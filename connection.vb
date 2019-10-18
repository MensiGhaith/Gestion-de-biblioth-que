Imports MySql.Data.MySqlClient

Public Class Connection
    Public con As New MySqlConnection("Server=localhost;Database=gb;Uid=root;Pwd=")
    Public cmd As MySqlCommand

    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter

    Public Function execute(ByVal req As String) As MySqlDataReader
        Try
            con.Open()
            cmd = New MySqlCommand(req, con)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox("Erreur in your connexion")
        End Try
        Return dr
    End Function
    Sub charger_grid(ByVal grid As DataGridView, ByVal req As String)
        Try
            cmd = New MySqlCommand(req, con)
            da = New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            grid.DataSource = table

        Catch ex As MySqlException
            MsgBox("Erreur in your request")
        End Try

    End Sub
    Sub charger_combo(ByVal combo As ComboBox, ByVal req As String)
        Try
            cmd = New MySqlCommand(req, con)
            da = New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            combo.DataSource = table
        Catch ex As MySqlException
            MsgBox("Erreur in your request")
        End Try

    End Sub
    Sub mettre_a_jour(ByVal req As String)
        Try
            con.Open()
            cmd = New MySqlCommand(req, con)
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Update successfully completed")
            End If
            disconnect()
        Catch ex As MySqlException
            MsgBox("Erreur in your request")
        End Try

    End Sub
    Function charger_liste(ByVal req As String) As DataSet
        cmd = New MySqlCommand(req, con)
        da = New MySqlDataAdapter(cmd)
        disconnect()
        Dim ds As New DataSet
        ds.Clear()
        da.Fill(ds, "tble")
        Return ds
    End Function
    Public Sub disconnect()
        con.Dispose()
        cmd.Dispose()
    End Sub
    Sub loadbook1(ByVal req As String, ByVal Type As ComboBox)


        cmd = New MySqlCommand(req, con)
        Dim da As New MySqlDataAdapter(cmd)
        Dim table As New DataTable
        con.Close()
        da.Fill(table)
        Type.DataSource = table
        Type.DisplayMember = "title"
        Type.ValueMember = "isbn"
        cmd.Dispose()


    End Sub
    Sub loadbook2(ByVal req As String, ByVal Type As ComboBox)


        cmd = New MySqlCommand(req, con)
        Dim da As New MySqlDataAdapter(cmd)
        Dim table As New DataTable
        con.Close()
        da.Fill(table)
        Type.DataSource = table
        Type.DisplayMember = "cin"
        Type.ValueMember = "cin"
        cmd.Dispose()


    End Sub
    Function verif_cin(ByVal req As String) As Integer
        Dim a As Integer

        dr = execute(req)
        If dr.HasRows Then
            a = 1
        Else
            a = 0

        End If
        con.Dispose()


        Return a

    End Function
    Sub add(ByVal req As String)
        con.Open()

        cmd = New MySqlCommand(req, con)
        Try
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("insertion successfully completed")


            End If
        Catch ex As Exception
            MsgBox("ERROR")
        End Try

        con.Close()
        cmd.Dispose()

    End Sub

End Class

