Public Class TransRepQhelpCoop

    Private Sub TransRepQhelpCoop_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' CrystalReportViewer1.LogOnInfo.Add(logon1)
        TransQhelpCoop1.DataSourceConnections.Clear()
        If My.Computer.Name = "RAMITTA-PC" Then
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransQhelpCoop1.DataSourceConnections.Item(0).SetConnection("RAMITTA-PC", "SalaryLatDB", "Fadia", "microsoft@1976")
        Else
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransQhelpCoop1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        End If
        Me.CrystalReportViewer1.RefreshReport()
    End Sub
End Class