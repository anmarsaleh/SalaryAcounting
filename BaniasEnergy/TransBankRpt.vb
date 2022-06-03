Public Class TransBankRpt

    Private Sub TransBankRpt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.SalaryRecords' table. You can move, or remove it, as needed.
        Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)
        'TODO: This line of code loads data into the 'ReportsDataSet.TransBankRpt' table. You can move, or remove it, as needed.
        Me.TransBankRptTableAdapter.Fill(Me.ReportsDataSet.TransBankRpt)
        Me.SalaryRecordsBindingSource.Filter = "CenterID<>95"
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.ReportViewer2.Visible = False
        Me.ReportViewer1.Visible = True
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = True
        Me.ReportViewer2.Dock = DockStyle.Fill
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class