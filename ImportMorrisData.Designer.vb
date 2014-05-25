<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportMorrisData
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.btnStartMorris = New System.Windows.Forms.Button
        Me.txtCntW = New System.Windows.Forms.TextBox
        Me.lblRecCnt = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblForlbl = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnFindCSV = New System.Windows.Forms.Button
        Me.lblQuicken = New System.Windows.Forms.Label
        Me.lblStartMorris = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ddlBank = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpImportActions = New System.Windows.Forms.GroupBox
        Me.grpFileInfo = New System.Windows.Forms.GroupBox
        Me.lblFolder = New System.Windows.Forms.Label
        Me.lblFolderName = New System.Windows.Forms.Label
        Me.lblFileName = New System.Windows.Forms.Label
        Me.hdnFileName = New System.Windows.Forms.Label
        Me.hdnFileAndPath = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCntPas = New System.Windows.Forms.TextBox
        Me.grpImportActions.SuspendLayout()
        Me.grpFileInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStartMorris
        '
        Me.btnStartMorris.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartMorris.Location = New System.Drawing.Point(173, 109)
        Me.btnStartMorris.Name = "btnStartMorris"
        Me.btnStartMorris.Size = New System.Drawing.Size(161, 26)
        Me.btnStartMorris.TabIndex = 0
        Me.btnStartMorris.Text = "Start Import"
        Me.btnStartMorris.UseVisualStyleBackColor = True
        '
        'txtCntW
        '
        Me.txtCntW.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCntW.Location = New System.Drawing.Point(311, 348)
        Me.txtCntW.Name = "txtCntW"
        Me.txtCntW.Size = New System.Drawing.Size(38, 31)
        Me.txtCntW.TabIndex = 1
        '
        'lblRecCnt
        '
        Me.lblRecCnt.AutoSize = True
        Me.lblRecCnt.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecCnt.Location = New System.Drawing.Point(111, 351)
        Me.lblRecCnt.Name = "lblRecCnt"
        Me.lblRecCnt.Size = New System.Drawing.Size(191, 23)
        Me.lblRecCnt.TabIndex = 2
        Me.lblRecCnt.Text = "Transactions Imported:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(237, 474)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblForlbl
        '
        Me.lblForlbl.AutoSize = True
        Me.lblForlbl.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForlbl.Location = New System.Drawing.Point(37, 15)
        Me.lblForlbl.Name = "lblForlbl"
        Me.lblForlbl.Size = New System.Drawing.Size(101, 23)
        Me.lblForlbl.TabIndex = 7
        Me.lblForlbl.Text = "FILE NAME:"
        Me.lblForlbl.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'btnFindCSV
        '
        Me.btnFindCSV.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCSV.Location = New System.Drawing.Point(175, 157)
        Me.btnFindCSV.Name = "btnFindCSV"
        Me.btnFindCSV.Size = New System.Drawing.Size(161, 23)
        Me.btnFindCSV.TabIndex = 9
        Me.btnFindCSV.Text = "Find Data"
        Me.btnFindCSV.UseVisualStyleBackColor = True
        '
        'lblQuicken
        '
        Me.lblQuicken.AutoSize = True
        Me.lblQuicken.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuicken.Location = New System.Drawing.Point(184, 134)
        Me.lblQuicken.Name = "lblQuicken"
        Me.lblQuicken.Size = New System.Drawing.Size(153, 23)
        Me.lblQuicken.TabIndex = 10
        Me.lblQuicken.Text = "FIND IMPORT FILE"
        '
        'lblStartMorris
        '
        Me.lblStartMorris.AutoSize = True
        Me.lblStartMorris.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartMorris.Location = New System.Drawing.Point(187, 83)
        Me.lblStartMorris.Name = "lblStartMorris"
        Me.lblStartMorris.Size = New System.Drawing.Size(128, 23)
        Me.lblStartMorris.TabIndex = 11
        Me.lblStartMorris.Text = "START IMPORT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 39)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "IMPORT MORRIS DATA"
        '
        'ddlBank
        '
        Me.ddlBank.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlBank.FormattingEnabled = True
        Me.ddlBank.Location = New System.Drawing.Point(121, 97)
        Me.ddlBank.Name = "ddlBank"
        Me.ddlBank.Size = New System.Drawing.Size(312, 23)
        Me.ddlBank.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Select Bank Account"
        '
        'grpImportActions
        '
        Me.grpImportActions.Controls.Add(Me.grpFileInfo)
        Me.grpImportActions.Controls.Add(Me.lblStartMorris)
        Me.grpImportActions.Controls.Add(Me.btnStartMorris)
        Me.grpImportActions.Location = New System.Drawing.Point(15, 177)
        Me.grpImportActions.Name = "grpImportActions"
        Me.grpImportActions.Size = New System.Drawing.Size(514, 150)
        Me.grpImportActions.TabIndex = 15
        Me.grpImportActions.TabStop = False
        Me.grpImportActions.Visible = False
        '
        'grpFileInfo
        '
        Me.grpFileInfo.Controls.Add(Me.lblFolder)
        Me.grpFileInfo.Controls.Add(Me.lblForlbl)
        Me.grpFileInfo.Controls.Add(Me.lblFolderName)
        Me.grpFileInfo.Controls.Add(Me.lblFileName)
        Me.grpFileInfo.Location = New System.Drawing.Point(12, 9)
        Me.grpFileInfo.Name = "grpFileInfo"
        Me.grpFileInfo.Size = New System.Drawing.Size(502, 71)
        Me.grpFileInfo.TabIndex = 18
        Me.grpFileInfo.TabStop = False
        '
        'lblFolder
        '
        Me.lblFolder.AutoSize = True
        Me.lblFolder.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolder.Location = New System.Drawing.Point(6, 35)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(132, 23)
        Me.lblFolder.TabIndex = 20
        Me.lblFolder.Text = "FOLDER NAME:"
        Me.lblFolder.Visible = False
        '
        'lblFolderName
        '
        Me.lblFolderName.AutoSize = True
        Me.lblFolderName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolderName.Location = New System.Drawing.Point(144, 39)
        Me.lblFolderName.Name = "lblFolderName"
        Me.lblFolderName.Size = New System.Drawing.Size(0, 19)
        Me.lblFolderName.TabIndex = 17
        Me.lblFolderName.Visible = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(144, 16)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(0, 19)
        Me.lblFileName.TabIndex = 4
        Me.lblFileName.Visible = False
        '
        'hdnFileName
        '
        Me.hdnFileName.AutoSize = True
        Me.hdnFileName.Location = New System.Drawing.Point(529, 147)
        Me.hdnFileName.Name = "hdnFileName"
        Me.hdnFileName.Size = New System.Drawing.Size(0, 13)
        Me.hdnFileName.TabIndex = 16
        Me.hdnFileName.Visible = False
        '
        'hdnFileAndPath
        '
        Me.hdnFileAndPath.AutoSize = True
        Me.hdnFileAndPath.Location = New System.Drawing.Point(12, 144)
        Me.hdnFileAndPath.Name = "hdnFileAndPath"
        Me.hdnFileAndPath.Size = New System.Drawing.Size(14, 13)
        Me.hdnFileAndPath.TabIndex = 19
        Me.hdnFileAndPath.Text = "X"
        Me.hdnFileAndPath.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(222, 445)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 23)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Duplicate Transactions:"
        '
        'txtCntPas
        '
        Me.txtCntPas.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCntPas.Location = New System.Drawing.Point(311, 390)
        Me.txtCntPas.Name = "txtCntPas"
        Me.txtCntPas.Size = New System.Drawing.Size(38, 31)
        Me.txtCntPas.TabIndex = 21
        '
        'ImportMorrisData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 520)
        Me.Controls.Add(Me.lblQuicken)
        Me.Controls.Add(Me.btnFindCSV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCntPas)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.hdnFileAndPath)
        Me.Controls.Add(Me.hdnFileName)
        Me.Controls.Add(Me.grpImportActions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ddlBank)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblRecCnt)
        Me.Controls.Add(Me.txtCntW)
        Me.Name = "ImportMorrisData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Data File"
        Me.grpImportActions.ResumeLayout(False)
        Me.grpImportActions.PerformLayout()
        Me.grpFileInfo.ResumeLayout(False)
        Me.grpFileInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartMorris As System.Windows.Forms.Button
    Friend WithEvents txtCntW As System.Windows.Forms.TextBox
    Friend WithEvents lblRecCnt As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblForlbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnFindCSV As System.Windows.Forms.Button
    Friend WithEvents lblQuicken As System.Windows.Forms.Label
    Friend WithEvents lblStartMorris As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ddlBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpImportActions As System.Windows.Forms.GroupBox
    Friend WithEvents hdnFileName As System.Windows.Forms.Label
    Friend WithEvents hdnFileAndPath As System.Windows.Forms.Label
    Friend WithEvents lblFolder As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents grpFileInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblFolderName As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCntPas As System.Windows.Forms.TextBox


End Class
