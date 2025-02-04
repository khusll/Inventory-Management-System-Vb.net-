<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillingForm))
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblcate = New System.Windows.Forms.Label()
        Me.amt = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.gst = New System.Windows.Forms.Label()
        Me.lbldisc = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.proname = New System.Windows.Forms.Label()
        Me.proid = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.printt = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(176, 229)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(170, 26)
        Me.txtname.TabIndex = 47
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(176, 361)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(170, 26)
        Me.txtAddress.TabIndex = 45
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(176, 293)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(170, 26)
        Me.txtContact.TabIndex = 43
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(176, 175)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(170, 26)
        Me.txtCustomerID.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(18, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(18, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 26)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Contact"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(18, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Name"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lbl2.Location = New System.Drawing.Point(18, 174)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(138, 26)
        Me.lbl2.TabIndex = 36
        Me.lbl2.Text = "Customer ID"
        '
        'txtCategory
        '
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(944, 127)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(170, 28)
        Me.txtCategory.TabIndex = 65
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(944, 292)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(170, 26)
        Me.txtTotalAmount.TabIndex = 64
        '
        'lblcate
        '
        Me.lblcate.AutoSize = True
        Me.lblcate.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcate.Location = New System.Drawing.Point(795, 126)
        Me.lblcate.Name = "lblcate"
        Me.lblcate.Size = New System.Drawing.Size(101, 26)
        Me.lblcate.TabIndex = 63
        Me.lblcate.Text = "Category"
        '
        'amt
        '
        Me.amt.AutoSize = True
        Me.amt.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(788, 292)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(150, 26)
        Me.amt.TabIndex = 62
        Me.amt.Text = "Total Amount"
        '
        'txtGST
        '
        Me.txtGST.Location = New System.Drawing.Point(944, 228)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(170, 26)
        Me.txtGST.TabIndex = 61
        '
        'gst
        '
        Me.gst.AutoSize = True
        Me.gst.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gst.Location = New System.Drawing.Point(797, 229)
        Me.gst.Name = "gst"
        Me.gst.Size = New System.Drawing.Size(65, 26)
        Me.gst.TabIndex = 60
        Me.gst.Text = "GST "
        '
        'lbldisc
        '
        Me.lbldisc.AutoSize = True
        Me.lbldisc.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisc.Location = New System.Drawing.Point(797, 173)
        Me.lbldisc.Name = "lbldisc"
        Me.lbldisc.Size = New System.Drawing.Size(99, 26)
        Me.lbldisc.TabIndex = 59
        Me.lbldisc.Text = "Discount"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(577, 228)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(170, 26)
        Me.txtProductName.TabIndex = 58
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(944, 174)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(170, 26)
        Me.txtDiscount.TabIndex = 57
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(577, 353)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(170, 26)
        Me.txtQuantity.TabIndex = 56
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(578, 292)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(169, 26)
        Me.txtPrice.TabIndex = 55
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(578, 174)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(169, 26)
        Me.txtProductID.TabIndex = 54
        '
        'qty
        '
        Me.qty.AutoSize = True
        Me.qty.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.Location = New System.Drawing.Point(409, 350)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(98, 26)
        Me.qty.TabIndex = 53
        Me.qty.Text = "Quantity"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(409, 292)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(63, 26)
        Me.price.TabIndex = 52
        Me.price.Text = "Price"
        '
        'proname
        '
        Me.proname.AutoSize = True
        Me.proname.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proname.Location = New System.Drawing.Point(409, 228)
        Me.proname.Name = "proname"
        Me.proname.Size = New System.Drawing.Size(152, 26)
        Me.proname.TabIndex = 51
        Me.proname.Text = "Product Name"
        '
        'proid
        '
        Me.proid.AutoSize = True
        Me.proid.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proid.Location = New System.Drawing.Point(409, 175)
        Me.proid.Name = "proid"
        Me.proid.Size = New System.Drawing.Size(121, 26)
        Me.proid.TabIndex = 50
        Me.proid.Text = "Product ID"
        '
        'txtInvoiceNumber
        '
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(176, 127)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(169, 26)
        Me.txtInvoiceNumber.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 26)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Invoice Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 26)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Invoice No"
        '
        'btnPrint
        '
        Me.btnPrint.AutoEllipsis = True
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Sitka Display Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnPrint.Location = New System.Drawing.Point(1020, 338)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 47)
        Me.btnPrint.TabIndex = 72
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoEllipsis = True
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Sitka Display Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.Location = New System.Drawing.Point(793, 340)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 47)
        Me.btnSave.TabIndex = 71
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(577, 126)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(170, 26)
        Me.DateTimePicker1.TabIndex = 73
        '
        'printt
        '
        Me.printt.AutoEllipsis = True
        Me.printt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.printt.Font = New System.Drawing.Font("Sitka Display Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printt.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.printt.Location = New System.Drawing.Point(908, 340)
        Me.printt.Name = "printt"
        Me.printt.Size = New System.Drawing.Size(94, 47)
        Me.printt.TabIndex = 74
        Me.printt.Text = "Exit"
        Me.printt.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lbl1.Font = New System.Drawing.Font("Constantia", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Lbl1.Location = New System.Drawing.Point(559, 20)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(319, 54)
        Me.Lbl1.TabIndex = 75
        Me.Lbl1.Text = "Billing System"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 481)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1491, 512)
        Me.DataGridView1.TabIndex = 76
        '
        'BillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 866)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.printt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.lblcate)
        Me.Controls.Add(Me.amt)
        Me.Controls.Add(Me.txtGST)
        Me.Controls.Add(Me.gst)
        Me.Controls.Add(Me.lbldisc)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.proname)
        Me.Controls.Add(Me.proid)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl2)
        Me.MinimizeBox = False
        Me.Name = "BillingForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblcate As System.Windows.Forms.Label
    Friend WithEvents amt As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents gst As System.Windows.Forms.Label
    Friend WithEvents lbldisc As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents qty As System.Windows.Forms.Label
    Friend WithEvents price As System.Windows.Forms.Label
    Friend WithEvents proname As System.Windows.Forms.Label
    Friend WithEvents proid As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents printt As System.Windows.Forms.Button
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
