Imports System.Data
Imports System.Data.SqlClient
Public Class DiagFrm
    Dim Dcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Dcmd As SqlCommand
    Private Sub CreateDiagProc()
        Dim dDsql, Dsql, Dcond As String
        If RadioButton1.Checked Then
            Dcond = " 0=0 "
        ElseIf RadioButton1.Checked Then
            Dcond = " IsWorkers=0 "
        ElseIf RadioButton3.Checked Then
            Dcond = " IsWorkers=1 "
        Else
            Dcond = " 0=0 "
        End If
        If CheckBox1.CheckState = CheckState.Checked Then
            Dcond += " and agentEmp=1 "
        Else
            Dcond += " and agentEmp=0 "
        End If
        dDsql = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiagValues]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[DiagValues]"
        Dsql = " CREATE PROCEDURE [dbo].[DiagValues] as BEGIN "
        Dsql += " select COUNT(empid) Cempid ,SUM(SlitSalary) CSlitSalary,SUM(SumDiscounts) cSumDiscounts,sum(FullSalary) CFullSalary,SUM(TotalSalary) cTotalSalary,CenterID  from SalaryRecords "
        Dsql += " where " & Dcond & ""
        Dsql += " group by CenterID order by CenterID END "
        Try
            Dcnn.Open()
            Dcmd = New SqlCommand("", Dcnn)
            Dcmd.CommandType = CommandType.Text
            Dcmd.CommandText = dDsql
            Dcmd.ExecuteNonQuery()
            Dcmd.CommandText = Dsql
            Dcmd.ExecuteNonQuery()
            Dcnn.Close()
        Catch ex As Exception
            Dcnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CreateDiagProc()
        Try
            Me.DiagValuesTableAdapter.Fill(Me.ReportsDataSet.DiagValues)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DiagFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportsDataSet.DiagValues' table. You can move, or remove it, as needed.
        Try
            Me.DiagValuesTableAdapter.Fill(Me.ReportsDataSet.DiagValues)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class