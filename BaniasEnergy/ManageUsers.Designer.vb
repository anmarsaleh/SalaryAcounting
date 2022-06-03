<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsers))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AllowContractsCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowEngeneersCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowManagersCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowAgentsCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowWorkersCheckBox = New System.Windows.Forms.CheckBox()
        Me.AllowSalaryCheckBox = New System.Windows.Forms.CheckBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersDBDataSet = New BaniasEnergy.UsersDBDataSet()
        Me.UsersTableAdapter = New BaniasEnergy.UsersDBDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.UsersDBDataSetTableAdapters.TableAdapterManager()
        Me.AllRecordsCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.LinkLabel3)
        Me.Panel2.Controls.Add(Me.UserIDTextBox)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 278)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 249)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "السماح بالوصول إلى المديريات"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(191, 169)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 26)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(191, 137)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 26)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(191, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 26)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 26)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(23, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "المديريات المسموح بدحولها"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(271, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "جميع مديريات الشركة"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(9, 32)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(176, 212)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(237, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(176, 212)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AllRecordsCheckBox)
        Me.GroupBox2.Controls.Add(Me.AllowContractsCheckBox)
        Me.GroupBox2.Controls.Add(Me.AllowEngeneersCheckBox)
        Me.GroupBox2.Controls.Add(Me.AllowManagersCheckBox)
        Me.GroupBox2.Controls.Add(Me.AllowAgentsCheckBox)
        Me.GroupBox2.Controls.Add(Me.AllowWorkersCheckBox)
        Me.GroupBox2.Controls.Add(Me.AllowSalaryCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 104)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "السجلات المسموح الوصول اليها"
        '
        'AllowContractsCheckBox
        '
        Me.AllowContractsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowContracts", True))
        Me.AllowContractsCheckBox.Location = New System.Drawing.Point(7, 49)
        Me.AllowContractsCheckBox.Name = "AllowContractsCheckBox"
        Me.AllowContractsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowContractsCheckBox.TabIndex = 6
        Me.AllowContractsCheckBox.Text = "العقود المؤقتة"
        Me.AllowContractsCheckBox.UseVisualStyleBackColor = True
        '
        'AllowEngeneersCheckBox
        '
        Me.AllowEngeneersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowEngeneers", True))
        Me.AllowEngeneersCheckBox.Location = New System.Drawing.Point(218, 49)
        Me.AllowEngeneersCheckBox.Name = "AllowEngeneersCheckBox"
        Me.AllowEngeneersCheckBox.Size = New System.Drawing.Size(81, 24)
        Me.AllowEngeneersCheckBox.TabIndex = 5
        Me.AllowEngeneersCheckBox.Text = "المهندسين"
        Me.AllowEngeneersCheckBox.UseVisualStyleBackColor = True
        '
        'AllowManagersCheckBox
        '
        Me.AllowManagersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowManagers", True))
        Me.AllowManagersCheckBox.Location = New System.Drawing.Point(31, 19)
        Me.AllowManagersCheckBox.Name = "AllowManagersCheckBox"
        Me.AllowManagersCheckBox.Size = New System.Drawing.Size(80, 24)
        Me.AllowManagersCheckBox.TabIndex = 4
        Me.AllowManagersCheckBox.Text = "المدراء"
        Me.AllowManagersCheckBox.UseVisualStyleBackColor = True
        '
        'AllowAgentsCheckBox
        '
        Me.AllowAgentsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowAgents", True))
        Me.AllowAgentsCheckBox.Location = New System.Drawing.Point(108, 49)
        Me.AllowAgentsCheckBox.Name = "AllowAgentsCheckBox"
        Me.AllowAgentsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowAgentsCheckBox.TabIndex = 3
        Me.AllowAgentsCheckBox.Text = "العقود سنوية"
        Me.AllowAgentsCheckBox.UseVisualStyleBackColor = True
        '
        'AllowWorkersCheckBox
        '
        Me.AllowWorkersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowWorkers", True))
        Me.AllowWorkersCheckBox.Location = New System.Drawing.Point(105, 19)
        Me.AllowWorkersCheckBox.Name = "AllowWorkersCheckBox"
        Me.AllowWorkersCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowWorkersCheckBox.TabIndex = 2
        Me.AllowWorkersCheckBox.Text = "العمالية"
        Me.AllowWorkersCheckBox.UseVisualStyleBackColor = True
        '
        'AllowSalaryCheckBox
        '
        Me.AllowSalaryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowSalary", True))
        Me.AllowSalaryCheckBox.Location = New System.Drawing.Point(195, 19)
        Me.AllowSalaryCheckBox.Name = "AllowSalaryCheckBox"
        Me.AllowSalaryCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllowSalaryCheckBox.TabIndex = 1
        Me.AllowSalaryCheckBox.Text = "المستخدمين"
        Me.AllowSalaryCheckBox.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(709, 32)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(41, 19)
        Me.LinkLabel3.TabIndex = 12
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "إلغــاء"
        Me.LinkLabel3.Visible = False
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(708, 57)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(38, 20)
        Me.UserIDTextBox.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(435, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 84)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "صلاحيات المستخدم"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersBindingSource, "IsActive", True))
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "IsActive", True))
        Me.CheckBox7.Location = New System.Drawing.Point(26, 15)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox7.TabIndex = 7
        Me.CheckBox7.Text = "نشط"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "ExpireDate", True))
        Me.TextBox4.Location = New System.Drawing.Point(8, 59)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(81, 20)
        Me.TextBox4.TabIndex = 6
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "IsExpire", True))
        Me.CheckBox6.Location = New System.Drawing.Point(95, 61)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "إنتهاء الصلاحية"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersBindingSource, "AllowDelete", True))
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowDelete", True))
        Me.CheckBox5.Location = New System.Drawing.Point(220, 61)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "إضافة/حذف"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersBindingSource, "AllowModify", True))
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowModify", True))
        Me.CheckBox4.Location = New System.Drawing.Point(87, 38)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(100, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "السماح بالتعديل"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowPrint", True))
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersBindingSource, "AllowPrint", True))
        Me.CheckBox3.Location = New System.Drawing.Point(86, 15)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "السماح بالطباعة"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllowOpen", True))
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersBindingSource, "AllowOpen", True))
        Me.CheckBox2.Location = New System.Drawing.Point(194, 38)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "فتح/إغلاق الراتب"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "IsAdmin", True))
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.UsersBindingSource, "IsAdmin", True))
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(207, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "مسؤول النظام"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(443, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(128, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(577, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "تأكيد كلمة المرور"
        Me.Label3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "UserPassword", True))
        Me.TextBox2.Location = New System.Drawing.Point(443, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "كلمة المرور"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "UserName", True))
        Me.TextBox1.Location = New System.Drawing.Point(443, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(577, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "اسم المستخدم"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(667, 6)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 19)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "إنشاء مستخدم"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(694, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(348, 419)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(39, 19)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "حفـــظ"
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(760, 138)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ProgressError.ico")
        Me.ImageList1.Images.SetKeyName(1, "ProgressSkip.ico")
        Me.ImageList1.Images.SetKeyName(2, "ProgressWarn.ico")
        Me.ImageList1.Images.SetKeyName(3, "Role.ico")
        Me.ImageList1.Images.SetKeyName(4, "TIJ4MP_C.ico")
        Me.ImageList1.Images.SetKeyName(5, "User3.png")
        Me.ImageList1.Images.SetKeyName(6, "User.png")
        Me.ImageList1.Images.SetKeyName(7, "username[1].png")
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.UsersDBDataSet
        '
        'UsersDBDataSet
        '
        Me.UsersDBDataSet.DataSetName = "UsersDBDataSet"
        Me.UsersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.UsersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'AllRecordsCheckBox
        '
        Me.AllRecordsCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsersBindingSource, "AllRecords", True))
        Me.AllRecordsCheckBox.Location = New System.Drawing.Point(195, 79)
        Me.AllRecordsCheckBox.Name = "AllRecordsCheckBox"
        Me.AllRecordsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AllRecordsCheckBox.TabIndex = 7
        Me.AllRecordsCheckBox.Text = "جميع السجلات"
        Me.AllRecordsCheckBox.UseVisualStyleBackColor = True
        '
        'ManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 447)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ManageUsers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إدارة المستخدمين"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents UsersDBDataSet As BaniasEnergy.UsersDBDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As BaniasEnergy.UsersDBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As BaniasEnergy.UsersDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AllowContractsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowEngeneersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowManagersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowAgentsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowWorkersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AllowSalaryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents AllRecordsCheckBox As System.Windows.Forms.CheckBox
End Class
