Imports System.Data.SqlClient
Public Class SqlServerDataAccessEmployees
    Implements DataAccessObject
    Dim objSqlConnection As SqlConnection = New SqlConnection(SqlServerConnectionString.connectionString)
    Public Function selectAll() As DataTable Implements DataAccessObject.selectAll
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objDataTable As DataTable = New DataTable()
        objDataTable.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return objDataTable
    End Function

    Public Function selectById(EmployeeID As String) As Object Implements DataAccessObject.selectById
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees where EmployeeID = " + EmployeeID + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objEmployees = New Employees
        If (objSqlDataReader.Read()) Then
            objEmployees.EmployeeID = Convert.ToString(objSqlDataReader("EmployeeID"))
            objEmployees.LastName = Convert.ToString(objSqlDataReader("LastName"))
            objEmployees.FirstName = Convert.ToString(objSqlDataReader("FirstName"))
            objEmployees.Title = Convert.ToString(objSqlDataReader("Title"))
            objEmployees.TitleOfCourtesy = Convert.ToString(objSqlDataReader("TitleOfCourtesy"))
            Try
                objEmployees.BirthDate = convertirDateTimeAString(Convert.ToDateTime(objSqlDataReader("BirthDate")))
            Catch ex As Exception
                objEmployees.BirthDate = Nothing
            End Try
            Try
                objEmployees.HireDate = convertirDateTimeAString(Convert.ToDateTime(objSqlDataReader("HireDate")))
            Catch ex As Exception
                objEmployees.HireDate = Nothing
            End Try
            objEmployees.Address = Convert.ToString(objSqlDataReader("Address"))
            objEmployees.City = Convert.ToString(objSqlDataReader("City"))
            objEmployees.Region = Convert.ToString(objSqlDataReader("Region"))
            objEmployees.City = Convert.ToString(objSqlDataReader("City"))
            objEmployees.PostalCode = Convert.ToString(objSqlDataReader("PostalCode"))
            objEmployees.Country = Convert.ToString(objSqlDataReader("Country"))
            objEmployees.HomePhone = Convert.ToString(objSqlDataReader("HomePhone"))
            objEmployees.Extension = Convert.ToString(objSqlDataReader("Extension"))
            objEmployees.Notes = Convert.ToString(objSqlDataReader("Notes"))
            objEmployees.ReportsTo = Convert.ToString(objSqlDataReader("ReportsTo"))
            objEmployees.PhotoPath = Convert.ToString(objSqlDataReader("PhotoPath"))
        Else
            objEmployees.EmployeeID = Nothing
        End If
        objSqlConnection.Close()
        Return objEmployees
    End Function
    Public Function selectAllByFilter(filter As String, value As String) As DataTable Implements DataAccessObject.selectAllByFilter
        Dim objSqlCommand As SqlCommand = New SqlCommand("select * from Employees where " + filter + " = " + value + "", objSqlConnection)
        objSqlConnection.Open()
        Dim objSqlDataReader As SqlDataReader = objSqlCommand.ExecuteReader()
        Dim objDataTable As DataTable = New DataTable()
        objDataTable.Load(objSqlDataReader)
        objSqlConnection.Close()
        Return objDataTable
    End Function
    Function selectByFilter(filter As String, value As String) As Object Implements DataAccessObject.selectByFilter
        Throw New NotImplementedException()
    End Function

    Public Function selectLast() As String Implements DataAccessObject.selectLast
        Dim objSqlCommand As SqlCommand = New SqlCommand("select MAX(EmployeeID) as EmployeeID from Employees", objSqlConnection)
        Dim objString As String = ""
        objSqlConnection.Open()
        objString = Convert.ToString(objSqlCommand.ExecuteScalar())
        objSqlConnection.Close()
        Return objString
    End Function

    Public Function insert(objEmployees As Employees) As String Implements DataAccessObject.insert
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "insert into Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension," +
        "Notes,ReportsTo,PhotoPath) values (" +
        "'" + objEmployees.LastName + "'" +
        ",'" + objEmployees.FirstName + "'" +
        ",'" + objEmployees.Title + "'" +
        ",'" + objEmployees.TitleOfCourtesy + "'" +
        "," + agregarInstruccionesAFecha(objEmployees.BirthDate) + "" +
        "," + agregarInstruccionesAFecha(objEmployees.HireDate) + "" +
        ",'" + objEmployees.Address + "'" +
        ",'" + objEmployees.City + "'" +
        ",'" + objEmployees.Region + "'" +
        ",'" + objEmployees.PostalCode + "'" +
        ",'" + objEmployees.Country + "'" +
        ",'" + objEmployees.HomePhone + "'" +
        ",'" + objEmployees.Extension + "'" +
        ",'" + objEmployees.Notes + "'" +
        "," + objEmployees.ReportsTo + "" +
        ",'" + objEmployees.PhotoPath + "')", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
        Return selectLast()
    End Function

    Private Function convertirDateTimeAString(objDateTime As DateTime) As String
        Return objDateTime.Year.ToString + "-" + agregarUnCeroAlNumeroMenorADiez(objDateTime.Month.ToString) + "-" + agregarUnCeroAlNumeroMenorADiez(objDateTime.Day.ToString)
    End Function
    Private Function agregarUnCeroAlNumeroMenorADiez(numero As String) As String
        If numero.Length = 1 Then
            numero = "0" + numero
        End If
        Return numero
    End Function
    Public Function agregarInstruccionesAFecha(objString As String) As String
        Dim resultado As String = "convert(datetime,'"
        resultado = resultado + objString
        resultado = resultado + "',20)"
        Return resultado
    End Function

    Public Sub delete(ID As String) Implements DataAccessObject.delete
        Dim objSqlCommand As SqlCommand = New SqlCommand(
        "delete from Employees where EmployeeID = " + ID + "", objSqlConnection)
        objSqlConnection.Open()
        objSqlCommand.ExecuteNonQuery()
        objSqlConnection.Close()
    End Sub

    Public Sub insertConDosID(ID1 As String, ID2 As String) Implements DataAccessObject.insertConDosID
        Throw New NotImplementedException()
    End Sub

    Public Function selectConDosFiltros(filtro1 As String, valor1 As String, filtro2 As String, valor2 As String) As Object Implements DataAccessObject.selectConDosFiltros
        Throw New NotImplementedException()
    End Function
End Class
