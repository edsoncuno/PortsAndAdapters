Imports Database_API_VB.NET
Public Class EmployeesManager
    Private daoEmployees As DataAccessObject
    Private daoRegion As DataAccessObject
    Private daoTerritories As DataAccessObject
    Private daoEmployeeTerritories As DataAccessObject
    Public Sub New(_daoEmployees As DataAccessObject, _daoRegion As DataAccessObject, _daoTerritories As DataAccessObject, _daoEmployeeTerritories As DataAccessObject)
        daoEmployees = _daoEmployees
        daoRegion = _daoRegion
        daoTerritories = _daoTerritories
        daoEmployeeTerritories = _daoEmployeeTerritories
    End Sub
    Public Function mostrarTodoEmployees() As DataTable
        Return daoEmployees.selectAll()
    End Function
    Public Function mostrarEmployees(EmployeeID As String) As Employees
        Return daoEmployees.selectById(EmployeeID)
    End Function
    Public Function mostarTodoEmployeesConFiltro(filter As String, value As String) As DataTable
        If filter = "" Then
            Return daoEmployees.selectAll()
        Else
            If filter = "EmployeeID" Or filter = "ReportsTo" Then
                Return daoEmployees.selectAllByFilter(filter, value)
            Else
                Return daoEmployees.selectAllByFilter(filter, "'" + value + "'")
            End If
        End If
    End Function
    Public Function mostrarTodoRegion()
        Return daoRegion.selectAll()
    End Function
    Public Function mostrarTerritoriosDeLaRegionPorRegionDescription(filter As String, value As String) As DataTable
        Dim objRegion = daoRegion.selectByFilter(filter, "'" + value + "'")
        Return daoTerritories.selectAllByFilter("RegionID", objRegion.RegionID)
    End Function
    Public Function mostrarEmployeeTerritoriosPorEmployeeID(filter As String, value As String) As DataTable
        Return daoEmployeeTerritories.selectAllByFilter(filter, value)
    End Function
End Class
