Public Class EnergyPolicy

    Private Sub Energy_Policy_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.ChangeLog' table. You can move, or remove it, as needed.
        Me.ChangeLogTableAdapter.Fill(Me.EnMS_DatabaseDataSet.ChangeLog)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Qualifications' table. You can move, or remove it, as needed.
        Me.QualificationsTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Qualifications)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Employees)
        'TODO: This line of code loads data into the 'EnMS_DatabaseDataSet.Energy_Policy' table. You can move, or remove it, as needed.
        Me.Energy_PolicyTableAdapter.Fill(Me.EnMS_DatabaseDataSet.Energy_Policy)
        'Populates the combobox with currently available names
        SubmitterCombo.DisplayMember = "Last_Name"
        SubmitterCombo.ValueMember = "Last_Name"
        SubmitterCombo.DataSource = Me.EmployeesTableAdapter.GetDataBy()

        If Energy_PolicyBindingSource.Count = 0 Then
            Me.Energy_PolicyBindingSource.AddNew()
        End If


    End Sub

    Private Sub Energy_PolicyBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Energy_PolicyBindingNavigatorSaveItem.Click

        If CheckBoxA.Checked = False Or CheckBoxB.Checked = False Or CheckBox1C.Checked = False Or CheckBoxD.Checked = False Or CheckBoxE.Checked = False Or CheckBoxF.Checked = False Or CheckBoxG.Checked = False Or CheckBoxH.Checked = False Then
            MsgBox("Policy Requirements Not Met")
        Else

            Energy_PolicyBindingSource.Current("Policy_Editor") = SubmitterCombo.SelectedValue 'Stamp the submitter
            Energy_PolicyBindingSource.Current("Policy_Date_Stamp") = DateTime.Now 'Stamp the time

            ChangeLogBindingSource.AddNew()
            ChangeLogBindingSource.Current("ChangeDate") = DateTime.Now 'Stamp the time to the change log
            ChangeLogBindingSource.Current("ChangeType") = "New Energy Policy Created" 'Declair a new energy policy was created in the change log
            ChangeLogBindingSource.Current("ChangeName") = SubmitterCombo.SelectedValue 'Stamp the submitter to the change log
            Me.ChangeLogBindingSource.EndEdit()
            Me.ChangeLogTableAdapter.Update(Me.EnMS_DatabaseDataSet.ChangeLog)

            Me.Validate()
            Me.Energy_PolicyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EnMS_DatabaseDataSet)
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        View_Energy_Policies.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub
End Class