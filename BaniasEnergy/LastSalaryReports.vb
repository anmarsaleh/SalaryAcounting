Imports System.Data
Imports System.Data.SqlClient
Public Class LastSalaryReports
    Dim Lcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Lcmd As SqlCommand
    Dim LstrSql, Lcond As String
    Dim E1, M1, Y1 As String
    Dim Pcn As String
    Private Sub LastSalaryReports_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Computer.Name = "RAMITTA" Then
            Pcn = ".\sqlexpress"
        ElseIf My.Computer.Name = "RAMITTA-PC" Then
            Pcn = "RAMITTA-PC"
        End If
        'LastSalary1.DataSourceConnections.Clear()
        'If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
        '    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
        '    LastSalary1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
        'Else
        '    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
        '    LastSalary1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        'End If
        'CrystalReportViewer1.Dock = DockStyle.Fill
        'CrystalReportViewer1.RefreshReport()
    End Sub
    Private Sub BuildCnn()
        If CheckBox1.CheckState = CheckState.Checked Then
            LastDetailSalary1.DataSourceConnections.Clear()
            If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                LastDetailSalary1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                LastDetailSalary1.Refresh()
                LastDetailSalary1.Subreports(0).DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                LastDetailSalary1.Subreports(1).DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                LastDetailSalary1.Subreports(2).DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                LastDetailSalary1.Refresh()
            Else
                LastDetailSalary1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                LastDetailSalary1.Refresh()
                LastDetailSalary1.Subreports(0).DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                LastDetailSalary1.Subreports(1).DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                LastDetailSalary1.Subreports(2).DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                LastDetailSalary1.Refresh()
            End If
        Else
            LastSalary1.DataSourceConnections.Clear()
            If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                LastSalary1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
            Else
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                LastSalary1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            End If
        End If
        LastDetailSalary1.Refresh()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'If CheckBox1.CheckState = CheckState.Checked Then
        '    'CrystalReportViewer2.LogOnInfo.Add(logon1)
        '    CrystalReportViewer1.Visible = False
        '    CrystalReportViewer2.Visible = True
        '    CrystalReportViewer2.Dock = DockStyle.Fill
        '    CrystalReportViewer2.RefreshReport()
        'Else
        '    ' CrystalReportViewer1.LogOnInfo.Add(logon1)
        '    CrystalReportViewer1.Visible = True
        '    CrystalReportViewer2.Visible = False
        '    CrystalReportViewer1.Dock = DockStyle.Fill
        '    CrystalReportViewer1.RefreshReport()
        'End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        BuildCnn()
        If CheckBox1.CheckState = CheckState.Checked Then
            BuildLsal()
            CrystalReportViewer1.Visible = False
            CrystalReportViewer2.Visible = True
            CrystalReportViewer2.Dock = DockStyle.Fill
            CrystalReportViewer2.RefreshReport()
        Else
            BuildLsal()
            CrystalReportViewer1.Visible = True
            CrystalReportViewer2.Visible = False
            CrystalReportViewer1.Dock = DockStyle.Fill
            CrystalReportViewer1.RefreshReport()
        End If
    End Sub
    Private Sub BuildLsal()
        Try
            Lcnn.Open()
            LstrSql = " IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[L_Sal]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[L_Sal]    "
            Lcmd = New SqlCommand(LstrSql, Lcnn)
            Lcmd.ExecuteNonQuery()

            LstrSql = ""
            LstrSql += " CREATE PROCEDURE [dbo].[L_Sal] AS BEGIN  "
            LstrSql += " SELECT        LastSalareis.*, CenterNames.CenterName,(SalaryMount+'_'+SalaryYear) as SalDate"
            LstrSql += " FROM            LastSalareis INNER JOIN "
            LstrSql += "          CenterNames ON LastSalareis.CenterID = CenterNames.CenterID  where  "
            If ComboBox1.Text = "جميع السجلات" Then
                E1 = " 1=1 "
            Else
                E1 = " empid=" & ComboBox1.Text & " "
            End If
            If ComboBox2.Text = "الكل" Then
                M1 = ""
            Else
                M1 = " and SalaryMount=" & ComboBox2.Text & " "
            End If
            If IsNumeric(TextBox1.Text) And TextBox1.Text.Length = 4 Then
                Y1 = " and SalaryYear=" & TextBox1.Text & " "
            Else
                MsgBox("يرجى ادخال العام المالي بشكل صحيح")
                Exit Sub
            End If
            Lcond = E1 + " " + M1 + " " + Y1
            LstrSql += " " + Lcond + " END "
            Lcmd = New SqlCommand(LstrSql, Lcnn)
            Lcmd.ExecuteNonQuery()
            Lcnn.Close()
        Catch ex As Exception
            Lcnn.Close()
            MsgBox("فشل في عرض التقرير")
        End Try
    End Sub
    Private Sub BuildLDsal()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class