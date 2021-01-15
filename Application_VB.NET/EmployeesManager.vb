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
    Private Function esValido(objEmployees As Employees) As Boolean
        If objEmployees.LastName = "" Then
            Return False
        End If
        If objEmployees.FirstName = "" Then
            Return False
        End If
        Return True
    End Function
    Private Sub limpiarRegionTerritorios(EmployeeID As String)
        daoEmployeeTerritories.delete(EmployeeID)
    End Sub
    Public Sub agregarTerritorio(EmployeeID As String, RegionDescription As String, TerritoryDescription As String)
        Dim objRegion As Region = daoRegion.selectByFilter("RegionDescription", "'" + RegionDescription + "'")
        Dim objTerritories As Territories = daoTerritories.selectConDosFiltros("RegionID", objRegion.RegionID, "TerritoryDescription", "'" + TerritoryDescription + "'")
        daoEmployeeTerritories.insertConDosID(EmployeeID, "'" + objTerritories.TerritoryID + "'")
    End Sub
    Private Sub actualizarRegionTerritorios(objEmployees As Employees, dtEmpleadoRegionTerritorios As DataTable)
        limpiarRegionTerritorios(objEmployees.EmployeeID)
        For index = 0 To dtEmpleadoRegionTerritorios.Rows.Count - 1
            Dim dr As DataRow = dtEmpleadoRegionTerritorios.Rows.Item(index)
            agregarTerritorio(objEmployees.EmployeeID, dr("RegionDescription").ToString, dr("TerritoryDescription").ToString)
        Next
    End Sub
    Public Function registrarEmpleado(objEmployees As Employees, dtEmpleadoRegionTerritorios As DataTable) As String
        If objEmployees.ReportsTo = "" Then
            objEmployees.ReportsTo = "null"
        End If
        If esValido(objEmployees) = False Then
            Return "Los datos del empeado no son validos"
        End If
        objEmployees.EmployeeID = daoEmployees.insert(objEmployees)
        actualizarRegionTerritorios(objEmployees, dtEmpleadoRegionTerritorios)
        Return "Empleado registrado"
    End Function
    Private Function existe(objEmployees As Employees) As Boolean
        objEmployees = daoEmployees.selectById(objEmployees.EmployeeID)
        If objEmployees.EmployeeID = Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function eliminarEmpleado(objEmployees As Employees) As String
        If existe(objEmployees) = False Then
            Return "El empleado al que desea eliminar no existe"
        End If
        limpiarRegionTerritorios(objEmployees.EmployeeID)
        Try
            daoEmployees.delete(objEmployees.EmployeeID)
            Return "Empleado eliminado"
        Catch ex As Exception
            Return "No se puedo eliminar al Empleado por que tiene Ordenes asociados"
        End Try
    End Function
End Class
