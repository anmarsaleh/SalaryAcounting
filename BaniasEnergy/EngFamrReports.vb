Imports System.Data.SqlClient

Public Class EngFamrReports
    Dim SqlCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim mCmd As New SqlCommand("", SqlCnn)
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) Then
            MyEngFarmRep(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            Me.EngFarmReportsTableAdapter.Fill(ReportsDataSet.EngFarmReports, TextBox1.Text, TextBox2.Text, TextBox3.Text)
            Me.ReportViewer1.RefreshReport()
        Else
            MsgBox("القيم المدخلة غير صحيحة")
            Exit Sub
        End If
    End Sub
    Private Sub MyEngFarmRep(ByRef p1, ByRef p2, ByRef p3)
        Dim strsql, StrDel As String
        StrDel = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EngFarmReports]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].EngFarmReports"
        strsql = "CREATE PROCEDURE dbo.EngFarmReports @p1 real=4 ,@p2 real=2.5 ,@p3 real=2.5 "
        strsql = strsql + " AS	BEGIN	select empid,fullname, SlitSalary, EngCooperation,retirefarmeng "
        strsql = strsql + " ,(SlitSalary*@p1)/100 as eng1, ((SlitSalary*@p2)/100) as eng2,((SlitSalary*@p2)/100)+retirefarmeng as eng3,salaryyear,salarymount "
        strsql = strsql + " from SalaryRecords where IsEngFarm=1 END"
        Try
            SqlCnn.Open()
            mCmd.CommandText = StrDel
            mCmd.ExecuteNonQuery()
            mCmd.CommandText = ""
            mCmd.CommandText = strsql
            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlCnn.Close()
    End Sub
    Private Sub EngFamrReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MyEngFarmRep(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Me.EngFarmReportsTableAdapter.Fill(ReportsDataSet.EngFarmReports, TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class