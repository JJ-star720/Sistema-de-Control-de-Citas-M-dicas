Public Class Paciente
    Private Nombre As String
    Private Apellidos As String
    Private FechaNacimiento As Date
    Private Edad As Integer
    Private Telefono As String
    Private Direccion As String
    Private altura As Double
    Private peso As Double
    Private alergias As String


    Public Sub New()
        ' Constructor vacío
    End Sub
    ' Constructor
    Public Sub New(nombre As String, apellidos As String, fechaNacimiento As Date, edad As Integer, telefono As String, direccion As String, altura As Double, peso As Double, alergias As String)
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.FechaNacimiento = fechaNacimiento
        Me.Edad = edad
        Me.Telefono = telefono
        Me.Direccion = direccion
        Me.altura = altura
        Me.peso = peso
        Me.alergias = alergias
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

    Public Property Alergias1 As String
        Get
            Return alergias
        End Get
        Set(value As String)
            alergias = value
        End Set
    End Property
End Class
