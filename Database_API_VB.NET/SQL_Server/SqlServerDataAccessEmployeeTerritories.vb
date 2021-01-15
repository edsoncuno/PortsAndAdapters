Imports System.Data.SqlClient
Public Class SqlServerDataAccessEmployeeTerritories
    Implements DataAccessObject
    Dim objSqlConnection As SqlConnection = New SqlConnection(SqlServerConnectionString.connectionString)
    Public Function selectAll() As DataTable Implements DataAccessObject.selectAll
        Throw New NotImplementedException()
    End Function

    Public Function selectById(EmployeeID As String) As Object Implements DataAccessObject.selectById
        Throw New NotImplementedException()
    End Function

    Public Function selectAllByFilter(filter As String, value As String) As DataTable Implements DataAccessObject.selectAllByFilter
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "select Region.RegionDescription, Territories.TerritoryDescription " +
        "from EmployeeTerritories " +
        "inner join Territories on " +
        "Territories.TerritoryID = EmployeeTerritories.TerritoryID " +
        "inner join Region on " +
        "Territories.RegionID = Region.RegionID " +
        "where " + filter + " = " + value + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objDataTable As DataTable = New DataTable()
        objDataTable.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return objDataTable
    End Function

    Public Function selectByFilter(filter As String, value As String) As Object Implements DataAccessObject.selectByFilter
        Throw New NotImplementedException()
    End Function

    Public Function selectLast() As String Implements DataAccessObject.selectLast
        Throw New NotImplementedException()
    End Function

    Public Function insert(objEmployees As Employees) As String Implements DataAccessObject.insert
        Throw New NotImplementedException()
    End Function

    Public Sub delete(EmployeeID As String) Implements DataAccessObject.delete
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "delete from EmployeeTerritories where EmployeeID = " + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub

    Public Sub insertConDosID(ID1 As String, ID2 As String) Implements DataAccessObject.insertConDosID
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "insert into EmployeeTerritories (EmployeeID, TerritoryID) values (" + ID1 + "," + ID2 + ")", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub

    Public Function selectConDosFiltros(filtro1 As String, valor1 As String, filtro2 As String, valor2 As String) As Object Implements DataAccessObject.selectConDosFiltros
        Throw New NotImplementedException()
    End Function
End Class
