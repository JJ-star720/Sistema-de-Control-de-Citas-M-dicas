Imports Microsoft.Ajax.Utilities
Public Class Gestion_Citas
    Inherits System.Web.UI.Page
    Protected dbCIT As New Respositorio_citas()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)
        TxtFechaCita.Text = ""
        TxtHora_Cita.Text = ""
        TxtArea.Text = ""
    End Sub



    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If IDCit.Value.IsNullOrWhiteSpace Then
            If String.IsNullOrWhiteSpace(TxtFechaCita.Text) Then
                LblMensaje.Text = "debe poner una fecha para la cita es obligatorio"
            Else
                Dim Cit As New Cita() With {
                    .FechaCita1 = TxtFechaCita.Text,
                    .HoraCita1 = TxtHora_Cita.Text,
                    .Area1 = TxtArea.Text
                }
                dbCIT.createCita(Cit)
                LblMensaje.Text = ""
                GvCita.DataBind()
            End If
        Else

            Dim newCIt As New Cita() With {
                .FechaCita1 = TxtFechaCita.Text,
                    .HoraCita1 = TxtHora_Cita.Text,
                    .Area1 = TxtArea.Text
            }
            Dim resultado As String = dbCIT.UpdateCita(IDCit.Value, newCIt)
            LblMensaje.Text = resultado
            IDCit.Value = ""
            GvCita.DataBind()

        End If
    End Sub

    Protected Sub GvCita_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index = GvCita.SelectedIndex
        Dim Idci As Integer = Convert.ToInt32(GvCita.SelectedDataKey.Value)

        If index >= 0 Then
            Dim row = GvCita.Rows(index)
            IDCit.Value = Idci.ToString()
            Dim cits As New Cita With {
                .FechaCita1 = row.Cells(2).Text,
                .HoraCita1 = row.Cells(3).Text,
                .Area1 = row.Cells(4).Text
            }

            ' Asignar los valores de las celdas a los controles del formulario
            TxtFechaCita.Text = cits.FechaCita1


            TxtHora_Cita.Text = cits.HoraCita1
            TxtArea.Text = cits.Area1




        End If
    End Sub

    Protected Sub GvCita_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id As Integer = Convert.ToInt32(GvCita.DataKeys(e.RowIndex).Value)
        Dim resultado As String = dbCIT.EliminarCita(id)
        ' Mostrar el mensaje de resultado en la etiqueta LblMensaje
        LblMensaje.Text = resultado
        e.Cancel = True
        GvCita.DataBind()
    End Sub

    Protected Sub Back_Click(sender As Object, e As EventArgs)
        Response.Redirect("Admin_acceso.aspx")
    End Sub
End Class