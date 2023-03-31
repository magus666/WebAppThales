Public Class EmployeeDummyModel
    Public Class Employee
        Public Property id As Integer
        Public Property employee_name As String
        Public Property employee_salary As Double
        Public Property employee_age As Integer
        Public Property profile_image As String
    End Class

    Public Class Root
        Public Property status As String
        Public Property data As List(Of Employee)
        Public Property message As String
    End Class
End Class
