Imports System.Windows.Input

Public Class ECUEs_Manager
    Inherits Manager
    Private Shared Function getECUEsGenerique() As ECUEs
        Dim ECUEs As ECUEs = New ECUEs(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                ECUEs = New ECUEs(CInt(row("id")), row("libelle"), row("credit"), row("employee_id"))
            Next
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ECUEs
    End Function
    Public Shared Function getById(id As Integer) As ECUEs
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getECUEsGenerique()
    End Function

    Public Shared Function getByLibelle(libelle As String) As ECUEs
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getECUEsGenerique()
    End Function

    Public Shared Function getByCredit(Credit As Integer) As ECUEs
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE credit = @credit;", Manager.connection)
        command.Parameters.AddWithValue("@credit", Credit)
        Return getECUEsGenerique()
    End Function

    Public Shared Function getByEmployee_id(Employee_id As Integer) As ECUEs
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE employee_id = @employee_id;", Manager.connection)
        command.Parameters.AddWithValue("@employee_id", Employee_id)
        Return getECUEsGenerique()
    End Function

    Public Shared Function getECUEGenerique() As List(Of ECUEs)
        Dim ECUEsList As New List(Of ECUEs)()
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs;", Manager.connection)

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                ECUEsList.Add(New ECUEs(CInt(row("id")), row("libelle"), row("credit"), row("employee_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ECUEsList
    End Function

    Public Shared Function getAll() As List(Of ECUEs)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs;", Manager.connection)
        Return getECUEGenerique()
    End Function

    Public Shared Function search(word As String) As List(Of ECUEs)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE libelle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getECUEGenerique()
    End Function

    Public Shared Function store(ECUEs As ECUEs) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO ECUEs(libelle, credit, employee_id) VALUES(@libelle, @credit, @employee_id);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ECUEs.Libelle)
            command.Parameters.AddWithValue("@credit", ECUEs.Credit)
            command.Parameters.AddWithValue("@employee_id", ECUEs.Employee_id)

            If (command.ExecuteNonQuery = 0) Then
                Return False
            Else
                Return True
            End If
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Shared Function update(ECUEs As ECUEs, id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE ECUEs(libelle, credit, employee_id) SET libelle = @libelle, credit = @credit, employee_id= @employee_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ECUEs.Libelle)
            command.Parameters.AddWithValue("@sigle", ECUEs.Credit)
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@employee_id", ECUEs.Employee_id)
            If (command.ExecuteNonQuery = 0) Then
                Return False
            Else
                Return True
            End If
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Shared Function delete(id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM ECUEs WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)
            If (command.ExecuteNonQuery = 0) Then
                Return False
            Else
                Return True
            End If
            disposeManager()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function
End Class
