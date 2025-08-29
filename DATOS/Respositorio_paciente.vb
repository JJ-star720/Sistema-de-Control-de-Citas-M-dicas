Imports System.Data.SqlClient
Imports System.Web.Configuration
Public Class Respositorio_paciente
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createPaciente(pas As Paciente) As String
        Try
            Dim query As String = "INSERT INTO Tabla_Paciente (Nombre, Apellido, Edad, Telefono, Direccion, Correo, altura, peso) 
            VALUES (@Nombre, @Apellido, @Edad, @Telefono, @Direccion, @Correo, @altura, @peso )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", pas.Nombre1),
                New SqlParameter("@Apellido", pas.Apellidos1),
                New SqlParameter("@Edad", pas.Edad1),
                New SqlParameter("@Telefono", pas.Telefono1),
                New SqlParameter("@Direccion", pas.Direccion1),
                New SqlParameter("@Correo", pas.Correo1),
                New SqlParameter("@altura", pas.Altura1)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Datos del paciente registrados con exito."
        Catch ex As Exception
            Return "Error al ingresar a el pasiente: " & ex.Message
        End Try
    End Function


    Public Function EliminarDoc(id As Integer) As String
        Try
            Dim query As String = "DELETE FROM Tabla_Doctor WHERE ID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return "No se encontró al Doctor con el ID especificado."
                    End If
                End Using
            End Using
            Return "Doctor eliminado exitosamente."
        Catch ex As Exception
            Return "Error al eliminar el Doctor: " & ex.Message
        End Try
    End Function


    Friend Function UpdateDoc(Iddc As String, doc As Doctor) As String
        Try
            Dim query As String = "UPDATE Tabla_Doctor SET NombreDc = @NombreDc1,
            ApellidoDc = @ApellidosDc1, EdadDc = @EdadDc1, TelefonoDc = @TelefonoDc1,
            DireccionDc = @DireccionDc1, CorreoDc = @Correo, Especialidad = @Especialidad, 
            Experiencia = @Experiencia WHERE ID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", Iddc),
                New SqlParameter("@NombreDc1", doc.NombreDc1),
                New SqlParameter("@ApellidosDc1", doc.ApellidosDc1),
                New SqlParameter("@EdadDc1", doc.EdadDc1),
                New SqlParameter("@TelefonoDc1", doc.TelefonoDc1),
                New SqlParameter("@DireccionDc1", doc.DireccionDc1),
                New SqlParameter("@CorreoDc1", doc.CorreoDc1),
                New SqlParameter("@Especialidad", doc.Especialidad1),
                New SqlParameter("@Experiencia", doc.Experiencia1)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Datos de doctor actualizados exitosamente."
        Catch ex As Exception
            Return "Error al actualizar Los Datos del doctor: " & ex.Message
        End Try
    End Function
End Class
