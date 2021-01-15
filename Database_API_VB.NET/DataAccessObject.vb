Public Interface DataAccessObject
    Function selectAll() As DataTable
    Function selectById(ID As String) As Object
    Function selectAllByFilter(filter As String, value As String) As DataTable
    Function selectByFilter(filter As String, value As String) As Object
    Function selectLast() As String
    Function insert(objEmployees As Employees) As String
    Sub delete(ID As String)
    Sub insertConDosID(ID1 As String, ID2 As String)
    Function selectConDosFiltros(filtro1 As String, valor1 As String, filtro2 As String, valor2 As String) As Object
End Interface
