<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenSalaryFrm
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
        Dim SalaryMountLabel As System.Windows.Forms.Label
        Dim SalaryYearLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryYearTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryMountTextBox = New System.Windows.Forms.TextBox()
        SalaryMountLabel = New System.Windows.Forms.Label()
        SalaryYearLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalaryMountLabel
        '
        SalaryMountLabel.AutoSize = True
        SalaryMountLabel.Location = New System.Drawing.Point(283, 10)
        SalaryMountLabel.Name = "SalaryMountLabel"
        SalaryMountLabel.Size = New System.Drawing.Size(70, 19)
        SalaryMountLabel.TabIndex = 0
        SalaryMountLabel.Text = "شهر الراتب"
        '
        'SalaryYearLabel
        '
        SalaryYearLabel.AutoSize = True
        SalaryYearLabel.Location = New System.Drawing.Point(118, 10)
        SalaryYearLabel.Name = "SalaryYearLabel"
        SalaryYearLabel.Size = New System.Drawing.Size(53, 19)
        SalaryYearLabel.TabIndex = 2
        SalaryYearLabel.Text = "من العام"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(292, 46)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(61, 19)
        NotesLabel.TabIndex = 4
        NotesLabel.Text = "مــلاحظات"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 81)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(0, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "بعد إغلاق شهر الراتب لا يمكنك القيام بأي تعديل على سجلات الراتب"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تمكنك هذة الواجهة من إدارة أشهر الراتب مثل فتح الراتب أو إغلاقة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 35)
        Me.Panel2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 26)
        Me.TextBox1.TabIndex = 6
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(311, 8)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(44, 19)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "تعـــديل"
        Me.LinkLabel2.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 19)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "إغـــلاق"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox2)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(NotesLabel)
        Me.Panel3.Controls.Add(Me.NotesTextBox)
        Me.Panel3.Controls.Add(SalaryYearLabel)
        Me.Panel3.Controls.Add(Me.SalaryYearTextBox)
        Me.Panel3.Controls.Add(SalaryMountLabel)
        Me.Panel3.Controls.Add(Me.SalaryMountTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(369, 149)
        Me.Panel3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(7, 6)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(105, 27)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(172, 7)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 27)
        Me.ComboBox1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "إغلاق الشهر الحالي"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(194, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Tag = "0"
        Me.Button1.Text = "فتح شهر جديد للراتب"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Location = New System.Drawing.Point(12, 43)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(265, 38)
        Me.NotesTextBox.TabIndex = 5
        '
        'SalaryYearTextBox
        '
        Me.SalaryYearTextBox.Location = New System.Drawing.Point(12, 7)
        Me.SalaryYearTextBox.MaxLength = 4
        Me.SalaryYearTextBox.Name = "SalaryYearTextBox"
        Me.SalaryYearTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SalaryYearTextBox.TabIndex = 3
        '
        'SalaryMountTextBox
        '
        Me.SalaryMountTextBox.Location = New System.Drawing.Point(177, 7)
        Me.SalaryMountTextBox.MaxLength = 2
        Me.SalaryMountTextBox.Name = "SalaryMountTextBox"
        Me.SalaryMountTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SalaryMountTextBox.TabIndex = 1
        '
        'OpenSalaryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 265)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "OpenSalaryFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فتح/إغلاق شهر الراتب"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SalaryMountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalaryYearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
