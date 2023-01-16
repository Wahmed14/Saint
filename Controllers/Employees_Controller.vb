Imports Mysqlx.XDevAPI.Relational
Public Class Employees_Controller
    Public Shared Function getAll() As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Nom", GetType(String))
        table.Columns.Add("Prénoms", GetType(String))
        table.Columns.Add("Téléphone", GetType(String))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("Genre", GetType(String))
        table.Columns.Add("Fonction", GetType(String))


        For Each employees As Employees In EmployeesManager.getAll()
            table.LoadDataRow(New Object() {employees.Id, employees.Last_name, employees.First__name, employees.Phone_number, employees.Email, employees.Gender, employees.Function_field}, True)
        Next
        Return table
    End Function
End Class


