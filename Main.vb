
Imports System.IO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class Main
    Structure HeaderTrx
        Dim dtStart As String
        Dim dtEnd As String
    End Structure
    Structure DataTrx
        Dim bankAccount As String
        Dim trnType As String
        Dim dtPosted As DateTime
        Dim trnAmt As String
        Dim fitId As String
        Dim chkNum As Int32
        Dim trnRefNum As String
        Dim trnName As String
        Dim trnMemo As String
    End Structure

    Dim myCommand As SqlCommand
    Dim aCommand As SqlCommand
    Dim dr As SqlDataReader
    Public struHeader As HeaderTrx
    Public struTrans As DataTrx
    Dim cn As SqlConnection

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Interval = 50000

    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DoTimedWork()
    End Sub
    Sub DoTimedWork()
        Dim strFile As String = ConfigurationManager.AppSettings("FIL")
        Dim strRootDir As String = ConfigurationManager.AppSettings("DIR")
        Dim strArchiveDir As String = strRootDir & "\Archive"
        Dim strFileAndPath As String = strRootDir & "\" & strFile
        Dim xx As String = Date.Now.ToShortDateString.Replace("/", "") & " " & Date.Now.ToShortTimeString.Replace(":", "")
        Dim MoveLocation As String = strArchiveDir & "\" & Date.Now.ToShortDateString.Replace("/", "") & " " & Date.Now.ToShortTimeString.Replace(":", "") & strFile
        If Directory.Exists(strRootDir) = True Then
            If File.Exists(strFileAndPath) Then
                If ManageMorrisData(strFileAndPath) Then
                    Dim FileToMove As String = strFileAndPath
                    If System.IO.File.Exists(FileToMove) = True Then
                        System.IO.File.Move(FileToMove, MoveLocation)
                        MsgBox("Data Imported. File Archived.")
                    End If
                End If
            End If
        End If

    End Sub
    Private Function ManageMorrisData(ByVal strPath As String) As Boolean
        Dim recCnt As Integer = 0
        Dim TextLine As String = ""
        Dim blnSkipFlag As Boolean = True
        Dim blnStartXMLRead As Boolean = False
        Dim blnReadingData As Boolean = False
        Dim intDateUpcount As Integer = 0
        Dim objReader As New System.IO.StreamReader(strPath)
        Dim strDataLine As String = ""
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        Do While objReader.Peek() <> -1
            TextLine = objReader.ReadLine()
            If TextLine = "<OFX>" Then blnStartXMLRead = True 'This line starts to read the data.
            If blnSkipFlag = True Then 'This skips reading the header and bank info.
                If blnStartXMLRead = True Then 'This starts reading the data in XML Like tags.
                    If intDateUpcount < 2 Then
                        Select Case parseLeader(TextLine)
                            Case "DTSTART"
                                struHeader.dtStart = parseTrailer(TextLine)
                                intDateUpcount += 1
                            Case "DTEND"
                                struHeader.dtEnd = parseTrailer(TextLine)
                                intDateUpcount += 1
                            Case Else
                        End Select

                    Else
                        blnSkipFlag = False
                    End If
                End If
            Else
                'Here is where we start parsing the transactional data.
                If parseTrailer(TextLine) <> "STMTTRN" And parseTrailer(TextLine) <> "/STMTTRN" Then
                    Select Case parseLeader(TextLine)
                        Case "TRNTYPE"
                            struTrans.trnType = parseTrailer(TextLine)
                        Case "DTPOSTED"
                            Dim strTemp As String = parseTrailer(TextLine)
                            Dim iYear As Int32 = Convert.ToInt32(strTemp.Substring(0, 4))
                            Dim iMonth As Int32 = Convert.ToInt32(strTemp.Substring(4, 2))
                            Dim iDAy As Int32 = Convert.ToInt32(strTemp.Substring(6, 2))
                            struTrans.dtPosted = New DateTime(iYear, iMonth, iDAy)

                        Case "TRNAMT"
                            struTrans.trnAmt = parseTrailer(TextLine)
                        Case "CHECKNUM"
                            If Len(parseTrailer(TextLine)) = 0 Then
                                struTrans.chkNum = 0
                            Else
                                struTrans.chkNum = Convert.ToInt32(parseTrailer(TextLine))
                            End If
                        Case "FITID"
                            struTrans.fitId = parseTrailer(TextLine)
                        Case "REFNUM"
                            struTrans.trnRefNum = parseTrailer(TextLine)
                        Case "NAME"
                            struTrans.trnName = parseTrailer(TextLine)
                        Case "MEMO"
                            struTrans.trnMemo = parseTrailer(TextLine)
                        Case Else
                    End Select
                End If
                'Prepare to add these items to the database

                'This means end of record line of data. Save the sturcture and do another one.
                'strTest = parseLeader(TextLine)

                If parseLeader(TextLine) = "/STMTTRN" Then
                    'recCnt += 1
                    'txtCntW.Text = recCnt.ToString()
                    Dim Sql As String = "Insert into tblMorrisTransactions(bnkActID, bnkTranType,"
                    Sql += " bnkTranPostDate, bnkTranAmt, bnkTranFTID, bnkTranCheckNum, bnkTranName, bnkTranRefNum, bnkTranMemo) values ('1010253265762',"
                    Sql += "'" & struTrans.trnType & "', "
                    Sql += "'" & struTrans.dtPosted & "', "
                    Sql += "" & struTrans.trnAmt & ", "
                    Sql += "'" & struTrans.fitId & "', "
                    Sql += "" & struTrans.chkNum & ", "
                    Sql += "'" & struTrans.trnName & "', "
                    Sql += "'" & struTrans.trnRefNum & "', "
                    Sql += "'" & struTrans.trnMemo & "') "

                    If cn.State = ConnectionState.Closed Then
                        cn.Open()
                    End If
                    Dim sql2 As String = "Select count(*) from tblMorrisTransactions where bnkTranFTID = " & struTrans.fitId
                    aCommand = New SqlCommand(sql2, cn)
                    Dim xcount As Integer = Convert.ToInt32(aCommand.ExecuteScalar())
                    If xcount = 0 Then
                        recCnt += 1
                        myCommand = New SqlCommand(Sql, cn)
                        myCommand.ExecuteNonQuery()
                    End If
                    struTrans = New DataTrx
                End If
            End If
        Loop
        cn.Close()
        objReader.Close()
        'txtCntW.Visible = True
        'lblRecCnt.Visible = True 'Without this close the applicaton defaults and can not move the file to archive
        Return True
    End Function
    Private Function parseTrailer(ByVal strLeader As String) As String
        strLeader = strLeader.Replace("'", "")
        Dim intBrkt As Integer = strLeader.LastIndexOf(">")
        Dim intLen As Integer = strLeader.Length
        Return strLeader.Substring(intBrkt + 1, intLen - (intBrkt + 1))
    End Function

    Private Function parseLeader(ByVal strLeader As String) As String
        Dim intBrkt As Integer = strLeader.LastIndexOf(">")
        Return strLeader.Substring(1, intBrkt - 1)
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DoTimedWork()
    End Sub

    
End Class
