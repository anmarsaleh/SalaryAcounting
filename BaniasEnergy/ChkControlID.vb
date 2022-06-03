Imports System.Data
Imports System.Data.SqlClient
Public Class ChkControlID
    Dim chkCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim chkCmd As SqlCommand
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim m, y, c As Integer
        Dim str1, str2 As String
        m = TextBox1.Text
        y = TextBox2.Text
        str2 = " select controlid from SalareisControl where SalaryMount=" & m & " and SalaryYear=" & y & " "
        Try
            chkCnn.Open()
            chkCmd = New SqlCommand(str2, chkCnn)
            chkCmd.CommandType = CommandType.Text
            c = chkCmd.ExecuteScalar
            str1 = " update  SalaryRecords set SalaryYear=" & y & ",SalaryMount=" & m & ",ControlID=" & c & " "
            chkCmd.CommandText = str1
            chkCmd.ExecuteNonQuery()
            MsgBox("شكرا على تأكيد راتب الشهر الحالي")
            MsgBox("يجب إعاتدة تشغيل البرنامج")
            Application.Restart()
            chkCnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            chkCnn.Close()
        End Try
    End Sub

    Private Sub ChkControlID_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.TextBox1.Text = SalaryMounth
        Me.TextBox2.Text = SalaryYear
        'Try
        '    chkCnn.Open()
        '    chkCmd = New SqlCommand("", chkCnn)
        'Catch ex As Exception

        'End Try
    End Sub
End Class