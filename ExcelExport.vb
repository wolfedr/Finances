
Imports Excel = Microsoft.Office.Interop.Excel
Module ExportToExcel_Raw
    ''' <summary>
    ''' Creates a simple MS-Excel spreadsheet from data residing in a DataGridView
    ''' </summary>
    ''' <param name="TheGrid">DataGridView currently with data</param>
    ''' <param name="FileName">Path and filename to write an excel wookbook too</param>
    ''' <remarks>
    ''' REQUIRES CHANGE IN TRY/CATCH FOR USE IN APPLICATIONS AS PER COMMENTS IN THE CATCH.
    ''' </remarks>
    Public Sub ExportGridToExcel(ByVal TheGrid As DataGridView, ByVal FileName As String)
        If TheGrid.DataSource Is Nothing Then
            Throw New Exception("No data to work with")
        End If

        Try
            Dim fs As New IO.StreamWriter(FileName, False)
            fs.WriteLine("<?xml version=""1.0""?>")
            fs.WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            fs.WriteLine("<ss:Workbook xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")
            fs.WriteLine("    <ss:Styles>")
            fs.WriteLine("        <ss:Style ss:ID=""1"">")
            fs.WriteLine("           <ss:Font ss:Bold=""1""/>")
            fs.WriteLine("        </ss:Style>")
            fs.WriteLine("    </ss:Styles>")
            fs.WriteLine("    <ss:Worksheet ss:Name=""Sheet1"">")
            fs.WriteLine("        <ss:Table>")
            For x As Integer = 0 To TheGrid.Columns.Count - 1
                fs.WriteLine("            <ss:Column ss:Width=""{0}""/>", TheGrid.Columns.Item(x).Width)
            Next
            fs.WriteLine("            <ss:Row ss:StyleID=""1"">")
            For i As Integer = 0 To TheGrid.Columns.Count - 1
                fs.WriteLine("                <ss:Cell>")
                fs.WriteLine(String.Format("                   <ss:Data ss:Type=""String"">{0}</ss:Data>", TheGrid.Columns.Item(i).HeaderText))
                fs.WriteLine("                </ss:Cell>")
            Next
            fs.WriteLine("            </ss:Row>")
            For intRow As Integer = 0 To TheGrid.RowCount - 2
                fs.WriteLine(String.Format("            <ss:Row ss:Height =""{0}"">", TheGrid.Rows(intRow).Height))
                For intCol As Integer = 0 To TheGrid.Columns.Count - 1
                    fs.WriteLine("                <ss:Cell>")
                    fs.WriteLine(String.Format("                   <ss:Data ss:Type=""String"">{0}</ss:Data>", TheGrid.Item(intCol, intRow).Value.ToString))
                    fs.WriteLine("                </ss:Cell>")
                Next
                fs.WriteLine("            </ss:Row>")
            Next
            fs.WriteLine("        </ss:Table>")
            fs.WriteLine("    </ss:Worksheet>")
            fs.WriteLine("</ss:Workbook>")
            fs.Close()
            fs.Dispose()
        Catch ex As Exception
            '  For demoing I am simply telling you we had a problem, in a real application
            '  we at least remove the MsgBox and uncomment the next line. What should also
            '  be considered is not using --> Throw new exception... because now the exception
            '  points to the line with that statement rather then the original problem.
            '
            '
            MsgBox(ex.Message)
            'Throw 
        End Try


        OpenExcelFile(FileName)
        Application.DoEvents()
    End Sub
    ''' <summary>
    ''' Opens a file with the Association under Shell in the system registry
    ''' </summary>
    ''' <param name="FileName">Opens file by shell association</param>
    ''' <remarks></remarks>
    Private Sub OpenExcelFile(ByVal FileName As String)
        If System.IO.File.Exists(FileName) Then
            Process.Start(FileName)
        End If
    End Sub

    

End Module
