Public Class Paciente
    ' Atributos privados
    Private Id As Integer
    Private Nombre As String
    Private Apellidos As String
    Private FechaNacimiento As Date
    Private Edad As Integer
    Private Telefono As String
    Private Direccion As String
    Private Correo As String
    Private altura As Double
    Private peso As Double


    Public Sub New()
        ' Constructor vacío
    End Sub

    ' Constructor con parámetros
    Public Sub New(id As Integer, nombre As String, apellidos As String, fechaNacimiento As Date, edad As Integer, telefono As String, direccion As String, correo As String, altura As Double, peso As Double)
        Me.Id1 = id
        Me.Nombre1 = nombre
        Me.Apellidos1 = apellidos
        Me.FechaNacimiento1 = fechaNacimiento
        Me.Edad1 = edad
        Me.Telefono1 = telefono
        Me.Direccion1 = direccion
        Me.Correo1 = correo
        Me.Altura1 = altura
        Me.Peso1 = peso

    End Sub

    Public Property Id1 As Integer
        Get
            Return Id
        End Get
        Set(value As Integer)
            Id = value
        End Set
    End Property

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

    Public Property Altura1 As Double
        Get
            Return altura
        End Get
        Set(value As Double)
            altura = value
        End Set
    End Property

    Public Property Peso1 As Double
        Get
            Return peso
        End Get
        Set(value As Double)
            peso = value
        End Set
    End Property

    Public Property Correo1 As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property
End Class
