<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvEmployeeTerritories = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmployeesEmployeeID = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.dgvEmployeesEmployeeTerritories = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbEmployeesTerritories = New System.Windows.Forms.ComboBox()
        Me.cmbEmployeesRegion = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.mcEmployeesHireDate = New System.Windows.Forms.MonthCalendar()
        Me.mcEmployeesBirthDate = New System.Windows.Forms.MonthCalendar()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEmployeesPhotoPath = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnEmployeesReportsTo = New System.Windows.Forms.Button()
        Me.txtEmployeesNotes = New System.Windows.Forms.TextBox()
        Me.txtEmployeesExtension = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmployeesHomePhone = New System.Windows.Forms.TextBox()
        Me.txtEmployeesCountry = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEmployeesPostalCode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmployeesRegion = New System.Windows.Forms.TextBox()
        Me.txtEmployeesCity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmployeesAddress = New System.Windows.Forms.TextBox()
        Me.txtEmployeesTitleOfCourtesy = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmployeesTitle = New System.Windows.Forms.TextBox()
        Me.txtEmployeesFirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmployeesLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmployeeTerritories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmployeesEmployeeTerritories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(15, 46)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(227, 162)
        Me.dgvEmployees.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filters:"
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(55, 6)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilter.TabIndex = 2
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(182, 6)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtFilter.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(288, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvEmployeeTerritories
        '
        Me.dgvEmployeeTerritories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeTerritories.Location = New System.Drawing.Point(248, 46)
        Me.dgvEmployeeTerritories.Name = "dgvEmployeeTerritories"
        Me.dgvEmployeeTerritories.Size = New System.Drawing.Size(227, 162)
        Me.dgvEmployeeTerritories.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employees:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Region Territories:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EmployeeID:"
        '
        'lblEmployeesEmployeeID
        '
        Me.lblEmployeesEmployeeID.AutoSize = True
        Me.lblEmployeesEmployeeID.Location = New System.Drawing.Point(116, 211)
        Me.lblEmployeesEmployeeID.Name = "lblEmployeesEmployeeID"
        Me.lblEmployeesEmployeeID.Size = New System.Drawing.Size(16, 13)
        Me.lblEmployeesEmployeeID.TabIndex = 189
        Me.lblEmployeesEmployeeID.Text = "..."
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(621, 534)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 188
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(520, 591)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 187
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(520, 564)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 186
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(520, 534)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 185
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'dgvEmployeesEmployeeTerritories
        '
        Me.dgvEmployeesEmployeeTerritories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeesEmployeeTerritories.Location = New System.Drawing.Point(248, 451)
        Me.dgvEmployeesEmployeeTerritories.Name = "dgvEmployeesEmployeeTerritories"
        Me.dgvEmployeesEmployeeTerritories.Size = New System.Drawing.Size(227, 162)
        Me.dgvEmployeesEmployeeTerritories.TabIndex = 149
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(69, 563)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 23)
        Me.btnRemove.TabIndex = 148
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(69, 534)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 23)
        Me.btnAdd.TabIndex = 147
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(66, 491)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 146
        Me.Label23.Text = "Territorio:"
        '
        'cmbEmployeesTerritories
        '
        Me.cmbEmployeesTerritories.FormattingEnabled = True
        Me.cmbEmployeesTerritories.Location = New System.Drawing.Point(69, 507)
        Me.cmbEmployeesTerritories.Name = "cmbEmployeesTerritories"
        Me.cmbEmployeesTerritories.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmployeesTerritories.TabIndex = 145
        '
        'cmbEmployeesRegion
        '
        Me.cmbEmployeesRegion.FormattingEnabled = True
        Me.cmbEmployeesRegion.Location = New System.Drawing.Point(69, 467)
        Me.cmbEmployeesRegion.Name = "cmbEmployeesRegion"
        Me.cmbEmployeesRegion.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmployeesRegion.TabIndex = 144
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(66, 451)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Region:"
        '
        'mcEmployeesHireDate
        '
        Me.mcEmployeesHireDate.Location = New System.Drawing.Point(487, 239)
        Me.mcEmployeesHireDate.Name = "mcEmployeesHireDate"
        Me.mcEmployeesHireDate.TabIndex = 142
        '
        'mcEmployeesBirthDate
        '
        Me.mcEmployeesBirthDate.Location = New System.Drawing.Point(487, 46)
        Me.mcEmployeesBirthDate.Name = "mcEmployeesBirthDate"
        Me.mcEmployeesBirthDate.TabIndex = 141
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(488, 217)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 140
        Me.Label21.Text = "HireDate:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(486, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 139
        Me.Label20.Text = "BirthDate:"
        '
        'txtEmployeesPhotoPath
        '
        Me.txtEmployeesPhotoPath.Location = New System.Drawing.Point(333, 396)
        Me.txtEmployeesPhotoPath.Name = "txtEmployeesPhotoPath"
        Me.txtEmployeesPhotoPath.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesPhotoPath.TabIndex = 138
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(267, 399)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 137
        Me.Label18.Text = "PhotoPath:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(267, 373)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "ReportsTo:"
        '
        'btnEmployeesReportsTo
        '
        Me.btnEmployeesReportsTo.Location = New System.Drawing.Point(333, 370)
        Me.btnEmployeesReportsTo.Name = "btnEmployeesReportsTo"
        Me.btnEmployeesReportsTo.Size = New System.Drawing.Size(101, 20)
        Me.btnEmployeesReportsTo.TabIndex = 135
        Me.btnEmployeesReportsTo.UseVisualStyleBackColor = True
        '
        'txtEmployeesNotes
        '
        Me.txtEmployeesNotes.Location = New System.Drawing.Point(334, 344)
        Me.txtEmployeesNotes.Name = "txtEmployeesNotes"
        Me.txtEmployeesNotes.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesNotes.TabIndex = 134
        '
        'txtEmployeesExtension
        '
        Me.txtEmployeesExtension.Location = New System.Drawing.Point(334, 318)
        Me.txtEmployeesExtension.Name = "txtEmployeesExtension"
        Me.txtEmployeesExtension.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesExtension.TabIndex = 133
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 347)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "Notes:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(272, 321)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Extension:"
        '
        'txtEmployeesHomePhone
        '
        Me.txtEmployeesHomePhone.Location = New System.Drawing.Point(334, 292)
        Me.txtEmployeesHomePhone.Name = "txtEmployeesHomePhone"
        Me.txtEmployeesHomePhone.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesHomePhone.TabIndex = 130
        '
        'txtEmployeesCountry
        '
        Me.txtEmployeesCountry.Location = New System.Drawing.Point(334, 266)
        Me.txtEmployeesCountry.Name = "txtEmployeesCountry"
        Me.txtEmployeesCountry.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesCountry.TabIndex = 129
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(259, 295)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "HomePhone:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(282, 269)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Country:"
        '
        'txtEmployeesPostalCode
        '
        Me.txtEmployeesPostalCode.Location = New System.Drawing.Point(334, 240)
        Me.txtEmployeesPostalCode.Name = "txtEmployeesPostalCode"
        Me.txtEmployeesPostalCode.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesPostalCode.TabIndex = 126
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(264, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "PostalCode:"
        '
        'txtEmployeesRegion
        '
        Me.txtEmployeesRegion.Location = New System.Drawing.Point(334, 214)
        Me.txtEmployeesRegion.Name = "txtEmployeesRegion"
        Me.txtEmployeesRegion.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesRegion.TabIndex = 124
        '
        'txtEmployeesCity
        '
        Me.txtEmployeesCity.Location = New System.Drawing.Point(116, 364)
        Me.txtEmployeesCity.Name = "txtEmployeesCity"
        Me.txtEmployeesCity.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesCity.TabIndex = 123
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Region:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "City:"
        '
        'txtEmployeesAddress
        '
        Me.txtEmployeesAddress.Location = New System.Drawing.Point(116, 338)
        Me.txtEmployeesAddress.Name = "txtEmployeesAddress"
        Me.txtEmployeesAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesAddress.TabIndex = 120
        '
        'txtEmployeesTitleOfCourtesy
        '
        Me.txtEmployeesTitleOfCourtesy.Location = New System.Drawing.Point(116, 312)
        Me.txtEmployeesTitleOfCourtesy.Name = "txtEmployeesTitleOfCourtesy"
        Me.txtEmployeesTitleOfCourtesy.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesTitleOfCourtesy.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Address:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "TitleOfCourtesy:"
        '
        'txtEmployeesTitle
        '
        Me.txtEmployeesTitle.Location = New System.Drawing.Point(116, 286)
        Me.txtEmployeesTitle.Name = "txtEmployeesTitle"
        Me.txtEmployeesTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesTitle.TabIndex = 116
        '
        'txtEmployeesFirstName
        '
        Me.txtEmployeesFirstName.Location = New System.Drawing.Point(116, 260)
        Me.txtEmployeesFirstName.Name = "txtEmployeesFirstName"
        Me.txtEmployeesFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesFirstName.TabIndex = 115
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "FirstName:"
        '
        'txtEmployeesLastName
        '
        Me.txtEmployeesLastName.Location = New System.Drawing.Point(116, 234)
        Me.txtEmployeesLastName.Name = "txtEmployeesLastName"
        Me.txtEmployeesLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeesLastName.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "LastName:"
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 647)
        Me.Controls.Add(Me.lblEmployeesEmployeeID)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgvEmployeesEmployeeTerritories)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbEmployeesTerritories)
        Me.Controls.Add(Me.cmbEmployeesRegion)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.mcEmployeesHireDate)
        Me.Controls.Add(Me.mcEmployeesBirthDate)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtEmployeesPhotoPath)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnEmployeesReportsTo)
        Me.Controls.Add(Me.txtEmployeesNotes)
        Me.Controls.Add(Me.txtEmployeesExtension)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEmployeesHomePhone)
        Me.Controls.Add(Me.txtEmployeesCountry)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtEmployeesPostalCode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtEmployeesRegion)
        Me.Controls.Add(Me.txtEmployeesCity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmployeesAddress)
        Me.Controls.Add(Me.txtEmployeesTitleOfCourtesy)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmployeesTitle)
        Me.Controls.Add(Me.txtEmployeesFirstName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmployeesLastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvEmployeeTerritories)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "frmEmployees"
        Me.Text = "Employees"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmployeeTerritories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmployeesEmployeeTerritories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvEmployeeTerritories As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEmployeesEmployeeID As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents dgvEmployeesEmployeeTerritories As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents cmbEmployeesTerritories As ComboBox
    Friend WithEvents cmbEmployeesRegion As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents mcEmployeesHireDate As MonthCalendar
    Friend WithEvents mcEmployeesBirthDate As MonthCalendar
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEmployeesPhotoPath As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Public WithEvents btnEmployeesReportsTo As Button
    Friend WithEvents txtEmployeesNotes As TextBox
    Friend WithEvents txtEmployeesExtension As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmployeesHomePhone As TextBox
    Friend WithEvents txtEmployeesCountry As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEmployeesPostalCode As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmployeesRegion As TextBox
    Friend WithEvents txtEmployeesCity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmployeesAddress As TextBox
    Friend WithEvents txtEmployeesTitleOfCourtesy As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmployeesTitle As TextBox
    Friend WithEvents txtEmployeesFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmployeesLastName As TextBox
    Friend WithEvents Label5 As Label
End Class
