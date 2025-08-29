Imports System.Data.SqlClient
Public Class Respositorio_citas
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createPaciente(cit As Cita) As String
        Try
            Dim query As String = "INSERT INTO Tabla_Paciente (Fecha_cita, Hora_cita, Area) 
            VALUES (@Fecha_cita, @Hora_cita, @Area )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Fecha_cita", cit.FechaCita1),
                New SqlParameter("@Hora_Cita", cit.HoraCita1),
                New SqlParameter("@area", cit.Area1)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Datos de cita registrados con exito."
        Catch ex As Exception
            Return "Error al ingresar a la cita: " & ex.Message
        End Try
    End Function


    Public Function EliminarPasiente(id As Integer) As String
        Try
            Dim query As String = "DELETE FROM Tabla_Citas WHERE Id = @iD"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@iD", id)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return "No se encontró al paciente con el ID especificado."
                    End If
                End Using
            End Using
            Return "Cita eliminado exitosamente."
        Catch ex As Exception
            Return "Error al Cita el Paciente: " & ex.Message
        End Try
    End Function


    Friend Function UpdatePaciente(Iddc As String, cit As Cita) As String
        Try
            Dim query As String = "UPDATE Tabla_Citas SET Fecha_Cita = @Fecha_Cita, Hora_cita = @Hora_Cita, Area = @area WHERE Id = @iD"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@iD", Iddc),
                New SqlParameter("@Fecha_cita", cit.FechaCita1),
                New SqlParameter("@Hora_Cita", cit.HoraCita1),
                New SqlParameter("@area", cit.Area1)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Datos del Paciente actualizados exitosamente."
        Catch ex As Exception
            Return "Error al actualizar Los Datos del Paciente: " & ex.Message
        End Try
    End Function
End Class
