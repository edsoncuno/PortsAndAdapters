Imports System.Data.SqlClient
Public Class SqlServerDataAccessEmployees
    Implements DataAccessObject
    Dim objSqlConnection As SqlConnection = New SqlConnection(SqlServerConnectionString.connectionString)
    Public Function selectAll() As DataTable Implements DataAccessObject.selectAll
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objDataTable As DataTable = New DataTable()
        objDataTable.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return objDataTable
    End Function

    Public Function selectById(EmployeeID As String) As Object Implements DataAccessObject.selectById
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees where EmployeeID = " + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objEmployees = New Employees
        If (objSqlDataReader.Read()) Then
            objEmployees.EmployeeID = Convert.ToString(objSqlDataReader("EmployeeID"))
            objEmployees.LastName = Convert.ToString(objSqlDataReader("LastName"))
            objEmployees.FirstName = Convert.ToString(objSqlDataReader("FirstName"))
            objEmployees.Title = Convert.ToString(objSqlDataReader("Title"))
            objEmployees.TitleOfCourtesy = Convert.ToString(objSqlDataReader("TitleOfCourtesy"))
            Try
                objEmployees.BirthDate = convertirDateTimeAString(Convert.ToDateTime(objSqlDataReader("BirthDate")))
            Catch ex As Exception
                objEmployees.BirthDate = Nothing
            End Try
            Try
                objEmployees.HireDate = convertirDateTimeAString(Convert.ToDateTime(objSqlDataReader("HireDate")))
            Catch ex As Exception
                objEmployees.HireDate = Nothing
            End Try
            objEmployees.Address = Convert.ToString(objSqlDataReader("Address"))
            objEmployees.City = Convert.ToString(objSqlDataReader("City"))
            objEmployees.Region = Convert.ToString(objSqlDataReader("Region"))
            objEmployees.City = Convert.ToString(objSqlDataReader("City"))
            objEmployees.PostalCode = Convert.ToString(objSqlDataReader("PostalCode"))
            objEmployees.Country = Convert.ToString(objSqlDataReader("Country"))
            objEmployees.HomePhone = Convert.ToString(objSqlDataReader("HomePhone"))
            objEmployees.Extension = Convert.ToString(objSqlDataReader("Extension"))
            objEmployees.Notes = Convert.ToString(objSqlDataReader("Notes"))
            objEmployees.ReportsTo = Convert.ToString(objSqlDataReader("ReportsTo"))
            objEmployees.PhotoPath = Convert.ToString(objSqlDataReader("PhotoPath"))
        Else
            objEmployees.EmployeeID = Nothing
        End If
        objSqlConnection.Close()
        Return objEmployees
    End Function
    Public Function selectAllByFilter(filter As String, value As String) As DataTable Implements DataAccessObject.selectAllByFilter
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees where " + filter + " = " + value + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objDataTable As DataTable = New DataTable()
        objDataTable.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return objDataTable
    End Function
    Function selectByFilter(filter As String, value As String) As Object Implements DataAccessObject.selectByFilter
        Throw New NotImplementedException()
    End Function
    Private Function convertirDateTimeAString(objDateTime As DateTime) As String
        Return objDateTime.Year.ToString + "-" + agregarUnCeroAlNumeroMenorADiez(objDateTime.Month.ToString) + "-" + agregarUnCeroAlNumeroMenorADiez(objDateTime.Day.ToString)
    End Function
    Private Function agregarUnCeroAlNumeroMenorADiez(numero As String) As String
        If numero.Length = 1 Then
            numero = "0" + numero
        End If
        Return numero
    End Function
End Class
