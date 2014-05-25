<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiblingCheck
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiblingCheck))
        Me.gvBusiness = New System.Windows.Forms.DataGridView
        Me.txtSiblingID = New System.Windows.Forms.TextBox
        Me.txtNewListedName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCommonBusName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAcceptMatch = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblGridInstructions = New System.Windows.Forms.RichTextBox
        Me.hdnActID = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblGrid = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnNoMatch = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.ddlBusiness = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAcceptChoice = New System.Windows.Forms.Button
        Me.grpEnter = New System.Windows.Forms.GroupBox
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        CType(Me.gvBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvBusiness
        '
        Me.gvBusiness.AllowUserToAddRows = False
        Me.gvBusiness.AllowUserToDeleteRows = False
        Me.gvBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvBusiness.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvBusiness.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.gvBusiness.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvBusiness.Location = New System.Drawing.Point(221, 461)
        Me.gvBusiness.Name = "gvBusiness"
        Me.gvBusiness.Size = New System.Drawing.Size(501, 113)
        Me.gvBusiness.TabIndex = 0
        Me.gvBusiness.TabStop = False
        '
        'txtSiblingID
        '
        Me.txtSiblingID.Enabled = False
        Me.txtSiblingID.Location = New System.Drawing.Point(375, 282)
        Me.txtSiblingID.Name = "txtSiblingID"
        Me.txtSiblingID.Size = New System.Drawing.Size(42, 20)
        Me.txtSiblingID.TabIndex = 1
        Me.txtSiblingID.TabStop = False
        Me.txtSiblingID.Text = "NONE"
        Me.txtSiblingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewListedName
        '
        Me.txtNewListedName.Location = New System.Drawing.Point(380, 142)
        Me.txtNewListedName.Name = "txtNewListedName"
        Me.txtNewListedName.Size = New System.Drawing.Size(141, 20)
        Me.txtNewListedName.TabIndex = 2
        Me.txtNewListedName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "New Business Name Found:"
        '
        'txtCommonBusName
        '
        Me.txtCommonBusName.Enabled = False
        Me.txtCommonBusName.Location = New System.Drawing.Point(375, 246)
        Me.txtCommonBusName.MaxLength = 15
        Me.txtCommonBusName.Name = "txtCommonBusName"
        Me.txtCommonBusName.Size = New System.Drawing.Size(141, 20)
        Me.txtCommonBusName.TabIndex = 4
        Me.txtCommonBusName.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Proposed Common Name:"
        '
        'btnAcceptMatch
        '
        Me.btnAcceptMatch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptMatch.Location = New System.Drawing.Point(240, 315)
        Me.btnAcceptMatch.Name = "btnAcceptMatch"
        Me.btnAcceptMatch.Size = New System.Drawing.Size(386, 23)
        Me.btnAcceptMatch.TabIndex = 6
        Me.btnAcceptMatch.TabStop = False
        Me.btnAcceptMatch.Text = "Accept This match. New entry will be added!"
        Me.btnAcceptMatch.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(73, 65)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(736, 74)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "New Entry number:"
        '
        'lblGridInstructions
        '
        Me.lblGridInstructions.BackColor = System.Drawing.SystemColors.Control
        Me.lblGridInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblGridInstructions.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGridInstructions.Location = New System.Drawing.Point(298, 585)
        Me.lblGridInstructions.Name = "lblGridInstructions"
        Me.lblGridInstructions.Size = New System.Drawing.Size(328, 87)
        Me.lblGridInstructions.TabIndex = 9
        Me.lblGridInstructions.Text = resources.GetString("lblGridInstructions.Text")
        '
        'hdnActID
        '
        Me.hdnActID.Location = New System.Drawing.Point(115, 467)
        Me.hdnActID.Name = "hdnActID"
        Me.hdnActID.Size = New System.Drawing.Size(29, 20)
        Me.hdnActID.TabIndex = 10
        Me.hdnActID.TabStop = False
        Me.hdnActID.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(286, 29)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(325, 33)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Create or Match Businesses"
        '
        'lblGrid
        '
        Me.lblGrid.AutoSize = True
        Me.lblGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrid.Location = New System.Drawing.Point(372, 440)
        Me.lblGrid.Name = "lblGrid"
        Me.lblGrid.Size = New System.Drawing.Size(192, 18)
        Me.lblGrid.TabIndex = 12
        Me.lblGrid.Text = "Similar Business Names"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 493)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(29, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TabStop = False
        Me.TextBox1.Visible = False
        '
        'btnNoMatch
        '
        Me.btnNoMatch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoMatch.Location = New System.Drawing.Point(240, 344)
        Me.btnNoMatch.Name = "btnNoMatch"
        Me.btnNoMatch.Size = New System.Drawing.Size(386, 23)
        Me.btnNoMatch.TabIndex = 14
        Me.btnNoMatch.TabStop = False
        Me.btnNoMatch.Text = "No Match!  New entry will be created!"
        Me.btnNoMatch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(240, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(386, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.TabStop = False
        Me.Button1.Text = "Skip. Return to Posting Screen to Select new Entry."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(85, 402)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(736, 35)
        Me.RichTextBox3.TabIndex = 16
        Me.RichTextBox3.Text = "If there is not enough information showing in New Business Name Found entry above" & _
            ", you can return to the Post menu and search for more information to allow you t" & _
            "o determine the name of the company." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ddlBusiness
        '
        Me.ddlBusiness.DropDownWidth = 200
        Me.ddlBusiness.FormattingEnabled = True
        Me.ddlBusiness.Location = New System.Drawing.Point(380, 179)
        Me.ddlBusiness.Name = "ddlBusiness"
        Me.ddlBusiness.Size = New System.Drawing.Size(191, 21)
        Me.ddlBusiness.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Select Business to Match:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(580, 164)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(283, 49)
        Me.RichTextBox2.TabIndex = 20
        Me.RichTextBox2.Text = "Begin immediately typing the name of the business you want to find. Click Start A" & _
            "gain if the name you want does not appear."
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(662, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Clear - Start Again"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAcceptChoice
        '
        Me.btnAcceptChoice.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptChoice.Location = New System.Drawing.Point(380, 210)
        Me.btnAcceptChoice.Name = "btnAcceptChoice"
        Me.btnAcceptChoice.Size = New System.Drawing.Size(147, 23)
        Me.btnAcceptChoice.TabIndex = 22
        Me.btnAcceptChoice.Text = "Accept Choice"
        Me.btnAcceptChoice.UseVisualStyleBackColor = True
        '
        'grpEnter
        '
        Me.grpEnter.Location = New System.Drawing.Point(103, 243)
        Me.grpEnter.Name = "grpEnter"
        Me.grpEnter.Size = New System.Drawing.Size(553, 153)
        Me.grpEnter.TabIndex = 23
        Me.grpEnter.TabStop = False
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(76, 206)
        Me.RichTextBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(298, 33)
        Me.RichTextBox4.TabIndex = 24
        Me.RichTextBox4.Text = "If no entry found, click Clear and click Accept Choice." & Global.Microsoft.VisualBasic.ChrW(10) & "Then enter the proposed n" & _
            "ame for the new entry."
        '
        'SiblingCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 673)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.btnAcceptChoice)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ddlBusiness)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNoMatch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblGrid)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.hdnActID)
        Me.Controls.Add(Me.lblGridInstructions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnAcceptMatch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCommonBusName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewListedName)
        Me.Controls.Add(Me.txtSiblingID)
        Me.Controls.Add(Me.gvBusiness)
        Me.Controls.Add(Me.grpEnter)
        Me.Name = "SiblingCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SiblingCheck"
        CType(Me.gvBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvBusiness As System.Windows.Forms.DataGridView
    Friend WithEvents txtSiblingID As System.Windows.Forms.TextBox
    Friend WithEvents txtNewListedName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCommonBusName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAcceptMatch As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGridInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents hdnActID As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblGrid As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnNoMatch As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents ddlBusiness As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAcceptChoice As System.Windows.Forms.Button
    Friend WithEvents grpEnter As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
End Class
