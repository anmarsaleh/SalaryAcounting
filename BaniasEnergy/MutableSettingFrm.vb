Public Class MutableSettingFrm

    Private Sub MutableSettingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MutableSettingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)

    End Sub

    Private Sub MutableSettingFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SetupSalaryDataSet.MutableSetting' table. You can move, or remove it, as needed.
        Me.MutableSettingTableAdapter.Fill(Me.SetupSalaryDataSet.MutableSetting)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.MutableSettingBindingSource.Count > 5 Then
            Me.MutableSettingDataGridView.Refresh()
            Exit Sub
        End If
        Me.Validate()
        Me.MutableSettingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)
    End Sub
End Class