<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        adminpanelf3 = New Label()
        searchtxtboxf7 = New TextBox()
        searchf7 = New Label()
        TabControl1 = New TabControl()
        TabPage2F7 = New TabPage()
        email27 = New TextBox()
        add27 = New TextBox()
        emailtf27 = New Label()
        addresstf27 = New Label()
        contacttf27 = New TextBox()
        cont27 = New Label()
        custname27 = New TextBox()
        custnametf27 = New Label()
        DataGridView2 = New DataGridView()
        custid7 = New DataGridViewTextBoxColumn()
        Custname7 = New DataGridViewTextBoxColumn()
        phone7 = New DataGridViewTextBoxColumn()
        emaill7 = New DataGridViewTextBoxColumn()
        adress7 = New DataGridViewTextBoxColumn()
        custid27 = New TextBox()
        custidtf27 = New Label()
        TabPage3f7 = New TabPage()
        unit36 = New TextBox()
        uom36 = New Label()
        TextBox3Qty36 = New TextBox()
        QTY36 = New Label()
        PRICE = New TextBox()
        price36 = New Label()
        desc36 = New TextBox()
        Description36 = New Label()
        TextBox36 = New TextBox()
        proname36 = New Label()
        Proid26 = New TextBox()
        proid36 = New Label()
        DataGridView3 = New DataGridView()
        Column15 = New DataGridViewTextBoxColumn()
        col16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        TabPage4f7 = New TabPage()
        DateTimePickerf7 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        oderid = New DataGridViewTextBoxColumn()
        custid = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        address = New DataGridViewTextBoxColumn()
        datee = New DataGridViewTextBoxColumn()
        email7 = New TextBox()
        addf7 = New TextBox()
        emailf7 = New Label()
        add7 = New Label()
        datef7 = New Label()
        orderf7 = New TextBox()
        orderidf7 = New Label()
        custf7 = New TextBox()
        custidf7 = New Label()
        TabPage5f7 = New TabPage()
        TabControl1.SuspendLayout()
        TabPage2F7.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3f7.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4f7.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' adminpanelf3
        ' 
        adminpanelf3.AutoSize = True
        adminpanelf3.BackColor = Color.Transparent
        adminpanelf3.Font = New Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point)
        adminpanelf3.ForeColor = Color.Teal
        adminpanelf3.Location = New Point(27, 9)
        adminpanelf3.Name = "adminpanelf3"
        adminpanelf3.Size = New Size(287, 39)
        adminpanelf3.TabIndex = 7
        adminpanelf3.Text = "MANAGER PANEL"
        ' 
        ' searchtxtboxf7
        ' 
        searchtxtboxf7.Location = New Point(984, 39)
        searchtxtboxf7.Name = "searchtxtboxf7"
        searchtxtboxf7.Size = New Size(288, 31)
        searchtxtboxf7.TabIndex = 10
        ' 
        ' searchf7
        ' 
        searchf7.AutoSize = True
        searchf7.Font = New Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point)
        searchf7.ForeColor = Color.Teal
        searchf7.Location = New Point(985, 9)
        searchf7.Name = "searchf7"
        searchf7.Size = New Size(87, 23)
        searchf7.TabIndex = 9
        searchf7.Text = "Search..."
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage2F7)
        TabControl1.Controls.Add(TabPage3f7)
        TabControl1.Controls.Add(TabPage4f7)
        TabControl1.Controls.Add(TabPage5f7)
        TabControl1.Font = New Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.Location = New Point(3, 119)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1339, 530)
        TabControl1.SizeMode = TabSizeMode.FillToRight
        TabControl1.TabIndex = 13
        ' 
        ' TabPage2F7
        ' 
        TabPage2F7.BackColor = Color.LightBlue
        TabPage2F7.BackgroundImageLayout = ImageLayout.Center
        TabPage2F7.BorderStyle = BorderStyle.Fixed3D
        TabPage2F7.Controls.Add(email27)
        TabPage2F7.Controls.Add(add27)
        TabPage2F7.Controls.Add(emailtf27)
        TabPage2F7.Controls.Add(addresstf27)
        TabPage2F7.Controls.Add(contacttf27)
        TabPage2F7.Controls.Add(cont27)
        TabPage2F7.Controls.Add(custname27)
        TabPage2F7.Controls.Add(custnametf27)
        TabPage2F7.Controls.Add(DataGridView2)
        TabPage2F7.Controls.Add(custid27)
        TabPage2F7.Controls.Add(custidtf27)
        TabPage2F7.Font = New Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage2F7.Location = New Point(4, 33)
        TabPage2F7.Name = "TabPage2F7"
        TabPage2F7.Padding = New Padding(3)
        TabPage2F7.Size = New Size(1331, 493)
        TabPage2F7.TabIndex = 1
        TabPage2F7.Text = "     Customer Management    "
        ' 
        ' email27
        ' 
        email27.Location = New Point(771, 61)
        email27.Name = "email27"
        email27.Size = New Size(228, 34)
        email27.TabIndex = 23
        ' 
        ' add27
        ' 
        add27.Location = New Point(1026, 61)
        add27.Name = "add27"
        add27.Size = New Size(228, 34)
        add27.TabIndex = 28
        ' 
        ' emailtf27
        ' 
        emailtf27.AutoSize = True
        emailtf27.BackColor = Color.Transparent
        emailtf27.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        emailtf27.ForeColor = Color.DarkSlateGray
        emailtf27.Location = New Point(774, 29)
        emailtf27.Name = "emailtf27"
        emailtf27.Size = New Size(75, 35)
        emailtf27.TabIndex = 22
        emailtf27.Text = "Email"
        ' 
        ' addresstf27
        ' 
        addresstf27.AutoSize = True
        addresstf27.BackColor = Color.Transparent
        addresstf27.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        addresstf27.ForeColor = Color.DarkSlateGray
        addresstf27.Location = New Point(1029, 29)
        addresstf27.Name = "addresstf27"
        addresstf27.Size = New Size(96, 35)
        addresstf27.TabIndex = 27
        addresstf27.Text = "Address"
        ' 
        ' contacttf27
        ' 
        contacttf27.Location = New Point(515, 61)
        contacttf27.Name = "contacttf27"
        contacttf27.Size = New Size(228, 34)
        contacttf27.TabIndex = 26
        ' 
        ' cont27
        ' 
        cont27.AutoSize = True
        cont27.BackColor = Color.Transparent
        cont27.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cont27.ForeColor = Color.DarkSlateGray
        cont27.Location = New Point(518, 29)
        cont27.Name = "cont27"
        cont27.Size = New Size(159, 35)
        cont27.TabIndex = 25
        cont27.Text = "Contact Phone"
        ' 
        ' custname27
        ' 
        custname27.Location = New Point(260, 61)
        custname27.Name = "custname27"
        custname27.Size = New Size(228, 34)
        custname27.TabIndex = 24
        ' 
        ' custnametf27
        ' 
        custnametf27.AutoSize = True
        custnametf27.BackColor = Color.Transparent
        custnametf27.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        custnametf27.ForeColor = Color.DarkSlateGray
        custnametf27.Location = New Point(263, 27)
        custnametf27.Name = "custnametf27"
        custnametf27.Size = New Size(121, 35)
        custnametf27.TabIndex = 23
        custnametf27.Text = "Cust name"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {custid7, Custname7, phone7, emaill7, adress7})
        DataGridView2.Location = New Point(2, 147)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 62
        DataGridView2.RowTemplate.Height = 33
        DataGridView2.Size = New Size(1289, 488)
        DataGridView2.TabIndex = 22
        ' 
        ' custid7
        ' 
        custid7.HeaderText = "Customer id"
        custid7.MinimumWidth = 8
        custid7.Name = "custid7"
        custid7.Width = 150
        ' 
        ' Custname7
        ' 
        Custname7.HeaderText = "Customer name"
        Custname7.MinimumWidth = 8
        Custname7.Name = "Custname7"
        Custname7.Width = 150
        ' 
        ' phone7
        ' 
        phone7.HeaderText = "Phone "
        phone7.MinimumWidth = 8
        phone7.Name = "phone7"
        phone7.Width = 150
        ' 
        ' emaill7
        ' 
        emaill7.HeaderText = "Email"
        emaill7.MinimumWidth = 8
        emaill7.Name = "emaill7"
        emaill7.Width = 150
        ' 
        ' adress7
        ' 
        adress7.HeaderText = "Address"
        adress7.MinimumWidth = 8
        adress7.Name = "adress7"
        adress7.Width = 150
        ' 
        ' custid27
        ' 
        custid27.Location = New Point(6, 61)
        custid27.Name = "custid27"
        custid27.Size = New Size(228, 34)
        custid27.TabIndex = 21
        ' 
        ' custidtf27
        ' 
        custidtf27.AutoSize = True
        custidtf27.BackColor = Color.Transparent
        custidtf27.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        custidtf27.ForeColor = Color.DarkSlateGray
        custidtf27.Location = New Point(9, 26)
        custidtf27.Name = "custidtf27"
        custidtf27.Size = New Size(85, 35)
        custidtf27.TabIndex = 20
        custidtf27.Text = "Cust id"
        ' 
        ' TabPage3f7
        ' 
        TabPage3f7.BackColor = Color.LightSteelBlue
        TabPage3f7.BackgroundImageLayout = ImageLayout.Center
        TabPage3f7.BorderStyle = BorderStyle.Fixed3D
        TabPage3f7.Controls.Add(unit36)
        TabPage3f7.Controls.Add(uom36)
        TabPage3f7.Controls.Add(TextBox3Qty36)
        TabPage3f7.Controls.Add(QTY36)
        TabPage3f7.Controls.Add(PRICE)
        TabPage3f7.Controls.Add(price36)
        TabPage3f7.Controls.Add(desc36)
        TabPage3f7.Controls.Add(Description36)
        TabPage3f7.Controls.Add(TextBox36)
        TabPage3f7.Controls.Add(proname36)
        TabPage3f7.Controls.Add(Proid26)
        TabPage3f7.Controls.Add(proid36)
        TabPage3f7.Controls.Add(DataGridView3)
        TabPage3f7.Font = New Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage3f7.Location = New Point(4, 33)
        TabPage3f7.Name = "TabPage3f7"
        TabPage3f7.Padding = New Padding(3)
        TabPage3f7.Size = New Size(1331, 493)
        TabPage3f7.TabIndex = 2
        TabPage3f7.Text = "     Product Management    "
        ' 
        ' unit36
        ' 
        unit36.Location = New Point(334, 128)
        unit36.Name = "unit36"
        unit36.Size = New Size(295, 34)
        unit36.TabIndex = 31
        ' 
        ' uom36
        ' 
        uom36.AutoSize = True
        uom36.BackColor = Color.Transparent
        uom36.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        uom36.ForeColor = Color.DarkSlateGray
        uom36.Location = New Point(331, 94)
        uom36.Name = "uom36"
        uom36.Size = New Size(230, 35)
        uom36.TabIndex = 30
        uom36.Text = "Unit of measurement"
        ' 
        ' TextBox3Qty36
        ' 
        TextBox3Qty36.Location = New Point(9, 128)
        TextBox3Qty36.Name = "TextBox3Qty36"
        TextBox3Qty36.Size = New Size(295, 34)
        TextBox3Qty36.TabIndex = 29
        ' 
        ' QTY36
        ' 
        QTY36.AutoSize = True
        QTY36.BackColor = Color.Transparent
        QTY36.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        QTY36.ForeColor = Color.DarkSlateGray
        QTY36.Location = New Point(12, 92)
        QTY36.Name = "QTY36"
        QTY36.Size = New Size(104, 35)
        QTY36.TabIndex = 28
        QTY36.Text = "Quantity"
        ' 
        ' PRICE
        ' 
        PRICE.Location = New Point(979, 50)
        PRICE.Name = "PRICE"
        PRICE.Size = New Size(295, 34)
        PRICE.TabIndex = 27
        ' 
        ' price36
        ' 
        price36.AutoSize = True
        price36.BackColor = Color.Transparent
        price36.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        price36.ForeColor = Color.DarkSlateGray
        price36.Location = New Point(982, 17)
        price36.Name = "price36"
        price36.Size = New Size(66, 35)
        price36.TabIndex = 26
        price36.Text = "Price"
        ' 
        ' desc36
        ' 
        desc36.Location = New Point(654, 50)
        desc36.Name = "desc36"
        desc36.Size = New Size(295, 34)
        desc36.TabIndex = 25
        ' 
        ' Description36
        ' 
        Description36.AutoSize = True
        Description36.BackColor = Color.Transparent
        Description36.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Description36.ForeColor = Color.DarkSlateGray
        Description36.Location = New Point(653, 14)
        Description36.Name = "Description36"
        Description36.Size = New Size(132, 35)
        Description36.TabIndex = 24
        Description36.Text = "Description"
        ' 
        ' TextBox36
        ' 
        TextBox36.Location = New Point(335, 50)
        TextBox36.Name = "TextBox36"
        TextBox36.Size = New Size(295, 34)
        TextBox36.TabIndex = 23
        ' 
        ' proname36
        ' 
        proname36.AutoSize = True
        proname36.BackColor = Color.Transparent
        proname36.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        proname36.ForeColor = Color.DarkSlateGray
        proname36.Location = New Point(338, 17)
        proname36.Name = "proname36"
        proname36.Size = New Size(112, 35)
        proname36.TabIndex = 22
        proname36.Text = "Pro name"
        ' 
        ' Proid26
        ' 
        Proid26.Location = New Point(9, 50)
        Proid26.Name = "Proid26"
        Proid26.Size = New Size(295, 34)
        Proid26.TabIndex = 21
        ' 
        ' proid36
        ' 
        proid36.AutoSize = True
        proid36.BackColor = Color.Transparent
        proid36.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        proid36.ForeColor = Color.DarkSlateGray
        proid36.Location = New Point(12, 15)
        proid36.Name = "proid36"
        proid36.Size = New Size(120, 35)
        proid36.TabIndex = 20
        proid36.Text = "Product id"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Column15, col16, Column17, Column18, Column19, Column16})
        DataGridView3.Location = New Point(9, 194)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 62
        DataGridView3.RowTemplate.Height = 33
        DataGridView3.Size = New Size(1266, 362)
        DataGridView3.TabIndex = 0
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Product id"
        Column15.MinimumWidth = 8
        Column15.Name = "Column15"
        Column15.Width = 150
        ' 
        ' col16
        ' 
        col16.HeaderText = "Pro name"
        col16.MinimumWidth = 8
        col16.Name = "col16"
        col16.Width = 150
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "Description"
        Column17.MinimumWidth = 8
        Column17.Name = "Column17"
        Column17.Width = 150
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "Price"
        Column18.MinimumWidth = 8
        Column18.Name = "Column18"
        Column18.Width = 150
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "Quantity"
        Column19.MinimumWidth = 8
        Column19.Name = "Column19"
        Column19.Width = 150
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Unit of measurement"
        Column16.MinimumWidth = 8
        Column16.Name = "Column16"
        Column16.Width = 150
        ' 
        ' TabPage4f7
        ' 
        TabPage4f7.BackColor = Color.LightBlue
        TabPage4f7.BackgroundImageLayout = ImageLayout.Center
        TabPage4f7.BorderStyle = BorderStyle.Fixed3D
        TabPage4f7.Controls.Add(DateTimePickerf7)
        TabPage4f7.Controls.Add(DataGridView1)
        TabPage4f7.Controls.Add(email7)
        TabPage4f7.Controls.Add(addf7)
        TabPage4f7.Controls.Add(emailf7)
        TabPage4f7.Controls.Add(add7)
        TabPage4f7.Controls.Add(datef7)
        TabPage4f7.Controls.Add(orderf7)
        TabPage4f7.Controls.Add(orderidf7)
        TabPage4f7.Controls.Add(custf7)
        TabPage4f7.Controls.Add(custidf7)
        TabPage4f7.Font = New Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage4f7.Location = New Point(4, 33)
        TabPage4f7.Name = "TabPage4f7"
        TabPage4f7.Padding = New Padding(3)
        TabPage4f7.Size = New Size(1331, 493)
        TabPage4f7.TabIndex = 3
        TabPage4f7.Text = "Order Management"
        ' 
        ' DateTimePickerf7
        ' 
        DateTimePickerf7.Location = New Point(1051, 58)
        DateTimePickerf7.Name = "DateTimePickerf7"
        DateTimePickerf7.Size = New Size(228, 34)
        DateTimePickerf7.TabIndex = 40
        ' 
        ' DataGridView1
        ' 
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {oderid, custid, email, address, datee})
        DataGridView1.Location = New Point(1, 151)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1266, 362)
        DataGridView1.TabIndex = 39
        ' 
        ' oderid
        ' 
        oderid.HeaderText = "Order id"
        oderid.MinimumWidth = 8
        oderid.Name = "oderid"
        oderid.Width = 150
        ' 
        ' custid
        ' 
        custid.HeaderText = "Cust id"
        custid.MinimumWidth = 8
        custid.Name = "custid"
        custid.Width = 150
        ' 
        ' email
        ' 
        email.HeaderText = "Email"
        email.MinimumWidth = 8
        email.Name = "email"
        email.Width = 150
        ' 
        ' address
        ' 
        address.HeaderText = "Address"
        address.MinimumWidth = 8
        address.Name = "address"
        address.Width = 150
        ' 
        ' datee
        ' 
        datee.HeaderText = "Date"
        datee.MinimumWidth = 8
        datee.Name = "datee"
        datee.Width = 150
        ' 
        ' email7
        ' 
        email7.Location = New Point(525, 60)
        email7.Name = "email7"
        email7.Size = New Size(228, 34)
        email7.TabIndex = 32
        ' 
        ' addf7
        ' 
        addf7.Location = New Point(788, 60)
        addf7.Name = "addf7"
        addf7.Size = New Size(228, 34)
        addf7.TabIndex = 38
        ' 
        ' emailf7
        ' 
        emailf7.AutoSize = True
        emailf7.BackColor = Color.Transparent
        emailf7.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        emailf7.ForeColor = Color.DarkSlateGray
        emailf7.Location = New Point(528, 28)
        emailf7.Name = "emailf7"
        emailf7.Size = New Size(75, 35)
        emailf7.TabIndex = 31
        emailf7.Text = "Email"
        ' 
        ' add7
        ' 
        add7.AutoSize = True
        add7.BackColor = Color.Transparent
        add7.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        add7.ForeColor = Color.DarkSlateGray
        add7.Location = New Point(791, 28)
        add7.Name = "add7"
        add7.Size = New Size(96, 35)
        add7.TabIndex = 37
        add7.Text = "Address"
        ' 
        ' datef7
        ' 
        datef7.AutoSize = True
        datef7.BackColor = Color.Transparent
        datef7.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        datef7.ForeColor = Color.DarkSlateGray
        datef7.Location = New Point(1051, 22)
        datef7.Name = "datef7"
        datef7.Size = New Size(62, 35)
        datef7.TabIndex = 35
        datef7.Text = "Date"
        ' 
        ' orderf7
        ' 
        orderf7.Location = New Point(4, 60)
        orderf7.Name = "orderf7"
        orderf7.Size = New Size(228, 34)
        orderf7.TabIndex = 34
        ' 
        ' orderidf7
        ' 
        orderidf7.AutoSize = True
        orderidf7.BackColor = Color.Transparent
        orderidf7.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        orderidf7.ForeColor = Color.DarkSlateGray
        orderidf7.Location = New Point(6, 22)
        orderidf7.Name = "orderidf7"
        orderidf7.Size = New Size(101, 35)
        orderidf7.TabIndex = 33
        orderidf7.Text = "Order id"
        ' 
        ' custf7
        ' 
        custf7.Location = New Point(261, 60)
        custf7.Name = "custf7"
        custf7.Size = New Size(228, 34)
        custf7.TabIndex = 30
        ' 
        ' custidf7
        ' 
        custidf7.AutoSize = True
        custidf7.BackColor = Color.Transparent
        custidf7.Font = New Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        custidf7.ForeColor = Color.DarkSlateGray
        custidf7.Location = New Point(261, 22)
        custidf7.Name = "custidf7"
        custidf7.Size = New Size(85, 35)
        custidf7.TabIndex = 29
        custidf7.Text = "Cust id"
        ' 
        ' TabPage5f7
        ' 
        TabPage5f7.BackColor = Color.LightSteelBlue
        TabPage5f7.BackgroundImageLayout = ImageLayout.Center
        TabPage5f7.BorderStyle = BorderStyle.Fixed3D
        TabPage5f7.Font = New Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point)
        TabPage5f7.Location = New Point(4, 33)
        TabPage5f7.Name = "TabPage5f7"
        TabPage5f7.Size = New Size(1331, 493)
        TabPage5f7.TabIndex = 4
        TabPage5f7.Text = "        Report      "
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1713, 643)
        Controls.Add(TabControl1)
        Controls.Add(searchtxtboxf7)
        Controls.Add(searchf7)
        Controls.Add(adminpanelf3)
        Name = "Form7"
        Text = "Form7"
        TabControl1.ResumeLayout(False)
        TabPage2F7.ResumeLayout(False)
        TabPage2F7.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        TabPage3f7.ResumeLayout(False)
        TabPage3f7.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        TabPage4f7.ResumeLayout(False)
        TabPage4f7.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents adminpanelf3 As Label
    Friend WithEvents searchtxtboxf7 As TextBox
    Friend WithEvents searchf7 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2F7 As TabPage
    Friend WithEvents email27 As TextBox
    Friend WithEvents add27 As TextBox
    Friend WithEvents emailtf27 As Label
    Friend WithEvents addresstf27 As Label
    Friend WithEvents contacttf27 As TextBox
    Friend WithEvents cont27 As Label
    Friend WithEvents custname27 As TextBox
    Friend WithEvents custnametf27 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents custid27 As TextBox
    Friend WithEvents custidtf27 As Label
    Friend WithEvents TabPage3f7 As TabPage
    Friend WithEvents unit36 As TextBox
    Friend WithEvents uom36 As Label
    Friend WithEvents TextBox3Qty36 As TextBox
    Friend WithEvents QTY36 As Label
    Friend WithEvents PRICE As TextBox
    Friend WithEvents price36 As Label
    Friend WithEvents desc36 As TextBox
    Friend WithEvents Description36 As Label
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents proname36 As Label
    Friend WithEvents Proid26 As TextBox
    Friend WithEvents proid36 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents col16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage4f7 As TabPage
    Friend WithEvents TabPage5f7 As TabPage
    Friend WithEvents email7 As TextBox
    Friend WithEvents addf7 As TextBox
    Friend WithEvents emailf7 As Label
    Friend WithEvents add7 As Label
    Friend WithEvents datef7 As Label
    Friend WithEvents orderf7 As TextBox
    Friend WithEvents orderidf7 As Label
    Friend WithEvents custf7 As TextBox
    Friend WithEvents custidf7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePickerf7 As DateTimePicker
    Friend WithEvents oderid As DataGridViewTextBoxColumn
    Friend WithEvents custid As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents datee As DataGridViewTextBoxColumn
    Friend WithEvents custid7 As DataGridViewTextBoxColumn
    Friend WithEvents Custname7 As DataGridViewTextBoxColumn
    Friend WithEvents phone7 As DataGridViewTextBoxColumn
    Friend WithEvents emaill7 As DataGridViewTextBoxColumn
    Friend WithEvents adress7 As DataGridViewTextBoxColumn
End Class
