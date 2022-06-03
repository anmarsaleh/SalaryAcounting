Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class CancelRetoreFrm
    Dim Cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Function GetCancelRestoreEmp(ByVal EmpID As Integer, ByVal CancelRestore As String) As String
        Dim sql, sqld As String
        Dim A As String = ""
        Dim B As String = ""
        If CancelRestore = "Cancel" Then
            A = "[Salarytmp]"
            B = "[SalaryRecords]"
        ElseIf CancelRestore = "Restore" Then
            A = "[SalaryRecords]"
            B = "[Salarytmp]"
        End If
        'sqld = " USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CancelRestore]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].CancelRestore " & Constants.vbCrLf & " "
        'sql = " CREATE PROCEDURE [dbo].[CancelRestore] AS BEGIN " & Constants.vbCrLf & " "
        'sql += " if EXISTS(select empid from " & A & " where empid=" & EmpID & ") begin delete from " & A & " where Empid=" & EmpID & " end " & Constants.vbCrLf & " "
        sql = " insert into " & A & "  select * from " & B & " sr where sr.EmpID=" & EmpID & ""  '& Constants.vbCrLf & " "
        'sql += "  update " & A & "  SET SalaryYear=" + SalaryYear + ",SalaryMount=" + SalaryMounth + ",ControlID=" + ControlID + "  where sr.EmpID=" & EmpID & ""
        'Dim cdCmd As New SqlCommand("", Cnn)
        'Try
        '    Cnn.Open()

        'Catch ex As Exception

        'End Try
        Return sql
    End Function
    Private Sub BtnCalcelEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcelEmp.Click
        Dim r As DialogResult = MsgBox("سيقوم البرنامج بشطب السجل الحالي هل تريد المتابعة", MsgBoxStyle.YesNo)
        If r = DialogResult.No Then
            Exit Sub
        End If

        Dim cmd As New SqlCommand("", Cnn)
        Dim cmd1 As New SqlCommand("", Cnn)
        If Not IsNumeric(LblEmpID.Text) Then
            MsgBox("رقم الموظف غير صالح لا يمكن تنفيذ الإجراء")
            Exit Sub

        End If
        ACtiveTrigers(False)

        Dim Trans1 As SqlClient.SqlTransaction
        Cnn.Open()
        Trans1 = Cnn.BeginTransaction
        Try
            cmd.CommandText = GetCancelRestoreEmp(CInt(LblEmpID.Text), "Cancel")
            cmd.Transaction = Trans1
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            cmd1.CommandText = "delete from SalaryRecords  where(EmpID=" & LblEmpID.Text & ")"
            cmd1.Transaction = Trans1
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            Trans1.Commit()
            Cnn.Close()
        Catch ex As SqlException
            Trans1.Rollback()

            Cnn.Close()
            MsgBox(ex.Message)
            Me.DialogResult = Windows.Forms.DialogResult.No
            ACtiveTrigers(True)
        End Try
        ACtiveTrigers(True)
    End Sub
    Dim da As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Bs As New BindingSource
    Private Sub CancelRetoreFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'SalaryTmpDataSet.Salarytmp' table. You can move, or remove it, as needed.
        Me.SalarytmpTableAdapter.Fill(Me.SalaryTmpDataSet.Salarytmp)
        ' Cnn.Open()
        da = New SqlDataAdapter("select EmpID,FullName from [Salarytmp]", Cnn)
        da.Fill(Ds)
        Ds.Tables(0).TableName = "TBLtemp"
        Bs.DataSource = Ds.Tables(0)
        Me.DataGridView1.DataSource = Bs
        Me.DataGridView1.Columns(0).HeaderText = "رقم الموظف"
        Me.DataGridView1.Columns(1).HeaderText = "الإسم الثلاثي "
        Me.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ' Cnn.Close()
    End Sub

    Private Sub BtnRestoreEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestoreEmp.Click
        Dim r As DialogResult = MsgBox("سيقوم البرنامج بإستعادة السجل الحالي إلى سجلات الراتب هل تريد المتابعة", MsgBoxStyle.YesNo)
        If r = DialogResult.No Then
            Exit Sub
        End If
        Dim cmd As New SqlCommand("", Cnn)
        Dim dr As DataRowView = Bs.Current
        If Not IsNumeric(dr("EmpID")) Then
            MsgBox("يجب إختيار سجل موظف لإستعادتة")

            Exit Sub
        End If
        Dim cempid As Integer = dr("EmpID")
        Try
            Cnn.Open()
            cmd.CommandText = GetCancelRestoreEmp(cempid, "Restore")
            cmd.ExecuteNonQuery()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'حذف السجل من سجلات tmp
            cmd.CommandText = "delete from [Salarytmp]  where(EmpID=" & cempid & ")"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update SalaryRecords set SalaryMount=" & SalaryMounth & ",SalaryYear=" & SalaryYear & ",ControlID=" & ControlID & "  where(EmpID=" & cempid & ")"
            cmd.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
            Me.DialogResult = Windows.Forms.DialogResult.No
            Cnn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            Me.SalarytmpBindingSource.EndEdit()
            Me.SalarytmpTableAdapter.Update(SalaryTmpDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim pos As Integer
        'pos = Me.SalarytmpBindingSource.Position
        If Not IsNumeric(TextBox1.Text) Then Exit Sub
        pos = Me.SalarytmpBindingSource.Find("EmpID", TextBox1.Text)
        Me.SalarytmpBindingSource.Position = pos

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim pos As Integer
        If Not IsNumeric(TextBox2.Text) Then Exit Sub
        pos = Me.Bs.Find("EmpID", TextBox2.Text)
        Me.Bs.Position = pos

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Sqlstr As String = "update Salarytmp set DriveMark=0,DriveVication=0,DriveMarkValue=0,drive=0,mutableDays=0,mutable=0"
        If MessageBox.Show("هل انت متأكد من تنفيذ هذا الإجراء لجميع سجلات الشطب", "RAMITTA", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim cmd As New SqlCommand(Sqlstr, Cnn)
            Try
                cmd.ExecuteNonQuery()

                Me.SalarytmpTableAdapter.Fill(Me.SalaryTmpDataSet.Salarytmp)
                Cnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Cnn.Close()
            End Try
        End If
    End Sub
End Class