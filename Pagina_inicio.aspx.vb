Imports System.Data.SqlClient
Imports Microsoft.Ajax.Utilities

Public Class Pagina_inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Function VerificarADMIN(admin As Admin_usuario) As Boolean
        Try
            Dim helper As New DATAHALPER()
            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@Email", admin.Email),
            New SqlParameter("@Password", admin.Password)
        }
            ' Ejecutar la consulta para verificar el usuario
            Dim query As String = "SELECT * FROM USUARIO WHERE EMAIL = @Email AND CONTRASEÑA = @Password"
            Dim dataTable As DataTable = helper.ExecuteQuery(query, parametros)


            ' Verificar si se encontró el usuario
            If dataTable.Rows.Count > 0 Then
                ' Usuario encontrado, puedes redirigir o realizar otra acción
                admin = admin.dtToUsuario(dataTable)
                Session.Add("UsuarioId", admin.Id.ToString())
                Session.Add("UsuarioEmail", admin.Email.ToString())
                Return True
            Else
                ' Usuario no encontrado, manejar el error
                Return False

            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Protected Function Verificarpaciente(Pas As Paciente_usuario) As Boolean
        Try
            Dim helper As New DATAHALPER()
            Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@Email", Pas.Email),
            New SqlParameter("@Password", Pas.Password)
        }
            ' Ejecutar la consulta para verificar al paciente
            Dim query As String = "SELECT * FROM Tabla_Pasientes_Clinica WHERE EMAIL = @Email AND Contraseña = @Password"
            Dim dataTable As DataTable = helper.ExecuteQuery(query, parametros)


            ' Verificar si se encontró al paciente
            If dataTable.Rows.Count > 0 Then
                ' Paciente encontrado, puedes redirigir o realizar otra acción
                Pas = Pas.dtToPasUsuario(dataTable)
                Session.Add("UsuarioId", Pas.Id.ToString())
                Session.Add("UsuarioEmail", Pas.Email.ToString())
                Return True
            Else
                ' Paciente no encontrado, manejar el error
                Return False

            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Protected Sub btnLogin_Click1(sender As Object, e As EventArgs)
        Dim admin As New Admin_usuario() With {
            .Email = txtEmail.Text,
            .Password = txtContraseña.Text
        }

        Dim Pas As New Paciente_usuario() With {
            .Email = txtEmail.Text,
            .Password = txtContraseña.Text
        }

        ' Validar el usuario
        If admin.Validar And VerificarADMIN(admin) Then
            Response.Redirect("Admin_acceso")
        ElseIf Pas.validar And Verificarpaciente(Pas) Then
            Response.Redirect("Pag_Pacientes")
        Else

            lblError.Text = "Correo electrónico o contraseña inválidos."
            lblError.Visible = True
        End If
    End Sub

End Class