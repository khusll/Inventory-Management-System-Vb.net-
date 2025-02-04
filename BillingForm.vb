Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports System.Data.OleDb.OleDbException
Imports Shop.productdetail
Imports MessagingToolkit.QRCode.Codec

Public Class BillingForm
    Private connection As OleDbConnection
    Private command As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dataSet As DataSet

    ' Form Load: Initialize connection and load data into DataGridView
    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ddbb\Users.accdb")
        txtInvoiceNumber.Text = GenerateInvoiceNumber() ' Assign to a TextBox

    End Sub

    ' Save Button event: Insert data into TBLBilling and update DataGridView
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'RANDOM INVOICE NUMBER 
        Try
            ' Your saving logic here (saving invoice details to database)

            MessageBox.Show("Invoice Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Generate a new Invoice Number after saving
            txtInvoiceNumber.Text = GenerateInvoiceNumber()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Print Button: Print the current DataGridView content
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim printDialog As New PrintDialog()
            Dim printDocument As New PrintDocument()

            AddHandler printDocument.PrintPage, AddressOf Me.PrintDocument_PrintPage

            If printDialog.ShowDialog() = DialogResult.OK Then
                printDocument.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing: " & ex.Message)
        End Try
    End Sub

    ' Print document handler
    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 10)
        Dim lineHeight As Single = printFont.GetHeight(e.Graphics) + 2
        Dim yPos As Single = 10

        ' Print the header
        e.Graphics.DrawString("Invoice Details", printFont, Brushes.Black, 10, yPos)
        yPos += lineHeight

        ' Print the DataGridView content
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim rowData As String = String.Join(" | ", row.Cells.Cast(Of DataGridViewCell)().Select(Function(cell) cell.Value.ToString()))
                e.Graphics.DrawString(rowData, printFont, Brushes.Black, 10, yPos)
                yPos += lineHeight
            End If
        Next
    End Sub

    Public Function GenerateInvoiceNumber() As String
        Dim rand As New Random()
        Dim randomNum As Integer = rand.Next(1000, 9999) ' Generate a 4-digit random number
        Dim invoiceNumber As String = "INV" & DateTime.Now.ToString("yyyyMMddHHmmss") & randomNum
        Return invoiceNumber
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub txtProductID_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged
        Dim query As String = "SELECT * FROM TBLproduct where ProductID = " & txtProductID.Text & ""
        Dim cmd As New OleDbCommand(query, connection)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()

        End While
    End Sub

    Private Sub printt_Click(sender As Object, e As EventArgs) Handles printt.Click

    End Sub
End Class
