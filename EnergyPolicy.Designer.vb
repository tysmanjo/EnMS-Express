<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnergyPolicy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnergyPolicy))
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
        Me.Energy_PolicyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Energy_PolicyTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.Energy_PolicyTableAdapter()
        Me.TableAdapterManager = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Energy_PolicyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Energy_PolicyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Policy_TextTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EmployeesTableAdapter()
        Me.FKQualificationsEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualificationsTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.QualificationsTableAdapter()
        Me.SubmitterCombo = New System.Windows.Forms.ComboBox()
        Me.FKQualificationsEmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChangeLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangeLogTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.ChangeLogTableAdapter()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxA = New System.Windows.Forms.CheckBox()
        Me.RequirementsText = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxH = New System.Windows.Forms.CheckBox()
        Me.CheckBoxG = New System.Windows.Forms.CheckBox()
        Me.CheckBoxF = New System.Windows.Forms.CheckBox()
        Me.CheckBoxE = New System.Windows.Forms.CheckBox()
        Me.CheckBoxD = New System.Windows.Forms.CheckBox()
        Me.CheckBox1C = New System.Windows.Forms.CheckBox()
        Me.CheckBoxB = New System.Windows.Forms.CheckBox()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Energy_PolicyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Energy_PolicyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Energy_PolicyBindingNavigator.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKQualificationsEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKQualificationsEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangeLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Energy_PolicyBindingSource
        '
        Me.Energy_PolicyBindingSource.DataMember = "Energy_Policy"
        Me.Energy_PolicyBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'Energy_PolicyTableAdapter
        '
        Me.Energy_PolicyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChangeLogTableAdapter = Nothing
        Me.TableAdapterManager.DesignTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Energy_PolicyTableAdapter = Me.Energy_PolicyTableAdapter
        Me.TableAdapterManager.EnPI_Baseline_DataTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_BaselineTableAdapter = Nothing
        Me.TableAdapterManager.ProcurementTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.RecordTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Energy_PolicyBindingNavigator
        '
        Me.Energy_PolicyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Energy_PolicyBindingNavigator.BindingSource = Me.Energy_PolicyBindingSource
        Me.Energy_PolicyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Energy_PolicyBindingNavigator.DeleteItem = Nothing
        Me.Energy_PolicyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Energy_PolicyBindingNavigatorSaveItem})
        Me.Energy_PolicyBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.Energy_PolicyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Energy_PolicyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Energy_PolicyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Energy_PolicyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Energy_PolicyBindingNavigator.Name = "Energy_PolicyBindingNavigator"
        Me.Energy_PolicyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Energy_PolicyBindingNavigator.Size = New System.Drawing.Size(733, 25)
        Me.Energy_PolicyBindingNavigator.TabIndex = 0
        Me.Energy_PolicyBindingNavigator.Text = "BindingNavigator1"
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
        'Energy_PolicyBindingNavigatorSaveItem
        '
        Me.Energy_PolicyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Energy_PolicyBindingNavigatorSaveItem.Image = CType(resources.GetObject("Energy_PolicyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Energy_PolicyBindingNavigatorSaveItem.Name = "Energy_PolicyBindingNavigatorSaveItem"
        Me.Energy_PolicyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Energy_PolicyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Policy_TextTextBox
        '
        Me.Policy_TextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Energy_PolicyBindingSource, "Policy_Text", True))
        Me.Policy_TextTextBox.Location = New System.Drawing.Point(0, 52)
        Me.Policy_TextTextBox.Multiline = True
        Me.Policy_TextTextBox.Name = "Policy_TextTextBox"
        Me.Policy_TextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Policy_TextTextBox.Size = New System.Drawing.Size(733, 293)
        Me.Policy_TextTextBox.TabIndex = 2
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employees"
        Me.EmployeeBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'FKQualificationsEmployeesBindingSource
        '
        Me.FKQualificationsEmployeesBindingSource.DataMember = "FK_Qualifications_Employees"
        Me.FKQualificationsEmployeesBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'QualificationsTableAdapter
        '
        Me.QualificationsTableAdapter.ClearBeforeFill = True
        '
        'SubmitterCombo
        '
        Me.SubmitterCombo.FormattingEnabled = True
        Me.SubmitterCombo.Location = New System.Drawing.Point(510, 602)
        Me.SubmitterCombo.Name = "SubmitterCombo"
        Me.SubmitterCombo.Size = New System.Drawing.Size(137, 21)
        Me.SubmitterCombo.TabIndex = 3
        Me.SubmitterCombo.Text = "Submitter"
        '
        'FKQualificationsEmployeesBindingSource1
        '
        Me.FKQualificationsEmployeesBindingSource1.DataMember = "FK_Qualifications_Employees"
        Me.FKQualificationsEmployeesBindingSource1.DataSource = Me.EmployeeBindingSource
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "View Historical Energy Policies"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 605)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Submitter"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 6
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
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CheckBoxA
        '
        Me.CheckBoxA.AutoSize = True
        Me.CheckBoxA.Location = New System.Drawing.Point(16, 19)
        Me.CheckBoxA.Name = "CheckBoxA"
        Me.CheckBoxA.Size = New System.Drawing.Size(479, 17)
        Me.CheckBoxA.TabIndex = 7
        Me.CheckBoxA.Text = "This policy is appropriate to the nature and scale of the organizer's energy use " & _
    "and consumption."
        Me.CheckBoxA.UseVisualStyleBackColor = True
        '
        'RequirementsText
        '
        Me.RequirementsText.AutoSize = True
        Me.RequirementsText.Location = New System.Drawing.Point(13, 352)
        Me.RequirementsText.Name = "RequirementsText"
        Me.RequirementsText.Size = New System.Drawing.Size(362, 13)
        Me.RequirementsText.TabIndex = 8
        Me.RequirementsText.Text = "This policy meet the following requirements to be compliant with ISO 50001:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxH)
        Me.GroupBox1.Controls.Add(Me.CheckBoxG)
        Me.GroupBox1.Controls.Add(Me.CheckBoxF)
        Me.GroupBox1.Controls.Add(Me.CheckBoxE)
        Me.GroupBox1.Controls.Add(Me.CheckBoxD)
        Me.GroupBox1.Controls.Add(Me.CheckBox1C)
        Me.GroupBox1.Controls.Add(Me.CheckBoxB)
        Me.GroupBox1.Controls.Add(Me.CheckBoxA)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 221)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requirements"
        '
        'CheckBoxH
        '
        Me.CheckBoxH.AutoSize = True
        Me.CheckBoxH.Location = New System.Drawing.Point(16, 198)
        Me.CheckBoxH.Name = "CheckBoxH"
        Me.CheckBoxH.Size = New System.Drawing.Size(253, 17)
        Me.CheckBoxH.TabIndex = 14
        Me.CheckBoxH.Text = "Is regularly reviewed, and updated as necessary"
        Me.CheckBoxH.UseVisualStyleBackColor = True
        '
        'CheckBoxG
        '
        Me.CheckBoxG.AutoSize = True
        Me.CheckBoxG.Location = New System.Drawing.Point(16, 175)
        Me.CheckBoxG.Name = "CheckBoxG"
        Me.CheckBoxG.Size = New System.Drawing.Size(352, 17)
        Me.CheckBoxG.TabIndex = 13
        Me.CheckBoxG.Text = "Is documented and communicated at all levels within the organization"
        Me.CheckBoxG.UseVisualStyleBackColor = True
        '
        'CheckBoxF
        '
        Me.CheckBoxF.AutoSize = True
        Me.CheckBoxF.Location = New System.Drawing.Point(16, 151)
        Me.CheckBoxF.Name = "CheckBoxF"
        Me.CheckBoxF.Size = New System.Drawing.Size(563, 17)
        Me.CheckBoxF.TabIndex = 12
        Me.CheckBoxF.Text = "Supports the purchase of energy-efficient products and services, and design for e" & _
    "nergy performance improvement."
        Me.CheckBoxF.UseVisualStyleBackColor = True
        '
        'CheckBoxE
        '
        Me.CheckBoxE.AutoSize = True
        Me.CheckBoxE.Location = New System.Drawing.Point(16, 127)
        Me.CheckBoxE.Name = "CheckBoxE"
        Me.CheckBoxE.Size = New System.Drawing.Size(400, 17)
        Me.CheckBoxE.TabIndex = 11
        Me.CheckBoxE.Text = "Provides the framework for setting and reviewing energy objectives and targets."
        Me.CheckBoxE.UseVisualStyleBackColor = True
        '
        'CheckBoxD
        '
        Me.CheckBoxD.AutoSize = True
        Me.CheckBoxD.Location = New System.Drawing.Point(16, 90)
        Me.CheckBoxD.Name = "CheckBoxD"
        Me.CheckBoxD.Size = New System.Drawing.Size(575, 30)
        Me.CheckBoxD.TabIndex = 10
        Me.CheckBoxD.Text = "Includes a commitment to comply with applicable legal requirements and other requ" & _
    "irements to which the organization" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " subscribes related to its energy use, consu" & _
    "mption, and efficiency"
        Me.CheckBoxD.UseVisualStyleBackColor = True
        '
        'CheckBox1C
        '
        Me.CheckBox1C.AutoSize = True
        Me.CheckBox1C.Location = New System.Drawing.Point(16, 66)
        Me.CheckBox1C.Name = "CheckBox1C"
        Me.CheckBox1C.Size = New System.Drawing.Size(606, 17)
        Me.CheckBox1C.TabIndex = 9
        Me.CheckBox1C.Text = "Includes a commitment to ensure the availability of information and of necessary " & _
    "resources to achive objectives and targets."
        Me.CheckBox1C.UseVisualStyleBackColor = True
        '
        'CheckBoxB
        '
        Me.CheckBoxB.AutoSize = True
        Me.CheckBoxB.Location = New System.Drawing.Point(16, 42)
        Me.CheckBoxB.Name = "CheckBoxB"
        Me.CheckBoxB.Size = New System.Drawing.Size(366, 17)
        Me.CheckBoxB.TabIndex = 8
        Me.CheckBoxB.Text = "Includes a commitment to continual improvement in energy performance."
        Me.CheckBoxB.UseVisualStyleBackColor = True
        '
        'EnergyPolicy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 632)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RequirementsText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SubmitterCombo)
        Me.Controls.Add(Me.Policy_TextTextBox)
        Me.Controls.Add(Me.Energy_PolicyBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EnergyPolicy"
        Me.Text = "Energy Policy"
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Energy_PolicyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Energy_PolicyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Energy_PolicyBindingNavigator.ResumeLayout(False)
        Me.Energy_PolicyBindingNavigator.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKQualificationsEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKQualificationsEmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangeLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents Energy_PolicyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Energy_PolicyTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.Energy_PolicyTableAdapter
    Friend WithEvents TableAdapterManager As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Energy_PolicyBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Energy_PolicyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Policy_TextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents FKQualificationsEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QualificationsTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.QualificationsTableAdapter
    Friend WithEvents SubmitterCombo As System.Windows.Forms.ComboBox
    Friend WithEvents FKQualificationsEmployeesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChangeLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChangeLogTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.ChangeLogTableAdapter
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1C As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxB As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxA As System.Windows.Forms.CheckBox
    Friend WithEvents RequirementsText As System.Windows.Forms.Label
    Friend WithEvents CheckBoxD As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxE As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxH As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxG As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxF As System.Windows.Forms.CheckBox
End Class
