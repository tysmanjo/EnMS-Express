Public Class Design_Analysis

    Private Sub DesignBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles DesignBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DesignBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)

    End Sub

    Private Sub Design_Analysis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Design' table. You can move, or remove it, as needed.
        Me.DesignTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Design)

        If DesignBindingSource.Count = 0 Then
            Me.DesignBindingSource.AddNew()
        End If



    End Sub
End Class