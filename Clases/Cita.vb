Public Class Cita
    Inherits Paciente

    Private FechaCita As String
    Private HoraCita As String
    Private Area As String

    Public Sub New()
    End Sub

    Public Sub New(fechaCita As String, horaCita As String, area As String)
        Me.FechaCita = fechaCita
        Me.HoraCita = horaCita
        Me.Area = area
    End Sub

    Public Property FechaCita1 As String
        Get
            Return FechaCita
        End Get
        Set(value As String)
            FechaCita = value
        End Set
    End Property

    Public Property HoraCita1 As String
        Get
            Return HoraCita
        End Get
        Set(value As String)
            HoraCita = value
        End Set
    End Property

    Public Property Area1 As String
        Get
            Return Area
        End Get
        Set(value As String)
            Area = value
        End Set
    End Property
End Class
