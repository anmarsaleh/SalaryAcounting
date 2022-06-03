Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Module CalculatingSalariesMdl
    Dim Cnn As New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim Cmd As SqlCommand
    Dim Dr As SqlDataReader
    Dim StrSql As String
    Dim r As Integer
    Public Function exeCalc(ByVal fldn As String) As String
        Dim r As String
        r = "select FieldCalc from IdentityFields where FieldLabel='" + fldn + "'"
        Return r
    End Function
    Public Sub RestorePoints(ByVal stat As Integer, ByVal SSCID As Integer)
        Try
            Cnn.Open()
            Cmd = New SqlCommand("", Cnn)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "R_Points"
            Cmd.Parameters.Add("@stat", SqlDbType.Bit).Value = stat
            Cmd.Parameters.Add("@ssCID", SqlDbType.Int).Value = SSCID
            Cmd.ExecuteNonQuery()
            Cnn.Close()
        Catch ex As Exception
            Cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function InitializeA() As Boolean 'تدقيق وتصحيح السجلات قبل حساب الراتب
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("Initialize.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            r = 0
            StrSql = ""
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\Bacounting\Initialize.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try
        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Allowance() As Boolean 'الترفيعة
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("Allowance.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\Allowance.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try
        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcFamily() As Boolean ' التعويض العائلي
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("Family.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\Family.sql").ToString
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcSpecialType() As Boolean '  إختصاص'
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("SpecialType.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            'If My.Settings.Oldspecial Then
            '    StrSql = File.ReadAllText(MyAppPath & "\SpecialOldsalary.sql")
            'Else
            '    StrSql = File.ReadAllText(MyAppPath & "\SpecialType.sql")
            'End If
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\SpecialType.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcBacklogReturn() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("SubBacklogReturn.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\SubBacklogReturn.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcDriveMutable() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("CreateMutable.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\mutable.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcDrive() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("DriveAcount.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\mutable.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcMutable() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("mutable.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\mutable.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcManagers() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("managers.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\managers.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CalcFullSalary() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("FullSalary.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\FullSalary.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '''''''''''''''''''''''''''''قسم الحسميات'''''''''''''''''''''''
    Public Function SubBacklogRecover() As Boolean ' مجموع استرداد الفرق غير خاضع لضريبة
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("SubBacklogRecover.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\SubBacklogRecover.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SocialInsurance() As Boolean ' التأمينات الإجتماعية
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("SocialInsurance.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\SocialInsurance.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Public Function CooperateBox() As Boolean 'صندوق التعاون
    '    Try
    '        StrSql = ""
    '        r = 0
    '        StrSql = File.ReadAllText(MyAppPath & "\execScript\OnAcounting\CooperateBox.sql")
    '        Cmd = New SqlCommand(StrSql, Cnn)
    '        Cmd.CommandType = CommandType.Text
    '        Cnn.Open()
    '        r = Cmd.ExecuteNonQuery()
    '        Cmd = Nothing
    '        Cnn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Cmd = Nothing
    '        Cnn.Close()
    '        Return False
    '    End Try

    '    If r > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Public Function CooperationWorkers() As Boolean 'نقابة العمال
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("CooperationWorkers.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\CooperationWorkers.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text
            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function EngCooperation() As Boolean 'نقابة المهندسين
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("EngCooperation.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\EngCooperation.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'Public Function habitation() As Boolean 'أجور سكن
    '    Try
    '        StrSql = ""
    '        r = 0
    '        StrSql = File.ReadAllText(MyAppPath & "\execScript\OnAcounting\habitation.sql")
    '        Cmd = New SqlCommand(StrSql, Cnn)
    '        Cmd.CommandType = CommandType.Text
    '        Cnn.Open()
    '        r = Cmd.ExecuteNonQuery()
    '        Cmd = Nothing
    '        Cnn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Cmd = Nothing
    '        Cnn.Close()
    '        Return False
    '    End Try

    '    If r > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    'صندوق المساعدة+إعانة نهاية خدمة+الغياب
    Public Function OtherFields() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("OtherFields.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\OtherFields.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'المبلغ الخاضع للضريبة + ضريبة الدخل
    'أخر إجرائية تستدعى للتنفيذ
    Public Function CalcTax() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("TotalTax.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\TotalTax.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'حساب قيم الحسم الشهري للسلف
    Public Function UpdateLoanDiscount() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("UpdateLoanDiscount.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\UpdateLoanDiscount.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'مجموع الحسم الشهري للسلف الأخرى
    Public Function SumTotalTakeOuts() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("SumTotalTakeOuts.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\SumTotalTakeOuts.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'حساب قيمة المتحول
    'Public Function Mutable() As Boolean
    '    Try
    '        StrSql = ""
    '        r = 0
    '        StrSql = File.ReadAllText(MyAppPath & "\mutable.sql")
    '        Cmd = New SqlCommand(StrSql, Cnn)
    '        Cmd.CommandType = CommandType.Text
    '        Cnn.Open()
    '        r = Cmd.ExecuteNonQuery()
    '        Cmd = Nothing
    '        Cnn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Cmd = Nothing
    '        Cnn.Close()
    '        Return False
    '    End Try

    '    If r > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    'تدوير قيمة الحقول الى اقرب فاصلة
    Public Function FieldRound() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("FieldRound.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            'If Not My.Computer.FileSystem.FileExists(MyAppPath & "\execScript\Aacounting\FieldRound.sql") Then
            '    Return True
            'End If
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\Aacounting\FieldRound.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteScalar()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '--------------------------------------------
    'مجموع الحسميات
    Public Function SumDiscounts() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("SumDiscounts.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\SumDiscounts.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'مجموع الراتب الصافي
    Public Function TotalSalary() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("TotalSalary.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\OnAcounting\TotalSalary.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    'التحقق من الراتب
    Public Function CheckSalary() As Boolean
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("CheckSalary.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\Aacounting\CheckSalary.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteScalar()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try

        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function PreLoad() As Boolean 'تنفيذ ملف سكريبت قبل فتح البرنامج
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("PreLoad.sql"), Cnn)
        Try
            Cnn.Open()
            Sql = Cmd.ExecuteScalar
            r = 0
            StrSql = ""
            StrSql = sql ' File.ReadAllText(MyAppPath & "\execScript\Onload\PreLoad.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try
        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function AfterDone() As Boolean 'تنفيذ ملف سكريبت بعد عملية حساب الراتب///تشغيل triger
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("AfterDone.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            r = 0
            StrSql = ""
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\Aacounting\AfterDone.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try
        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function AfterOpenMonth() As Boolean 'الترفيعة
        Dim sql As String
        Cmd = New SqlCommand(exeCalc("UpdateValues.sql"), Cnn)
        Try
            Cnn.Open()
            sql = Cmd.ExecuteScalar
            StrSql = ""
            r = 0
            StrSql = sql 'File.ReadAllText(MyAppPath & "\execScript\OnAcounting\Allowance.sql")
            Cmd = New SqlCommand(StrSql, Cnn)
            Cmd.CommandType = CommandType.Text

            r = Cmd.ExecuteNonQuery()
            Cmd = Nothing
            Cnn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd = Nothing
            Cnn.Close()
            Return False
        End Try
        If r > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
