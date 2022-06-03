Public Class CheckSalaryFrm

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckSalaryFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CheckSalaryDBDataSet.CheckSalary' table. You can move, or remove it, as needed.
        Me.CheckSalaryTableAdapter1.Fill(Me.CheckSalaryDBDataSet.CheckSalary)
        Me.ChkSalaryTextBox.Hide()
        Me.ControlIDTextBox.Hide()
        If Me.CheckSalaryBindingSource.Count = 0 Then
            Me.CheckSalaryBindingSource.AddNew()
            Me.ChkSalaryTextBox.Text = 1
            Me.ControlIDTextBox.Text = ControlID
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.CheckSalaryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CheckSalaryDBDataSet)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For Each Ctrl As Control In Me.Panel3.Controls
            If TypeOf Ctrl Is TextBox Then
                If Ctrl.Name = "ChkSalaryTextBox" Or Ctrl.Name = "ControlIDTextBox" Then

                Else
                    Ctrl.Text = 0
                End If
            End If
        Next
        Button1.PerformClick
    End Sub
End Class