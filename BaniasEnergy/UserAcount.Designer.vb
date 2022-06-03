<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAcount
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtOldPW = New System.Windows.Forms.TextBox()
        Me.TxtNewPW = New System.Windows.Forms.TextBox()
        Me.TxtconfirmPW = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.BaniasEnergy.My.Resources.Resources.logon1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "تغيير اسم الدخول"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "كلمة المرور القديمة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "كلمة المرور الجديدة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "تأكيد كلمة المرور"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(257, 8)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(147, 26)
        Me.TxtName.TabIndex = 5
        '
        'TxtOldPW
        '
        Me.TxtOldPW.Location = New System.Drawing.Point(257, 39)
        Me.TxtOldPW.Name = "TxtOldPW"
        Me.TxtOldPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOldPW.Size = New System.Drawing.Size(147, 26)
        Me.TxtOldPW.TabIndex = 6
        Me.TxtOldPW.UseSystemPasswordChar = True
        '
        'TxtNewPW
        '
        Me.TxtNewPW.Location = New System.Drawing.Point(257, 72)
        Me.TxtNewPW.Name = "TxtNewPW"
        Me.TxtNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPW.Size = New System.Drawing.Size(147, 26)
        Me.TxtNewPW.TabIndex = 7
        Me.TxtNewPW.UseSystemPasswordChar = True
        '
        'TxtconfirmPW
        '
        Me.TxtconfirmPW.Location = New System.Drawing.Point(257, 105)
        Me.TxtconfirmPW.Name = "TxtconfirmPW"
        Me.TxtconfirmPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtconfirmPW.Size = New System.Drawing.Size(147, 26)
        Me.TxtconfirmPW.TabIndex = 8
        Me.TxtconfirmPW.UseSystemPasswordChar = True
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(138, 142)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(120, 35)
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "موافق"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(323, 142)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(81, 35)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "تجاهل"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'UserAcount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 177)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtconfirmPW)
        Me.Controls.Add(Me.TxtNewPW)
        Me.Controls.Add(Me.TxtOldPW)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MinimizeBox = False
        Me.Name = "UserAcount"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تغيير حسابي"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtOldPW As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewPW As System.Windows.Forms.TextBox
    Friend WithEvents TxtconfirmPW As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
