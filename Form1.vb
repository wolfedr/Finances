Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form1
    Inherits System.Windows.Forms.Form

    'Private dataGridView2 As New DataGridView()
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private WithEvents reloadButton As New Button()
    Private WithEvents submitButton As New Button()

    <STAThreadAttribute()> _
    Public Shared Sub Main()
        Application.Run(New Form1())
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load
        rbAll.Checked = True

        ' Bind the DataGridView to the BindingSource 
        ' and load the data from the database. 
        Me.DataGridView2.DataSource = Me.bindingSource1

        GetData()

    End Sub


    Private Sub GetData()

        Dim strSql As String = "select * from tblDRTransactions"
        If Not rbAll.Checked Then
            strSql += " where bnkPostedToJournal = '0'"
        End If
        strSql += " Order by bnkTranPostDate Desc"
        Dim cn As SqlConnection
        Dim selectCommand As String = strSql
        Try
            cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
            Me.dataAdapter = New SqlDataAdapter(selectCommand, cn)
            ' Create a command builder to generate SQL update, insert, and 
            ' delete commands based on selectCommand. These are used to 
            ' update the database. 
            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
            ' Populate a new data table and bind it to the BindingSource. 
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table

            ' Resize the DataGridView columns to fit the newly loaded content. 
            Me.DataGridView2.AutoResizeColumns( _
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("To run this example, replace the value of the " + _
                "connectionString variable with a connection string that is " + _
                "valid for your system.")
        End Try

    End Sub

   
    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        ' Reload the data from the database.
        GetData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Update the database with the user's changes. 
        Me.dataAdapter.Update(CType(Me.bindingSource1.DataSource, DataTable))

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAll.CheckedChanged

    End Sub
End Class
