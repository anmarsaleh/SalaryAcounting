<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeOutsFrm
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
        Dim TakeoutNameLabel As System.Windows.Forms.Label
        Dim TakeoutDateLabel As System.Windows.Forms.Label
        Dim TakeoutTotalLabel As System.Windows.Forms.Label
        Dim TakeoutMountsLabel As System.Windows.Forms.Label
        Dim TakeoutDiscountLabel As System.Windows.Forms.Label
        Dim TakeoutRemainingLabel As System.Windows.Forms.Label
        Dim RemainingEndateLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BacklogReturnDataGridView = New System.Windows.Forms.DataGridView()
        Me.TakeoutIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeoutNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeoutDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeoutTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeoutMountsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeoutDiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeoutRemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemainingEndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeOutsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaniasEnergyDBDataSet = New BaniasEnergy.BaniasEnergyDBDataSet()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutNameComboBox = New System.Windows.Forms.ComboBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.RemainingEndateTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutRemainingTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutMountsTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutDateTextBox = New System.Windows.Forms.TextBox()
        Me.LastModifyTextBox = New System.Windows.Forms.TextBox()
        Me.CreateDateTextBox = New System.Windows.Forms.TextBox()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.TakeoutIDTextBox = New System.Windows.Forms.TextBox()
        Me.TakeOutsTableAdapter = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TakeOutsTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ControlIDTextBox = New System.Windows.Forms.TextBox()
        Me.IsCloseCheckBox = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        TakeoutNameLabel = New System.Windows.Forms.Label()
        TakeoutDateLabel = New System.Windows.Forms.Label()
        TakeoutTotalLabel = New System.Windows.Forms.Label()
        TakeoutMountsLabel = New System.Windows.Forms.Label()
        TakeoutDiscountLabel = New System.Windows.Forms.Label()
        TakeoutRemainingLabel = New System.Windows.Forms.Label()
        RemainingEndateLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BacklogReturnDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TakeOutsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TakeoutNameLabel
        '
        TakeoutNameLabel.AutoSize = True
        TakeoutNameLabel.Location = New System.Drawing.Point(386, 25)
        TakeoutNameLabel.Name = "TakeoutNameLabel"
        TakeoutNameLabel.Size = New System.Drawing.Size(54, 19)
        TakeoutNameLabel.TabIndex = 0
        TakeoutNameLabel.Text = "إسم البند"
        '
        'TakeoutDateLabel
        '
        TakeoutDateLabel.AutoSize = True
        TakeoutDateLabel.Location = New System.Drawing.Point(395, 57)
        TakeoutDateLabel.Name = "TakeoutDateLabel"
        TakeoutDateLabel.Size = New System.Drawing.Size(45, 19)
        TakeoutDateLabel.TabIndex = 2
        TakeoutDateLabel.Text = "التاريخ"
        '
        'TakeoutTotalLabel
        '
        TakeoutTotalLabel.AutoSize = True
        TakeoutTotalLabel.Location = New System.Drawing.Point(352, 89)
        TakeoutTotalLabel.Name = "TakeoutTotalLabel"
        TakeoutTotalLabel.Size = New System.Drawing.Size(88, 19)
        TakeoutTotalLabel.TabIndex = 4
        TakeoutTotalLabel.Text = "المبلغ الإجمالي"
        '
        'TakeoutMountsLabel
        '
        TakeoutMountsLabel.AutoSize = True
        TakeoutMountsLabel.Location = New System.Drawing.Point(344, 121)
        TakeoutMountsLabel.Name = "TakeoutMountsLabel"
        TakeoutMountsLabel.Size = New System.Drawing.Size(96, 19)
        TakeoutMountsLabel.TabIndex = 6
        TakeoutMountsLabel.Text = "عدد أشهر الحسم"
        TakeoutMountsLabel.Visible = False
        '
        'TakeoutDiscountLabel
        '
        TakeoutDiscountLabel.AutoSize = True
        TakeoutDiscountLabel.Location = New System.Drawing.Point(112, 22)
        TakeoutDiscountLabel.Name = "TakeoutDiscountLabel"
        TakeoutDiscountLabel.Size = New System.Drawing.Size(114, 19)
        TakeoutDiscountLabel.TabIndex = 8
        TakeoutDiscountLabel.Text = "مبلغ الحسم الشهري"
        '
        'TakeoutRemainingLabel
        '
        TakeoutRemainingLabel.AutoSize = True
        TakeoutRemainingLabel.Location = New System.Drawing.Point(136, 53)
        TakeoutRemainingLabel.Name = "TakeoutRemainingLabel"
        TakeoutRemainingLabel.Size = New System.Drawing.Size(81, 19)
        TakeoutRemainingLabel.TabIndex = 10
        TakeoutRemainingLabel.Text = "المبلغ المتبقي"
        '
        'RemainingEndateLabel
        '
        RemainingEndateLabel.AutoSize = True
        RemainingEndateLabel.Location = New System.Drawing.Point(137, 85)
        RemainingEndateLabel.Name = "RemainingEndateLabel"
        RemainingEndateLabel.Size = New System.Drawing.Size(80, 19)
        RemainingEndateLabel.TabIndex = 12
        RemainingEndateLabel.Text = "تاريخ الإنتهاء"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(158, 121)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(59, 19)
        NotesLabel.TabIndex = 14
        NotesLabel.Text = "ملاحضات"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(613, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تمكنك هذة النافذه من إضافة سلف وقروض مختلفة " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "بالإضافة إلى إدخال أقساط الكفلاء أو" & _
    " أي إقتطاعات شهرية متكررة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.UseCompatibleTextRendering = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 48)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(613, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoToolTip = True
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel1.Text = "إضــافة"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoToolTip = True
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel2.Text = "حفــظ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.AutoToolTip = True
        Me.ToolStripLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel3.IsLink = True
        Me.ToolStripLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel3.Text = "حــذف"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.BacklogReturnDataGridView)
        Me.GroupBox2.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox2.Controls.Add(Me.TakeoutNameComboBox)
        Me.GroupBox2.Controls.Add(NotesLabel)
        Me.GroupBox2.Controls.Add(Me.NotesTextBox)
        Me.GroupBox2.Controls.Add(RemainingEndateLabel)
        Me.GroupBox2.Controls.Add(Me.RemainingEndateTextBox)
        Me.GroupBox2.Controls.Add(TakeoutRemainingLabel)
        Me.GroupBox2.Controls.Add(Me.TakeoutRemainingTextBox)
        Me.GroupBox2.Controls.Add(TakeoutDiscountLabel)
        Me.GroupBox2.Controls.Add(Me.TakeoutDiscountTextBox)
        Me.GroupBox2.Controls.Add(TakeoutMountsLabel)
        Me.GroupBox2.Controls.Add(Me.TakeoutMountsTextBox)
        Me.GroupBox2.Controls.Add(TakeoutTotalLabel)
        Me.GroupBox2.Controls.Add(Me.TakeoutTotalTextBox)
        Me.GroupBox2.Controls.Add(TakeoutDateLabel)
        Me.GroupBox2.Controls.Add(Me.TakeoutDateTextBox)
        Me.GroupBox2.Controls.Add(TakeoutNameLabel)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(613, 182)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "البند الحالي"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(330, 151)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 23)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "حساب يدوي"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'BacklogReturnDataGridView
        '
        Me.BacklogReturnDataGridView.AllowUserToAddRows = False
        Me.BacklogReturnDataGridView.AllowUserToDeleteRows = False
        Me.BacklogReturnDataGridView.AutoGenerateColumns = False
        Me.BacklogReturnDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.BacklogReturnDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BacklogReturnDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BacklogReturnDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BacklogReturnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BacklogReturnDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TakeoutIDDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.TakeoutNameDataGridViewTextBoxColumn, Me.TakeoutDateDataGridViewTextBoxColumn, Me.TakeoutTotalDataGridViewTextBoxColumn, Me.TakeoutMountsDataGridViewTextBoxColumn, Me.TakeoutDiscountDataGridViewTextBoxColumn, Me.TakeoutRemainingDataGridViewTextBoxColumn, Me.RemainingEndateDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.CreateDateDataGridViewTextBoxColumn, Me.LastModifyDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.BacklogReturnDataGridView.DataSource = Me.TakeOutsBindingSource
        Me.BacklogReturnDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.BacklogReturnDataGridView.EnableHeadersVisualStyles = False
        Me.BacklogReturnDataGridView.GridColor = System.Drawing.SystemColors.ControlText
        Me.BacklogReturnDataGridView.Location = New System.Drawing.Point(443, 22)
        Me.BacklogReturnDataGridView.MultiSelect = False
        Me.BacklogReturnDataGridView.Name = "BacklogReturnDataGridView"
        Me.BacklogReturnDataGridView.ReadOnly = True
        Me.BacklogReturnDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.BacklogReturnDataGridView.RowHeadersVisible = False
        Me.BacklogReturnDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BacklogReturnDataGridView.Size = New System.Drawing.Size(167, 157)
        Me.BacklogReturnDataGridView.TabIndex = 22
        '
        'TakeoutIDDataGridViewTextBoxColumn
        '
        Me.TakeoutIDDataGridViewTextBoxColumn.DataPropertyName = "TakeoutID"
        Me.TakeoutIDDataGridViewTextBoxColumn.HeaderText = "TakeoutID"
        Me.TakeoutIDDataGridViewTextBoxColumn.Name = "TakeoutIDDataGridViewTextBoxColumn"
        Me.TakeoutIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TakeoutIDDataGridViewTextBoxColumn.Visible = False
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpIDDataGridViewTextBoxColumn.Visible = False
        '
        'TakeoutNameDataGridViewTextBoxColumn
        '
        Me.TakeoutNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TakeoutNameDataGridViewTextBoxColumn.DataPropertyName = "TakeoutName"
        Me.TakeoutNameDataGridViewTextBoxColumn.HeaderText = "إسـم الـبند"
        Me.TakeoutNameDataGridViewTextBoxColumn.Name = "TakeoutNameDataGridViewTextBoxColumn"
        Me.TakeoutNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TakeoutDateDataGridViewTextBoxColumn
        '
        Me.TakeoutDateDataGridViewTextBoxColumn.DataPropertyName = "TakeoutDate"
        Me.TakeoutDateDataGridViewTextBoxColumn.HeaderText = "TakeoutDate"
        Me.TakeoutDateDataGridViewTextBoxColumn.Name = "TakeoutDateDataGridViewTextBoxColumn"
        Me.TakeoutDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TakeoutDateDataGridViewTextBoxColumn.Visible = False
        '
        'TakeoutTotalDataGridViewTextBoxColumn
        '
        Me.TakeoutTotalDataGridViewTextBoxColumn.DataPropertyName = "TakeoutTotal"
        Me.TakeoutTotalDataGridViewTextBoxColumn.HeaderText = "TakeoutTotal"
        Me.TakeoutTotalDataGridViewTextBoxColumn.Name = "TakeoutTotalDataGridViewTextBoxColumn"
        Me.TakeoutTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TakeoutTotalDataGridViewTextBoxColumn.Visible = False
        '
        'TakeoutMountsDataGridViewTextBoxColumn
        '
        Me.TakeoutMountsDataGridViewTextBoxColumn.DataPropertyName = "TakeoutMounts"
        Me.TakeoutMountsDataGridViewTextBoxColumn.HeaderText = "TakeoutMounts"
        Me.TakeoutMountsDataGridViewTextBoxColumn.Name = "TakeoutMountsDataGridViewTextBoxColumn"
        Me.TakeoutMountsDataGridViewTextBoxColumn.ReadOnly = True
        Me.TakeoutMountsDataGridViewTextBoxColumn.Visible = False
        '
        'TakeoutDiscountDataGridViewTextBoxColumn
        '
        Me.TakeoutDiscountDataGridViewTextBoxColumn.DataPropertyName = "TakeoutDiscount"
        Me.TakeoutDiscountDataGridViewTextBoxColumn.HeaderText = "TakeoutDiscount"
        Me.TakeoutDiscountDataGridViewTextBoxColumn.Name = "TakeoutDiscountDataGridViewTextBoxColumn"
        Me.TakeoutDiscountDataGridViewTextBoxColumn.ReadOnly = True
        Me.TakeoutDiscountDataGridViewTextBoxColumn.Visible = False
        '
        'TakeoutRemainingDataGridViewTextBoxColumn
        '
        Me.TakeoutRemainingDataGridViewTextBoxColumn.DataPropertyName = "TakeoutRemaining"
        Me.TakeoutRemainingDataGridViewTextBoxColumn.HeaderText = "TakeoutRemaining"
        Me.TakeoutRemainingDataGridViewTextBoxColumn.Name = "TakeoutRemainingDataGridViewTextBoxColumn"
        Me.TakeoutRemainingDataGridViewTextBoxColumn.ReadOnly = True
        Me.TakeoutRemainingDataGridViewTextBoxColumn.Visible = False
        '
        'RemainingEndateDataGridViewTextBoxColumn
        '
        Me.RemainingEndateDataGridViewTextBoxColumn.DataPropertyName = "RemainingEndate"
        Me.RemainingEndateDataGridViewTextBoxColumn.HeaderText = "RemainingEndate"
        Me.RemainingEndateDataGridViewTextBoxColumn.Name = "RemainingEndateDataGridViewTextBoxColumn"
        Me.RemainingEndateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RemainingEndateDataGridViewTextBoxColumn.Visible = False
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Visible = False
        '
        'CreateDateDataGridViewTextBoxColumn
        '
        Me.CreateDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate"
        Me.CreateDateDataGridViewTextBoxColumn.HeaderText = "CreateDate"
        Me.CreateDateDataGridViewTextBoxColumn.Name = "CreateDateDataGridViewTextBoxColumn"
        Me.CreateDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreateDateDataGridViewTextBoxColumn.Visible = False
        '
        'LastModifyDataGridViewTextBoxColumn
        '
        Me.LastModifyDataGridViewTextBoxColumn.DataPropertyName = "LastModify"
        Me.LastModifyDataGridViewTextBoxColumn.HeaderText = "LastModify"
        Me.LastModifyDataGridViewTextBoxColumn.Name = "LastModifyDataGridViewTextBoxColumn"
        Me.LastModifyDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastModifyDataGridViewTextBoxColumn.Visible = False
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'TakeOutsBindingSource
        '
        Me.TakeOutsBindingSource.DataMember = "TakeOuts"
        Me.TakeOutsBindingSource.DataSource = Me.BaniasEnergyDBDataSet
        '
        'BaniasEnergyDBDataSet
        '
        Me.BaniasEnergyDBDataSet.DataSetName = "BaniasEnergyDBDataSet"
        Me.BaniasEnergyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(158, 149)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(32, 26)
        Me.UserIDTextBox.TabIndex = 21
        '
        'TakeoutNameComboBox
        '
        Me.TakeoutNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutName", True))
        Me.TakeoutNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TakeoutNameComboBox.FormattingEnabled = True
        Me.TakeoutNameComboBox.Location = New System.Drawing.Point(238, 21)
        Me.TakeoutNameComboBox.Name = "TakeoutNameComboBox"
        Me.TakeoutNameComboBox.Size = New System.Drawing.Size(121, 27)
        Me.TakeoutNameComboBox.TabIndex = 18
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(6, 114)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(146, 61)
        Me.NotesTextBox.TabIndex = 15
        '
        'RemainingEndateTextBox
        '
        Me.RemainingEndateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "RemainingEndate", True))
        Me.RemainingEndateTextBox.Location = New System.Drawing.Point(6, 82)
        Me.RemainingEndateTextBox.Name = "RemainingEndateTextBox"
        Me.RemainingEndateTextBox.ReadOnly = True
        Me.RemainingEndateTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RemainingEndateTextBox.TabIndex = 13
        '
        'TakeoutRemainingTextBox
        '
        Me.TakeoutRemainingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutRemaining", True))
        Me.TakeoutRemainingTextBox.Location = New System.Drawing.Point(6, 50)
        Me.TakeoutRemainingTextBox.Name = "TakeoutRemainingTextBox"
        Me.TakeoutRemainingTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TakeoutRemainingTextBox.TabIndex = 11
        '
        'TakeoutDiscountTextBox
        '
        Me.TakeoutDiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutDiscount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.TakeoutDiscountTextBox.Location = New System.Drawing.Point(6, 18)
        Me.TakeoutDiscountTextBox.Name = "TakeoutDiscountTextBox"
        Me.TakeoutDiscountTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TakeoutDiscountTextBox.TabIndex = 9
        '
        'TakeoutMountsTextBox
        '
        Me.TakeoutMountsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutMounts", True))
        Me.TakeoutMountsTextBox.Location = New System.Drawing.Point(238, 118)
        Me.TakeoutMountsTextBox.Name = "TakeoutMountsTextBox"
        Me.TakeoutMountsTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TakeoutMountsTextBox.TabIndex = 7
        Me.TakeoutMountsTextBox.Visible = False
        '
        'TakeoutTotalTextBox
        '
        Me.TakeoutTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutTotal", True))
        Me.TakeoutTotalTextBox.Location = New System.Drawing.Point(238, 86)
        Me.TakeoutTotalTextBox.Name = "TakeoutTotalTextBox"
        Me.TakeoutTotalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TakeoutTotalTextBox.TabIndex = 5
        '
        'TakeoutDateTextBox
        '
        Me.TakeoutDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.TakeoutDateTextBox.Location = New System.Drawing.Point(238, 54)
        Me.TakeoutDateTextBox.Name = "TakeoutDateTextBox"
        Me.TakeoutDateTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TakeoutDateTextBox.TabIndex = 3
        '
        'LastModifyTextBox
        '
        Me.LastModifyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "LastModify", True))
        Me.LastModifyTextBox.Location = New System.Drawing.Point(426, 7)
        Me.LastModifyTextBox.Name = "LastModifyTextBox"
        Me.LastModifyTextBox.Size = New System.Drawing.Size(34, 26)
        Me.LastModifyTextBox.TabIndex = 20
        '
        'CreateDateTextBox
        '
        Me.CreateDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "CreateDate", True))
        Me.CreateDateTextBox.Location = New System.Drawing.Point(388, 11)
        Me.CreateDateTextBox.Name = "CreateDateTextBox"
        Me.CreateDateTextBox.Size = New System.Drawing.Size(32, 26)
        Me.CreateDateTextBox.TabIndex = 19
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "EmpID", True))
        Me.EmpIDTextBox.Location = New System.Drawing.Point(307, 8)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.Size = New System.Drawing.Size(31, 26)
        Me.EmpIDTextBox.TabIndex = 7
        '
        'TakeoutIDTextBox
        '
        Me.TakeoutIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "TakeoutID", True))
        Me.TakeoutIDTextBox.Location = New System.Drawing.Point(352, 11)
        Me.TakeoutIDTextBox.Name = "TakeoutIDTextBox"
        Me.TakeoutIDTextBox.Size = New System.Drawing.Size(30, 26)
        Me.TakeoutIDTextBox.TabIndex = 6
        '
        'TakeOutsTableAdapter
        '
        Me.TakeOutsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BacklogRecoverTableAdapter = Nothing
        Me.TableAdapterManager.BacklogReturnTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CenterNamesTableAdapter = Nothing
        Me.TableAdapterManager.DirectoratesTableAdapter = Nothing
        Me.TableAdapterManager.OfficesTableAdapter = Nothing
        Me.TableAdapterManager.RecoverNamesTableAdapter = Nothing
        Me.TableAdapterManager.ReturnNamesTableAdapter = Nothing
        Me.TableAdapterManager.SalareisControlTableAdapter = Nothing
        Me.TableAdapterManager.SalaryRecordsTableAdapter = Nothing
        Me.TableAdapterManager.SpecializeValuesTableAdapter = Nothing
        Me.TableAdapterManager.TakeOutNamesTableAdapter = Nothing
        Me.TableAdapterManager.TakeOutsTableAdapter = Me.TakeOutsTableAdapter
        Me.TableAdapterManager.TypeSpecializeValuesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.ControlIDTextBox)
        Me.Panel2.Controls.Add(Me.IsCloseCheckBox)
        Me.Panel2.Controls.Add(Me.LastModifyTextBox)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.CreateDateTextBox)
        Me.Panel2.Controls.Add(Me.EmpIDTextBox)
        Me.Panel2.Controls.Add(Me.TakeoutIDTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 45)
        Me.Panel2.TabIndex = 6
        '
        'ControlIDTextBox
        '
        Me.ControlIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TakeOutsBindingSource, "ControlID", True))
        Me.ControlIDTextBox.Location = New System.Drawing.Point(257, 11)
        Me.ControlIDTextBox.Name = "ControlIDTextBox"
        Me.ControlIDTextBox.Size = New System.Drawing.Size(33, 26)
        Me.ControlIDTextBox.TabIndex = 3
        '
        'IsCloseCheckBox
        '
        Me.IsCloseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TakeOutsBindingSource, "IsClose", True))
        Me.IsCloseCheckBox.Location = New System.Drawing.Point(118, 6)
        Me.IsCloseCheckBox.Name = "IsCloseCheckBox"
        Me.IsCloseCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsCloseCheckBox.TabIndex = 2
        Me.IsCloseCheckBox.Text = "CheckBox1"
        Me.IsCloseCheckBox.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 19)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "إغـــلاق"
        '
        'TakeOutsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(613, 300)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "TakeOutsFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "سلف / قروض أخرى"
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BacklogReturnDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TakeOutsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BaniasEnergyDBDataSet As BaniasEnergy.BaniasEnergyDBDataSet
    Friend WithEvents TakeOutsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TakeOutsTableAdapter As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TakeOutsTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemainingEndateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutRemainingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutMountsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TakeoutNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastModifyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreateDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BacklogReturnDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TakeoutIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakeoutNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakeoutDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakeoutTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakeoutMountsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakeoutDiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakeoutRemainingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemainingEndateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsCloseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ControlIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
