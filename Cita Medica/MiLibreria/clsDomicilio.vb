Public Class clsDomicilio   'clase hija de clsAtencion
    Inherits clsAtencion

    Private m_Direccion As String
    Private m_NecesitaHospitalizar As Boolean

    Sub New(ByVal Diag As String, ByVal Dni As String, ByVal Fecha As Date, ByVal IDAten As String, ByVal Direc As String, ByVal Hospit As Boolean)
        MyBase.New(Diag, Dni, Fecha, IDAten)
        m_Direccion = Direc
        m_NecesitaHospitalizar = Hospit
    End Sub

    Public ReadOnly Property Direccion As String
        Get
            Return m_Direccion
        End Get
    End Property

    Public ReadOnly Property Hospitalizar As Boolean
        Get
            Return m_NecesitaHospitalizar
        End Get
    End Property
End Class
