<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnbill = New System.Windows.Forms.Button()
        Me.btncust = New System.Windows.Forms.Button()
        Me.btnusers = New System.Windows.Forms.Button()
        Me.btnprod = New System.Windows.Forms.Button()
        Me.btndash = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnreport)
        Me.Panel1.Controls.Add(Me.btnbill)
        Me.Panel1.Controls.Add(Me.btncust)
        Me.Panel1.Controls.Add(Me.btnusers)
        Me.Panel1.Controls.Add(Me.btnprod)
        Me.Panel1.Controls.Add(Me.btndash)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 969)
        Me.Panel1.TabIndex = 0
        '
        'btnlogout
        '
        Me.btnlogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnlogout.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_logout_30
        Me.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(0, 879)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(221, 60)
        Me.btnlogout.TabIndex = 8
        Me.btnlogout.Text = "Log Out"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnreport.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_report_30
        Me.btnreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreport.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(2, 453)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(218, 61)
        Me.btnreport.TabIndex = 7
        Me.btnreport.Text = "   Report"
        Me.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnbill
        '
        Me.btnbill.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbill.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnbill.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_estimate_30
        Me.btnbill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnbill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbill.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbill.Location = New System.Drawing.Point(2, 384)
        Me.btnbill.Name = "btnbill"
        Me.btnbill.Size = New System.Drawing.Size(218, 61)
        Me.btnbill.TabIndex = 6
        Me.btnbill.Text = "  Billing"
        Me.btnbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbill.UseVisualStyleBackColor = False
        '
        'btncust
        '
        Me.btncust.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncust.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btncust.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_human_resources_29__1_
        Me.btncust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btncust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncust.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncust.Location = New System.Drawing.Point(2, 315)
        Me.btncust.Name = "btncust"
        Me.btncust.Size = New System.Drawing.Size(218, 61)
        Me.btncust.TabIndex = 5
        Me.btncust.Text = "      Customer"
        Me.btncust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncust.UseVisualStyleBackColor = False
        '
        'btnusers
        '
        Me.btnusers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnusers.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnusers.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_people_29
        Me.btnusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnusers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusers.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusers.Location = New System.Drawing.Point(2, 243)
        Me.btnusers.Name = "btnusers"
        Me.btnusers.Size = New System.Drawing.Size(218, 61)
        Me.btnusers.TabIndex = 4
        Me.btnusers.Text = "Users"
        Me.btnusers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnusers.UseVisualStyleBackColor = False
        '
        'btnprod
        '
        Me.btnprod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprod.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnprod.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_product_30
        Me.btnprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnprod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprod.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprod.Location = New System.Drawing.Point(2, 175)
        Me.btnprod.Name = "btnprod"
        Me.btnprod.Size = New System.Drawing.Size(218, 61)
        Me.btnprod.TabIndex = 3
        Me.btnprod.Text = "    Product"
        Me.btnprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprod.UseVisualStyleBackColor = False
        '
        'btndash
        '
        Me.btndash.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndash.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btndash.BackgroundImage = Global.Shop.My.Resources.Resources.icons8_dashboard_layout_30
        Me.btndash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndash.Font = New System.Drawing.Font("Sitka Banner", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndash.Location = New System.Drawing.Point(2, 105)
        Me.btndash.Name = "btndash"
        Me.btndash.Size = New System.Drawing.Size(218, 61)
        Me.btndash.TabIndex = 2
        Me.btndash.Text = "     Dashboard"
        Me.btndash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndash.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 77)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(221, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1645, 77)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(614, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Panel"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(221, 77)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1645, 892)
        Me.Panel4.TabIndex = 2
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1866, 969)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Admin"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btndash As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btnbill As System.Windows.Forms.Button
    Friend WithEvents btncust As System.Windows.Forms.Button
    Friend WithEvents btnusers As System.Windows.Forms.Button
    Friend WithEvents btnprod As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
