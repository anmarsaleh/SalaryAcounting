Public Class SalaryTaxFrm

    Private Sub SalaryTaxFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SetupSalaryDataSet.SetupTax' table. You can move, or remove it, as needed.
        Me.SetupTaxTableAdapter.Fill(Me.SetupSalaryDataSet.SetupTax)
        TextBox16.Hide()
        TextBox17.Hide()
        TextBox18.Hide()
        Me.TaxationIDTextBox.Hide()
        Me.ControlIDTextBox.Hide()
        Dim r As Integer = Me.SetupTaxBindingSource.Count
        If r <= 0 Then
            Me.SetupTaxBindingSource.AddNew()
            Me.TaxationIDTextBox.Text = 1
            Me.ControlIDTextBox.Text = ControlID
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TextBox16.Text = Cu_User.UserID
        Me.TextBox17.Text = Now.Date
        Me.TextBox18.Text = Now.Date
        Me.ControlIDTextBox.Text = ControlID
        Try
            Me.Validate()
            Me.SetupTaxBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SetupSalaryDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("تم حفظ الإعدادات بنجاح")
        End Try
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class