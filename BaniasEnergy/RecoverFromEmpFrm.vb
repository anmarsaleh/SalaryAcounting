Imports System.Data
Imports System.Data.SqlClient
Public Class RecoverFromEmpFrm
    Dim SqlCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim SqlCmd As SqlCommand
    Dim Dr As SqlDataReader
    Private Sub BacklogRecoverBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BacklogRecoverBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub

    Private Sub RecoverFromEmpFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.BacklogRecover' table. You can move, or remove it, as needed.
        Me.BacklogRecoverTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogRecover)
        BacklogRCIDTextBox.Hide()
        UserIDTextBox.Hide()
        LastModifyTextBox.Hide()
        CreateDateTextBox.Hide()
        RM_RemainingTextBox.Hide()
        EmpIDTextBox.Hide()
        ControlIDTextBox.Hide()
        ChkInf()
        Me.BacklogRecoverBindingSource.Filter = "EmpID=" & Mymainfrm.EmpIDTextBox.Text & ""
        ' Panel3.Enabled = False
        If Cu_User.IsAdmin Then
            ToolStripButton1.Enabled = True
        Else
            ToolStripButton1.Enabled = False
        End If
    End Sub
    Private Sub ChkInf()
        BacklogNameComboBox.Items.Clear()
        BacklogNameComboBox.Items.Add("جديد")
        Dim Strsql As String = "Select * from RecoverNames"
        SqlCnn.Open()
        SqlCmd = New SqlCommand(Strsql, SqlCnn)
        SqlCmd.CommandType = CommandType.Text
        Dr = SqlCmd.ExecuteReader
        While Dr.Read()
            BacklogNameComboBox.Items.Add(Dr("RcvrName"))
        End While
        Dr.Close()
        SqlCmd = Nothing
        SqlCnn.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub BacklogNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacklogNameComboBox.SelectedIndexChanged
        If BacklogNameComboBox.Text = "جديد" Then
            Dim NewRtnName As String = InputBox("أدخل اسم البند الجديد")
            If NewRtnName.Length = 0 Then Exit Sub
            Dim Strsql As String = "INSERT INTO  RecoverNames (RcvrNameID,RcvrName) VALUES(@p1,@p2)"
            Dim StrNewID As String = "Select Max(RcvrNameID)+1 from RecoverNames"
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
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click

        Try
            Me.Validate()
            Me.BacklogRecoverBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        'Panel3.Enabled = True
        Dim NewID As Integer
        If IsNothing(Me.BacklogRecoverTableAdapter.GetNewRCID) Then
            NewID = 1
        Else
            NewID = Me.BacklogRecoverTableAdapter.GetNewRCID
        End If
        Me.BacklogRecoverBindingSource.AddNew()
        Me.BacklogRCIDTextBox.Text = NewID
        Me.UserIDTextBox.Text = Cu_User.UserID
        Me.LastModifyTextBox.Text = Now.Date.ToString
        Me.CreateDateTextBox.Text = Now.Date.ToString
        Me.EmpIDTextBox.Text = Mymainfrm.EmpIDTextBox.Text
        Me.ControlIDTextBox.Text = ControlID
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        If MsgBox("هل تريد بالتأكيد حذف البند الحالي؟", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Me.BacklogRecoverBindingSource.RemoveCurrent()
            Try
                Me.Validate()
                Me.BacklogRecoverBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("تم إلغاء العملية")
        End If
    End Sub

    Private Sub IsRepeatedCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsRepeatedCheckBox.CheckedChanged
        Me.RepeatedMountsTextBox.Visible = IsRepeatedCheckBox.Checked
        Label2.Visible = IsRepeatedCheckBox.Checked
        Label4.Visible = IsRepeatedCheckBox.Checked
    End Sub
    Private Sub حذفالبندالمحددلجميعالعاملينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفالبندالمحددلجميعالعاملينToolStripMenuItem.Click
        Me.Panel3.Enabled = False
        If MsgBox("هل أنت متأكد من إلغاء بند الإسترداد المحدد من جميع العاملين", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            If BacklogReturnDataGridView.RowCount < 1 Then
                MsgBox("لا يوجد بند لحذفة")
                Exit Sub
            End If

            Dim cuName As String = BacklogReturnDataGridView.CurrentRow.Cells("BacklogNameDataGridViewTextBoxColumn").Value
            Try
                If SqlCnn.State = ConnectionState.Open Then SqlCnn.Close()
                SqlCnn.Open()
                SqlCmd = New SqlCommand("DELETE FROM [BacklogRecover] WHERE BacklogName=N'" & cuName & "'", SqlCnn)
                SqlCmd.ExecuteNonQuery()
                SqlCnn.Close()
                Me.BacklogRecoverTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogRecover)
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

    Private Sub حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حفظالقيمالمدخلةلجميعالعاملينToolStripMenuItem.Click
        Me.Panel3.Enabled = False
        If MsgBox("هل أنت متأكد من تطبيق قيمة بند الإسترداد على جميع العاملين", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            If BacklogNameComboBox.Text.Length = 0 Then
                MsgBox("يجب إختيار بند للمتابعة")
                BacklogNameComboBox.Focus()
                Exit Sub
            End If
            Dim Strproc, tot As String
            Dim Ispercent As Byte = 0
            If InStr(BacklogTotalTextBox1.Text, "%") > 0 Then
                Dim r As String = Trim(BacklogTotalTextBox1.Text)
                r = Strings.Replace(Trim(BacklogTotalTextBox1.Text), "%", "")
                If Not IsNumeric(r) Then Exit Sub
                tot = r
                Ispercent = 1
            Else
                tot = Trim(BacklogTotalTextBox1.Text)
                Ispercent = 0
            End If
            Try
                If SqlCnn.State = ConnectionState.Open Then SqlCnn.Close()
                SqlCnn.Open()
                SqlCmd = New SqlCommand(My.Settings.DropPatchRecover, SqlCnn)
                SqlCmd.ExecuteNonQuery()

                SqlCmd.CommandType = CommandType.Text
                SqlCmd.CommandText = My.Settings.CreatePatchRecover
                SqlCmd.ExecuteNonQuery()

                SqlCnn.Close()
                SqlCnn.Open()
                SqlCmd.CommandType = CommandType.Text
                Strproc = "EXECUTE  [SalaryLatDB].[dbo].[RecoverPatch]  N'" & BacklogNameComboBox.Text & "'," & tot & "," & IsRepeatedCheckBox.CheckState & "," & IIf(RepeatedMountsTextBox.Text = "", 0, RepeatedMountsTextBox.Text) & "," & 0 & ",N'" & IIf(NotesTextBox.Text = "", "-", NotesTextBox.Text) & "'," & Cu_User.UserID & "," & ControlID & "," & ReturnTaxCheckBox.CheckState & "," & Ispercent & ""
                SqlCmd.CommandText = Strproc
                SqlCmd.ExecuteNonQuery()
                SqlCnn.Close()
                'Me.BacklogRecoverBindingSource.RemoveCurrent()
                Me.BacklogRecoverTableAdapter.Fill(Me.BaniasEnergyDBDataSet.BacklogRecover)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim StrPer As String = InputBox("أدخل النسبة المؤوية الواجب استردادها من الراتب المقطوع", "نسبة عن الراتب المقطوع")
        If IsNumeric(StrPer) Then
            BacklogTotalTextBox1.Text = Math.Ceiling(Val(Mymainfrm.SlitSalaryTextBox.Text * StrPer / 100))
        Else
            MsgBox("الرجاء إدخال قيمة رقمية صالحة")
        End If
    End Sub

    Private Sub ReturnTaxCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnTaxCheckBox.CheckedChanged
        ReturnOnlyTaxCheckBox.Visible = ReturnTaxCheckBox.Checked
    End Sub

    Private Sub ReturnOnlyTaxCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ReturnOnlyTaxCheckBox.CheckedChanged

    End Sub
End Class