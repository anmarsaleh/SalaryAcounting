Public Class OfficersFrm

    Private Sub OfficesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OfficesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub

    Private Sub OfficersFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Offices' table. You can move, or remove it, as needed.
        Me.OfficesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Offices)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class