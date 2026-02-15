Public Class clsInterna     'clase hija de clsAtencion
    Inherits clsAtencion

    Private m_NumConsultorio As Integer
    Private m_OrdenAtencion As String

    Sub New(ByVal Diag As String, ByVal Dni As String, ByVal Fecha As Date, ByVal IDAten As String, ByVal Num As Integer, ByVal Orden As String)
        MyBase.New(Diag, Dni, Fecha, IDAten)
        m_NumConsultorio = Num
        m_OrdenAtencion = Orden
    End Sub

    Public ReadOnly Property NumeroCons As Integer
        Get
            Return m_NumConsultorio
        End Get
    End Property

    Public ReadOnly Property OrdenAt As String
        Get
            Return m_OrdenAtencion
        End Get
    End Property
End Class
