Public Class GivenReportFrm
    Dim eEmpID1 As Integer
    Private Sub GivenReportFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportsDataSet.GivenSalary' table. You can move, or remove it, as needed.
        Me.GivenSalaryTableAdapter.Fill(Me.ReportsDataSet.GivenSalary, 0)
        'TODO: This line of code loads data into the 'ReportsDataSet.GivenSalary' table. You can move, or remove it, as needed.
        eEmpID1 = 0
        'Me.GivenSalaryTableAdapter.Fill(Me.ReportsDataSet.GivenSalary, eEmpID1)
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.RefreshReport()
       
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If IsNumeric(TextBox1.Text) Then
            eEmpID1 = TextBox1.Text
        Else
            eEmpID1 = 0
        End If
        Me.GivenSalaryTableAdapter.Fill(Me.ReportsDataSet.GivenSalary, eEmpID1)
        If RadioButton1.Checked Then
            Me.ReportViewer1.Visible = True
            Me.ReportViewer2.Visible = False
            Me.ReportViewer3.Visible = False
            Me.ReportViewer1.Dock = DockStyle.Fill
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        ElseIf RadioButton2.Checked Then
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = True
            Me.ReportViewer3.Visible = False
            Me.ReportViewer2.Dock = DockStyle.Fill
            Me.ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer2.RefreshReport()

        ElseIf RadioButton3.Checked Then
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = False
            Me.ReportViewer3.Visible = True
            Me.ReportViewer3.Dock = DockStyle.Fill
            Me.ReportViewer3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer3.RefreshReport()

        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            eEmpID1 = TextBox1.Text
        Else
            eEmpID1 = 0
        End If
        Me.GivenSalaryTableAdapter.Fill(Me.ReportsDataSet.GivenSalary, eEmpID1)
        If RadioButton1.Checked Then
            Me.ReportViewer1.Visible = True
            Me.ReportViewer2.Visible = False
            Me.ReportViewer3.Visible = False
            Me.ReportViewer1.Dock = DockStyle.Fill
            Me.ReportViewer1.RefreshReport()

        ElseIf RadioButton2.Checked Then
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = True
            Me.ReportViewer3.Visible = False
            Me.ReportViewer2.Dock = DockStyle.Fill
            Me.ReportViewer2.RefreshReport()

        ElseIf RadioButton3.Checked Then
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = False
            Me.ReportViewer3.Visible = True
            Me.ReportViewer3.Dock = DockStyle.Fill
            Me.ReportViewer3.RefreshReport()

        End If
    End Sub

End Class