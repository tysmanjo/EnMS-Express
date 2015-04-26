<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Records
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
        Dim TitleLabel As System.Windows.Forms.Label
        Dim RecordTypeLabel As System.Windows.Forms.Label
        Dim ReviewCompleteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Records))
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.RecordBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RecordBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.ReviewDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DescriptionTextTextBox = New System.Windows.Forms.TextBox()
        Me.ReviewTextTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitterComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReviewCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RecordTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EmployeesTableAdapter()
        TitleLabel = New System.Windows.Forms.Label()
        RecordTypeLabel = New System.Windows.Forms.Label()
        ReviewCompleteLabel = New System.Windows.Forms.Label()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(50, 19)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'RecordTypeLabel
        '
        RecordTypeLabel.AutoSize = True
        RecordTypeLabel.Location = New System.Drawing.Point(8, 72)
        RecordTypeLabel.Name = "RecordTypeLabel"
        RecordTypeLabel.Size = New System.Drawing.Size(72, 13)
        RecordTypeLabel.TabIndex = 5
        RecordTypeLabel.Text = "Record Type:"
        '
        'ReviewCompleteLabel
        '
        ReviewCompleteLabel.AutoSize = True
        ReviewCompleteLabel.Location = New System.Drawing.Point(7, 52)
        ReviewCompleteLabel.Name = "ReviewCompleteLabel"
        ReviewCompleteLabel.Size = New System.Drawing.Size(93, 13)
        ReviewCompleteLabel.TabIndex = 18
        ReviewCompleteLabel.Text = "Review Complete:"
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        Me.RecordBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChangeLogTableAdapter = Nothing
        Me.TableAdapterManager.DesignTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Energy_PolicyTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_Baseline_DataTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_BaselineTableAdapter = Nothing
        Me.TableAdapterManager.ProcurementTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.RecordTableAdapter = Me.RecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RecordBindingNavigator
        '
        Me.RecordBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecordBindingNavigator.BindingSource = Me.RecordBindingSource
        Me.RecordBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RecordBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RecordBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecordBindingNavigatorSaveItem})
        Me.RecordBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.RecordBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecordBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecordBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecordBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecordBindingNavigator.Name = "RecordBindingNavigator"
        Me.RecordBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecordBindingNavigator.Size = New System.Drawing.Size(962, 25)
        Me.RecordBindingNavigator.TabIndex = 0
        Me.RecordBindingNavigator.Text = "BindingNavigator1"
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
        'RecordBindingNavigatorSaveItem
        '
        Me.RecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecordBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecordBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecordBindingNavigatorSaveItem.Name = "RecordBindingNavigatorSaveItem"
        Me.RecordBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RecordBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(86, 13)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(356, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'ReviewDateDateTimePicker
        '
        Me.ReviewDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource, "ReviewDate", True))
        Me.ReviewDateDateTimePicker.Location = New System.Drawing.Point(106, 20)
        Me.ReviewDateDateTimePicker.Name = "ReviewDateDateTimePicker"
        Me.ReviewDateDateTimePicker.Size = New System.Drawing.Size(225, 20)
        Me.ReviewDateDateTimePicker.TabIndex = 10
        '
        'DescriptionTextTextBox
        '
        Me.DescriptionTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "DescriptionText", True))
        Me.DescriptionTextTextBox.Location = New System.Drawing.Point(6, 116)
        Me.DescriptionTextTextBox.Multiline = True
        Me.DescriptionTextTextBox.Name = "DescriptionTextTextBox"
        Me.DescriptionTextTextBox.Size = New System.Drawing.Size(436, 397)
        Me.DescriptionTextTextBox.TabIndex = 14
        '
        'ReviewTextTextBox
        '
        Me.ReviewTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "ReviewText", True))
        Me.ReviewTextTextBox.Location = New System.Drawing.Point(6, 72)
        Me.ReviewTextTextBox.Multiline = True
        Me.ReviewTextTextBox.Name = "ReviewTextTextBox"
        Me.ReviewTextTextBox.Size = New System.Drawing.Size(475, 441)
        Me.ReviewTextTextBox.TabIndex = 16
        '
        'SubmitterComboBox
        '
        Me.SubmitterComboBox.FormattingEnabled = True
        Me.SubmitterComboBox.Location = New System.Drawing.Point(86, 39)
        Me.SubmitterComboBox.Name = "SubmitterComboBox"
        Me.SubmitterComboBox.Size = New System.Drawing.Size(356, 21)
        Me.SubmitterComboBox.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ReviewCompleteLabel)
        Me.GroupBox1.Controls.Add(Me.ReviewCompleteCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ReviewDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.ReviewTextTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(466, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 528)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Review"
        '
        'ReviewCompleteCheckBox
        '
        Me.ReviewCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RecordBindingSource, "ReviewComplete", True))
        Me.ReviewCompleteCheckBox.Location = New System.Drawing.Point(121, 47)
        Me.ReviewCompleteCheckBox.Name = "ReviewCompleteCheckBox"
        Me.ReviewCompleteCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.ReviewCompleteCheckBox.TabIndex = 19
        Me.ReviewCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Set Review Date: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Review/Resolution Text"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RecordTypeComboBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.SubmitterComboBox)
        Me.GroupBox2.Controls.Add(Me.DescriptionTextTextBox)
        Me.GroupBox2.Controls.Add(RecordTypeLabel)
        Me.GroupBox2.Controls.Add(TitleLabel)
        Me.GroupBox2.Controls.Add(Me.TitleTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 528)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Submission"
        '
        'RecordTypeComboBox
        '
        Me.RecordTypeComboBox.FormattingEnabled = True
        Me.RecordTypeComboBox.Items.AddRange(New Object() {"Nonconformity", "Correction", "Corrective Action", "Preventitive Action"})
        Me.RecordTypeComboBox.Location = New System.Drawing.Point(86, 67)
        Me.RecordTypeComboBox.Name = "RecordTypeComboBox"
        Me.RecordTypeComboBox.Size = New System.Drawing.Size(356, 21)
        Me.RecordTypeComboBox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Description Text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Submitter:"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 24)
        Me.MenuStrip1.TabIndex = 20
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
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 580)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RecordBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Records"
        Me.Text = "Records"
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordBindingNavigator.ResumeLayout(False)
        Me.RecordBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents RecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecordTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RecordBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReviewDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DescriptionTextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReviewTextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RecordTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReviewCompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeesTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EmployeesTableAdapter
End Class
