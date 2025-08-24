Public Class Admin_acceso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnDoc_Click(sender As Object, e As EventArgs)
        Response.Redirect(".aspx")
    End Sub

    Protected Sub BtnCit_Click(sender As Object, e As EventArgs)
        Response.Redirect(".aspx")
    End Sub

    Protected Sub BtnPas_Click(sender As Object, e As EventArgs)
        Response.Redirect("Gestion_Pasientes.aspx")
    End Sub

    Protected Sub BynBack_Click(sender As Object, e As EventArgs)
        Response.Redirect("Pagina_inicio.aspx")
    End Sub
End Class