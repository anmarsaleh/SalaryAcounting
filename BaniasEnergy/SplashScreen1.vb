Imports System.Threading
Imports System.IO
Imports System.Management
Imports System.Data
Imports System.Data.SqlClient
Public NotInheritable Class SplashScreen1
    Dim Idp, Idp1 As String
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).
        If My.Settings.ActibeFor = "" Then
            'Application title
            If My.Application.Info.Title <> "" Then
                ApplicationTitle.Text = My.Application.Info.Title
            Else
                '-
                'If the application title is missing, use the application name, without the extension
                ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If
        Else
            ApplicationTitle.Text = My.Settings.ActibeFor
        End If
       
        'For Each frm As Form In My.Application.OpenForms
        '    frm.Icon = My.Resources.Ramitta
        'Next
        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
        'PictureBox1.Width = 0
    End Sub

    Dim count As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        count += 5
        If count < 263 Then
            'PictureBox1.Width = count
            'PictureBox1.Refresh()
            'Application.DoEvents()
            If count = 25 Then
                Label1.Visible = True
                PictureBox3.Visible = True
                Timer1.Stop()
                Application.DoEvents()
                If Not CheckDatabase() Then
                    MsgBox("فشل الإتصال مع مخدم قاعدة البيانات")
                    Application.Exit()
                Else
                    Timer1.Start()
                End If
            ElseIf count = 100 Then
                PictureBox3.Visible = False
                Label2.Visible = True
                Label1.Text += " تم"
                PictureBox4.Visible = True
            ElseIf count = 175 Then
                PictureBox4.Visible = False
                Label3.Visible = True
                PictureBox5.Visible = True
                Label2.Text += " تم"
            ElseIf count > 225 Then
                PictureBox5.Visible = False
                Label4.Visible = True
                PictureBox6.Visible = True
                If count = 250 Then Label3.Text += " تم"
            End If
        Else
            PictureBox6.Visible = False
            Label4.Text += " تم"
            Timer1.Enabled = False
            ' Thread.Sleep(2000)

            Me.Hide()
            'ActiveProg()
            'If Not My.Settings.ActivateSalary = Idp1 Then
            '    If My.Settings.ActivateSalary = String.Empty Then
            '        MsgBox("لم يعثر البرنامج على مفتاح التنشيط")
            '        Dim f As New FrmActive
            '        f.ShowDialog()
            '    Else
            '        MsgBox("مفتاح التنشيط الموجود غير صالح")
            '        Dim f As New FrmActive
            '        f.ShowDialog()
            '    End If
            '    Application.Exit()
            'End If

            Myloginfrm = New LogInFrm
            Myloginfrm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ActiveProg()
        Dim Srh As ManagementObjectSearcher
        Srh = New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
        For Each Device As ManagementObject In Srh.Get
            For Each Prop As PropertyData In Device.Properties
                'استخراج الرقم
                Idp = (Prop.Value.ToString)
            Next
        Next
        Idp = Obfuscate(Idp)
        'تحويله الى اسكي
        Idp = Str2Int(Idp)
        'تشويش الرقم
        Idp1 = Obfuscate(Idp)
        'تحويله الى اسكي
        'رقم التفعيل
        Idp1 = Str2Int(Idp1)
        'اقتصاص 14 رقم
        Idp1 = (Idp1.Substring(0, 14))
    End Sub
End Class
