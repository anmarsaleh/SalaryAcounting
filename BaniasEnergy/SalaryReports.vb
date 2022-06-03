Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class SalaryReports
    Public cryRpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public CRTable As CrystalDecisions.CrystalReports.Engine.Table
    Public CRTLI As CrystalDecisions.Shared.TableLogOnInfo
    Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Pcn As String
    Private Sub SalaryReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Name = "RAMITTA" Then
            Pcn = "RAMITTA"
        ElseIf My.Computer.Name = "RAMITTA-PC" Then
            Pcn = "RAMITTA-PC"
        ElseIf My.Computer.Name = "GEMTQ-SERVER" Then
            Pcn = "GEMTQ-SERVER"
        End If
        'TODO: This line of code loads data into the 'ReportsDataSet.BianSalary' table. You can move, or remove it, as needed.
        ' Me.BianSalaryTableAdapter.Fill(Me.ReportsDataSet.BianSalary)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsTakeOut' table. You can move, or remove it, as needed.
        Me.DetialsTakeOutTableAdapter.Fill(Me.ReportsDataSet.DetialsTakeOut)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsRecover' table. You can move, or remove it, as needed.
        Me.DetialsRecoverTableAdapter.Fill(Me.ReportsDataSet.DetialsRecover)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsReturn' table. You can move, or remove it, as needed.
        Me.DetialsReturnTableAdapter.Fill(Me.ReportsDataSet.DetialsReturn)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Directorates' table. You can move, or remove it, as needed.
        Me.DirectoratesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Directorates)
        'TODO: This line of code loads data into the 'ReportsDataSet.SalaryReport' table. You can move, or remove it, as needed.
        Me.SalaryReportTableAdapter.Fill(Me.ReportsDataSet.SalaryReport)

        TextBox1.Hide()

        'logon1.ConnectionInfo.DatabaseName = "SalaryLatDB"
        'logon1.ConnectionInfo.ServerName = "WIN-O7R3FJDV768"
        'logon1.ConnectionInfo.UserID = "sa"
        'logon1.ConnectionInfo.Password = "latakiaport@2017"
        'logon1.ConnectionInfo.IntegratedSecurity = False
        Select Case TextBox1.Text
            Case "Button1"
                'Me.CrystalReportViewer1.LogOnInfo.Add(logon1)
                ' CrvCnn(EmpSalary1)
                EmpSalaryNew1.DataSourceConnections.Clear()
                If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    EmpSalaryNew1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                Else
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    EmpSalaryNew1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                End If
                Me.CrystalReportViewer1.ReportSource = EmpSalaryNew1
                Me.CrystalReportViewer1.Visible = True
                Me.CrystalReportViewer1.Dock = DockStyle.Fill
                Me.CrystalReportViewer1.RefreshReport()
            Case "Button2"
                'Me.CRVsalaryTable.LogOnInfo.Add(logon1)
                ' CrvCnn(SalaryTable1)
                SalaryTable1.DataSourceConnections.Clear()
                If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    SalaryTable1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                Else
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    SalaryTable1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                End If
                Me.CRVsalaryTable.Visible = True
                Me.CRVsalaryTable.Dock = DockStyle.Fill
                Me.CRVsalaryTable.RefreshReport()

            Case "Button3"
                Me.ReturnViewer.Dock = DockStyle.Fill
                Me.ReturnViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                Me.ReturnViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
                Me.ReturnViewer.ZoomPercent = 25
                ReturnViewer.Visible = True
                Me.DetialsReturnBindingSource.Filter = "EmpID='" & CuEmpID & "'"
                Me.ReturnViewer.RefreshReport()
            Case "Button4"
                'CRVrecoverBack.LogOnInfo.Add(logon1)
                'CrvCnn(RecoverBackRpt1)
                RecoverBackRpt1.DataSourceConnections.Clear()
                If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    RecoverBackRpt1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                Else
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    RecoverBackRpt1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                End If
                CRVrecoverBack.Visible = True
                CRVrecoverBack.Dock = DockStyle.Fill
                CRVrecoverBack.RefreshReport()
            Case "Button5"
                'CRVloans.LogOnInfo.Add(logon1)
                'CrvCnn(CrLoans1)
                CrLoans1.DataSourceConnections.Clear()
                If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    CrLoans1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                Else
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    CrLoans1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                End If
                CRVloans.Visible = True
                CRVloans.Dock = DockStyle.Fill
                Me.CRVloans.RefreshReport()
            Case "Button19"
                ' CrvCnn(DetailEmpSalary1)
                ' CRVdetailsalary.LogOnInfo.Add(logon1)
                '-----------------------------
                DetailEmpSalary2.DataSourceConnections.Clear()
                If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    DetailEmpSalary2.DataSourceConnections.Item(0).IntegratedSecurity = False
                    DetailEmpSalary2.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                    'DetailEmpSalary1.DataSourceConnections.Item(0).SetLogon("Fadia", "microsoft@1976")

                    DetailEmpSalary2.Subreports(0).DataSourceConnections.Item(0).IntegratedSecurity = False
                    DetailEmpSalary2.Subreports(0).DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                    'DetailEmpSalary1.Subreports(0).DataSourceConnections.Item(0).SetLogon("Fadia", "microsoft@1976")
                    DetailEmpSalary2.Subreports(1).DataSourceConnections.Item(0).IntegratedSecurity = False
                    DetailEmpSalary2.Subreports(1).DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                    'DetailEmpSalary1.Subreports(1).DataSourceConnections.Item(0).SetLogon("Fadia", "microsoft@1976")
                    DetailEmpSalary2.Subreports(2).DataSourceConnections.Item(0).IntegratedSecurity = False
                    DetailEmpSalary2.Subreports(2).DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
                    'DetailEmpSalary1.Subreports(2).DataSourceConnections.Item(0).SetLogon("Fadia", "microsoft@1976")

                Else
                    ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                    DetailEmpSalary2.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                    DetailEmpSalary2.Subreports(0).DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                    DetailEmpSalary2.Subreports(1).DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                    DetailEmpSalary2.Subreports(2).DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)



                End If
                'For i As Integer = 0 To DetailEmpSalary1.Subreports.Count - 1
                '    If My.Computer.Name = "RAMITTA" Then
                '        ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                '        DetailEmpSalary1.DataSourceConnections.Item(0).SetConnection(".\sqlexpress", "SalaryLatDB", "Fadia", "microsoft@1976")
                '    Else
                '        ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                '        DetailEmpSalary1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
                '    End If
                'Next
                '-----------------------------------
                'Me.DetailEmpSalary1.Database.Tables.ApplyLogOnInfo(logon1)
                'Me.DetailEmpSalary1.Database.Tables(1).ApplyLogOnInfo(logon1)
                'Me.DetailEmpSalary1.Database.Tables(2).ApplyLogOnInfo(logon1)
                Me.CRVdetailsalary.Visible = True
                Me.CRVdetailsalary.Dock = DockStyle.Fill
                Me.CRVdetailsalary.RefreshReport()
            Case "button22"

            Case "Button6"
                'نقابة المهندسين
                MyGlobalRpt("IsEngCooperation", "EngCooperation", "نقاية المهندسين")
            Case "Button7"
                'رسم نقابة مهندسين زراعيين
                MyGlobalRpt("IsEngFarm", "EngCooperation", "نقابة مهندسين زراعيين")
            Case "Button8"
                MyGlobalRpt("IsSocialInsurance", "SocialInsurance", "تأمينات إجتماعية")

            Case "Button13"
                'م35+10ن
                MyGlobalRpt("Qhelp", "Qhelp", "م35+10ن")
            Case "Button32"
                'إعانة مهندسين زراعيين
                MyGlobalRpt("retirefarmeng", "retirefarmeng", "إعانة .م.ز")
            Case "Button10"
                'نقابة عمال
                MyGlobalRpt("ISCooperationWorkers", "CooperationWorkers", "نقابة العمال")
            Case "Button11"
                'ضمان صحي
                MyGlobalRpt("EmpHelth", "EmpHelth", "ضمان صحي")
            Case "Button15"
                'طابع
                MyGlobalRpt("Typo", "Typo", "اشتراكات السكن")
            Case "Button14"
                'تكافل موحد
                MyGlobalRpt("IntegratorSolidarity", "IntegratorSolidarity", "تكافل موحد")
            Case "Button12"
                'مساعدة ونهاية خدمة
                MyGlobalRpt("IsAssistBox", "AssistBox", "م.نهاية خدمة")
            Case "Button9"
                'صندوق تعاون
                MyGlobalRpt("IsCooperateBox", "CooperateBox", "صندوق التعاون")
            Case "Button26"
                'تأمينات تقاعدية
                MyGlobalRpt("IsstipendInsurance", "stipendInsurance", "تأمينات تقاعدية")
            Case "Button17"
                'مصرف عقاري
                MyLoanRptProc("AkariBankDate", "AB_Total", "AB_Mounts", "AB_Discount", "المصرف عقاري")
            Case "Button31"
                'مصرف التسليف
                MyLoanRptProc("TasleefBankDate", "TB_Total", "TB_Mounts", "TB_Discount", "مصرف التسليف")
            Case "Button20"
                'مصرف التوفير
                MyLoanRptProc("TawfeerBankDate", "TWB_Total", "TWB_Mounts", "TWB_Discount", "مصرف التوفير")
            Case "Button18"
                'مصرف شعبي 
                MyLoanRptProc("WorkersLoanDate", "WL_Total", "WL_Mounts", "WL_Discount", "مصرف شعبي")
            Case "Button24"
                'تجزئة 
                MyLoanRptProc("TajzahLoanDate", "TL_Total", "TL_Mounts", "TL_Discount", " السورية للتجارة ")
            Case "Button21"
                ' سلفة راتب
                MyLoanRptProc("CooperationLoanDate", "CL_Total", "CL_Mounths", "CL_Discount", "سلفة راتب")
            Case "Button16"
                'ضم خدمة 
                MyLoanRptProc("HoldServiceDate", "HS_Total", "HS_Mounths", "HS_Discount", "ضم الخدمة")
            Case "Button27"
                'قسط نقابة المهندسين 
                MyLoanRptProc("EngCooperationTaxDate", "ECT_Total", "ECT_Mounts", "ECT_Discount", "رسم نقابة المهندسين", " and IsEngCooperation=1")
            Case "Button34"
                ' الزراعيينقسط نقابة المهندسين 
                MyLoanRptProc("EngCooperationTaxDate", "ECT_Total", "ECT_Mounts", "ECT_Discount", "رسم نقابة مهندسين زراعيين", " and IsEngFarm=1")
            Case "Button23"
                'تغريمات 
                MyLoanRptProc("Datepenalty", "P_Total", "P_Mounths", "P_Discount", "التغريمات")
            Case "Button28"
                ' استردادات
                MyLoanRptProc("RecoveryDate", "RC_Total", "RC_Mounts", "RC_Discount", "الإستردادات")
            Case "Button29"
                ' عقوبات
                MyLoanRptProc("RodDate", "R_Total", "R_Mounths", "R_Discount", "العقوبات")
            Case "Button30"
                ' محجوزات
                MyLoanRptProc("DiscountTaskDate", "DT_Total", "DT_Mounts", "DT_Discount", "المحجوزات")
        End Select

        Me.ReportViewerBian.RefreshReport()
    End Sub
    Private Sub MyLoanRptProc(ByRef L_Date As String, ByVal L_total As String, ByVal L_Month As String, ByVal L_Dis As String, ByVal rName As String, Optional eng As String = "")
        Dim strDropProc As String = "USE [SalaryLatDB] IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MyLoanProc]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[MyLoanProc]"
        Dim StrCreateProc As String = "CREATE PROCEDURE [dbo].[MyLoanProc]  AS BEGIN "
        StrCreateProc += " EXEC('SELECT      N''" & rName & "'' as r_Name, SalaryRecords.EmpID, SalaryRecords.FullName, " + L_Date + " as Ldate, " + L_total + " as Ltotal, " + L_Month + " as Lmonth, "
        StrCreateProc += L_Dis + " as Ldis, CenterNames.CenterName,SalaryMount,SalaryYear"
        StrCreateProc += " FROM         SalaryRecords INNER JOIN"
        StrCreateProc += "      CenterNames ON SalaryRecords.CenterID = CenterNames.CenterID "
        StrCreateProc += " where IsContract=0 and (" + L_Dis + ">0) " + eng + "') END"
        Dim cmd As New SqlCommand("", cnn)
        Try
            cnn.Open()
            cmd.CommandText = strDropProc
            cmd.ExecuteNonQuery()
            cmd.CommandText = Nothing
            cmd.CommandText = StrCreateProc
            cmd.ExecuteNonQuery()
            'CrvGlobalLoan.LogOnInfo.Add(logon1)
            'CrvCnn(GloabalLoans1)
            GloabalLoans1.DataSourceConnections.Clear()
            If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                GloabalLoans1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
            Else
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                GloabalLoans1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            End If
            CrvGlobalLoan.Visible = True
            CrvGlobalLoan.Dock = DockStyle.Fill
            CrvGlobalLoan.RefreshReport()
        Catch ex As SqlException
            MsgBox(ex.Message)
            cnn.Close()
        End Try
    End Sub
    Private Sub MyGlobalRpt(ByRef rP1 As String, ByRef rP2 As String, ByVal tname As String)

        Dim cmd As New SqlCommand("", cnn)
        Try
            cnn.Open()
            Dim str1 As String = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Myproc]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[Myproc]"
            cmd.CommandText = str1
            cmd.ExecuteNonQuery()
            Dim strsql As String = MyGlobalProc(rP1, rP2, tname)
            cmd.CommandText = strsql
            cmd.ExecuteNonQuery()
            cnn.Close()
            'CRVGlobal.LogOnInfo.Add(logon1)
            'CrvCnn(T_Engcooper1)
            T_Engcooper1.DataSourceConnections.Clear()
            If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                T_Engcooper1.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
            Else
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                T_Engcooper1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            End If
            CRVGlobal.Visible = True
            CRVGlobal.Dock = DockStyle.Fill
            CRVGlobal.RefreshReport()
        Catch ex As SqlException
            MsgBox(ex.Message)
            cnn.Close()
        End Try
    End Sub
    Private Function MyGlobalProc(ByVal p1 As String, ByVal p2 As String, ByVal stName As String) As String
        Dim r As String = "CREATE PROCEDURE [dbo].[Myproc] AS"
        r = r + " BEGIN "
        'r = r + " EXEC(' SELECT SalaryRecords.EmpID, Directorates.DirectorateName, SalaryRecords.FullName, " & p1 & " as tot1," & p2 & " as tot,SalaryMount,SalaryYear,''" & stName & "'' as t_Name FROM   SalaryRecords INNER JOIN Directorates ON SalaryRecords.DirectorateID = Directorates.DirectorateID where (" & p1 & "=1)')  END"
        r = r + " EXEC(' SELECT SalaryRecords.EmpID, CenterNames.CenterName, SalaryRecords.FullName, " & p1 & " as tot1," & p2 & " as tot,SalaryMount,SalaryYear,N''" & stName & "'' as t_Name FROM   SalaryRecords INNER JOIN CenterNames ON SalaryRecords.CenterID = CenterNames.CenterID where (" & p2 & " >0 and " & p1 & ">=1)')  END"
        Return r
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Eid As String = TextBox2.Text
        If Eid = "" Then Eid = 0
        Select Case TextBox1.Text
            Case "Button22"
                If IsNumeric(TextBox2.Text) Then
                    Me.BianSalaryTableAdapter.Fill(ReportsDataSet.BianSalary, TextBox2.Text)
                    ReportViewerBian.Dock = DockStyle.Fill
                    ReportViewerBian.Visible = True
                    ReportViewerBian.RefreshReport()
                End If

            Case "Button2"
                Me.SalaryReportBindingSource.Filter = "DirectorateName='" & ComboBox1.Text & "'"
                Me.TableSViewer.RefreshReport()
            Case "Button3"
                Me.DetialsReturnBindingSource.Filter = "EmpID='" & Eid & "'"
                Me.ReturnViewer.RefreshReport()
            Case "Button4"
                Me.DetialsRecoverBindingSource.Filter = "EmpID='" & Eid & "'"
                Me.RecoverViewer.RefreshReport()
            Case "Button5"

        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub CrvCnn(ByVal obj As Object)
        obj.DataSourceConnections.Clear()
        For i As Integer = 0 To obj.Subreports.Count - 1
            If My.Computer.Name = "RAMITTA" Or My.Computer.Name = "RAMITTA-PC" Then
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                obj.DataSourceConnections.Item(0).SetConnection(Pcn.ToString, "SalaryLatDB", "Fadia", "microsoft@1976")
            Else
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                obj.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            End If
        Next
        End
    End Sub
End Class