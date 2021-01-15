Imports Customer_API_VB.NET
Imports Application_VB.NET
Imports Database_API_VB.NET
Public Class frmEmployees
    Private daoEmployees As DataAccessObject = New SqlServerDataAccessEmployees
    Private daoRegion As DataAccessObject = New SqlServerDataAccessRegion
    Private daoTerritories As DataAccessObject = New SqlServerDataAccessTerritories
    Private daoEmployeeTeritories As DataAccessObject = New SqlServerDataAccessEmployeeTerritories
    Private objEmployeesManager As EmployeesManager = New EmployeesManager(daoEmployees, daoRegion, daoTerritories, daoEmployeeTeritories)
    Private objManager As Manager = New WfaManagerEmployees(objEmployeesManager)
    Private dtEmployeesEmployeeTerritories As DataTable
    Public objEmployees As Employees = New Employees
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub
    Private Sub inicializar()
        limpiarFiltro()
        llenarFiltro()
        limpiarEmployees()
        llenarEmployees()
    End Sub
    Private Sub limpiarFiltro()
        cmbFilter.Items.Clear()
        cmbFilter.Text = ""
        txtFilter.Text = ""
        dgvEmployees.DataSource = objManager.mostrarTodos
        dgvEmployeeTerritories = Nothing
    End Sub
    Private Sub llenarFiltro()
        cmbFilter.Items.Add("")
        cmbFilter.Items.Add("EmployeeID")
        cmbFilter.Items.Add("LastName")
        cmbFilter.Items.Add("FirstName")
        cmbFilter.Items.Add("Title")
        cmbFilter.Items.Add("TitleOfCourtesy")
        cmbFilter.Items.Add("Address")
        cmbFilter.Items.Add("City")
        cmbFilter.Items.Add("Region")
        cmbFilter.Items.Add("Country")
        cmbFilter.Items.Add("HomePhone")
    End Sub
    Private Sub limpiarEmployees()
        lblEmployeesEmployeeID.Text = ""
        txtEmployeesLastName.Text = ""
        txtEmployeesFirstName.Text = ""
        txtEmployeesTitle.Text = ""
        txtEmployeesTitleOfCourtesy.Text = ""
        mcEmployeesBirthDate.SetDate(Date.Now)
        mcEmployeesHireDate.SetDate(Date.Now)
        txtEmployeesAddress.Text = ""
        txtEmployeesCity.Text = ""
        txtEmployeesRegion.Text = ""
        txtEmployeesPostalCode.Text = ""
        txtEmployeesCountry.Text = ""
        txtEmployeesHomePhone.Text = ""
        txtEmployeesExtension.Text = ""
        txtEmployeesNotes.Text = ""
        btnEmployeesReportsTo.Text = ""
        txtEmployeesPhotoPath.Text = ""
        dgvEmployeesEmployeeTerritories.DataSource = Nothing
        cmbEmployeesRegion.Items.Clear()
        cmbEmployeesTerritories.Items.Clear()
    End Sub
    Private Sub llenarEmployees()
        llenarComboBoxConDataTable(cmbEmployeesRegion, objManager.mostrarTodosAuxiliar1, "RegionDescription")
        dtEmployeesEmployeeTerritories = New DataTable
        dtEmployeesEmployeeTerritories.Columns.Add("RegionDescription", GetType(String))
        dtEmployeesEmployeeTerritories.Columns.Add("TerritoryDescription", GetType(String))
        dgvEmployeesEmployeeTerritories.DataSource = dtEmployeesEmployeeTerritories
    End Sub
    Private Sub llenarComboBoxConDataTable(cmb As ComboBox, dt As DataTable, column As String)
        cmb.Items.Clear()
        Dim dr As DataRow
        For indexRow = 0 To dt.Rows.Count - 1
            dr = dt.Rows.Item(indexRow)
            cmb.Items.Add(dr(column))
        Next
        cmb.SelectedIndex = 0
    End Sub
    Private Sub cmbEmployeesRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeesRegion.SelectedIndexChanged
        Dim RegionDescription As String = cmbEmployeesRegion.Text
        llenarComboBoxConDataTable(cmbEmployeesTerritories, objManager.mostratTodosAuxiliar2("RegionDescription", RegionDescription), "TerritoryDescription")
        dgvEmployeesEmployeeTerritories.Select()
    End Sub
    Private Sub cmbEmployeesTerritories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeesTerritories.SelectedIndexChanged
        dgvEmployeesEmployeeTerritories.Select()
    End Sub
    Private Sub mostrarEmployees()
        lblEmployeesEmployeeID.Text = objEmployees.EmployeeID
        txtEmployeesLastName.Text = objEmployees.LastName
        txtEmployeesFirstName.Text = objEmployees.FirstName
        txtEmployeesTitle.Text = objEmployees.Title
        txtEmployeesTitleOfCourtesy.Text = objEmployees.TitleOfCourtesy
        mcEmployeesBirthDate.SetDate(convertirStringADateTime(objEmployees.BirthDate))
        mcEmployeesHireDate.SetDate(convertirStringADateTime(objEmployees.HireDate))
        txtEmployeesAddress.Text = objEmployees.Address
        txtEmployeesCity.Text = objEmployees.City
        txtEmployeesRegion.Text = objEmployees.Region
        txtEmployeesPostalCode.Text = objEmployees.PostalCode
        txtEmployeesCountry.Text = objEmployees.Country
        txtEmployeesHomePhone.Text = objEmployees.HomePhone
        txtEmployeesExtension.Text = objEmployees.HomePhone
        txtEmployeesNotes.Text = objEmployees.Notes
        btnEmployeesReportsTo.Text = objEmployees.ReportsTo
        txtEmployeesPhotoPath.Text = objEmployees.PhotoPath
    End Sub
    Private Function convertirStringADateTime(objString As String) As DateTime
        Return Date.ParseExact(objString, "yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
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
    Private Sub dgvEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        If e.RowIndex >= 0 And e.RowIndex < dgvEmployees.Rows.Count - 1 Then
            Dim row As DataGridViewRow
            row = dgvEmployees.Rows(e.RowIndex)
            objEmployees.EmployeeID = row.Cells("EmployeeID").Value.ToString()
            objEmployees = objManager.mostrar(objEmployees.EmployeeID)
            mostrarEmployees()
            dtEmployeesEmployeeTerritories = objManager.mostraTablaAuxliar3("")
            'mostrarEmployeeTerritories()
        End If
    End Sub
    'Private Sub mostrarEmployeeTerritories()
    '    dgvEmployeeTerritories.DataSource = dtEmployeesEmployeeTerritories
    '    dgvEmployeesEmployeeTerritories.DataSource = dtEmployeesEmployeeTerritories
    'End Sub
    Private Sub actualizarDataTableEmployeesEmployeeTerritories()
        dgvEmployeesEmployeeTerritories.DataSource = dtEmployeesEmployeeTerritories
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inicializar()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim existe As Boolean = False
        For index = 0 To dtEmployeesEmployeeTerritories.Rows.Count - 1
            Dim objDataRow As DataRow = dtEmployeesEmployeeTerritories.Rows.Item(index)
            If objDataRow("RegionDescription") = cmbEmployeesRegion.Text And objDataRow("TerritoryDescription") = cmbEmployeesTerritories.Text Then
                existe = True
            End If
        Next
        If existe = False Then
            dtEmployeesEmployeeTerritories.Rows.Add(cmbEmployeesRegion.Text, cmbEmployeesTerritories.Text)
            actualizarDataTableEmployeesEmployeeTerritories()
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For indexRow = 0 To dtEmployeesEmployeeTerritories.Rows.Count - 1
            Dim objDataRow As DataRow = dtEmployeesEmployeeTerritories.Rows.Item(indexRow)
            If objDataRow("RegionDescription") = cmbEmployeesRegion.Text And objDataRow("TerritoryDescription") = cmbEmployeesTerritories.Text Then
                objDataRow.Delete()
            End If
        Next
        actualizarDataTableEmployeesEmployeeTerritories()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvEmployees.DataSource = objManager.mostrarTodosConFiltro(cmbFilter.Text, txtFilter.Text)
    End Sub
End Class
