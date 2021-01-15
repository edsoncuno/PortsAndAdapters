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
End Class
