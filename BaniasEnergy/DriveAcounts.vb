Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class DriveAcounts
    Dim Mcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim mCmd As New SqlCommand("", Mcnn)
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub DriveAcounts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SalaryYearTextBox.Hide()
        SalarymonthTextBox.Hide()
        Me.ReportViewer1.Visible = False
        'TODO: This line of code loads data into the 'DriveDataSet.DriveAcounts' table. You can move, or remove it, as needed.
        Me.DriveAcountsTableAdapter.Fill(Me.DriveDataSet.DriveAcounts, SalaryYear, SalaryMounth)
        Me.SumDriveMarkValueTableAdapter.Fill(Me.DriveDataSet.SumDriveMarkValue)
        If Me.DriveAcountsBindingSource.Count = 0 Then
            Me.DriveAcountsBindingSource.AddNew()
            Me.SalaryYearTextBox.Text = SalaryYear
            Me.SalarymonthTextBox.Text = SalaryMounth
            Me.DriveDateDateTimePicker.Value = Now.Date
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Function CalcD() As Boolean
        Dim r As Boolean = False
        Try
            Mcnn.Open()
            mCmd.CommandType = CommandType.Text
            'If File.Exists(Application.StartupPath + "\CreateMutable.sql") Then
            '    mCmd.CommandText = File.ReadAllText(Application.StartupPath + "\CreateMutable.sql")
            '    mCmd.ExecuteNonQuery()
            '    My.Settings.Cmutable = File.ReadAllText(Application.StartupPath + "\CreateMutable.sql")
            '    My.Settings.Save()
            'Else
            '    MsgBox("لم يتم العثور على ملف أو الملف غير صالح ""CreateMutable")
            '    MsgBox("سيقوم البرنامج بإنشاء الملف المفقود وفق آخر عملية حسابية ناجحة")
            '    File.Create(Application.StartupPath + "\CreateMutable.sql")
            '    File.WriteAllText(Application.StartupPath + "\CreateMutable.sql", My.Settings.Cmutable.ToString)
            '    mCmd.CommandText = My.Settings.Cmutable
            '    mCmd.ExecuteNonQuery()
            'End If
            CalcDrive()
            Mcnn.Close()
            r = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Mcnn.Close()
            r = False
        End Try
        Return r
    End Function
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.Validate()
        Me.DriveAcountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DriveDataSet)
        Me.DriveDataSet.AcceptChanges()
        If CalcDrive() Then
            Me.DriveAcountsTableAdapter.Fill(Me.DriveDataSet.DriveAcounts, SalaryYear, SalaryMounth)
            Me.SumDriveMarkValueTableAdapter.Fill(Me.DriveDataSet.SumDriveMarkValue)
        Else
            MsgBox("فشلت العملية يرجى المحاولة مرة أخرى")
        End If
        Me.DriveAcountsBindingSource.ResetBindings(False)
        Me.SumDriveMarkValueBindingSource.ResetBindings(False)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ReportViewer1.Visible Then
            ReportViewer1.Dock = DockStyle.None
            ReportViewer1.Visible = False
            Button2.Text = "عرض التقرير "
            Me.WindowState = FormWindowState.Normal
        Else
            ReportViewer1.Visible = True
            ReportViewer1.Dock = DockStyle.Fill
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
            Button2.Text = "إغلاق التقرير"
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If ReportViewer2.Visible Then
            ReportViewer1.Dock = DockStyle.None
            ReportViewer2.Visible = False
            Button5.Text = "عرض تقرير العلامة "
            Me.WindowState = FormWindowState.Normal
        Else
            ReportViewer2.Visible = True
            ReportViewer2.Dock = DockStyle.Fill
            ReportViewer2.RefreshReport()
            ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
            Button5.Text = "إغلاق تقرير العلامة"
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class