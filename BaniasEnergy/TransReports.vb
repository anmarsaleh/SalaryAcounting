Imports System.Data
Imports System.Data.SqlClient
Public Class TransReports
    Dim SqlCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim mCmd As New SqlCommand("", SqlCnn)
    Dim mSqlReader As SqlDataReader
    Dim t1, t2, t3, t4 As String
    Dim SalM, SalY As Integer
    Private Sub TransReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ISoldRecords.Hide()
        If ISoldRecords.CheckState = CheckState.Checked Then
            Me.GroupBox1.Visible = False
            Me.GroupBox2.Visible = True
        Else
            Me.GroupBox1.Visible = True
            Me.GroupBox2.Visible = False
        End If
        'TODO: This line of code loads data into the 'ReportsDataSet.FieldTrans' table. You can move, or remove it, as needed.
        Me.FieldTransTableAdapter.Fill(Me.ReportsDataSet.FieldTrans)
        Try
            SqlCnn.Open()
            mCmd.CommandType = CommandType.Text
            mCmd.CommandText = "select TackOutName from TakeOutNames"
            mSqlReader = mCmd.ExecuteReader()
            While mSqlReader.Read
                ListBox4.Items.Add(mSqlReader("TackOutName"))
            End While
            mSqlReader.Close()
            '-----
            mCmd.CommandText = "select RtnName from ReturnNames"
            mSqlReader = mCmd.ExecuteReader()
            While mSqlReader.Read
                ListBox2.Items.Add(mSqlReader("RtnName"))
            End While
            mSqlReader.Close()
            '-----
            mCmd.CommandText = "select RcvrName from RecoverNames"
            mSqlReader = mCmd.ExecuteReader()
            While mSqlReader.Read
                ListBox3.Items.Add(mSqlReader("RcvrName"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlCnn.Close()
        mCmd.Dispose()
        mSqlReader.Close()
        'mSqlReader("FldEn")
    End Sub
    Private Sub MyTransReport(ByRef FldArn As String, ByRef joinstr As String, ByRef FldName As String, ByRef cond As String, Optional ByVal TblNameL As String = "SalaryRecords", Optional ByVal Lcon As String = " ")
        Dim TblOldN As String
        Dim SqlOld As String
        Dim worker As String = "Isworkers=1 and"
        SqlOld = " Sr.SalaryMount=" + SalM.ToString + " and Sr.SalaryYear=" + SalY.ToString + " and "
        If ISoldRecords.CheckState = CheckState.Checked Then
            TblOldN = "LastSalareis"
            TblNameL = TblOldN
            Lcon = SqlOld
        Else
            TblOldN = "SalaryRecords"
            TblNameL = TblOldN
            'Lcon = IIf(Cu_User.AllowWorkers, worker, "")
        End If
        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t3 = TextBox3.Text
        t4 = TextBox8.Text
        Dim dropStr As String = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MyTransRep]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[MyTransRep]"
        Dim str As String = " CREATE PROCEDURE [dbo].[MyTransRep] AS"
        str = str + " BEGIN "
        str = str + "EXEC('SELECT N''" & t3 & "'' as t3,N''" & t2 & "'' as t2,N''" & t1 & "'' as t1,N''" & FldArn & "'' as FName, Sr.EmpID, Sr.FullName,Sr.IsEngCooperation,Sr.IsEngFarm,Sr.retirefarmeng,Sr.SalaryMount,Sr.SalaryYear, Cn.CenterName, (" & FldName & ") as Flden"
        str = str + " FROM   CenterNames Cn INNER JOIN " + TblNameL + " Sr ON Cn.CenterID = Sr.CenterID  " & joinstr & " Where  " + Lcon + " " & cond & ""
        str = str + " ') end"
        Try
            SqlCnn.Open()
            mCmd.CommandText = dropStr
            mCmd.ExecuteNonQuery()
            '-------
            mCmd.CommandText = str
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlCnn.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim Tfldcond As String = ListBox4.Text
        Dim r As String = " INNER JOIN TakeOuts ON Sr.EmpID = TakeOuts.EmpID"
        Dim Flds1, Flds2 As String
        If ListBox4.SelectedIndices.Count > 1 Then
            Flds1 = ListBox4.SelectedItems(0).ToString
            Flds2 = ListBox4.SelectedItems(1).ToString
            MyTransReport(Tfldcond, r, "TakeOuts.TakeoutDiscount", " TakeOuts.TakeoutDiscount>0 and TakeOuts.TakeoutName=N''" & Flds1 & "'' or TakeOuts.TakeoutName=N''" & Flds2 & "''")
        Else
            MyTransReport(Tfldcond, r, "TakeOuts.TakeoutDiscount", " TakeOuts.TakeoutDiscount>0 and TakeOuts.TakeoutName=N''" & Tfldcond & "''")
        End If
        TransRpt1.DataSourceConnections.Clear()
        If My.Computer.Name = "RAMITTA-PC" Then
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection("RAMITTA-PC", "SalaryLatDB", "Fadia", "microsoft@1976")
            transRptM1.DataSourceConnections.Item(0).SetConnection("RAMITTA-PC", "SalaryLatDB", "Fadia", "microsoft@1976")
        Else
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            transRptM1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        End If
        If CheckBox3.CheckState = CheckState.Checked Then
            Me.CrystalReportViewer1.ReportSource = TransRpt1
        Else
            Me.CrystalReportViewer1.ReportSource = transRptM1
        End If

        Me.CrystalReportViewer1.Visible = True
        Me.CrystalReportViewer1.Dock = DockStyle.Fill
        Me.CrystalReportViewer1.RefreshReport()
        Button6.Text = "رجوع"
       
    End Sub
    'Private Sub MyEngFarmRep(ByRef p1, ByRef p2, ByRef p3)
    '    Dim strsql, StrDel As String
    '    StrDel = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EngFarmReports]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].EngFarmReports"
    '    strsql = "CREATE PROCEDURE dbo.EngFarmReports @p1 real=4 ,@p2 real=2.5 ,@p3 real=2.5 "
    '    strsql = strsql + " AS	BEGIN	select empid,fullname, SlitSalary, EngCooperation,retirefarmeng "
    '    strsql = strsql + " ,(SlitSalary*@p1)/100 as eng1, ((SlitSalary*@p2)/100) as eng2,((SlitSalary*@p2)/100)+retirefarmeng as eng3 "
    '    strsql = strsql + " from SalaryRecords where IsEngFarm=1 END"
    '    Try
    '        SqlCnn.Open()
    '        mCmd.CommandText = StrDel
    '        mCmd.ExecuteNonQuery()
    '        mCmd.CommandText = ""
    '        mCmd.CommandText = strsql
    '        mCmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    SqlCnn.Close()
    'End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'SalaryRecords.IsEngCooperation,SalaryRecords.IsEngFarm
        Dim selValue As String
        selValue = ListBox1.SelectedValue
        If selValue = "EngCooperation" and CheckBox1.CheckState=CheckState.Checked Then
            'MyTransReport(ListBox1.Text, "", ListBox1.SelectedValue, " where " & ListBox1.SelectedValue & " >0 and IsEngFarm=1")
            Dim EngF As New EngFamrReports
            EngF.ShowDialog()
            Exit Sub
        ElseIf selValue = "EngCooperation" And CheckBox1.CheckState = CheckState.Unchecked Then
            MyTransReport(ListBox1.Text, "", ListBox1.SelectedValue, " " & ListBox1.SelectedValue & " >0 and IsEngCooperation=1")
        ElseIf selValue = "Qhelp1" And CheckBox2.CheckState = CheckState.Checked Then
            QhelpAcoop("Qhelp1", "مساعدة فورية")
            Dim f As New TransRepQhelpCoop
            f.Show()
            Exit Sub
        ElseIf selValue = "Qhelp2" And CheckBox2.CheckState = CheckState.Checked Then
            QhelpAcoop("Qhelp2", "أمانات وتبرعات")
            Dim f As New TransRepQhelpCoop
            f.Show()
            Exit Sub
        ElseIf selValue = "CooperationWorkers" And CheckBox2.CheckState = CheckState.Checked Then
            QhelpAcoop("CooperationWorkers", "نقابة عمال")
            Dim f As New TransRepQhelpCoop
            f.Show()
            Exit Sub
        Else
            MyTransReport(ListBox1.Text, "", ListBox1.SelectedValue, "  " & ListBox1.SelectedValue & " >0")
        End If
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        'CrystalReportViewer1.LogOnInfo.Add(logon1)
        TransRpt1.DataSourceConnections.Clear()
        transRptM1.DataSourceConnections.Clear()
        If My.Computer.Name = "RAMITTA-PC" Then
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
            transRptM1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
        Else
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            transRptM1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        End If
        If CheckBox3.CheckState = CheckState.Checked Then
            Me.CrystalReportViewer1.ReportSource = TransRpt1
        Else
            Me.CrystalReportViewer1.ReportSource = transRptM1
        End If
        Me.CrystalReportViewer1.Visible = True
        Me.CrystalReportViewer1.Dock = DockStyle.Fill
        Me.CrystalReportViewer1.RefreshReport()
        Button6.Text = "رجوع"
    End Sub
    Private Function QhelpAcoop(ByVal Fld As String, t As String) As String
        Dim r As String = ""
        Dim del As String
        del = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QhelpCoop]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[QhelpCoop]"
        r = "CREATE PROCEDURE [dbo].QhelpCoop AS  BEGIN EXEC(' "
        r = r + " SELECT   N''" + t + "'' as fname,cn.CenterName, Isnull(ag0.q0,0) as Q0, Isnull(ag1.q1,0) as Q1,cn.CenterID FROM  CenterNames AS cn left outer JOIN"
        r = r + " (SELECT  SUM(" + Fld + ") AS q0, CenterID FROM  SalaryRecords  WHERE (agentEmp = 0) GROUP BY CenterID) AS ag0 ON cn.CenterID = ag0.CenterID left outer JOIN"
        r = r + " (SELECT        SUM(" + Fld + ") AS q1, CenterID FROM  SalaryRecords WHERE (agentEmp = 1) GROUP BY CenterID) AS ag1 ON cn.CenterID = ag1.CenterID"
        r = r + " GROUP BY cn.CenterName, ag0.q0, ag1.q1,cn.CenterID ') end"
        Try
            SqlCnn.Open()
            mCmd.CommandText = del
            mCmd.ExecuteNonQuery()
            mCmd.CommandText = r
            mCmd.ExecuteNonQuery()
            SqlCnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            SqlCnn.Close()
        End Try
        Return r
    End Function
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Tfldcond = ListBox2.Text
        Dim r As String = " INNER JOIN BacklogReturn ON Sr.EmpID = BacklogReturn.EmpID"
        MyTransReport(Tfldcond, r, "BacklogReturn.BacklogTotal", "  BacklogReturn.BacklogName=N''" & Tfldcond & "''")
        'CrystalReportViewer1.LogOnInfo.Add(logon1)
        TransRpt1.DataSourceConnections.Clear()
        transRptM1.DataSourceConnections.Clear()
        If My.Computer.Name = "RAMITTA-PC" Then
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
            transRptM1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
        Else
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            transRptM1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        End If
        If CheckBox3.CheckState = CheckState.Checked Then
            Me.CrystalReportViewer1.ReportSource = TransRpt1
        Else
            Me.CrystalReportViewer1.ReportSource = transRptM1
        End If
        Me.CrystalReportViewer1.Visible = True
        Me.CrystalReportViewer1.Dock = DockStyle.Fill
        Me.CrystalReportViewer1.RefreshReport()
        Button6.Text = "رجوع"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim Tfldcond = ListBox3.Text
        Dim r As String = " INNER JOIN BacklogRecover ON Sr.EmpID = BacklogRecover.EmpID"
        MyTransReport(Tfldcond, r, "BacklogRecover.BacklogTotal", "  BacklogRecover.BacklogName=N''" & Tfldcond & "''")
        'CrystalReportViewer1.LogOnInfo.Add(logon1)
        TransRpt1.DataSourceConnections.Clear()
        transRptM1.DataSourceConnections.Clear()
        If My.Computer.Name = "RAMITTA-PC" Then
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
            transRptM1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
        Else
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransRpt1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            transRptM1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        End If
        If CheckBox3.CheckState = CheckState.Checked Then
            Me.CrystalReportViewer1.ReportSource = TransRpt1
        Else
            Me.CrystalReportViewer1.ReportSource = transRptM1
        End If
        Me.CrystalReportViewer1.Visible = True
        Me.CrystalReportViewer1.Dock = DockStyle.Fill
        Me.CrystalReportViewer1.RefreshReport()
        Button6.Text = "رجوع"
    End Sub
    Private Sub MyMergProc()
        Dim a1, a2 As String
        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t3 = TextBox3.Text
        t4 = TextBox8.Text
        a1 = ListBox1.SelectedValue
        a2 = ListBox4.Text
        Dim dropstr As String = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mymergeflds]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[Mymergeflds]"
        Dim strSql As String
        strSql = "CREATE PROCEDURE [dbo].Mymergeflds AS  BEGIN EXEC('"
        strSql = strSql + "SELECT f1, N''" & t4 & "'' as t4,N''" & t3 & "'' as t3,N''" & t2 & "'' as t2,N''" & t1 & "'' as t1,    COALESCE( sr.FullName,tk.fullname) as Fname,COALESCE( sr.EmpID,tk.EmpID) as empids"
        strSql = strSql + ",COALESCE(sr.f1,tk.f2) as FldName FROM"
        strSql = strSql + "  (SELECT        EmpID, FullName, " + a1 + " as f1 FROM   SalaryRecords    WHERE    (" + a1 + " >0)) AS sr "
        strSql = strSql + " full outer JOIN"
        strSql = strSql + " (SELECT        TakeOuts.EmpID, TakeOuts.TakeoutDiscount as f2,  SalaryRecords.FullName FROM"
        strSql = strSql + " TakeOuts INNER JOIN SalaryRecords ON TakeOuts.EmpID = SalaryRecords.EmpID"
        strSql = strSql + " WHERE        (TakeOuts.TakeoutDiscount >0 and TakeOuts.TakeoutName = N''" & a2 & "'')) AS tk ON sr.EmpID = tk.EmpID and tk.EmpID<>sr.EmpID "
        strSql = strSql + " order by empids ') end"
        Try
            SqlCnn.Open()
            mCmd.CommandType = CommandType.Text
            mCmd.CommandText = dropstr
            mCmd.ExecuteNonQuery()
            mCmd.CommandText = strSql
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlCnn.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MyMergProc()
        'CrystalReportViewer2.LogOnInfo.Add(logon1)
        TransMergRpt1.DataSourceConnections.Clear()
        If My.Computer.Name = "RAMITTA-PC" Then
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransMergRpt1.DataSourceConnections.Item(0).SetConnection("RAMITTA-pc", "SalaryLatDB", "Fadia", "microsoft@1976")
        Else
            ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
            TransMergRpt1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
        End If
        Me.CrystalReportViewer2.Visible = True
        Me.CrystalReportViewer2.Dock = DockStyle.Fill
        Me.CrystalReportViewer2.RefreshReport()
        Button6.Text = "رجوع"
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Dim s As String = TextBox4.Text.Trim
        Me.FieldTransBindingSource.Filter = "FldAr LIKE '%" & s & "%'"
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        Dim count As Integer = (ListBox4.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = ListBox4.Items.Item(a)
            If InStr(words.ToLower, TextBox7.Text.ToLower) Then
                ListBox4.SelectedItem = words
            End If
        Next
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        Dim count As Integer = (ListBox3.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = ListBox3.Items.Item(a)
            If InStr(words.ToLower, TextBox6.Text.ToLower) Then
                ListBox3.SelectedItem = words
            End If
        Next
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        Dim count As Integer = (ListBox2.Items.Count - 1)
        Dim words As String
        For a = 0 To count
            words = ListBox2.Items.Item(a)
            If InStr(words.ToLower, TextBox5.Text.ToLower) Then
                ListBox2.SelectedItem = words
            End If
        Next
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If CrystalReportViewer1.Visible = True Or CrystalReportViewer2.Visible = True Then
            CrystalReportViewer1.Visible = False
            CrystalReportViewer2.Visible = False
            Button6.Text = "إغلاق"
            If ISoldRecords.CheckState = CheckState.Checked Then
                GroupBox1.Visible = False
            Else
                GroupBox1.Visible = True
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        '163; 28
        If ListBox1.SelectedValue = "EngCooperation" Then
            CheckBox1.Visible = True
        Else
            CheckBox1.Visible = False
        End If

        If ListBox1.SelectedValue = "Qhelp1" Or ListBox1.SelectedValue = "Qhelp2" Or ListBox1.SelectedValue = "CooperationWorkers" Then
            CheckBox2.Visible = True
        Else
            CheckBox2.Visible = False
        End If

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If IsNumeric(TextBox9.Text) And IsNumeric(TextBox10.Text) Then
            SalM = TextBox9.Text
            SalY = TextBox10.Text
        Else
            MsgBox("القيمة  المدخلة غير صالحة")
        End If

    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedIndices.Count > 2 Then
            ListBox4.ClearSelected()

        End If
    End Sub

End Class