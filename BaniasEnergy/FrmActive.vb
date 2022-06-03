Imports System.Management
Public Class FrmActive
    Dim Idp As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmActive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Searcher As ManagementObjectSearcher
        Searcher = New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
        For Each Device As ManagementObject In Searcher.Get
            For Each Prop As PropertyData In Device.Properties
                'استخراج الرقم
                Idp = (Prop.Value.ToString)
            Next
        Next
        'تشويش الرقم
        Idp = Obfuscate(Idp)
        'تحويله الى اسكي
        Idp = Str2Int(Idp)
        'رقم التسجيل
        TextBox1.Text = Idp
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text.Length < 14 Then
            TextBox2.Focus()
            TextBox2.SelectAll()
            Exit Sub
        End If
        If TextBox3.Text.Length < 4 Then
            TextBox3.Focus()
            TextBox3.SelectAll()
            Exit Sub
        End If
        My.Settings.ActivateSalary = TextBox2.Text
        My.Settings.ActibeFor = TextBox3.Text
        My.Settings.Save()
        Application.DoEvents()
        MsgBox("تم إدخال مفتاح التسجيل")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class