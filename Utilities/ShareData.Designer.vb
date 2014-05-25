<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShareData
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.dte = New System.Windows.Forms.DateTimePicker
        Me.btnExport = New System.Windows.Forms.Button
        Me.chkJNL = New System.Windows.Forms.CheckBox
        Me.chkBNK = New System.Windows.Forms.CheckBox
        Me.chkBus = New System.Windows.Forms.CheckBox
        Me.chkCOA = New System.Windows.Forms.CheckBox
        Me.chkCheck = New System.Windows.Forms.CheckBox
        Me.cnkActivity = New System.Windows.Forms.CheckBox
        Me.btnImport = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnOpen = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.lblFileName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFolder = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(580, 584)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'dte
        '
        Me.dte.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dte.Location = New System.Drawing.Point(354, 247)
        Me.dte.Margin = New System.Windows.Forms.Padding(4)
        Me.dte.Name = "dte"
        Me.dte.Size = New System.Drawing.Size(151, 27)
        Me.dte.TabIndex = 1
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(363, 311)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 36)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'chkJNL
        '
        Me.chkJNL.AutoSize = True
        Me.chkJNL.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJNL.Location = New System.Drawing.Point(141, 197)
        Me.chkJNL.Margin = New System.Windows.Forms.Padding(4)
        Me.chkJNL.Name = "chkJNL"
        Me.chkJNL.Size = New System.Drawing.Size(74, 23)
        Me.chkJNL.TabIndex = 3
        Me.chkJNL.Text = "Journal"
        Me.chkJNL.UseVisualStyleBackColor = True
        '
        'chkBNK
        '
        Me.chkBNK.AutoSize = True
        Me.chkBNK.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBNK.Location = New System.Drawing.Point(141, 228)
        Me.chkBNK.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBNK.Name = "chkBNK"
        Me.chkBNK.Size = New System.Drawing.Size(146, 23)
        Me.chkBNK.TabIndex = 4
        Me.chkBNK.Text = "Bank Transactions"
        Me.chkBNK.UseVisualStyleBackColor = True
        '
        'chkBus
        '
        Me.chkBus.AutoSize = True
        Me.chkBus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBus.Location = New System.Drawing.Point(141, 260)
        Me.chkBus.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBus.Name = "chkBus"
        Me.chkBus.Size = New System.Drawing.Size(101, 23)
        Me.chkBus.TabIndex = 5
        Me.chkBus.Text = "Businesses"
        Me.chkBus.UseVisualStyleBackColor = True
        '
        'chkCOA
        '
        Me.chkCOA.AutoSize = True
        Me.chkCOA.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCOA.Location = New System.Drawing.Point(141, 292)
        Me.chkCOA.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCOA.Name = "chkCOA"
        Me.chkCOA.Size = New System.Drawing.Size(143, 23)
        Me.chkCOA.TabIndex = 6
        Me.chkCOA.Text = "Chart of Accounts"
        Me.chkCOA.UseVisualStyleBackColor = True
        '
        'chkCheck
        '
        Me.chkCheck.AutoSize = True
        Me.chkCheck.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheck.Location = New System.Drawing.Point(141, 324)
        Me.chkCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.Size = New System.Drawing.Size(74, 23)
        Me.chkCheck.TabIndex = 7
        Me.chkCheck.Text = "Checks"
        Me.chkCheck.UseVisualStyleBackColor = True
        '
        'cnkActivity
        '
        Me.cnkActivity.AutoSize = True
        Me.cnkActivity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnkActivity.Location = New System.Drawing.Point(141, 356)
        Me.cnkActivity.Margin = New System.Windows.Forms.Padding(4)
        Me.cnkActivity.Name = "cnkActivity"
        Me.cnkActivity.Size = New System.Drawing.Size(88, 23)
        Me.cnkActivity.TabIndex = 8
        Me.cnkActivity.Text = "Activities"
        Me.cnkActivity.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(554, 311)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(100, 36)
        Me.btnImport.TabIndex = 9
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(554, 247)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(100, 36)
        Me.btnOpen.TabIndex = 10
        Me.btnOpen.Text = "Open File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(189, 57)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 19)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Folder Name:"
        '
        'lblFileName
        '
        Me.lblFileName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(493, 91)
        Me.lblFileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(243, 19)
        Me.lblFileName.TabIndex = 12
        Me.lblFileName.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(576, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "File Name:"
        '
        'lblFolder
        '
        Me.lblFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFolder.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolder.Location = New System.Drawing.Point(40, 91)
        Me.lblFolder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFolder.Name = "lblFolder"
        Me.lblFolder.Size = New System.Drawing.Size(389, 19)
        Me.lblFolder.TabIndex = 14
        Me.lblFolder.Text = " "
        '
        'ShareData
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(791, 641)
        Me.Controls.Add(Me.lblFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.cnkActivity)
        Me.Controls.Add(Me.chkCheck)
        Me.Controls.Add(Me.chkCOA)
        Me.Controls.Add(Me.chkBus)
        Me.Controls.Add(Me.chkBNK)
        Me.Controls.Add(Me.chkJNL)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dte)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShareData"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ShareData"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents dte As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents chkJNL As System.Windows.Forms.CheckBox
    Friend WithEvents chkBNK As System.Windows.Forms.CheckBox
    Friend WithEvents chkBus As System.Windows.Forms.CheckBox
    Friend WithEvents chkCOA As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheck As System.Windows.Forms.CheckBox
    Friend WithEvents cnkActivity As System.Windows.Forms.CheckBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFolder As System.Windows.Forms.Label

End Class
