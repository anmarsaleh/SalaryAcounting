Imports System.Data
Imports System.Data.SqlClient
Public Class TakeOutsFrm
    Dim Sqlcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim SqlCmd As SqlCommand
    Dim Dr As SqlDataReader
    Dim IsSaveOk As Boolean = False
    Dim IsAdd As Boolean = False
    Private Sub TakeOutsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.TakeOuts' table. You can move, or remove it, as needed.
        Me.TakeOutsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.TakeOuts)
        EmpIDTextBox.Hide()
        TakeoutIDTextBox.Hide()
        CreateDateTextBox.Hide()
        LastModifyTextBox.Hide()
        UserIDTextBox.Hide()
        IsCloseCheckBox.Hide()
        ControlIDTextBox.Hide()
        ChkInf()
        Me.TakeOutsBindingSource.Filter = "EmpID=" & Mymainfrm.EmpIDTextBox.Text & " AND IsClose=0"
        If TakeOutsBindingSource.Count < 1 Then
            GroupBox2.Enabled = False
        End If
        If TakeOutsBindingSource.Count > 0 Then
            Me.TakeoutNameComboBox.Enabled = False
        End If
        ' GroupBox2.Enabled = False
    End Sub
    Private Sub ChkInf()
        TakeoutNameComboBox.Items.Clear()
        TakeoutNameComboBox.Items.Add("جديد")
        Dim Strsql As String = "Select * from TakeOutNames"
        SqlCnn.Open()
        SqlCmd = New SqlCommand(Strsql, SqlCnn)
        SqlCmd.CommandType = CommandType.Text
        Dr = SqlCmd.ExecuteReader
        While Dr.Read()
            TakeoutNameComboBox.Items.Add(Dr("TackOutName"))
        End While
        Dr.Close()
        SqlCmd = Nothing
        SqlCnn.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        'If CheckBox1.CheckState = CheckState.Unchecked Then
        '    CheckTakeOuts()
        '    If Not IsSaveOk Then Exit Sub
        'End If
        CheckTakeOuts()
        If IsAdd Then
            Me.TakeoutRemainingTextBox.Text = TakeoutTotalTextBox.Text
        End If
        If Not IsSaveOk Then Exit Sub
        Try
            Me.Validate()
            Me.TakeOutsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        IsAdd = False
    End Sub
    Private Sub CheckTakeOuts()
        If TakeoutNameComboBox.Text.Length > 0 Then
            If TakeoutDateTextBox.TextLength > 0 AndAlso IsDate(TakeoutDateTextBox.Text) Then
                If TakeoutTotalTextBox.Text > 0 AndAlso TakeoutDiscountTextBox.Text > 0 Then
                    'TakeoutDiscountTextBox.Text = CInt((CInt(TakeoutTotalTextBox.Text) / CInt(TakeoutMountsTextBox.Text)))
                    'RemainingEndateTextBox.Text = DateAdd(DateInterval.Month, CInt(TakeoutMountsTextBox.Text), CDate(TakeoutDateTextBox.Text))
                    'Dim s As Integer = CInt((CInt(TakeoutTotalTextBox.Text) / CInt(TakeoutMountsTextBox.Text)))
                    'Dim d As Integer = s * CInt(TakeoutMountsTextBox.Text)
                    'Dim r As Integer = CInt(TakeoutTotalTextBox.Text) - d
                    'NotesTextBox.Text = "قيمة آخر قسط:" & " " & (r + CInt(TakeoutDiscountTextBox.Text)).ToString
                    IsSaveOk = True
                    Return
                Else
                    MsgBox("يجب أن تكون قيمة حقل المبلغ الإجمالي والقسط الشهري أكبر من الصفر")
                    IsSaveOk = False
                    Return
                End If
            Else
                MsgBox(" الرجاء التأكد من تاريخ السلفة")
                TakeoutDateTextBox.Focus()
                TakeoutDateTextBox.SelectAll()
                IsSaveOk = False
                Return
            End If
        Else
            MsgBox("يجب إختيار اسم البند")
            TakeoutNameComboBox.Focus()
            TakeoutNameComboBox.SelectAll()
            IsSaveOk = False
            Return
        End If
    End Sub
    Private Sub TakeoutNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeoutNameComboBox.SelectedIndexChanged
        If TakeoutNameComboBox.Text = "جديد" Then
            Dim NewRtnName As String = InputBox("أدخل اسم البند الجديد")
            If NewRtnName.Length = 0 Then Exit Sub
            Dim Strsql As String = "INSERT INTO  TakeOutNames (TakeID,TackOutName) VALUES(@p1,@p2)"
            Dim StrNewID As String = "Select Max(TakeID)+1 from TakeOutNames"
            Sqlcnn.Open()
            SqlCmd = New SqlCommand(StrNewID, Sqlcnn)
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
            Sqlcnn.Close()
            ChkInf()
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        IsAdd = True
        GroupBox2.Enabled = True
        Me.TakeoutNameComboBox.Enabled = True
        Dim NewID As Integer
        If IsNothing(Me.TakeOutsTableAdapter.GetNewTakeID) Then
            NewID = 1
        Else
            NewID = Me.TakeOutsTableAdapter.GetNewTakeID
        End If
        Me.TakeOutsBindingSource.AddNew()
        Me.TakeoutIDTextBox.Text = NewID
        Me.UserIDTextBox.Text = Cu_User.UserID
        Me.LastModifyTextBox.Text = Now.Date.ToString
        Me.CreateDateTextBox.Text = Now.Date.ToString
        Me.EmpIDTextBox.Text = Mymainfrm.EmpIDTextBox.Text
        Me.IsCloseCheckBox.CheckState = CheckState.Unchecked
        Me.ControlIDTextBox.Text = ControlID
        ' Me.IsCloseCheckBox.Checked = False
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        If MsgBox("هل تريد بالتأكيد حذف البند الحالي؟", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Me.TakeOutsBindingSource.RemoveCurrent()
            Try
                Me.Validate()
                Me.TakeOutsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)
                Me.TakeoutNameComboBox.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("تم إلغاء العملية")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TakeoutDiscountTextBox.ReadOnly = False
            TakeoutRemainingTextBox.ReadOnly = False
            RemainingEndateTextBox.ReadOnly = False
        Else
            TakeoutDiscountTextBox.ReadOnly = True
            TakeoutRemainingTextBox.ReadOnly = True
            RemainingEndateTextBox.ReadOnly = True
        End If
    End Sub
End Class