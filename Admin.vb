Imports System.Data.OleDb
Public Class Admin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndash.Click
        With Dashboard
            .TopLevel = (False)
            Panel4.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnusers_Click(sender As Object, e As EventArgs) Handles btnusers.Click
        With User
            .TopLevel = (False)
            Panel4.Controls.Add(User)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btncust_Click(sender As Object, e As EventArgs) Handles btncust.Click
            With customers
                .TopLevel = False
            Panel4.Controls.Add(customers)
            .BringToFront()
            .Show()
            End With
    End Sub

    Private Sub btnprod_Click(sender As Object, e As EventArgs) Handles btnprod.Click
        With Product
            .TopLevel = (False)
            Panel4.Controls.Add(Product)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnbill_Click(sender As Object, e As EventArgs) Handles btnbill.Click
        With BillingForm
            .TopLevel = (False)
            Panel4.Controls.Add(BillingForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class