Public Class clsAtencion        'clase padre, de esta ehredaran clsInterna y clsDomicilio
    Private m_Diagnostico As String
    Private m_DNIPaciente As String
    Private m_FechaAtencion As Date
    Private m_IDAtencion As String

    Sub New(ByVal Diag As String, ByVal Dni As String, ByVal Fecha As Date, ByVal IDAten As String)
        m_Diagnostico = Diag
        m_DNIPaciente = Dni
        m_FechaAtencion = Fecha
        m_IDAtencion = IDAten
    End Sub

    Public ReadOnly Property DNIPaciente As String
        Get
            Return m_DNIPaciente
        End Get
    End Property

    Public ReadOnly Property IDAtencion As String
        Get
            Return m_IDAtencion
        End Get
    End Property

    Public ReadOnly Property Diagnostico As String
        Get
            Return m_Diagnostico
        End Get
    End Property

    Public ReadOnly Property Fecha As Date
        Get
            Return m_FechaAtencion
        End Get
    End Property
End Class
