Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Public Class UodateForAllFrm
    Dim Cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Cmd As SqlCommand
    Dim StrSql As String
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Cmd = Nothing
        Cnn.Close()
        Me.Close()
    End Sub

    Private Sub UodateForAllFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Mymainfrm = New MainFrm
        Mymainfrm.Show()

    End Sub

    Private Sub UodateForAllFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mymainfrm.Close()
        Cnn.Open()
        Cmd = New SqlCommand(StrSql, Cnn)
        Cmd.CommandType = CommandType.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button1.Click
        Try
            Select Case sender.name
                Case "Button1"
                    If InStr(TextBox1.Text, "%") > 0 Then
                        Dim r As String = TextBox1.Text
                        r = Strings.Replace(TextBox1.Text, "%", "")
                        If Not IsNumeric(r) Then Exit Sub
                        StrSql = "update SalaryRecords set Allowance=(SlitSalary *" & r & ")/100"
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    ElseIf IsNumeric(TextBox1.Text) Then
                        StrSql = "update SalaryRecords set Allowance=" & TextBox1.Text & ""
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    End If
                Case "Button3"
                    If InStr(TextBox3.Text, "%") > 0 Then
                        Dim r As String = TextBox3.Text
                        r = Strings.Replace(TextBox3.Text, "%", "")
                        If Not IsNumeric(r) Then Exit Sub
                        StrSql = "update SalaryRecords set Gift=(SlitSalary *" & r & ")/100"
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    ElseIf IsNumeric(TextBox3.Text) Then
                        StrSql = "update SalaryRecords set Gift=" & TextBox3.Text & ""
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    End If
                Case "Button4"
                    If InStr(TextBox4.Text, "%") > 0 Then
                        Dim r As String = TextBox4.Text
                        r = Strings.Replace(TextBox4.Text, "%", "")
                        If Not IsNumeric(r) Then Exit Sub
                        StrSql = "update SalaryRecords set Slave_AssistBox=(SlitSalary *" & r & ")/100,IsAssistBox=1"
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    ElseIf IsNumeric(TextBox4.Text) Then
                        StrSql = "update SalaryRecords set Slave_AssistBox=" & TextBox4.Text & " ,IsAssistBox=1"
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    End If
                Case "Button5"
                    If InStr(TextBox5.Text, "%") > 0 Then
                        Dim r As String = TextBox5.Text
                        r = Strings.Replace(TextBox5.Text, "%", "")
                        If Not IsNumeric(r) Then Exit Sub
                        StrSql = "update SalaryRecords set IntegratorSolidarity=(SlitSalary *" & r & ")/100"
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    ElseIf IsNumeric(TextBox5.Text) Then
                        StrSql = "update SalaryRecords set IntegratorSolidarity=" & TextBox5.Text & ""
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    End If
                Case "Button6"
                    If InStr(TextBox6.Text, "%") > 0 Then
                        Dim r As String = TextBox6.Text
                        r = Strings.Replace(TextBox6.Text, "%", "")
                        If Not IsNumeric(r) Then Exit Sub
                        StrSql = "update SalaryRecords set Typo=(SlitSalary*" & r & ")/100"
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    ElseIf IsNumeric(TextBox6.Text) Then
                        StrSql = "update SalaryRecords set Typo=" & TextBox6.Text & ""
                        Cmd.CommandText = StrSql
                        Cmd.ExecuteNonQuery()
                    End If
            End Select
        Catch ex As SqlException
            MsgBox(ex.Message)
            Exit Sub
        End Try
        MsgBox("تمت العملية بنجاح")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        StrSql = "update SalaryRecords set IsSocialInsurance=" & CheckBox1.CheckState & ",ISCooperationWorkers=" & CheckBox3.CheckState & " ,IsAssistBox=" & CheckBox5.CheckState & ",IsstipendInsurance=" & CheckBox8.CheckState & ""
        Cmd.CommandText = StrSql
        Try
            Cmd.ExecuteNonQuery()
            MsgBox("تم الإجراء بنجاح")
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub تنفيذToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تنفيذToolStripMenuItem.Click
        StrSql = ""
        Select Case ContextMenuStrip1.SourceControl.Name
            Case "CheckBox1"
                StrSql = "update SalaryRecords set IsSocialInsurance=" & CheckBox1.CheckState & ""
            Case "CheckBox2"
                ''StrSql = "update SalaryRecords set IsCooperateBox = " & CheckBox2.CheckState & ""
            Case "CheckBox3"
                StrSql = "update SalaryRecords set ISCooperationWorkers=" & CheckBox3.CheckState & ""
            Case "CheckBox4"
                ' StrSql = "update SalaryRecords set IsEndService=" & CheckBox4.CheckState & ""
            Case "CheckBox5"
                StrSql = "update SalaryRecords set IsAssistBox=" & CheckBox5.CheckState & ""
            Case "CheckBox6"
                ' StrSql = "update SalaryRecords set IsDeathAssist=" & CheckBox6.CheckState & ""
            Case "CheckBox7"
                '  StrSql = "update SalaryRecords set IsSolidaritySocial=" & CheckBox7.CheckState & ""
            Case "CheckBox8"
                StrSql = "update SalaryRecords set IsstipendInsurance=" & CheckBox8.CheckState & ""
        End Select
        If StrSql <> "" Then
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Try
            StrSql = "declare @date date "
            StrSql = StrSql + " select @date=Sdate from CreateMutable "
            StrSql = StrSql + " update SalaryRecords set mutableDays=( "
            StrSql = StrSql + " select datediff(day, dateadd(day, 1-day(@date), @date),dateadd(month, 1, dateadd(day, 1-day(@date), @date))) ) "
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            MsgBox("تم")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub
End Class