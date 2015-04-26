Public Class Baseline_Form

    Private Sub EnPI_BaselineBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EnPI_BaselineBindingNavigatorSaveItem.Click
        If EnPI_SEUCheckBox.Checked = False Then

            MsgBox("Non-SEU's should not be used in EnPI tracking")

        Else
            Me.Validate()
            Me.EnPI_BaselineBindingSource.EndEdit()
            Me.EnPI_Baseline_DataBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)

            'Dim baselineCount As Integer
            'baselineCount = Me.EnPI_BaselineBindingSource.Count
            'MessageBox.Show(baselineCount)
            'If baselineCount > 0 Then 'Don't attempt to display a chart if there is no baseline data
            'Dim baselineName As String
            ' For i As Integer = 1 To baselineCount
            '      baselineName = Me.EnMS_DatabaseDataSet.EnPI_Baseline.Rows(0).Item("EnPI_Name")
            '       EnMS_Main.EnPI_Chart.Series.Add(baselineName)
            '    Next
            'End If

            EnMS_Main.updateChartEnPI()
        End If
    End Sub

    Private Sub Baseline_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.EnPI_Baseline_Data' table. You can move, or remove it, as needed.
        Me.EnPI_BaselineTableAdapter.Fill(Me.EnMS_DatabaseDataSet.EnPI_Baseline)
        Me.EnPI_Baseline_DataTableAdapter.Fill(Me.EnMS_DatabaseDataSet.EnPI_Baseline_Data)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.EnPI_Baseline' table. You can move, or remove it, as needed.
        If Me.EnPI_BaselineBindingSource.Count = 0 Then
            Me.EnPI_BaselineBindingSource.AddNew()
        End If
    End Sub

    Private Sub EnPI_BaselineDataBindingSource_AddingNew(sender As System.Object, e As System.ComponentModel.AddingNewEventArgs) Handles EnPI_Baseline_DataBindingSource.AddingNew
        Me.EnPI_BaselineBindingSource.EndEdit()
    End Sub

End Class