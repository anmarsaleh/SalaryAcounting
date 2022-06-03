Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class ReturnToEmpFrm
    Dim SqlCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim SqlCmd As SqlCommand
    Dim Dr As SqlDataReader
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub BacklogReturnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BacklogReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub

    Private Sub ReturnToEmpFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.BacklogRecover' table. You can move, or remove it, as needed.
        Me.BacklogRecoverTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogRecover)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.BacklogReturn' table. You can move, or remove it, as needed.
        Me.BacklogReturnTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogReturn)
        CreateDAteTextBox.Hide()
        BacklogRIDTextBox.Hide()
        EmpIDTextBox.Hide()
        LastModifyTextBox.Hide()
        RM_RemainingTextBox.Hide()
        UserIDTextBox.Hide()
        Me.ConnectWithTextBox.Hide()
        ControlIDTextBox.Hide()
        'BacklogNameTextBox.Hide()
        ChkInf()
        'Me.Panel3.Enabled = False
        Me.BacklogReturnBindingSource.Filter = "EmpID=" & Mymainfrm.EmpIDTextBox.Text & ""
        If Cu_User.IsAdmin Then
            ToolStripButton1.Enabled = True
        Else
            ToolStripButton1.Enabled = False
        End If
    End Sub
    Private Sub ChkInf()
        'My.Settings.RtnName.ToArray()
        BacklogNameComboBox.Items.Clear()
        BacklogNameComboBox.Items.Add("جديد")
        Dim Strsql As String = "Select * from ReturnNames"
        SqlCnn.Open()
        SqlCmd = New SqlCommand(Strsql, SqlCnn)
        SqlCmd.CommandType = CommandType.Text
        Dr = SqlCmd.ExecuteReader
        While Dr.Read()
            BacklogNameComboBox.Items.Add(Dr("RtnName"))
        End While
        Dr.Close()
        SqlCmd = Nothing
        SqlCnn.Close()
        ''Dim r As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("RtnToEmp")
        ''If r Is Nothing Then Exit Sub
        ''Dim w() As String = r.GetValueNames
        ' File.Create("c:\lolo.txt")
        ''File.WriteAllLines("c:\lolo.txt", w)
        ''BacklogNameComboBox.Items.AddRange(w)
        'BacklogNameComboBox.Items.AddRange(My.Settings.RtnName.ToArray())
    End Sub

    Private Sub BacklogNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacklogNameComboBox.SelectedIndexChanged
        If BacklogNameComboBox.Text = "جديد" Then
            Dim NewRtnName As String = InputBox("أدخل اسم البند الجديد")
            If NewRtnName.Length = 0 Then Exit Sub
            Dim Strsql As String = "INSERT INTO  ReturnNames (RtnNameID,RtnName) VALUES(@p1,@p2)"
            Dim StrNewID As String = "Select Max(RtnNameID)+1 from ReturnNames"
            SqlCnn.Open()
            SqlCmd = New SqlCommand(StrNewID, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            Dim Nid As Integer
            If IsDBNull(SqlCmd.ExecuteScalar) Then
                Nid = 1
            Else
                Nid = SqlCmd.ExecuteScalar
            End If
            SqlCmd.CommandText = ""
            SqlCmd.CommandText = Strsql
            SqlCmd.Parameters.AddWithValue("@p1", Nid)
            SqlCmd.Parameters.AddWithValue("@p2", NewRtnName.Trim)
            SqlCmd.ExecuteNonQuery()
            SqlCmd = Nothing
            SqlCnn.Close()
            ChkInf()
        End If
        BacklogNameTextBox.Text = BacklogNameComboBox.Text
        'If BacklogNameComboBox.Text = "جديد" Then
        '    Dim NewRtnName As String = InputBox("أدخل اسم البند الجديد")
        '    Dim r As Microsoft.Win32.RegistryKey
        '    r = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("RtnToEmp")
        '    If r Is Nothing Then
        '        r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("RtnToEmp")
        '    End If
        '    Dim c As Integer = r.ValueCount + 1
        '    Microsoft.Win32.Registry.SetValue(Microsoft.Win32.Registry.CurrentUser.Name + "\RtnToEmp", NewRtnName, vbEmpty)

        '    'My.Settings.RtnName.Insert(0, Trim(NewRtnName))
        '    'My.Settings.Save()
        'End If
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        BacklogNameTextBox.Text = BacklogNameComboBox.Text
        Try
            Me.Validate()
            Me.BacklogReturnBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Panel3.Enabled = True
        Dim NewID As Integer
        If IsNothing(Me.BacklogReturnTableAdapter.GetNewRtnID) Then
            NewID = 1
        Else
            NewID = Me.BacklogReturnTableAdapter.GetNewRtnID
        End If
        Me.BacklogReturnBindingSource.AddNew()
        Me.BacklogRIDTextBox.Text = NewID
        Me.UserIDTextBox.Text = Cu_User.UserID
        Me.LastModifyTextBox.Text = Now.Date.ToString
        Me.CreateDAteTextBox.Text = Now.Date.ToString
        Me.EmpIDTextBox.Text = Mymainfrm.EmpIDTextBox.Text
        Me.ControlIDTextBox.Text = ControlID
    End Sub
    Dim ss1 As String = "الراتب المقطوع"
    Dim ss2 As String = "التعويض العائلي"
    Dim ss3 As String = "إختصاص"
    Dim ss4 As String = "طبيعة عمل"
    Dim ss5 As String = "تعويض مسؤولية"
    Dim ss6 As String = "تدفئة"
    Dim ss7 As String = "مخاطر عمل"
    Private Sub ConnectWithComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectWithComboBox.SelectedIndexChanged
        Select Case ConnectWithComboBox.Text
            Case ss1.Trim
                Me.ConnectWithTextBox.Text = "SlitSalary"
            Case ss2.Trim
                Me.ConnectWithTextBox.Text = "RepaymentFamily"
            Case ss3.Trim
                Me.ConnectWithTextBox.Text = "Specialize"
            Case ss4.Trim
                Me.ConnectWithTextBox.Text = "TypeSpecialize"
            Case ss5.Trim
                Me.ConnectWithTextBox.Text = "Authority"
            Case ss6.Trim
                Me.ConnectWithTextBox.Text = "warm"
            Case ss7.Trim
                Me.ConnectWithTextBox.Text = "DangerWork"
        End Select
    End Sub
    Private Sub BacklogReturnBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacklogReturnBindingSource.PositionChanged
        Select Case ConnectWithTextBox.Text
            Case "SlitSalary"
                ConnectWithComboBox.Text = "الراتب المقطوع"
            Case "RepaymentFamily"
                ConnectWithComboBox.Text = "التعويض العائلي"
            Case "Specialize"
                ConnectWithComboBox.Text = "إختصاص"
            Case "TypeSpecialize"
                ConnectWithComboBox.Text = "طبيعة عمل"
            Case "Authority"
                ConnectWithComboBox.Text = "تعويض مسؤولية"
            Case "warm"
                ConnectWithComboBox.Text = "تدفئة"
            Case "DangerWork"
                ConnectWithComboBox.Text = "مخاطر عمل"
        End Select
    End Sub
    Private Sub IsConnectCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsConnectCheckBox.CheckedChanged
        Me.ConnectWithComboBox.Visible = Me.IsConnectCheckBox.Checked
        Label3.Visible = Me.IsConnectCheckBox.Checked
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        If MsgBox("هل تريد بالتأكيد حذف البند الحالي؟", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Me.BacklogReturnBindingSource.RemoveCurrent()
            Try
                Me.Validate()
                Me.BacklogReturnBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("تم إلغاء العملية")
        End If
    End Sub

   
    Private Sub IsRepeatedCheckBox_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IsRepeatedCheckBox.CheckStateChanged
        RepeatedMountsTextBox.Visible = Me.IsRepeatedCheckBox.Checked
        Label4.Visible = Me.IsRepeatedCheckBox.Checked
        Label2.Visible = Me.IsRepeatedCheckBox.Checked
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim r As String
        r = InputBox("أدخل قيمة النسبة المؤية المرادة من الراتب المقطوع ليتم ادخالها في حقل المبلغ", "RAMITTA", 0)
        If IsNumeric(r) Then
            BacklogTotalTextBox.Text = Math.Ceiling(Val(Mymainfrm.SlitSalaryTextBox.Text * r / 100))
        Else
            MsgBox("خطأ في ادخال القيمة")
        End If
    End Sub

    Private Sub حفظالبندالمدخللجميعالعاملينToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles حفظالبندالمدخللجميعالعاملينToolStripMenuItem.Click
        Me.Panel3.Enabled = False
        If MsgBox("هل أنت متأكد من تطبيق قيمة بند الإعادة على جميع العاملين", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            If BacklogNameComboBox.Text.Length = 0 Then
                MsgBox("يجب إختيار بند للمتابعة")
                BacklogNameComboBox.Focus()
                Exit Sub
            End If
            Dim Strproc, tot As String
            Dim Ispercent As Byte = 0
            If InStr(BacklogTotalTextBox.Text, "%") > 0 Then
                Dim r As String = Trim(BacklogTotalTextBox.Text)
                r = Strings.Replace(Trim(BacklogTotalTextBox.Text), "%", "")
                If Not IsNumeric(r) Then Exit Sub
                tot = r
                Ispercent = 1
            Else
                tot = Trim(BacklogTotalTextBox.Text)
                Ispercent = 0
            End If
            Try
                If SqlCnn.State = ConnectionState.Open Then SqlCnn.Close()
                SqlCnn.Open()
                SqlCmd = New SqlCommand(My.Settings.DropPatchReturn, SqlCnn)
                SqlCmd.ExecuteNonQuery()

                SqlCmd.CommandType = CommandType.Text
                SqlCmd.CommandText = My.Settings.CreatePatchReturn
                SqlCmd.ExecuteNonQuery()

                SqlCnn.Close()
                SqlCnn.Open()
                SqlCmd.CommandType = CommandType.Text
                Strproc = "EXECUTE  [SalaryLatDB].[dbo].[ReturnPatch]  N'" & BacklogNameComboBox.Text & "'," & tot & "," & IsRepeatedCheckBox.CheckState & "," & IIf(RepeatedMountsTextBox.Text = "", 0, RepeatedMountsTextBox.Text) & "," & 0 & ",N'" & IIf(NotesTextBox.Text = "", "-", NotesTextBox.Text) & "'," & Cu_User.UserID & "," & ControlID & "," & ExpTaxCheckBox.CheckState & "," & Ispercent & ""
                SqlCmd.CommandText = Strproc
                SqlCmd.ExecuteNonQuery()
                SqlCnn.Close()
                'Me.BacklogRecoverBindingSource.RemoveCurrent()
                Me.BacklogReturnTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogReturn)
                SqlCnn.Close()
            Catch ex As SqlException
                MsgBox(ex.Message)
                SqlCnn.Close()
            End Try
        Else
            MsgBox("تم تجاهل الإجراء")
        End If
        Me.Panel3.Enabled = True
    End Sub

    Private Sub إلغاءالبندالمدخللجميعالعاملينToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles إلغاءالبندالمدخللجميعالعاملينToolStripMenuItem.Click
        Me.Panel3.Enabled = False
        If MsgBox("هل أنت متأكد من إلغاء بند الإعادة المحدد من جميع العاملين", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            If BacklogReturnDataGridView.RowCount < 1 Then
                MsgBox("لا يوجد بند لحذفة")
                Exit Sub
            End If

            Dim cuName As String = BacklogReturnDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn2").Value
            Dim sqlr As String = "DELETE FROM BacklogReturn WHERE BacklogName=N'" & cuName & "'"
            Try
                If SqlCnn.State = ConnectionState.Open Then SqlCnn.Close()
                SqlCnn.Open()

                SqlCmd = New SqlCommand(sqlr, SqlCnn)
                SqlCmd.CommandTimeout = 60
                SqlCmd.ExecuteNonQuery()
                SqlCnn.Close()
                Me.BacklogReturnTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogReturn)
                SqlCnn.Close()
            Catch ex As SqlException
                MsgBox(ex.Message)
                SqlCnn.Close()
            End Try
        Else
            MsgBox("تم تجلهب العملية")
        End If
        Me.Panel3.Enabled = True
    End Sub

End Class