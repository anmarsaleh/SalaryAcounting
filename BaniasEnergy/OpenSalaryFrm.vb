Imports System.Data
Imports System.Data.SqlClient
Public Class OpenSalaryFrm
    Dim Cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Cmd As SqlCommand
    Dim Dr As SqlDataReader
    Dim StrSelectsalary As String = "select * from SalareisControl where (ControlID=@cid)"
    Dim StrNewsallary As String = "INSERT INTO SalareisControl([ControlID],[SalaryYear],[SalaryMount],[SalaryDate],[SalaryStatus],[OpenDate],[CloseDate],[Notes]) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)"
    Dim StrUpdateSalary As String = "UPDATE SalareisControl SET SalaryYear=@u2,SalaryMount=@u3,SalaryDate=@u4,SalaryStatus=@u5,OpenDate=@u6,CloseDate=@u7,Notes=@u8 WHERE (ControlID=@uc)"
    Dim CsalRec As String = "update SalaryRecords set ControlID=@d1,SalaryYear=@d2,SalaryMount=@d3"
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Mymainfrm = New MainFrm
        Mymainfrm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SalaryMountTextBox.Text = ComboBox1.Text
        Me.SalaryYearTextBox.Text = ComboBox2.Text
        Dim r As DialogResult = MsgBox("هل تريد بالتأكيد فتح الراتب للشهر والعام المعطى؟", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "تأكيد")
        If r = MsgBoxResult.Cancel Then
            MsgBox("تم تجاهل العملية")
            Exit Sub
        End If
        'Button1.Tag = 1
        'Button1.Text = "تهيئة السجلات للتعديل"
        LinkLabel2.Visible = True

        MsgBox("سيقوم البرنامج بتهيئة سجلات جميع الموظفين للإدخال والتعديل ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
       
        Try
            Cnn.Open()
            Dim Chkstat As Boolean = False
            Dim cmdchk As New SqlCommand("select SalaryStatus from SalareisControl where(SalaryStatus=1)", Cnn)
            Chkstat = cmdchk.ExecuteScalar
            If Chkstat Then
                MsgBox("لايمكن فتح راتب أكثر من شهر واحد" + Chr(13) + "يجب إغلاق الشهر المفتوح قبل المتابعة")
                Cnn.Close()
                Exit Sub
            End If
            ACtiveTrigers(False)
            If UpdateSalaryField() Then
                'TextBox1.AppendText("نجح إجراء تحديث سجلات الراتب" + vbNewLine)
            Else
                'TextBox1.AppendText("فشل إجراء تحديث سجلات الراتب" + vbNewLine)
            End If
            If AfterOpenMonth() Then

            End If
            If UpdateAllSolfa() Then
                'TextBox1.AppendText("نجاح تحديث سلف الجدول")
            End If
            Cmd = New SqlCommand(StrNewsallary, Cnn)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@p1", ControlID + 1)
            Cmd.Parameters.AddWithValue("@p2", Me.SalaryYearTextBox.Text)
            Cmd.Parameters.AddWithValue("@p3", Me.SalaryMountTextBox.Text)
            Cmd.Parameters.AddWithValue("@p4", Now.Date)
            Cmd.Parameters.AddWithValue("@p5", True)
            Cmd.Parameters.AddWithValue("@p6", Now.Date)
            Cmd.Parameters.AddWithValue("@p7", Now.Date)
            Cmd.Parameters.AddWithValue("@p8", Me.NotesTextBox.Text)
            Cmd.ExecuteNonQuery()
            'تحديث مفتاح شهر الراتب
            'سجلات الارتب
            Cmd.CommandText = CsalRec
            Cmd.Parameters.AddWithValue("@d1", ControlID + 1)
            Cmd.Parameters.AddWithValue("@d2", Me.SalaryYearTextBox.Text)
            Cmd.Parameters.AddWithValue("@d3", Me.SalaryMountTextBox.Text)
            Cmd.ExecuteNonQuery()

            ControlID += 1
            'السلف الأخرى
            Cmd.CommandText = "Update TakeOuts SET ControlID=@pp"
            Cmd.Parameters.AddWithValue("@pp", ControlID)
            Cmd.ExecuteNonQuery()
            'إعدادات الضريبة
            Cmd.CommandText = "Update SetupTax SET ControlID=@pp1"
            Cmd.Parameters.AddWithValue("@pp1", ControlID)
            Cmd.ExecuteNonQuery()
            'إعدادات حساب المفردات
            Cmd.CommandText = "Update SalaryConstants SET ControlID=@pp2"
            Cmd.Parameters.AddWithValue("@pp2", ControlID)
            Cmd.ExecuteNonQuery()
            'إعادة فرق
            Cmd.CommandText = "Update BacklogReturn SET ControlID=@pp3"
            Cmd.Parameters.AddWithValue("@pp3", ControlID)
            Cmd.ExecuteNonQuery()
            'استرداد فرق
            Cmd.CommandText = "Update BacklogRecover SET ControlID=@pp4"
            Cmd.Parameters.AddWithValue("@pp4", ControlID)
            Cmd.ExecuteNonQuery()
            'ضوابط راتب الشهر
            Cmd.CommandText = "Update CheckSalary SET ControlID=@pp5"
            Cmd.Parameters.AddWithValue("@pp5", ControlID)
            Cmd.ExecuteNonQuery()
            ' Cmd.CommandText=My.Computer.FileSystem.ReadAllText()
            'إدخال سجل المتحول الجديد
            Cmd.CommandText = My.Settings.InsertMutable.ToString
            Cmd.ExecuteNonQuery()
            Cmd = Nothing

            'Button1.Text = "فتح شهر جديد للراتب"
            'Button1.Tag = 0
            'LinkLabel2.Visible = False
            MsgBox("تم فتح راتب الشهر بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message + Chr(13) + "قد يؤثر هذا الخطأ على عملية حساب الراتب المقترنة بالشهر الجاري")
        Finally
            Cnn.Close()
        End Try
        ACtiveTrigers(True)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            ACtiveTrigers(False)
            Cnn.Open()
            Cmd = New SqlCommand(StrNewsallary, Cnn)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@u2", Me.SalaryYearTextBox.Text)
            Cmd.Parameters.AddWithValue("@u3", Me.SalaryMountTextBox.Text)
            Cmd.Parameters.AddWithValue("@u4", Now.Date)
            Cmd.Parameters.AddWithValue("@u5", True)
            Cmd.Parameters.AddWithValue("@u6", Now.Date)
            Cmd.Parameters.AddWithValue("@u7", Now.Date)
            Cmd.Parameters.AddWithValue("@u8", Me.NotesTextBox.Text)
            Cmd.Parameters.AddWithValue("@uc", ControlID + 1)
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = CsalRec
            Cmd.Parameters.AddWithValue("@d1", ControlID + 1)
            Cmd.Parameters.AddWithValue("@d2", Me.SalaryYearTextBox.Text)
            Cmd.Parameters.AddWithValue("@d3", Me.SalaryMountTextBox.Text)
            Cmd.ExecuteNonQuery()
            Cmd = Nothing

            MsgBox("تمت عملية التعديل بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cnn.Close()
            ACtiveTrigers(True)
        End Try
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.SalaryMountTextBox.Text = ComboBox1.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Me.SalaryYearTextBox.Text = ComboBox2.Text
    End Sub

    Private Sub OpenSalaryFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TextBox1.Hide()

        If Me.TextBox1.Text = "Open" Then
            Button1.Visible = True
            Button2.Visible = False
            If SalaryMounth = 12 Then
                SalaryMounth = 1
                SalaryYear += 1
            Else
                SalaryMounth += 1
            End If
            ComboBox1.Text = SalaryMounth
            ComboBox2.Items.Add(SalaryYear)
            ComboBox2.Items.Add(SalaryYear + 1)
            ComboBox2.Text = SalaryYear
        ElseIf TextBox1.Text = "Close" Then
            ComboBox2.Items.Add(SalaryYear)
            ComboBox2.Text = SalaryYear.ToString
            ComboBox1.Text = SalaryMounth.ToString
            Button1.Visible = False
            Button2.Visible = True
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.SalaryMountTextBox.Text = ComboBox1.Text
        Me.SalaryYearTextBox.Text = ComboBox2.Text
        Dim r As DialogResult = MsgBox("هل تريد بالتأكيد إغلاق الراتب للشهر والعام المعطى؟", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "تأكيد")
        If r = MsgBoxResult.Cancel Then
            MsgBox("تم تجاهل العملية")
            Exit Sub
        Else
            If ControlID <= 0 Then
                MsgBox("لم يتم التعرف على شهر الراتب المراد إغلاقة الرجاء إعادة تشغيل البرنامج والمحاوله مرة أخرى")
                Exit Sub
            End If
            Dim StrSql As String = "Update SalareisControl SET SalaryStatus=0 WHERE (ControlID=@Cid)"

            Try
                Cnn.Open()
                Cmd = New SqlCommand(StrSql, Cnn)
                Cmd.CommandType = CommandType.Text
                Cmd.Parameters.AddWithValue("@Cid", ControlID)
                Dim exeq As Integer = 0
                exeq = Cmd.ExecuteNonQuery()
                If exeq < 1 Then
                    MsgBox("فشلت عملية إغلاق شهر الراتب الرجاء المحاولة مرة أخرى")
                Else
                    MsgBox("تمت عملية إغلاق شهر الراتب بنجاح")
                    MyInsertSalary = New InsertLastSalaryFrm
                    MyInsertSalary.ShowDialog(Me)
                    Button2.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
            End Try
        End If
    End Sub
End Class