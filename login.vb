Imports MySql.Data.MySqlClient

Public Class login
    Dim cl As New Connection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles un.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        If DialogResult.OK = MessageBox.Show("Voulez vous quitter la page?", "Informations", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) Then
            Application.Exit()
        End If


    End Sub
    Sub authentification()
        Dim req As String = "select * from users where username = '" & usern.Text & "'and password='" & psd.Text & "'"
        Dim dr As MySqlDataReader = cl.execute(req)
        If dr.HasRows Then
            If dr.Read Then
                If dr(5) = 1 Then

                    Dim str2 As String

                    str2 = dr(1).ToString()
                    Control.zone.Text = "Welcome, " + str2 + " in your personal space"

                    Me.Hide()
                    Control.Show()

                Else
                    Dim str2 As String

                    str2 = dr(1).ToString()
                    User.zone1.Text = "Welcome, " + str2 + " Here is our available books"
                    Me.Hide()
                    User.Show()
                End If

            End If
        Else

            MessageBox.Show("User not found")
        End If
        cl.disconnect()
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        authentification()

    End Sub

End Class
