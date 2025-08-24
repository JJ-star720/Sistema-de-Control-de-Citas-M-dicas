Public Class Gestion_Doctor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If IDClients.Value.IsNullOrWhiteSpace Then
            If TxtNombreDc.Text = "" Then
                LblMensaje.Text = "EL campo NOMBRE son obligatorio"
            Else
                Dim Doc As New Doctor() With {
                    .NombreDc1 = TxtNombreDc.Text,
                    .ApellidosDc1 = TxtApellidosDc.Text,
                    .EdadDc1 = Conversion.Val(TxtEdadDc.Text),
                    .TelefonoDc1 = TxtTelefonoDc.Text,
                    .DireccionDc1 = TxtDireccionDc.Text,
                    .CorreoDc1 = TxtCorreoDc.Text,
                    .Especialidad1 = TxtEspecialidad.Text,
                    .Experiencia1 = Conversion.Val(TxtExperiencia.Text)
                }
                dbClientrepo.createCliente(person)
                LblMensaje.Text = "Cliente creado correctamente"
                GvClientes.DataBind()
            End If
        Else

            Dim newcliente As New Cliente() With {
                .Nombre = TxtNombre.Text,
                .Apellido = Txtapellido.Text,
                .Edad = Convert.ToInt32(Txtedad.Text),
                .Direccion = Txtdireccion.Text,
                .Telefono = Convert.ToInt32(Txttelefono.Text),
                .Correo = Txtcorreo.Text
            }
            Dim resultado As String = dbClientrepo.UpdateClientes(IDClients.Value, newcliente)
            LblMensaje.Text = resultado
            IDClients.Value = ""
            GvClientes.DataBind()

        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)

    End Sub
End Class