<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Top_ManagmentLabel As System.Windows.Forms.Label
        Dim Managment_RepLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employees))
        Me.EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
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
        Me.EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Top_ManagmentCheckBox = New System.Windows.Forms.CheckBox()
        Me.Managment_RepCheckBox = New System.Windows.Forms.CheckBox()
        Me.QualificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualificationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeesTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.QualificationsTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.QualificationsTableAdapter()
        Me.ChangeLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangeLogTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.ChangeLogTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Top_ManagmentLabel = New System.Windows.Forms.Label()
        Managment_RepLabel = New System.Windows.Forms.Label()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangeLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(64, 50)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(64, 76)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Top_ManagmentLabel
        '
        Top_ManagmentLabel.AutoSize = True
        Top_ManagmentLabel.Location = New System.Drawing.Point(51, 104)
        Top_ManagmentLabel.Name = "Top_ManagmentLabel"
        Top_ManagmentLabel.Size = New System.Drawing.Size(88, 13)
        Top_ManagmentLabel.TabIndex = 7
        Top_ManagmentLabel.Text = "Top Managment:"
        '
        'Managment_RepLabel
        '
        Managment_RepLabel.AutoSize = True
        Managment_RepLabel.Location = New System.Drawing.Point(174, 104)
        Managment_RepLabel.Name = "Managment_RepLabel"
        Managment_RepLabel.Size = New System.Drawing.Size(137, 13)
        Managment_RepLabel.TabIndex = 9
        Managment_RepLabel.Text = "Managment Representitive:"
        '
        'EmployeesBindingNavigator
        '
        Me.EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeesBindingNavigator.BindingSource = Me.EmployeesBindingSource
        Me.EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeesBindingNavigatorSaveItem})
        Me.EmployeesBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeesBindingNavigator.Name = "EmployeesBindingNavigator"
        Me.EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(610, 25)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(159, 47)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(152, 20)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(159, 73)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(152, 20)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Top_ManagmentCheckBox
        '
        Me.Top_ManagmentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmployeesBindingSource, "Top_Managment", True))
        Me.Top_ManagmentCheckBox.Location = New System.Drawing.Point(146, 99)
        Me.Top_ManagmentCheckBox.Name = "Top_ManagmentCheckBox"
        Me.Top_ManagmentCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Top_ManagmentCheckBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Top_ManagmentCheckBox, resources.GetString("Top_ManagmentCheckBox.ToolTip"))
        Me.Top_ManagmentCheckBox.UseVisualStyleBackColor = True
        '
        'Managment_RepCheckBox
        '
        Me.Managment_RepCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EmployeesBindingSource, "Managment_Rep", True))
        Me.Managment_RepCheckBox.Location = New System.Drawing.Point(317, 99)
        Me.Managment_RepCheckBox.Name = "Managment_RepCheckBox"
        Me.Managment_RepCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Managment_RepCheckBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Managment_RepCheckBox, resources.GetString("Managment_RepCheckBox.ToolTip"))
        Me.Managment_RepCheckBox.UseVisualStyleBackColor = True
        '
        'QualificationsBindingSource
        '
        Me.QualificationsBindingSource.DataMember = "FK_Qualifications_Employees"
        Me.QualificationsBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'QualificationsDataGridView
        '
        Me.QualificationsDataGridView.AutoGenerateColumns = False
        Me.QualificationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QualificationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.QualificationsDataGridView.DataSource = Me.QualificationsBindingSource
        Me.QualificationsDataGridView.Location = New System.Drawing.Point(0, 129)
        Me.QualificationsDataGridView.Name = "QualificationsDataGridView"
        Me.QualificationsDataGridView.RowHeadersVisible = False
        Me.QualificationsDataGridView.Size = New System.Drawing.Size(610, 313)
        Me.QualificationsDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Qualification_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Qualification_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Qualification_Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qualification Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Qualification_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qualification Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChangeLogTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.Energy_PolicyTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_Baseline_DataTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_BaselineTableAdapter = Nothing
        'Me.TableAdapterManager.EnPI_DataTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Me.QualificationsTableAdapter
        Me.TableAdapterManager.RecordTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QualificationsTableAdapter
        '
        Me.QualificationsTableAdapter.ClearBeforeFill = True
        '
        'ChangeLogBindingSource
        '
        Me.ChangeLogBindingSource.DataMember = "ChangeLog"
        Me.ChangeLogBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'ChangeLogTableAdapter
        '
        Me.ChangeLogTableAdapter.ClearBeforeFill = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 440)
        Me.Controls.Add(Me.QualificationsDataGridView)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Top_ManagmentLabel)
        Me.Controls.Add(Me.Top_ManagmentCheckBox)
        Me.Controls.Add(Managment_RepLabel)
        Me.Controls.Add(Me.Managment_RepCheckBox)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Employees"
        Me.Text = "Employee Managment"
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangeLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmployeesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QualificationsTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.QualificationsTableAdapter
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Top_ManagmentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Managment_RepCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QualificationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QualificationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ChangeLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChangeLogTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.ChangeLogTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
