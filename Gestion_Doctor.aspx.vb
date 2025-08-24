Imports System.Web.UI.WebControls.Expressions
Imports Microsoft.Ajax.Utilities
Public Class Gestion_Doctor
    Inherits System.Web.UI.Page
    Protected dbDOCTS As New Respositorio_Doc()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If IDDocts.Value.IsNullOrWhiteSpace Then
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
                dbDOCTS.createCliente(Doc)
                LblMensaje.Text = "Cliente creado correctamente"
                GvDoctor.DataBind()
            End If
        Else

            Dim newDoc As New Doctor() With {
                .NombreDc1 = TxtNombreDc.Text,
                .ApellidosDc1 = TxtApellidosDc.Text,
                .EdadDc1 = Conversion.Val(TxtEdadDc.Text),
                .TelefonoDc1 = TxtTelefonoDc.Text,
                .DireccionDc1 = TxtDireccionDc.Text,
                .CorreoDc1 = TxtCorreoDc.Text,
                .Especialidad1 = TxtEspecialidad.Text,
                .Experiencia1 = Conversion.Val(TxtExperiencia.Text)
            }
            Dim resultado As String = dbDOCTS.UpdateClientes(IDDocts.Value, newDoc)
            LblMensaje.Text = resultado
            IDDocts.Value = ""
            GvDoctor.DataBind()

        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)
        TxtNombreDc.Text = ""
        TxtApellidosDc.Text = ""
        TxtEdadDc.Text = ""
        TxtTelefonoDc.Text = ""
        TxtDireccionDc.Text = ""
        TxtCorreoDc.Text = ""
        TxtEspecialidad.Text = ""
        TxtExperiencia.Text = ""
    End Sub
End Class