Public Class Employees

    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.EmployeesTableAdapter.Update(Me.EnMS_DatabaseDataSet.Employees)
        'Try this for heirarchical update'
        Me.QualificationsBindingSource.EndEdit()
        Me.QualificationsTableAdapter.Update(Me.EnMS_DatabaseDataSet.Qualifications)
        'Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)

    End Sub

    Private Sub Employees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.ChangeLog' table. You can move, or remove it, as needed.
        Me.ChangeLogTableAdapter.Fill(Me.EnMS_DatabaseDataSet.ChangeLog)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Qualifications' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Employees)
        Me.QualificationsTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Qualifications)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Employees' table. You can move, or remove it, as needed.

        If EmployeesBindingSource.Count = 0 Then
            Me.EmployeesBindingSource.AddNew()
        End If
    End Sub

    Private Sub QualificationsBindingSource_AddingNew(sender As System.Object, e As System.ComponentModel.AddingNewEventArgs) Handles QualificationsBindingSource.AddingNew
        Me.EmployeesBindingSource.EndEdit()
    End Sub

    Private Sub PrintLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        PrintForm1.Print()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class