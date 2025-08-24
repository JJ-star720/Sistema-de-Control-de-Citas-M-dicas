Imports System.Data.SqlClient
Public Class Respositorio_Doc
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createCliente(doc As Doctor) As String
        Try
            Dim query As String = "INSERT INTO Tabla_Doctor (NombreDc, ApellidoDc, EdadDc, TelefonoDc, DireccionDc, CorreoDc, Especialidad, Experiencia) 
            VALUES (@NombreDc, @ApellidoDc, @EdadDc, @TelefonoDc, @DireccionDc, @CorreoDc, @Especialidad, @Experiencia )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@NombreDc", doc.NombreDc1),
                New SqlParameter("@ApellidoDc", doc.ApellidosDc1),
                New SqlParameter("@EdadDc", doc.EdadDc1),
                New SqlParameter("@TelefonoDc", doc.TelefonoDc1),
                New SqlParameter("@DireccionDc", doc.DireccionDc1),
                New SqlParameter("@CorreoDc", doc.CorreoDc1),
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
            Return "Datos del doctor registrados con exito."
        Catch ex As Exception
            Return "Error al ingresar a el Doctor: " & ex.Message
        End Try
    End Function


    Public Function EliminarCliente(id As Integer) As String
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


    Friend Function UpdateClientes(Iddc As String, doc As Doctor) As String
        Try
            Dim query As String = "UPDATE Tabla_Doctor SET NombreDc = @NombreDc,
            ApellidoDc = @ApellidoDc, EdadDc = @EdadDc, TelefonoDc = @TelefonoDc,
            DireccionDc = @DireccionDc, CorreoDc = @Correo WHERE ClienteID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", Iddc),
                New SqlParameter("@NombreDc", doc.NombreDc1),
                New SqlParameter("@ApellidoDc", doc.ApellidosDc1),
                New SqlParameter("@EdadDc", doc.EdadDc1),
                New SqlParameter("@TelefonoDc", doc.TelefonoDc1),
                New SqlParameter("@DireccionDc", doc.DireccionDc1),
                New SqlParameter("@CorreoDc", doc.CorreoDc1),
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
