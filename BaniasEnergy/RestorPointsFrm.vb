Imports System.Data.SqlClient
Imports System.Data
Public Class RestorPointsFrm

    Private Sub RestorPointsFrm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub RestorPointsFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SetupSalaryDataSet.RestorePoints' table. You can move, or remove it, as needed.
        Me.RestorePointsTableAdapter.Fill(Me.SetupSalaryDataSet.RestorePoints)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("سيقوم البرنامج بانشاء نسخة ادخال بيانات جديدة", "RAMITTA", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            RestorePoints(0, 0)
            Me.RestorePointsTableAdapter.Fill(Me.SetupSalaryDataSet.RestorePoints)
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Msid As Integer
        Msid = ComboBox1.SelectedValue
        If MessageBox.Show("سيقوم البرنامج باستعادة نقطة البيانات المحددة هل تريد المتابعة", "RAMITTA", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            RestorePoints(1, Msid)
            MsgBox("يجب اعادة تشغيل البرنامج")
            Application.Restart()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim val As String
        Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim cmd As New SqlCommand("", cnn)
        Try
            cnn.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from RestorePoints where H_Date=N'" & ComboBox1.Text & "'"
            cmd.ExecuteNonQuery()
            cnn.Close()
            Me.RestorePointsTableAdapter.Fill(Me.SetupSalaryDataSet.RestorePoints)
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.Message)

        End Try
    End Sub
End Class