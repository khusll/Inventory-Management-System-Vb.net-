Imports System.Data.OleDb
Imports System.IO
Imports System.Data.OleDb.OleDbException
Imports Shop.productdetail
Imports MessagingToolkit.QRCode.Codec
Imports System.Drawing

Public Class Product

    Private conn As OleDbConnection
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ddbb\Users.accdb"
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'UsersDataSet4.TBLproduct' table. You can move, or remove it, as needed.

        Try
            ' Initialize and open the connection
            conn = New OleDbConnection(connString)
            conn.Open()

            ' Initialize DataGridView
            dgvProducts.Columns.Add("ProductID", "Product ID")
            dgvProducts.Columns.Add("ProductName", "Product Name")
            dgvProducts.Columns.Add("Category", "Category")
            dgvProducts.Columns.Add("Price", "Price")
            dgvProducts.Columns.Add("Quantity", "Quantity")
            dgvProducts.Columns.Add("Discount", "Discount (%)")
            dgvProducts.Columns.Add("GST", "GST (%)")
            dgvProducts.Columns.Add("TotalAmount", "Total Amount")

            ' Populate ComboBox with predefined categories
            cmbCategory.Items.AddRange(New String() {"Kurti", "Jeans", "Tops&Tunics", "Shorts", "Pants", "Shrugs", "partywear Gowns"})
            cmbCategory.SelectedIndex = 0 ' Set default selected category

            txtTotalAmount.ReadOnly = True

            ' Load data from the database
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error initializing database connection: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadData()
        Try
            Dim query As String = "SELECT * FROM TBLproduct order by ProductID"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            dgvProducts.Rows.Clear()
            While reader.Read()
                dgvProducts.Rows.Add(reader("ProductID"), reader("ProductName"), reader("Category"),
                                     reader("Price"), reader("Quantity"), reader("Discount"),
                                     reader("GST"), reader("TotalAmount"))
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Disable manual entry for Product ID
            txtProductID.Enabled = False

            ' Generate a unique Product ID
            Dim newProductID As Integer = 1001 ' Default starting ID

            ' Get the list of existing IDs and sort them
            Dim queryID As String = "SELECT ProductID FROM TBLproduct ORDER BY ProductID"
            Using cmdID As New OleDbCommand(queryID, conn)
                Dim reader As OleDbDataReader = cmdID.ExecuteReader()
                Dim productIDs As New List(Of Integer)

                ' Collect all existing IDs
                While reader.Read()
                    productIDs.Add(CInt(reader("ProductID")))
                End While
                reader.Close()

                ' Find the next available ID (sequential)
                newProductID = If(productIDs.Count = 0, 1001, productIDs.Max() + 1)
            End Using
            txtProductID.Text = newProductID.ToString()

            ' Calculate total amount
            Dim price As Decimal = Decimal.Parse(txtPrice.Text)
            Dim quantity As Integer = Integer.Parse(txtqty.Text)
            Dim discount As Decimal = Decimal.Parse(txtDiscount.Text)
            Dim gst As Decimal = Decimal.Parse(txtGST.Text)
            Dim subtotal As Decimal = price * quantity
            Dim discountAmount As Decimal = subtotal * (discount / 100)
            Dim gstAmount As Decimal = (subtotal - discountAmount) * (gst / 100)
            Dim totalAmount As Decimal = (subtotal - discountAmount) + gstAmount

            ' Add to database
            Dim query As String = "INSERT INTO TBLproduct (ProductID, ProductName, Category, Price, Quantity, Discount, GST, TotalAmount) " &
                      "VALUES (@ProductID, @ProductName, @Category, @Price, @Quantity, @Discount, @GST, @TotalAmount)"

            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text)
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Price", price)
                cmd.Parameters.AddWithValue("@Quantity", quantity)
                cmd.Parameters.AddWithValue("@Discount", discount)
                cmd.Parameters.AddWithValue("@GST", gst)
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                cmd.ExecuteNonQuery()
            End Using

            ' Refresh data
            LoadData()
            ' Clear input fields
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Try
                Dim productID As String = dgvProducts.SelectedRows(0).Cells("ProductID").Value.ToString()

                Dim query As String = "DELETE FROM TBLproduct WHERE ProductID = @ProductID"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductID", productID)
                cmd.ExecuteNonQuery()

                ' Refresh data
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error deleting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Product_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the connection when the form closes
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub ClearFields()
        ' Clear all input fields
        txtProductID.Clear()
        txtProductName.Clear()
        cmbCategory.SelectedIndex = 0
        txtPrice.Clear()
        txtqty.Clear()
        txtDiscount.Clear()
        txtGST.Clear()
        txtTotalAmount.Clear()
    End Sub

    Private Sub Buttn1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Generate.Click
        Try
            Dim qrCode As New QRCodeEncoder()
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            pic_QRcode.Image = qrCode.Encode(txt_QRcode.Text, System.Text.Encoding.UTF8)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub buynow_Click(sender As Object, e As EventArgs)
        product_id = txtProductID.Text
        product_name = txtProductName.Text
        product_price = txtPrice.Text
        product_qty = txtqty.Text
        product_cat = cmbCategory.Text
        product_dis = txtDiscount.Text
        product_gst = txtGST.Text
        product_total = txtTotalAmount.Text
        Me.Hide()
        BillingForm.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String = "INSERT INTO TBLproduct (ProductName, Category, Price, Quantity, Discount, GST, TotalAmount) " &
                            "VALUES (@ProductName, @Category, @Price, @Quantity, @Discount, @GST, @TotalAmount)"
        Try
            Using cmd As New OleDbCommand(query, conn)
                ' Add parameters
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Price", txtPrice)
                cmd.Parameters.AddWithValue("@Quantity", txtqty)
                cmd.Parameters.AddWithValue("@Discount", txtDiscount)
                cmd.Parameters.AddWithValue("@GST", txtGST)
                cmd.Parameters.AddWithValue("@TotalAmount", txtTotalAmount)

                ' Execute the query
                cmd.ExecuteNonQuery()
            End Using

            ' Refresh data and clear input fields
            LoadData()
            ClearFields()

            MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txt_QRcode.Clear()
        pic_QRcode.Image = Nothing
        txt_QRcode.Focus()
    End Sub
End Class