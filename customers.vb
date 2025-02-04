Imports System.Data.OleDb
Public Class customers

    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ddbb\Users.accdb;"
    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDataSet2.TBLcustomer' table. You can move, or remove it, as needed.
        Me.TBLcustomerTableAdapter1.Fill(Me.UsersDataSet2.TBLcustomer)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingSource2.AddNew()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo SaveError

        BindingSource2.EndEdit()
        ' TBLcusterTableAdapter1.Update(UsersDataSet2.TBLcustomer)
        MessageBox.Show("Data has been saved ")

SaveError:
        Exit Sub
    End Sub

    Private Sub notFound()

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If BindingSource2.Current Is Nothing Then
            MessageBox.Show("No record selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                BindingSource2.RemoveCurrent() ' Remove the current row
                Me.Validate()
                Me.BindingSource2.EndEdit()
                'Me.TBLcustomerTableAdapter.Update(Me.UsersDataSet8.TBLcustomer) ' Perform the database update
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error while deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If BindingSource2.Position > 0 Then
            BindingSource2.MovePrevious()
        Else
            MessageBox.Show("No previous customer.")
        End If
    End Sub

    ' Navigate to next customer
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If BindingSource2.Position < BindingSource2.Count - 1 Then
            BindingSource2.MoveNext()
        Else
            MessageBox.Show("No next customer.")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
       
    End Sub
 

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
    'Try
    'Me.TBLcustomerTableAdapter.search(Me.UsersDataSet1.TBLcustomer, ToolStripTextBox.Text)
    'Catch ex As System.Exception
    'System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    'End Sub

    Private Sub Buttn1_Click(sender As Object, e As EventArgs) Handles Buttn1.Click
        Me.Hide()
        User.Show()
    End Sub
End Class