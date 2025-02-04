<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.dashp2 = New System.Windows.Forms.Panel()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.dashp3 = New System.Windows.Forms.Panel()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.dashp4 = New System.Windows.Forms.Panel()
        Me.lblTotalProducts = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dashp2.SuspendLayout()
        Me.dashp3.SuspendLayout()
        Me.dashp4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dashp2
        '
        Me.dashp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.dashp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dashp2.Controls.Add(Me.lblTotalUsers)
        Me.dashp2.Location = New System.Drawing.Point(621, 372)
        Me.dashp2.Name = "dashp2"
        Me.dashp2.Size = New System.Drawing.Size(295, 182)
        Me.dashp2.TabIndex = 0
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsers.Location = New System.Drawing.Point(22, 81)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(98, 35)
        Me.lblTotalUsers.TabIndex = 0
        Me.lblTotalUsers.Text = "Label1"
        '
        'dashp3
        '
        Me.dashp3.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.dashp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.dashp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dashp3.Controls.Add(Me.lblTotalCustomers)
        Me.dashp3.Location = New System.Drawing.Point(1057, 372)
        Me.dashp3.Name = "dashp3"
        Me.dashp3.Size = New System.Drawing.Size(295, 182)
        Me.dashp3.TabIndex = 1
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomers.Location = New System.Drawing.Point(22, 81)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(102, 35)
        Me.lblTotalCustomers.TabIndex = 1
        Me.lblTotalCustomers.Text = "Label2"
        '
        'dashp4
        '
        Me.dashp4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.dashp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dashp4.Controls.Add(Me.lblTotalProducts)
        Me.dashp4.Location = New System.Drawing.Point(180, 372)
        Me.dashp4.Name = "dashp4"
        Me.dashp4.Size = New System.Drawing.Size(295, 182)
        Me.dashp4.TabIndex = 2
        '
        'lblTotalProducts
        '
        Me.lblTotalProducts.AutoSize = True
        Me.lblTotalProducts.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProducts.Location = New System.Drawing.Point(22, 82)
        Me.lblTotalProducts.Name = "lblTotalProducts"
        Me.lblTotalProducts.Size = New System.Drawing.Size(101, 35)
        Me.lblTotalProducts.TabIndex = 1
        Me.lblTotalProducts.Text = "Label3"
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(653, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Welcome Back ! "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1029, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "This dashboard will display information about the total number of users, customer" & _
    "s, and products" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(627, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 52)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dashboard"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1754, 986)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dashp4)
        Me.Controls.Add(Me.dashp2)
        Me.Controls.Add(Me.dashp3)
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.dashp2.ResumeLayout(False)
        Me.dashp2.PerformLayout()
        Me.dashp3.ResumeLayout(False)
        Me.dashp3.PerformLayout()
        Me.dashp4.ResumeLayout(False)
        Me.dashp4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dashp2 As System.Windows.Forms.Panel
    Friend WithEvents dashp3 As System.Windows.Forms.Panel
    Friend WithEvents dashp4 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalUsers As System.Windows.Forms.Label
    Friend WithEvents lblTotalCustomers As System.Windows.Forms.Label
    Friend WithEvents lblTotalProducts As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
