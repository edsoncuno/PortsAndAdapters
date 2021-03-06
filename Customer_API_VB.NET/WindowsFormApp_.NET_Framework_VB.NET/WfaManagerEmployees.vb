﻿Imports Application_VB.NET
Imports Database_API_VB.NET

Public Class WfaManagerEmployees
    Implements Manager
    Private objEmployeesManager As EmployeesManager
    Public Sub New(_EmployeesManager As EmployeesManager)
        objEmployeesManager = _EmployeesManager
    End Sub
    Public Function mostrarTodos() As DataTable Implements Manager.mostrarTodos
        Return objEmployeesManager.mostrarTodoEmployees
    End Function
    Public Function mostrar(EmployeeID As String) As Employees Implements Manager.mostrar
        Return objEmployeesManager.mostrarEmployees(EmployeeID)
    End Function
    Function mostrarTodosConFiltro(filter As String, value As String) As DataTable Implements Manager.mostrarTodosConFiltro
        Return objEmployeesManager.mostarTodoEmployeesConFiltro(filter, value)
    End Function
    Function mostrarTodosAuxiliar1() As DataTable Implements Manager.mostrarTodosAuxiliar1
        Return objEmployeesManager.mostrarTodoRegion
    End Function
    Function mostratTodosAuxiliar2(filter As String, value As String) As DataTable Implements Manager.mostratTodosAuxiliar2
        Return objEmployeesManager.mostrarTerritoriosDeLaRegionPorRegionDescription(filter, value)
    End Function
    Function mostraTablaAuxliar3(filter As String, value As String) As DataTable Implements Manager.mostraTablaAuxliar3
        Return objEmployeesManager.mostrarEmployeeTerritoriosPorEmployeeID(filter, value)
    End Function

    Public Function registrar(objEmployees As Object, objDataTable As DataTable) As String Implements Manager.registrar
        Return objEmployeesManager.registrarEmpleado(objEmployees, objDataTable)
    End Function

    Public Function eliminar(objEmployees As Object) As String Implements Manager.eliminar
        Return objEmployeesManager.eliminarEmpleado(objEmployees)
    End Function

    Public Function update(objEmployees As Object, objDataTable As DataTable) As String Implements Manager.update
        Return objEmployeesManager.actualizarEmpleado(objEmployees, objDataTable)
    End Function
End Class
