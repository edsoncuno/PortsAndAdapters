Public Interface DataAccessObject
    Function selectAll() As DataTable
    Function selectById(EmployeeID As String) As Object
    Function selectAllByFilter(filter As String, value As String) As DataTable
    Function selectByFilter(filter As String, value As String) As Object
End Interface
