Public Class View_Energy_Policies

    Private Sub View_Energy_Policies_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Energy_Policy' table. You can move, or remove it, as needed.
        Me.Energy_PolicyTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Energy_Policy)

    End Sub

    Private Sub NextPolicy_Click(sender As System.Object, e As System.EventArgs) Handles NextPolicy.Click
        If BindingSource1.Position + 1 < BindingSource1.Count Then
            BindingSource1.MoveNext()
        End If

        ' Force the form to repaint.
        Me.Invalidate()

    End Sub

    Private Sub PrevPolicy_Click(sender As System.Object, e As System.EventArgs) Handles PrevPolicy.Click

        If BindingSource1.Position - 1 < BindingSource1.Count Then
            BindingSource1.MovePrevious()
        End If

        ' Force the form to repaint.
        Me.Invalidate()

    End Sub
End Class