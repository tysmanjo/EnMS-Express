Public Class Records

    Private Sub RecordBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)

    End Sub


    Private Sub RecordBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles RecordBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)
        EnMS_Main.EventsListBox.Refresh()
        RecordBindingSource.Current("Submitter") = SubmitterComboBox.SelectedValue 'Stamp the submitter
        RecordBindingSource.Current("RecordType") = RecordTypeComboBox.SelectedValue
    End Sub

    Private Sub Records_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Record' table. You can move, or remove it, as needed.
        Me.RecordTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Record)

        If RecordBindingSource.Count = 0 Then
            Me.RecordBindingSource.AddNew()
        End If

        SubmitterComboBox.DisplayMember = "Last_Name"
        SubmitterComboBox.ValueMember = "Last_Name"
        SubmitterComboBox.DataSource = Me.EmployeesTableAdapter.GetDataBy()
        If RecordBindingSource.Count <> 0 Then
            RecordTypeComboBox.DisplayMember = "RecordType"
            RecordTypeComboBox.ValueMember = "RecordType"
            RecordTypeComboBox.DataSource = Me.RecordTableAdapter.GetRecordTypeDataBy()
        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub
End Class