<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryTaxFrm
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
        Dim TaxImmunityLabel As System.Windows.Forms.Label
        Dim Tax1Label As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.SetupTaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SetupSalaryDataSet = New BaniasEnergy.SetupSalaryDataSet()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ControlIDTextBox = New System.Windows.Forms.TextBox()
        Me.TaxationIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tax1TextBox = New System.Windows.Forms.TextBox()
        Me.TaxImmunityTextBox = New System.Windows.Forms.TextBox()
        Me.SetupTaxTableAdapter = New BaniasEnergy.SetupSalaryDataSetTableAdapters.SetupTaxTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.SetupSalaryDataSetTableAdapters.TableAdapterManager()
        TaxImmunityLabel = New System.Windows.Forms.Label()
        Tax1Label = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SetupTaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetupSalaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaxImmunityLabel
        '
        TaxImmunityLabel.AutoSize = True
        TaxImmunityLabel.Location = New System.Drawing.Point(240, 9)
        TaxImmunityLabel.Name = "TaxImmunityLabel"
        TaxImmunityLabel.Size = New System.Drawing.Size(151, 18)
        TaxImmunityLabel.TabIndex = 0
        TaxImmunityLabel.Text = "الحد المعفى من ضريبة الدخل"
        '
        'Tax1Label
        '
        Tax1Label.AutoSize = True
        Tax1Label.Location = New System.Drawing.Point(328, 77)
        Tax1Label.Name = "Tax1Label"
        Tax1Label.Size = New System.Drawing.Size(83, 18)
        Tax1Label.TabIndex = 2
        Tax1Label.Text = "الشريحة الأولى"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(331, 139)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(83, 18)
        Label3.TabIndex = 4
        Label3.Text = "الشريحة الثالثة"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(328, 167)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(86, 18)
        Label4.TabIndex = 6
        Label4.Text = "الشريحة الرابعة"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(322, 201)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(94, 18)
        Label5.TabIndex = 8
        Label5.Text = "الشريحة الخامسة"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(319, 232)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(94, 18)
        Label6.TabIndex = 10
        Label6.Text = "الشريحة السادسة"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(325, 260)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(89, 18)
        Label7.TabIndex = 12
        Label7.Text = "الشريحة السابعة"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(331, 108)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(83, 18)
        Label8.TabIndex = 14
        Label8.Text = "الشريحة الثانية"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(325, 294)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(85, 18)
        Label9.TabIndex = 16
        Label9.Text = "الشريحة الثامنة"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(215, 49)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(110, 18)
        Label10.TabIndex = 18
        Label10.Text = "قيمة الشريحة / ل س"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(31, 49)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(131, 18)
        Label11.TabIndex = 19
        Label11.Text = "نسبة الحسم للشريحة /%"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(92, 9)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(36, 18)
        Label12.TabIndex = 28
        Label12.Text = "ل. س"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "متغيرات ضريبة الدخل"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox18)
        Me.Panel2.Controls.Add(Me.TextBox17)
        Me.Panel2.Controls.Add(Me.TextBox16)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 401)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 54)
        Me.Panel2.TabIndex = 1
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "CreateDate", True))
        Me.TextBox18.Location = New System.Drawing.Point(231, 18)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(29, 20)
        Me.TextBox18.TabIndex = 30
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetupTaxBindingSource
        '
        Me.SetupTaxBindingSource.DataMember = "SetupTax"
        Me.SetupTaxBindingSource.DataSource = Me.SetupSalaryDataSet
        '
        'SetupSalaryDataSet
        '
        Me.SetupSalaryDataSet.DataSetName = "SetupSalaryDataSet"
        Me.SetupSalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "LastModify", True))
        Me.TextBox17.Location = New System.Drawing.Point(196, 18)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(29, 20)
        Me.TextBox17.TabIndex = 29
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "UserID", True))
        Me.TextBox16.Location = New System.Drawing.Point(160, 18)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(29, 20)
        Me.TextBox16.TabIndex = 28
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "إغلاق"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(287, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حفظ التعديلات"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ControlIDTextBox)
        Me.Panel3.Controls.Add(Me.TaxationIDTextBox)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Label12)
        Me.Panel3.Controls.Add(Me.TextBox8)
        Me.Panel3.Controls.Add(Me.TextBox9)
        Me.Panel3.Controls.Add(Me.TextBox10)
        Me.Panel3.Controls.Add(Me.TextBox11)
        Me.Panel3.Controls.Add(Me.TextBox12)
        Me.Panel3.Controls.Add(Me.TextBox13)
        Me.Panel3.Controls.Add(Me.TextBox14)
        Me.Panel3.Controls.Add(Me.TextBox15)
        Me.Panel3.Controls.Add(Label11)
        Me.Panel3.Controls.Add(Label10)
        Me.Panel3.Controls.Add(Label9)
        Me.Panel3.Controls.Add(Me.TextBox7)
        Me.Panel3.Controls.Add(Label8)
        Me.Panel3.Controls.Add(Me.TextBox6)
        Me.Panel3.Controls.Add(Label7)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Label6)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Tax1Label)
        Me.Panel3.Controls.Add(Me.Tax1TextBox)
        Me.Panel3.Controls.Add(TaxImmunityLabel)
        Me.Panel3.Controls.Add(Me.TaxImmunityTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 364)
        Me.Panel3.TabIndex = 2
        '
        'ControlIDTextBox
        '
        Me.ControlIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "ControlID", True))
        Me.ControlIDTextBox.Location = New System.Drawing.Point(118, 335)
        Me.ControlIDTextBox.Name = "ControlIDTextBox"
        Me.ControlIDTextBox.Size = New System.Drawing.Size(41, 25)
        Me.ControlIDTextBox.TabIndex = 32
        '
        'TaxationIDTextBox
        '
        Me.TaxationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "TaxationID", True))
        Me.TaxationIDTextBox.Location = New System.Drawing.Point(57, 335)
        Me.TaxationIDTextBox.Name = "TaxationIDTextBox"
        Me.TaxationIDTextBox.Size = New System.Drawing.Size(35, 25)
        Me.TaxationIDTextBox.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(178, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 32)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "ملاحظة: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "التعديلات على الحقول تطبق على جميع سجلات الراتب"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax8", True))
        Me.TextBox8.Location = New System.Drawing.Point(43, 291)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 25)
        Me.TextBox8.TabIndex = 27
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax2", True))
        Me.TextBox9.Location = New System.Drawing.Point(44, 105)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 25)
        Me.TextBox9.TabIndex = 26
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax7", True))
        Me.TextBox10.Location = New System.Drawing.Point(43, 260)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 25)
        Me.TextBox10.TabIndex = 25
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax6", True))
        Me.TextBox11.Location = New System.Drawing.Point(44, 229)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 25)
        Me.TextBox11.TabIndex = 24
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax5", True))
        Me.TextBox12.Location = New System.Drawing.Point(44, 198)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 25)
        Me.TextBox12.TabIndex = 23
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax4", True))
        Me.TextBox13.Location = New System.Drawing.Point(44, 167)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 25)
        Me.TextBox13.TabIndex = 22
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax3", True))
        Me.TextBox14.Location = New System.Drawing.Point(44, 136)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 25)
        Me.TextBox14.TabIndex = 21
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Ptax1", True))
        Me.TextBox15.Location = New System.Drawing.Point(44, 74)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 25)
        Me.TextBox15.TabIndex = 20
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax8", True))
        Me.TextBox7.Location = New System.Drawing.Point(215, 291)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 25)
        Me.TextBox7.TabIndex = 17
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax2", True))
        Me.TextBox6.Location = New System.Drawing.Point(216, 105)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 25)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax7", True))
        Me.TextBox5.Location = New System.Drawing.Point(215, 260)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 25)
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax6", True))
        Me.TextBox4.Location = New System.Drawing.Point(216, 229)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 25)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax5", True))
        Me.TextBox3.Location = New System.Drawing.Point(216, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 25)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax4", True))
        Me.TextBox2.Location = New System.Drawing.Point(216, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax3", True))
        Me.TextBox1.Location = New System.Drawing.Point(216, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tax1TextBox
        '
        Me.Tax1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "Tax1", True))
        Me.Tax1TextBox.Location = New System.Drawing.Point(216, 74)
        Me.Tax1TextBox.Name = "Tax1TextBox"
        Me.Tax1TextBox.Size = New System.Drawing.Size(100, 25)
        Me.Tax1TextBox.TabIndex = 3
        Me.Tax1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaxImmunityTextBox
        '
        Me.TaxImmunityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SetupTaxBindingSource, "TaxImmunity", True))
        Me.TaxImmunityTextBox.Location = New System.Drawing.Point(134, 6)
        Me.TaxImmunityTextBox.Name = "TaxImmunityTextBox"
        Me.TaxImmunityTextBox.Size = New System.Drawing.Size(100, 25)
        Me.TaxImmunityTextBox.TabIndex = 1
        Me.TaxImmunityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SetupTaxTableAdapter
        '
        Me.SetupTaxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalaryConstantsTableAdapter = Nothing
        Me.TableAdapterManager.SetupTaxTableAdapter = Me.SetupTaxTableAdapter
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.SetupSalaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalaryTaxFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(418, 455)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SalaryTaxFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إعداد متغيرات ضريبة الدخل"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SetupTaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetupSalaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SetupSalaryDataSet As BaniasEnergy.SetupSalaryDataSet
    Friend WithEvents SetupTaxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SetupTaxTableAdapter As BaniasEnergy.SetupSalaryDataSetTableAdapters.SetupTaxTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.SetupSalaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TaxImmunityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Tax1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TaxationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ControlIDTextBox As System.Windows.Forms.TextBox
End Class
