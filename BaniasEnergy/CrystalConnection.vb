Imports System
Imports System.Configuration
Public Class CrystalConnection

    Private Sub CrystalConnection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TxtServerName.Text = My.Settings.CRVservername
        TxtDataName.Text = My.Settings.CRVDBname
        TxtUserId.Text = My.Settings.CRVuserid
        TxtPassWord.Text = My.Settings.CRVpw
        CheckBox1.Checked = My.Settings.CRVisecurity
        If CheckBox1.CheckState = CheckState.Checked Then
            TxtUserId.Enabled = False
            TxtPassWord.Enabled = False
        Else
            TxtUserId.Enabled = True
            TxtPassWord.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.CRVservername = TxtServerName.Text
        My.Settings.CRVDBname = TxtDataName.Text
        My.Settings.CRVuserid = TxtUserId.Text
        My.Settings.CRVpw = TxtPassWord.Text
        My.Settings.CRVisecurity = CheckBox1.Checked
        My.Settings.Save()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TxtUserId.Enabled = False
            TxtPassWord.Enabled = False
        Else
            TxtUserId.Enabled = True
            TxtPassWord.Enabled = True
        End If
    End Sub
End Class