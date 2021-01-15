Imports System.Data.SqlClient
Public Class SqlServerDataAccessTerritories
    Implements DataAccessObject
    Dim objSqlConnection As SqlConnection = New SqlConnection(SqlServerConnectionString.connectionString)

    Public Sub delete(ID As String) Implements DataAccessObject.delete
        Throw New NotImplementedException()
    End Sub

    Public Sub insertConDosID(ID1 As String, ID2 As String) Implements DataAccessObject.insertConDosID
        Throw New NotImplementedException()
    End Sub

    Public Function selectAll() As DataTable Implements DataAccessObject.selectAll
        Throw New NotImplementedException()
    End Function

    Public Function selectById(EmployeeID As String) As Object Implements DataAccessObject.selectById
        Throw New NotImplementedException()
    End Function

    Public Function selectAllByFilter(filter As String, value As String) As DataTable Implements DataAccessObject.selectAllByFilter
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Territories where " + filter + " = " + value + "", objSqlConnection)
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

    Public Function selectConDosFiltros(filtro1 As String, valor1 As String, filtro2 As String, valor2 As String) As Object Implements DataAccessObject.selectConDosFiltros
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "select * from Territories where " + filtro1 + " = " + valor1 + " and " + filtro2 + " = " + valor2 + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objTerritories = New Territories
        If (objSqlDataReader.Read()) Then
            objTerritories.TerritoryID = Convert.ToString(objSqlDataReader("TerritoryID"))
            objTerritories.TerritoryDescription = Convert.ToString(objSqlDataReader("TerritoryDescription"))
            objTerritories.RegionID = Convert.ToString(objSqlDataReader("RegionID"))
        Else
            objTerritories.TerritoryID = Nothing
            objTerritories.TerritoryDescription = Nothing
            objTerritories.RegionID = Nothing
        End If
        objSqlConnection.Close()
        Return objTerritories
    End Function
End Class
