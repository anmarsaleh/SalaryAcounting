Public Class SalaryConstantFrm

    Private Sub SalaryConstantFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaniasEnergyDBDataSet.SalaryRecords' table. You can move, or remove it, as needed.
        'Me.SalaryRecordsTableAdapter.Fill(Me.BaniasEnergyDBDataSet.SalaryRecords)
        'TODO: This line of code loads data into the 'SetupSalaryDataSet.SalaryConstants' table. You can move, or remove it, as needed.
        Me.SalaryConstantsTableAdapter.Fill(Me.SetupSalaryDataSet.SalaryConstants)
        SalaryConstIDTextBox.Hide()
        ControlIDTextBox.Hide()
        'Me.SalaryConstantsBindingSource.ResetBindings(True)
        If Me.SalaryConstantsBindingSource.CurrencyManager.Count <= 0 Then
            Me.SalaryConstantsBindingSource.CurrencyManager.AddNew()
            Me.SalaryConstIDTextBox.Text = 1
            Me.ControlIDTextBox.Text = ControlID
        End If
        CheckBox1.Checked = My.Settings.Oldspecial
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ControlIDTextBox.Text = ControlID
        Try
            Me.Validate()
            Me.SalaryConstantsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)
            My.Settings.Oldspecial = CheckBox1.Checked
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("تمت عملية الحفظ بنجاح")
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MyAdvancedSettings = New AdvancedSettings
        MyAdvancedSettings.ShowDialog(Me)
    End Sub

    Private Sub Label39_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label38_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub OverWdayTextBox_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class