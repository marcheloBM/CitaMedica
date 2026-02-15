Public Class clsPaciente    'clase independiente de clsAtencion, clsInterna o clsDomicilio
    Private m_DNI As String
    Private m_Edad As Integer
    Private m_Nombres As String
    Private m_Sexo As String

    Sub New(ByVal Dni As String, ByVal Edad As Integer, ByVal Nomb As String, ByVal Sexo As String)
        m_DNI = Dni
        m_Edad = Edad
        m_Nombres = Nomb
        m_Sexo = Sexo
    End Sub

    Public ReadOnly Property DNI As String
        Get
            Return m_DNI
        End Get
    End Property

    Public ReadOnly Property Edad As Integer
        Get
            Return m_Edad
        End Get
    End Property

    Public ReadOnly Property Nombre As String
        Get
            Return m_Nombres
        End Get
    End Property

    Public ReadOnly Property Sexo As String
        Get
            Return m_Sexo
        End Get
    End Property
End Class
