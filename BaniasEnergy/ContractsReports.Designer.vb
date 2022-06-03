<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContractsReports
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioBtndone = New System.Windows.Forms.RadioButton()
        Me.RadioBtnsalary = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ContractsReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsDataSet = New BaniasEnergy.ReportsDataSet()
        Me.ContractsReportsTableAdapter = New BaniasEnergy.ReportsDataSetTableAdapters.ContractsReportsTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ContractsReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioBtndone)
        Me.Panel1.Controls.Add(Me.RadioBtnsalary)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 50)
        Me.Panel1.TabIndex = 0
        '
        'RadioBtndone
        '
        Me.RadioBtndone.AutoSize = True
        Me.RadioBtndone.Location = New System.Drawing.Point(269, 12)
        Me.RadioBtndone.Name = "RadioBtndone"
        Me.RadioBtndone.Size = New System.Drawing.Size(129, 17)
        Me.RadioBtndone.TabIndex = 1
        Me.RadioBtndone.Text = "تصفية العقود المنتاهية"
        Me.RadioBtndone.UseVisualStyleBackColor = True
        '
        'RadioBtnsalary
        '
        Me.RadioBtnsalary.AutoSize = True
        Me.RadioBtnsalary.Checked = True
        Me.RadioBtnsalary.Location = New System.Drawing.Point(422, 12)
        Me.RadioBtnsalary.Name = "RadioBtnsalary"
        Me.RadioBtnsalary.Size = New System.Drawing.Size(87, 17)
        Me.RadioBtnsalary.TabIndex = 0
        Me.RadioBtnsalary.TabStop = True
        Me.RadioBtnsalary.Text = "الشهر الجاري"
        Me.RadioBtnsalary.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 33)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "إغلاق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(524, 308)
        Me.Panel3.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ContractsReportsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BaniasEnergy.contractsSalaries.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(524, 308)
        Me.ReportViewer1.TabIndex = 0
        '
        'ContractsReportsBindingSource
        '
        Me.ContractsReportsBindingSource.DataMember = "ContractsReports"
        Me.ContractsReportsBindingSource.DataSource = Me.ReportsDataSet
        '
        'ReportsDataSet
        '
        Me.ReportsDataSet.DataSetName = "ReportsDataSet"
        Me.ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContractsReportsTableAdapter
        '
        Me.ContractsReportsTableAdapter.ClearBeforeFill = True
        '
        'ContractsReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 391)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ContractsReports"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "تقارير العقود المؤقتة"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.ContractsReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioBtndone As System.Windows.Forms.RadioButton
    Friend WithEvents RadioBtnsalary As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ContractsReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportsDataSet As BaniasEnergy.ReportsDataSet
    Friend WithEvents ContractsReportsTableAdapter As BaniasEnergy.ReportsDataSetTableAdapters.ContractsReportsTableAdapter
End Class
