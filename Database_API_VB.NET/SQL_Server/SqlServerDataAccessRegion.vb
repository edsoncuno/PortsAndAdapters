Imports System.Data.SqlClient
Public Class SqlServerDataAccessRegion
    Implements DataAccessObject
    Dim objSqlConnection As SqlConnection = New SqlConnection(SqlServerConnectionString.connectionString)

    Public Function selectAll() As DataTable Implements DataAccessObject.selectAll
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Region", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objDatatable As DataTable = New DataTable()
        objDatatable.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return objDatatable
    End Function

    Public Function selectById(EmployeeID As String) As Object Implements DataAccessObject.selectById
        Throw New NotImplementedException()
    End Function
    Function selectAllByFilter(filter As String, value As String) As DataTable Implements DataAccessObject.selectAllByFilter
        Throw New NotImplementedException()
    End Function

    Public Function selectByFilter(filter As String, value As String) As Object Implements DataAccessObject.selectByFilter
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Region where " + filter + " = " + value + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objRegion = New Region
        If (objSqlDataReader.Read()) Then
            objRegion.RegionID = Convert.ToString(objSqlDataReader("RegionID"))
            objRegion.RegionDescription = Convert.ToString(objSqlDataReader("RegionDescription"))
        Else
            objRegion.RegionID = Nothing
            objRegion.RegionDescription = Nothing
        End If
        objSqlConnection.Close()
        Return objRegion
    End Function
End Class
