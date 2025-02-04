Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with user types
        cmbUserType.Items.Add("Admin")
        cmbUserType.Items.Add("Manager")
        cmbUserType.Items.Add("User")
        cmbUserType.SelectedIndex = 0 ' Default selection
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate input
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbUserType.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Database connection and query
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ddbb\Users.accdb"
        Dim query As String = "SELECT * FROM Usertype WHERE Username = ? AND Password = ? AND UserType = ?"

        Using conn As New OleDbConnection(connString),
              cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@UserType", cmbUserType.SelectedItem.ToString())

            conn.Open()
            Using reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    ' Login successful
                    reader.Read()
                    Select Case cmbUserType.SelectedItem.ToString().ToLower()
                        Case "admin"
                            Dim adminForm As New Admin()
                            adminForm.Show()
                        Case "manager"
                            Dim managerForm As New Manager()
                            managerForm.Show()
                        Case "user"
                            Dim userForm As New User()
                            userForm.Show()
                    End Select
                    Me.Hide()
                Else
                    ' Login failed
                    MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Butto3_Click(sender As Object, e As EventArgs) Handles Butto3.Click
        txtUsername.Text = " "
        txtPassword.Text = ""
    End Sub
End Class