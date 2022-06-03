Public Class ContractsReports

    Private Sub ContractsReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportsDataSet.ContractsReports' table. You can move, or remove it, as needed.
        Me.ContractsReportsTableAdapter.Fill(Me.ReportsDataSet.ContractsReports)
       
    End Sub

   

    Private Sub ContractsReports_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.ContractsReportsBindingSource.Filter = "salarymount>=StartM and salarymount < EndM"
        Me.ReportViewer1.RefreshReport()
    End Sub

    
    Private Sub RadioBtnsalary_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioBtnsalary.CheckedChanged
        If RadioBtnsalary.Checked Then
            Me.ContractsReportsBindingSource.Filter = "salarymount>=StartM and salarymount < EndM"
            Me.ReportViewer1.RefreshReport()
        Else
            Me.ContractsReportsBindingSource.Filter = "salarymount=EndM"
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class