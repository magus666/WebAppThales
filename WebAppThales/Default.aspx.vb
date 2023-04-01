Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then

        End If
    End Sub

    Protected Sub BtnOpenApi_Click(sender As Object, e As EventArgs)
        Try
            ScriptManager.RegisterStartupScript(Page, GetType(Page), "OpenWindow", "window.open('https://thalesapi.azurewebsites.net/','_blank');", True)
        Catch ex As Exception

        End Try
    End Sub
End Class