<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddActivity
    Inherits Finances.baseform

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtType = New System.Windows.Forms.TextBox
        Me.lblCaption = New System.Windows.Forms.Label
        Me.ddlActivity = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnGO = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblHdnSource = New System.Windows.Forms.Label
        Me.txtProject = New System.Windows.Forms.TextBox
        Me.rbDisplay = New System.Windows.Forms.RadioButton
        Me.rbEdit = New System.Windows.Forms.RadioButton
        Me.grpType = New System.Windows.Forms.GroupBox
        Me.rbAdd = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.lblMode = New System.Windows.Forms.Label
        Me.ddlProject = New System.Windows.Forms.ComboBox
        Me.ddlActivityType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ddlRecords = New System.Windows.Forms.ComboBox
        Me.lblID = New System.Windows.Forms.Label
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.Label4 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ddlSort = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSort = New System.Windows.Forms.TextBox
        Me.grpType.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Activity Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(443, 268)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(168, 22)
        Me.txtType.TabIndex = 2
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(502, 32)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(17, 19)
        Me.lblCaption.TabIndex = 16
        Me.lblCaption.Text = "  "
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ddlActivity
        '
        Me.ddlActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlActivity.FormattingEnabled = True
        Me.ddlActivity.Location = New System.Drawing.Point(443, 184)
        Me.ddlActivity.Name = "ddlActivity"
        Me.ddlActivity.Size = New System.Drawing.Size(168, 24)
        Me.ddlActivity.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(376, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Project"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(480, 384)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(75, 23)
        Me.btnGO.TabIndex = 20
        Me.btnGO.Text = "GO"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(480, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(448, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 26)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Add or Edit Activity"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(441, 184)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(168, 22)
        Me.txtDescription.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(305, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Activity Description"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHdnSource
        '
        Me.lblHdnSource.AutoSize = True
        Me.lblHdnSource.Location = New System.Drawing.Point(87, 76)
        Me.lblHdnSource.Name = "lblHdnSource"
        Me.lblHdnSource.Size = New System.Drawing.Size(73, 13)
        Me.lblHdnSource.TabIndex = 41
        Me.lblHdnSource.Text = "hiddenSource"
        Me.lblHdnSource.Visible = False
        '
        'txtProject
        '
        Me.txtProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProject.Location = New System.Drawing.Point(441, 230)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.ReadOnly = True
        Me.txtProject.Size = New System.Drawing.Size(168, 22)
        Me.txtProject.TabIndex = 45
        '
        'rbDisplay
        '
        Me.rbDisplay.AutoSize = True
        Me.rbDisplay.Location = New System.Drawing.Point(24, 37)
        Me.rbDisplay.Name = "rbDisplay"
        Me.rbDisplay.Size = New System.Drawing.Size(127, 23)
        Me.rbDisplay.TabIndex = 0
        Me.rbDisplay.TabStop = True
        Me.rbDisplay.Text = "Display Activity"
        Me.rbDisplay.UseVisualStyleBackColor = True
        '
        'rbEdit
        '
        Me.rbEdit.AutoSize = True
        Me.rbEdit.Location = New System.Drawing.Point(24, 62)
        Me.rbEdit.Name = "rbEdit"
        Me.rbEdit.Size = New System.Drawing.Size(104, 23)
        Me.rbEdit.TabIndex = 1
        Me.rbEdit.TabStop = True
        Me.rbEdit.Text = "Edit Activity"
        Me.rbEdit.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rbAdd)
        Me.grpType.Controls.Add(Me.rbEdit)
        Me.grpType.Controls.Add(Me.rbDisplay)
        Me.grpType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.Location = New System.Drawing.Point(720, 134)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(163, 146)
        Me.grpType.TabIndex = 47
        Me.grpType.TabStop = False
        Me.grpType.Text = "Activity Types"
        '
        'rbAdd
        '
        Me.rbAdd.AutoSize = True
        Me.rbAdd.Location = New System.Drawing.Point(24, 87)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(104, 23)
        Me.rbAdd.TabIndex = 3
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "Add Activity"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Activity Notes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(443, 301)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(440, 47)
        Me.txtNotes.TabIndex = 50
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(572, 387)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(351, 23)
        Me.RichTextBox2.TabIndex = 52
        Me.RichTextBox2.Text = "'Go Button' will save new activities and edits."
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.Location = New System.Drawing.Point(494, 80)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(61, 23)
        Me.lblMode.TabIndex = 53
        Me.lblMode.Text = "MODE"
        '
        'ddlProject
        '
        Me.ddlProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlProject.FormattingEnabled = True
        Me.ddlProject.Location = New System.Drawing.Point(443, 230)
        Me.ddlProject.Name = "ddlProject"
        Me.ddlProject.Size = New System.Drawing.Size(168, 24)
        Me.ddlProject.TabIndex = 54
        '
        'ddlActivityType
        '
        Me.ddlActivityType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlActivityType.FormattingEnabled = True
        Me.ddlActivityType.Location = New System.Drawing.Point(443, 268)
        Me.ddlActivityType.Name = "ddlActivityType"
        Me.ddlActivityType.Size = New System.Drawing.Size(168, 24)
        Me.ddlActivityType.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Activity ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ddlRecords
        '
        Me.ddlRecords.DropDownWidth = 50
        Me.ddlRecords.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlRecords.FormattingEnabled = True
        Me.ddlRecords.Location = New System.Drawing.Point(441, 109)
        Me.ddlRecords.Name = "ddlRecords"
        Me.ddlRecords.Size = New System.Drawing.Size(168, 27)
        Me.ddlRecords.TabIndex = 57
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(109, 134)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(15, 18)
        Me.lblID.TabIndex = 43
        Me.lblID.Text = "1"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblID.Visible = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-13, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 58
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(29, 230)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(306, 50)
        Me.RichTextBox1.TabIndex = 59
        Me.RichTextBox1.Text = "New Projects and Activity Type must be added separately. See administrator."
        '
        'ddlSort
        '
        Me.ddlSort.DropDownWidth = 50
        Me.ddlSort.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlSort.FormattingEnabled = True
        Me.ddlSort.Location = New System.Drawing.Point(441, 145)
        Me.ddlSort.Name = "ddlSort"
        Me.ddlSort.Size = New System.Drawing.Size(168, 27)
        Me.ddlSort.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Activity Sort"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSort
        '
        Me.txtSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSort.Location = New System.Drawing.Point(615, 145)
        Me.txtSort.MaximumSize = New System.Drawing.Size(1000, 50)
        Me.txtSort.MinimumSize = New System.Drawing.Size(10, 10)
        Me.txtSort.Name = "txtSort"
        Me.txtSort.Size = New System.Drawing.Size(75, 22)
        Me.txtSort.TabIndex = 62
        '
        'AddActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1108, 534)
        Me.Controls.Add(Me.txtSort)
        Me.Controls.Add(Me.ddlSort)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ddlRecords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.txtProject)
        Me.Controls.Add(Me.lblHdnSource)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ddlActivity)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ddlActivityType)
        Me.Controls.Add(Me.ddlProject)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MaximizeBox = False
        Me.Name = "AddActivity"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.[Auto]
        Me.Text = "Activity Manager"
        Me.Controls.SetChildIndex(Me.ddlProject, 0)
        Me.Controls.SetChildIndex(Me.ddlActivityType, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtType, 0)
        Me.Controls.SetChildIndex(Me.ddlActivity, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.btnGO, 0)
        Me.Controls.SetChildIndex(Me.btnClose, 0)
        Me.Controls.SetChildIndex(Me.lblCaption, 0)
        Me.Controls.SetChildIndex(Me.lblID, 0)
        Me.Controls.SetChildIndex(Me.txtDescription, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.lblHdnSource, 0)
        Me.Controls.SetChildIndex(Me.txtProject, 0)
        Me.Controls.SetChildIndex(Me.grpType, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtNotes, 0)
        Me.Controls.SetChildIndex(Me.RichTextBox2, 0)
        Me.Controls.SetChildIndex(Me.lblMode, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ddlRecords, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.RichTextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ddlSort, 0)
        Me.Controls.SetChildIndex(Me.txtSort, 0)
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents ddlActivity As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblHdnSource As System.Windows.Forms.Label
    Friend WithEvents txtProject As System.Windows.Forms.TextBox
    Friend WithEvents rbDisplay As System.Windows.Forms.RadioButton
    Friend WithEvents rbEdit As System.Windows.Forms.RadioButton
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents rbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents ddlProject As System.Windows.Forms.ComboBox
    Friend WithEvents ddlActivityType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ddlRecords As System.Windows.Forms.ComboBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ddlSort As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSort As System.Windows.Forms.TextBox
End Class
