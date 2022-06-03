Public Class DriveException

    Private Sub DriveExceptionBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles DriveExceptionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DriveExceptionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub

    Private Sub DriveException_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.DriveException' table. You can move, or remove it, as needed.
        Me.DriveExceptionTableAdapter.Fill(Me.BaniasEnergyDBDataSet.DriveException)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.DriveExceptionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaniasEnergyDBDataSet)

    End Sub
End Class