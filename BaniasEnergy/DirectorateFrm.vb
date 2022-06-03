Public Class DirectorateFrm

    Private Sub DirectoratesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectoratesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DirectoratesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub

    Private Sub DirectorateFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Directorates' table. You can move, or remove it, as needed.
        Me.DirectoratesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Directorates)


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()

    End Sub
End Class