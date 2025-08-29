Imports System.Data.SqlClient
Imports System.Web.Configuration
Public Class Respositorio_paciente
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createPaciente(pas As Paciente) As String
        Try
            Dim query As String = "INSERT INTO Tabla_Paciente (Nombre, Apellidos, Edad, Telefono, Direccion, Correo, altura, peso) 
            VALUES (@Nombre, @Apellidos, @Edad, @Telefono, @Direccion, @Correo, @altura, @peso )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", pas.Nombre1),
                New SqlParameter("@Apellidos", pas.Apellidos1),
                New SqlParameter("@Edad", pas.Edad1),
                New SqlParameter("@Telefono", pas.Telefono1),
                New SqlParameter("@Direccion", pas.Direccion1),
                New SqlParameter("@Correo", pas.Correo1),
                New SqlParameter("@altura", pas.Altura1),
                New SqlParameter("@peso", pas.Peso1)
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


    Public Function EliminarPasiente(id As Integer) As String
        Try
            Dim query As String = "DELETE FROM Tabla_Paciente WHERE Id = @iD"
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
            Return "Paciente eliminado exitosamente."
        Catch ex As Exception
            Return "Error al eliminar el Paciente: " & ex.Message
        End Try
    End Function


    Friend Function UpdatePaciente(Iddc As String, pas As Paciente) As String
        Try
            Dim query As String = "UPDATE Tabla_Paciente SET Nombre = @Nombre,
            Apellidos = @Apellidos, Edad = @Edad, Telefono = @Telefono,
            Direccion = @Direccion, Correo = @Correo, altura = @altura, 
            peso = @peso WHERE Id = @iD"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@iD", Iddc),
                New SqlParameter("@Nombre", pas.Nombre1),
                New SqlParameter("@Apellido", pas.Apellidos1),
                New SqlParameter("@Edad", pas.Edad1),
                New SqlParameter("@Telefono", pas.Telefono1),
                New SqlParameter("@Direccion", pas.Direccion1),
                New SqlParameter("@Correo", pas.Correo1),
                New SqlParameter("@alrura", pas.Altura1),
                New SqlParameter("@peso", pas.Peso1)
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
