Public Class SpecializAetting

    Private Sub SpecializeValuesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SpecializeValuesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)

    End Sub

    Private Sub SpecializAetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SetupSalaryDataSet.TypeSpecializeValues' table. You can move, or remove it, as needed.
        Me.TypeSpecializeValuesTableAdapter.Fill(Me.SetupSalaryDataSet.TypeSpecializeValues)
        'TODO: This line of code loads data into the 'SetupSalaryDataSet.SpecializeValues' table. You can move, or remove it, as needed.
        Me.SpecializeValuesTableAdapter.Fill(Me.SetupSalaryDataSet.SpecializeValues)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.SpecializeValuesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.TypeSpecializeValuesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SpecializeValuesDataGridView_CellMouseMove(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SpecializeValuesDataGridView.CellMouseMove
       

    End Sub
End Class