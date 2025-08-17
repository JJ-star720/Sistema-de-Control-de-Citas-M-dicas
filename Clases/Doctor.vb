Public Class Doctor
    Private Nombre As String
    Private Apellidos As String
    Private FechaNacimiento As Date
    Private Edad As Integer
    Private Telefono As String
    Private Direccion As String
    Private Especialidad As String



    Public Sub New()
        ' Constructor vacío
    End Sub


    ' Constructor
    Public Sub New(nombre As String, apellidos As String, fechaNacimiento As Date, edad As Integer, telefono As String, direccion As String, especialidad As String)
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.FechaNacimiento = fechaNacimiento
        Me.Edad = edad
        Me.Telefono = telefono
        Me.Direccion = direccion
        Me.Especialidad = especialidad
    End Sub



    Public Property Nombre1 As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property Apellidos1 As String
        Get
            Return Apellidos
        End Get
        Set(value As String)
            Apellidos = value
        End Set
    End Property

    Public Property FechaNacimiento1 As Date
        Get
            Return FechaNacimiento
        End Get
        Set(value As Date)
            FechaNacimiento = value
        End Set
    End Property

    Public Property Edad1 As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property Especialidad1 As String
        Get
            Return Especialidad
        End Get
        Set(value As String)
            Especialidad = value
        End Set
    End Property
End Class
