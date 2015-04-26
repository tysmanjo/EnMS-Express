<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnMS_Main
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnMS_Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnPIsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergyPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcurementAnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnPI_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.EnPI_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnPI_ComboBox = New System.Windows.Forms.ComboBox()
        Me.EnMS_Queue_Groupbox = New System.Windows.Forms.GroupBox()
        Me.ReviewDateText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.openEventButton = New System.Windows.Forms.Button()
        Me.EventsListBox = New System.Windows.Forms.ListBox()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.EnPI_BaselineTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_BaselineTableAdapter()
        Me.EnPI_BaselineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnMSDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnPI_Baseline_DataTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_Baseline_DataTableAdapter()
        Me.RecordTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.RecordTableAdapter()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.EnPI_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EnPI_GroupBox.SuspendLayout()
        Me.EnMS_Queue_Groupbox.SuspendLayout()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnPI_BaselineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnMSDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.EnMSToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EnMSToolStripMenuItem
        '
        Me.EnMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnPIsToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.EnergyPolicyToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ProcurementAnalysisToolStripMenuItem})
        Me.EnMSToolStripMenuItem.Name = "EnMSToolStripMenuItem"
        Me.EnMSToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EnMSToolStripMenuItem.Text = "EnMS"
        '
        'EnPIsToolStripMenuItem
        '
        Me.EnPIsToolStripMenuItem.Name = "EnPIsToolStripMenuItem"
        Me.EnPIsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EnPIsToolStripMenuItem.Text = "EnPI Managment"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'EnergyPolicyToolStripMenuItem
        '
        Me.EnergyPolicyToolStripMenuItem.Name = "EnergyPolicyToolStripMenuItem"
        Me.EnergyPolicyToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.EnergyPolicyToolStripMenuItem.Text = "Energy Policy"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'ProcurementAnalysisToolStripMenuItem
        '
        Me.ProcurementAnalysisToolStripMenuItem.Name = "ProcurementAnalysisToolStripMenuItem"
        Me.ProcurementAnalysisToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ProcurementAnalysisToolStripMenuItem.Text = "Procurement Analysis"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ChangeLogToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ChangeLogToolStripMenuItem
        '
        Me.ChangeLogToolStripMenuItem.Name = "ChangeLogToolStripMenuItem"
        Me.ChangeLogToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ChangeLogToolStripMenuItem.Text = "Change Log"
        '
        'EnPI_Chart
        '
        ChartArea1.Name = "ChartArea1"
        Me.EnPI_Chart.ChartAreas.Add(ChartArea1)
        Me.EnPI_Chart.Location = New System.Drawing.Point(6, 19)
        Me.EnPI_Chart.Name = "EnPI_Chart"
        Me.EnPI_Chart.Size = New System.Drawing.Size(456, 302)
        Me.EnPI_Chart.TabIndex = 1
        Me.EnPI_Chart.Text = "EnPI_Chart"
        '
        'EnPI_GroupBox
        '
        Me.EnPI_GroupBox.Controls.Add(Me.Label1)
        Me.EnPI_GroupBox.Controls.Add(Me.EnPI_ComboBox)
        Me.EnPI_GroupBox.Controls.Add(Me.EnPI_Chart)
        Me.EnPI_GroupBox.Location = New System.Drawing.Point(12, 27)
        Me.EnPI_GroupBox.Name = "EnPI_GroupBox"
        Me.EnPI_GroupBox.Size = New System.Drawing.Size(468, 373)
        Me.EnPI_GroupBox.TabIndex = 2
        Me.EnPI_GroupBox.TabStop = False
        Me.EnPI_GroupBox.Text = "EnPI Tracking"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EnPI: "
        '
        'EnPI_ComboBox
        '
        Me.EnPI_ComboBox.FormattingEnabled = True
        Me.EnPI_ComboBox.Location = New System.Drawing.Point(50, 339)
        Me.EnPI_ComboBox.Name = "EnPI_ComboBox"
        Me.EnPI_ComboBox.Size = New System.Drawing.Size(173, 21)
        Me.EnPI_ComboBox.TabIndex = 2
        '
        'EnMS_Queue_Groupbox
        '
        Me.EnMS_Queue_Groupbox.Controls.Add(Me.ReviewDateText)
        Me.EnMS_Queue_Groupbox.Controls.Add(Me.Label2)
        Me.EnMS_Queue_Groupbox.Controls.Add(Me.openEventButton)
        Me.EnMS_Queue_Groupbox.Controls.Add(Me.EventsListBox)
        Me.EnMS_Queue_Groupbox.Location = New System.Drawing.Point(486, 27)
        Me.EnMS_Queue_Groupbox.Name = "EnMS_Queue_Groupbox"
        Me.EnMS_Queue_Groupbox.Size = New System.Drawing.Size(327, 373)
        Me.EnMS_Queue_Groupbox.TabIndex = 3
        Me.EnMS_Queue_Groupbox.TabStop = False
        Me.EnMS_Queue_Groupbox.Text = "Upcoming Events"
        '
        'ReviewDateText
        '
        Me.ReviewDateText.AutoSize = True
        Me.ReviewDateText.Location = New System.Drawing.Point(191, 342)
        Me.ReviewDateText.Name = "ReviewDateText"
        Me.ReviewDateText.Size = New System.Drawing.Size(10, 13)
        Me.ReviewDateText.TabIndex = 3
        Me.ReviewDateText.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Review Date:"
        '
        'openEventButton
        '
        Me.openEventButton.Location = New System.Drawing.Point(20, 337)
        Me.openEventButton.Name = "openEventButton"
        Me.openEventButton.Size = New System.Drawing.Size(75, 23)
        Me.openEventButton.TabIndex = 1
        Me.openEventButton.Text = "Open"
        Me.openEventButton.UseVisualStyleBackColor = True
        '
        'EventsListBox
        '
        Me.EventsListBox.DataSource = Me.RecordBindingSource
        Me.EventsListBox.DisplayMember = "Title"
        Me.EventsListBox.FormattingEnabled = True
        Me.EventsListBox.Location = New System.Drawing.Point(6, 19)
        Me.EventsListBox.Name = "EventsListBox"
        Me.EventsListBox.Size = New System.Drawing.Size(313, 303)
        Me.EventsListBox.TabIndex = 0
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        Me.RecordBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 406)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(821, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'EnPI_BaselineTableAdapter
        '
        Me.EnPI_BaselineTableAdapter.ClearBeforeFill = True
        '
        'EnPI_BaselineBindingSource
        '
        Me.EnPI_BaselineBindingSource.DataMember = "EnPI_Baseline"
        Me.EnPI_BaselineBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        '
        'EnMSDatabaseDataSetBindingSource
        '
        Me.EnMSDatabaseDataSetBindingSource.DataSource = Me.EnMS_DatabaseDataSet
        Me.EnMSDatabaseDataSetBindingSource.Position = 0
        '
        'EnPI_Baseline_DataTableAdapter
        '
        Me.EnPI_Baseline_DataTableAdapter.ClearBeforeFill = True
        '
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'EnMS_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 428)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EnMS_Queue_Groupbox)
        Me.Controls.Add(Me.EnPI_GroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EnMS_Main"
        Me.Text = "EnMS_Express"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.EnPI_Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EnPI_GroupBox.ResumeLayout(False)
        Me.EnPI_GroupBox.PerformLayout()
        Me.EnMS_Queue_Groupbox.ResumeLayout(False)
        Me.EnMS_Queue_Groupbox.PerformLayout()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnPI_BaselineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnMSDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnergyPolicyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnPIsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnPI_Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents EnPI_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EnMS_Queue_Groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents EnPI_BaselineTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_BaselineTableAdapter
    Friend WithEvents EnPI_BaselineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnMSDatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnPI_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EnPI_Baseline_DataTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.EnPI_Baseline_DataTableAdapter
    Friend WithEvents openEventButton As System.Windows.Forms.Button
    Friend WithEvents EventsListBox As System.Windows.Forms.ListBox
    Friend WithEvents RecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecordTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents ReviewDateText As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ProcurementAnalysisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
