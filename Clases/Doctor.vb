Public Class Doctor
    ' Atributos privados
    Private IdDc As Integer
    Private NombreDc As String
    Private ApellidosDc As String
    Private EdadDc As Integer
    Private TelefonoDc As String
    Private DireccionDc As String
    Private CorreoDc As String
    Private Especialidad As String
    Private Experiencia As Integer



    Public Sub New()
        ' Constructor vacío
    End Sub

    ' Constructor con parámetros
    Public Sub New(idDc As Integer, nombreDc As String, apellidosDc As String, edadDc As Integer, telefonoDc As String, direccionDc As String, correoDc As String, especialidad As String, experiencia As Integer)
        Me.IdDc1 = idDc
        Me.NombreDc1 = nombreDc
        Me.ApellidosDc1 = apellidosDc
        Me.EdadDc1 = edadDc
        Me.TelefonoDc1 = telefonoDc
        Me.DireccionDc1 = direccionDc
        Me.CorreoDc1 = correoDc
        Me.Especialidad1 = especialidad
        Me.Experiencia1 = experiencia
    End Sub

    Public Property IdDc1 As Integer
        Get
            Return IdDc
        End Get
        Set(value As Integer)
            IdDc = value
        End Set
    End Property

    Public Property NombreDc1 As String
        Get
            Return NombreDc
        End Get
        Set(value As String)
            NombreDc = value
        End Set
    End Property

    Public Property ApellidosDc1 As String
        Get
            Return ApellidosDc
        End Get
        Set(value As String)
            ApellidosDc = value
        End Set
    End Property

    Public Property EdadDc1 As Integer
        Get
            Return EdadDc
        End Get
        Set(value As Integer)
            EdadDc = value
        End Set
    End Property

    Public Property TelefonoDc1 As String
        Get
            Return TelefonoDc
        End Get
        Set(value As String)
            TelefonoDc = value
        End Set
    End Property

    Public Property DireccionDc1 As String
        Get
            Return DireccionDc
        End Get
        Set(value As String)
            DireccionDc = value
        End Set
    End Property

    Public Property CorreoDc1 As String
        Get
            Return CorreoDc
        End Get
        Set(value As String)
            CorreoDc = value
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

    Public Property Experiencia1 As Integer
        Get
            Return Experiencia
        End Get
        Set(value As Integer)
            Experiencia = value
        End Set
    End Property



End Class
