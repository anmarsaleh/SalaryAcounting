Public Class CenterNamesFrm

    Private Sub CenterNamesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterNamesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CenterNamesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub

    Private Sub CenterNamesFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.CenterNames' table. You can move, or remove it, as needed.
        Me.CenterNamesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.CenterNames)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class