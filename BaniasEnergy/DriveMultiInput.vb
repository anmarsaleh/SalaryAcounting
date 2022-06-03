Imports System.Data
Imports System.Data.SqlClient
Public Class DriveMultiInput
    Dim mdCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim mdCmd As SqlCommand
    Dim strsql As String, Drv As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then Exit Sub
        Dim isdrv As Integer, Sql, msgfrm As String
        If CheckBox1.Checked Then
            isdrv = 1
        Else
            isdrv = 0
        End If
        strsql = TextBox1.Text
        msgfrm = ""
        strsql = Strings.Replace(strsql, "+", ",")
        strsql = strsql.ToCharArray
        If IsNumeric(TextBox2.Text) Then
            Drv = TextBox2.Text
        Else
            Drv = 0
        End If
       
        If TextBox3.Text = "0" Then
            Sql = "update SalaryRecords set IsDrive=" + isdrv.ToString + ",DriveVication=" + Drv.ToString + " where EmpID in(" + strsql + ")"
            msgfrm = "هل تريد بالتأكيد تطبيق القيمة على جميع سجلات الحوافز التي أدخلت رقمها الذاتي"
            If Drv > 24 Then
                MsgBox("القيمة المدخلة خاطئة")
                Exit Sub
            End If
        ElseIf TextBox3.Text = "1" Then
            Sql = "update SalaryRecords set mutableDays=" + Drv.ToString + " where EmpID in(" + strsql + ")"
            msgfrm = "هل تريد بالتأكيد تطبيق القيمة على جميع سجلات الطوناج التي أدخلت رقمها الذاتي"
            If Drv > 31 Then
                MsgBox("القيمة المدخلة خاطئة")
                Exit Sub
            End If
        End If
        If MessageBox.Show(msgfrm, "RAMITTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                mdCnn.Open()
                mdCmd = New SqlCommand("", mdCnn)
                mdCmd.CommandType = CommandType.Text
                mdCmd.CommandText = Sql
                mdCmd.ExecuteNonQuery()
                mdCnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                mdCnn.Close()
            End Try
        Else
        End If
    End Sub
    Private Sub ChkInput(ByVal str As String)

    End Sub

    Private Sub DriveMultiInput_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox3.Hide()

    End Sub

    Private Sub DriveMultiInput_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If TextBox3.Text = "0" Then
            CheckBox1.Visible = True
            Label4.Text = "عدد الإستراحات"
            Me.Text = "إدخال متعدد لإستراحات الحوافز"
        ElseIf TextBox3.Text = "1" Then
            CheckBox1.Visible = False
            Me.Text = "إدخال متعدد لإستراحات لورديات الطوناج"
            Label4.Text = "عدد الورديات"
        End If

    End Sub
End Class