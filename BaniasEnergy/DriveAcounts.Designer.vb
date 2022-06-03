<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriveAcounts
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
        Dim WorkerNoLabel As System.Windows.Forms.Label
        Dim WorkerDaysLabel As System.Windows.Forms.Label
        Dim ConstWorkersLabel As System.Windows.Forms.Label
        Dim TotalProLabel As System.Windows.Forms.Label
        Dim TotalProLabel1 As System.Windows.Forms.Label
        Dim TotalProLabel2 As System.Windows.Forms.Label
        Dim Perc1Label As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim TotRd1Label As System.Windows.Forms.Label
        Dim TotRd2Label As System.Windows.Forms.Label
        Dim MutableUnitLabel As System.Windows.Forms.Label
        Dim TotMuLabel As System.Windows.Forms.Label
        Dim Class1ConstLabel As System.Windows.Forms.Label
        Dim TotClass1Label As System.Windows.Forms.Label
        Dim Class2ConstLabel As System.Windows.Forms.Label
        Dim Class3ConstLabel As System.Windows.Forms.Label
        Dim TotClass2Label As System.Windows.Forms.Label
        Dim TotClass3Label As System.Windows.Forms.Label
        Dim TotalClassesLabel As System.Windows.Forms.Label
        Dim MarkEmpLabel As System.Windows.Forms.Label
        Dim MarkWorkerMLabel As System.Windows.Forms.Label
        Dim TotalMarkEWLabel As System.Windows.Forms.Label
        Dim PlusMarkDriveLabel As System.Windows.Forms.Label
        Dim MarkPriceLabel As System.Windows.Forms.Label
        Dim DriveDateLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DriveAcountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriveDataSet = New BaniasEnergy.DriveDataSet()
        Me.SumDriveMarkValueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DriveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TotalProTextBox = New System.Windows.Forms.TextBox()
        Me.ConstWorkersTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerDaysTextBox = New System.Windows.Forms.TextBox()
        Me.WorkerNoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TotMuTextBox = New System.Windows.Forms.TextBox()
        Me.TotRd1TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MutableUnitTextBox = New System.Windows.Forms.TextBox()
        Me.TotRd2TextBox = New System.Windows.Forms.TextBox()
        Me.TotRd1TextBox = New System.Windows.Forms.TextBox()
        Me.Perc2TextBox = New System.Windows.Forms.TextBox()
        Me.Perc1TextBox = New System.Windows.Forms.TextBox()
        Me.TotalProTextBox2 = New System.Windows.Forms.TextBox()
        Me.TotalProTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalClassesTextBox = New System.Windows.Forms.TextBox()
        Me.TotClass3TextBox = New System.Windows.Forms.TextBox()
        Me.TotClass2TextBox = New System.Windows.Forms.TextBox()
        Me.Class3ConstTextBox = New System.Windows.Forms.TextBox()
        Me.Class2ConstTextBox = New System.Windows.Forms.TextBox()
        Me.TotClass1TextBox = New System.Windows.Forms.TextBox()
        Me.Class1ConstTextBox = New System.Windows.Forms.TextBox()
        Me.MarkEmpTextBox = New System.Windows.Forms.TextBox()
        Me.MarkWorkerMTextBox = New System.Windows.Forms.TextBox()
        Me.TotalMarkEWTextBox = New System.Windows.Forms.TextBox()
        Me.PlusMarkDriveTextBox = New System.Windows.Forms.TextBox()
        Me.MarkPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryYearTextBox = New System.Windows.Forms.TextBox()
        Me.SalarymonthTextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DriveAcountsTableAdapter = New BaniasEnergy.DriveDataSetTableAdapters.DriveAcountsTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.DriveDataSetTableAdapters.TableAdapterManager()
        Me.SumDriveMarkValueTableAdapter = New BaniasEnergy.DriveDataSetTableAdapters.SumDriveMarkValueTableAdapter()
        WorkerNoLabel = New System.Windows.Forms.Label()
        WorkerDaysLabel = New System.Windows.Forms.Label()
        ConstWorkersLabel = New System.Windows.Forms.Label()
        TotalProLabel = New System.Windows.Forms.Label()
        TotalProLabel1 = New System.Windows.Forms.Label()
        TotalProLabel2 = New System.Windows.Forms.Label()
        Perc1Label = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        TotRd1Label = New System.Windows.Forms.Label()
        TotRd2Label = New System.Windows.Forms.Label()
        MutableUnitLabel = New System.Windows.Forms.Label()
        TotMuLabel = New System.Windows.Forms.Label()
        Class1ConstLabel = New System.Windows.Forms.Label()
        TotClass1Label = New System.Windows.Forms.Label()
        Class2ConstLabel = New System.Windows.Forms.Label()
        Class3ConstLabel = New System.Windows.Forms.Label()
        TotClass2Label = New System.Windows.Forms.Label()
        TotClass3Label = New System.Windows.Forms.Label()
        TotalClassesLabel = New System.Windows.Forms.Label()
        MarkEmpLabel = New System.Windows.Forms.Label()
        MarkWorkerMLabel = New System.Windows.Forms.Label()
        TotalMarkEWLabel = New System.Windows.Forms.Label()
        PlusMarkDriveLabel = New System.Windows.Forms.Label()
        MarkPriceLabel = New System.Windows.Forms.Label()
        DriveDateLabel = New System.Windows.Forms.Label()
        CType(Me.DriveAcountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SumDriveMarkValueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'WorkerNoLabel
        '
        WorkerNoLabel.AutoSize = True
        WorkerNoLabel.Location = New System.Drawing.Point(563, 24)
        WorkerNoLabel.Name = "WorkerNoLabel"
        WorkerNoLabel.Size = New System.Drawing.Size(57, 13)
        WorkerNoLabel.TabIndex = 0
        WorkerNoLabel.Text = "عدد العمال"
        '
        'WorkerDaysLabel
        '
        WorkerDaysLabel.AutoSize = True
        WorkerDaysLabel.Location = New System.Drawing.Point(429, 24)
        WorkerDaysLabel.Name = "WorkerDaysLabel"
        WorkerDaysLabel.Size = New System.Drawing.Size(65, 13)
        WorkerDaysLabel.TabIndex = 2
        WorkerDaysLabel.Text = "الأيام الفعلية"
        '
        'ConstWorkersLabel
        '
        ConstWorkersLabel.AutoSize = True
        ConstWorkersLabel.Location = New System.Drawing.Point(343, 24)
        ConstWorkersLabel.Name = "ConstWorkersLabel"
        ConstWorkersLabel.Size = New System.Drawing.Size(26, 13)
        ConstWorkersLabel.TabIndex = 4
        ConstWorkersLabel.Text = "ثابت"
        '
        'TotalProLabel
        '
        TotalProLabel.AutoSize = True
        TotalProLabel.Location = New System.Drawing.Point(80, 21)
        TotalProLabel.Name = "TotalProLabel"
        TotalProLabel.Size = New System.Drawing.Size(203, 13)
        TotalProLabel.TabIndex = 6
        TotalProLabel.Text = "كمية الإنتاج المقدرة للعامل الواحد في اليوم"
        '
        'TotalProLabel1
        '
        TotalProLabel1.AutoSize = True
        TotalProLabel1.Location = New System.Drawing.Point(349, 35)
        TotalProLabel1.Name = "TotalProLabel1"
        TotalProLabel1.Size = New System.Drawing.Size(78, 13)
        TotalProLabel1.TabIndex = 0
        TotalProLabel1.Text = "الشريحة الأولى"
        '
        'TotalProLabel2
        '
        TotalProLabel2.AutoSize = True
        TotalProLabel2.Location = New System.Drawing.Point(352, 61)
        TotalProLabel2.Name = "TotalProLabel2"
        TotalProLabel2.Size = New System.Drawing.Size(75, 13)
        TotalProLabel2.TabIndex = 2
        TotalProLabel2.Text = "الشريحة الثانية"
        '
        'Perc1Label
        '
        Perc1Label.AutoSize = True
        Perc1Label.Location = New System.Drawing.Point(207, 35)
        Perc1Label.Name = "Perc1Label"
        Perc1Label.Size = New System.Drawing.Size(54, 13)
        Perc1Label.TabIndex = 4
        Perc1Label.Text = "نسبة ثابتة"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(207, 61)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 8
        Label2.Text = "نسبة ثابتة"
        '
        'TotRd1Label
        '
        TotRd1Label.AutoSize = True
        TotRd1Label.Location = New System.Drawing.Point(88, 35)
        TotRd1Label.Name = "TotRd1Label"
        TotRd1Label.Size = New System.Drawing.Size(31, 13)
        TotRd1Label.TabIndex = 8
        TotRd1Label.Text = "الناتج"
        '
        'TotRd2Label
        '
        TotRd2Label.AutoSize = True
        TotRd2Label.Location = New System.Drawing.Point(88, 61)
        TotRd2Label.Name = "TotRd2Label"
        TotRd2Label.Size = New System.Drawing.Size(31, 13)
        TotRd2Label.TabIndex = 10
        TotRd2Label.Text = "الناتج"
        '
        'MutableUnitLabel
        '
        MutableUnitLabel.AutoSize = True
        MutableUnitLabel.Location = New System.Drawing.Point(295, 94)
        MutableUnitLabel.Name = "MutableUnitLabel"
        MutableUnitLabel.Size = New System.Drawing.Size(132, 13)
        MutableUnitLabel.TabIndex = 12
        MutableUnitLabel.Text = "كمية الطوناج الداخل والخارج"
        '
        'TotMuLabel
        '
        TotMuLabel.AutoSize = True
        TotMuLabel.Location = New System.Drawing.Point(92, 98)
        TotMuLabel.Name = "TotMuLabel"
        TotMuLabel.Size = New System.Drawing.Size(15, 13)
        TotMuLabel.TabIndex = 16
        TotMuLabel.Text = "="
        '
        'Class1ConstLabel
        '
        Class1ConstLabel.AutoSize = True
        Class1ConstLabel.Location = New System.Drawing.Point(239, 22)
        Class1ConstLabel.Name = "Class1ConstLabel"
        Class1ConstLabel.Size = New System.Drawing.Size(100, 13)
        Class1ConstLabel.TabIndex = 0
        Class1ConstLabel.Text = "ثابت الشريحة الأولى"
        '
        'TotClass1Label
        '
        TotClass1Label.AutoSize = True
        TotClass1Label.Location = New System.Drawing.Point(119, 22)
        TotClass1Label.Name = "TotClass1Label"
        TotClass1Label.Size = New System.Drawing.Size(59, 13)
        TotClass1Label.TabIndex = 2
        TotClass1Label.Text = "كتلة العلاوة"
        '
        'Class2ConstLabel
        '
        Class2ConstLabel.AutoSize = True
        Class2ConstLabel.Location = New System.Drawing.Point(242, 48)
        Class2ConstLabel.Name = "Class2ConstLabel"
        Class2ConstLabel.Size = New System.Drawing.Size(97, 13)
        Class2ConstLabel.TabIndex = 4
        Class2ConstLabel.Text = "ثابت الشريحة الثانية"
        '
        'Class3ConstLabel
        '
        Class3ConstLabel.AutoSize = True
        Class3ConstLabel.Location = New System.Drawing.Point(242, 74)
        Class3ConstLabel.Name = "Class3ConstLabel"
        Class3ConstLabel.Size = New System.Drawing.Size(97, 13)
        Class3ConstLabel.TabIndex = 6
        Class3ConstLabel.Text = "ثابت الشريحة الثالثة"
        '
        'TotClass2Label
        '
        TotClass2Label.AutoSize = True
        TotClass2Label.Location = New System.Drawing.Point(119, 51)
        TotClass2Label.Name = "TotClass2Label"
        TotClass2Label.Size = New System.Drawing.Size(59, 13)
        TotClass2Label.TabIndex = 8
        TotClass2Label.Text = "كتلة العلاوة"
        '
        'TotClass3Label
        '
        TotClass3Label.AutoSize = True
        TotClass3Label.Location = New System.Drawing.Point(119, 77)
        TotClass3Label.Name = "TotClass3Label"
        TotClass3Label.Size = New System.Drawing.Size(59, 13)
        TotClass3Label.TabIndex = 10
        TotClass3Label.Text = "كتلة العلاوة"
        '
        'TotalClassesLabel
        '
        TotalClassesLabel.AutoSize = True
        TotalClassesLabel.Location = New System.Drawing.Point(119, 103)
        TotalClassesLabel.Name = "TotalClassesLabel"
        TotalClassesLabel.Size = New System.Drawing.Size(92, 13)
        TotalClassesLabel.TabIndex = 12
        TotalClassesLabel.Text = "مجموع كتل العلاوة"
        '
        'MarkEmpLabel
        '
        MarkEmpLabel.AutoSize = True
        MarkEmpLabel.Location = New System.Drawing.Point(381, 290)
        MarkEmpLabel.Name = "MarkEmpLabel"
        MarkEmpLabel.Size = New System.Drawing.Size(103, 13)
        MarkEmpLabel.TabIndex = 5
        MarkEmpLabel.Text = "علامات المستخدمين"
        '
        'MarkWorkerMLabel
        '
        MarkWorkerMLabel.AutoSize = True
        MarkWorkerMLabel.Location = New System.Drawing.Point(381, 316)
        MarkWorkerMLabel.Name = "MarkWorkerMLabel"
        MarkWorkerMLabel.Size = New System.Drawing.Size(97, 13)
        MarkWorkerMLabel.TabIndex = 7
        MarkWorkerMLabel.Text = "علامات عمال الإنتاج"
        '
        'TotalMarkEWLabel
        '
        TotalMarkEWLabel.AutoSize = True
        TotalMarkEWLabel.Location = New System.Drawing.Point(381, 345)
        TotalMarkEWLabel.Name = "TotalMarkEWLabel"
        TotalMarkEWLabel.Size = New System.Drawing.Size(80, 13)
        TotalMarkEWLabel.TabIndex = 9
        TotalMarkEWLabel.Text = "مجموع العلامات"
        '
        'PlusMarkDriveLabel
        '
        PlusMarkDriveLabel.AutoSize = True
        PlusMarkDriveLabel.Location = New System.Drawing.Point(18, 412)
        PlusMarkDriveLabel.Name = "PlusMarkDriveLabel"
        PlusMarkDriveLabel.Size = New System.Drawing.Size(59, 13)
        PlusMarkDriveLabel.TabIndex = 11
        PlusMarkDriveLabel.Text = "فائض حوافز"
        '
        'MarkPriceLabel
        '
        MarkPriceLabel.AutoSize = True
        MarkPriceLabel.Location = New System.Drawing.Point(196, 412)
        MarkPriceLabel.Name = "MarkPriceLabel"
        MarkPriceLabel.Size = New System.Drawing.Size(64, 13)
        MarkPriceLabel.TabIndex = 13
        MarkPriceLabel.Text = "سعر العلامة"
        '
        'DriveDateLabel
        '
        DriveDateLabel.AutoSize = True
        DriveDateLabel.Location = New System.Drawing.Point(595, 21)
        DriveDateLabel.Name = "DriveDateLabel"
        DriveDateLabel.Size = New System.Drawing.Size(35, 13)
        DriveDateLabel.TabIndex = 4
        DriveDateLabel.Text = "التاريخ"
        '
        'DriveAcountsBindingSource
        '
        Me.DriveAcountsBindingSource.DataMember = "DriveAcounts"
        Me.DriveAcountsBindingSource.DataSource = Me.DriveDataSet
        '
        'DriveDataSet
        '
        Me.DriveDataSet.DataSetName = "DriveDataSet"
        Me.DriveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SumDriveMarkValueBindingSource
        '
        Me.SumDriveMarkValueBindingSource.DataMember = "SumDriveMarkValue"
        Me.SumDriveMarkValueBindingSource.DataSource = Me.DriveDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(DriveDateLabel)
        Me.Panel1.Controls.Add(Me.DriveDateDateTimePicker)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 52)
        Me.Panel1.TabIndex = 0
        '
        'DriveDateDateTimePicker
        '
        Me.DriveDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DriveAcountsBindingSource, "DriveDate", True))
        Me.DriveDateDateTimePicker.Location = New System.Drawing.Point(468, 18)
        Me.DriveDateDateTimePicker.Name = "DriveDateDateTimePicker"
        Me.DriveDateDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.DriveDateDateTimePicker.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "تصفية"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "إختر تاريخ"
        Me.Label1.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(299, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "علامة الحوافز المرحلة"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 440)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 46)
        Me.Panel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(107, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 40)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "تقرير العلامة"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "إغلاق"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(342, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "عرض التقرير"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حساب وحفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TotalProLabel)
        Me.GroupBox1.Controls.Add(Me.TotalProTextBox)
        Me.GroupBox1.Controls.Add(ConstWorkersLabel)
        Me.GroupBox1.Controls.Add(Me.ConstWorkersTextBox)
        Me.GroupBox1.Controls.Add(WorkerDaysLabel)
        Me.GroupBox1.Controls.Add(Me.WorkerDaysTextBox)
        Me.GroupBox1.Controls.Add(WorkerNoLabel)
        Me.GroupBox1.Controls.Add(Me.WorkerNoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 54)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "الإنتاج المعياري"
        '
        'TotalProTextBox
        '
        Me.TotalProTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotalPro", True))
        Me.TotalProTextBox.Location = New System.Drawing.Point(5, 21)
        Me.TotalProTextBox.Name = "TotalProTextBox"
        Me.TotalProTextBox.Size = New System.Drawing.Size(76, 20)
        Me.TotalProTextBox.TabIndex = 7
        '
        'ConstWorkersTextBox
        '
        Me.ConstWorkersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "ConstWorkers", True))
        Me.ConstWorkersTextBox.Location = New System.Drawing.Point(289, 21)
        Me.ConstWorkersTextBox.Name = "ConstWorkersTextBox"
        Me.ConstWorkersTextBox.Size = New System.Drawing.Size(48, 20)
        Me.ConstWorkersTextBox.TabIndex = 5
        '
        'WorkerDaysTextBox
        '
        Me.WorkerDaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "WorkerDays", True))
        Me.WorkerDaysTextBox.Location = New System.Drawing.Point(375, 21)
        Me.WorkerDaysTextBox.Name = "WorkerDaysTextBox"
        Me.WorkerDaysTextBox.Size = New System.Drawing.Size(48, 20)
        Me.WorkerDaysTextBox.TabIndex = 3
        '
        'WorkerNoTextBox
        '
        Me.WorkerNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "WorkerNo", True))
        Me.WorkerNoTextBox.Location = New System.Drawing.Point(509, 21)
        Me.WorkerNoTextBox.Name = "WorkerNoTextBox"
        Me.WorkerNoTextBox.Size = New System.Drawing.Size(48, 20)
        Me.WorkerNoTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(TotMuLabel)
        Me.GroupBox2.Controls.Add(Me.TotMuTextBox)
        Me.GroupBox2.Controls.Add(Me.TotRd1TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(MutableUnitLabel)
        Me.GroupBox2.Controls.Add(Me.MutableUnitTextBox)
        Me.GroupBox2.Controls.Add(TotRd2Label)
        Me.GroupBox2.Controls.Add(Me.TotRd2TextBox)
        Me.GroupBox2.Controls.Add(TotRd1Label)
        Me.GroupBox2.Controls.Add(Me.TotRd1TextBox)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.Perc2TextBox)
        Me.GroupBox2.Controls.Add(Perc1Label)
        Me.GroupBox2.Controls.Add(Me.Perc1TextBox)
        Me.GroupBox2.Controls.Add(TotalProLabel2)
        Me.GroupBox2.Controls.Add(Me.TotalProTextBox2)
        Me.GroupBox2.Controls.Add(TotalProLabel1)
        Me.GroupBox2.Controls.Add(Me.TotalProTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 124)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "حد الأداء الحافزي"
        '
        'TotMuTextBox
        '
        Me.TotMuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotMu", True))
        Me.TotMuTextBox.Location = New System.Drawing.Point(6, 91)
        Me.TotMuTextBox.Name = "TotMuTextBox"
        Me.TotMuTextBox.Size = New System.Drawing.Size(76, 20)
        Me.TotMuTextBox.TabIndex = 17
        '
        'TotRd1TextBox1
        '
        Me.TotRd1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotRd1", True))
        Me.TotRd1TextBox1.Location = New System.Drawing.Point(114, 91)
        Me.TotRd1TextBox1.Name = "TotRd1TextBox1"
        Me.TotRd1TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TotRd1TextBox1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "-"
        '
        'MutableUnitTextBox
        '
        Me.MutableUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "MutableUnit", True))
        Me.MutableUnitTextBox.Location = New System.Drawing.Point(213, 91)
        Me.MutableUnitTextBox.Name = "MutableUnitTextBox"
        Me.MutableUnitTextBox.Size = New System.Drawing.Size(76, 20)
        Me.MutableUnitTextBox.TabIndex = 13
        '
        'TotRd2TextBox
        '
        Me.TotRd2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotRd2", True))
        Me.TotRd2TextBox.Location = New System.Drawing.Point(6, 58)
        Me.TotRd2TextBox.Name = "TotRd2TextBox"
        Me.TotRd2TextBox.Size = New System.Drawing.Size(76, 20)
        Me.TotRd2TextBox.TabIndex = 11
        '
        'TotRd1TextBox
        '
        Me.TotRd1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotRd1", True))
        Me.TotRd1TextBox.Location = New System.Drawing.Point(6, 32)
        Me.TotRd1TextBox.Name = "TotRd1TextBox"
        Me.TotRd1TextBox.Size = New System.Drawing.Size(76, 20)
        Me.TotRd1TextBox.TabIndex = 9
        '
        'Perc2TextBox
        '
        Me.Perc2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "Perc2", True))
        Me.Perc2TextBox.Location = New System.Drawing.Point(125, 58)
        Me.Perc2TextBox.Name = "Perc2TextBox"
        Me.Perc2TextBox.Size = New System.Drawing.Size(76, 20)
        Me.Perc2TextBox.TabIndex = 7
        '
        'Perc1TextBox
        '
        Me.Perc1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "Perc1", True))
        Me.Perc1TextBox.Location = New System.Drawing.Point(125, 32)
        Me.Perc1TextBox.Name = "Perc1TextBox"
        Me.Perc1TextBox.Size = New System.Drawing.Size(76, 20)
        Me.Perc1TextBox.TabIndex = 5
        '
        'TotalProTextBox2
        '
        Me.TotalProTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotalPro", True))
        Me.TotalProTextBox2.Location = New System.Drawing.Point(267, 58)
        Me.TotalProTextBox2.Name = "TotalProTextBox2"
        Me.TotalProTextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TotalProTextBox2.TabIndex = 3
        '
        'TotalProTextBox1
        '
        Me.TotalProTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotalPro", True))
        Me.TotalProTextBox1.Location = New System.Drawing.Point(267, 32)
        Me.TotalProTextBox1.Name = "TotalProTextBox1"
        Me.TotalProTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TotalProTextBox1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(TotalClassesLabel)
        Me.GroupBox3.Controls.Add(Me.TotalClassesTextBox)
        Me.GroupBox3.Controls.Add(TotClass3Label)
        Me.GroupBox3.Controls.Add(Me.TotClass3TextBox)
        Me.GroupBox3.Controls.Add(TotClass2Label)
        Me.GroupBox3.Controls.Add(Me.TotClass2TextBox)
        Me.GroupBox3.Controls.Add(Class3ConstLabel)
        Me.GroupBox3.Controls.Add(Me.Class3ConstTextBox)
        Me.GroupBox3.Controls.Add(Class2ConstLabel)
        Me.GroupBox3.Controls.Add(Me.Class2ConstTextBox)
        Me.GroupBox3.Controls.Add(TotClass1Label)
        Me.GroupBox3.Controls.Add(Me.TotClass1TextBox)
        Me.GroupBox3.Controls.Add(Class1ConstLabel)
        Me.GroupBox3.Controls.Add(Me.Class1ConstTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 268)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 135)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "كتلة العلاوة للشرائح"
        '
        'TotalClassesTextBox
        '
        Me.TotalClassesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotalClasses", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TotalClassesTextBox.Location = New System.Drawing.Point(13, 100)
        Me.TotalClassesTextBox.Name = "TotalClassesTextBox"
        Me.TotalClassesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalClassesTextBox.TabIndex = 13
        '
        'TotClass3TextBox
        '
        Me.TotClass3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotClass3", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TotClass3TextBox.Location = New System.Drawing.Point(13, 74)
        Me.TotClass3TextBox.Name = "TotClass3TextBox"
        Me.TotClass3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotClass3TextBox.TabIndex = 11
        '
        'TotClass2TextBox
        '
        Me.TotClass2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotClass2", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TotClass2TextBox.Location = New System.Drawing.Point(13, 48)
        Me.TotClass2TextBox.Name = "TotClass2TextBox"
        Me.TotClass2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotClass2TextBox.TabIndex = 9
        '
        'Class3ConstTextBox
        '
        Me.Class3ConstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "Class3Const", True))
        Me.Class3ConstTextBox.Location = New System.Drawing.Point(190, 71)
        Me.Class3ConstTextBox.Name = "Class3ConstTextBox"
        Me.Class3ConstTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Class3ConstTextBox.TabIndex = 7
        '
        'Class2ConstTextBox
        '
        Me.Class2ConstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "Class2Const", True))
        Me.Class2ConstTextBox.Location = New System.Drawing.Point(190, 45)
        Me.Class2ConstTextBox.Name = "Class2ConstTextBox"
        Me.Class2ConstTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Class2ConstTextBox.TabIndex = 5
        '
        'TotClass1TextBox
        '
        Me.TotClass1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotClass1", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"))
        Me.TotClass1TextBox.Location = New System.Drawing.Point(13, 19)
        Me.TotClass1TextBox.Name = "TotClass1TextBox"
        Me.TotClass1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotClass1TextBox.TabIndex = 3
        '
        'Class1ConstTextBox
        '
        Me.Class1ConstTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "Class1Const", True))
        Me.Class1ConstTextBox.Location = New System.Drawing.Point(190, 19)
        Me.Class1ConstTextBox.Name = "Class1ConstTextBox"
        Me.Class1ConstTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Class1ConstTextBox.TabIndex = 1
        '
        'MarkEmpTextBox
        '
        Me.MarkEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "MarkEmp", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.MarkEmpTextBox.Location = New System.Drawing.Point(490, 287)
        Me.MarkEmpTextBox.Name = "MarkEmpTextBox"
        Me.MarkEmpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarkEmpTextBox.TabIndex = 6
        '
        'MarkWorkerMTextBox
        '
        Me.MarkWorkerMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "MarkWorkerM", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.MarkWorkerMTextBox.Location = New System.Drawing.Point(490, 313)
        Me.MarkWorkerMTextBox.Name = "MarkWorkerMTextBox"
        Me.MarkWorkerMTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarkWorkerMTextBox.TabIndex = 8
        '
        'TotalMarkEWTextBox
        '
        Me.TotalMarkEWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "TotalMarkEW", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TotalMarkEWTextBox.Location = New System.Drawing.Point(490, 339)
        Me.TotalMarkEWTextBox.Name = "TotalMarkEWTextBox"
        Me.TotalMarkEWTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalMarkEWTextBox.TabIndex = 10
        '
        'PlusMarkDriveTextBox
        '
        Me.PlusMarkDriveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "PlusMarkDrive", True))
        Me.PlusMarkDriveTextBox.Location = New System.Drawing.Point(87, 409)
        Me.PlusMarkDriveTextBox.Name = "PlusMarkDriveTextBox"
        Me.PlusMarkDriveTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlusMarkDriveTextBox.TabIndex = 12
        '
        'MarkPriceTextBox
        '
        Me.MarkPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "MarkPrice", True))
        Me.MarkPriceTextBox.Location = New System.Drawing.Point(262, 409)
        Me.MarkPriceTextBox.Name = "MarkPriceTextBox"
        Me.MarkPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarkPriceTextBox.TabIndex = 14
        '
        'SalaryYearTextBox
        '
        Me.SalaryYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "SalaryYear", True))
        Me.SalaryYearTextBox.Location = New System.Drawing.Point(574, 414)
        Me.SalaryYearTextBox.Name = "SalaryYearTextBox"
        Me.SalaryYearTextBox.Size = New System.Drawing.Size(33, 20)
        Me.SalaryYearTextBox.TabIndex = 16
        '
        'SalarymonthTextBox
        '
        Me.SalarymonthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DriveAcountsBindingSource, "Salarymonth", True))
        Me.SalarymonthTextBox.Location = New System.Drawing.Point(613, 414)
        Me.SalarymonthTextBox.Name = "SalarymonthTextBox"
        Me.SalarymonthTextBox.Size = New System.Drawing.Size(30, 20)
        Me.SalarymonthTextBox.TabIndex = 17
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 98
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DriveAcountsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BaniasEnergy.DriveAcount.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(534, 143)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(109, 89)
        Me.ReportViewer1.TabIndex = 18
        Me.ReportViewer1.Visible = False
        '
        'ReportViewer2
        '
        Me.ReportViewer2.DocumentMapWidth = 69
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SumDriveMarkValueBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "BaniasEnergy.Report1.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(567, 236)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(71, 49)
        Me.ReportViewer2.TabIndex = 19
        Me.ReportViewer2.Visible = False
        '
        'DriveAcountsTableAdapter
        '
        Me.DriveAcountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DriveAcountsTableAdapter = Me.DriveAcountsTableAdapter
        Me.TableAdapterManager.MarkDriveTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.DriveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SumDriveMarkValueTableAdapter
        '
        Me.SumDriveMarkValueTableAdapter.ClearBeforeFill = True
        '
        'DriveAcounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 486)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.SalarymonthTextBox)
        Me.Controls.Add(Me.SalaryYearTextBox)
        Me.Controls.Add(MarkPriceLabel)
        Me.Controls.Add(Me.MarkPriceTextBox)
        Me.Controls.Add(PlusMarkDriveLabel)
        Me.Controls.Add(Me.PlusMarkDriveTextBox)
        Me.Controls.Add(TotalMarkEWLabel)
        Me.Controls.Add(Me.TotalMarkEWTextBox)
        Me.Controls.Add(MarkWorkerMLabel)
        Me.Controls.Add(Me.MarkWorkerMTextBox)
        Me.Controls.Add(MarkEmpLabel)
        Me.Controls.Add(Me.MarkEmpTextBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DriveAcounts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "علامة الحوافز الإنتاجية"
        CType(Me.DriveAcountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SumDriveMarkValueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DriveDataSet As BaniasEnergy.DriveDataSet
    Friend WithEvents DriveAcountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriveAcountsTableAdapter As BaniasEnergy.DriveDataSetTableAdapters.DriveAcountsTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.DriveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkerNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkerDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConstWorkersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalProTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalProTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TotalProTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TotMuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotRd1TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MutableUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotRd2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotRd1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Perc2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Perc1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalClassesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotClass3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotClass2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Class3ConstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Class2ConstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotClass1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Class1ConstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkWorkerMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalMarkEWTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlusMarkDriveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarkPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriveDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalaryYearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalarymonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SumDriveMarkValueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SumDriveMarkValueTableAdapter As BaniasEnergy.DriveDataSetTableAdapters.SumDriveMarkValueTableAdapter
End Class
