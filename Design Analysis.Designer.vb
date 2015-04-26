<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Design_Analysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Design_Analysis))
        Dim Design_NameLabel As System.Windows.Forms.Label
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
        Me.DesignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesignTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.DesignTableAdapter()
        Me.TableAdapterManager = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.DesignBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DesignBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Design_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Design_ReportTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Design_NameLabel = New System.Windows.Forms.Label()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DesignBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DesignBindingSource
        '
        Me.DesignBindingSource.DataMember = "Design"
        Me.DesignBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'DesignTableAdapter
        '
        Me.DesignTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChangeLogTableAdapter = Nothing
        Me.TableAdapterManager.DesignTableAdapter = Me.DesignTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Energy_PolicyTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_Baseline_DataTableAdapter = Nothing
        Me.TableAdapterManager.EnPI_BaselineTableAdapter = Nothing
        'Me.TableAdapterManager.EnPI_DataTableAdapter = Nothing
        Me.TableAdapterManager.ProcurementTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.RecordTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DesignBindingNavigator
        '
        Me.DesignBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DesignBindingNavigator.BindingSource = Me.DesignBindingSource
        Me.DesignBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DesignBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DesignBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DesignBindingNavigatorSaveItem})
        Me.DesignBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DesignBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DesignBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DesignBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DesignBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DesignBindingNavigator.Name = "DesignBindingNavigator"
        Me.DesignBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DesignBindingNavigator.Size = New System.Drawing.Size(570, 25)
        Me.DesignBindingNavigator.TabIndex = 0
        Me.DesignBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DesignBindingNavigatorSaveItem
        '
        Me.DesignBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DesignBindingNavigatorSaveItem.Image = CType(resources.GetObject("DesignBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DesignBindingNavigatorSaveItem.Name = "DesignBindingNavigatorSaveItem"
        Me.DesignBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DesignBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Design_NameLabel
        '
        Design_NameLabel.AutoSize = True
        Design_NameLabel.Location = New System.Drawing.Point(8, 22)
        Design_NameLabel.Name = "Design_NameLabel"
        Design_NameLabel.Size = New System.Drawing.Size(74, 13)
        Design_NameLabel.TabIndex = 1
        Design_NameLabel.Text = "Design Name:"
        '
        'Design_NameTextBox
        '
        Me.Design_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DesignBindingSource, "Design_Name", True))
        Me.Design_NameTextBox.Location = New System.Drawing.Point(88, 19)
        Me.Design_NameTextBox.Name = "Design_NameTextBox"
        Me.Design_NameTextBox.Size = New System.Drawing.Size(251, 20)
        Me.Design_NameTextBox.TabIndex = 2
        '
        'Design_ReportTextBox
        '
        Me.Design_ReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DesignBindingSource, "Design_Report", True))
        Me.Design_ReportTextBox.Location = New System.Drawing.Point(6, 82)
        Me.Design_ReportTextBox.Multiline = True
        Me.Design_ReportTextBox.Name = "Design_ReportTextBox"
        Me.Design_ReportTextBox.Size = New System.Drawing.Size(533, 440)
        Me.Design_ReportTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Design_ReportTextBox)
        Me.GroupBox1.Controls.Add(Design_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Design_NameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 528)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Design Analysis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Explain the results of the energy performance evaluation for the design or modifi" & _
    "cation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of new facilities equipment, or systems which have an effect on SEU's"
        '
        'Design_Analysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 563)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DesignBindingNavigator)
        Me.Name = "Design_Analysis"
        Me.Text = "Design Analysis"
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DesignBindingNavigator.ResumeLayout(False)
        Me.DesignBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents DesignBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DesignTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.DesignTableAdapter
    Friend WithEvents TableAdapterManager As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DesignBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DesignBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Design_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Design_ReportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
