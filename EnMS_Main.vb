Public Class EnMS_Main

    Private Sub EmployeesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeesToolStripMenuItem.Click
        Employees.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecordsToolStripMenuItem.Click
        Records.Show()
    End Sub

    Private Sub EnergyPolicyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnergyPolicyToolStripMenuItem.Click
        EnergyPolicy.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About_EnMS_Express.Show()
    End Sub

    Private Sub ChangeLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeLogToolStripMenuItem.Click
        Change_Log.Show()
    End Sub

    Private Sub EnMS_Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Record' table. You can move, or remove it, as needed.
        Me.RecordTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Record)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.EnPI_Baseline_Data' table. You can move, or remove it, as needed.
        Me.EnPI_BaselineTableAdapter.Fill(Me.EnMS_DatabaseDataSet.EnPI_Baseline)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.EnPI_Baseline_Data' table. You can move, or remove it, as needed.

        Dim baselineCount As Integer
        Dim chartPosition As Integer
        chartPosition = 0
        baselineCount = Me.EnPI_BaselineBindingSource.Count
        'MessageBox.Show(baselineCount)
        Me.EnPI_Chart.Series.Add("Baseline")
        If baselineCount > 0 Then 'Don't attempt to display a chart if there is no baseline data
            chartPosition = 1
            Dim baselineName As String
            baselineName = Me.EnMS_DatabaseDataSet.EnPI_Baseline.Rows(0).Item("EnPI_Name")
            Me.EnPI_Chart.Titles.Add(baselineName)
        End If
        updateChartEnPI()
        'Me.EventsListBox.DataSource = EnMS_DatabaseDataSet.Tables("Record")
        'Me.EventsListBox.DisplayMember = "Title"
        Dim EventIndex = EventsListBox.SelectedIndex
        If EventIndex > 0 Then
            Me.ReviewDateText.Text = Me.EnMS_DatabaseDataSet.Record.Rows(EventIndex).Item("ReviewDate")
        End If

    End Sub

    Public Sub updateChartEnPI()

        Dim EnPI_Selection As Integer
        'Dim EnPI_BaselineValueX As EnMS_DatabaseDataSet.EnPI_Baseline_DataDataTable
        'EnPI_BaselineValueX = EnPI_Baseline_DataTableAdapter.GetEnPIBaselineValueX()
        'Dim EnPI_BaselineValueY As EnMS_DatabaseDataSet.EnPI_Baseline_DataDataTable
        'EnPI_BaselineValueY = EnPI_Baseline_DataTableAdapter.GetEnPIBaselineValueY()
        'Dim EnPI_BaselineValueX = EnPI_Baseline_DataTableAdapter.GetEnPIBaselineValueX()
        'Dim EnPI_BaselineValueY = EnPI_Baseline_DataTableAdapter.GetEnPIBaselineValueY()
        'Dim EnPI_BaselineValueX = 

        EnPI_ComboBox.DisplayMember = "EnPI_Name"
        EnPI_ComboBox.ValueMember = "EnPI_Name"
        EnPI_ComboBox.DataSource = Me.EnPI_BaselineTableAdapter.getEnPInames()
        EnPI_Selection = EnPI_ComboBox.SelectedIndex
        'If Me.EnPI_BaselineBindingSource.Count > 0 Then
        'EnPI_Chart.Series("Baseline").Points.DataBindXY(EnPI_BaselineValueX, EnPI_BaselineValueY)
        'End If

    End Sub


    Private Sub EnPI_Chart_Click(sender As System.Object, e As System.EventArgs) Handles EnPI_Chart.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub EventsListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EventsListBox.SelectedIndexChanged
        Dim EventIndex = EventsListBox.SelectedIndex
        Me.ReviewDateText.Text = Me.EnMS_DatabaseDataSet.Record.Rows(EventIndex).Item("ReviewDate")
    End Sub

    Private Sub openEventButton_Click(sender As System.Object, e As System.EventArgs) Handles openEventButton.Click
        Dim EventIndex = EventsListBox.SelectedIndex
        RecordBindingSource.Position = EventIndex
        Records.Show()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub

    Private Sub EnPIsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnPIsToolStripMenuItem.Click
        Baseline_Form.Show()
    End Sub

    Private Sub ProcurementAnalysisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcurementAnalysisToolStripMenuItem.Click
        Procurement.Show()
    End Sub
End Class