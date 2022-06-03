Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Collections.Generic
Public Class ManageUsers
    Dim uCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim uCmd As New SqlCommand("", uCnn)
    Dim uDR As SqlDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ManageUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.UsersDBDataSet.Users)
        UserIDTextBox.Hide()
        DrawUserList()
        LoadAllCenters()
        LoadCentersByUser(UserIDTextBox.Text)
        Me.Text = Me.Text
    End Sub
    Private Sub LoadAllCenters()
        Dim sql As String
        Dim SqlDA As SqlDataAdapter
        Dim DS As DataSet
        sql = "select CenterID,CenterName from CenterNames"
        Try
            uCnn.Open()
            SqlDA = New SqlDataAdapter("select CenterID,CenterName from CenterNames", uCnn)
            DS = New DataSet
            SqlDA.Fill(DS, "CenterNames")
            ListBox1.DisplayMember = "CenterName"
            ListBox1.ValueMember = "CenterID"
            ListBox1.DataSource = DS.Tables(0)
            'While uDR.Read
            '    Me.ListBox1.Items.Add(uDR("centerid") + uDR("CenterName"))
            'End While
            uCnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            uCnn.Close()
        End Try
    End Sub
    Private Sub LoadCentersByUser(ByRef uid As Integer)
        Dim uSql As String
        Dim SqlDA As SqlDataAdapter
        Dim DS As DataSet
        If Not IsNumeric(uid) Then Exit Sub
        uSql = "SELECT        UsersAccCenters.UserID, UsersAccCenters.CenterID, UsersAccCenters.AccAllow,CenterNames.CenterName "
        uSql = uSql + " FROM            Users INNER JOIN UsersAccCenters ON Users.UserID = UsersAccCenters.UserID "
        uSql = uSql + "   INNER JOIN  CenterNames ON UsersAccCenters.CenterID = CenterNames.CenterID  where Users.UserID= " + uid.ToString + " "
        Try
            uCnn.Open()
            uCmd.CommandText = uSql
            SqlDA = New SqlDataAdapter(uSql, uCnn)
            DS = New DataSet
            SqlDA.Fill(DS, "UsersAccCenters")
            ListBox2.DisplayMember = "CenterName"
            ListBox2.ValueMember = "CenterID"
            ListBox2.DataSource = DS.Tables(0)
            uCnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            uCnn.Close()
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim NewUserID As Integer
        NewUserID = Me.UsersTableAdapter.GetNewUserID
        Me.UsersBindingSource.AddNew()
        Me.UserIDTextBox.Text = NewUserID
        LinkLabel3.Visible = True
        LoadCentersByUser(-1)
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.UsersBindingSource.CurrencyManager.CancelCurrentEdit()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Not CheckFrm() Then Exit Sub
        If CheckBox6.Checked Then
            If Not IsDate(TextBox4.Text) Then
                MsgBox("يجب تحديد تاريخ إنتهاء صلاحية الحساب")
                TextBox4.Focus()
                TextBox4.SelectAll()
                Exit Sub
            End If
        End If
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UsersDBDataSet)
            Dim Dr As DataRowView = Me.UsersBindingSource.Current
            'With Cu_User
            '    .AllowDelete = Dr("AllowDelete")
            '    .AllowModify = Dr("AllowModify")
            '    .AllowOpen = Dr("AllowOpen")
            '    .AllowPrint = Dr("AllowPrint")
            '    .ExpireDate = Dr("ExpireDate")
            '    .IsExpire = Dr("IsExpire")
            '    .IsActive = Dr("IsActive")
            '    .IsAdmin = Dr("IsAdmin")
            'End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DrawUserList()
            MsgBox("تمت العملية بنجاح")
        End Try

    End Sub
    Private Function CheckFrm() As Boolean
        Dim r As Boolean
        If TextBox1.TextLength < 1 Then
            r = False
            MsgBox("الرجاء كتابة اسم المستخدم بشكل صحيح")
            TextBox1.BackColor = Color.Red
            Return False
        Else
            TextBox1.BackColor = Color.White
            r = True
        End If
        'If TextBox2.Text <> TextBox3.Text Then
        '    r = False
        '    MsgBox("كلمة المرور غير مطابقة لتأكيد كلمة المرور")
        '    TextBox2.BackColor = Color.Red
        '    TextBox3.BackColor = Color.Red
        '    Return False
        'Else
        '    TextBox2.BackColor = Color.White
        '    TextBox3.BackColor = Color.White
        '    r = True
        'End If
        Return r
    End Function
    Private Sub DrawUserList()
        ListView1.Clear()
        Dim UserCount As Integer = Me.UsersBindingSource.Count
        For i As Integer = 0 To UserCount - 1
            ListView1.Items.Add(Me.UsersTableAdapter.GetData(i)("UserName"), IIf(Me.UsersTableAdapter.GetData(i)("IsActive") = True, 5, 6))
        Next i

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Dim cUserName As String = ListView1.SelectedItems(0).Text
        Dim pos As Integer = Me.UsersBindingSource.Position
        pos = Me.UsersBindingSource.Find("UserName", cUserName)
        Me.UsersBindingSource.Position = pos
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Dsql, Isql As String, mcuerid As Integer
        mcuerid = UserIDTextBox.Text
        Dsql = "delete UsersAccCenters  "
        Dsql = Dsql + " where userid=" + mcuerid.ToString + ""
        Isql = "INSERT INTO [UsersAccCenters]([UserID]  ,[CenterID] ,[AccAllow]) "
        Isql = Isql + " select  " + mcuerid.ToString + ",CenterID ,1 from CenterNames "
        Try
            uCnn.Open()
            uCmd.CommandText = Dsql
            uCmd.ExecuteNonQuery()
            uCmd.CommandText = Isql
            uCmd.ExecuteNonQuery()
            uCnn.Close()
            LoadCentersByUser(UserIDTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
            uCnn.Close()
        End Try
        'ListBox2.DataSource = Nothing
        'ListBox2.Items.Clear()
        'ListBox2.Items.AddRange(ListBox1.Items)
        'ListBox2.DisplayMember = "CenterName"
        'ListBox2.ValueMember = "CenterID"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim Dsql As String, mcuerid As Integer
        mcuerid = UserIDTextBox.Text
        Dsql = "delete UsersAccCenters  "
        Dsql = Dsql + " where userid=" + mcuerid.ToString + ""
        Try
            uCnn.Open()
            uCmd.CommandText = Dsql
            uCmd.ExecuteNonQuery()
            uCnn.Close()
            LoadCentersByUser(UserIDTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
            uCnn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim a, b, Isql, mcuerid As String
        mcuerid = UserIDTextBox.Text
        a = ListBox1.SelectedItems(0)(1).ToString
        b = ListBox1.SelectedItems(0)(0).ToString
        Isql = "INSERT INTO [UsersAccCenters]([UserID]  ,[CenterID] ,[AccAllow]) "
        Isql = Isql + " Values ( " + mcuerid.ToString + "," + b.ToString + " ,1 ) "
        If ListBox2.FindString(a) <> 0 Then
            Try
                uCnn.Open()
                uCmd.CommandText = Isql
                uCmd.ExecuteNonQuery()
                uCnn.Close()
                LoadCentersByUser(mcuerid)
            Catch ex As Exception
                MsgBox(ex.Message)
                uCnn.Close()
            End Try
        Else
            'MsgBox("المديرية المحددة موجودة مسبقا")
        End If
       
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim a, b, Dsql, mcuerid As String
        mcuerid = UserIDTextBox.Text
        a = ListBox2.SelectedItems(0)(1).ToString
        b = ListBox2.SelectedItems(0)(0).ToString
        Dsql = "delete from UsersAccCenters where(UserID=" + mcuerid.ToString + " and CenterID=" + a + ") "
        If ListBox2.FindString(a) <> 0 Then
            Try
                uCnn.Open()
                uCmd.CommandText = Dsql
                uCmd.ExecuteNonQuery()
                uCnn.Close()
                LoadCentersByUser(mcuerid)
            Catch ex As Exception
                MsgBox(ex.Message)
                uCnn.Close()
            End Try
        Else
            'MsgBox("المديرية المحددة موجودة مسبقا")
        End If
    End Sub

    Private Sub UserIDTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UserIDTextBox.TextChanged
        If UserIDTextBox.Text <> "" Then
            LoadCentersByUser(UserIDTextBox.Text)
        End If
    End Sub

    Private Sub AllowSalaryCheckBox_Click(sender As System.Object, e As System.EventArgs) Handles AllowWorkersCheckBox.Click, AllowSalaryCheckBox.Click, AllowManagersCheckBox.Click, AllowEngeneersCheckBox.Click, AllowContractsCheckBox.Click, AllowAgentsCheckBox.Click
        If sender.CheckState = CheckState.Checked Then
            For Each ctrl As CheckBox In GroupBox2.Controls
                ctrl.CheckState = CheckState.Unchecked
            Next
            sender.CheckState = CheckState.Checked
        Else

        End If
    End Sub

   
End Class