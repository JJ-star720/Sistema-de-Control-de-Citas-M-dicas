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
                dbDOCTS.createDoc(Doc)
                LblMensaje.Text = ""
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
            Dim resultado As String = dbDOCTS.UpdateDoc(IDDocts.Value, newDoc)
            LblMensaje.Text = resultado
            IDDocts.Value = ""
            GvDoctor.DataBind()

        End If
    End Sub

    Protected Sub GvDoctor_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index = GvDoctor.SelectedIndex
        Dim IdDocs As Integer = Convert.ToInt32(GvDoctor.SelectedDataKey.Value)

        If index >= 0 Then
            Dim row = GvDoctor.Rows(index)
            IDDocts.Value = IdDocs.ToString()
            Dim Doctors As New Doctor With {
                .NombreDc1 = row.Cells(2).Text,
                .ApellidosDc1 = row.Cells(3).Text,
                .EdadDc1 = row.Cells(4).Text,
                .TelefonoDc1 = row.Cells(5).Text,
                .DireccionDc1 = row.Cells(6).Text,
                .CorreoDc1 = row.Cells(7).Text,
                .Especialidad1 = row.Cells(8).Text,
                .Experiencia1 = row.Cells(9).Text
            }


            ' Asignar los valores de las celdas a los controles del formulario
            TxtNombreDc.Text = Doctors.NombreDc1
            TxtApellidosDc.Text = Doctors.ApellidosDc1
            TxtEdadDc.Text = Doctors.EdadDc1
            TxtTelefonoDc.Text = Doctors.TelefonoDc1
            TxtDireccionDc.Text = Doctors.DireccionDc1
            TxtCorreoDc.Text = Doctors.CorreoDc1
            TxtEspecialidad.Text = Doctors.Especialidad1
            TxtExperiencia.Text = Doctors.Experiencia1




        End If
    End Sub

    Protected Sub GvDoctor_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id As Integer = Convert.ToInt32(GvDoctor.DataKeys(e.RowIndex).Value)
        Dim resultado As String = dbDOCTS.EliminarDoc(id)
        ' Mostrar el mensaje de resultado en la etiqueta LblMensaje
        LblMensaje.Text = resultado
        e.Cancel = True
        GvDoctor.DataBind()
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

    Protected Sub Back_Click(sender As Object, e As EventArgs)
        Response.Redirect("Admin_acceso.aspx")
    End Sub
End Class