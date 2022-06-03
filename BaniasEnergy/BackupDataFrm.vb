Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class BackupDataFrm
    Dim Cnn As New SqlConnection(My.Settings.ConnectionSqlMaster)
    Dim Cmd As New SqlCommand("", Cnn)
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Myloginfrm = New LogInFrm
        Myloginfrm.Show()
        Me.Close()
    End Sub
    Dim BackFilepath As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Sfd As New SaveFileDialog
        Sfd.Filter = "(*.trn)|*.trn|(*.bak)|*.bak"
        Sfd.FileName = "New"
        Sfd.ShowDialog()
        BackFilepath = Sfd.FileName
        TextBox1.Text = BackFilepath
        Sfd.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim StrSql As String
        StrSql = "BACKUP DATABASE [BaniasEnergyDB] TO  [SalaryBackup] WITH NOFORMAT, INIT,  NAME = N'BaniasEnergyDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        If BackFilepath = "" Then
            MsgBox("يجب تحديد مسار صحيح")
            Exit Sub
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.GetParentPath(BackFilepath)) Then
            MsgBox("المسار غير صحيح")
            Exit Sub
        End If
        Try
            Cnn.Open()
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            Cnn.Close()
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\BackupData\SalaryBackup.bak", BackFilepath)
        Catch ex As SqlException
            MsgBox(ex.Message)
            Cnn.Close()
        End Try
    End Sub
    Dim RestFilepath As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Ofd As New OpenFileDialog
        Ofd.Filter = "(*.trn)|*.trn|(*.bak)|*.bak"
        Ofd.ShowDialog()
        RestFilepath = Ofd.FileName
        TextBox2.Text = RestFilepath
        Ofd.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim StrSql As String
        StrSql = "RESTORE DATABASE [BaniasEnergyDB] FROM  DISK = N'" & RestFilepath & "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10"
        If RestFilepath = "" Then
            MsgBox("يجب تحديد مسار صحيح")
            Exit Sub
        End If
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.GetParentPath(RestFilepath)) Then
            MsgBox("المسار غير صحيح")
            Exit Sub
        End If
        Try
            Cnn.Open()
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
            Cnn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim Strsql As String = "USE [BaniasEnergyDB]  DBCC SHRINKDATABASE(N'BaniasEnergyDB' )"
        Try
            Cnn.Open()
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
            Cnn.Close()
        End Try
    End Sub

    Private Sub BackupDataFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\BackupData") Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\BackupData")
        End If
        Dim CubkPath As String = Application.StartupPath & "\BackupData"
        Try
            Cnn.Open()
            Cmd.CommandText = "IF  EXISTS (SELECT name FROM master.dbo.sysdevices WHERE name = N'SalaryBackup') EXEC master.dbo.sp_dropdevice @logicalname = N'SalaryBackup'"
            Dim r As Integer = Cmd.ExecuteScalar
            Dim bkd As String = "EXEC master.dbo.sp_addumpdevice  @devtype = N'disk', @logicalname = N'SalaryBackup', @physicalname = N'" & CubkPath & "\SalaryBackup.bak'"
            Cmd.CommandText = bkd
            Cmd.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception
            Cnn.Close()
            MsgBox(ex.Message)
        End Try


    End Sub
End Class