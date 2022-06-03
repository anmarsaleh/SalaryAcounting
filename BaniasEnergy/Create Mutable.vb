Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class Create_Mutable
    Dim Mcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim mCmd As New SqlCommand("", Mcnn)

    Private Sub Create_Mutable_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.ReportViewer1.Visible Or Me.ReportViewer2.Visible Then
            e.Cancel = True
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = False
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub Create_Mutable_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportsDataSet.MutableReport' table. You can move, or remove it, as needed.
        Me.MutableReportTableAdapter.Fill(Me.ReportsDataSet.MutableReport)
        Me.SMonthTextBox.Hide()
        Me.SYearTextBox.Hide()
        'TODO: This line of code loads data into the 'MutableDataSet.CreateMutable' table. You can move, or remove it, as needed.
        Me.CreateMutableTableAdapter.Fill(Me.MutableDataSet.CreateMutable, SalaryMounth, SalaryYear)
        If Me.CreateMutableBindingSource.Count = 0 Then
            Me.CreateMutableBindingSource.AddNew()
            Me.SMonthTextBox.Text = SalaryMounth
            Me.SYearTextBox.Text = SalaryYear
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Function CalcM() As Boolean
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
            CalcDriveMutable()
            Mcnn.Close()
            r = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Mcnn.Close()
            r = False
        End Try

        Return r
    End Function
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.CreateMutableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MutableDataSet)
        Me.MutableDataSet.AcceptChanges()
        If CalcDriveMutable() Then
            Me.CreateMutableTableAdapter.Fill(Me.MutableDataSet.CreateMutable, SalaryMounth, SalaryYear)
        Else
            MsgBox("فشلت العملية يرجى المحاولة مرة أخرى")
        End If
        'If CalcM() = True Then
        '    Me.CreateMutableTableAdapter.Fill(Me.MutableDataSet.CreateMutable, SalaryMounth, SalaryYear)
        'Else
        '    MsgBox("فشلت العملية يرجى المحاولة مرة أخرى")
        'End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
        Me.ReportViewer2.Visible = False
        Me.ReportViewer1.Visible = True
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label1.Visible = True
            DateTimePicker1.Visible = True
            Button4.Visible = True
            DateTimePicker1.Value = Now.Date
        Else
            Label1.Visible = False
            DateTimePicker1.Visible = False
            Button4.Visible = False
            Me.CreateMutableTableAdapter.Fill(Me.MutableDataSet.CreateMutable, SalaryMounth, SalaryYear)
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim y, m As Integer
        y = Year(DateTimePicker1.Value)
        m = Month(DateTimePicker1.Value)
        Me.CreateMutableTableAdapter.Fill(Me.MutableDataSet.CreateMutable, m, y)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            Mcnn.Open()
            Dim mCmd As New SqlCommand("", Mcnn)
            mCmd.CommandType = CommandType.StoredProcedure
            mCmd.CommandText = "SumMutable"
            mCmd.Parameters.AddWithValue("@cn", TextBox1.Text)
            mCmd.Parameters.AddWithValue("@mc", TextBox2.Text)
            TextBox3.Text = mCmd.ExecuteScalar.ToString
            Mcnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Mcnn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Maximized
        Me.ReportViewer2.Visible = True
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Dock = DockStyle.Fill
        Me.ReportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        Me.ReportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class