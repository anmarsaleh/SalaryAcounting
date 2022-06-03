Imports System.Data.SqlClient
Imports System.Data
Public Class FrmPloterTbl
    Dim tablCnn As SqlConnection ' SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
    Dim tblCmd As SqlCommand 'SqlCommand("", tablCnn)
    Dim Dsql, sql, tblname As String
    Dim stCID As String
    Dim search As System.Management.ManagementObjectSearcher
    Dim results As System.Management.ManagementObjectCollection
    Dim y, m As String
    'I call a two-element array of type Object 
    Dim args(1) As Object

    'Statement class instance System.Management.ManagementObject 
    Dim printer As System.Management.ManagementObject
    Private Sub FrmPloterTbl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        Try
            'Cheque to a class instance variable search ManagementObjectSearcher 
            'With the query that we have to specify as a parameter, in this case 
            'Select * from using Win32_Printer will be searched all available printers and installed in 
            'Operating system. 
            search = New System.Management.ManagementObjectSearcher("select * from Win32_Printer")

            'The Get method calls belonging to class ManagementObjectSearcher 
            'The query we specified earlier in order to enhance the 
            'Variable of type ManagementObjectCollection results with the whole 
            'Resultant. 
            results = search.Get()


            'We make a ForEach loop variable by assigning the printer 
            'Type ManagementObject collection of all sets variable 
            'Results 
            For Each Me.printer In results
                'We value Intems through the property and the Add method of the ComboBox 
                'CbxAvialiblePrinters, which display all the printers 
                'Available on the inside, giving the possibility to select them. 
                cbxAvialiblePrinters.Items.Add(Me.printer("Name"))
            Next

            'We also run using a try / catch Exception class and a possible exception at runtime. 
        Catch ex As Exception
            'The user by displaying a messagebox 
            MessageBox.Show(ex.Message.ToString())
        End Try
        loadPloter()
    End Sub
   
    Private Sub loadPloter()
        If My.Computer.Name = "RAMITTA1" Or My.Computer.Name = "RAMITTA-PC" Then
            tablCnn = New SqlConnection(My.Settings.BaniasEnergyDBConnectionString)
        Else
            tablCnn = New SqlConnection(My.Settings.PortCOnnection)
        End If
        tblCmd = New SqlCommand("", tablCnn)
        Me.IsOldSalary.Hide()

        If IsOldSalary.CheckState = CheckState.Unchecked Then
            tblname = "SalaryRecords"
            Label2.Visible = False
            Label3.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
        Else
            tblname = "LastSalareis"
            Label2.Visible = True
            Label3.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True

        End If
        Dsql = "USE [SalaryLatDB]  IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PloterTable]') AND type in (N'P', N'PC')) DROP PROCEDURE [dbo].[PloterTable]"
        sql = "CREATE PROCEDURE [dbo].[PloterTable] AS BEGIN exec('"
        sql = sql + " select " + tblname + ".*,CenterNames.CenterName, case when IsEngCooperation=1 then EngCooperation else 0 end as ENGCop,case when IsEngFarm=1 then EngCooperation else 0 end as ENGCopF, case when agentEmp=1 then case when salarymount=1 then 12 else salarymount-1 end  else salarymount end as m1,case when agentEmp=1 then case when salarymount=1 then SalaryYear-1 else SalaryYear end else SalaryYear end  as y1,  case when  " + tblname + ".agentEmp = 1 then N''عقد سنوي'' else N''موظف ثابت'' end as Tname from  " + tblname + " INNER JOIN CenterNames  ON CenterNames.CenterID = " + tblname + ".CenterID  "
        sql = sql + " Where iscontract=0 " + stCID + " ') END"
        Try
            tablCnn.Open()
            tblCmd.CommandText = Dsql
            tblCmd.ExecuteNonQuery()
            tblCmd.CommandText = sql
            tblCmd.ExecuteNonQuery()
            tablCnn.Close()
            PloterTables1.DataSourceConnections.Clear()
            If My.Computer.Name = "RAMITTA1" Or My.Computer.Name = "RAMITTA-PC" Then
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                PloterTables1.DataSourceConnections.Item(0).SetConnection("RAMITTA-PC", "SalaryLatDB", "Fadia", "microsoft@1976")
            Else
                ' DetailEmpSalary1.Subreports(i).SetDatabaseLogon(My.Settings.CRVuserid, My.Settings.CRVpw, My.Settings.CRVservername, My.Settings.CRVDBname)
                PloterTables1.DataSourceConnections.Item(0).SetConnection(My.Settings.CRVservername, My.Settings.CRVDBname, My.Settings.CRVuserid, My.Settings.CRVpw)
            End If
            PloterTables1.PrintOptions.PrinterName = TextBox2.Text

            CrystalReportViewer1.Visible = True
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
            tablCnn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim pCid As Integer = IIf(IsNumeric(TextBox1.Text), TextBox1.Text, 0)
        Dim Agentstr As Integer = IIf(CheckBox1.Checked, 1, 0)
        Dim nmy As String
        m = " and SalaryMount=" + IIf(IsNumeric(TextBox3.Text), TextBox3.Text, SalaryMounth.ToString) + " "
        y = " and SalaryYear=" + IIf(IsNumeric(TextBox4.Text), TextBox4.Text, SalaryYear.ToString) + " "
        nmy = m & " " & y
        If IsOldSalary.CheckState = CheckState.Unchecked Then
            nmy = ""
        Else
            nmy = m & " " & y
        End If
        If Button1.Text = "تصفية" Then
            stCID = " and CenterNames.CenterID=" + pCid.ToString + " and agentEmp=" + Agentstr.ToString + "  " + nmy + ""
            Button1.Text = "إلغاء التصفية"
        Else
            stCID = String.Empty
            Button1.Text = "تصفية"
        End If

        loadPloter()
    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        'Test 
        Try

            'We make a ForEach loop by assigning the variable prnt 
            'Type ManagementObject collection of all sets variable 
            'Results 
            For Each Me.printer In results
                'We check that the value using its Name 
                'Of the variable print is equal to the value of properties 
                'Text of the ComboBox cbxAvialiblePrinters 
                If Me.printer("Name") = cbxAvialiblePrinters.Text Then

                    'We call the method InvokeMethod 
                    'Which invokes the method on the past 
                    'As an argument in this case SetDefaultPrinter, 
                    'That will set as the default printer that the user 
                    'Selected from the ComboBox control cbxAvialiblePrinters. 
                    Me.printer.InvokeMethod("SetDefaultPrinter", args(0))
                    'Visualise also using a TextBlock tbkPrinterSelect 
                    'The name of the currently selected printer and set as 
                    'Default printer. 
                    TextBox2.Text = cbxAvialiblePrinters.Text
                    'We also add a check if there has been selected 
                    'No printer by the user using the SelectedIndex property. 
                    'This property returns an integer which indicate which items the user has 
                    'Chosen in the non-selection will return a negative value -1. 
                ElseIf (cbxAvialiblePrinters.SelectedIndex.Equals(-1)) Then

                    'We display a message asking where you select a printer from 
                    'ComboBox cbxAvialiblePrinters 
                    MessageBox.Show("Select a printer from the drop-down box", "")
                End If
            Next
            loadPloter()
            'We also run using a try / catch Exception class and a possible exception at runtime. 
        Catch ex As Exception
            'The user by displaying a messagebox 
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
End Class