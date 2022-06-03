<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoverFromEmpFrm
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
        Dim BacklogNameLabel As System.Windows.Forms.Label
        Dim BacklogTotalLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecoverFromEmpFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ControlIDTextBox = New System.Windows.Forms.TextBox()
        Me.LastModifyTextBox = New System.Windows.Forms.TextBox()
        Me.CreateDateTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.RM_RemainingTextBox = New System.Windows.Forms.TextBox()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.BacklogRCIDTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReturnOnlyTaxCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReturnTaxCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BacklogTotalTextBox1 = New System.Windows.Forms.TextBox()
        Me.BacklogReturnDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.RepeatedMountsTextBox = New System.Windows.Forms.TextBox()
        Me.IsRepeatedCheckBox = New System.Windows.Forms.CheckBox()
        Me.BacklogNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.حذفالبندالمحددلجميعالعاملينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BacklogRecoverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaniasEnergyDBDataSet = New BaniasEnergy.BaniasEnergyDBDataSet()
        Me.BacklogRCIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BacklogNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BacklogTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsRepeatedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RepeatedMountsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RMRemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BacklogRecoverTableAdapter = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.BacklogRecoverTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager()
        BacklogNameLabel = New System.Windows.Forms.Label()
        BacklogTotalLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BacklogReturnDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BacklogRecoverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BacklogNameLabel
        '
        BacklogNameLabel.AutoSize = True
        BacklogNameLabel.Location = New System.Drawing.Point(306, 14)
        BacklogNameLabel.Name = "BacklogNameLabel"
        BacklogNameLabel.Size = New System.Drawing.Size(68, 19)
        BacklogNameLabel.TabIndex = 1
        BacklogNameLabel.Text = "أضف/إختر "
        '
        'BacklogTotalLabel
        '
        BacklogTotalLabel.AutoSize = True
        BacklogTotalLabel.Location = New System.Drawing.Point(95, 14)
        BacklogTotalLabel.Name = "BacklogTotalLabel"
        BacklogTotalLabel.Size = New System.Drawing.Size(83, 19)
        BacklogTotalLabel.TabIndex = 3
        BacklogTotalLabel.Text = "مبلغ الإسترداد"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(304, 131)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(70, 19)
        NotesLabel.TabIndex = 8
        NotesLabel.Text = "ملاحـــــظات"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 31)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تمكنك هذه الواجهة من إضافة  عدة بنود لإسترداد مبالغ من الراتب"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ControlIDTextBox)
        Me.Panel2.Controls.Add(Me.LastModifyTextBox)
        Me.Panel2.Controls.Add(Me.CreateDateTextBox)
        Me.Panel2.Controls.Add(Me.UserIDTextBox)
        Me.Panel2.Controls.Add(Me.RM_RemainingTextBox)
        Me.Panel2.Controls.Add(Me.EmpIDTextBox)
        Me.Panel2.Controls.Add(Me.BacklogRCIDTextBox)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 257)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(587, 32)
        Me.Panel2.TabIndex = 1
        '
        'ControlIDTextBox
        '
        Me.ControlIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "ControlID", True))
        Me.ControlIDTextBox.Location = New System.Drawing.Point(328, 6)
        Me.ControlIDTextBox.Name = "ControlIDTextBox"
        Me.ControlIDTextBox.Size = New System.Drawing.Size(36, 26)
        Me.ControlIDTextBox.TabIndex = 18
        '
        'LastModifyTextBox
        '
        Me.LastModifyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "LastModify", True))
        Me.LastModifyTextBox.Location = New System.Drawing.Point(291, 6)
        Me.LastModifyTextBox.Name = "LastModifyTextBox"
        Me.LastModifyTextBox.Size = New System.Drawing.Size(31, 26)
        Me.LastModifyTextBox.TabIndex = 12
        '
        'CreateDateTextBox
        '
        Me.CreateDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "CreateDate", True))
        Me.CreateDateTextBox.Location = New System.Drawing.Point(249, 6)
        Me.CreateDateTextBox.Name = "CreateDateTextBox"
        Me.CreateDateTextBox.Size = New System.Drawing.Size(36, 26)
        Me.CreateDateTextBox.TabIndex = 11
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(208, 3)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(35, 26)
        Me.UserIDTextBox.TabIndex = 10
        '
        'RM_RemainingTextBox
        '
        Me.RM_RemainingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "RM_Remaining", True))
        Me.RM_RemainingTextBox.Location = New System.Drawing.Point(165, 6)
        Me.RM_RemainingTextBox.Name = "RM_RemainingTextBox"
        Me.RM_RemainingTextBox.Size = New System.Drawing.Size(37, 26)
        Me.RM_RemainingTextBox.TabIndex = 9
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "EmpID", True))
        Me.EmpIDTextBox.Location = New System.Drawing.Point(115, 6)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.Size = New System.Drawing.Size(44, 26)
        Me.EmpIDTextBox.TabIndex = 4
        '
        'BacklogRCIDTextBox
        '
        Me.BacklogRCIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "BacklogRCID", True))
        Me.BacklogRCIDTextBox.Location = New System.Drawing.Point(70, 6)
        Me.BacklogRCIDTextBox.Name = "BacklogRCIDTextBox"
        Me.BacklogRCIDTextBox.Size = New System.Drawing.Size(39, 26)
        Me.BacklogRCIDTextBox.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 19)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "إغـــلاق"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.ReturnOnlyTaxCheckBox)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.ReturnTaxCheckBox)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BacklogTotalTextBox1)
        Me.Panel3.Controls.Add(Me.BacklogReturnDataGridView)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(NotesLabel)
        Me.Panel3.Controls.Add(Me.NotesTextBox)
        Me.Panel3.Controls.Add(Me.RepeatedMountsTextBox)
        Me.Panel3.Controls.Add(Me.IsRepeatedCheckBox)
        Me.Panel3.Controls.Add(BacklogTotalLabel)
        Me.Panel3.Controls.Add(BacklogNameLabel)
        Me.Panel3.Controls.Add(Me.BacklogNameComboBox)
        Me.Panel3.Location = New System.Drawing.Point(0, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(587, 195)
        Me.Panel3.TabIndex = 2
        '
        'ReturnOnlyTaxCheckBox
        '
        Me.ReturnOnlyTaxCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BacklogRecoverBindingSource, "ReturnOnlyTax", True))
        Me.ReturnOnlyTaxCheckBox.Location = New System.Drawing.Point(25, 88)
        Me.ReturnOnlyTaxCheckBox.Name = "ReturnOnlyTaxCheckBox"
        Me.ReturnOnlyTaxCheckBox.Size = New System.Drawing.Size(133, 24)
        Me.ReturnOnlyTaxCheckBox.TabIndex = 22
        Me.ReturnOnlyTaxCheckBox.Text = "إستثناء النقابات"
        Me.ReturnOnlyTaxCheckBox.UseVisualStyleBackColor = True
        Me.ReturnOnlyTaxCheckBox.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 27)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "%"
        Me.ToolTip1.SetToolTip(Me.Button1, "إدخال نسبة مؤوية من الراتب المقطوع")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReturnTaxCheckBox
        '
        Me.ReturnTaxCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BacklogRecoverBindingSource, "ReturnTax", True))
        Me.ReturnTaxCheckBox.Location = New System.Drawing.Point(159, 88)
        Me.ReturnTaxCheckBox.Name = "ReturnTaxCheckBox"
        Me.ReturnTaxCheckBox.Size = New System.Drawing.Size(211, 24)
        Me.ReturnTaxCheckBox.TabIndex = 20
        Me.ReturnTaxCheckBox.Text = "إعادة مبلغ الضريبة المقتطع للعامل"
        Me.ToolTip1.SetToolTip(Me.ReturnTaxCheckBox, "سيقوم البرنامج عند تفعيل الخيار بإنقاص المبلغ الخاضع للضريبة من مبلغ الإسترداد")
        Me.ReturnTaxCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(25, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "القيمة (-1)  تكرار المبلغ بشكل دائم"
        Me.Label4.Visible = False
        '
        'BacklogTotalTextBox1
        '
        Me.BacklogTotalTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "BacklogTotal", True))
        Me.BacklogTotalTextBox1.Location = New System.Drawing.Point(25, 11)
        Me.BacklogTotalTextBox1.Name = "BacklogTotalTextBox1"
        Me.BacklogTotalTextBox1.Size = New System.Drawing.Size(59, 26)
        Me.BacklogTotalTextBox1.TabIndex = 17
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
        Me.BacklogReturnDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BacklogRCIDDataGridViewTextBoxColumn, Me.BacklogNameDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.BacklogTotalDataGridViewTextBoxColumn, Me.IsRepeatedDataGridViewCheckBoxColumn, Me.RepeatedMountsDataGridViewTextBoxColumn, Me.RMRemainingDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.CreateDateDataGridViewTextBoxColumn, Me.LastModifyDataGridViewTextBoxColumn})
        Me.BacklogReturnDataGridView.DataSource = Me.BacklogRecoverBindingSource
        Me.BacklogReturnDataGridView.Dock = System.Windows.Forms.DockStyle.Right
        Me.BacklogReturnDataGridView.EnableHeadersVisualStyles = False
        Me.BacklogReturnDataGridView.GridColor = System.Drawing.SystemColors.ControlText
        Me.BacklogReturnDataGridView.Location = New System.Drawing.Point(394, 0)
        Me.BacklogReturnDataGridView.MultiSelect = False
        Me.BacklogReturnDataGridView.Name = "BacklogReturnDataGridView"
        Me.BacklogReturnDataGridView.ReadOnly = True
        Me.BacklogReturnDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.BacklogReturnDataGridView.RowHeadersVisible = False
        Me.BacklogReturnDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BacklogReturnDataGridView.Size = New System.Drawing.Size(193, 195)
        Me.BacklogReturnDataGridView.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "عدد أشهر التكرار"
        Me.Label2.Visible = False
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(25, 131)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(275, 52)
        Me.NotesTextBox.TabIndex = 9
        '
        'RepeatedMountsTextBox
        '
        Me.RepeatedMountsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "RepeatedMounts", True))
        Me.RepeatedMountsTextBox.Location = New System.Drawing.Point(25, 43)
        Me.RepeatedMountsTextBox.Name = "RepeatedMountsTextBox"
        Me.RepeatedMountsTextBox.Size = New System.Drawing.Size(59, 26)
        Me.RepeatedMountsTextBox.TabIndex = 7
        Me.RepeatedMountsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RepeatedMountsTextBox.Visible = False
        '
        'IsRepeatedCheckBox
        '
        Me.IsRepeatedCheckBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.IsRepeatedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BacklogRecoverBindingSource, "IsRepeated", True))
        Me.IsRepeatedCheckBox.Location = New System.Drawing.Point(180, 50)
        Me.IsRepeatedCheckBox.Name = "IsRepeatedCheckBox"
        Me.IsRepeatedCheckBox.Size = New System.Drawing.Size(190, 24)
        Me.IsRepeatedCheckBox.TabIndex = 6
        Me.IsRepeatedCheckBox.Text = "تكرار مبلغ الإسترداد"
        Me.IsRepeatedCheckBox.UseVisualStyleBackColor = False
        '
        'BacklogNameComboBox
        '
        Me.BacklogNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacklogRecoverBindingSource, "BacklogName", True))
        Me.BacklogNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.BacklogRecoverBindingSource, "BacklogName", True))
        Me.BacklogNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BacklogNameComboBox.FormattingEnabled = True
        Me.BacklogNameComboBox.Location = New System.Drawing.Point(179, 11)
        Me.BacklogNameComboBox.Name = "BacklogNameComboBox"
        Me.BacklogNameComboBox.Size = New System.Drawing.Size(121, 27)
        Me.BacklogNameComboBox.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(587, 26)
        Me.ToolStrip1.TabIndex = 3
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 23)
        Me.ToolStripLabel1.Text = "إضـــافة"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoToolTip = True
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 23)
        Me.ToolStripLabel2.Text = "حفـــظ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
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
        Me.ToolStripLabel3.Size = New System.Drawing.Size(53, 23)
        Me.ToolStripLabel3.Text = "حـــذف"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem, Me.ToolStripMenuItem1, Me.حذفالبندالمحددلجميعالعاملينToolStripMenuItem})
        Me.ToolStripButton1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(174, 23)
        Me.ToolStripButton1.Text = " بند الإسترداد لجميع العاملين"
        Me.ToolStripButton1.ToolTipText = "بند الإسترداد  لجميع السجلات" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "يمكنك إدخال رمز النسبة المؤوية % مع القيمة وعندها س" & _
    "يقوم البرنامج" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "بحساب النسبة المؤوية من الراتب المقطوع لكل موظف وتخزينها في بند ا" & _
    "لإعادة"
        '
        'حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem
        '
        Me.حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem.Name = "حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem"
        Me.حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem.Text = "حفظ البند المدخل لجميع العاملين"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(244, 6)
        '
        'حذفالبندالمحددلجميعالعاملينToolStripMenuItem
        '
        Me.حذفالبندالمحددلجميعالعاملينToolStripMenuItem.Name = "حذفالبندالمحددلجميعالعاملينToolStripMenuItem"
        Me.حذفالبندالمحددلجميعالعاملينToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.حذفالبندالمحددلجميعالعاملينToolStripMenuItem.Text = "إلغاء البند المحدد لجميع العاملين"
        '
        'BacklogRecoverBindingSource
        '
        Me.BacklogRecoverBindingSource.DataMember = "BacklogRecover"
        Me.BacklogRecoverBindingSource.DataSource = Me.BaniasEnergyDBDataSet
        '
        'BaniasEnergyDBDataSet
        '
        Me.BaniasEnergyDBDataSet.DataSetName = "BaniasEnergyDBDataSet"
        Me.BaniasEnergyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BacklogRCIDDataGridViewTextBoxColumn
        '
        Me.BacklogRCIDDataGridViewTextBoxColumn.DataPropertyName = "BacklogRCID"
        Me.BacklogRCIDDataGridViewTextBoxColumn.HeaderText = "BacklogRCID"
        Me.BacklogRCIDDataGridViewTextBoxColumn.Name = "BacklogRCIDDataGridViewTextBoxColumn"
        Me.BacklogRCIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.BacklogRCIDDataGridViewTextBoxColumn.Visible = False
        '
        'BacklogNameDataGridViewTextBoxColumn
        '
        Me.BacklogNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BacklogNameDataGridViewTextBoxColumn.DataPropertyName = "BacklogName"
        Me.BacklogNameDataGridViewTextBoxColumn.HeaderText = "إسم البند"
        Me.BacklogNameDataGridViewTextBoxColumn.Name = "BacklogNameDataGridViewTextBoxColumn"
        Me.BacklogNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpIDDataGridViewTextBoxColumn.Visible = False
        '
        'BacklogTotalDataGridViewTextBoxColumn
        '
        Me.BacklogTotalDataGridViewTextBoxColumn.DataPropertyName = "BacklogTotal"
        Me.BacklogTotalDataGridViewTextBoxColumn.HeaderText = "BacklogTotal"
        Me.BacklogTotalDataGridViewTextBoxColumn.Name = "BacklogTotalDataGridViewTextBoxColumn"
        Me.BacklogTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.BacklogTotalDataGridViewTextBoxColumn.Visible = False
        '
        'IsRepeatedDataGridViewCheckBoxColumn
        '
        Me.IsRepeatedDataGridViewCheckBoxColumn.DataPropertyName = "IsRepeated"
        Me.IsRepeatedDataGridViewCheckBoxColumn.HeaderText = "IsRepeated"
        Me.IsRepeatedDataGridViewCheckBoxColumn.Name = "IsRepeatedDataGridViewCheckBoxColumn"
        Me.IsRepeatedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsRepeatedDataGridViewCheckBoxColumn.Visible = False
        '
        'RepeatedMountsDataGridViewTextBoxColumn
        '
        Me.RepeatedMountsDataGridViewTextBoxColumn.DataPropertyName = "RepeatedMounts"
        Me.RepeatedMountsDataGridViewTextBoxColumn.HeaderText = "RepeatedMounts"
        Me.RepeatedMountsDataGridViewTextBoxColumn.Name = "RepeatedMountsDataGridViewTextBoxColumn"
        Me.RepeatedMountsDataGridViewTextBoxColumn.ReadOnly = True
        Me.RepeatedMountsDataGridViewTextBoxColumn.Visible = False
        '
        'RMRemainingDataGridViewTextBoxColumn
        '
        Me.RMRemainingDataGridViewTextBoxColumn.DataPropertyName = "RM_Remaining"
        Me.RMRemainingDataGridViewTextBoxColumn.HeaderText = "RM_Remaining"
        Me.RMRemainingDataGridViewTextBoxColumn.Name = "RMRemainingDataGridViewTextBoxColumn"
        Me.RMRemainingDataGridViewTextBoxColumn.ReadOnly = True
        Me.RMRemainingDataGridViewTextBoxColumn.Visible = False
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotesDataGridViewTextBoxColumn.Visible = False
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
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
        'BacklogRecoverTableAdapter
        '
        Me.BacklogRecoverTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BacklogRecoverTableAdapter = Me.BacklogRecoverTableAdapter
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
        Me.TableAdapterManager.TakeOutsTableAdapter = Nothing
        Me.TableAdapterManager.TypeSpecializeValuesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecoverFromEmpFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(587, 289)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "RecoverFromEmpFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "استردادات مختلفة"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BacklogReturnDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BacklogRecoverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents BaniasEnergyDBDataSet As BaniasEnergy.BaniasEnergyDBDataSet
    Friend WithEvents BacklogRecoverTableAdapter As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.BacklogRecoverTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BacklogRCIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BacklogNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RepeatedMountsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsRepeatedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RM_RemainingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastModifyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreateDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BacklogReturnDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BacklogRCIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BacklogNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BacklogTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsRepeatedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RepeatedMountsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RMRemainingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BacklogRecoverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BacklogTotalTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ControlIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReturnTaxCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents حذفالبندالمحددلجميعالعاملينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReturnOnlyTaxCheckBox As System.Windows.Forms.CheckBox
End Class
