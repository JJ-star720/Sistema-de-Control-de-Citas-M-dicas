Imports Microsoft.Ajax.Utilities
Public Class Pag_Pacientes
    Inherits System.Web.UI.Page
    Protected dbCIT As New Respositorio_citas()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
            TxtApellidos.Text = pass.Apellidos1



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
            TxtAreaEs.Text = cits.Area1




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
            TxtProfecional.Text = Doctors.NombreDc1
            TxtEspecialidad.Text = Doctors.Especialidad1




        End If
    End Sub

    Protected Sub GvAgenda_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index = GvAgenda.SelectedIndex
        Dim IdDocs As Integer = Convert.ToInt32(GvAgenda.SelectedDataKey.Value)

        If index >= 0 Then
            Dim row = GvAgenda.Rows(index)
            IDAgenda.Value = IdDocs.ToString()
            Dim agend As New Cita With {
                .Nombre1 = row.Cells(2).Text,
                .Apellidos1 = row.Cells(3).Text,
                .NombreDc1 = row.Cells(4).Text,
                .Especialidad1 = row.Cells(5).Text,
                .FechaCita1 = row.Cells(6).Text,
                .HoraCita1 = row.Cells(7).Text,
                .Area1 = row.Cells(8).Text
            }


            ' Asignar los valores de las celdas a los controles del formulario
            TxtNombre.Text = agend.Nombre1
            TxtApellidos.Text = agend.Apellidos1
            TxtProfecional.Text = agend.NombreDc1
            TxtEspecialidad.Text = agend.Especialidad1
            TxtFechaCita.Text = agend.FechaCita1
            TxtHora_Cita.Text = agend.HoraCita1
            TxtAreaEs.Text = agend.Area1




        End If
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If IDAgenda.Value.IsNullOrWhiteSpace Then
            If String.IsNullOrWhiteSpace(TxtFechaCita.Text) Then
                LblMensaje.Text = "debe poner una fecha para la cita es obligatorio"
            Else
                Dim Cit As New Cita() With {
                    .Nombre1 = TxtNombre.Text,
                    .Apellidos1 = TxtNombre.Text,
                    .NombreDc1 = TxtProfecional.Text,
                    .Especialidad1 = TxtEspecialidad.Text,
                    .FechaCita1 = TxtFechaCita.Text,
                    .HoraCita1 = TxtHora_Cita.Text,
                    .Area1 = TxtAreaEs.Text
                }
                dbCIT.createAgenda(Cit)
                LblMensaje.Text = dbCIT.createAgenda(Cit)
                GvAgenda.DataBind()
            End If
        Else

            Dim newCIt As New Cita() With {
                .Nombre1 = TxtNombre.Text,
                    .Apellidos1 = TxtNombre.Text,
                    .NombreDc1 = TxtProfecional.Text,
                    .Especialidad1 = TxtEspecialidad.Text,
                .FechaCita1 = TxtFechaCita.Text,
                    .HoraCita1 = TxtHora_Cita.Text,
                    .Area1 = TxtAreaEs.Text
            }
            Dim resultado As String = dbCIT.UpdateAgendas(IDAgenda.Value, newCIt)
            LblMensaje.Text = resultado
            IDAgenda.Value = ""
            GvAgenda.DataBind()

        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs)
        TxtNombre.Text = ""
        TxtApellidos.Text = ""
        TxtProfecional.Text = ""
        TxtEspecialidad.Text = ""
        TxtFechaCita.Text = ""
        TxtHora_Cita.Text = ""
        TxtAreaEs.Text = ""
    End Sub
End Class