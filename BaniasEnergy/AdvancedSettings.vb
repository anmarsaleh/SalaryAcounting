Imports System.IO
Imports System.Text
Imports System.Linq
Imports Microsoft.VisualBasic
Public Class AdvancedSettings
    Dim Fdefault As String
    Dim F As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If InStr(TextBox1.Text, "delete") > 0 Or InStr(TextBox1.Text, "drop") > 0 Or InStr(TextBox1.Text, "Create") > 0 Or InStr(TextBox1.Text, "alter") > 0 Then
            MsgBox("خطأ")
        Else
            If F.Length > 0 Then
                '''''''''يجب التحقق من صحة الإجرائية الجديدة
                File.WriteAllText(F & ".sql", TextBox1.Text)
                'File.WriteAllText(My.Resources & "." & F & ".sql", TextBox1.Text)
                MsgBox("تم تعديل الإجرائية بنجاح")
            Else
                MsgBox("لم يتم تعديل أي بند")
            End If
        End If
        ComboBox1.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        TextBox1.Clear()
        Select Case ComboBox1.Text
            Case Trim("الترفيعة")
                F = "Allowance"
            Case Trim("التعويض العائلي")
                F = "Family"
            Case Trim("تعويض لإختصاص وطبيعة عمل")
                F = "SpecialType"
            Case Trim("الراتب الكلي")
                F = "FullSalary"
            Case Trim("صندوق التعاون")
                F = "CooperateBox"
            Case Trim("نقابة العمال")
                F = "CooperationWorkers"
            Case Trim("نقابة المهندسين")
                F = "EngCooperation"
            Case Trim("اجور السكن")
                F = "habitation"
            Case Trim("تأمينات إجتماعية")
                F = "SocialInsurance"
            Case Trim("ضريبة الدخل")
                F = "TotalTax"
            Case Trim("بقية البنود")
                F = "OtherFields"
            Case Trim("مجموع الحسميات")
                F = "SumDiscounts"
            Case Trim("الراتب الصافي")
                F = "TotalSalary"
        End Select
        Dim ReadF As String = ""
        If F.Length > 0 Then
            ReadF = File.ReadAllText(F & ".sql")
            Fdefault = ReadF
            TextBox1.Text = ReadF
            TextBox1.Text.ToUpper()
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = Fdefault
        ComboBox1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class