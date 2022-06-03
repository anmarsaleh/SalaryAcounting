Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class UserAcount
    Dim Cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Cmd As New SqlCommand("", Cnn)
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Dim StrSql As String = "update Users set UserName=N'" & TxtName.Text.Trim & "',UserPassword=N'" & TxtconfirmPW.Text.Trim & "'  where (UserID=" & Cu_User.UserID & ")"
        If TxtOldPW.Text.Trim = Cu_User.UserPW Then
            If TxtNewPW.Text.Trim = TxtconfirmPW.Text.Trim Then
                Try
                    Cnn.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()
                Catch ex As SqlException
                    MsgBox(ex.Message)
                End Try
                Cmd = Nothing
                Cnn.Close()
                If MsgBox("يجب تسخيل الخروج لتأخذ التغييرات مفعولها", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Application.Restart()
                End If
            Else
                MsgBox("كلمة المرور الجديدة لا تطابق تأكيد كلمة المرور")
                TxtconfirmPW.SelectAll()
                TxtNewPW.Focus()
                TxtNewPW.SelectAll()
            End If
        Else
            MsgBox("كلمة المرور القديمة غير صالحة")
            TxtOldPW.Focus()
            TxtOldPW.SelectAll()
        End If
    End Sub

    Private Sub UserAcount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtName.Text = Cu_User.UserName
    End Sub
End Class