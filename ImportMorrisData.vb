Imports System.IO
Imports System.Data
Imports System.Configuration
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class ImportMorrisData

    Structure HeaderTrx
        Dim dtStart As String
        Dim dtEnd As String
        Dim acct As String
    End Structure

    Structure DataTrx
        Dim bankAccount As String
        Dim trnType As String
        Dim dtPosted As Date
        Dim trnAmt As String
        Dim fitId As String
        Dim chkNum As Int32
        Dim trnRefNum As String
        Dim trnName As String
        Dim trnMemo As String
        Dim trnPostFlag As String
    End Structure

    Dim myCommand As SqlCommand
    Dim aCommand As SqlCommand
    Dim dr As SqlDataReader
    Public struHeader As HeaderTrx
    Dim gblAccountNum As String
    Dim cn As SqlConnection
    Dim loadComplete As Boolean = False

    Private Sub ImportMorris_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label3.Visible = False
        ddlBank.Visible = False
        lblForlbl.Visible = False
        txtCntW.Visible = False
        txtCntPas.Visible = False
        lblRecCnt.Visible = False
        btnStartMorris.Visible = False
        lblStartMorris.Visible = False
        grpImportActions.Visible = True

        Dim strSql As String = "Select actNum, actBank, actName from tblBankAcct where actStatus = 'A' order by actName "
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        aCommand = New SqlCommand(strSql, cn)
        dr = aCommand.ExecuteReader()
        Dim aryBank As ArrayList = New ArrayList
        aryBank.Add(New AddValue("Select Account to Import Data From!", 0))
        While dr.Read()
            Dim x As String = dr.GetString(2) & " (" & dr.GetInt64(0).ToString & ") " & dr.GetString(1)
            Dim y As String = dr.GetInt64(0)
            ' gblBusID = dr.GetInt64(0)
            aryBank.Add(New AddValue(x, dr.GetInt64(0)))
        End While
        dr.Close()
        cn.Close()
        ddlBank.DisplayMember = "Display"
        ddlBank.ValueMember = "Value"
        ddlBank.DataSource = aryBank
        loadComplete = True
    End Sub

    Private Sub btnStartImportClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartMorris.Click
        'Quicken Imports\  
        Dim myDrive As String = Environment.CurrentDirectory
        Dim strFileAndPath As String = hdnFileAndPath.Text
        Dim strFile As String = lblFileName.Text
        Dim intStopLoc As Integer = InStr(strFile, "_")
        Dim strRootDir As String = ConfigurationManager.AppSettings("DIR")
        Dim strExt As String = Microsoft.VisualBasic.Right(strFile, 3)
        If Directory.Exists(strRootDir) = False Then
            Directory.CreateDirectory(strRootDir)
        End If
        Dim strArchiveDir As String = strRootDir & "\Archive"

        If Directory.Exists(strArchiveDir) = False Then
            Directory.CreateDirectory(strArchiveDir)
        End If

        If Len(strFileAndPath) > 0 Then
            Dim dteNow As Date = Today()
            Dim strFilePrefix As String
            strFilePrefix = dteNow.Month & dteNow.Day & dteNow.Year
            If UCase(strExt) = "TXT" Then
                If ManageTXTData(strFileAndPath) Then
                    Dim FileToMove As String = strFileAndPath
                    'get file nname
                    Dim MoveLocation As String = strArchiveDir & "\" & strFilePrefix & "_" & strFile
                    If System.IO.File.Exists(FileToMove) = True Then
                        System.IO.File.Move(FileToMove, MoveLocation)
                        MsgBox("Data Imported. File Archived.")
                    End If
                    'Reset names so they don't duplicate. 9/25/2011
                    lblFileName.Text = ""
                    hdnFileName.Text = ""
                End If

            Else
                MessageBox.Show("Improper FIle Name file to import", "Import Error", MessageBoxButtons.OK)
            End If

        Else
ErrorExisits: ErrorExists("You must select a file to import")
        End If
    End Sub
    Function ErrorExists(ByVal strErr As String) As Boolean
        MessageBox.Show(strErr, "Import Error", MessageBoxButtons.OK)
        Return ErrorExists
    End Function

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = ConfigurationManager.AppSettings("DIR")
        OpenFileDialog1.Filter = "Quicken Files (*.qfx or qif)|*.qfx;*.qif"     'Word (*.doc) |*.doc;*.rtf|(*.txt) |*.txt|(*.*) |*.*"
        OpenFileDialog1.ShowDialog()
    End Sub
    

    Private Function ManageTXTData(ByVal strPath As String) As Boolean
        On Error GoTo HandleMe
        Dim recCnt As Integer = 0
        Dim pasCnt As Integer = 0
        Dim TextLine As String = ""
        Dim objReader As New System.IO.StreamReader(strPath)
        Dim strDataLine As String = ""
        Dim intReadCount As Int32 = 0
        Dim struTrans As New DataTrx
        Dim strReadCount As Int32 = 0
        Dim strTestx As String
        Dim dteTestx As Date
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        Dim intCheckCOunt As Integer = 0
        Dim intTesty As Integer
        objReader.Peek()
        objReader.Peek()
        Dim actAry() As String
        Dim tempDat As String

        Do While objReader.Peek() <> -1
            intCheckCOunt += 1
            struTrans = New DataTrx
            TextLine = objReader.ReadLine()
            TextLine = CleanDBEntry(TextLine)
            If Len(TextLine) > 1 Then
                TextLine = TextLine.Replace(Chr(34), "")
                TextLine = TextLine.Replace(Chr(38), "")
                Dim datArray() As String
                datArray = TextLine.Split(",")
                Dim myCnt As Integer = datArray.Length
                '0 is account
                '1 is date and time and sequence-Can be used for FITID
                '2 is Credit or Debit indicator
                '3 Transaction Type Indicator
                '4 Check Number
                '5 amount
                '6 Chunk-Transaction Name and Business name
                'Assign account number
                If datArray(4).Length = 0 Then datArray(4) = "0"
                struTrans.bankAccount = datArray(0)
                '****Assign the date to the structure
                'Dim testx As String = datArray(1).Substring(0, 10)
                struTrans.dtPosted = Convert.ToDateTime(datArray(1).Substring(0, 10))
                'Assign FITID after removing all non numneric characters
                datArray(1) = datArray(1).Replace(Chr(58), "")   ':
                datArray(1) = datArray(1).Replace(Chr(46), "")         '.
                datArray(1) = datArray(1).Replace(Chr(84), "")         'T
                datArray(1) = datArray(1).Replace(Chr(45), "")         '-
                struTrans.fitId = datArray(1)

                '****Assign the amount to the structure
                Select Case UCase(datArray(2))
                    Case "DEBIT"
                        struTrans.trnAmt = "-" & datArray(5).Trim
                    Case "CREDIT"
                        struTrans.trnAmt = datArray(5).Trim
                    Case "CHECKS PAID"
                        struTrans.chkNum = datArray(4)
                        struTrans.trnAmt = "-" & datArray(5).Trim
                    Case Else
                End Select
                'Get Morris type code for later use in verifying duplicates
                Dim MorrisCode As String = datArray(3)
                'Get tran type to guids parsing
                struTrans.trnMemo = datArray(6)
                struTrans.trnType = TranTypeCode(datArray(3), datArray(0), datArray(6))
                struTrans.trnPostFlag = "0"
                If InStr("EQUITYTRANSFERXFERDONATIONINTERNALTRANSFER", struTrans.trnType) Then 'These are all itnernal transacions.
                    struTrans.trnName = "MORRIS"
                Else
                    struTrans.trnName = GetBusinessName(datArray(6), datArray(3))
                End If
                strReadCount += 1
                Dim Sql As String = "Insert into tblDRTransactions(bnkActID, bnkTranType,"
                Sql += " bnkTranPostDate, bnkTranAmt, bnkTranFTID, bnkTranCheckNum, bnkTranName, bnkTranRefNum, bnkTranMemo, bnkPostedToJournal,timestamp) values ("
                Sql += struTrans.bankAccount & ", "
                Sql += "'" & struTrans.trnType & "', "
                Sql += "'" & struTrans.dtPosted & "', "
                Sql += "" & struTrans.trnAmt & ", "
                Sql += "'" & struTrans.fitId & "', "
                Sql += "" & struTrans.chkNum & ", "
                Sql += "'" & struTrans.trnName & "', "
                Sql += "'" & struTrans.trnRefNum & "', "
                Sql += "'" & struTrans.trnMemo & "', "
                Sql += "'" & struTrans.trnPostFlag & "', "
                Sql += "'" & Now() & "') "
                'Check that this is not a previous transacton
                'Dim sql12 As String = "Select count(*) from tblDRTransactions where bnkTranFTID = " & struTrans.fitId & " and bnkActID = " & struTrans.bankAccount

                Dim sql2 As String = "Select count(*) from tblDRTransactions where "
                sql2 += "Left(CAST(bnkTranFTID as varchar(max)),8) = '" & struTrans.fitId.Substring(0, 8) & "' "
                sql2 += "and bnkActID = " & struTrans.bankAccount & " "
                sql2 += "and abs(bnkTranAmt) = " & Math.Abs(Convert.ToDecimal(struTrans.trnAmt))
                sql2 += " and bnkTranCheckNum = " & struTrans.chkNum
                aCommand = New SqlCommand(sql2, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                Dim xcount As Integer = Convert.ToInt32(aCommand.ExecuteScalar())
                If xcount = 0 Then
                    recCnt += 1
                    myCommand = New SqlCommand(Sql, cn)
                    myCommand.ExecuteNonQuery()
                Else
                    'Stop
                    pasCnt += 1
                    recCnt += 0
                End If
            End If
ForceLoop:  ClearStructure(struTrans)
        Loop
        cn.Close()
        objReader.Close()
        txtCntW.Text = recCnt.ToString
        txtCntPas.Text = pasCnt.ToString
        txtCntW.Visible = True
        txtCntPas.Visible = True
        lblRecCnt.Visible = True 'Without this close the applicaton defaults and can not move the file to archive
        Return True
        Exit Function
HandleMe:
        MessageBox.Show("ERROR: " & Err.Description, "Load Errors", MessageBoxButtons.OK)
    End Function
    Function GetBusinessName(ByRef strIn As String, ByVal strType As String) As String
        If InStr("EQUITYTRANSFERXFERDONATIONINTERNALTRANSFER", strType) Then
            Return "MORRIS"
        End If

        Dim strReturn As String = ""
        Dim strSQl As String = "select distinct busName, busLeftName from tblBusiness"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        aCommand = New SqlCommand(strSQl, cn)
        dr = aCommand.ExecuteReader()
        While dr.Read
            Dim myStr As String = dr(0)
            Dim loc As Integer = -1
            Dim tstx As String = dr(0).ToString.ToUpper
            Dim tsty As String = strIn.ToUpper
            loc = InStr(strIn.ToUpper, dr(0).ToString.ToUpper)
            If loc > 0 Then 'See in busname string is in memo
                strReturn = dr(0)
                Exit While
            ElseIf InStr(strIn.ToUpper, dr(1).ToString.ToUpper) > 0 Then 'See if its left name is
                strReturn = dr(0)
                Exit While
            ElseIf InStr(strIn.ToUpper, dr(0).ToString.Replace(" ", "").ToUpper) > 0 Then 'See if its  name has space remove
                strReturn = dr(0)
                Exit While
            Else
            End If


        End While

        dr.Close()
        cn.Close()
        'End Select
        Return strReturn
    End Function

    Function TranTypeCode(ByVal inCode As String, ByVal bnkAct As String, ByVal Memo As String) As String
        Dim strBankAct As String = ""
        Select Case inCode
            Case "006", "6", "061", "61"    'Electronic credits + to hosting account(HA) Debits - to external account(EO)    (6) and debits  (61) - TO HOSTING ACCOUNT
                '++++++++++Determine external account++++++++++++

                If Memo.Contains("4000547000") Then
                    strBankAct = "4000547000"  'Equity 624

                ElseIf Memo.Contains("4000547200") Then
                    strBankAct = "4000547200"  'Equity 710

                ElseIf Memo.Contains("766712") Then
                    strBankAct = "766712"  'Doug Donationa

                ElseIf Memo.Contains("67121") Then
                    strBankAct = "67121"  'DR REntal

                ElseIf Memo.Contains("1250836") Then
                    strBankAct = "1250836"  'Fund Raising Savings

                ElseIf Memo.Contains("56855") Then
                    strBankAct = "56855"  ' General Operations
                Else
                    strBankAct = "0000000"
                End If

                If Memo.Contains("Internet transfer to checking") Then   'HA fund out to EO Checking
                    Return "INTERNALTRANSFER"   'Move withing bank

                ElseIf Memo.Contains("Internet transfer to savings") Then  'HA funds out to EO Savings
                    Return "INTERNALTRANSFER"   'Move within bank from transaction account to listed savings.

                ElseIf Memo.Contains("Internet transfer from savings") Then  'HA gets funds in from EO Savings
                    Return "INTERNALTRANSFER"   'Move within bank from transaction account to listed savings

                ElseIf Memo.Contains("Internet transfer from checking") Then   ' HA gets funds in from EO Checking 
                    Return "INTERNALTRANSFER"   'Move withing bank

                ElseIf Memo.Contains("Internet transfer from loan") Then   ' HA gets funds in from EO Checking 
                    Select Case strBankAct
                        Case "4000547000"
                            Return "EQUITYTRANSFER"   'This happens when a draw is made on a equity loan for 624
                        Case "4000547200"
                            Return "EQUITYTRANSFER"   'This happens when a draw is made on a equity loan for 710
                        Case "766712" 'Doug Personl
                            Return "XFERDONATION"   'This happens when a donation is recieved from Dougs personal account.
                        Case "67121", "766723", "56855", "1250836"  'DR RENTAL, Fundraising, 
                            Return "INTERNALTRANSFER"   'This happens when funds are simply moved from one active account to another 
                        Case Else
                            MessageBox.Show("Unknown Transaction Type Encountered. Transaction stored in database for review!", "", MessageBoxButtons.OK)
                    End Select

                ElseIf Memo.Contains("DEBIT TO LOAN") Then 'HA funds out to Equity account
                    Return "LOAN PAYMENT"   'This is likely an internal payment for interest or principle withdraw from a loan.
                Else
                    Return "POS"    'EFT/ACH DEBIT I
                End If

            Case "007", "7"
                Return "INT"   'INTEREST CREDIT
            Case "011", "11"
                Return "DEP"   'Regular Deposit
                'Case "031"  'This was only used on equipty accounts and for now we are ignoring them
                '    Return "PRINCIPAL DISBURSEMENT"   'Regular Deposit
            Case "033", "33"
                Return "MISCELLANEOUS INTEREST DEBIT"   'Regular Deposit
            Case "044", "44"
                Return "DEPOSITED ITEM CHARGE BACK"   'Regular Deposit
            Case "053", "53"
                Return "CHECK"      'Check Cashed
            Case "055", "55"
                Return "DEBIT"         'Misc Debit
            Case "056", "56"
                Return "SRVCHG"         'Service Charge

            Case "062", "62"
                Return "CHECK"  'Check paid.
            Case "063", "63"
                Return "CHECK"  'Check paid.
            Case "077", "77"
                Return "LOAN PAYMENT"  'Payment of loan. Can be a local bank debit
            Case "158"
                Return "OVERDRAFT"
            Case "161"
                Return "DIRECTDEBIT"  'ACH WITHDRAWL Paypal 
            Case "162"
                Return "DIRECTDEP" 'ACH DEPOSIT
            Case "181"
                Return "ATM" 'ATM ONUS WITHDRAWAL 
            Case "191"
                Return "POS" 'ATM/POS PURCHA 
            Case "193"
                Return "CREDIT" ',193,,3.89,ATM/POS RETURN 
            Case "194"
                Return "DIRECTDEBIT"  'VZWRLSS*PRPAY A
            Case Else   '
                Return "UNKNOWN"  'new code or no code.
                MessageBox.Show("Unknown Transaction Type Encountered. Transaction stored in database for review!", "", MessageBoxButtons.OK)

        End Select
        Return ""

    End Function

    Function ClearStructure(ByVal myStruct As DataTrx) As DataTrx
        myStruct.bankAccount = ""
        myStruct.chkNum = 0
        myStruct.dtPosted = Nothing
        myStruct.fitId = ""
        myStruct.trnAmt = 0
        myStruct.trnMemo = ""
        myStruct.trnRefNum = ""
        myStruct.trnType = ""
        Return myStruct
    End Function

    Function CleanDBEntry(ByVal strIn As String) As String
        Dim strEntry As String
        strEntry = strIn.Replace("'", "")
        Return strEntry
    End Function
   
    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        lblFileName.Visible = True
        lblFileName.Text += OpenFileDialog1.SafeFileName
        hdnFileAndPath.Text = OpenFileDialog1.FileName.ToString()
        lblFolderName.Text = OpenFileDialog1.InitialDirectory
        lblFileName.Visible = True
        lblFolderName.Visible = True
        lblForlbl.Visible = True
        lblFolder.Visible = True
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        baseform.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindCSV.Click
        btnStartMorris.Visible = True
        lblStartMorris.Visible = True
        OpenFileDialog1.Title = "Please Select a CSV File"
        OpenFileDialog1.InitialDirectory = ConfigurationManager.AppSettings("DIR")
        OpenFileDialog1.Filter = "Text Files|*.txt|Comma Delimited|*.csv" & "|All Files|*.*"
        OpenFileDialog1.FileName = hdnFileName.Text
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ddlBank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlBank.SelectedIndexChanged
        If loadComplete = True Then
            If ddlBank.SelectedIndex <> 0 Then   'This check keeps visibility from appearing when index is reset back to zero
                grpImportActions.Visible = True
            End If
            Dim strDate As String
            strDate = Today.Month & Today.Day & Today.Year
            Select Case ddlBank.SelectedValue
                Case 1010137561375
                    gblAccountNum = ddlBank.SelectedValue
                    hdnFileName.Text = strDate & "_Joint"
                Case 1941309997
                    gblAccountNum = ddlBank.SelectedValue
                    hdnFileName.Text = strDate & "_Doug"
                Case 1010253265762
                    gblAccountNum = ddlBank.SelectedValue
                    hdnFileName.Text = strDate & "_Jean"
                Case 56855
                    gblAccountNum = ddlBank.SelectedValue
                    hdnFileName.Text = strDate & "_DR"
                Case Else
                    gblAccountNum = "NONE"
                    hdnFileName.Text = "FILE NOT FOUND!"
            End Select
        End If
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'grpFileInfo.Visible = False
        'grpImportActions.Visible = False
        txtCntW.Visible = False
        txtCntPas.Visible = False
        lblRecCnt.Visible = False
        ddlBank.SelectedIndex = 0
    End Sub
End Class
