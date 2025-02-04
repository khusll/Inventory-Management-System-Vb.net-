Imports System.Data.OleDb

Public Class User

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDataSet1.TBLusers' table. You can move, or remove it, as needed.
        Me.TBLusersTableAdapter.Fill(Me.UsersDataSet1.TBLusers)
    End Sub


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If TBLusersBindingSource.Position > 0 Then
            TBLusersBindingSource.MovePrevious()
        Else
            MessageBox.Show("No previous customer.")
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If TBLusersBindingSource.Position < TBLusersBindingSource.Count - 1 Then
            TBLusersBindingSource.MoveNext()
        Else
            MessageBox.Show("No next customer.")
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo SaveError

        TBLusersBindingSource.EndEdit()
        'TBLcustomerTableAdapter.Update(UsersDataSet8.TBLcustomer)
        MessageBox.Show("Data has been saved ")

SaveError:
        Exit Sub
    End Sub
    Private Sub notFound()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        TBLusersBindingSource.AddNew()
        clr()

    End Sub
    Sub clr()
        txtID.Focus()
        txtUsername.Clear()
        txtName.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        cboRole.SelectedIndex = 0
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If TBLusersBindingSource.Current Is Nothing Then
            MessageBox.Show("No record selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                TBLusersBindingSource.RemoveCurrent() ' Remove the current row
                Me.Validate()
                Me.TBLusersBindingSource.EndEdit()
                'Me.TBLcustomerTableAdapter.Update(Me.UsersDataSet8.TBLcustomer) ' Perform the database update
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error while deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

    End Sub
End Class