Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading
Imports Microsoft.VisualBasic

Public Class rptRentalStatus
    Dim cn As SqlConnection
    Dim cn2 As SqlConnection
    Dim oCommand As SqlCommand
    Dim oCommand2 As SqlCommand
    Dim dr As SqlDataReader
    Dim dr2 As SqlDataReader
    Dim myDataset As New DataSet
    Dim LoadComplete As Boolean = False
    Dim myPanel As Panel = New System.Windows.Forms.Panel
    Dim MyIncLbl As Label = New System.Windows.Forms.Label
    Dim MyRevLbl As Label = New System.Windows.Forms.Label
    Dim MyUnitLbl As Label = New System.Windows.Forms.Label



    Private Sub rptRentalStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'BuildControls() 'This builds an array of controls on call from data.
        Dim strSql2 As String = "Select distinct jnlActivity from tblDRJournal where jnlActivity in (SELECT ActivityDescription  FROM tblActivity where ActivityType = 'RENTAL' )"
        cn2 = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql2, cn2)
        cn2.Open()
        DR2 = oCommand.ExecuteReader
        'While 
        dr2.Read()
        BuildControls()
        MyUnitLbl.Text = dr2(0)
        Dim strSql As String = "Select sum(jnlTranAmount) as ExpAmount, 0 as IncAmount from tblDRJournal "
        strSql += " where jnlactivity = '710 Rental' and  left(ltrim(str(jnlActNum)),1) > 6"
        strSql += " Union Select 0 as ExpAmount, sum(jnlTranAmount) as IncAmount from tblDRJournal where jnlactivity = '710 Rental' and  left(ltrim(str(jnlActNum)),1) < 6 "
        cn = New SqlConnection(ConfigurationManager.ConnectionStrings("MorrisDevStr").ConnectionString.ToString)
        oCommand = New SqlCommand(strSql, cn)
        cn.Open()
        dr = oCommand.ExecuteReader()
        dr.Read()
        MyRevLbl.Text = Format(dr(0), "C")
        dr.Read()
        MyIncLbl.Text = Format(dr(1), "C")
        dr.Close()
        cn.Close()
        'End While

    End Sub
    Sub BuildControls()
        Dim intx As Integer = 2
        Dim x As String = intx.ToString()
        myPanel.Name = "Panel" & x
        myPanel.Location = New System.Drawing.Point(254, 101)
        myPanel.Size = New System.Drawing.Size(248, 125)
        myPanel.BackColor = Color.White
        myPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D

        'Dim LblInc2 As Label = New System.Windows.Forms.Label
        MyIncLbl.Name = "LabelI" & x
        MyIncLbl.AutoSize = True
        MyIncLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyIncLbl.Location = New System.Drawing.Point(26, 74)
        MyIncLbl.Size = New System.Drawing.Size(15, 16)
        MyIncLbl.TabIndex = 1


        'Dim lblExp2 As Label = New System.Windows.Forms.Label
        MyRevLbl.Name = "LabelR" & x
        MyRevLbl.AutoSize = True
        MyRevLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyRevLbl.Location = New System.Drawing.Point(138, 74)
        MyRevLbl.Size = New System.Drawing.Size(15, 16)
        MyRevLbl.TabIndex = 2



        Dim lblUnit2 As Label = New System.Windows.Forms.Label
        MyUnitLbl.Name = "LabelU" & x
        MyUnitLbl.AutoSize = True
        MyUnitLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MyUnitLbl.Location = New System.Drawing.Point(57, 25)
        MyUnitLbl.Name = "lblUnit"
        MyUnitLbl.Size = New System.Drawing.Size(98, 18)
        MyUnitLbl.TabIndex = 0
        MyUnitLbl.Text = "PROPERTY"

        Dim LblRight2 As Label = New System.Windows.Forms.Label
        LblRight2.AutoSize = True
        LblRight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblRight2.Location = New System.Drawing.Point(127, 56)
        LblRight2.Name = "Label2"
        LblRight2.Size = New System.Drawing.Size(81, 18)
        LblRight2.TabIndex = 2
        LblRight2.Text = "Expenses"
        '
        'Label2
        '
        Dim LblLeft2 As Label = New System.Windows.Forms.Label
        LblLeft2.AutoSize = True
        LblLeft2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblLeft2.Location = New System.Drawing.Point(13, 56)
        LblLeft2.Name = "Label1"
        LblLeft2.Size = New System.Drawing.Size(82, 18)
        LblLeft2.TabIndex = 1
        LblLeft2.Text = "Revenues"

        myPanel.Controls.Add(MyIncLbl)
        myPanel.Controls.Add(MyRevLbl)
        myPanel.Controls.Add(MyUnitLbl)
        myPanel.Controls.Add(LblLeft2)
        myPanel.Controls.Add(LblRight2)
        Panel1.Visible = False
        Me.Controls.Add(myPanel)
    End Sub



End Class