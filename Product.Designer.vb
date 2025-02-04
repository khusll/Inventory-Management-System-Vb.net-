<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.proname = New System.Windows.Forms.Label()
        Me.proid = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lbldisc = New System.Windows.Forms.Label()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.gst = New System.Windows.Forms.Label()
        Me.amt = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblcate = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Btn_Generate = New System.Windows.Forms.Button()
        Me.pic_QRcode = New System.Windows.Forms.PictureBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt_QRcode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_QRcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderSize = 10
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Sitka Heading Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(159, 186)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(132, 40)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderSize = 10
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Sitka Heading Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(297, 232)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSave.Size = New System.Drawing.Size(132, 41)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn3.FlatAppearance.BorderSize = 10
        Me.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn3.Font = New System.Drawing.Font("Sitka Heading Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(159, 232)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(132, 41)
        Me.btn3.TabIndex = 34
        Me.btn3.Text = "Next"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatAppearance.BorderSize = 10
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Sitka Heading Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(21, 186)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 41)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn1.FlatAppearance.BorderSize = 10
        Me.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn1.Font = New System.Drawing.Font("Sitka Heading Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(21, 232)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(132, 40)
        Me.btn1.TabIndex = 32
        Me.btn1.Text = "Previous"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(794, 139)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(123, 26)
        Me.txtDiscount.TabIndex = 30
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(505, 139)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(121, 26)
        Me.txtqty.TabIndex = 29
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(362, 140)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(111, 26)
        Me.txtPrice.TabIndex = 28
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(21, 140)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(116, 26)
        Me.txtProductID.TabIndex = 26
        '
        'qty
        '
        Me.qty.AutoSize = True
        Me.qty.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.Location = New System.Drawing.Point(500, 111)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(98, 26)
        Me.qty.TabIndex = 24
        Me.qty.Text = "Quantity"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(357, 111)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(63, 26)
        Me.price.TabIndex = 23
        Me.price.Text = "Price"
        '
        'proname
        '
        Me.proname.AutoSize = True
        Me.proname.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proname.Location = New System.Drawing.Point(160, 111)
        Me.proname.Name = "proname"
        Me.proname.Size = New System.Drawing.Size(152, 26)
        Me.proname.TabIndex = 22
        Me.proname.Text = "Product Name"
        '
        'proid
        '
        Me.proid.AutoSize = True
        Me.proid.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proid.Location = New System.Drawing.Point(16, 111)
        Me.proid.Name = "proid"
        Me.proid.Size = New System.Drawing.Size(121, 26)
        Me.proid.TabIndex = 20
        Me.proid.Text = "Product ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(526, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 49)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Product Management"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(165, 140)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(170, 26)
        Me.txtProductName.TabIndex = 39
        '
        'lbldisc
        '
        Me.lbldisc.AutoSize = True
        Me.lbldisc.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisc.Location = New System.Drawing.Point(790, 111)
        Me.lbldisc.Name = "lbldisc"
        Me.lbldisc.Size = New System.Drawing.Size(99, 26)
        Me.lbldisc.TabIndex = 40
        Me.lbldisc.Text = "Discount"
        '
        'txtGST
        '
        Me.txtGST.Location = New System.Drawing.Point(932, 139)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(116, 26)
        Me.txtGST.TabIndex = 43
        '
        'gst
        '
        Me.gst.AutoSize = True
        Me.gst.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gst.Location = New System.Drawing.Point(927, 111)
        Me.gst.Name = "gst"
        Me.gst.Size = New System.Drawing.Size(65, 26)
        Me.gst.TabIndex = 42
        Me.gst.Text = "GST "
        '
        'amt
        '
        Me.amt.AutoSize = True
        Me.amt.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt.Location = New System.Drawing.Point(1072, 111)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(150, 26)
        Me.amt.TabIndex = 44
        Me.amt.Text = "Total Amount"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(1077, 139)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(145, 26)
        Me.txtTotalAmount.TabIndex = 48
        '
        'lblcate
        '
        Me.lblcate.AutoSize = True
        Me.lblcate.Font = New System.Drawing.Font("Bell MT", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcate.Location = New System.Drawing.Point(649, 109)
        Me.lblcate.Name = "lblcate"
        Me.lblcate.Size = New System.Drawing.Size(101, 26)
        Me.lblcate.TabIndex = 47
        Me.lblcate.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(654, 137)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 28)
        Me.cmbCategory.TabIndex = 49
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnedit.FlatAppearance.BorderSize = 10
        Me.btnedit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnedit.Font = New System.Drawing.Font("Sitka Heading Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(297, 186)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(132, 41)
        Me.btnedit.TabIndex = 51
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'dgvProducts
        '
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(21, 298)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowTemplate.Height = 28
        Me.dgvProducts.Size = New System.Drawing.Size(1424, 633)
        Me.dgvProducts.TabIndex = 52
        '
        'Btn_Generate
        '
        Me.Btn_Generate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Generate.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Generate.Location = New System.Drawing.Point(1274, 249)
        Me.Btn_Generate.Name = "Btn_Generate"
        Me.Btn_Generate.Size = New System.Drawing.Size(91, 34)
        Me.Btn_Generate.TabIndex = 56
        Me.Btn_Generate.Text = "Generate QR"
        Me.Btn_Generate.UseVisualStyleBackColor = False
        '
        'pic_QRcode
        '
        Me.pic_QRcode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pic_QRcode.Location = New System.Drawing.Point(1273, 98)
        Me.pic_QRcode.Name = "pic_QRcode"
        Me.pic_QRcode.Size = New System.Drawing.Size(172, 142)
        Me.pic_QRcode.TabIndex = 57
        Me.pic_QRcode.TabStop = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(1250, 58)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(34, 22)
        Me.lbl2.TabIndex = 58
        Me.lbl2.Text = "QR"
        '
        'txt_QRcode
        '
        Me.txt_QRcode.Location = New System.Drawing.Point(1290, 56)
        Me.txt_QRcode.Name = "txt_QRcode"
        Me.txt_QRcode.Size = New System.Drawing.Size(155, 26)
        Me.txt_QRcode.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1371, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 34)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1623, 1038)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_QRcode)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.pic_QRcode)
        Me.Controls.Add(Me.Btn_Generate)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.lblcate)
        Me.Controls.Add(Me.amt)
        Me.Controls.Add(Me.txtGST)
        Me.Controls.Add(Me.gst)
        Me.Controls.Add(Me.lbldisc)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.proname)
        Me.Controls.Add(Me.proid)
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_QRcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents qty As System.Windows.Forms.Label
    Friend WithEvents price As System.Windows.Forms.Label
    Friend WithEvents proname As System.Windows.Forms.Label
    Friend WithEvents proid As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lbldisc As System.Windows.Forms.Label
    Friend WithEvents txtGST As System.Windows.Forms.TextBox
    Friend WithEvents gst As System.Windows.Forms.Label
    Friend WithEvents amt As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblcate As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Generate As System.Windows.Forms.Button
    Friend WithEvents pic_QRcode As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txt_QRcode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
