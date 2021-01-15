Public Interface Manager
    Function mostrarTodos() As DataTable
    Function mostrar(EmployeeID As String) As Database_API_VB.NET.Employees
    Function mostrarTodosConFiltro(filter As String, value As String) As DataTable
    Function mostrarTodosAuxiliar1() As DataTable
    Function mostratTodosAuxiliar2(filter As String, value As String) As DataTable
    Function mostraTablaAuxliar3(filter As String, value As String) As DataTable
    Function registrar(objEmployees As Object, objDataTable As DataTable) As String
    Function eliminar(objEmployees As Object) As String
End Interface
