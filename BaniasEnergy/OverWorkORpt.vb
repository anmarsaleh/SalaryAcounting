Public Class OverWorkORpt

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub OverWorkORpt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.CenterNames' table. You can move, or remove it, as needed.
        Me.CenterNamesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.CenterNames)
        'TODO: This line of code loads data into the 'ReportsDataSet.HourOverW' table. You can move, or remove it, as needed.
        Me.HourOverWTableAdapter.Fill(Me.ReportsDataSet.HourOverW)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.HourOverWBindingSource.RemoveFilter()
        Me.HourOverWBindingSource.Filter = "CenterName='" + ComboBox1.Text + "'"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.HourOverWBindingSource.RemoveFilter()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class