Imports System.Data.OleDb

Public Class Dashboard
    Private ReadOnly conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ddbb\Users.accdb"

    ' Load Event
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCounts()
        Timer1.Interval = 5000 ' Refresh every 5 seconds
        Timer1.Start()
    End Sub

    ' Method to Fetch and Display Counts
    Private Sub DisplayCounts()
        Try
            Using con As New OleDbConnection(conString)
                con.Open()

                ' Fetch Total Users
                lblTotalUsers.Text = "Total Users: " & GetRecordCount(con, "TBLusers").ToString()

                ' Fetch Total Customers
                lblTotalCustomers.Text = "Total Customers: " & GetRecordCount(con, "TBLcustomer").ToString()

                ' Fetch Total Products
                lblTotalProducts.Text = "Total Products: " & GetRecordCount(con, "TBLproduct").ToString()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to Get Record Count from Any Table
    Private Function GetRecordCount(con As OleDbConnection, tableName As String) As Integer
        Dim count As Integer = 0
        Try
            Dim query As String = "SELECT COUNT(*) FROM " & tableName
            Using cmd As New OleDbCommand(query, con)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching count for " & tableName & ": " & ex.Message)
        End Try
        Return count
    End Function

    ' Auto-refresh counts every 5 seconds
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DisplayCounts()
    End Sub
End Class
