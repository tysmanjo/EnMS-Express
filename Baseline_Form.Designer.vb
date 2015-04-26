<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baseline_Form
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
        Dim EnPI_NameLabel As System.Windows.Forms.Label
        Dim EnPI_UnitsLabel As System.Windows.Forms.Label
        Dim EnPI_IntervalLabel As System.Windows.Forms.Label
        Dim EnPI_TargetLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Baseline_Form))
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
        Me.EnPI_BaselineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnPI_BaselineTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_BaselineTableAdapter()
        Me.TableAdapterManager = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.EnPI_Baseline_DataTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_Baseline_DataTableAdapter()
        Me.EnPI_BaselineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EnPI_BaselineBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EnPI_NameTextBox = New System.Windows.Forms.TextBox()
        Me.EnPI_UnitsTextBox = New System.Windows.Forms.TextBox()
        Me.EnPI_Baseline_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnPI_Baseline_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnPI_SEUCheckBox = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EnPI_TargetTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnPI_ActualValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        EnPI_NameLabel = New System.Windows.Forms.Label()
        EnPI_UnitsLabel = New System.Windows.Forms.Label()
        EnPI_IntervalLabel = New System.Windows.Forms.Label()
        EnPI_TargetLabel = New System.Windows.Forms.Label()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnPI_BaselineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnPI_BaselineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnPI_BaselineBindingNavigator.SuspendLayout()
        CType(Me.EnPI_Baseline_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnPI_Baseline_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnPI_NameLabel
        '
        EnPI_NameLabel.AutoSize = True
        EnPI_NameLabel.Location = New System.Drawing.Point(29, 18)
        EnPI_NameLabel.Name = "EnPI_NameLabel"
        EnPI_NameLabel.Size = New System.Drawing.Size(38, 13)
        EnPI_NameLabel.TabIndex = 1
        EnPI_NameLabel.Text = "Name:"
        '
        'EnPI_UnitsLabel
        '
        EnPI_UnitsLabel.AutoSize = True
        EnPI_UnitsLabel.Location = New System.Drawing.Point(33, 44)
        EnPI_UnitsLabel.Name = "EnPI_UnitsLabel"
        EnPI_UnitsLabel.Size = New System.Drawing.Size(34, 13)
        EnPI_UnitsLabel.TabIndex = 3
        EnPI_UnitsLabel.Text = "Units:"
        '
        'EnPI_IntervalLabel
        '
        EnPI_IntervalLabel.AutoSize = True
        EnPI_IntervalLabel.Location = New System.Drawing.Point(247, 20)
        EnPI_IntervalLabel.Name = "EnPI_IntervalLabel"
        EnPI_IntervalLabel.Size = New System.Drawing.Size(45, 13)
        EnPI_IntervalLabel.TabIndex = 5
        EnPI_IntervalLabel.Text = "Interval:"
        '
        'EnPI_TargetLabel
        '
        EnPI_TargetLabel.AutoSize = True
        EnPI_TargetLabel.Location = New System.Drawing.Point(222, 47)
        EnPI_TargetLabel.Name = "EnPI_TargetLabel"
        EnPI_TargetLabel.Size = New System.Drawing.Size(67, 13)
        EnPI_TargetLabel.TabIndex = 8
        EnPI_TargetLabel.Text = "EnPI Target:"
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnPI_BaselineBindingSource
        '
        Me.EnPI_BaselineBindingSource.DataMember = "EnPI_Baseline"
        Me.EnPI_BaselineBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'EnPI_BaselineTableAdapter
        '
        Me.EnPI_BaselineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChangeLogTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Energy_PolicyTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_Baseline_DataTableAdapter = Me.EnPI_Baseline_DataTableAdapter
        Me.TableAdapterManager.EnPI_BaselineTableAdapter = Me.EnPI_BaselineTableAdapter
        'Me.TableAdapterManager.EnPI_DataTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.RecordTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EnPI_Baseline_DataTableAdapter
        '
        Me.EnPI_Baseline_DataTableAdapter.ClearBeforeFill = True
        '
        'EnPI_BaselineBindingNavigator
        '
        Me.EnPI_BaselineBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EnPI_BaselineBindingNavigator.BindingSource = Me.EnPI_BaselineBindingSource
        Me.EnPI_BaselineBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EnPI_BaselineBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EnPI_BaselineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EnPI_BaselineBindingNavigatorSaveItem})
        Me.EnPI_BaselineBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EnPI_BaselineBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EnPI_BaselineBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EnPI_BaselineBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EnPI_BaselineBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EnPI_BaselineBindingNavigator.Name = "EnPI_BaselineBindingNavigator"
        Me.EnPI_BaselineBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EnPI_BaselineBindingNavigator.Size = New System.Drawing.Size(452, 25)
        Me.EnPI_BaselineBindingNavigator.TabIndex = 0
        Me.EnPI_BaselineBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'EnPI_BaselineBindingNavigatorSaveItem
        '
        Me.EnPI_BaselineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EnPI_BaselineBindingNavigatorSaveItem.Image = CType(resources.GetObject("EnPI_BaselineBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EnPI_BaselineBindingNavigatorSaveItem.Name = "EnPI_BaselineBindingNavigatorSaveItem"
        Me.EnPI_BaselineBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EnPI_BaselineBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EnPI_NameTextBox
        '
        Me.EnPI_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnPI_BaselineBindingSource, "EnPI_Name", True))
        Me.EnPI_NameTextBox.Location = New System.Drawing.Point(73, 15)
        Me.EnPI_NameTextBox.Name = "EnPI_NameTextBox"
        Me.EnPI_NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EnPI_NameTextBox.TabIndex = 2
        '
        'EnPI_UnitsTextBox
        '
        Me.EnPI_UnitsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnPI_BaselineBindingSource, "EnPI_Units", True))
        Me.EnPI_UnitsTextBox.Location = New System.Drawing.Point(73, 41)
        Me.EnPI_UnitsTextBox.Name = "EnPI_UnitsTextBox"
        Me.EnPI_UnitsTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EnPI_UnitsTextBox.TabIndex = 4
        '
        'EnPI_Baseline_DataBindingSource
        '
        Me.EnPI_Baseline_DataBindingSource.DataMember = "PK_EnPI_Baseline_FK"
        Me.EnPI_Baseline_DataBindingSource.DataSource = Me.EnPI_BaselineBindingSource
        '
        'EnPI_Baseline_DataDataGridView
        '
        Me.EnPI_Baseline_DataDataGridView.AutoGenerateColumns = False
        Me.EnPI_Baseline_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EnPI_Baseline_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.EnPI_ActualValue, Me.DataGridViewTextBoxColumn4})
        Me.EnPI_Baseline_DataDataGridView.DataSource = Me.EnPI_Baseline_DataBindingSource
        Me.EnPI_Baseline_DataDataGridView.Location = New System.Drawing.Point(0, 182)
        Me.EnPI_Baseline_DataDataGridView.Name = "EnPI_Baseline_DataDataGridView"
        Me.EnPI_Baseline_DataDataGridView.RowHeadersVisible = False
        Me.EnPI_Baseline_DataDataGridView.Size = New System.Drawing.Size(444, 385)
        Me.EnPI_Baseline_DataDataGridView.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EnPI_SEUCheckBox)
        Me.GroupBox1.Controls.Add(EnPI_TargetLabel)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.EnPI_TargetTextBox)
        Me.GroupBox1.Controls.Add(Me.EnPI_NameTextBox)
        Me.GroupBox1.Controls.Add(EnPI_IntervalLabel)
        Me.GroupBox1.Controls.Add(EnPI_NameLabel)
        Me.GroupBox1.Controls.Add(Me.EnPI_UnitsTextBox)
        Me.GroupBox1.Controls.Add(EnPI_UnitsLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 148)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Baseline"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 65)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'EnPI_SEUCheckBox
        '
        Me.EnPI_SEUCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EnPI_BaselineBindingSource, "EnPI_SEU", True))
        Me.EnPI_SEUCheckBox.Location = New System.Drawing.Point(73, 79)
        Me.EnPI_SEUCheckBox.Name = "EnPI_SEUCheckBox"
        Me.EnPI_SEUCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.EnPI_SEUCheckBox.TabIndex = 10
        Me.EnPI_SEUCheckBox.Text = "SEU"
        Me.EnPI_SEUCheckBox.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Dailey", "Weekly", "Monthly"})
        Me.ComboBox1.Location = New System.Drawing.Point(298, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'EnPI_TargetTextBox
        '
        Me.EnPI_TargetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnPI_BaselineBindingSource, "EnPI_Target", True))
        Me.EnPI_TargetTextBox.Location = New System.Drawing.Point(298, 44)
        Me.EnPI_TargetTextBox.Name = "EnPI_TargetTextBox"
        Me.EnPI_TargetTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EnPI_TargetTextBox.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EnPI_Baseline_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EnPI_Baseline_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EnPI_Index"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EnPI_Index"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EnPI_Value"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Baseline"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Baseline value for comparison"
        '
        'EnPI_ActualValue
        '
        Me.EnPI_ActualValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EnPI_ActualValue.DataPropertyName = "EnPI_ActualValue"
        Me.EnPI_ActualValue.HeaderText = "Value"
        Me.EnPI_ActualValue.Name = "EnPI_ActualValue"
        Me.EnPI_ActualValue.ToolTipText = "Measured Value"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EnPI_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "Date of measurement"
        Me.DataGridViewTextBoxColumn4.Width = 55
        '
        'Baseline_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 587)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EnPI_Baseline_DataDataGridView)
        Me.Controls.Add(Me.EnPI_BaselineBindingNavigator)
        Me.Name = "Baseline_Form"
        Me.Text = "EnPI Baselines"
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnPI_BaselineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnPI_BaselineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnPI_BaselineBindingNavigator.ResumeLayout(False)
        Me.EnPI_BaselineBindingNavigator.PerformLayout()
        CType(Me.EnPI_Baseline_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnPI_Baseline_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents EnPI_BaselineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnPI_BaselineTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_BaselineTableAdapter
    Friend WithEvents TableAdapterManager As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EnPI_BaselineBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EnPI_BaselineBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EnPI_Baseline_DataTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_Baseline_DataTableAdapter
    Friend WithEvents EnPI_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnPI_UnitsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnPI_Baseline_DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnPI_Baseline_DataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents EnPI_TargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnPI_SEUCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnPI_ActualValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
