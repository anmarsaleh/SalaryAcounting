Public Class ResultCheckFrm

    Private Sub ResultCheckFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CheckSalaryDBDataSet.ResultCheck' table. You can move, or remove it, as needed.
        Me.ResultCheckTableAdapter.Fill(Me.CheckSalaryDBDataSet.ResultCheck)

    End Sub

    Private Sub ResultCheckDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ResultCheckDataGridView.CellClick
        Dim t As System.Type = ResultCheckDataGridView.CurrentCell.GetType
        If t.Name = "DataGridViewButtonCell" Then
            Dim dr As DataRowView = Me.ResultCheckBindingSource.Current
            Dim Cpos As Integer = Mymainfrm.SalaryRecordsBindingSource.Position
            Dim CEmpid As Integer = dr("empid")
            Cpos = Mymainfrm.SalaryRecordsBindingSource.Find("EmpID", CEmpid)
            Mymainfrm.SalaryRecordsBindingSource.Position = Cpos
        End If
    End Sub

    Private Sub ResultCheckFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Height = 70 + Me.ResultCheckBindingSource.Count * 26
        If Me.ResultCheckBindingSource.Count < 1 Then
            MsgBox("لم يتم الكشف عن أية أخطاء")
            Me.Close()
        End If
    End Sub
End Class