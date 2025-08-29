Imports Microsoft.Ajax.Utilities
Public Class Pag_Pacientes
    Inherits System.Web.UI.Page

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
End Class