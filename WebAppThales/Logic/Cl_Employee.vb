Imports Newtonsoft.Json
Imports System.Net
Imports System.Threading.Tasks

Public Class Cl_Employee
    Public Async Function GetEmployee() As Task(Of List(Of EmployeeModel))
        Try
            Dim UrlApi As String = "https://thalesapi.azurewebsites.net/api/Employee/GetlEmployees"
            Dim WebCliente As New WebClient()
            Dim JsonDevuleto As String = Await WebCliente.DownloadStringTaskAsync(New Uri(UrlApi))
            Dim ListaParametrizacion As List(Of EmployeeModel) = JsonConvert.DeserializeObject(Of List(Of EmployeeModel))(JsonDevuleto)
            Return ListaParametrizacion
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Async Function GetEmployeById(IdEmployee As Integer) As Task(Of List(Of EmployeeModel))
        Try
            Dim UrlApi As String = "https://thalesapi.azurewebsites.net/api/Employee/GetlEmployeeById?IdEmployee=" & IdEmployee
            Dim WebCliente As New WebClient()
            Dim JsonDevuleto As String = Await WebCliente.DownloadStringTaskAsync(New Uri(UrlApi))
            Dim ListaParametrizacion As List(Of EmployeeModel) = JsonConvert.DeserializeObject(Of List(Of EmployeeModel))(JsonDevuleto)
            Return ListaParametrizacion
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Async Function GetEmployeeDummy() As Task(Of Object)
        Try
            Dim UrlApi As String = "https://dummy.restapiexample.com/api/v1/employees"
            Dim WebCliente As New WebClient()
            Dim JsonDevuleto As String = Await WebCliente.DownloadStringTaskAsync(New Uri(UrlApi))
            Dim ObjetoDevuelto = JsonConvert.DeserializeObject(Of EmployeeDummyModel.Root)(JsonDevuleto)
            Dim ListaDevuelta = ObjetoDevuelto.data
            Return ListaDevuelta
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
