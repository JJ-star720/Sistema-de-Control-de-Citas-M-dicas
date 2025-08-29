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


    Protected Sub GvPaciente_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index = GvPasiente.SelectedIndex
        Dim IdPas As Integer = Convert.ToInt32(GvPasiente.SelectedDataKey.Value)

        If index >= 0 Then
            Dim row = GvPasiente.Rows(index)
            IDPass.Value = IdPas.ToString()
            Dim pass As New Paciente With {
                .Nombre1 = row.Cells(2).Text,
                .Apellidos1 = row.Cells(3).Text,
                .Edad1 = row.Cells(4).Text,
                .Telefono1 = row.Cells(5).Text,
                .Direccion1 = row.Cells(6).Text,
                .Correo1 = row.Cells(7).Text,
                .Altura1 = row.Cells(8).Text,
                .Peso1 = row.Cells(9).Text
            }


            ' Asignar los valores de las celdas a los controles del formulario
            TxtNombre.Text = pass.Nombre1

            If row.Cells(3).Text.IsNullOrWhiteSpace Then
                TxtApellidos.Text = ""
            Else
                TxtApellidos.Text = pass.Apellidos1
                TxtCorreo.Text = pass.Correo1
                TxtDireccion.Text = pass.Direccion1
            End If

            TxtTelefono.Text = pass.Telefono1

        End If
    End Sub

    Protected Sub GvPaciente_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id As Integer = Convert.ToInt32(GvPasiente.DataKeys(e.RowIndex).Value)
        Dim resultado As String = dbPASS.EliminarPasiente(id)
        ' Mostrar el mensaje de resultado en la etiqueta LblMensaje
        LblMensaje.Text = resultado
        e.Cancel = True
        GvPasiente.DataBind()
    End Sub
End Class