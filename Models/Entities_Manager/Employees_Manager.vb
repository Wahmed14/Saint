

Imports Mysqlx.XDevAPI.Relational

Public Class EmployeesManager
    Inherits Manager

    Public Shared Function getById(id As Integer) As Employees
        Dim employee As Employees = Nothing
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Employees WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                employee = New Employees(CInt(row("id")), row("last_name"), row("first_name"), row("phone_number"), row("email"), row("gender"), row("function_field"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return employee
    End Function

    Public Shared Function getAll() As List(Of Employees)
        Dim employeeList As New List(Of Employees)()
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Employees;", Manager.connection)

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                employeeList.Add(New Employees(CInt(row("id")), row("last_name"), row("first_name"), row("phone_number"), row("email"), row("gender"), row("function_field")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return employeeList
    End Function
End Class

