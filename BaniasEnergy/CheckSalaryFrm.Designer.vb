<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckSalaryFrm
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
        Dim C_SlitLabel As System.Windows.Forms.Label
        Dim C_FamilyLabel As System.Windows.Forms.Label
        Dim C_AllowanceLabel As System.Windows.Forms.Label
        Dim C_ScecialLabel As System.Windows.Forms.Label
        Dim C_TypeSpecialLabel As System.Windows.Forms.Label
        Dim C_AuthorityLabel As System.Windows.Forms.Label
        Dim C_DangerWorkLabel As System.Windows.Forms.Label
        Dim C_TotalSalaryLabel As System.Windows.Forms.Label
        Dim C_TotalDiscountLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlIDTextBox = New System.Windows.Forms.TextBox()
        Me.ChkSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.C_TotalDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C_SlitTextBox = New System.Windows.Forms.TextBox()
        Me.C_FamilyTextBox = New System.Windows.Forms.TextBox()
        Me.C_AllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.C_ScecialTextBox = New System.Windows.Forms.TextBox()
        Me.C_TypeSpecialTextBox = New System.Windows.Forms.TextBox()
        Me.C_AuthorityTextBox = New System.Windows.Forms.TextBox()
        Me.C_DangerWorkTextBox = New System.Windows.Forms.TextBox()
        Me.C_TotalSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.CheckSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckSalaryDBDataSet = New BaniasEnergy.CheckSalaryDBDataSet()
        Me.CheckSalaryTableAdapter1 = New BaniasEnergy.CheckSalaryDBDataSetTableAdapters.CheckSalaryTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.CheckSalaryDBDataSetTableAdapters.TableAdapterManager()
        C_SlitLabel = New System.Windows.Forms.Label()
        C_FamilyLabel = New System.Windows.Forms.Label()
        C_AllowanceLabel = New System.Windows.Forms.Label()
        C_ScecialLabel = New System.Windows.Forms.Label()
        C_TypeSpecialLabel = New System.Windows.Forms.Label()
        C_AuthorityLabel = New System.Windows.Forms.Label()
        C_DangerWorkLabel = New System.Windows.Forms.Label()
        C_TotalSalaryLabel = New System.Windows.Forms.Label()
        C_TotalDiscountLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.CheckSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckSalaryDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C_SlitLabel
        '
        C_SlitLabel.AutoSize = True
        C_SlitLabel.Location = New System.Drawing.Point(246, 13)
        C_SlitLabel.Name = "C_SlitLabel"
        C_SlitLabel.Size = New System.Drawing.Size(189, 19)
        C_SlitLabel.TabIndex = 2
        C_SlitLabel.Text = "الراتب المقطوع أصغر من"
        '
        'C_FamilyLabel
        '
        C_FamilyLabel.AutoSize = True
        C_FamilyLabel.Location = New System.Drawing.Point(237, 46)
        C_FamilyLabel.Name = "C_FamilyLabel"
        C_FamilyLabel.Size = New System.Drawing.Size(189, 19)
        C_FamilyLabel.TabIndex = 4
        C_FamilyLabel.Text = "التعويض العائلي أكبر من"
        '
        'C_AllowanceLabel
        '
        C_AllowanceLabel.AutoSize = True
        C_AllowanceLabel.Location = New System.Drawing.Point(299, 79)
        C_AllowanceLabel.Name = "C_AllowanceLabel"
        C_AllowanceLabel.Size = New System.Drawing.Size(128, 19)
        C_AllowanceLabel.TabIndex = 6
        C_AllowanceLabel.Text = "الترفيعة أكبر من"
        '
        'C_ScecialLabel
        '
        C_ScecialLabel.AutoSize = True
        C_ScecialLabel.Location = New System.Drawing.Point(232, 112)
        C_ScecialLabel.Name = "C_ScecialLabel"
        C_ScecialLabel.Size = New System.Drawing.Size(193, 19)
        C_ScecialLabel.TabIndex = 8
        C_ScecialLabel.Text = "تعويض إختصاص أكبر من"
        '
        'C_TypeSpecialLabel
        '
        C_TypeSpecialLabel.AutoSize = True
        C_TypeSpecialLabel.Location = New System.Drawing.Point(270, 145)
        C_TypeSpecialLabel.Name = "C_TypeSpecialLabel"
        C_TypeSpecialLabel.Size = New System.Drawing.Size(155, 19)
        C_TypeSpecialLabel.TabIndex = 10
        C_TypeSpecialLabel.Text = "طبيعة عمل أكبر من"
        '
        'C_AuthorityLabel
        '
        C_AuthorityLabel.AutoSize = True
        C_AuthorityLabel.Location = New System.Drawing.Point(232, 178)
        C_AuthorityLabel.Name = "C_AuthorityLabel"
        C_AuthorityLabel.Size = New System.Drawing.Size(194, 19)
        C_AuthorityLabel.TabIndex = 12
        C_AuthorityLabel.Text = "تعويض مسؤولية أكبر من"
        '
        'C_DangerWorkLabel
        '
        C_DangerWorkLabel.AutoSize = True
        C_DangerWorkLabel.Location = New System.Drawing.Point(239, 211)
        C_DangerWorkLabel.Name = "C_DangerWorkLabel"
        C_DangerWorkLabel.Size = New System.Drawing.Size(186, 19)
        C_DangerWorkLabel.TabIndex = 14
        C_DangerWorkLabel.Text = "تعويض معيشة  أكبر من"
        '
        'C_TotalSalaryLabel
        '
        C_TotalSalaryLabel.AutoSize = True
        C_TotalSalaryLabel.Location = New System.Drawing.Point(244, 244)
        C_TotalSalaryLabel.Name = "C_TotalSalaryLabel"
        C_TotalSalaryLabel.Size = New System.Drawing.Size(183, 19)
        C_TotalSalaryLabel.TabIndex = 16
        C_TotalSalaryLabel.Text = "الراتب الصافي أصغر من"
        '
        'C_TotalDiscountLabel
        '
        C_TotalDiscountLabel.AutoSize = True
        C_TotalDiscountLabel.Location = New System.Drawing.Point(232, 277)
        C_TotalDiscountLabel.Name = "C_TotalDiscountLabel"
        C_TotalDiscountLabel.Size = New System.Drawing.Size(204, 19)
        C_TotalDiscountLabel.TabIndex = 18
        C_TotalDiscountLabel.Text = "مجموع الحسميات أكبر من"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "سيقوم برنامج التحقق من صحة الراتب بناءً على محددات ضوابط المفردات التالية: "
        '
        'ControlIDTextBox
        '
        Me.ControlIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "ControlID", True))
        Me.ControlIDTextBox.Location = New System.Drawing.Point(12, 46)
        Me.ControlIDTextBox.Name = "ControlIDTextBox"
        Me.ControlIDTextBox.Size = New System.Drawing.Size(34, 27)
        Me.ControlIDTextBox.TabIndex = 19
        '
        'ChkSalaryTextBox
        '
        Me.ChkSalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "ChkSalary", True))
        Me.ChkSalaryTextBox.Location = New System.Drawing.Point(12, 13)
        Me.ChkSalaryTextBox.Name = "ChkSalaryTextBox"
        Me.ChkSalaryTextBox.Size = New System.Drawing.Size(44, 27)
        Me.ChkSalaryTextBox.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 404)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 46)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(110, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "إلغاء جميع الضوابط"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "إغلاق"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حـفـــظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ControlIDTextBox)
        Me.Panel3.Controls.Add(Me.C_TotalDiscountTextBox)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.ChkSalaryTextBox)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(C_TotalDiscountLabel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(C_SlitLabel)
        Me.Panel3.Controls.Add(Me.C_SlitTextBox)
        Me.Panel3.Controls.Add(C_FamilyLabel)
        Me.Panel3.Controls.Add(Me.C_FamilyTextBox)
        Me.Panel3.Controls.Add(C_AllowanceLabel)
        Me.Panel3.Controls.Add(Me.C_AllowanceTextBox)
        Me.Panel3.Controls.Add(C_ScecialLabel)
        Me.Panel3.Controls.Add(Me.C_ScecialTextBox)
        Me.Panel3.Controls.Add(C_TypeSpecialLabel)
        Me.Panel3.Controls.Add(Me.C_TypeSpecialTextBox)
        Me.Panel3.Controls.Add(C_AuthorityLabel)
        Me.Panel3.Controls.Add(Me.C_AuthorityTextBox)
        Me.Panel3.Controls.Add(C_DangerWorkLabel)
        Me.Panel3.Controls.Add(Me.C_DangerWorkTextBox)
        Me.Panel3.Controls.Add(C_TotalSalaryLabel)
        Me.Panel3.Controls.Add(Me.C_TotalSalaryTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 362)
        Me.Panel3.TabIndex = 2
        '
        'C_TotalDiscountTextBox
        '
        Me.C_TotalDiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_TDiscount", True))
        Me.C_TotalDiscountTextBox.Location = New System.Drawing.Point(182, 274)
        Me.C_TotalDiscountTextBox.Name = "C_TotalDiscountTextBox"
        Me.C_TotalDiscountTextBox.Size = New System.Drawing.Size(48, 27)
        Me.C_TotalDiscountTextBox.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(47, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(395, 38)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "تنوية: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "سيتجاهل البرنامج كل بند مسند إليه القيمة (0) صفر "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(76, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 19)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "ل.س"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "ل.س"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "ل.س"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "ل.س"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "ل.س"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "ل.س"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ل.س"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ل.س"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "من الراتب الصافي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "%"
        '
        'C_SlitTextBox
        '
        Me.C_SlitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_Slit", True))
        Me.C_SlitTextBox.Location = New System.Drawing.Point(130, 10)
        Me.C_SlitTextBox.Name = "C_SlitTextBox"
        Me.C_SlitTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_SlitTextBox.TabIndex = 3
        Me.C_SlitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_FamilyTextBox
        '
        Me.C_FamilyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_Family", True))
        Me.C_FamilyTextBox.Location = New System.Drawing.Point(130, 43)
        Me.C_FamilyTextBox.Name = "C_FamilyTextBox"
        Me.C_FamilyTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_FamilyTextBox.TabIndex = 5
        Me.C_FamilyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_AllowanceTextBox
        '
        Me.C_AllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_Allowance", True))
        Me.C_AllowanceTextBox.Location = New System.Drawing.Point(130, 76)
        Me.C_AllowanceTextBox.Name = "C_AllowanceTextBox"
        Me.C_AllowanceTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_AllowanceTextBox.TabIndex = 7
        Me.C_AllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_ScecialTextBox
        '
        Me.C_ScecialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_Scecial", True))
        Me.C_ScecialTextBox.Location = New System.Drawing.Point(130, 109)
        Me.C_ScecialTextBox.Name = "C_ScecialTextBox"
        Me.C_ScecialTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_ScecialTextBox.TabIndex = 9
        Me.C_ScecialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_TypeSpecialTextBox
        '
        Me.C_TypeSpecialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_TypeSpecial", True))
        Me.C_TypeSpecialTextBox.Location = New System.Drawing.Point(130, 142)
        Me.C_TypeSpecialTextBox.Name = "C_TypeSpecialTextBox"
        Me.C_TypeSpecialTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_TypeSpecialTextBox.TabIndex = 11
        Me.C_TypeSpecialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_AuthorityTextBox
        '
        Me.C_AuthorityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_Authority", True))
        Me.C_AuthorityTextBox.Location = New System.Drawing.Point(130, 175)
        Me.C_AuthorityTextBox.Name = "C_AuthorityTextBox"
        Me.C_AuthorityTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_AuthorityTextBox.TabIndex = 13
        Me.C_AuthorityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_DangerWorkTextBox
        '
        Me.C_DangerWorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_DangerWork", True))
        Me.C_DangerWorkTextBox.Location = New System.Drawing.Point(130, 208)
        Me.C_DangerWorkTextBox.Name = "C_DangerWorkTextBox"
        Me.C_DangerWorkTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_DangerWorkTextBox.TabIndex = 15
        Me.C_DangerWorkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_TotalSalaryTextBox
        '
        Me.C_TotalSalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CheckSalaryBindingSource, "C_TotalSalary", True))
        Me.C_TotalSalaryTextBox.Location = New System.Drawing.Point(130, 241)
        Me.C_TotalSalaryTextBox.Name = "C_TotalSalaryTextBox"
        Me.C_TotalSalaryTextBox.Size = New System.Drawing.Size(100, 27)
        Me.C_TotalSalaryTextBox.TabIndex = 17
        Me.C_TotalSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckSalaryBindingSource
        '
        Me.CheckSalaryBindingSource.DataMember = "CheckSalary"
        Me.CheckSalaryBindingSource.DataSource = Me.CheckSalaryDBDataSet
        '
        'CheckSalaryDBDataSet
        '
        Me.CheckSalaryDBDataSet.DataSetName = "CheckSalaryDBDataSet"
        Me.CheckSalaryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckSalaryTableAdapter1
        '
        Me.CheckSalaryTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckSalaryTableAdapter = Me.CheckSalaryTableAdapter1
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.CheckSalaryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CheckSalaryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(452, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "CheckSalaryFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ضوابط رواتب الموظفين"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.CheckSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckSalaryDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ChkSalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_SlitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_FamilyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_AllowanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_ScecialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_TypeSpecialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_AuthorityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_DangerWorkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents C_TotalSalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ControlIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents C_TotalDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckSalaryDBDataSet As BaniasEnergy.CheckSalaryDBDataSet
    Friend WithEvents CheckSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckSalaryTableAdapter1 As BaniasEnergy.CheckSalaryDBDataSetTableAdapters.CheckSalaryTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.CheckSalaryDBDataSetTableAdapters.TableAdapterManager
End Class
