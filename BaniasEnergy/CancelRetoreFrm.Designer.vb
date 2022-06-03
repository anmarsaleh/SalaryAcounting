<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelRetoreFrm
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
        Dim DriveMarkLabel As System.Windows.Forms.Label
        Dim DriveVicationLabel As System.Windows.Forms.Label
        Dim DriveMarkValueLabel As System.Windows.Forms.Label
        Dim DriveLabel As System.Windows.Forms.Label
        Dim MutableDaysLabel As System.Windows.Forms.Label
        Dim MutableLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLEmpName = New System.Windows.Forms.Label()
        Me.LblEmpID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCalcelEmp = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnRestoreEmp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.IsWorkersCheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MutableTextBox = New System.Windows.Forms.TextBox()
        Me.MutableDaysTextBox = New System.Windows.Forms.TextBox()
        Me.DriveTextBox = New System.Windows.Forms.TextBox()
        Me.DriveMarkValueTextBox = New System.Windows.Forms.TextBox()
        Me.DriveVicationTextBox = New System.Windows.Forms.TextBox()
        Me.DriveMarkTextBox = New System.Windows.Forms.TextBox()
        Me.IsDriveCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SalarytmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryTmpDataSet = New BaniasEnergy.SalaryTmpDataSet()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarytmpTableAdapter = New BaniasEnergy.SalaryTmpDataSetTableAdapters.SalarytmpTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.SalaryTmpDataSetTableAdapters.TableAdapterManager()
        Me.Button5 = New System.Windows.Forms.Button()
        DriveMarkLabel = New System.Windows.Forms.Label()
        DriveVicationLabel = New System.Windows.Forms.Label()
        DriveMarkValueLabel = New System.Windows.Forms.Label()
        DriveLabel = New System.Windows.Forms.Label()
        MutableDaysLabel = New System.Windows.Forms.Label()
        MutableLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SalarytmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryTmpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DriveMarkLabel
        '
        DriveMarkLabel.AutoSize = True
        DriveMarkLabel.Location = New System.Drawing.Point(172, 33)
        DriveMarkLabel.Name = "DriveMarkLabel"
        DriveMarkLabel.Size = New System.Drawing.Size(53, 24)
        DriveMarkLabel.TabIndex = 2
        DriveMarkLabel.Text = "العلامة"
        '
        'DriveVicationLabel
        '
        DriveVicationLabel.AutoSize = True
        DriveVicationLabel.Location = New System.Drawing.Point(158, 65)
        DriveVicationLabel.Name = "DriveVicationLabel"
        DriveVicationLabel.Size = New System.Drawing.Size(72, 24)
        DriveVicationLabel.TabIndex = 4
        DriveVicationLabel.Text = "استراحات"
        '
        'DriveMarkValueLabel
        '
        DriveMarkValueLabel.AutoSize = True
        DriveMarkValueLabel.Location = New System.Drawing.Point(134, 97)
        DriveMarkValueLabel.Name = "DriveMarkValueLabel"
        DriveMarkValueLabel.Size = New System.Drawing.Size(86, 24)
        DriveMarkValueLabel.TabIndex = 6
        DriveMarkValueLabel.Text = "قيمة العلامة"
        '
        'DriveLabel
        '
        DriveLabel.AutoSize = True
        DriveLabel.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DriveLabel.Location = New System.Drawing.Point(129, 127)
        DriveLabel.Name = "DriveLabel"
        DriveLabel.Size = New System.Drawing.Size(97, 19)
        DriveLabel.TabIndex = 8
        DriveLabel.Text = "تعويض الحوافز"
        '
        'MutableDaysLabel
        '
        MutableDaysLabel.AutoSize = True
        MutableDaysLabel.Location = New System.Drawing.Point(123, 44)
        MutableDaysLabel.Name = "MutableDaysLabel"
        MutableDaysLabel.Size = New System.Drawing.Size(98, 24)
        MutableDaysLabel.TabIndex = 0
        MutableDaysLabel.Text = "عدد الورديات"
        '
        'MutableLabel
        '
        MutableLabel.AutoSize = True
        MutableLabel.Location = New System.Drawing.Point(124, 72)
        MutableLabel.Name = "MutableLabel"
        MutableLabel.Size = New System.Drawing.Size(93, 24)
        MutableLabel.TabIndex = 2
        MutableLabel.Text = "قيمة المتحول"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 383)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.BtnCalcelEmp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(640, 346)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "شطب سجل الموظف"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LBLEmpName)
        Me.Panel1.Controls.Add(Me.LblEmpID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 81)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الرقم:"
        '
        'LBLEmpName
        '
        Me.LBLEmpName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmpName.ForeColor = System.Drawing.Color.Red
        Me.LBLEmpName.Location = New System.Drawing.Point(3, 50)
        Me.LBLEmpName.Name = "LBLEmpName"
        Me.LBLEmpName.Size = New System.Drawing.Size(278, 27)
        Me.LBLEmpName.TabIndex = 3
        Me.LBLEmpName.Text = "Label3"
        Me.LBLEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEmpID
        '
        Me.LblEmpID.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpID.ForeColor = System.Drawing.Color.Red
        Me.LblEmpID.Location = New System.Drawing.Point(287, 50)
        Me.LblEmpID.Name = "LblEmpID"
        Me.LblEmpID.Size = New System.Drawing.Size(94, 27)
        Me.LblEmpID.TabIndex = 2
        Me.LblEmpID.Text = "Label2"
        Me.LblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "سييقوم البرنامج بشطب سجل الموظف الحالي وإيقاف راتبة " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " إختر تنفيذ إجراء الشطب للم" &
    "تابعة"
        '
        'BtnCalcelEmp
        '
        Me.BtnCalcelEmp.Location = New System.Drawing.Point(138, 90)
        Me.BtnCalcelEmp.Name = "BtnCalcelEmp"
        Me.BtnCalcelEmp.Size = New System.Drawing.Size(150, 28)
        Me.BtnCalcelEmp.TabIndex = 0
        Me.BtnCalcelEmp.Text = "تنفيذ إجراء الشطب"
        Me.BtnCalcelEmp.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(640, 346)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "استعادة سجل"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 72)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(634, 271)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.BtnRestoreEmp)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(634, 69)
        Me.Panel3.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(378, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(97, 30)
        Me.TextBox2.TabIndex = 15
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(481, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 29)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "بحث"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnRestoreEmp
        '
        Me.BtnRestoreEmp.Location = New System.Drawing.Point(27, 35)
        Me.BtnRestoreEmp.Name = "BtnRestoreEmp"
        Me.BtnRestoreEmp.Size = New System.Drawing.Size(148, 31)
        Me.BtnRestoreEmp.TabIndex = 1
        Me.BtnRestoreEmp.Text = "تنفيذ إجراء الإستعادة"
        Me.BtnRestoreEmp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "إختر سجل الموظف المراد استعادتة ومن ثم قم بتنفيذ إجراء الإستعادة"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.IsWorkersCheckBox)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(DriveLabel)
        Me.TabPage3.Controls.Add(Me.DriveTextBox)
        Me.TabPage3.Controls.Add(DriveMarkValueLabel)
        Me.TabPage3.Controls.Add(Me.DriveMarkValueTextBox)
        Me.TabPage3.Controls.Add(DriveVicationLabel)
        Me.TabPage3.Controls.Add(Me.DriveVicationTextBox)
        Me.TabPage3.Controls.Add(DriveMarkLabel)
        Me.TabPage3.Controls.Add(Me.DriveMarkTextBox)
        Me.TabPage3.Controls.Add(Me.IsDriveCheckBox)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(640, 346)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "حوافز/طوناج"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'IsWorkersCheckBox
        '
        Me.IsWorkersCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalarytmpBindingSource, "IsWorkers", True))
        Me.IsWorkersCheckBox.Location = New System.Drawing.Point(355, 298)
        Me.IsWorkersCheckBox.Name = "IsWorkersCheckBox"
        Me.IsWorkersCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsWorkersCheckBox.TabIndex = 15
        Me.IsWorkersCheckBox.Text = "عمالية"
        Me.IsWorkersCheckBox.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(478, 300)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 30)
        Me.TextBox1.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(581, 297)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 29)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "بحث"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(MutableLabel)
        Me.GroupBox1.Controls.Add(Me.MutableTextBox)
        Me.GroupBox1.Controls.Add(MutableDaysLabel)
        Me.GroupBox1.Controls.Add(Me.MutableDaysTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 119)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تعويض المتحول"
        '
        'MutableTextBox
        '
        Me.MutableTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalarytmpBindingSource, "mutable", True))
        Me.MutableTextBox.Location = New System.Drawing.Point(17, 69)
        Me.MutableTextBox.Name = "MutableTextBox"
        Me.MutableTextBox.Size = New System.Drawing.Size(100, 30)
        Me.MutableTextBox.TabIndex = 3
        '
        'MutableDaysTextBox
        '
        Me.MutableDaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalarytmpBindingSource, "mutableDays", True))
        Me.MutableDaysTextBox.Location = New System.Drawing.Point(17, 37)
        Me.MutableDaysTextBox.Name = "MutableDaysTextBox"
        Me.MutableDaysTextBox.Size = New System.Drawing.Size(100, 30)
        Me.MutableDaysTextBox.TabIndex = 1
        '
        'DriveTextBox
        '
        Me.DriveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalarytmpBindingSource, "drive", True))
        Me.DriveTextBox.Location = New System.Drawing.Point(27, 127)
        Me.DriveTextBox.Name = "DriveTextBox"
        Me.DriveTextBox.Size = New System.Drawing.Size(100, 30)
        Me.DriveTextBox.TabIndex = 9
        '
        'DriveMarkValueTextBox
        '
        Me.DriveMarkValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalarytmpBindingSource, "DriveMarkValue", True))
        Me.DriveMarkValueTextBox.Location = New System.Drawing.Point(27, 94)
        Me.DriveMarkValueTextBox.Name = "DriveMarkValueTextBox"
        Me.DriveMarkValueTextBox.Size = New System.Drawing.Size(100, 30)
        Me.DriveMarkValueTextBox.TabIndex = 7
        '
        'DriveVicationTextBox
        '
        Me.DriveVicationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalarytmpBindingSource, "DriveVication", True))
        Me.DriveVicationTextBox.Location = New System.Drawing.Point(27, 62)
        Me.DriveVicationTextBox.Name = "DriveVicationTextBox"
        Me.DriveVicationTextBox.Size = New System.Drawing.Size(100, 30)
        Me.DriveVicationTextBox.TabIndex = 5
        '
        'DriveMarkTextBox
        '
        Me.DriveMarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalarytmpBindingSource, "DriveMark", True))
        Me.DriveMarkTextBox.Location = New System.Drawing.Point(27, 30)
        Me.DriveMarkTextBox.Name = "DriveMarkTextBox"
        Me.DriveMarkTextBox.Size = New System.Drawing.Size(100, 30)
        Me.DriveMarkTextBox.TabIndex = 3
        '
        'IsDriveCheckBox
        '
        Me.IsDriveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalarytmpBindingSource, "IsDrive", True))
        Me.IsDriveCheckBox.Location = New System.Drawing.Point(112, 6)
        Me.IsDriveCheckBox.Name = "IsDriveCheckBox"
        Me.IsDriveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsDriveCheckBox.TabIndex = 2
        Me.IsDriveCheckBox.Text = "حوافز"
        Me.IsDriveCheckBox.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SalarytmpBindingSource
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView2.Location = New System.Drawing.Point(231, 3)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(406, 272)
        Me.DataGridView2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 383)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 40)
        Me.Panel2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(524, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 31)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "إغلاق"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SalarytmpBindingSource
        '
        Me.SalarytmpBindingSource.DataMember = "Salarytmp"
        Me.SalarytmpBindingSource.DataSource = Me.SalaryTmpDataSet
        '
        'SalaryTmpDataSet
        '
        Me.SalaryTmpDataSet.DataSetName = "SalaryTmpDataSet"
        Me.SalaryTmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "الرقم الذاتي"
        Me.EmpIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "الإسم الثلاثي"
        Me.FullNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalarytmpTableAdapter
        '
        Me.SalarytmpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalarytmpTableAdapter = Me.SalarytmpTableAdapter
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.SalaryTmpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(10, 300)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(216, 40)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "إلغاء القيم لجميع العاملين"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CancelRetoreFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "CancelRetoreFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "شطب/استعادة موظف"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.SalarytmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryTmpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LBLEmpName As System.Windows.Forms.Label
    Friend WithEvents LblEmpID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCalcelEmp As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnRestoreEmp As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SalaryTmpDataSet As BaniasEnergy.SalaryTmpDataSet
    Friend WithEvents SalarytmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalarytmpTableAdapter As BaniasEnergy.SalaryTmpDataSetTableAdapters.SalarytmpTableAdapter
    Friend WithEvents DriveMarkValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriveVicationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriveMarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsDriveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TableAdapterManager As BaniasEnergy.SalaryTmpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DriveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MutableDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MutableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents IsWorkersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
End Class
