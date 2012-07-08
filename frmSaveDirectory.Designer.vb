<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaveDirectory
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
        Me.cmbOS = New System.Windows.Forms.ComboBox()
        Me.rdo86 = New System.Windows.Forms.RadioButton()
        Me.rdo64 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSteam = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmbOS
        '
        Me.cmbOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOS.FormattingEnabled = True
        Me.cmbOS.Items.AddRange(New Object() {"7", "Vista", "XP"})
        Me.cmbOS.Location = New System.Drawing.Point(201, 6)
        Me.cmbOS.Name = "cmbOS"
        Me.cmbOS.Size = New System.Drawing.Size(121, 21)
        Me.cmbOS.TabIndex = 0
        '
        'rdo86
        '
        Me.rdo86.AutoSize = True
        Me.rdo86.Location = New System.Drawing.Point(328, 7)
        Me.rdo86.Name = "rdo86"
        Me.rdo86.Size = New System.Drawing.Size(42, 17)
        Me.rdo86.TabIndex = 1
        Me.rdo86.TabStop = True
        Me.rdo86.Text = "x86"
        Me.rdo86.UseVisualStyleBackColor = True
        '
        'rdo64
        '
        Me.rdo64.AutoSize = True
        Me.rdo64.Location = New System.Drawing.Point(376, 7)
        Me.rdo64.Name = "rdo64"
        Me.rdo64.Size = New System.Drawing.Size(42, 17)
        Me.rdo64.TabIndex = 2
        Me.rdo64.TabStop = True
        Me.rdo64.Text = "x64"
        Me.rdo64.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Options for automatic directory choice:"
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(12, 92)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(325, 20)
        Me.txtDirectory.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(343, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnChoose
        '
        Me.btnChoose.Location = New System.Drawing.Point(12, 63)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(75, 23)
        Me.btnChoose.TabIndex = 6
        Me.btnChoose.Text = "Choose..."
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Alternatively, enter save directory manually:"
        '
        'chkSteam
        '
        Me.chkSteam.AutoSize = True
        Me.chkSteam.Location = New System.Drawing.Point(328, 30)
        Me.chkSteam.Name = "chkSteam"
        Me.chkSteam.Size = New System.Drawing.Size(56, 17)
        Me.chkSteam.TabIndex = 8
        Me.chkSteam.Text = "Steam"
        Me.chkSteam.UseVisualStyleBackColor = True
        '
        'frmSaveDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 123)
        Me.Controls.Add(Me.chkSteam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChoose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdo64)
        Me.Controls.Add(Me.rdo86)
        Me.Controls.Add(Me.cmbOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaveDirectory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select directory..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbOS As System.Windows.Forms.ComboBox
    Friend WithEvents rdo86 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo64 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnChoose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkSteam As System.Windows.Forms.CheckBox

End Class
