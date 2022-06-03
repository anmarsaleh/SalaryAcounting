Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Public Class MainFrm
    Dim Mycnn = New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Mycmd = New SqlCommand("", Mycnn)
    Dim Cu_emp As Integer
    Dim MyDr As DataRowView
    Private trd As Thread
    Function ChkControlID() As Boolean
        Dim chk As Integer, val As Boolean
        Dim cnnc As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim cmdc As New SqlCommand("select count(dd.controlid) from (select controlid from salaryrecords group by ControlID) as dd", cnnc)
        Try
            cnnc.Open()
            chk = cmdc.ExecuteScalar
            If chk > 1 Then
                val = False
            Else
                val = True
            End If
            cnnc.Close()
        Catch ex As Exception
            cnnc.Close()
            MsgBox(ex.Message)
        End Try
        Return val
    End Function
    Private Sub إيقافالتشغيلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إيقافالتشغيلToolStripMenuItem.Click
        Application.Exit()
    End Sub
#Region "محددات الساعة"
    Private Const WM_NCLBUTTONDOWN = &HA1
    Private Const HTCAPTION = 2
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
                (ByVal hwnd As Integer, ByVal wMsg As Integer, _
                 ByVal wParam As Integer, ByVal lParam As String) As Integer
    Private Declare Sub ReleaseCapture Lib "user32" ()

    'Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
    '    Dim Clock_Font As New Font("Georgia", 11.0F, FontStyle.Bold)
    '    Dim Clock_Blend As New Drawing2D.Blend
    '    Dim Clock_Factors As Single() = {0.0F, 0.2F, 0.5F, 0.7F, 1.0F, 0.7F, 0.5F, 0.2F, 0.0F}
    '    Dim Clock_Positions As Single() = {0.0F, 0.1F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 1.0F}

    '    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
    '    e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '    Clock_Blend.Factors = Clock_Factors
    '    Clock_Blend.Positions = Clock_Positions
    '    '---------------------------------------------------------------------------' 
    '    'Draw Analog Clock Background' 
    '    'Dim rect As New Rectangle(0, 0, 100, 100)
    '    'Dim lgb As New Drawing2D.LinearGradientBrush(rect, Color.Black, Color.White, 90, True)
    '    'lgb.Blend = Clock_Blend

    '    'e.Graphics.FillEllipse(lgb, 0, 0, 100, 100)

    '    'lgb.LinearColors = New Color() {Color.White, Color.Black}
    '    'e.Graphics.FillEllipse(lgb, 10, 10, 90, 90)


    '    'lgb.LinearColors = New Color() {Color.Black, Color.White}
    '    'e.Graphics.FillEllipse(lgb, 13, 13, 86, 86)

    '    '---------------------------------------------------------------------------' 

    '    'Draw Analog Clock Numbers Background (Not Important) ' 

    '    'Dim path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
    '    'path.AddEllipse(20, 20, 160, 160)
    '    'path.AddEllipse(40, 40, 120, 120)

    '    'e.Graphics.FillPath(New SolidBrush(Color.FromArgb(20, Color.White)), path)
    '    '---------------------------------------------------------------------------' 

    '    'Draw Numbers' 

    '    Dim sbW As New SolidBrush(Color.Black)
    '    e.Graphics.DrawString("1", Clock_Font, sbW, 130, 30)
    '    e.Graphics.DrawString("2", Clock_Font, sbW, 153, 55)
    '    e.Graphics.DrawString("3", Clock_Font, sbW, 162, 90)
    '    e.Graphics.DrawString("4", Clock_Font, sbW, 153, 125)
    '    e.Graphics.DrawString("5", Clock_Font, sbW, 130, 150)
    '    e.Graphics.DrawString("6", Clock_Font, sbW, 93, 160)
    '    e.Graphics.DrawString("7", Clock_Font, sbW, 55, 150)
    '    e.Graphics.DrawString("8", Clock_Font, sbW, 32, 125)
    '    e.Graphics.DrawString("9", Clock_Font, sbW, 23, 90)
    '    e.Graphics.DrawString("10", Clock_Font, sbW, 27, 55)
    '    e.Graphics.DrawString("11", Clock_Font, sbW, 55, 30)
    '    e.Graphics.DrawString("12", Clock_Font, sbW, 89, 20)

    '    '---------------------------------------------------------------------------' 

    '    'This Code Will Work On Moving The Hands To The Center Of The Clock' 

    '    e.Graphics.TranslateTransform(100, 100, Drawing2D.MatrixOrder.Append)
    '    '---------------------------------------------------------------------------' 

    '    'Create The Angle Of Each Hand' 


    '    Dim hAngle As Single = 2.0 * Math.PI * (Now.Hour + Now.Minute / 60.0) / 12.0 ' m_Hours' 
    '    Dim sAngle As Single = 2.0 * Math.PI * Now.Second / 60.0 ' seconds' 
    '    Dim mAngle As Single = 2.0 * Math.PI * (Now.Minute + Now.Second / 60.0) / 60.0 ' minute' 

    '    '---------------------------------------------------------------------------' 
    '    'Draw Hours Hand' 

    '    Dim PathHours As New Drawing2D.GraphicsPath()
    '    Dim HourArrow As Point() = {New Point(Convert.ToInt32(40 * Math.Sin(hAngle)), Convert.ToInt32(-40 * Math.Cos(hAngle))), _
    '                                New Point(Convert.ToInt32(-5 * Math.Cos(hAngle)), Convert.ToInt32(-5 * Math.Sin(hAngle))), _
    '                                New Point(Convert.ToInt32(5 * Math.Cos(hAngle)), Convert.ToInt32(5 * Math.Sin(hAngle))), _
    '                                New Point(Convert.ToInt32(40 * Math.Sin(hAngle)), Convert.ToInt32(-40 * Math.Cos(hAngle)))}
    '    PathHours.AddPolygon(HourArrow)

    '    Dim hourBrush As New Drawing2D.LinearGradientBrush(PathHours.GetBounds(), Color.Black, Color.White, 90, False)
    '    hourBrush.Blend = Clock_Blend

    '    e.Graphics.FillPath(hourBrush, PathHours)
    '    e.Graphics.FillEllipse(hourBrush, -5, -5, 10, 10)
    '    '---------------------------------------------------------------------------' 

    '    'Draw Minute Hand' 

    '    Dim PathMinutes As New Drawing2D.GraphicsPath()
    '    Dim MinArrow As Point() = {New Point(Convert.ToInt32(60 * Math.Sin(mAngle)), Convert.ToInt32(-60 * Math.Cos(mAngle))), _
    '                               New Point(Convert.ToInt32(-5 * Math.Cos(mAngle)), Convert.ToInt32(-5 * Math.Sin(mAngle))), _
    '                               New Point(Convert.ToInt32(5 * Math.Cos(mAngle)), Convert.ToInt32(5 * Math.Sin(mAngle))), _
    '                               New Point(Convert.ToInt32(60 * Math.Sin(mAngle)), Convert.ToInt32(-60 * Math.Cos(mAngle)))}
    '    PathMinutes.AddPolygon(MinArrow)

    '    Dim minuteBrush As New Drawing2D.LinearGradientBrush(PathMinutes.GetBounds(), Color.Black, Color.White, 90, False)
    '    minuteBrush.Blend = Clock_Blend

    '    e.Graphics.FillPath(minuteBrush, PathMinutes)
    '    e.Graphics.FillEllipse(minuteBrush, -5, -5, 10, 10)

    '    '---------------------------------------------------------------------------' 


    '    ' Draw Second Hand' 
    '    Dim secondPen As New Pen(Color.Black, 1)
    '    Dim m_Point As New Point(0, 0)

    '    Dim secHand As New Point(Convert.ToInt32(70 * Math.Sin(sAngle)), Convert.ToInt32(-70 * Math.Cos(sAngle)))
    '    e.Graphics.DrawLine(secondPen, m_Point, secHand)


    'End Sub
    'Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        Dim lHwnd As Int32
    '        lHwnd = Me.Handle
    '        If lHwnd = 0 Then Exit Sub
    '        ReleaseCapture()
    '        SendMessage(lHwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    '    End If
    'End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'If Panel1.Height < 150 Then
        '    Timer1.Stop()
        'Else
        '    Timer1.Start()
        'End If
        'Me.Label1.Text = Now
        'Me.Refresh()
        'PictureBox1.Refresh()
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Panel1.Height = 150 Then
            Panel1.Height = 10
            Button1.Location = New Point(276, 131)
            Label5.Visible = True
            Label5.Dock = DockStyle.Fill
            ' PictureBox1.Visible = False
            Timer1.Enabled = False
            ToolStripButton5.Visible = True
            ToolStripButton5.AutoToolTip = True
        Else
            Panel1.Height = 150
            Button1.Location = New Point(276, 131)
            Label5.Visible = False
            Label5.Dock = DockStyle.None
            ' PictureBox1.Visible = True
            'Timer1.Enabled = True
            ToolStripButton5.Visible = False
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Button1.PerformClick()
    End Sub

    Private Sub ضريبةالدخلToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ضريبةالدخلToolStripMenuItem.Click
        Mysalarytax = New SalaryTaxFrm
        Mysalarytax.ShowDialog(Me)
    End Sub

    Private Sub إدارةالمستخدمينToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدارةالمستخدمينToolStripMenuItem.Click
        'Dim Mymanageuser As New ManageUsers
        'Mymanageuser.ShowDialog(Me)
    End Sub

    Private Sub تسجيلخروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تسجيلخروجToolStripMenuItem.Click
        Myloginfrm = New LogInFrm
        Myloginfrm.Show()
        Me.Close()
    End Sub

    Private Sub ثوابتالمفرداتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثوابتالمفرداتToolStripMenuItem.Click
        Mysalaryconstants = New SalaryConstantFrm
        Mysalaryconstants.ShowDialog(Me)

    End Sub

    Private Sub MainFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.CurrentRecord = IIf(Me.EmpIDTextBox.Text = "", 0, Me.EmpIDTextBox.Text) 'Me.SalaryRecordsBindingSource.Position
        My.Settings.CurrentTab = Me.TabControl1.SelectedIndex
        My.Settings.Save()
        'Myloginfrm = New LogInFrm
        'Myloginfrm.Show()
    End Sub
    Private Sub loaddata()
        Dim pos As Integer = Me.SalaryRecordsBindingSource.Position
        UpdateUserData(Cu_User.UserID)
        Me.SalaryRecordsTableAdapter.ClearBeforeFill = True
        Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)
        Me.MutableSettingTableAdapter.Fill(Me.MutableDataSet.MutableSetting)
        Me.CenterNamesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.CenterNames)
        Me.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        Me.DetialsRecoverTableAdapter.Fill(Me.ReportsDataSet.DetialsRecover)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsReturn' table. You can move, or remove it, as needed.
        Me.DetialsReturnTableAdapter.Fill(Me.ReportsDataSet.DetialsReturn)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsTakeOut' table. You can move, or remove it, as needed.
        Me.DetialsTakeOutTableAdapter.Fill(Me.ReportsDataSet.DetialsTakeOut)
        'TODO: This line of code loads data into the 'ReportsDataSet.SalaryReport' table. You can move, or remove it, as needed.
        Me.SalaryReportTableAdapter.Fill(Me.ReportsDataSet.SalaryReport)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Offices' table. You can move, or remove it, as needed.
        Me.OfficesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Offices)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Directorates' table. You can move, or remove it, as needed.
        Me.DirectoratesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Directorates)
        ' Me.DirectoratesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Directorates)
        Me.TypeSpecializeValuesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.TypeSpecializeValues)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.SpecializeValues' table. You can move, or remove it, as needed.
        Me.SpecializeValuesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SpecializeValues)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.CenterNames' table. You can move, or remove it, as needed.
        If Cu_User.IsAdmin Then
            Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)
            Label1.Text = EmpCompanyComboBox.Text
            Label31.Text = "سجلات العاملين بالشركة"
        Else
            UserRecorsAllows()
        End If
        Me.SalaryRecordsBindingSource.ResetBindings(True)
        Me.SalaryRecordsBindingSource.Position = pos
        Me.SalaryRecordsBindingSource.ResetBindings(False)
    End Sub

    Private Sub MainFrm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Cu_User.IsAdmin Then
            DelRestorp()
            DelArchive()
        End If
    End Sub
    Private Sub DelArchive()
        Dim aCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim aCmd As New SqlCommand("", aCnn)
        Dim test As Integer
        Dim strsql As String
        test = IIf(IsNumeric(My.Settings.DelArchive), CInt(My.Settings.DelArchive), 0)
        If test <= 0 Then Exit Sub
        strsql = " declare @d2 date "
        strsql += " select @d2=convert(date,'1'+'/'+ SalaryMount+'/'+SalaryYear)  from SalaryRecords "
        strsql += " delete  from Audit "
        strsql += " where DATEDIFF(m,UpdateDate,@d2)>" & test & " "
        Try
            aCnn.Open()
            aCmd.CommandType = CommandType.Text
            aCmd.CommandText = strsql
            aCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            aCnn.Close()
        End Try
    End Sub
    Private Sub DelRestorp()
        Dim RaCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim RaCmd As New SqlCommand("", RaCnn)
        Dim Cnt, val, test As Integer
        Cnt = 0
        test = IIf(IsNumeric(My.Settings.DelRestorePoint), CInt(My.Settings.DelRestorePoint), 0)
        If test <= 0 Then Exit Sub
        Try
            RaCnn.Open()
            RaCmd.CommandType = CommandType.Text
            RaCmd.CommandText = " select MAX(controlid) from RestorePoints "
            Cnt = RaCmd.ExecuteScalar
            val = Cnt - test
            val = IIf(val > 0, val, 0)
            RaCmd.CommandText = "Delete from RestorePoints where ControlID< " & val & ""
            RaCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            RaCnn.Close()
        End Try
    End Sub
    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.DriveException' table. You can move, or remove it, as needed.
        Me.DriveExceptionTableAdapter.Fill(Me.BaniasEnergyDBDataSet.DriveException)
        'TODO: This line of code loads data into the 'ReportsDataSet.SalaryReport' table. You can move, or remove it, as needed.
        Me.SalaryReportTableAdapter.Fill(Me.ReportsDataSet.SalaryReport)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsRecover' table. You can move, or remove it, as needed.
        Me.DetialsRecoverTableAdapter.Fill(Me.ReportsDataSet.DetialsRecover)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsReturn' table. You can move, or remove it, as needed.
        Me.DetialsReturnTableAdapter.Fill(Me.ReportsDataSet.DetialsReturn)
        'TODO: This line of code loads data into the 'ReportsDataSet.DetialsTakeOut' table. You can move, or remove it, as needed.
        Me.DetialsTakeOutTableAdapter.Fill(Me.ReportsDataSet.DetialsTakeOut)
        'trd = New Thread(AddressOf SaveTask)
        'trd.IsBackground = True
        loaddata()
        Me.MarkNoTextBox.Hide()
        Me.ControlIDTextBox.Hide()
        ControlIDTextBox1.Hide()
        Me.UserIDTextBox.Hide()
        Me.LastModifyTextBox.Hide()
        Me.CreateDateTextBox.Hide()
        Me.SalaryYearTextBox.Hide()
        Me.SalaryMountTextBox.Hide()
        Me.TaxationIDTextBox.Hide()
        Me.SalaryConstantsTextBox.Hide()
        'Me.TindexTextBox.Hide()
        'Me.STindexTextBox.Hide()
        Label3.Text = Cu_User.UserName
        Label9.Text = Me.SalaryRecordsBindingSource.Count
        If Me.SalaryRecordsBindingSource.Count > 0 Then
            Me.SalaryRecordsBindingSource.Position = Me.SalaryRecordsBindingSource.Find("EmpId", My.Settings.CurrentRecord) 'IIf(My.Settings.CurrentRecord > 0, My.Settings.CurrentRecord, 0)
        End If
        Me.TabControl1.SelectedIndex = My.Settings.CurrentTab
        'ToolStripStatusLabel4.Text = Label12.Text

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Myreturntoemp = New ReturnToEmpFrm
        If Me.EmpIDTextBox.Text = "" Then
            MsgBox("لايمكن فتح واجهة إعادة الفرق")
            Exit Sub
        End If
        Myreturntoemp.ShowDialog(Me)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyrecoverFromEmp = New RecoverFromEmpFrm
        If Me.EmpIDTextBox.Text = "" Then
            MsgBox("لايمكن فتح واجهة إسترداد الفرق")
            Exit Sub
        End If
        MyrecoverFromEmp.EmpIDTextBox.Text = EmpIDTextBox.Text
        MyrecoverFromEmp.ShowDialog(Me)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Mytakeouts = New TakeOutsFrm
        Mytakeouts.ShowDialog(Me)
    End Sub
    Private Sub SaveTask()
        'Me.Validate()
        'Me.SalaryRecordsBindingSource.EndEdit()
        'Me.SalaryRecordsTableAdapter.Update(Me.BaniasEnergyDBDataSet.SalaryRecords)
        'Me.BaniasEnergyDBDataSet.SalaryRecords.AcceptChanges()
        'Me.ToolStripProgressBar1.Value = 75
        'Label9.Text = Me.SalaryRecordsBindingSource.Count
        CalcOnSave()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If SalaryState = 0 Then
            Exit Sub
        End If

        Me.ToolStripProgressBar1.Visible = True
        If Not Me.IsContractCheckBox.Visible Then
            Me.IsContractCheckBox.Visible = False
        End If
        Me.ToolStripProgressBar1.Value = 25
        'Dim KeepF As String = Me.SalaryRecordsBindingSource.Filter
        'If KeepF <> "" Then
        '    Me.SalaryRecordsBindingSource.RemoveFilter()
        'End If
        Me.FullNameLabel1.Text = FnameTextBox.Text + " " + MnameTextBox.Text + " " + LnameTextBox.Text
        Me.UserIDTextBox.Text = Cu_User.UserID
        'Dim Idfree As Integer = Me.SalaryRecordsTableAdapter.IsEmpIdFree(Me.EmpIDTextBox.Text)
        Me.ToolStripProgressBar1.Value = 50
        Dim cp As Integer = Me.EmpIDTextBox.Text
        Dim ctab As Integer = Me.TabControl1.SelectedIndex
        Try
            TabControl1.Enabled = False
            'MutableCalc()
            Me.Validate()
            Me.SalaryRecordsBindingSource.EndEdit()
            Me.SalaryRecordsTableAdapter.Update(Me.BaniasEnergyDBDataSet.SalaryRecords)
            Me.BaniasEnergyDBDataSet.SalaryRecords.AcceptChanges()
            Me.ToolStripProgressBar1.Value = 75
            Label9.Text = Me.SalaryRecordsBindingSource.Count
            CalcOnSave()
            'trd.Start()
            If Cu_User.IsAdmin Then
                Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)
                Label1.Text = EmpCompanyComboBox.Text
                Label31.Text = "سجلات العاملين بالشركة"
            Else
                UserRecorsAllows()
            End If
            If Me.SalaryRecordsBindingSource.Count > 0 Then
                Me.SalaryRecordsBindingSource.Position = Me.SalaryRecordsBindingSource.Find("EmpId", cp) 'IIf(My.Settings.CurrentRecord > 0, My.Settings.CurrentRecord, 0)
            End If
            Me.TabControl1.SelectedIndex = ctab
            'If KeepF <> "" Then
            '    Me.SalaryRecordsBindingSource.Filter = KeepF
            'End If
        Catch ee As DBConcurrencyException

            MessageBox.Show("  لا يمكن تنفيذ التعديلات على هذا السجل لأنة معدل من قبل مستخدم آخر" + Constants.vbCrLf + "يرجى تحديث بيانات السجل قبل التعديل بالضغط على زر F5", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
        Catch ex As Exception
            MsgBox(ex.Message)
            TabControl1.Enabled = True
        Finally
            TabControl1.Enabled = True
        End Try
        Me.ToolStripProgressBar1.Value = 100
        Me.Label17.Text = Cu_User.LastEditUser(IIf(IsNumeric(UserIDTextBox.Text), UserIDTextBox.Text, 0))
        Me.ToolStripProgressBar1.Visible = False
        UpdateUserData(Cu_User.UserID)

        'If Cu_User.IsAdmin Then CalcOnSave()

    End Sub

    Private Sub MainFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LoadSalaryDate()
        If Not ChkControlID() Then
            Dim chkf As New ChkControlID
            chkf.ShowDialog()
        End If
        LoadConstants()

        LoadTax()
        LoadCRVconnection()
        Label1.Text = EmpCompanyComboBox.Text
        Dim Dt As Date = DateSerial(SalaryYear, SalaryMounth, 1)
        Dt = FormatDateTime(Dt, DateFormat.LongDate) '"MMM-yyyy") 'DateFormat.LongDate)
        Label12.Text = Format(Dt, "MMM - yyyy") 'SalaryMounth.ToString + "-" + SalaryYear.ToString
        ToolStripStatusLabel4.Text = Format(Dt, "MMM - yyyy")
        If SalaryState Then
            Label13.Text = "مفتوح"
            Label13.ForeColor = Color.Green
        Else
            Label13.Text = "مغلق"
            Label13.ForeColor = Color.Red
        End If
        'Timer1.Enabled = True
        If SalaryState = 0 Then
            ToolStripButton4.Enabled = False
            إغلاقالراتبToolStripMenuItem.Enabled = False
            ToolStripButton3.Enabled = True
            فتحسجلاتشهرجديدToolStripMenuItem.Enabled = True
            حسابالراتبToolStripMenuItem.Enabled = False
            ToolStripButton1.Enabled = False
            ToolStripButton2.Enabled = False
            تدقيقسجلاتالراتبToolStripMenuItem.Enabled = False
            'Me.SalaryRecordsBindingSource.SuspendBinding()
            Me.TabControl1.TabPages(0).Enabled = False
            Me.TabControl1.TabPages(1).Enabled = False
            Me.TabControl1.TabPages(2).Enabled = False
            Me.TabControl1.TabPages(3).Enabled = False
            Me.TabControl1.TabPages(4).Enabled = True
            ' عملياتالراتبToolStripMenuItem.Enabled = False
            سجلاتالشطبToolStripMenuItem.Enabled = False
            'ضبطToolStripMenuItem.Enabled = False
            ToolStripButton1.Enabled = False
            ToolStripButton1.Enabled = False
        Else
            ToolStripButton4.Enabled = True
            إغلاقالراتبToolStripMenuItem.Enabled = True
            ToolStripButton3.Enabled = False
            فتحسجلاتشهرجديدToolStripMenuItem.Enabled = False
            حسابالراتبToolStripMenuItem.Enabled = True
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
            تدقيقسجلاتالراتبToolStripMenuItem.Enabled = True
            Me.SalaryRecordsBindingSource.ResumeBinding()
            Me.TabControl1.TabPages(0).Enabled = True
            Me.TabControl1.TabPages(1).Enabled = True
            Me.TabControl1.TabPages(2).Enabled = True
            Me.TabControl1.TabPages(3).Enabled = True
            Me.TabControl1.TabPages(4).Enabled = True
            'عملياتالراتبToolStripMenuItem.Enabled = True
            سجلاتالشطبToolStripMenuItem.Enabled = True
            ضبطToolStripMenuItem.Enabled = True
            ToolStripButton1.Enabled = True
            ToolStripButton1.Enabled = True
        End If
        حساباتToolStripMenuItem.Enabled = Cu_User.IsAdmin
        Me.Text = Me.Text & "//" & "المستخدم الحالي:" & Cu_User.UserName
        CheckPermision()
        'ToolTip1.Show("إنقر هنا لإظهار حالة سجلات الشهر", Button1)
        If IsNumeric(Me.EmpIDTextBox.Text) Then
            Cu_emp = Me.EmpIDTextBox.Text
        End If
        If IsContractCheckBox.CheckState = CheckState.Checked Then
            Me.GroupBox29.Visible = True
        Else
            Me.GroupBox29.Visible = False
        End If
        If Not Cu_User.IsAdmin Then
            Me.GroupBox28.Visible = False
            Button5.Visible = False
            Button3.Visible = False
            Button8.Visible = False
            Button13.Visible = False
            Button12.Visible = False
            Button5.Visible = False
            Button14.Visible = False
            CardNoTextBox.Enabled = False
            العرضToolStripMenuItem.Enabled = False
            'ToolStripButton1.Enabled = False
            حسابالراتبToolStripMenuItem.Enabled = False
            إلغــاءToolStripMenuItem.Enabled = False
            عملياتالراتبToolStripMenuItem.Enabled = False
        Else
            Me.GroupBox28.Visible = True
            Button5.Visible = True
            Button3.Visible = True
            Button8.Visible = True
            Button13.Visible = True
            Button12.Visible = True
            Button5.Visible = True
            Button14.Visible = True
            ToolStripButton1.Enabled = True
            CardNoTextBox.Enabled = True
            حسابالراتبToolStripMenuItem.Enabled = True
            إلغــاءToolStripMenuItem.Enabled = True
            العرضToolStripMenuItem.Enabled = True
            عملياتالراتبToolStripMenuItem.Enabled = True
        End If
        ACtiveTrigers(True)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Drv As DataRowView = Me.SalaryRecordsBindingSource.Current
        'If Drv.IsEdit Then
        '    MsgBox("row is edit")
        'ElseIf Drv.IsNew Then
        '    MsgBox("row is addnew")
        'End If
        If Drv IsNot Nothing AndAlso Drv.IsNew Then Exit Sub
        Dim NewID As Integer = IIf(IsDBNull(Me.SalaryRecordsTableAdapter.GetNewEmpID), 100, Me.SalaryRecordsTableAdapter.GetNewEmpID)
        Me.SalaryRecordsBindingSource.AddNew()
        Me.FnameTextBox.Text = "موظف جديد"
        Me.EmpIDTextBox.Text = NewID.ToString
        Me.ControlIDTextBox.Text = ControlID
        Me.SalaryConstantsTextBox.Text = 1 'معرف ثوابت البرنامج
        Me.TaxationIDTextBox.Text = 1
        Me.MarkNoTextBox.Text = 1
        Me.UserIDTextBox.Text = Cu_User.UserID
        Me.CreateDateTextBox.Text = Now.Date
        Me.LastModifyTextBox.Text = Now.Date
        Me.SalaryYearTextBox.Text = SalaryYear
        Me.SalaryMountTextBox.Text = SalaryMounth
        Me.IsContractCheckBox.Visible = True
        Me.IsContractCheckBox.Enabled = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Me.SalaryRecordsBindingSource.IsBindingSuspended Then Exit Sub
        If MsgBox("هل أنت متأكد من حذف السجل الحالي", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = vbYes Then
            Me.SalaryRecordsBindingSource.RemoveCurrent()
            Button6.PerformClick()
        Else
            MsgBox("تم إلغاء عملية الحذف")
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.SalaryRecordsBindingSource.RemoveFilter()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.SalaryRecordsBindingSource.RemoveFilter()
        Me.SalaryRecordsBindingSource.Filter = "MarkNo=0"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.SalaryRecordsBindingSource.RemoveFilter()
        Me.SalaryRecordsBindingSource.Filter = "MarkNo=2"
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Cu_User.AllowOpen Then
            Myopensalary = New OpenSalaryFrm
            Myopensalary.TextBox1.Text = "Open"
            Myopensalary.Show()
            Me.Close()
            If Myloginfrm IsNot Nothing Then
                Myloginfrm.Close()
            End If
        Else
            MsgBox("لا تملك صلاحية فتح راتب شهر جديد")
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If Cu_User.AllowOpen Then
            'ToolStripButton1.PerformClick()
            'MyCalculatingSalaries.CheckBox1.CheckState = CheckState.Checked
            'MyCalculatingSalaries.Button1.PerformClick()
            Myopensalary = New OpenSalaryFrm
            Myopensalary.TextBox1.Text = "Close"
            Myopensalary.Show()
            Application.DoEvents()
            Me.Close()
            If Myloginfrm IsNot Nothing Then
                Myloginfrm.Close()
            End If
        Else
            MsgBox("لا تملك صلاحية إغلاق الشهر الحالي")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If SalaryState = 0 Then
            MsgBox("لا يمكن تنفيذ الإجراء على الشهر الحالي لأنة مغلق")
            Exit Sub
        End If
        MyCalculatingSalaries = New CalculatingSalaries
        MyCalculatingSalaries.Show()
        Me.Close()
        Application.DoEvents()
        If Not Myloginfrm Is Nothing Then
            Myloginfrm.Close()
        End If
    End Sub

    Private Sub تسميةالدوائرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تسميةالدوائرToolStripMenuItem.Click
        MyDirectorate = New DirectorateFrm
        MyDirectorate.ShowDialog(Me)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Directorates' table. You can move, or remove it, as needed.
        'Me.DirectoratesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Directorates)
    End Sub

    Private Sub المنصبالوظيفيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles المنصبالوظيفيToolStripMenuItem.Click
        Myofficers = New OfficersFrm
        Myofficers.ShowDialog(Me)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.Offices' table. You can move, or remove it, as needed.
        'Me.OfficesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.Offices)
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If TabControl1.SelectedTab.Name = SalaryTabPage.Name Then
            Me.SalaryReportBindingSource.RemoveFilter()
            Me.SalaryReportBindingSource.Filter = "EmpID=" & IIf(Me.EmpIDTextBox.Text = "", -1, Me.EmpIDTextBox.Text) & ""
            Me.DetialsReturnBindingSource.Filter = Me.SalaryReportBindingSource.Filter
            Me.DetialsRecoverBindingSource.Filter = Me.SalaryReportBindingSource.Filter
            Me.DetialsTakeOutBindingSource.Filter = Me.SalaryReportBindingSource.Filter
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.SalaryReportBindingSource.Filter = "EmpID=" & IIf(Me.EmpIDTextBox.Text = "", -1, Me.EmpIDTextBox.Text) & ""
        Me.DetialsReturnBindingSource.Filter = Me.SalaryReportBindingSource.Filter
        Me.DetialsRecoverBindingSource.Filter = Me.SalaryReportBindingSource.Filter
        Me.DetialsTakeOutBindingSource.Filter = Me.SalaryReportBindingSource.Filter
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        MyResultCheckFrm = New ResultCheckFrm
        MyResultCheckFrm.Show()
    End Sub

    Private Sub UserIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserIDTextBox.TextChanged
        ' Me.Label17.Text = Cu_User.LastEditUser(IIf(IsNumeric(UserIDTextBox.Text), UserIDTextBox.Text, 0))
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim p, cp As Integer
        cp = Me.SalaryRecordsBindingSource.Position
        If IsNumeric(TextBox1.Text) Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            p = Me.SalaryRecordsBindingSource.Find("EmpID", TextBox1.Text)
            If p > -1 Then
                Me.SalaryRecordsBindingSource.Position = p
                Me.TextBox1.BackColor = Color.White
            Else
                Me.SalaryRecordsBindingSource.Position = cp
                Me.TextBox1.BackColor = Color.Red
            End If
        ElseIf TextBox1.TextLength > 0 Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            If InStr(TextBox1.Text, "%") > 0 Then
                Me.SalaryRecordsBindingSource.Filter = "FullName LIKE '" & TextBox1.Text & "' "
            Else
                Me.SalaryRecordsBindingSource.Filter = "FullName LIKE '%" & TextBox1.Text & "%' "
            End If
        ElseIf Me.SalaryRecordsBindingSource.Count = 0 Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
        Else
            'Me.SalaryRecordsBindingSource.Find("EmpID", Cu_emp)
            Me.SalaryRecordsBindingSource.RemoveFilter()
        End If
        If TextBox1.Text = "" Then
            Me.TextBox1.BackColor = Color.White
        End If
        If TabControl1.SelectedTab.Name = SalaryTabPage.Name Then
            Me.SalaryReportBindingSource.RemoveFilter()
            Me.SalaryReportBindingSource.Filter = "EmpID=" & IIf(Me.EmpIDTextBox.Text = "", -1, Me.EmpIDTextBox.Text) & ""
            Me.DetialsReturnBindingSource.Filter = Me.SalaryReportBindingSource.Filter
            Me.DetialsRecoverBindingSource.Filter = Me.SalaryReportBindingSource.Filter
            Me.DetialsTakeOutBindingSource.Filter = Me.SalaryReportBindingSource.Filter
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub EmpIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpIDTextBox.TextChanged

        'If TextBox1.Text = "" Then
        '    CuEmpID = -1
        'Else
        CuEmpID = IIf(IsNumeric(EmpIDTextBox.Text), EmpIDTextBox.Text, -1)
        'End If
        Me.Label17.Text = Cu_User.LastEditUser(IIf(IsNumeric(UserIDTextBox.Text), UserIDTextBox.Text, 0))
        Me.GroupBoxManager.Visible = IsManagerCheckBox.Checked
        Label1.Text = EmpCompanyComboBox.Text
       
    End Sub

    Private Sub إدخالاتموحدةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إدخالاتموحدةToolStripMenuItem.Click
        Myupdateforall = New UodateForAllFrm
        Myupdateforall.Show()
    End Sub

    Private Sub التحققمنسجلاتالراتبToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles التحققمنسجلاتالراتبToolStripMenuItem1.Click
        MyCheckSalaryFrm = New CheckSalaryFrm
        MyCheckSalaryFrm.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Button6.PerformClick()
    End Sub

    Private Sub تدقيقسجلاتالراتبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تدقيقسجلاتالراتبToolStripMenuItem.Click
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub راتبالشهرالحاليToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles راتبالشهرالحاليToolStripMenuItem.Click
        MymanageReports = New ManageReports
        MymanageReports.Show(Me)
    End Sub

    Private Sub رواتبقديمةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles رواتبقديمةToolStripMenuItem.Click
       
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim pos As Integer = Me.SalaryRecordsBindingSource.Position
        If LinkLabel3.Text = "تصفية" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            Me.SalaryRecordsBindingSource.Filter = "DirectorateID=" & IIf(IsNothing(DirectorateIDComboBox.SelectedValue), -1, DirectorateIDComboBox.SelectedValue) & ""
            LinkLabel3.Text = "إلغاء"
        ElseIf LinkLabel3.Text = "إلغاء" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            LinkLabel3.Text = "تصفية"
            Me.SalaryRecordsBindingSource.Position = pos
        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim pos As Integer = Me.SalaryRecordsBindingSource.Position
        If LinkLabel4.Text = "تصفية" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            Me.SalaryRecordsBindingSource.Filter = "OfficeID=" & IIf(IsNothing(OfficeIDComboBox.SelectedValue), -1, OfficeIDComboBox.SelectedValue) & ""
            LinkLabel4.Text = "إلغاء"
        ElseIf LinkLabel4.Text = "إلغاء" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            LinkLabel4.Text = "تصفية"
            Me.SalaryRecordsBindingSource.Position = pos
        End If

    End Sub

    Private Sub إلغاءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إلغاءToolStripMenuItem.Click
        IsEngCooperationRadioButton.Checked = False
        IsEngFarmRadioButton.Checked = False
    End Sub

    Private Sub حساباتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حساباتToolStripMenuItem.Click
        Mymanageuser = New ManageUsers
        Mymanageuser.ShowDialog(Me)
    End Sub

    Private Sub تغييرحسابيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تغييرحسابيToolStripMenuItem.Click
        myuserAcount = New UserAcount
        myuserAcount.ShowDialog()
    End Sub

    Private Sub حسابالراتبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حسابالراتبToolStripMenuItem.Click
        ToolStripButton1.PerformClick()
    End Sub

    Private Sub فتحسجلاتشهرجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فتحسجلاتشهرجديدToolStripMenuItem.Click
        ToolStripButton3.PerformClick()
    End Sub

    Private Sub إغلاقالراتبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إغلاقالراتبToolStripMenuItem.Click
        ToolStripButton4.PerformClick()
    End Sub
    Private Sub CheckPermision()
        If Not Cu_User.IsAdmin Then
            If Not Cu_User.AllowModify Then
                Me.SalaryRecordsBindingSource.SuspendBinding()
            End If
            LinkLabel2.Enabled = False
            إدارةالتقاريرToolStripMenuItem.Enabled = Cu_User.AllowPrint
            إدخالاتموحدةToolStripMenuItem.Enabled = False
            ثوابتالمفرداتToolStripMenuItem.Enabled = False
            ضريبةالدخلToolStripMenuItem.Enabled = False
            حساباتToolStripMenuItem.Enabled = False
            'ضبطToolStripMenuItem.Enabled = False
            حذفسجلعاملToolStripMenuItem.Enabled = False
            مفرداتمتغيرةToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub أخذنسخةاحطياطيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles أخذنسخةاحطياطيةToolStripMenuItem.Click
        Mybackup = New BackupDataFrm
        Mybackup.Show()
        Me.Close()
    End Sub

    Private Sub التطبيقToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles التطبيقToolStripMenuItem.Click
        mysplashscreen = New SplashScreen1
        Dim btn As New Button
        btn.Text = "X"
        btn.Visible = True
        btn.Size = New Point(20, 20)
        btn.Left = 0
        btn.Top = 0
        AddHandler btn.Click, AddressOf btnclik
        mysplashscreen.Timer1.Enabled = False
        mysplashscreen.ApplicationTitle.Text = My.Settings.ActibeFor
        mysplashscreen.Label5.Text = "النسخة مرخصة"
        ' mysplashscreen.PictureBox1.Controls.Add(btn)
        mysplashscreen.Show()
        ' MsgBox("برنامج رواتب العاملين في محطة كهرباء بانياس")
    End Sub
    Private Sub btnclik()
        mysplashscreen.Close()
    End Sub

    Private Sub شطبموظفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles شطبموظفToolStripMenuItem.Click
        MyCancelRestore = New CancelRetoreFrm
        MyCancelRestore.LblEmpID.Text = EmpIDTextBox.Text
        MyCancelRestore.LBLEmpName.Text = FullNameLabel1.Text
        MyCancelRestore.ShowDialog(Me)
        If MyCancelRestore.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.SalaryRecordsBindingSource.RemoveCurrent()
            SendKeys.Send("{ENTER}")
        End If
        Me.Button6.PerformClick()
    End Sub

    Private Sub عرضالسجلاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضالسجلاتToolStripMenuItem.Click
        MyCancelRestore = New CancelRetoreFrm
        MyCancelRestore.TabControl1.SelectedTab = MyCancelRestore.TabPage2
        MyCancelRestore.ShowDialog(Me)
        If MyCancelRestore.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)

        End If
    End Sub

    Private Sub آلةحاسبةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles آلةحاسبةToolStripMenuItem.Click
        Shell("Calc")
    End Sub

    Private Sub ToolStripStatusLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel5.Click
        If DataGridView1.Visible Then
            DataGridView1.Hide()
            ToolStripStatusLabel5.Text = "إظهار قائمة سجلات الموظفين"
        Else
            DataGridView1.Show()
            ToolStripStatusLabel5.Text = "إخفاء قائمة سجلات الموظفين"
        End If
    End Sub

    Private Sub FullNameLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullNameLabel1.TextChanged
        ToolStripStatusLabel1.Text = FullNameLabel1.Text
        StatusStrip1.Refresh()
    End Sub

    Private Sub ميزانالراتبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ميزانالراتبToolStripMenuItem.Click
        Mybalancereport = New BalanceReport
        Mybalancereport.Show()
    End Sub

    Private Sub إلغــاءToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles إلغــاءToolStripMenuItem.Click
        If Cu_User.IsAdmin Then
            ClearSolfa(ContextMenuStrip2.SourceControl)
        Else
            MsgBox("لا تملك الصلاحية")
        End If

    End Sub
    Private Sub ClearSolfa(ByVal ctrls As Control)
        For Each ctrl As Control In ctrls.Controls
            If TypeOf ctrl Is TextBox Then ctrl.Text = 0
        Next
    End Sub

    Private Sub أسماءالمراكزToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles أسماءالمراكزToolStripMenuItem.Click
        MyCenterName = New CenterNamesFrm
        MyCenterName.Show()
    End Sub

    Private Sub سعرالطوناجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles سعرالطوناجToolStripMenuItem.Click
        mutablesetting = New MutableSettingFrm
        mutablesetting.ShowDialog()
        'TODO: This line of code loads data into the 'MutableDataSet.MutableSetting' table. You can move, or remove it, as needed.
        'Me.MutableSettingTableAdapter.Fill(Me.MutableDataSet.MutableSetting)
    End Sub

    Private Sub نسبةتعويضإختصاصطبيعةعملToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نسبةتعويضإختصاصطبيعةعملToolStripMenuItem.Click
        Specializeset = New SpecializAetting
        Specializeset.ShowDialog()
        Me.TypeSpecializeValuesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.TypeSpecializeValues)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.SpecializeValues' table. You can move, or remove it, as needed.
        Me.SpecializeValuesTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SpecializeValues)
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.CenterNames' table. You can move, or remove it, as needed.
    End Sub
    Private Sub SpecializeValuesBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecializeValuesBindingSource.CurrentChanged
        'SpecializeValues()
    End Sub
    Private Sub SpecializeValues()
        If SpecializeValuesBindingSource.Current Is Nothing Then Exit Sub
        Dim Sdrwvalue As String
        Dim SDrw As DataRowView = SpecializeValuesBindingSource.Current
        Sdrwvalue = SDrw("SpecializeValue")
        If IsNumeric(Sdrwvalue) Then
            If Sdrwvalue > 0 Then
                If SlitSalaryTextBox.Text = "" Then Exit Sub
                Me.SpecializeTextBox.Text = IIf(IsNumeric(Sdrwvalue), (SlitSalaryTextBox.Text * Sdrwvalue) / 100, 0)
            End If
        End If
        ' SDrw = Nothing
    End Sub
    Private Sub TypeSpecializeValuesBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeSpecializeValuesBindingSource.CurrentChanged
        'TypeSpecializeValues()
    End Sub
    Private Sub TypeSpecializeValues()
        If TypeSpecializeValuesBindingSource.Current Is Nothing Then Exit Sub
        Dim Sdrwvalue As String
        Dim SDrw As DataRowView = TypeSpecializeValuesBindingSource.Current
        Sdrwvalue = SDrw("TypeSpecializeValue")
        If IsNumeric(Sdrwvalue) Then
            If Sdrwvalue > 0 Then
                If SlitSalaryTextBox.Text = "" Then Exit Sub
                Me.TypeSpecializeTextBox.Text = Convert.ToDouble(IIf(IsNumeric(Sdrwvalue), (SlitSalaryTextBox.Text * Sdrwvalue) / 100, 0))
            End If
        End If
        ' SDrw = Nothing
    End Sub

    Private Sub MutableSettingBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MutableSettingBindingSource.CurrentChanged
        'MutableCalc()
    End Sub
    'تم الغاء عمل الإجرائية
    Private Sub MutableCalc()
        Dim Mdays, Mcost, Tcost, Mlimit As String
        If Me.MutableSettingBindingSource.Current Is Nothing Then Exit Sub
        Dim Mdrv As DataRowView = Me.MutableSettingBindingSource.Current
        Mcost = IIf(IsNumeric(Mdrv("MutableCost")), Mdrv("MutableCost"), 0)
        Mlimit = IIf(IsNumeric(Mdrv("MutableLimited")), Mdrv("MutableLimited"), 0)
        Mdays = IIf(IsNumeric(MutableDaysTextBox.Text), MutableDaysTextBox.Text, 0)
        MutableCostTextBox.Text = Mcost
        Tcost = Mcost * Mdays
        If CInt(Tcost) > CInt(Mlimit) Then Tcost = Mlimit
        MutableTextBox.Text = Tcost
    End Sub

    Private Sub DriveTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DriveTextBox.TextChanged

    End Sub

    Private Sub IsEngCooperationRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IsEngCooperationRadioButton.CheckedChanged

    End Sub


    Private Sub AgentEmpCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AgentEmpCheckBox.CheckedChanged
        If IsManagerCheckBox.Checked = True Then
            Me.IsContractCheckBox.Checked = False
            Me.IsSoldurCheckBox.Checked = False
            Me.AgentEmpCheckBox.Checked = False
        End If
    End Sub

    Private Sub IsContractCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IsContractCheckBox.CheckedChanged
        If IsContractCheckBox.CheckState = CheckState.Checked Then
            IsContractCheckBox.Visible = True
        Else
            IsContractCheckBox.Visible = False
        End If
        If IsManagerCheckBox.Checked = True Then
            Me.IsContractCheckBox.Checked = False
            Me.IsSoldurCheckBox.Checked = False
            Me.AgentEmpCheckBox.Checked = False
        End If
        If IsContractCheckBox.CheckState = CheckState.Checked Then
            If Not Cu_User.IsAdmin Then
                IsContractCheckBox.Checked = True
            End If

        End If
    End Sub

    Private Sub IsSoldurCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IsSoldurCheckBox.CheckedChanged
        If IsManagerCheckBox.Checked = True Then
            Me.IsContractCheckBox.Checked = False
            Me.IsSoldurCheckBox.Checked = False
            Me.AgentEmpCheckBox.Checked = False
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim pos As Integer = Me.SalaryRecordsBindingSource.Position
        If LinkLabel5.Text = "تصفية" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            Me.SalaryRecordsBindingSource.Filter = "CenterID=" & IIf(IsNothing(EmpCompanyComboBox.SelectedValue), -1, EmpCompanyComboBox.SelectedValue) & ""
            Label9.Text = Me.SalaryRecordsBindingSource.Count
            LinkLabel5.Text = "إلغاء"
        ElseIf LinkLabel5.Text = "إلغاء" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            LinkLabel5.Text = "تصفية"
            Me.SalaryRecordsBindingSource.Position = pos
            Label9.Text = Me.SalaryRecordsBindingSource.Count
        End If
    End Sub

    Private Sub IsOverWorkOhrCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles IsOverWorkOhrCheckBox.CheckedChanged
        If IsOverWorkOhrCheckBox.CheckState = CheckState.Unchecked Then
            Me.OverWorkDayTextBox.Text = 0
            Me.OverWorkDayTextBox.ReadOnly = True
            Me.OverWorkNightTextBox.Text = 0
            Me.OverWorkNightTextBox.ReadOnly = True
            Me.OverWorkOhrTextBox.Text = 0
            Me.OverWorkValueTextBox.Text = 0
        Else
            Me.OverWorkDayTextBox.ReadOnly = False
            Me.OverWorkNightTextBox.ReadOnly = False
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("سيقوم البرنامج بتحديث سقف المساعي لجميع العاملين ضمن المركز", "RAMITTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
            Dim cmd As New SqlCommand("", cnn)
            Dim cid, fvalue As Integer
            cid = Me.EmpCompanyComboBox.SelectedValue
            fvalue = Me.ForecTopWvalueTextBox.Text
            Try
                ACtiveTrigers(False)
                cnn.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update SalaryRecords set ForecTopWvalue= " & fvalue & " where CenterID=" & cid & ""
                cmd.ExecuteNonQuery()
                cnn.Close()
                cmd = Nothing
            Catch ex As Exception
                cnn.Close()
                MsgBox(ex.Message)
            End Try
        End If
      
        ACtiveTrigers(True)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If MessageBox.Show("سيقوم البرنامج بتحديث قيمة الإختصاص لجميع العاملين ضمن المركز", "RAMITTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
            Dim cmd As New SqlCommand("", cnn)
            Dim SpID, SpVal, cid As Integer
            SpID = Me.SpecializeIDComboBox.SelectedValue
            SpVal = Me.SpecializeTextBox.Text
            cid = Me.EmpCompanyComboBox.SelectedValue
            Try
                ACtiveTrigers(False)
                cnn.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update SalaryRecords set SpecializeID= " & SpID & "  where CenterID=" & cid & ""
                cmd.ExecuteNonQuery()
                cnn.Close()
                cmd = Nothing
                loaddata()
            Catch ex As Exception
                MsgBox(ex.Message)
                cnn.Close()
            End Try
        End If
        ACtiveTrigers(True)
     
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If MessageBox.Show("سيقوم البرنامج بتحديث قيمة طبيعة عمل لجميع العاملين ضمن المركز", "RAMITTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
            Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
            Dim cmd As New SqlCommand("", cnn)
            Dim SpID, SpVal, cid As Integer
            SpID = Me.TypeSpecializeIDComboBox.SelectedValue
            SpVal = Me.TypeSpecializeTextBox.Text
            cid = Me.EmpCompanyComboBox.SelectedValue
            Try
                ACtiveTrigers(False)
                cnn.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update SalaryRecords set TypeSpecializeID= " & SpID & "  where CenterID=" & cid & ""
                cmd.ExecuteNonQuery()
                cnn.Close()
                cmd = Nothing
                loaddata()
            Catch ex As Exception
                MsgBox(ex.Message)
                cnn.Close()
            End Try
        End If

        ACtiveTrigers(True)
    End Sub

    Private Sub قسمالتحويلاتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles قسمالتحويلاتToolStripMenuItem.Click
        Dim f As New TransReports
        f.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim cmd As New SqlCommand("", cnn)
        Dim Rval As Integer '= IIf(IsNumeric(TextBox12.Text), TextBox12.Text, 0)
        If Not IsNumeric(TextBox12.Text) And TextBox12.Text = 0 Then
            MsgBox("القيمة المدخلة غير صالحة")
            Exit Sub
        Else
            Rval = CInt(TextBox12.Text)
            If MessageBox.Show("هل تريد بالتأكيد تطبيق قيمة حقل إعانة م.ز على جميع سجلات المهندسين الزراعيين ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Try
                    ACtiveTrigers(False)
                    cnn.Open()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "update SalaryRecords set retirefarmeng= " & Rval & "  where IsEngFarm=1"
                    cmd.ExecuteNonQuery()
                    cnn.Close()
                    cmd = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
       
        ACtiveTrigers(True)

    End Sub
    Private Sub عرضأرشيفالأحداثToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles عرضأرشيفالأحداثToolStripMenuItem.Click
        Dim f As New UsersArchive
        f.Show()
    End Sub

    Private Sub الإتصالالمباشرمعالبياناتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles الإتصالالمباشرمعالبياناتToolStripMenuItem.Click
        MsgBox("الربط الشبكي غير متاح حاليا")
    End Sub

    Private Sub تصديرإلىملفToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles تصديرإلىملفToolStripMenuItem.Click
        Dim f As New TransSalaries
        f.Show()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim cmd As New SqlCommand("", cnn)
        Dim Sql As String
        If Not IsDate(EngCooperationTaxDateTextBox.Text) Then
            MsgBox("التاريخ المخل غير صحيح")
            Exit Sub
        End If
        If Not IsNumeric(ECT_TotalTextBox.Text) Or Not IsNumeric(TextBox6.Text) Then
            MsgBox("قيمة الرسم أو الحسم الشهري غير صالحة")
            Exit Sub
            If ECT_TotalTextBox.Text < TextBox6.Text Then
                MsgBox("يجب ان تكون قيمة الرسم اكبر أو تساوي من الحسم الشهري")
                Exit Sub
            End If
        End If
        If MessageBox.Show("هل تريد بالتأكيد تحديث قيم جميع السجلات للمهندسين", "RAMITTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Sql = "update SalaryRecords Set "
            Sql = Sql + " EngCooperationTaxDate=N'" + EngCooperationTaxDateTextBox.Text + "',ECT_Total=" + ECT_TotalTextBox.Text.ToString + ",ECT_Discount=" + TextBox6.Text.ToString + " ,ECT_Mounts= " + ECT_TotalTextBox.Text.ToString + ""
            Sql = Sql + " where IsEngCooperation=1" '+ IIf(IsEngCooperationRadioButton.Checked, 1, 0) + ""  
            Try
                ACtiveTrigers(False)
                cnn.Open()
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
                cnn.Close()
            End Try
            cnn.Close()
        End If

        ACtiveTrigers(True)

    End Sub

    Private Sub تحديثالبياناتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles تحديثالبياناتToolStripMenuItem.Click
        Me.TabControl1.Enabled = False
        Dim cupos As Integer = IIf(IsNumeric(EmpIDTextBox.Text), EmpIDTextBox.Text, 0)
        loaddata()
        Me.SalaryRecordsBindingSource.Position = Me.SalaryRecordsBindingSource.Find("EmpId", cupos)
        Me.TabControl1.Enabled = True
        'Me.SalaryReportBindingSource.Find(cupos)
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged, RadioButton7.CheckedChanged, RadioButton6.CheckedChanged, RadioButton5.CheckedChanged, RadioButton4.CheckedChanged, RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        Select Case sender.name
            Case "RadioButton1"
                mSelectRecords("IsWorkers", "0")
                Label31.Text = "سجلات المستخدمين"
            Case "RadioButton2"
                mSelectRecords("IsWorkers", "1")
                Label31.Text = "سجلات العمالية"
            Case "RadioButton3"
                mSelectRecords("IsContract", "1")
                Label31.Text = "سجلات العقود مؤقتة"
            Case "RadioButton4"
                mSelectRecords("IsEngeneer", "1")
                Label31.Text = "سجلات جميع المهندسين"
            Case "RadioButton5"
                mSelectRecords("IsSoldur", "1")
                Label31.Text = "سجلات عسكريين احطياط"
            Case "RadioButton6"
                mSelectRecords("AgentEmp", "1")
                Label31.Text = "سجلات العقود السنوية"
            Case "RadioButton7"
                Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)
                Label9.Text = Me.SalaryRecordsBindingSource.Count
                Label31.Text = "جميع سجلات العاملين في الشركة"
            Case "RadioButton8"
                mSelectRecords("IsManager", "1")
                Label31.Text = "سجلات المدراء فقط"
                GroupBoxManager.Visible = True
        End Select
    End Sub
    Private Sub mSelectRecords(ByRef Fldname As String, ByRef val As String)
        Dim cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim cmd As New SqlCommand("", cnn)
        Dim dr As SqlDataReader
        Dim Cids As String = "0"
        Dim uid As String = Cu_User.UserID.ToString
        Try
            cnn.Open()
            cmd.CommandText = "select * from UsersAccCenters where UserID=" + uid + ""
            dr = cmd.ExecuteReader
            While dr.Read
                Cids = Cids & "," & dr("CenterID")
            End While
            dr.Close()
            cmd.CommandText = ""
            cmd.CommandText = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fillby]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[fillby]"
            cmd.ExecuteNonQuery()
            cmd.CommandText = UserDataSql(Cids)
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.SalaryRecordsTableAdapter.FillBy(Me.BaniasEnergyDBDataSet.SalaryRecords, Fldname, val)
        Label9.Text = Me.SalaryRecordsBindingSource.Count
    End Sub
    Private Function UserDataSql(ByRef fcids As String) As String
        Dim r As String
        r = "  CREATE PROCEDURE [dbo].[fillby] @FldN nvarchar(15) ,@val int AS BEGIN exec (' "
        r = r + "select * "
        'r = r + " SELECT        EmpID, FinanceID, DirectorateID, OfficeID, Fname, Mname, Lname, agentEmp, SlitSalary, Allowance, RepaymentFamily, RF_HaveWife, RF_child1, RF_child2, "
        'r = r + " RF_child3, RF_OtherChild, IsEngeneer, DangerWork, BacklogReturn, Impulse, Gift, TotalTax, SalaryTax, BacklogRecover, TotalTakeOuts, IsSocialInsurance,"
        'r = r + " SocialInsurance, IsCooperateBox, CooperateBox, ISCooperationWorkers, CooperationWorkers, IsEngCooperation, EngCooperation, IShabitation, IsAssistBox,"
        'r = r + " AssistBox, IsEndService, EndService, AbsenceNumber, absence, IntegratorSolidarity, IsSolidaritySocial, SolidaritySocial, SportClup, Incubation, Typo, IsDeathAssist,"
        'r = r + " DeathAssist, HoldServiceDate, HS_Total, HS_Mounths, HS_Discount, Datepenalty, P_Total, P_Mounths, P_Discount, DiscountTaskDate, DT_Total, DT_Mounts,"
        'r = r + " DT_Discount, RodDate, R_Total, R_Mounths, R_Discount, CooperationLoanDate, CL_Total, CL_Mounths, CL_Discount, WorkersLoanDate, WL_Total, WL_Mounts,"
        'r = r + " WL_Discount, EngCooperationTaxDate, ECT_Total, ECT_Mounts, ECT_Discount, AkariBankDate, AB_Total, AB_Mounts, AB_Discount, TasleefBankDate, TB_Total,"
        'r = r + " TB_Mounts, TB_Discount, TawfeerBankDate, TWB_Total, TWB_Mounts, TWB_Discount, TajzahLoanDate, TL_Total, TL_Mounts, TL_Discount, RecoveryDate,"
        'r = r + " RC_Total, RC_Mounts, RC_Discount, FullSalary, SumDiscounts, TotalSalary, SalaryYear, SalaryMount, UserID, CreateDate, LastModify, MarkRecord, FullName,"
        'r = r + "  ControlID, TSpecialize, TaxationID, SalaryConstants, habitationPerc, habitation, CardNo, Notes, IsEngFarm, TaxFarmEng, IsstipendInsurance, EmpCompany,"
        'r = r + " EmpHelth, stipendInsurance, WorkableEmp, CleanerTax, OldSlitSalary, STindex, Tindex, IsManager, ManagerTax, NoTax, Slave_DeathAssist, Slave_AssistBox,"
        'r = r + "  Slave_SolidaritySocial, EmpClass, IsSoldur, NoSalaryCost, NoSalaryDays, salarysame, mutableCost, mutableDays, mutableClass, mutable, HealthVacationDays,"
        'r = r + " Night, drive, IsContract, CenterID, HealthVacationCost, TypeSpecializeID, SpecializeID, Qhelp, retirefarmeng, Spcar, Amanager, Nmanager, Pmanager, SpHouse,"
        'r = r + "  OverWorkValue, OverWorkOhr, OverWorkDay, OverWorkNight, IsOverWorkOhr, ForecTopWvalue, Specialize, TypeSpecialize, Authority, ReturnSpecialize, Qhelp1,"
        'r = r + "  Qhelp2, MarkNo,IsWorkers,ContractSdate,ContractEdate,ContractAbsenc,ContractAbsencVa,ContractNo "
        r = r + " FROM            SalaryRecords  where CenterID in(" + fcids + " ) and  '+ @FldN +' ='+ @val +'  order by EmpID"
        r = r + "      ') END"
        Return r
    End Function
    Private Sub UserRecorsAllows()
        Dim sqlFld As String
        With Cu_User
            If .AllowSalary = True Then
                sqlFld = "IsWorkers"
                mSelectRecords(sqlFld, 0)
                Label31.Text = "سجلات المستخدمين"
            End If

            If .AllowWorkers = True Then
                sqlFld = "IsWorkers"
                mSelectRecords(sqlFld, 1)
                Label31.Text = "سجلات العمالية"
            End If


            If .AllowAgents = True Then
                sqlFld = "AgentEmp"
                mSelectRecords(sqlFld, 1)
                Label31.Text = "سجلات العقود السنوية"
            End If


            If .AllowEngeneers = True Then
                sqlFld = "IsEngeneer"
                mSelectRecords(sqlFld, 1)
                Label31.Text = "سجلات المهندسين"
            End If


            If .AllowManagers = True Then
                sqlFld = "IsManager"
                mSelectRecords(sqlFld, 1)
                Label31.Text = "سجلات مدراء الشركة"
            End If


            If .AllowContracts = True Then
                sqlFld = "IsContract"
                mSelectRecords(sqlFld, 1)
                Label31.Text = "سجلات العقود المؤقتة"
            End If

            If .AllRecords = True Then
                sqlFld = "1"
                mSelectRecords(sqlFld, 1)
                Label31.Text = "جميع السجلات"
            End If
        End With

    End Sub

    Private Sub IsContractCheckBox_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles IsContractCheckBox.CheckStateChanged
        If IsContractCheckBox.CheckState = CheckState.Checked Then
            Me.GroupBox29.Visible = True
        Else
            Me.GroupBox29.Visible = False
        End If
    End Sub

    Private Sub تقاريرالعقودالمؤقتةToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles تقاريرالعقودالمؤقتةToolStripMenuItem.Click
        Dim cf As New ContractsReports
        cf.Show()
    End Sub

    Private Sub عرضفيشالشطبToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles عرضفيشالشطبToolStripMenuItem.Click
        MyLastSalaryReports = New LastSalaryReports
        MyLastSalaryReports.Show(Me)
    End Sub

    Private Sub بيانمفرداتالراتبToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles بيانمفرداتالراتبToolStripMenuItem.Click
        Dim OldRpt As New TransReports
        OldRpt.ISoldRecords.Checked = True
        OldRpt.Show()
        OldRpt.ISoldRecords.Checked = True
        OldRpt.GroupBox2.Visible = True
        OldRpt.GroupBox1.Visible = False
        OldRpt.GroupBox2.Dock = DockStyle.Bottom
    End Sub

    Private Sub جداولالرواتبToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles جداولالرواتبToolStripMenuItem.Click
        Dim f As New FrmPloterTbl
        f.IsOldSalary.CheckState = CheckState.Checked
        f.Show()
    End Sub

    Private Sub متغيراتالطوناجToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles متغيراتالطوناجToolStripMenuItem.Click
        Dim f As New Create_Mutable
        f.Show()
    End Sub

    Private Sub CrystalReportConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrystalReportConnectionToolStripMenuItem.Click
        Dim f As New CrystalConnection
        f.Show()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        TextBox1.Focus()

    End Sub

    Private Sub BtnFirst_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrev.Click, BtnNext.Click, BtnLast.Click, BtnFirst.Click
        Try
            Select Case sender.name
                Case "BtnFirst"
                    Me.SalaryRecordsBindingSource.MoveFirst()
                Case "BtnLast"
                    Me.SalaryRecordsBindingSource.MoveLast()
                Case "BtnNext"
                    Me.SalaryRecordsBindingSource.MoveNext()
                Case "BtnPrev"
                    Me.SalaryRecordsBindingSource.MovePrevious()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub استمارةعلامةالحوافزToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles استمارةعلامةالحوافزToolStripMenuItem.Click
        Dim f As New MarkDriveFrm
        f.Show()
    End Sub

    Private Sub علاماتالحوافزالإنتاجيةToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles علاماتالحوافزالإنتاجيةToolStripMenuItem.Click
        Dim f As New DriveAcounts
        f.Show()
    End Sub

    Private Sub IsManagerCheckBox_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles IsManagerCheckBox.CheckStateChanged
        If IsManagerCheckBox.CheckState = CheckState.Unchecked Then
            Me.GroupBoxManager.Visible = False
            Me.PmanagerRadioButton.Checked = False
            Me.AmanagerRadioButton.Checked = False
            Me.NmanagerRadioButton.Checked = False
        ElseIf IsManagerCheckBox.CheckState = CheckState.Checked Then
            Me.GroupBoxManager.Visible = True
            Me.IsContractCheckBox.Checked = False
            Me.IsSoldurCheckBox.Checked = False
            Me.AgentEmpCheckBox.Checked = False
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Dim strsql As String
        Dim cn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim cm As New SqlCommand("", cn)
        strsql = "declare @date date "
        strsql = strsql + " select @date= Sdate from CreateMutable"
        strsql = strsql + " update SalaryRecords set mutableDays=("
        strsql = strsql + " select datediff(day, dateadd(day, 1-day(@date), @date),"
        strsql = strsql + "  dateadd(month, 1, dateadd(day, 1-day(@date), @date))) )"
        Try
            cn.Open()
            cm.CommandText = strsql
            If MessageBox.Show("سيقوم البيرنامج بإدخال عدد الورديات بناء على تاريخ المتحول لجميع العاملين", "RAMITTA", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cm.ExecuteNonQuery()
                loaddata()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'If e.ColumnIndex = 1 Then
        '    Select Case Me.MarkNoTextBox.Text
        '        Case "0"
        '            Me.DataGridView1.CurrentCell.Style.BackColor = Color.Green
        '        Case "1"
        '            Me.DataGridView1.CurrentCell.Style.BackColor = Color.Red
        '        Case "2"
        '            Me.DataGridView1.CurrentCell.Style.BackColor = Color.White
        '    End Select

        'End If
    End Sub

    Private Sub MarkNoTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles MarkNoTextBox.TextChanged
        'Select Case Me.MarkNoTextBox.Text
        '    Case "0"
        '        Me.DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.Green
        '    Case "1"
        '        Me.DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.Red
        '    Case "2"
        '        Me.DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.White
        'End Select
        'Me.DataGridView1.Refresh()
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.MarkNoTextBox.Text = "1" Then
                Me.DataGridView1.SelectedRows(0).Cells("MarkRecordDataGridViewImageColumn").Style.BackColor = Color.Red
                Me.MarkNoTextBox.Text = "0"
            ElseIf Me.MarkNoTextBox.Text = "0" Then
                Me.DataGridView1.SelectedRows(0).Cells("MarkRecordDataGridViewImageColumn").Style.BackColor = Color.Green
                Me.MarkNoTextBox.Text = "2"
            ElseIf Me.MarkNoTextBox.Text = "2" Then
                Me.DataGridView1.SelectedRows(0).Cells("MarkRecordDataGridViewImageColumn").Style.BackColor = Color.White
                Me.MarkNoTextBox.Text = "1"
            Else
                ' Me.DataGridView1.SelectedRows(0).Cells("MarkRecordDataGridViewImageColumn").Value = My.Resources.F
                'Me.MarkNoTextBox.Text = "1"
            End If
            'Dim Eid As Integer = CInt(Me.EmpIDTextBox.Text)
            'Try
            '    Me.SalaryRecordsTableAdapter.UpdateMarNo(Me.MarkNoTextBox.Text, Me.DataGridView1.SelectedRows(0).Cells("MarkRecordDataGridViewImageColumn").Value, Eid)
            'Catch ex As Exception
            'End Try
            Me.DataGridView1.Refresh()
        End If
    End Sub

    Private Sub DataGridView1_CellPainting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        'Select Case Me.MarkNoTextBox.Text
        '    Case "0"
        '        Me.DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.Green
        '    Case "1"
        '        Me.DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.Red
        '    Case "2"
        '        Me.DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.White
        'End Select
        '' Me.DataGridView1.Refresh()
    End Sub

    Private Sub الدعمToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles الدعمToolStripMenuItem.Click
        MsgBox("ميزة الدعم البعيد غير متوفرة في هذة النسخة")
    End Sub

    Private Sub راميتاToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles راميتاToolStripMenuItem.Click

    End Sub

    Private Sub نقطةاستعادةToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles نقطةاستعادةToolStripMenuItem.Click
        Dim f As New RestorPointsFrm
        If Cu_User.IsAdmin Then
            f.Show()
        End If
    End Sub

    Private Sub بيانمقترضToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles بيانمقترضToolStripMenuItem.Click
        Dim f1 As GivenReportFrm
        f1 = New GivenReportFrm
        f1.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripComboBox1.Click
        If ToolStripComboBox1.Text = "أدخل رقم مركز" Then
            ToolStripComboBox1.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        If ToolStripButton6.Text = "تصفية حسب المركز" Then
            If IsNumeric(ToolStripComboBox1.Text) Then
                Me.SalaryRecordsBindingSource.RemoveFilter()
                Me.SalaryRecordsBindingSource.Filter = "CenterID=" + ToolStripComboBox1.Text + ""
                Label9.Text = Me.SalaryRecordsBindingSource.Count
            Else
                MsgBox("رمز المركز غير صالح")
            End If
            ToolStripButton6.Text = "إلغاء التصفية"
        ElseIf ToolStripButton6.Text = "إلغاء التصفية" Then
            Me.SalaryRecordsBindingSource.RemoveFilter()
            Label9.Text = Me.SalaryRecordsBindingSource.Count
            ToolStripButton6.Text = "تصفية حسب المركز"
        End If
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Dim DmiFrm As New DriveMultiInput
        DmiFrm.TextBox3.Text = 0
        DmiFrm.ShowDialog()
    End Sub

    Private Sub تحليلالإدخالاتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles تحليلالإدخالاتToolStripMenuItem.Click
        Dim DFrm As New DiagFrm
        DFrm.Show()
    End Sub

    Private Sub حذفأرشيفأحداثالبياناتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles حذفأرشيفأحداثالبياناتToolStripMenuItem.Click

    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Dim val As String
        Dim slt As Integer = SlitSalaryTextBox.Text
        val = InputBox("أدخل قيمة العلاوة التي ستضاف الى الراتب المقطوع", "RAMITTA")
        If IsNumeric(val) AndAlso val.Length < 5 Then
            slt = slt + val
            SlitSalaryTextBox.Text = slt
        Else
            MsgBox("القيمة المدخلة غير صالحة")
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Dim DmiFrm As New DriveMultiInput
        DmiFrm.TextBox3.Text = 1
        DmiFrm.ShowDialog()
    End Sub

    Private Sub استثناءعلامةالحوافزToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles استثناءعلامةالحوافزToolStripMenuItem.Click
        Dim f As New DriveException
        f.Show()

    End Sub

    Private Sub TabControl1_Selected(sender As System.Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If e.TabPageIndex = 4 Then
            Me.SalaryReportBindingSource.RemoveFilter()
            Me.SalaryReportBindingSource.Filter = "EmpID= " & CuEmpID & " "
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Dim val As String
        Dim slt As Integer = OldSlitSalaryTextBox.Text
        val = InputBox("أدخل قيمة العلاوة التي ستضاف الى راتب التعويضات", "RAMITTA")
        If IsNumeric(val) AndAlso val.Length < 5 Then
            slt = slt + val
            OldSlitSalaryTextBox.Text = slt
        Else
            MsgBox("القيمة المدخلة غير صالحة")
        End If
    End Sub

    Private Sub تقريرالإجرةالساعيةللموظفينToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles تقريرالإجرةالساعيةللموظفينToolStripMenuItem.Click
        Dim f As New OverWorkORpt
        f.ShowDialog()
    End Sub
End Class
