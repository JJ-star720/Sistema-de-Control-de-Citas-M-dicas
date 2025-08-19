Public Class Admin_usuario
    Public Property Id As Integer
    Public Property Email As String
    Public Property Password As String

    ' Constructor por defecto
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(id As Integer, email As String, password As String)
        Me.Id = id
        Me.Email = email
        Me.Password = password
    End Sub

    ' Método para validar el usuario (ejemplo simple)
    Public Function Validar() As Boolean
        Return Not String.IsNullOrEmpty(Email) AndAlso Not String.IsNullOrEmpty(Password)
    End Function

    ' Método para convertir un DataTable a un objeto Usuario
    Public Function dtToUsuario(dataTable As DataTable) As Admin_usuario
        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            Dim row = dataTable.Rows(0)
            Return New Admin_usuario() With {
                .Id = Convert.ToInt32(row("ID")),
                .Email = Convert.ToString(row("Email")),
                .Password = Convert.ToString(row("Contraseña"))
            }
        End If
        Return Nothing
    End Function
End Class
