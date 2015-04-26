<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Energy_Policies
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
        Me.PrevPolicy = New System.Windows.Forms.Button()
        Me.DateLable = New System.Windows.Forms.Label()
        Me.NextPolicy = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PolicyDate = New System.Windows.Forms.Label()
        Me.PolicySubmitterLable = New System.Windows.Forms.Label()
        Me.PolicySubmitter = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnMS_DatabaseDataSet = New EnMS_Express.EnMS_DatabaseDataSet()
        Me.Energy_PolicyTableAdapter = New EnMS_Express.EnMS_DatabaseDataSetTableAdapters.Energy_PolicyTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrevPolicy
        '
        Me.PrevPolicy.Location = New System.Drawing.Point(124, 564)
        Me.PrevPolicy.Name = "PrevPolicy"
        Me.PrevPolicy.Size = New System.Drawing.Size(75, 23)
        Me.PrevPolicy.TabIndex = 1
        Me.PrevPolicy.Text = "Previous"
        Me.PrevPolicy.UseVisualStyleBackColor = True
        '
        'DateLable
        '
        Me.DateLable.AutoSize = True
        Me.DateLable.Location = New System.Drawing.Point(353, 569)
        Me.DateLable.Name = "DateLable"
        Me.DateLable.Size = New System.Drawing.Size(36, 13)
        Me.DateLable.TabIndex = 2
        Me.DateLable.Text = "Date: "
        '
        'NextPolicy
        '
        Me.NextPolicy.Location = New System.Drawing.Point(236, 564)
        Me.NextPolicy.Name = "NextPolicy"
        Me.NextPolicy.Size = New System.Drawing.Size(75, 23)
        Me.NextPolicy.TabIndex = 3
        Me.NextPolicy.Text = "Next"
        Me.NextPolicy.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Policy_Text", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(952, 529)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'PolicyDate
        '
        Me.PolicyDate.AutoSize = True
        Me.PolicyDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Policy_Date_Stamp", True))
        Me.PolicyDate.Location = New System.Drawing.Point(395, 569)
        Me.PolicyDate.Name = "PolicyDate"
        Me.PolicyDate.Size = New System.Drawing.Size(30, 13)
        Me.PolicyDate.TabIndex = 5
        Me.PolicyDate.Text = "Date"
        '
        'PolicySubmitterLable
        '
        Me.PolicySubmitterLable.AutoSize = True
        Me.PolicySubmitterLable.Location = New System.Drawing.Point(499, 569)
        Me.PolicySubmitterLable.Name = "PolicySubmitterLable"
        Me.PolicySubmitterLable.Size = New System.Drawing.Size(88, 13)
        Me.PolicySubmitterLable.TabIndex = 6
        Me.PolicySubmitterLable.Text = "Policy Submitter: "
        '
        'PolicySubmitter
        '
        Me.PolicySubmitter.AutoSize = True
        Me.PolicySubmitter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Policy_Editor", True))
        Me.PolicySubmitter.Location = New System.Drawing.Point(593, 569)
        Me.PolicySubmitter.Name = "PolicySubmitter"
        Me.PolicySubmitter.Size = New System.Drawing.Size(35, 13)
        Me.PolicySubmitter.TabIndex = 7
        Me.PolicySubmitter.Text = "Name"
        '
        'BindingSource1
        '
        Me.BindingSource1.AllowNew = False
        Me.BindingSource1.DataMember = "Energy_Policy"
        Me.BindingSource1.DataSource = Me.EnMS_DatabaseDataSet
        '
        'EnMS_DatabaseDataSet
        '
        Me.EnMS_DatabaseDataSet.DataSetName = "EnMS_DatabaseDataSet"
        Me.EnMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Energy_PolicyTableAdapter
        '
        Me.Energy_PolicyTableAdapter.ClearBeforeFill = True
        '
        'View_Energy_Policies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 623)
        Me.Controls.Add(Me.PolicySubmitter)
        Me.Controls.Add(Me.PolicySubmitterLable)
        Me.Controls.Add(Me.PolicyDate)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.NextPolicy)
        Me.Controls.Add(Me.DateLable)
        Me.Controls.Add(Me.PrevPolicy)
        Me.Name = "View_Energy_Policies"
        Me.Text = "View Energy Policies"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnMS_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrevPolicy As System.Windows.Forms.Button
    Friend WithEvents DateLable As System.Windows.Forms.Label
    Friend WithEvents NextPolicy As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PolicyDate As System.Windows.Forms.Label
    Friend WithEvents PolicySubmitterLable As System.Windows.Forms.Label
    Friend WithEvents PolicySubmitter As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EnMS_DatabaseDataSet As EnMS_Express.EnMS_DatabaseDataSet
    Friend WithEvents Energy_PolicyTableAdapter As EnMS_Express.EnMS_DatabaseDataSetTableAdapters.Energy_PolicyTableAdapter
End Class
