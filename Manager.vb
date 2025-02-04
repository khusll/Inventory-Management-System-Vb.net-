Imports System.Data.OleDb

Public Class Manager
    Public Sub LoadDataFromProductForm(productDGV As DataGridView)
        ' Clear DataGridView3 before adding new data
        DataGridView3.Rows.Clear()

        ' Loop through dgvProducts (from Product form) and add data to DataGridView3
        For Each row As DataGridViewRow In productDGV.Rows
            If Not row.IsNewRow Then
                DataGridView3.Rows.Add(row.Cells("ProductID").Value, row.Cells("ProductName").Value, row.Cells("Category").Value,
                                       row.Cells("Price").Value, row.Cells("Quantity").Value, row.Cells("Discount").Value,
                                       row.Cells("GST").Value, row.Cells("TotalAmount").Value)
            End If
        Next
    End Sub
    Private conn As OleDbConnection
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ddbb\Users.accdb"

    ' Form Load Event to Initialize DataGridViews and Load Data
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click

        Login.Show()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
