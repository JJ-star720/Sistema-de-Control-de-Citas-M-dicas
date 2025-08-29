Imports System.Web.UI.WebControls.Expressions
Imports Microsoft.Ajax.Utilities
Public Class Gestion_Pasientes
    Inherits System.Web.UI.Page
    Protected dbPASS As New Respositorio_paciente()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If IDPass.Value.IsNullOrWhiteSpace Then
            If TxtNombre.Text = "" Then
                LblMensaje.Text = "EL campo NOMBRE son obligatorio"
            Else
                Dim pass As New Paciente() With {
                    .Nombre1 = TxtNombre.Text,
                    .Apellidos1 = TxtApellidos.Text,
                    .Edad1 = Conversion.Val(TxtEdad.Text),
                    .Telefono1 = Conversion.Val(TxtTelefono.Text),
                    .Direccion1 = TxtDireccion.Text,
                    .Correo1 = TxtCorreo.Text,
                    .Altura1 = Conversion.Val(Txtaltura.Text),
                    .Peso1 = Conversion.Val(Txtpeso.Text)
                }
                dbPASS.createPaciente(pass)
                LblMensaje.Text = dbPASS.createPaciente(pass)
                GvPasiente.DataBind()
            End If
        Else

            Dim newPas As New Paciente() With {
                .Nombre1 = TxtNombre.Text,
                .Apellidos1 = TxtApellidos.Text,
                .Edad1 = Conversion.Val(TxtEdad.Text),
                .Telefono1 = Conversion.Val(TxtTelefono.Text),
                .Direccion1 = TxtDireccion.Text,
                .Correo1 = TxtCorreo.Text,
                .Altura1 = Conversion.Val(Txtaltura.Text),
                .Peso1 = Conversion.Val(Txtpeso.Text)
            }
            Dim resultado As String = dbPASS.UpdatePaciente(IDPass.Value, newPas)
            LblMensaje.Text = resultado
            IDPass.Value = ""
            GvPasiente.DataBind()

        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)
        TxtNombre.Text = ""
        TxtApellidos.Text = ""
        TxtEdad.Text = ""
        TxtTelefono.Text = ""
        TxtDireccion.Text = ""
        TxtCorreo.Text = ""
        Txtaltura.Text = ""
        Txtpeso.Text = ""
    End Sub
End Class