Public Class Change_Log

    Private Sub ChangeLogBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ChangeLogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)

    End Sub

    Private Sub Change_Log_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.ChangeLog' table. You can move, or remove it, as needed.
        Me.ChangeLogTableAdapter.Fill(Me.EnMS_DatabaseDataSet.ChangeLog)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub
End Class