Public Class MarkDriveFrm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MarkDriveBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MarkDriveBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MarkDriveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DriveDataSet)

    End Sub

    Private Sub MarkDriveFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DriveDataSet.MarkDrive' table. You can move, or remove it, as needed.
        Me.MarkDriveTableAdapter.Fill(Me.DriveDataSet.MarkDrive)

    End Sub
End Class