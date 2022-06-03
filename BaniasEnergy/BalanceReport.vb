Public Class BalanceReport

    Private Sub BalanceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BalanceDataSet.Directorates' table. You can move, or remove it, as needed.
        Me.DirectoratesTableAdapter.Fill(Me.BalanceDataSet.Directorates)
        'TODO: This line of code loads data into the 'BalanceDataSet.TakeOuts' table. You can move, or remove it, as needed.
        Me.TakeOutsTableAdapter.Fill(Me.BalanceDataSet.TakeOuts)
        'TODO: This line of code loads data into the 'BalanceDataSet.BacklogRecover' table. You can move, or remove it, as needed.
        Me.BacklogRecoverTableAdapter.Fill(Me.BalanceDataSet.BacklogRecover)
        'TODO: This line of code loads data into the 'BalanceDataSet.BacklogReturn' table. You can move, or remove it, as needed.
        Me.BacklogReturnTableAdapter.Fill(Me.BalanceDataSet.BacklogReturn)
        'TODO: This line of code loads data into the 'BalanceDataSet.SalaryRecords' table. You can move, or remove it, as needed.
        Me.SalaryRecordsTableAdapter.Fill(Me.BalanceDataSet.SalaryRecords)
        ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mFilter As Integer = ComboBox1.SelectedValue
        Me.SalaryRecordsBindingSource.Filter = "DirectorateID=" & mFilter & ""
        Me.BacklogRecoverBindingSource.Filter = "DirectorateID=" & mFilter & ""
        Me.BacklogReturnBindingSource.Filter = "DirectorateID=" & mFilter & ""
        Me.TakeOutsBindingSource.Filter = "DirectorateID=" & mFilter & ""
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.SalaryRecordsBindingSource.RemoveFilter()
        Me.BacklogRecoverBindingSource.RemoveFilter()
        Me.BacklogReturnBindingSource.RemoveFilter()
        Me.TakeOutsBindingSource.RemoveFilter()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class