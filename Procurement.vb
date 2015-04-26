Public Class Procurement

    Private Sub ProcurementBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcurementBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProcurementBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)

    End Sub

    Private Sub Procurement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Procurement' table. You can move, or remove it, as needed.
        Me.ProcurementTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Procurement)

        If ProcurementBindingSource.Count = 0 Then
            Me.ProcurementBindingSource.AddNew()
        End If

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class