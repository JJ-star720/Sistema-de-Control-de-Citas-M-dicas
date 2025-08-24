Imports System.Data.SqlClient
Public Class Respositorio_paciente
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createCliente(doc As Doctor) As String
        Try
            Dim query As String = "INSERT INTO Tabla_Paciente (NombreDc, ApellidoDc, EdadDc, TelefonoDc, DireccionDc, CorreoDc, Especialidad, Experiencia) 
            VALUES (@NombreDc, @ApellidoDc, @EdadDc, @TelefonoDc, @DireccionDc, @CorreoDc, @Especialidad, @Experiencia )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", doc.NombreDc1),
                New SqlParameter("@Apellido", doc.ApellidosDc1),
                New SqlParameter("@Edad", doc.EdadDc1),
                New SqlParameter("@Telefono", doc.TelefonoDc1),
                New SqlParameter("@Direccion", doc.DireccionDc1),
                New SqlParameter("@Correo", doc.CorreoDc1)
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
End Class
