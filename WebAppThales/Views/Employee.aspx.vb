Public Class Employee
    Inherits System.Web.UI.Page
    Dim GetEmployeeClass As New Cl_Employee

    Protected Async Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                Await FillDataGridAllEmployees()
                Await GetDropDownEmployee()
                Await GetEmployeeClass.GetEmployeeDummy()
            Catch ex As Exception
                MensajeError("Unable to bring Dummy API information: " & ex.Message)
            End Try
        End If
    End Sub

    Public Async Function FillDataGridAllEmployees() As Threading.Tasks.Task
        Try
            Dim GetAllEmployee = Await GetEmployeeClass.GetEmployee
            GrwEmployee.DataSource = GetAllEmployee
            GrwEmployee.DataBind()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Function

    Public Async Function FillDataGridEmployeeById() As Threading.Tasks.Task
        Try
            Dim IdEmployeeDropDownList = DdlEmployee.SelectedValue
            Dim GetAllEmployee = Await GetEmployeeClass.GetEmployeById(IdEmployeeDropDownList)
            GrwEmployee.DataSource = GetAllEmployee
            GrwEmployee.DataBind()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Function

    Public Async Function GetDropDownEmployee() As Threading.Tasks.Task
        Try
            Dim GetAllEmployee = Await GetEmployeeClass.GetEmployee


            Dim EmployeeName = From EmployeeModel In GetAllEmployee
                               Select EmployeeModel.NameEmployee,
                               EmployeeModel.IdEmployee

            DdlEmployee.DataSource = EmployeeName
            DdlEmployee.DataValueField = "IdEmployee"
            DdlEmployee.DataTextField = "NameEmployee"
            DdlEmployee.DataBind()
            DdlEmployee.Items.Insert(0, "--Select--")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Protected Async Sub DdlEmployee_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If DdlEmployee.SelectedValue = "--Select--" Then
                Await FillDataGridAllEmployees()
            Else
                Await FillDataGridEmployeeById()
            End If
        Catch ex As Exception
            MensajeError(ex.Message)
        End Try
    End Sub

    Protected Async Sub TxtSearch_TextChanged(sender As Object, e As EventArgs)
        If TxtSearch.Text = String.Empty Then
            Await FillDataGridAllEmployees()
        End If
    End Sub

    Protected Async Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        Try
            If TxtSearch.Text = String.Empty Then
                Await FillDataGridAllEmployees()
                Exit Sub
            Else
                Dim GetAllEmployee = Await GetEmployeeClass.GetEmployeById(TxtSearch.Text)
                GrwEmployee.DataSource = GetAllEmployee
                GrwEmployee.DataBind()
            End If
        Catch ex As Exception
            MensajeError(ex.Message)
        End Try
    End Sub
    Public Function MensajeError(Mensaje As String)
        IdMensajeDanger.Visible = True
        LblMensajePeligro.Text = Mensaje
        Return Mensaje
    End Function
    Public Function MensajeAdvertencia(Mensaje As String)
        IdMensajeWarning.Visible = True
        LblMensajeAviso.Text = Mensaje
        Return Mensaje
    End Function

    'Protected Sub GrwEmployee_RowDataBound(sender As Object, e As GridViewRowEventArgs)
    '    Try
    '        If (e.Row.RowType = DataControlRowType.DataRow) Then
    '            Dim EmployeeImage As Image = (CType(e.Row.FindControl("ImgUser"), Image))
    '            EmployeeImage.ImageUrl = "https://pluspng.com/img-png/png-user-icon-icons-logos-emojis-users-2400.png"
    '        End If
    '    Catch ex As Exception
    '        MensajeError(ex.Message)
    '    End Try
    'End Sub
End Class