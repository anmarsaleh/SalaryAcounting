<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransBankRpt
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TransBankRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New BaniasEnergy.ReportsDataSet()
        Me.SalaryRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaniasEnergyDBDataSet = New BaniasEnergy.BaniasEnergyDBDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TransBankRptTableAdapter = New BaniasEnergy.ReportsDataSetTableAdapters.TransBankRptTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalaryRecordsTableAdapter = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.SalaryRecordsTableAdapter()
        CType(Me.TransBankRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransBankRptBindingSource
        '
        Me.TransBankRptBindingSource.DataMember = "TransBankRpt"
        Me.TransBankRptBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalaryRecordsBindingSource
        '
        Me.SalaryRecordsBindingSource.DataMember = "SalaryRecords"
        Me.SalaryRecordsBindingSource.DataSource = Me.BaniasEnergyDBDataSet
        '
        'BaniasEnergyDBDataSet
        '
        Me.BaniasEnergyDBDataSet.DataSetName = "BaniasEnergyDBDataSet"
        Me.BaniasEnergyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 62)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(215, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 32)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "تقريرالمصرف التجاري"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(405, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 32)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "بيان تحويل الرواتب"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 43)
        Me.Panel2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransBankRptTableAdapter
        '
        Me.TransBankRptTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TransBankRptBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BaniasEnergy.TransBank.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(300, 174)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(145, 106)
        Me.ReportViewer1.TabIndex = 3
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'ReportViewer2
        '
        Me.ReportViewer2.DocumentMapWidth = 36
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SalaryRecordsBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "BaniasEnergy.TransBank1rpt.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(59, 171)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(179, 109)
        Me.ReportViewer2.TabIndex = 4
        Me.ReportViewer2.Visible = False
        '
        'SalaryRecordsTableAdapter
        '
        Me.SalaryRecordsTableAdapter.ClearBeforeFill = True
        '
        'TransBankRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 455)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TransBankRpt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.Text = "تقرير التحويل"
        CType(Me.TransBankRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TransBankRptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportsDataSet As BaniasEnergy.ReportsDataSet
    Friend WithEvents TransBankRptTableAdapter As BaniasEnergy.ReportsDataSetTableAdapters.TransBankRptTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalaryRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaniasEnergyDBDataSet As BaniasEnergy.BaniasEnergyDBDataSet
    Friend WithEvents SalaryRecordsTableAdapter As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.SalaryRecordsTableAdapter
End Class
