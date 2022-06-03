Public Class SettingFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.SetCalcOnOldslit = CheckBox1.Checked
        My.Settings.chechSalary = CheckBox2.Checked
        My.Settings.ExportReports = CheckBox3.Checked
        My.Settings.Save()
        Me.Close()
    End Sub
End Class