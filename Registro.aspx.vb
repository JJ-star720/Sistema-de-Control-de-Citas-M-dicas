Imports System.Data.SqlClient

Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtContraseña.Text.Trim()

        Dim usuario As New Admin_usuario() With {
         .Email = txtEmail.Text,
         .Password = txtContraseña.Text
}
        If RegistrarUsuario(usuario) Then
            ScriptManager.RegisterStartupScript(
                Me, Me.GetType(),
                "ServerControlScript",
                "Swal.fire('Usuario Registrado').then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = 'Login.aspx';
                    }
                });",
                True)
        Else
            ScriptManager.RegisterStartupScript(
                Me, Me.GetType(),
                "ServerControlScript",
                "Swal.fire('Error al registrar el usuario. Inténtalo de nuevo.');",
                True)
            lblError.Text = "Error al registrar el usuario. Inténtalo de nuevo."
            lblError.Visible = True
        End If

    End Sub

    Private Function RegistrarUsuario(usuario As Admin_usuario) As Boolean

        Dim helper As New DATAHALPER()
        Dim sql As String = "INSERT INTO Usuarios (Email, Contraseña) VALUES (@Email, @Password)"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@Email", usuario.Email),
            New SqlParameter("@Password", usuario.Password)
        }
        Return helper.ExecuteNonQuery(sql, parameters)


    End Function
End Class