<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceReport
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
        Dim DirectorateNameLabel As System.Windows.Forms.Label
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TakeOutsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalanceDataSet = New BaniasEnergy.BalanceDataSet()
        Me.BacklogRecoverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BacklogReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalaryRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DirectoratesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TakeOutsTableAdapter = New BaniasEnergy.BalanceDataSetTableAdapters.TakeOutsTableAdapter()
        Me.BacklogRecoverTableAdapter = New BaniasEnergy.BalanceDataSetTableAdapters.BacklogRecoverTableAdapter()
        Me.BacklogReturnTableAdapter = New BaniasEnergy.BalanceDataSetTableAdapters.BacklogReturnTableAdapter()
        Me.SalaryRecordsTableAdapter = New BaniasEnergy.BalanceDataSetTableAdapters.SalaryRecordsTableAdapter()
        Me.DirectoratesTableAdapter = New BaniasEnergy.BalanceDataSetTableAdapters.DirectoratesTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.BalanceDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DirectoratesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        DirectorateNameLabel = New System.Windows.Forms.Label()
        CType(Me.TakeOutsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BacklogRecoverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BacklogReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DirectoratesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectoratesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DirectorateNameLabel
        '
        DirectorateNameLabel.AutoSize = True
        DirectorateNameLabel.Location = New System.Drawing.Point(535, 15)
        DirectorateNameLabel.Name = "DirectorateNameLabel"
        DirectorateNameLabel.Size = New System.Drawing.Size(57, 19)
        DirectorateNameLabel.TabIndex = 0
        DirectorateNameLabel.Text = "إختر قسم"
        '
        'TakeOutsBindingSource
        '
        Me.TakeOutsBindingSource.DataMember = "TakeOuts"
        Me.TakeOutsBindingSource.DataSource = Me.BalanceDataSet
        '
        'BalanceDataSet
        '
        Me.BalanceDataSet.DataSetName = "BalanceDataSet"
        Me.BalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BacklogRecoverBindingSource
        '
        Me.BacklogRecoverBindingSource.DataMember = "BacklogRecover"
        Me.BacklogRecoverBindingSource.DataSource = Me.BalanceDataSet
        '
        'BacklogReturnBindingSource
        '
        Me.BacklogReturnBindingSource.DataMember = "BacklogReturn"
        Me.BacklogReturnBindingSource.DataSource = Me.BalanceDataSet
        '
        'SalaryRecordsBindingSource
        '
        Me.SalaryRecordsBindingSource.DataMember = "SalaryRecords"
        Me.SalaryRecordsBindingSource.DataSource = Me.BalanceDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(DirectorateNameLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 69)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "عرض الكل"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "تصفية"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DirectoratesBindingSource
        '
        Me.DirectoratesBindingSource.DataMember = "Directorates"
        Me.DirectoratesBindingSource.DataSource = Me.BalanceDataSet
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 371)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(601, 62)
        Me.Panel2.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.TakeOutsBindingSource
        ReportDataSource6.Name = "DataSet2"
        ReportDataSource6.Value = Me.BacklogRecoverBindingSource
        ReportDataSource7.Name = "DataSet3"
        ReportDataSource7.Value = Me.BacklogReturnBindingSource
        ReportDataSource8.Name = "DataSet4"
        ReportDataSource8.Value = Me.SalaryRecordsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BaniasEnergy.BalanceRpt.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(178, 108)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(160, 111)
        Me.ReportViewer1.TabIndex = 2
        '
        'TakeOutsTableAdapter
        '
        Me.TakeOutsTableAdapter.ClearBeforeFill = True
        '
        'BacklogRecoverTableAdapter
        '
        Me.BacklogRecoverTableAdapter.ClearBeforeFill = True
        '
        'BacklogReturnTableAdapter
        '
        Me.BacklogReturnTableAdapter.ClearBeforeFill = True
        '
        'SalaryRecordsTableAdapter
        '
        Me.SalaryRecordsTableAdapter.ClearBeforeFill = True
        '
        'DirectoratesTableAdapter
        '
        Me.DirectoratesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DirectoratesTableAdapter = Me.DirectoratesTableAdapter
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.BalanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DirectoratesBindingSource1
        Me.ComboBox1.DisplayMember = "DirectorateName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(392, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 27)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "DirectorateID"
        '
        'DirectoratesBindingSource1
        '
        Me.DirectoratesBindingSource1.DataMember = "Directorates"
        Me.DirectoratesBindingSource1.DataSource = Me.BalanceDataSet
        '
        'BalanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 433)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "BalanceReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.Text = "ميزان الراتب"
        CType(Me.TakeOutsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BacklogRecoverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BacklogReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DirectoratesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectoratesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TakeOutsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BalanceDataSet As BaniasEnergy.BalanceDataSet
    Friend WithEvents BacklogRecoverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BacklogReturnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalaryRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TakeOutsTableAdapter As BaniasEnergy.BalanceDataSetTableAdapters.TakeOutsTableAdapter
    Friend WithEvents BacklogRecoverTableAdapter As BaniasEnergy.BalanceDataSetTableAdapters.BacklogRecoverTableAdapter
    Friend WithEvents BacklogReturnTableAdapter As BaniasEnergy.BalanceDataSetTableAdapters.BacklogReturnTableAdapter
    Friend WithEvents SalaryRecordsTableAdapter As BaniasEnergy.BalanceDataSetTableAdapters.SalaryRecordsTableAdapter
    Friend WithEvents DirectoratesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirectoratesTableAdapter As BaniasEnergy.BalanceDataSetTableAdapters.DirectoratesTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.BalanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DirectoratesBindingSource1 As System.Windows.Forms.BindingSource
End Class
