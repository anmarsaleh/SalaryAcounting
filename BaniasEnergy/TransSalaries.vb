Imports Excel = Microsoft.Office.Interop.Excel

Imports System.Runtime.InteropServices
Imports System.Data
Imports System.Data.SqlClient
Public Class TransSalaries
    Dim Cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Cmd As New SqlCommand("", Cnn)
    Dim DR As SqlDataReader
    
    Private Sub TransSalaries_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "d:\" + SalaryMounth.ToString + "-" + SalaryYear.ToString + "-Salaries.xlsx"
    End Sub
    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
       
        Label2.Visible = True
        PictureBox1.Visible = True
        Panel1.Refresh()
        Application.DoEvents()
        System.Threading.Thread.Sleep(2000)
        Panel1.Refresh()
        Application.DoEvents()
        PictureBox1.Image = New Bitmap(My.Resources.images)
        Panel1.Refresh()
        Application.DoEvents()

        Label3.Visible = True
        PictureBox2.Visible = True
        Panel1.Refresh()
        Application.DoEvents()
        System.Threading.Thread.Sleep(2000)
        PictureBox2.Image = New Bitmap(My.Resources.images)
        Panel1.Refresh()
        Application.DoEvents()

        Label4.Visible = True
        PictureBox3.Visible = True
        Panel1.Refresh()
        Application.DoEvents()
        System.Threading.Thread.Sleep(1000)
        PictureBox3.Image = New Bitmap(My.Resources.images)
        Panel1.Refresh()
        Application.DoEvents()
        Dim Sql As String
        Dim cnt As Integer
        Dim xl As Microsoft.Office.Interop.Excel.Application

        xl = New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        wb = xl.Workbooks.Add
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        ws = wb.ActiveSheet
        GroupBox1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        Me.ControlBox = False
        
        Label5.Visible = True
        Label5.Text = "...جاري تصدير البيانات"
        System.Threading.Thread.Sleep(1000)
        Me.ProgressBar1.Visible = True
        Panel1.Refresh()
        Application.DoEvents()
        Sql = "select EmpID, CardNo,FullName,TotalSalary,UserID,getdate() as dd from SalaryRecords where CenterID<>95 and CardNo<>N'' and  IsContract=0 order by CardNo asc"
        Try
            Cnn.Open()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Sql
            DR = Cmd.ExecuteReader
            Me.ProgressBar1.Maximum = 1600
            cnt = 2
            ws.Range("A1").Value = "رقم الحساب"
            ws.Range("A1").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            ws.Range("B1").Value = " الراتب الصافي"
            ws.Range("B1").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            ws.Range("C1").Value = " الإسم الثلاثي"
            ws.Range("C1").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            While (DR.Read)
                If cnt < 1600 Then Me.ProgressBar1.Value = cnt
                ws.Range("A" + cnt.ToString + "").NumberFormat = "@" ' wsTemp.Range("A" + cnt.ToString + "").NumberFormat
                ws.Range("A" + cnt.ToString + "").Value = DR("CardNO").ToString
                ws.Range("A" + cnt.ToString + "").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                ws.Range("B" + cnt.ToString + "").Value = CInt(DR("TotalSalary")).ToString
                ws.Range("B" + cnt.ToString + "").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                ws.Range("C" + cnt.ToString + "").Value = DR("FullName").ToString
                ws.Range("C" + cnt.ToString + "").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                Panel1.Refresh()
                Application.DoEvents()
                cnt = cnt + 1
            End While

            ws.Range("B" + cnt.ToString + "").Value = "=sum(B2:B" + (cnt - 1).ToString + ")"
            ws.Range("A" + cnt.ToString + "").Value = "المجموع الكلي"
            Me.ProgressBar1.Step = 1600
            Cnn.Close()
            Label5.Text = "تم تصدير البيانات بنجاح"
            PictureBox4.Visible = True
            PictureBox4.Image = New Bitmap(My.Resources.images)
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            Cnn.Close()
            xl.Quit()
            ReleaseComObject(ws)
            ReleaseComObject(ws)
            ReleaseComObject(wb)
            ReleaseComObject(wb)
            ReleaseComObject(xl)
            GroupBox1.Enabled = True
            Button2.Enabled = True
            Button4.Enabled = True
            Me.ControlBox = True
            Label5.Text = "فشلت عملية تصدير البيانات"
            PictureBox4.Visible = True
            PictureBox4.Image = New Bitmap(My.Resources.Fail)
        End Try
        Dim xFilename As String = "d:\" & SalaryMounth.ToString & "_" + SalaryYear.ToString & "_Salaries.xlsx"
        ' xl.XlFileFormat.xlWorkbookDefault()
        'xl.DisplayAlerts = False
        'xl.SaveWorkspace(xFilename)
        Dim i As Integer = 1
        For i = 1 To 25
            If Not My.Computer.FileSystem.FileExists(xFilename) Then
                'My.Computer.FileSystem.DeleteFile(xFilename, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                Exit For
            End If
            xFilename = "d:\" & i.ToString + "_" & SalaryMounth.ToString & "_" & SalaryYear.ToString & "_Salaries.xlsx"
        Next i
       
        wb.SaveAs(xFilename, Excel.XlFileFormat.xlWorkbookDefault, TextBox1.Text, TextBox2.Text, CheckBox1.Checked, , Excel.XlSaveAsAccessMode.xlNoChange, , , , , )

        wb.Close()
        ' xl.DisplaAlerts = True
        xl.Quit()
        ReleaseComObject(ws)
        ReleaseComObject(ws)
        ReleaseComObject(wb)
        ReleaseComObject(wb)
        ReleaseComObject(xl)
        GroupBox1.Enabled = True
        Button2.Enabled = True
        Button4.Enabled = True
        Me.ControlBox = True
        Application.DoEvents()
        'Dim procID As Integer
        Dim newProc As Diagnostics.Process

        'newProc.WaitForExit()
        'Dim procEC As Integer = -1
        'If newProc.HasExited Then
        '    procEC = newProc.ExitCode
        'End If
        If My.Computer.FileSystem.FileExists(xFilename) Then

            If CheckBox3.CheckState = CheckState.Checked Then
                newProc = Diagnostics.Process.Start(xFilename)

            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim f As New TransBankRpt
        f.Show()
    End Sub
End Class