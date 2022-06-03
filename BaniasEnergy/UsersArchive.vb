Imports System.Data
Imports System.Data.SqlClient
Public Class UsersArchive
    Dim arcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim arcmd As New SqlCommand("", arcnn)
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub ArchUsers(ByVal Cond As String)
        Dim StrSql, DelSql As String
        DelSql = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsersArrchive]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[UsersArrchive]"
        StrSql = "CREATE PROCEDURE [dbo].[UsersArrchive]  AS BEGIN exec(' "
        StrSql = StrSql + " SELECT        Audit.AuditID, CASE Audit.Type WHEN ''U'' THEN ''تعديل'' WHEN ''I'' THEN ''إدخال'' WHEN ''D'' THEN ''حذف'' END AS Type1, Audit.TableName, "
        StrSql = StrSql + "                 CASE Audit.TableName WHEN ''SalaryRecords'' THEN ''سجلات الراتب'' WHEN ''TakeOuts'' THEN ''سلف أخرى'' WHEN ''BacklogRecover'' THEN ''إسترداد فرق'' WHEN ''BacklogReturn''"
        StrSql = StrSql + "                 THEN ''إعادة فرق'' END AS RecordPlace, Audit.PrimaryKeyField, Audit.PrimaryKeyValue, Audit.FieldName, Audit.OldValue, Audit.NewValue, Audit.UpdateDate, "
        StrSql = StrSql + "                Audit.UserName AS PC, Audit.UserID, Audit.SalaryMonth, Audit.SalaryYear, Users.UserName, FieldTrans.FldAr, Audit.EmpID, SalaryRecords.FullName"
        StrSql = StrSql + " FROM            Audit INNER JOIN"
        StrSql = StrSql + "  Users ON Audit.UserID = Users.UserID INNER JOIN"
        StrSql = StrSql + "        SalaryRecords ON Audit.EmpID = SalaryRecords.EmpID INNER JOIN"
        StrSql = StrSql + "      FieldTrans ON Audit.FieldName = FieldTrans.FldEn " + Cond + ""
        StrSql = StrSql + "   ')"
        Try
            arcnn.Open()
            arcmd.CommandText = DelSql
            arcmd.ExecuteNonQuery()
            arcmd.CommandText = StrSql
            arcmd.ExecuteNonQuery()
            arcnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            arcnn.Close()
        End Try
    End Sub

    Private Sub UsersArchive_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub
    Private Sub UsersArchive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.UsersDBDataSet.Users)
        'TODO: This line of code loads data into the 'UsersDBDataSet.AuditArchive' table. You can move, or remove it, as needed.
        'Me.AuditArchiveTableAdapter.Fill(Me.UsersDBDataSet.AuditArchive)
        TXTyear.Text = SalaryYear.ToString
        TXTmonth.Text = SalaryMounth.ToString
        Me.AuditArchiveTableAdapter.FillBy(Me.UsersDBDataSet.AuditArchive, SalaryMounth, SalaryYear)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try
            arcnn.Open()
            If CheckBox1.CheckState = CheckState.Checked Then
                arcmd.CommandText = "ALTER TABLE SalaryRecords DISABLE TRIGGER ALL"
                arcmd.ExecuteNonQuery()
                MsgBox("تم ايقاف متابعة أحداث المستخدمين")
            Else
                arcmd.CommandText = "ALTER TABLE SalaryRecords ENABLE TRIGGER ALL"
                arcmd.ExecuteNonQuery()
                MsgBox("تم تشغيل متابعة أحداث المستخدمين")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            arcnn.Close()
        End Try
        arcnn.Close()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        MsgBox("يجب اعادة تسجيل الدخول لتنفيذ الإجراء المطلوب")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim str, a, b, c, u As String
        a = "SalaryYear=" + TXTyear.Text
        b = IIf(IsNumeric(TXTmonth.Text), "and SalaryMonth =" + TXTmonth.Text, "")
        c = IIf(IsNumeric(TXTempid.Text), "and EmpID= " + TXTempid.Text, "")
        u = ComboBox1.SelectedValue

        If CheckBox3.Checked Then
            str = a + " " + b + " " + c + " and UserID=" + u + ""
        Else
            str = a + " " + b + " " + c + " "
        End If
        Me.AuditArchiveTableAdapter.FillBy(Me.UsersDBDataSet.AuditArchive, TXTmonth.Text, TXTyear.Text)

        Me.AuditArchiveBindingSource.RemoveFilter()
        Me.AuditArchiveBindingSource.Filter = str
        'String.Format("UpdateDate >= #{0:M/dd/yyyy}# AND UpdateDate <= #{1:M/dd/yyyy}#", _
        'DateTimePicker1.Value, _
        ' DateTimePicker2.Value)
    End Sub

    
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class