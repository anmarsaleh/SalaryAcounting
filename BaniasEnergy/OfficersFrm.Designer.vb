<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficersFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficersFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BaniasEnergyDBDataSet = New BaniasEnergy.BaniasEnergyDBDataSet()
        Me.OfficesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficesTableAdapter = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.OfficesTableAdapter()
        Me.TableAdapterManager = New BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager()
        Me.OfficesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OfficesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OfficesDataGridView = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfficesBindingNavigator.SuspendLayout()
        CType(Me.OfficesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 30)
        Me.Panel1.TabIndex = 0
        '
        'BaniasEnergyDBDataSet
        '
        Me.BaniasEnergyDBDataSet.DataSetName = "BaniasEnergyDBDataSet"
        Me.BaniasEnergyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OfficesBindingSource
        '
        Me.OfficesBindingSource.DataMember = "Offices"
        Me.OfficesBindingSource.DataSource = Me.BaniasEnergyDBDataSet
        '
        'OfficesTableAdapter
        '
        Me.OfficesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BacklogRecoverTableAdapter = Nothing
        Me.TableAdapterManager.BacklogReturnTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DirectoratesTableAdapter = Nothing
        Me.TableAdapterManager.OfficesTableAdapter = Me.OfficesTableAdapter
        Me.TableAdapterManager.RecoverNamesTableAdapter = Nothing
        Me.TableAdapterManager.ReturnNamesTableAdapter = Nothing
        Me.TableAdapterManager.SalareisControlTableAdapter = Nothing
        Me.TableAdapterManager.SalaryRecordsTableAdapter = Nothing
        Me.TableAdapterManager.TakeOutNamesTableAdapter = Nothing
        Me.TableAdapterManager.TakeOutsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OfficesBindingNavigator
        '
        Me.OfficesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OfficesBindingNavigator.BindingSource = Me.OfficesBindingSource
        Me.OfficesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OfficesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OfficesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OfficesBindingNavigatorSaveItem})
        Me.OfficesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OfficesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OfficesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OfficesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OfficesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OfficesBindingNavigator.Name = "OfficesBindingNavigator"
        Me.OfficesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OfficesBindingNavigator.Size = New System.Drawing.Size(327, 25)
        Me.OfficesBindingNavigator.TabIndex = 1
        Me.OfficesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OfficesBindingNavigatorSaveItem
        '
        Me.OfficesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OfficesBindingNavigatorSaveItem.Image = CType(resources.GetObject("OfficesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OfficesBindingNavigatorSaveItem.Name = "OfficesBindingNavigatorSaveItem"
        Me.OfficesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OfficesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OfficesDataGridView
        '
        Me.OfficesDataGridView.AutoGenerateColumns = False
        Me.OfficesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OfficesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.OfficesDataGridView.DataSource = Me.OfficesBindingSource
        Me.OfficesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OfficesDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.OfficesDataGridView.Name = "OfficesDataGridView"
        Me.OfficesDataGridView.Size = New System.Drawing.Size(327, 201)
        Me.OfficesDataGridView.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 2)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(50, 19)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "إغـــلاق"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OfficeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OfficeName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "التسمية الوظيفية"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'OfficersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 256)
        Me.Controls.Add(Me.OfficesDataGridView)
        Me.Controls.Add(Me.OfficesBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "OfficersFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "المنصب الوظيفي"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BaniasEnergyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfficesBindingNavigator.ResumeLayout(False)
        Me.OfficesBindingNavigator.PerformLayout()
        CType(Me.OfficesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BaniasEnergyDBDataSet As BaniasEnergy.BaniasEnergyDBDataSet
    Friend WithEvents OfficesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OfficesTableAdapter As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.OfficesTableAdapter
    Friend WithEvents TableAdapterManager As BaniasEnergy.BaniasEnergyDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OfficesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OfficesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OfficesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
