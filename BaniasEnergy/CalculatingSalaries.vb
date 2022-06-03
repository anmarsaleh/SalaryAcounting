Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class CalculatingSalaries
    Dim rCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim rCmd As SqlCommand
    Dim Ischkshow As Boolean = False
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.UseWaitCursor = True
        RestorePoints(0, 0)
        'Dim Isok As DialogResult = MessageBox.Show("سيقوم البرنامج بحساب رواتب الموظفين وتوليد التارير المرتبطة" + Chr(13) + "هل تريد المتابعة", "عملية حساب الراتب", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        'If Not Isok = Windows.Forms.DialogResult.Yes Then Exit Sub
        Me.Label2.Visible = False
        ProgressBar1.Style = ProgressBarStyle.Blocks
        If InitializeA() Then
            ProgressBar1.PerformStep()
        End If
        If Allowance() Then
            ProgressBar1.PerformStep()
        End If
        If CalcFamily() Then
            ProgressBar1.PerformStep()
        End If
        If CalcSpecialType() Then
            ProgressBar1.PerformStep()
        End If
        If CalcBacklogReturn() Then
            ProgressBar1.PerformStep()
        End If
        If CalcMutable() Then
            ProgressBar1.PerformStep()
        End If
        If CalcManagers() Then
            ProgressBar1.PerformStep()
        End If
        If FieldRound() Then
            ProgressBar1.PerformStep()
        End If
        If CalcFullSalary() Then
            ProgressBar1.PerformStep()
        End If
        ''''''''''''''قسم الحسميات''''''''''''''''''''
        If SubBacklogRecover() Then
            ProgressBar1.PerformStep()
        End If
        ProgressBar1.PerformStep()
        If SocialInsurance() Then
            ProgressBar1.PerformStep()
        End If
        'If CooperateBox() Then
        '    ProgressBar1.PerformStep()
        'End If
        If CooperationWorkers() Then
            ProgressBar1.PerformStep()
        End If
        If EngCooperation() Then
            ProgressBar1.PerformStep()
        End If
        'If habitation() Then
        '    ProgressBar1.PerformStep()
        'End If
        If OtherFields() Then
            ProgressBar1.PerformStep()
        End If

        If CalcTax() Then
            ProgressBar1.PerformStep()
        End If
        If UpdateLoanDiscount() Then
            ProgressBar1.PerformStep()
        End If
        'If Mutable() Then
        '    ProgressBar1.PerformStep()
        'End If
        If SumTotalTakeOuts() Then
            ProgressBar1.PerformStep()
        End If
        If FieldRound() Then
            ProgressBar1.PerformStep()
        End If
        If SumDiscounts() Then
            ProgressBar1.PerformStep()
        End If
        If TotalSalary() Then
            ProgressBar1.PerformStep()
        End If
        If AfterDone() Then
            ProgressBar1.PerformStep()
        End If
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Me.Label2.Visible = True
        If CheckSalary() Then
            If MsgBox("تم الكشف عن بعض الأخطاء أثناء تدقيق سجلات رواتب الموظفين هل تريد عرضها الآن", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                Ischkshow = True
                Me.Close()
            Else
                Ischkshow = False
            End If
        Else
            Ischkshow = False
        End If
        ACtiveTrigers(True)
        Me.UseWaitCursor = False
        Me.Close()
    End Sub

    Private Sub CalculatingSalaries_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If CheckBox1.CheckState = CheckState.Unchecked Then
            Mymainfrm = New MainFrm
            Mymainfrm.Show()
        Else
            Myopensalary = New OpenSalaryFrm
            Myopensalary.TextBox1.Text = "Close"
            Myopensalary.Show()
        End If
        If Ischkshow Then
            If CheckSalary() Then
                MyResultCheckFrm = New ResultCheckFrm
                MyResultCheckFrm.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub CalculatingSalaries_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        CheckBox1.Hide()
    End Sub
End Class