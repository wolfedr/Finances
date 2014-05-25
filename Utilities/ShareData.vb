Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Linq

Public Class ShareData
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader

    Private Sub ShareData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

    End Sub

    Function GetData() As String


        Return ""
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim upcount As Integer = 0
        Dim reader As SqlDataReader
        Dim expDate As String = dte.Text
        Dim strRootDir As String = ConfigurationManager.AppSettings("DIR") & "\ShareData\"
        If Directory.Exists(strRootDir) = False Then
            Directory.CreateDirectory(strRootDir)
        End If
        '************************************************
        'Export Journal Transactions
        Dim strFilePrefix As String = Now.Month & Now.Day & Now.Year & "_JNL_Export.csv"
        Dim strPath As String = strRootDir & strFilePrefix
        Dim strSql As String = "Select * from tblDRJournal where jnlTranDate > '" & expDate & "'"
        'cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisTestStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Using stream = New StreamWriter(strPath)
            Using cn
                Using oCommand
                    reader = oCommand.ExecuteReader()
                    While reader.Read()
                        '*****************************************
                        'Do not export the primary key jnlID. First column is jnlLink
                        stream.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7},{8}, {9}, {10}, {11},{12}, {13}, {14}, {15}, {16},{17}", _
                        CheckDBNull(Of String)(reader(1)), _
                        CheckDBNull(Of Int32)(reader(2)), _
                        CheckDBNull(Of Int32)(reader(3)), _
                        CheckDBNull(Of Int32)(reader(4)), _
                        CheckDBNull(Of Date)(reader(5)), _
                        CheckDBNull(Of String)(reader(6)), _
                        CheckDBNull(Of Decimal)(reader(7)), _
                        CheckDBNull(Of String)(reader(8)), _
                        CheckDBNull(Of String)(reader(9)), _
                        CheckDBNull(Of Int32)(reader(10)), _
                        CheckDBNull(Of Int32)(reader(11)), _
                        CheckDBNull(Of String)(reader(12)), _
                        CheckDBNull(Of Date)(reader(13)), _
                        CheckDBNull(Of Int32)(reader(14)), _
                        CheckDBNull(Of String)(reader(15)), _
                        CheckDBNull(Of Boolean)(reader(16)), _
                        CheckDBNull(Of String)(reader(17)), _
                        CheckDBNull(Of Boolean)(reader(18))))
                        upcount += 1
                    End While

                End Using
            End Using
        End Using
        cn.Close()
        MessageBox.Show("You Exported " & upcount & "records to file " & strPath & ".", "Notice", MessageBoxButtons.OK)

        'Export Bank Transactions
        upcount = 0
        strFilePrefix = Now.Month & Now.Day & Now.Year & "_BNK_Export.csv"
        strPath = strRootDir & strFilePrefix
        strSql = "Select * from tblDRTransactions where bnkTranPostDate > '" & expDate & "'"
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        Using stream = New StreamWriter(strPath)
            Using cn
                Using oCommand
                    reader = oCommand.ExecuteReader()
                    While reader.Read()
                        '*****************************************
                        'Do not export the primary key jnlID. First column is jnlLink
                        stream.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7},{8}, {9}, {10}", _
                        CheckDBNull(Of Int32)(reader(1)), _
                        CheckDBNull(Of String)(reader(2)), _
                        CheckDBNull(Of Date)(reader(3)), _
                        CheckDBNull(Of Decimal)(reader(4)), _
                        CheckDBNull(Of Int64)(reader(5)), _
                        CheckDBNull(Of Int32)(reader(6)), _
                        CheckDBNull(Of String)(reader(7)), _
                        CheckDBNull(Of String)(reader(8)), _
                        CheckDBNull(Of String)(reader(9)), _
                        CheckDBNull(Of Boolean)(reader(10)), _
                        CheckDBNull(Of Date)(reader(11))))
                        upcount += 1
                    End While

                End Using
            End Using
        End Using

        cn.Close()
        cn.Dispose()
        MessageBox.Show("You Exported " & upcount & "records. " & vbCrLf & "File location " & strRootDir & "." & vbCrLf & "Name: " & strFilePrefix, "Notice", MessageBoxButtons.OK)





    End Sub


    Public Shared Function CheckDBNull(Of T)(ByVal pReaderVar As Object) As T
        If pReaderVar.Equals(DBNull.Value) Then
            ' Value is null, determine the return type for a default
            If GetType(T).Equals(GetType(String)) Then
                Return CType(CType("", Object), T)
            ElseIf GetType(T).Equals(GetType(Nullable(Of DateTime))) Then
                'Return CType(CType(New Nullable(Of DateTime), Object), T)
                Return CType(CType("1/1/1901 12:00:00 AM", Object), T)
            ElseIf GetType(T).Equals(GetType(Boolean)) Then
                Return CType(CType(0, Object), T)
            Else
                ' If it's anything else just return nothing
                Return Nothing
            End If
        Else
            ' Cast the value into the correct return type
            Return CType(pReaderVar, T)
        End If
    End Function

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim upcount As Integer = 0
        Dim reader As SqlDataReader
        Dim recCount As Integer = 1
        Dim expDate As String = dte.Text
        Dim strInFileAndPath As String = ""
        strInFileAndPath = lblFolder.Text.Trim & "\" & lblFileName.Text.Trim
        Dim txtLine As String = ("x,y,z")
        '**********************************************
        'Import Journal Transactions
        Dim strFilePrefix As String = Now.Month & Now.Day & Now.Year & "_JNL_Export.csv"
        Dim strSqlchk As String = "Select max(timestamp) from tblDRJournal"
        Dim strSql As String = "SELECT MAX(jnlTranDate) FROM tblDRJournal"
        'cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisTestStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        reader = oCommand.ExecuteReader()
        reader.Read()
        Dim topTSDate As Date = reader(0)
        'reader.Read()
        'Dim topTranDate As Date = CType(reader(0), Date)
        reader.Close()
        'cn.Close()
        Dim myDate As DateTime
        'If the record was already imported the tran date will be more or equal so dont do it again.
        'If a new tran date but the 
        Dim strSqlDup As String = ""



        Using stream As StreamReader = New StreamReader(strInFileAndPath)
            While Not stream.EndOfStream
                txtLine = stream.ReadLine
                recCount = 1  'reset to indicate duplicate to bypass insert on null data
                If Not String.IsNullOrEmpty(txtLine) Then
                    strSql = ""
                    Dim aryLine As String() = txtLine.Split(",")
                    'GoTo skipHere
                    myDate = CheckDBNull(Of Date)(aryLine(12))
                    'Get only if the time stamp is newer than records already imported
                    'If myDate >= topTSDate Then
                    strSql = "insert into tblDRJournal ("
                    strSql += "jnlLink, jnlActID, jnlActNum,jnlActSeq,jnlTranDate,jnlTranType,jnlTranAmount,jnlTranDesc,jnlTranMemo, jnlTranBusinessID,"
                    strSql += "jnlBankTranID,jnlBankAct,timestamp,jnlActivityID, jnlActivity,jnlHaveReceipt,Externalmark,jnlActive) Values ("
                    strSql += "'" & aryLine(0) & "',"
                    strSql += "'" & aryLine(1) & "',"
                    strSql += "'" & aryLine(2) & "',"
                    strSql += "'" & aryLine(3) & "',"
                    strSql += "'" & aryLine(4) & "',"
                    strSql += "'" & aryLine(5) & "',"
                    strSql += "'" & aryLine(6) & "',"
                    strSql += "'" & aryLine(7) & "',"
                    strSql += "'" & aryLine(8) & "',"
                    strSql += "" & aryLine(9) & ","
                    strSql += "" & aryLine(10) & ","
                    strSql += "'" & aryLine(11) & "',"
                    strSql += "'" & CheckDBNull(Of Date)(aryLine(12)) & "',"
                    strSql += "" & aryLine(13) & ","
                    strSql += "'" & aryLine(14) & "',"
                    Dim x As String = aryLine(15).ToString.Trim()
                    If x = "False" Then
                        strSql += "0,"
                    Else
                        strSql += "1,"
                    End If
                    strSql += "'NA',"  'This field is External Mark and it needs to be eliminated
                    x = aryLine(17)
                    If x = "False" Then
                        strSql += "0)"
                    Else
                        strSql += "1)"
                    End If
                    'Section to verify no duplicate in destination table
                    strSqlDup = "Select count(*) from tblDRJournal where "
                    strSqlDup += "jnlTranDate = '" & CheckDBNull(Of Date)(aryLine(4)) & "' and "
                    strSqlDup += "jnlBankTranID = " & CheckDBNull(Of Int32)(aryLine(10)) & " and "
                    strSqlDup += "jnlTranAmount = " & CheckDBNull(Of Decimal)(aryLine(6))
                    oCommand = New SqlCommand(strSqlDup, cn)
                    recCount = oCommand.ExecuteScalar()


                End If
                '*****************************************************
               
skipHere:       If recCount = 0 Then
                    oCommand = New SqlCommand(strSql, cn)
                    reader = oCommand.ExecuteReader()
                    reader.Close()
                End If
            End While
        End Using
        If cn.State = ConnectionState.Open Then cn.Close()
        MessageBox.Show("You Imported " & upcount & "records to file " & strFilePrefix & ".", "Notice", MessageBoxButtons.OK)
        ''Export Bank Transactions
        'upcount = 0
        'strFilePrefix = Now.Month & Now.Day & Now.Year & "_BNK_Export.csv"
        'strPath = strRootDir & strFilePrefix
        'strSql = "Select * from tblDRTransactions where bnkTranPostDate > '" & expDate & "'"
        'cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        'oCommand = New SqlCommand(strSql, cn)
        'cn.Open()
        'Using stream = New StreamWriter(strPath)
        '    Using cn
        '        Using oCommand
        '            reader = oCommand.ExecuteReader()
        '            While reader.Read()
        '                '*****************************************
        '                'Do not export the primary key jnlID. First column is jnlLink
        '                stream.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7},{8}, {9}, {10}", _
        '                CheckDBNull(Of Int32)(reader(1)), _
        '                CheckDBNull(Of String)(reader(2)), _
        '                CheckDBNull(Of Date)(reader(3)), _
        '                CheckDBNull(Of Decimal)(reader(4)), _
        '                CheckDBNull(Of Int64)(reader(5)), _
        '                CheckDBNull(Of Int32)(reader(6)), _
        '                CheckDBNull(Of String)(reader(7)), _
        '                CheckDBNull(Of String)(reader(8)), _
        '                CheckDBNull(Of String)(reader(9)), _
        '                CheckDBNull(Of Boolean)(reader(10)), _
        '                CheckDBNull(Of Date)(reader(11))))
        '                upcount += 1
        '            End While

        '        End Using
        '    End Using
        'End Using
        'MessageBox.Show("You Imported " & upcount & "records. " & vbCrLf & "File location " & strInFileAndPath & "." & vbCrLf & "Name: " & strFilePrefix, "Notice", MessageBoxButtons.OK)
    End Sub

    Private Sub btnOpen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = ConfigurationManager.AppSettings("DIR2")
        OpenFileDialog1.Filter = "Exported Files (*.csv)|*.csv|All Files(*.*)|*.*"     'Word (*.doc) |*.doc;*.rtf|(*.txt) |*.txt|(*.*) |*.*"
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'lblFileName.Visible = True
        lblFileName.Text += OpenFileDialog1.SafeFileName
        'hdnFileAndPath.Text = OpenFileDialog1.FileName.ToString()
        lblFolder.Text = OpenFileDialog1.InitialDirectory
        'lblFileName.Visible = True
        'lblFolderName.Visible = True
        'lblForlbl.Visible = True
        'lblFolder.Visible = True
    End Sub
End Class
