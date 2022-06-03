Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Module MainMDL

#Region "MyFormsDeclear"
    Public Mymainfrm As MainFrm
    Public Myloginfrm As LogInFrm
    Public Mymanageuser As ManageUsers
    Public Myopensalary As OpenSalaryFrm
    Public MyrecoverFromEmp As RecoverFromEmpFrm
    Public Myreturntoemp As ReturnToEmpFrm
    Public Mysalaryconstants As SalaryConstantFrm
    Public Mysalarytax As SalaryTaxFrm
    Public Mytakeouts As TakeOutsFrm
    Public MyCalculatingSalaries As CalculatingSalaries
    Public MyCheckSalaryFrm As CheckSalaryFrm
    Public MyResultCheckFrm As ResultCheckFrm
    Public MyAdvancedSettings As AdvancedSettings
    Public MyInsertSalary As InsertLastSalaryFrm
    Public MysalaryReports As SalaryReports
    Public MymanageReports As ManageReports
    Public Myupdateforall As UodateForAllFrm
    Public MyLastSalaryReports As LastSalaryReports
    Public myuserAcount As UserAcount
    Public Mybackup As BackupDataFrm
    Public MyCancelRestore As CancelRetoreFrm
    Public Mybalancereport As BalanceReport
    Public mysplashscreen As SplashScreen1
    Public MyCenterName As CenterNamesFrm
    Public mutablesetting As MutableSettingFrm
    Public Specializeset As SpecializAetting
#End Region
    Dim SqlCnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim SqlCmd As SqlCommand
    Dim Rd As SqlDataReader
    Public Cu_User As UsersClass
    Public Cu_Tax As TaxClass
    Public Cu_Constants As ConstantClass
    Public MyDirectorate As DirectorateFrm
    Public Myofficers As OfficersFrm
    Public SalaryMounth, SalaryYear As Integer
    Public SalaryState As Boolean
    Public ControlID As Integer = 0
    Public CuEmpID As Integer = 100375
    Public MyAppPath As String = Application.StartupPath
    Public logon1 As New CrystalDecisions.Shared.TableLogOnInfo
    Public logonold As New CrystalDecisions.Shared.TableLogOnInfo
    'Public logon1s As New CrystalDecisions.Shared.TableLogOnInfos

    Public Sub LoadCRVconnection()
        logon1.ConnectionInfo.DatabaseName = My.Settings.CRVDBname '"SalaryLatDB"
        logon1.ConnectionInfo.ServerName = My.Settings.CRVservername ' "WIN-O7R3FJDV768"
        logon1.ConnectionInfo.UserID = My.Settings.CRVuserid ' "sa"
        logon1.ConnectionInfo.Password = My.Settings.CRVpw ' "latakiaport@2017"
        logon1.ConnectionInfo.IntegratedSecurity = My.Settings.CRVisecurity
        '-------
        logonold.ConnectionInfo.DatabaseName = "SalaryLatDB"
        logonold.ConnectionInfo.ServerName = "ramitta-pc"
        logonold.ConnectionInfo.UserID = "Fadia"
        logonold.ConnectionInfo.Password = "microsoft@1976"
        logonold.ConnectionInfo.IntegratedSecurity = False
    End Sub
    Public Function GetAgentM(ByVal m As Integer) As Integer
        If m = 1 Then
            m = 12
        Else
            m -= 1
        End If
        Return m
    End Function
    Public Function GetAgentY(ByVal y As Integer, ByVal m As Integer) As Integer
        If m = 1 Then
            y -= 1
        Else
            y = y
        End If
        Return y
    End Function

    Public Sub LoadSalaryDate()
        Dim Cid As Integer
        SqlCnn.Open()
        SqlCmd = New SqlCommand("Select top 1 ControlID from SalaryRecords", SqlCnn)
        SqlCmd.CommandType = CommandType.Text
        Rd = SqlCmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = False Then
            MsgBox("لا تحتوي قاعدة البيانات على أي سجل موظف!" + Chr(13) + "الرجاء إدخال سجلات الموظفين ومن ثم فتح راتب الشهر")
            Rd.Close()
            SqlCmd = Nothing
            SqlCnn.Close()
            Exit Sub
        End If
        If IsDBNull(Rd("ControlID")) Then
            MsgBox("لم يكشف البرنامج عن أي شهر مفتوح الرجاء فتح شهر راتب")
            SalaryYear = Now.Year
            Rd.Close()
            SqlCmd = Nothing
            SqlCnn.Close()
            Myopensalary = New OpenSalaryFrm
            Myopensalary.Show()
            Myopensalary.TopMost = True
            'Application.Exit()
            SqlCnn.Close()
            Exit Sub
        End If
        Cid = Rd("ControlID")
        Rd.Close()
        SqlCmd.CommandText = "select * from SalareisControl where (ControlID=@p1)"
        SqlCmd.Parameters.AddWithValue("@p1", Cid)
        Rd = SqlCmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            Rd.Close()
            SqlCmd = Nothing
            SqlCnn.Close()
            Exit Sub
        End If
        SalaryMounth = IIf(Rd("SalaryMount") = 0, Now.Month, Rd("SalaryMount"))
        SalaryYear = IIf(Rd("SalaryYear") = 0, Now.Year, Rd("SalaryYear"))
        ControlID = Rd("ControlID")
        SalaryState = Rd("SalaryStatus")
        Rd.Close()
        SqlCmd = Nothing
        'يجب إزالة السطر بعد الموافقة على البرنامج
        'If SalaryYear = 2014 Then Application.ExitThread()
        ' '''''''''''''''''''''''''''''''''''''''''''''''''
        SqlCnn.Close()
    End Sub
    Public Sub LoadTax()
        Cu_Tax = New TaxClass
        Dim StrSql As String = "select * from SetupTax"
        SqlCnn.Open()
        SqlCmd = New SqlCommand(StrSql, SqlCnn)
        SqlCmd.CommandType = CommandType.Text
        Rd = SqlCmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Rd.Close()
            SqlCmd = Nothing
            SqlCnn.Close()
            Exit Sub
        End If
        Rd.Read()
        If Not Rd.HasRows Then
            Rd.Close()
            SqlCmd = Nothing
            SqlCnn.Close()
            Exit Sub
        End If
        With Cu_Tax
            .TaxID = Rd("TaxationID")
            .TaxImmunity = Rd("TaxImmunity")
            .Tax1 = Rd("Tax1")
            .Tax2 = Rd("Tax2")
            .Tax3 = Rd("Tax3")
            .Tax4 = Rd("Tax4")
            .Tax5 = Rd("Tax5")
            .Tax6 = Rd("Tax6")
            .Tax7 = Rd("Tax7")
            .Tax8 = Rd("Tax8")
            .Ptax1 = Rd("Ptax1")
            .Ptax2 = Rd("Ptax2")
            .Ptax3 = Rd("Ptax3")
            .Ptax4 = Rd("Ptax4")
            .Ptax5 = Rd("Ptax5")
            .Ptax6 = Rd("Ptax6")
            .Ptax7 = Rd("Ptax7")
            .Ptax8 = Rd("Ptax8")
            .UserID = Rd("UserID")
            .LastModify = Rd("LastModify")
            .CreateDate = Rd("CreateDate")
        End With
        Rd.Close()
        SqlCmd = Nothing
        SqlCnn.Close()
    End Sub
    Public Sub LoadConstants()
        Dim StrSql As String = "select * from SalaryConstants"
        SqlCnn.Open()
        SqlCmd = New SqlCommand(StrSql, SqlCnn)
        SqlCmd.CommandType = CommandType.Text
        Rd = SqlCmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Rd.Close()
            SqlCmd = Nothing
            SqlCnn.Close()
            Exit Sub
        End If
        Cu_Constants = New ConstantClass(Rd("SalaryConstID"))
        With Cu_Constants
            .Wife = Rd("Wife ")
            .Child1 = Rd("Child1")
            .Child2 = Rd("Child2")
            .Child3 = Rd("Child3")
            .OtherChild = Rd("OtherChild")
            .warm = Rd("warm")
            .Specialize = Rd("Specialize")
            .TypeSpecialize = Rd("TypeSpecialize")
            .SocialInsurance = Rd("SocialInsurance")
            .CooperateBox = Rd("CooperateBox")
            .CooperationWorkers = Rd("CooperationWorkers")
            .EngCooperation = Rd("EngCooperation")
            .habitation = Rd("habitation")
            .AssistBox = Rd("AssistBox")
            .AssistBox1 = Rd("AssistBox1")
            .Typo = Rd("Typo")
            .DeathAssist = Rd("DeathAssist")
            .EndService = Rd("EndService")
            .TaxImmunity = Rd("TaxImmunity")
        End With
        Rd.Close()
        SqlCmd = Nothing
        SqlCnn.Close()
    End Sub
    Public Function InsertTOLastSalareis() As Boolean 'الإجراء بعد إغلاق الرااتب
        'ترحيل سجلات الراتب''''''''''
        Dim r As Boolean
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(My.Settings.InsertLastSalary, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.ExecuteNonQuery()
            r = True
            SqlCmd = Nothing
            SqlCnn.Close()
        Catch ex As Exception
            SqlCmd = Nothing
            SqlCnn.Close()
            r = False
        End Try
        Return r
    End Function
    'ترحيل السلف الأخرى
    Public Function InsertLastTakeouts() As Boolean
        Dim r As Boolean
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(My.Settings.InsertLastTakeOuts, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.ExecuteNonQuery()
            r = True
            SqlCmd = Nothing
            SqlCnn.Close()
        Catch ex As Exception
            SqlCmd = Nothing
            SqlCnn.Close()
            r = False
        End Try
        Return r
    End Function
    ''' <summary>
    '''  تحديث قيم السلف الأخرى المنتهية
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks> التأكد من السلف المنهية </remarks>
    'Public Function UpdateTakeOuts() As Boolean
    '    Dim r As Boolean
    '    Try
    '        SqlCnn.Open()
    '        SqlCmd = New SqlCommand(My.Settings.UpdateTakeOuts, SqlCnn)
    '        SqlCmd.CommandType = CommandType.Text
    '        SqlCmd.ExecuteNonQuery()
    '        r = True
    '        SqlCmd = Nothing
    '        SqlCnn.Close()
    '    Catch ex As Exception
    '        SqlCmd = Nothing
    '        SqlCnn.Close()
    '        r = False
    '    End Try
    '    Return r
    'End Function
    ''' <summary>
    ''' تحديث قيم إعادة فرق وترحيلها
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function UpdateBacklogReturn() As Boolean
        Dim r As Boolean
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(My.Settings.UpdateBacklogReturn, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.ExecuteNonQuery()
            r = True
            SqlCmd = Nothing
            SqlCnn.Close()
        Catch ex As Exception
            SqlCmd = Nothing
            SqlCnn.Close()
            r = False
        End Try
        Return r
    End Function
    ''' <summary>
    ''' تحديث قيم استراد فرق وترحيلها
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function UpdateBacklogRecover() As Boolean
        Dim r As Boolean
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(My.Settings.UpdateBacklogRecover, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.ExecuteNonQuery()
            r = True
            SqlCmd = Nothing
            SqlCnn.Close()
        Catch ex As Exception
            SqlCmd = Nothing
            SqlCnn.Close()
            r = False
        End Try

        Return r
    End Function
    ''' <summary>
    ''' تحديث السلف والإقتطاعات الثابتة بجدول الراتب
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function UpdateAllSolfa() As Boolean
        Dim r As Boolean
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(My.Settings.UpdateAllSolfa, SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.ExecuteNonQuery()
            r = True
            SqlCmd = Nothing
            SqlCnn.Close()
        Catch ex As Exception
            SqlCmd = Nothing
            SqlCnn.Close()
            r = False
        End Try
        Return r
    End Function
    ''' <summary>
    '''  تحديث قيم مفردات جدوا الراتب
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks> إعادة تعيين بعض مفردات الراتب للإدخال الجديد </remarks>
    Public Function UpdateSalaryField() As Boolean
        Dim r As Boolean
        Dim sql As String
        Try
            SqlCnn.Open()
            SqlCmd = New SqlCommand(exeCalc("UpdateSalaryFields.sql"), SqlCnn)
            SqlCmd.CommandType = CommandType.Text
            sql = SqlCmd.ExecuteScalar()
            r = True
            SqlCmd.CommandText = sql
            SqlCmd.ExecuteNonQuery()
            SqlCnn.Close()
        Catch ex As Exception
            SqlCmd = Nothing
            SqlCnn.Close()
            r = False
        End Try
        Return r
    End Function
    ' ''' <summary>
    ' ''' ترحيل ثوابت مفردات الراتب
    ' ''' </summary>
    ' ''' <returns>Boolean</returns>
    ' ''' <remarks></remarks>
    'Public Function UpdateLastConsyants() As Boolean
    '    Dim r As Boolean
    '    Try
    '        SqlCnn.Open()
    '        SqlCmd = New SqlCommand(My.Settings.UpdateLastConsyants, SqlCnn)
    '        SqlCmd.CommandType = CommandType.Text
    '        If SqlCmd.ExecuteNonQuery > 0 Then
    '            r = True
    '            SqlCmd = Nothing
    '            SqlCnn.Close()
    '        Else
    '            r = False
    '        End If
    '    Catch ex As Exception
    '        SqlCmd = Nothing
    '        SqlCnn.Close()
    '    End Try
    '    Return r
    'End Function
    Public Function CheckDatabase() As Boolean
        Dim r As Boolean = False
        Try
            'SqlCnn.ConnectionString = "Data Source=.\sqlexpress;Initial Catalog=BaniasEnergyDB1;Integrated Security=True"
            SqlCnn.Open()
            r = True
        Catch ex As SqlException
            If ex.Number = -1 Then
                MsgBox("لم يتم العثور على مخدم قاعدة البيانات" + Chr(13) + "الرجاء التأكد من تشغيل SQLSERVER")
                r = False
                Application.Exit()
            ElseIf ex.Number = 4060 Then
                MsgBox("لم يستطع البرنامج الإتصال مع قاعدة البيانات")
                Shell("CreateBaniasDB.exe", AppWinStyle.NormalFocus, True, -1)
                r = False
                Application.Exit()
            End If
        Finally
            If SqlCnn.State = ConnectionState.Open Then SqlCnn.Close()
        End Try
        Return (r)
    End Function
    Public Sub GetRtnConnect(ByVal Val As String)
        Dim ss1 As String = "الراتب المقطوع"
        Dim ss2 As String = "التعويض العائلي"
        Dim ss3 As String = "إختصاص"
        Dim ss4 As String = "طبيعة عمل"
        Dim ss5 As String = "تعويض مسؤولية"
        Dim ss6 As String = "تدفئة"
        Dim ss7 As String = "مخاطر عمل"

    End Sub
    Dim ucnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim ucmdd As New SqlCommand("", ucnn)
    Public Sub UpdateUserData(ByVal uID As Integer)
        Dim usrd As SqlDataReader
        Try
            ucnn.Open()
            ucmdd.CommandText = "select * from users where UserID=" & uID.ToString & ""
            usrd = ucmdd.ExecuteReader

            If usrd.Read() Then
                Cu_User = New UsersClass(usrd("UserId"), usrd("UserName").ToString, usrd("ExpireDate").ToString, usrd("IsAdmin"), usrd("IsActive"), usrd("UserPassword").ToString, usrd("AllowOpen"), _
                                         usrd("AllowDelete"), usrd("AllowModify"), usrd("AllowPrint"), usrd("IsExpire"), usrd("AllowSalary"), usrd("AllowWorkers"), usrd("AllowAgents"), usrd("AllowManagers"), usrd("AllowEngeneers"), usrd("AllowContracts"), usrd("AllRecords"))
            End If
            usrd.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ucnn.Close()
        End Try
        ucnn.Close()
    End Sub
    Public Sub ACtiveTrigers(ByVal tValue As Boolean, Optional ByVal Tregername As String = "Salaryrecords")
        If My.Settings.SalTriger = CheckState.Checked Then Exit Sub
        If Not Cu_User.IsAdmin Then Exit Sub
        Try
            ucnn.Open()
            If tValue = False Then
                ucmdd.CommandText = "ALTER TABLE SalaryRecords DISABLE TRIGGER ALL"
                ucmdd.ExecuteNonQuery()
            Else
                ucmdd.CommandText = "ALTER TABLE SalaryRecords ENABLE TRIGGER ALL"
                ucmdd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ucnn.Close()
        End Try
        ucnn.Close()
    End Sub

    Public Sub LoadCalcFiles(Optional ByVal DoThat As Boolean = 0)
        'If My.Computer.Name <> "WIN-O7R3FJDV768" Or My.Computer.Name <> "RAMITTA" Then Exit Sub
        ACtiveTrigers(False)
        Dim fcnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Dim Drv As SqlDataReader
        Dim CmdTest As New SqlCommand("", ucnn)
        Dim CmdDo As New SqlCommand("", fcnn)
        'التحقق من وجود المكتبات
        With My.Computer.FileSystem
            If Not .DirectoryExists(Application.StartupPath + "\execScript") Then
                .CreateDirectory(Application.StartupPath + "\execScript")
                .CreateDirectory(Application.StartupPath + "\execScript\Aacounting")
                .CreateDirectory(Application.StartupPath + "\execScript\AfterCloseMonth")
                .CreateDirectory(Application.StartupPath + "\execScript\Bacounting")
                .CreateDirectory(Application.StartupPath + "\execScript\OnAcounting")
                .CreateDirectory(Application.StartupPath + "\execScript\Onload")
            ElseIf Not .DirectoryExists(Application.StartupPath + "\execScript\Aacounting") Then
                .CreateDirectory(Application.StartupPath + "\execScript\Aacounting")
            ElseIf Not .DirectoryExists(Application.StartupPath + "\execScript\AfterCloseMonth") Then
                .CreateDirectory(Application.StartupPath + "\execScript\AfterCloseMonth")
            ElseIf Not .DirectoryExists(Application.StartupPath + "\execScript\Bacounting") Then
                .CreateDirectory(Application.StartupPath + "\execScript\Bacounting")
            ElseIf Not .DirectoryExists(Application.StartupPath + "\execScript\OnAcounting") Then
                .CreateDirectory(Application.StartupPath + "\execScript\OnAcounting")
            ElseIf Not .DirectoryExists(Application.StartupPath + "\execScript\Onload") Then
                .CreateDirectory(Application.StartupPath + "\execScript\Onload")
            End If
        End With
        Dim Aacounting As String = Application.StartupPath + "\execScript\Aacounting"
        Dim AfterCloseMonth As String = Application.StartupPath + "\execScript\AfterCloseMonth"
        Dim Bacounting As String = Application.StartupPath + "\execScript\AacouBacountingnting"
        Dim OnAcounting As String = Application.StartupPath + "\execScript\OnAcounting"
        Dim Onload As String = Application.StartupPath + "\execScript\Onload"
        Dim DRText, Fname, Flabel, Ftext As String
        With My.Computer.FileSystem
            Try
                fcnn.Open()
                ucnn.Open()
                CmdDo.CommandText = "select * from IdentityFields"
                Drv = CmdDo.ExecuteReader
                If Drv.RecordsAffected <= 0 Then

                End If
                While Drv.Read
                    DRText = Drv("FieldCalc").ToString
                    Fname = Drv("FieldName").ToString
                    Flabel = Drv("FieldLabel").ToString
                    Flabel = Drv("FieldLabel").ToString

                    'If Fname = "AfterCloseMonth" OrElse Fname = "AfterOpenMonth" Then
                    '    MsgBox("Fname")
                    'End If

                    If Not .FileExists(Application.StartupPath + "\execScript\" + Drv("FieldName") + "\" + Drv("FieldLabel").ToString) Then
                        Dim s As FileStream
                        s = File.Create(Application.StartupPath + "\execScript\" + Drv("FieldName") + "\" + Drv("FieldLabel"))
                        s.Close()
                    End If
                    Ftext = .ReadAllText(Application.StartupPath + "\execScript\" + Fname + "\" + Flabel, System.Text.Encoding.ASCII)
                    If Fname <> "AfterCloseMonth" And Fname <> "AfterOpenMonth" Then
                        Try
                            CmdTest.CommandText = Ftext
                            CmdTest.ExecuteNonQuery()
                            Dim s As String = "update IdentityFields Set FieldCalc='" + Ftext.ToString + "' where FieldLabel='" + Flabel + "'"
                            CmdTest.CommandText = s
                            CmdTest.ExecuteNonQuery()
                        Catch ex As Exception
                            If MessageBox.Show("سيقوم البرنامج بتصحيح الخطأ تلقائيا في الملف" + Drv("FieldLabel").ToString + "هل تريد التابعة الإجراء", "RAMITTA", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                My.Computer.FileSystem.WriteAllText(Application.StartupPath + "\execScript\" + Drv("FieldName") + "\" + Drv("FieldLabel"), Drv("FieldCalc").ToString, False)
                            Else
                                MsgBox(ex.Message + "_" + Drv(Flabel) + "الرجاء مراجعة المسؤول المختص")
                            End If
                        End Try
                    End If
                End While
                Drv.Close()
                fcnn.Close()
                ucnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                fcnn.Close()
                ucnn.Close()
            End Try
        End With
    End Sub
    Public Sub CalcOnSave()
        ACtiveTrigers(False)
        If InitializeA() Then

        End If
        If Allowance() Then

        End If
        If CalcFamily() Then

        End If
        If CalcSpecialType() Then

        End If
        If CalcBacklogReturn() Then

        End If
        If CalcDriveMutable() Then

        End If
        If CalcDrive() Then

        End If
        If CalcMutable() Then

        End If
        If CalcManagers() Then

        End If
        If CalcFullSalary() Then

        End If
        ''''''''''''''قسم الحسميات''''''''''''''''''''
        If SubBacklogRecover() Then

        End If

        If SocialInsurance() Then

        End If
        'If CooperateBox() Then
        '   
        'End If
        If CooperationWorkers() Then

        End If
        If EngCooperation() Then

        End If
        'If habitation() Then
        '   
        'End If
        If OtherFields() Then

        End If

        If CalcTax() Then

        End If
        If UpdateLoanDiscount() Then

        End If
        'If Mutable() Then
        '   
        'End If
        If SumTotalTakeOuts() Then

        End If
        If FieldRound() Then

        End If
        If SumDiscounts() Then

        End If
        If TotalSalary() Then

        End If
        If AfterDone() Then

        End If
        ACtiveTrigers(True)
    End Sub
End Module
