Imports System.Data.SqlClient
Public Class Respositorio_citas
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createCita(cit As Cita) As String
        Try
            Dim query As String = "INSERT INTO Tabla_Cita (Fecha_Cita, Hora_Cita, Area) 
            VALUES (@Fecha_Cita, @Hora_Cita, @Area )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Fecha_Cita", cit.FechaCita1),
                New SqlParameter("@Hora_Cita", cit.HoraCita1),
                New SqlParameter("@Area", cit.Area1)
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


    Public Function EliminarCita(id As Integer) As String
        Try
            Dim query As String = "DELETE FROM Tabla_Cita WHERE Id = @iD"
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
                        Return "No se encontró al Cita con el ID especificado."
                    End If
                End Using
            End Using
            Return "Cita eliminado exitosamente."
        Catch ex As Exception
            Return "Error al Cita el Paciente: " & ex.Message
        End Try
    End Function


    Friend Function UpdateCita(Iddc As String, cit As Cita) As String
        Try
            Dim query As String = "UPDATE Tabla_Cita SET Fecha_Cita = @Fecha_Cita, Hora_Cita = @Hora_Cita, Area = @area WHERE Id = @iD"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@iD", Iddc),
                New SqlParameter("@Fecha_Cita", cit.FechaCita1),
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
            Return "Datos de la cita actualizados exitosamente."
        Catch ex As Exception
            Return "Error al actualizar Los Datos de la cita: " & ex.Message
        End Try
    End Function


    Public Function createAgenda(cit As Cita) As String
        Try
            Dim query As String = "INSERT INTO Agendas (NombrePas, ApellidosPas, Profecional, Especialidad, Fechacita, Horacita, AreaEs) 
            VALUES (@Nombre, @Apellidos, @Profecional, @Especialidad, @Fecha_Cita, @Hora_Cita, @Area )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", cit.Nombre1),
                New SqlParameter("@Apellidos", cit.Apellidos1),
                New SqlParameter("@Profecional", cit.NombreDc1),
                New SqlParameter("@Especialidad", cit.Especialidad1),
                New SqlParameter("@Fecha_Cita", cit.FechaCita1),
                New SqlParameter("@Hora_Cita", cit.HoraCita1),
                New SqlParameter("@Area", cit.Area1)
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

    Friend Function UpdateAgendas(Iddc As String, cit As Cita) As String
        Try
            Dim query As String = "UPDATE Agendas SET NombrePas = @Nombre, ApellidosPas = @Apellidos, 
            Profecional = @Profecional, Especialidad = @Especialidad, 
            Fechacita = @Fecha_Cita, Horacita = @Hora_Cita, AreaEs = @area WHERE ID = @iD"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@iD", Iddc),
                New SqlParameter("@Nombre", cit.Nombre1),
                New SqlParameter("@Apellidos", cit.Apellidos1),
                New SqlParameter("@Profecional", cit.NombreDc1),
                New SqlParameter("@Especialidad", cit.Especialidad1),
                New SqlParameter("@Fecha_Cita", cit.FechaCita1),
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
            Return "Datos del Cita actualizados exitosamente."
        Catch ex As Exception
            Return "Error al actualizar Los Datos de la cita: " & ex.Message
        End Try
    End Function

    Public Function EliminarAgenda(id As Integer) As String
        Try
            Dim query As String = "DELETE FROM Agendas WHERE ID = @iD"
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
                        Return "No se encontró al cita con el ID especificado."
                    End If
                End Using
            End Using
            Return "Cita se Cancelo con exitosamente."
        Catch ex As Exception
            Return "Error al Cita el Paciente: " & ex.Message
        End Try
    End Function
End Class
