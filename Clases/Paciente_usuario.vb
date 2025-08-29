Public Class Paciente_usuario
    Public Property ID As Integer
    Public Property EmailPas As String
    Public Property PasswordPas As String

    ' Constructor por defecto
    Public Sub New()
    End Sub

    ' Método para validar el usuario (ejemplo simple)
    Public Function Validar() As Boolean
        Return Not String.IsNullOrEmpty(EmailPas) AndAlso Not String.IsNullOrEmpty(PasswordPas)
    End Function

    ' Método para convertir un DataTable a un objeto Usuario
    Public Function dtToPasUsuario(dataTable As DataTable) As Paciente_usuario
        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            Dim row = dataTable.Rows(0)
            Return New Paciente_usuario() With {
                .ID = Convert.ToInt32(row("ID")),
                .EmailPas = Convert.ToString(row("EmailPas")),
                .PasswordPas = Convert.ToString(row("ContraseñaPas"))
            }
        End If
        Return Nothing
    End Function
End Class
