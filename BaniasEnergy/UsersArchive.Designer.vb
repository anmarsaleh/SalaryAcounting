<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersArchive
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersDBDataSet = New BaniasEnergy.UsersDBDataSet()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TXTyear = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTmonth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTempid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AuditIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryKeyFieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryKeyValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FieldNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FldArDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuditArchiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuditArchiveTableAdapter = New BaniasEnergy.UsersDBDataSetTableAdapters.AuditArchiveTableAdapter()
        Me.UsersTableAdapter = New BaniasEnergy.UsersDBDataSetTableAdapters.UsersTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditArchiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TXTyear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TXTmonth)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TXTempid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(840, 416)
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UsersBindingSource
        Me.ComboBox1.DisplayMember = "UserName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(28, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "UserID"
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
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(157, 105)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox3.TabIndex = 18
        Me.CheckBox3.Text = "أرشيف المستخدم"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TXTyear
        '
        Me.TXTyear.Location = New System.Drawing.Point(91, 39)
        Me.TXTyear.Name = "TXTyear"
        Me.TXTyear.Size = New System.Drawing.Size(52, 20)
        Me.TXTyear.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "العام"
        '
        'TXTmonth
        '
        Me.TXTmonth.Location = New System.Drawing.Point(180, 39)
        Me.TXTmonth.Name = "TXTmonth"
        Me.TXTmonth.Size = New System.Drawing.Size(52, 20)
        Me.TXTmonth.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "الشهر"
        '
        'TXTempid
        '
        Me.TXTempid.Location = New System.Drawing.Point(149, 65)
        Me.TXTempid.Name = "TXTempid"
        Me.TXTempid.Size = New System.Drawing.Size(52, 20)
        Me.TXTempid.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "الرقم الذاتي"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckState = Global.BaniasEnergy.My.MySettings.Default.StopAdmiTriger
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Global.BaniasEnergy.My.MySettings.Default, "StopAdmiTriger", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(60, 301)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(192, 17)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "إيقاف تسجيل أحداث صلاحيات المدير"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckState = Global.BaniasEnergy.My.MySettings.Default.SalTriger
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Global.BaniasEnergy.My.MySettings.Default, "SalTriger", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(70, 278)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(182, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "إيقاف تسجيل أحداث المستخدمين"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(82, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "إغلاق"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(56, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "طباعة السجلات"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "عرض السجلات"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "أختر تاريخين لعرض الأحداث المطلوبة ضمنا"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AuditIDDataGridViewTextBoxColumn, Me.PrimaryKeyFieldDataGridViewTextBoxColumn, Me.PrimaryKeyValueDataGridViewTextBoxColumn, Me.UserName, Me.FieldNameDataGridViewTextBoxColumn, Me.FldArDataGridViewTextBoxColumn, Me.OldValueDataGridViewTextBoxColumn, Me.NewValueDataGridViewTextBoxColumn, Me.UpdateDateDataGridViewTextBoxColumn, Me.PCDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.SalaryMonthDataGridViewTextBoxColumn, Me.SalaryYearDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AuditArchiveBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(557, 416)
        Me.DataGridView1.TabIndex = 0
        '
        'AuditIDDataGridViewTextBoxColumn
        '
        Me.AuditIDDataGridViewTextBoxColumn.DataPropertyName = "AuditID"
        Me.AuditIDDataGridViewTextBoxColumn.HeaderText = "AuditID"
        Me.AuditIDDataGridViewTextBoxColumn.Name = "AuditIDDataGridViewTextBoxColumn"
        Me.AuditIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AuditIDDataGridViewTextBoxColumn.Visible = False
        '
        'PrimaryKeyFieldDataGridViewTextBoxColumn
        '
        Me.PrimaryKeyFieldDataGridViewTextBoxColumn.DataPropertyName = "PrimaryKeyField"
        Me.PrimaryKeyFieldDataGridViewTextBoxColumn.HeaderText = "مفتاح السجل"
        Me.PrimaryKeyFieldDataGridViewTextBoxColumn.Name = "PrimaryKeyFieldDataGridViewTextBoxColumn"
        Me.PrimaryKeyFieldDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrimaryKeyFieldDataGridViewTextBoxColumn.Visible = False
        '
        'PrimaryKeyValueDataGridViewTextBoxColumn
        '
        Me.PrimaryKeyValueDataGridViewTextBoxColumn.DataPropertyName = "PrimaryKeyValue"
        Me.PrimaryKeyValueDataGridViewTextBoxColumn.HeaderText = "رقم السجل"
        Me.PrimaryKeyValueDataGridViewTextBoxColumn.Name = "PrimaryKeyValueDataGridViewTextBoxColumn"
        Me.PrimaryKeyValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "اسم المستحدم"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'FieldNameDataGridViewTextBoxColumn
        '
        Me.FieldNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FieldNameDataGridViewTextBoxColumn.HeaderText = "اسم الموظف"
        Me.FieldNameDataGridViewTextBoxColumn.Name = "FieldNameDataGridViewTextBoxColumn"
        Me.FieldNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FldArDataGridViewTextBoxColumn
        '
        Me.FldArDataGridViewTextBoxColumn.DataPropertyName = "FldAr"
        Me.FldArDataGridViewTextBoxColumn.HeaderText = "الحقل المتأثر"
        Me.FldArDataGridViewTextBoxColumn.Name = "FldArDataGridViewTextBoxColumn"
        Me.FldArDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OldValueDataGridViewTextBoxColumn
        '
        Me.OldValueDataGridViewTextBoxColumn.DataPropertyName = "OldValue"
        Me.OldValueDataGridViewTextBoxColumn.HeaderText = "قبل التنفيذ"
        Me.OldValueDataGridViewTextBoxColumn.Name = "OldValueDataGridViewTextBoxColumn"
        Me.OldValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewValueDataGridViewTextBoxColumn
        '
        Me.NewValueDataGridViewTextBoxColumn.DataPropertyName = "NewValue"
        Me.NewValueDataGridViewTextBoxColumn.HeaderText = "بعد التنفيذ"
        Me.NewValueDataGridViewTextBoxColumn.Name = "NewValueDataGridViewTextBoxColumn"
        Me.NewValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UpdateDateDataGridViewTextBoxColumn
        '
        Me.UpdateDateDataGridViewTextBoxColumn.DataPropertyName = "UpdateDate"
        Me.UpdateDateDataGridViewTextBoxColumn.HeaderText = "تاريخ التعديل"
        Me.UpdateDateDataGridViewTextBoxColumn.Name = "UpdateDateDataGridViewTextBoxColumn"
        Me.UpdateDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PCDataGridViewTextBoxColumn
        '
        Me.PCDataGridViewTextBoxColumn.DataPropertyName = "PC"
        Me.PCDataGridViewTextBoxColumn.HeaderText = "الحاسب"
        Me.PCDataGridViewTextBoxColumn.Name = "PCDataGridViewTextBoxColumn"
        Me.PCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'SalaryMonthDataGridViewTextBoxColumn
        '
        Me.SalaryMonthDataGridViewTextBoxColumn.DataPropertyName = "SalaryMonth"
        Me.SalaryMonthDataGridViewTextBoxColumn.HeaderText = "SalaryMonth"
        Me.SalaryMonthDataGridViewTextBoxColumn.Name = "SalaryMonthDataGridViewTextBoxColumn"
        Me.SalaryMonthDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalaryMonthDataGridViewTextBoxColumn.Visible = False
        '
        'SalaryYearDataGridViewTextBoxColumn
        '
        Me.SalaryYearDataGridViewTextBoxColumn.DataPropertyName = "SalaryYear"
        Me.SalaryYearDataGridViewTextBoxColumn.HeaderText = "SalaryYear"
        Me.SalaryYearDataGridViewTextBoxColumn.Name = "SalaryYearDataGridViewTextBoxColumn"
        Me.SalaryYearDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalaryYearDataGridViewTextBoxColumn.Visible = False
        '
        'AuditArchiveBindingSource
        '
        Me.AuditArchiveBindingSource.DataMember = "AuditArchive"
        Me.AuditArchiveBindingSource.DataSource = Me.UsersDBDataSet
        '
        'AuditArchiveTableAdapter
        '
        Me.AuditArchiveTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "حذف أرشيف المستخدمين الأقدم من"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.BaniasEnergy.My.MySettings.Default, "DelArchive", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(52, 330)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = Global.BaniasEnergy.My.MySettings.Default.DelArchive
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "شهر"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "في حال القيمة صفر او سالبة لن يتم أي إجراء"
        '
        'UsersArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 416)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UsersArchive"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "أرشيف أحداث المستخدمين"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditArchiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UsersDBDataSet As BaniasEnergy.UsersDBDataSet
    Friend WithEvents AuditArchiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuditArchiveTableAdapter As BaniasEnergy.UsersDBDataSetTableAdapters.AuditArchiveTableAdapter
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TXTyear As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTmonth As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTempid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As BaniasEnergy.UsersDBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents AuditIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryKeyFieldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrimaryKeyValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FieldNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FldArDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryMonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
