Imports System.Data
Imports System.Data.SqlClient
Public Class LogInFrm
    Dim SqlCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim SqlCmd As SqlCommand
    Dim Rd As SqlDataReader
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogIn.Click
        Dim Str1 As String = "SELECT COUNT(*) AS RecCount FROM   (SELECT  UserName FROM Users  WHERE   (userID = @UserID)) AS derivedtbl_1"
        Dim str2 As String = "SELECT     UserPassword FROM Users  WHERE     (UserID = @UserID)"
        Dim InUname, InPW As String
        InUname = ComboBox1.SelectedValue 'Trim(TextBox1.Text)
        InPW = Trim(TextBox2.Text)
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(Str1, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.Parameters.AddWithValue("@UserID", InUname)
            Dim r As Integer = SqlCmd.ExecuteScalar
            If r > 0 Then
                Dim p As String = ""
                SqlCmd.CommandText = str2
                p = SqlCmd.ExecuteScalar.ToString
                SqlCmd.CommandText = "Update Users SET PcName=N'" & My.Computer.Name & "' where UserID=" & ComboBox1.SelectedValue & ""
                SqlCmd.ExecuteNonQuery()
                If p = InPW Then
                    LoadUser()
                    LoadCalc()
                    SqlCnn.Close()
                    SqlCmd = Nothing
                    If Cu_User.ExpiredUser Then
                        MsgBox("للأسف مدة صلاحية حسابك قد أنتهتة" & Chr(13) & "الرجاء مراجعة مسؤول النظام")
                        Exit Sub
                    End If
                    If Not Cu_User.IsActive Then
                        MsgBox("الحساب الحالي معطل!" & Chr(13) & "الرجاء مراجعة مسؤول النظام")
                        Exit Sub
                    End If
                    'Dim f As New MainFrm
                    'f.Show()
                    'تنفيذ ملف preload
                    Try
                        PreLoad()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Mymainfrm = New MainFrm
                    Mymainfrm.Show()
                    Me.Close()
                Else
                    MsgBox("الرجاء التأكد من كلمة المرور")
                    TextBox2.Focus()
                    TextBox2.SelectAll()
                    SqlCnn.Close()
                    Exit Sub
                End If
            Else
                MsgBox("الرجاء التأكد من اسم المستخدم")
                TextBox1.Focus()
                TextBox1.SelectAll()
                SqlCnn.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ' Application.Exit()
        End Try
    End Sub
    Private Sub LoadUser()
        Try
            SqlCmd.CommandText = "select * from users where userID='" & ComboBox1.SelectedValue & "'"
            Rd = SqlCmd.ExecuteReader
            If Rd.Read() Then
                Cu_User = New UsersClass(Rd("UserId"), Rd("UserName").ToString, Rd("ExpireDate").ToString, Rd("IsAdmin"), Rd("IsActive"), Rd("UserPassword").ToString, Rd("AllowOpen"), _
                                         Rd("AllowDelete"), Rd("AllowModify"), Rd("AllowPrint"), Rd("IsExpire"), Rd("AllowSalary"), Rd("AllowWorkers"), Rd("AllowAgents"), Rd("AllowManagers"), Rd("AllowEngeneers"), Rd("AllowContracts"), Rd("AllRecords"))
            End If
            Rd.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Private Sub LogInFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'UsersDBDataSet.Users' table. You can move, or remove it, as needed.
        Try
            Me.UsersTableAdapter.Fill(Me.UsersDBDataSet.Users)
            TextBox1.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        End Try
        'Me.Text += " شهر " + SalaryMounth + " للعام " + SalaryYear
    End Sub
    Private Sub LoadCalc()
        If My.Computer.Name = "WIN-O7R3FJDV768" Or My.Computer.Name = "RAMITTA-PC" And Cu_User.IsAdmin = True Then
            LoadCalcFiles()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Focus()
    End Sub
End Class