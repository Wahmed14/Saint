Imports Microsoft.VisualBasic.ApplicationServices

Public Class Users_Manager
    Inherits Manager
    Private Shared Function getUserGenerique() As Users
        Dim users As Users = New Users(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                users = New Users(CInt(row("id")), row("username"), row("function_field"), row("password_field"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Users
    End Function

    Public Shared Function getById(id As Integer) As Users
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getUserGenerique()
    End Function

    Public Shared Function getByUsername(username As String) As Users
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE username = @username;", Manager.connection)
        command.Parameters.AddWithValue("@username", username)
        Return getUserGenerique()
    End Function

    Public Shared Function getUsersGenerique() As List(Of Users)
        Dim userList As New List(Of Users)()
        Try

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            dataAdapater.Fill(dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                userList.Add(New Users(CInt(row("id")), row("username"), row("function_field"), row("password_field")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return userList
    End Function

    Public Shared Function getAll() As List(Of Users)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users;", Manager.connection)
        Return getUsersGenerique()
    End Function

    Public Shared Function searchUsersByUsername(username As String)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE username LIKE @username ;", Manager.connection)
        command.Parameters.AddWithValue("@username", "%" & username & "%")
        Return getUsersGenerique()
    End Function

    Public Shared Function store(users As Users) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO Users(username, function_field, password_field) VALUES (@username, @function_field, @password_field);", Manager.connection)
            command.Parameters.AddWithValue("@username", users.Username)
            command.Parameters.AddWithValue("@function_field", users.Function_field)
            command.Parameters.AddWithValue("@password_field", users.Password_field)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function update(users As Users, id As Integer, update_password_field As Boolean) As Boolean
        Try
            If (update_password_field) Then
                command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Users SET username = @username, function_field = @function_field, password_field = @password_field WHERE id = @id;", Manager.connection)
                command.Parameters.AddWithValue("@username", users.Username)
                command.Parameters.AddWithValue("@function_field", users.Function_field)
                command.Parameters.AddWithValue("@password_field", users.Password_field)
                command.Parameters.AddWithValue("@id", id)
            Else
                command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Users SET username = @username, function_field = @function_field WHERE id = @id;", Manager.connection)
                command.Parameters.AddWithValue("@username", users.Username)
                command.Parameters.AddWithValue("@function_field", users.Function_field)
                command.Parameters.AddWithValue("@id", id)
            End If
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function delete(id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM Users WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la supression : " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
End Class

