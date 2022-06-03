Imports System.Threading
Public Class InsertLastSalaryFrm
    Dim suc As Boolean = True
    Private Sub InsertLastSalaryFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LinkLabel1.Hide()
        LinkLabel2.Hide()
        TextBox1.Hide()
        ProgressBar1.Value = 0
        ProgressBar1.PerformStep()
        'تحديث قيم إسترداد الفروقات وترحيلها 
        If UpdateBacklogRecover() Then
            ProgressBar1.PerformStep()
            TextBox1.AppendText("نجحاح إجراء تحديث وترحيل استرداد الفروقات" + vbNewLine)
        Else
            TextBox1.AppendText("فشل إجراء تحديث وترحيل استرداد الفروقات" + vbNewLine)
            suc = False
        End If
        'تحديث قيم إعادة الفروقات وترحيلها 
        If UpdateBacklogReturn() Then
            ProgressBar1.PerformStep()
            TextBox1.AppendText("نجحاح إجراء تحديث وترحيل إعادة الفروقات" + vbNewLine)
        Else
            TextBox1.AppendText("فشل إجراء تحديث وترحيل إعادة الفروقات" + vbNewLine)
            suc = False
        End If
        'ترحيل السلف الأخرى
        If InsertLastTakeouts() Then
            ProgressBar1.PerformStep()
            TextBox1.AppendText("نجحاح ترحيل قيم السلف الأخرى" + vbNewLine)
        Else
            TextBox1.AppendText("فشل إجراء ترحيل قيم السلف الأخرى" + vbNewLine)
            suc = False
        End If
        'ترحيل سجلات الراتب
        If InsertTOLastSalareis() Then
            ProgressBar1.PerformStep()
            TextBox1.AppendText("نجحاح إجراء ترحيل سجلات الراتب" + vbNewLine)
            'Timer1.Enabled = True
            'Timer1.Start()
           
        Else
            TextBox1.AppendText("فشل إجراء ترحيل سجلات الراتب" + vbNewLine)
            suc = True
            'Timer1.Enabled = False
            'MsgBox("فشلت عملية الترحيل")
            'Me.Close()
        End If
       
        If Not suc Then
            LinkLabel1.Show()
            LinkLabel2.Show()
        Else
            Timer1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer1.Enabled = False
            Thread.Sleep(2000)
            MsgBox("تم ترحيل وتحديث سجلات الرواتب للشهر الجاري بنجاح")
            Me.Close()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
    End Sub
End Class