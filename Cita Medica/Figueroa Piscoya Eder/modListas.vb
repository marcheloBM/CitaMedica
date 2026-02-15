Imports MiLibreria

'La logica es la sgte:
'Un paciente puede tener muchas citas medicas y no al reves.
'Las listas respectivas (Lista de Pacientes y Lista de Citas) seran guardadas en ArrayList
'En la Lista de Citas Medicas habran citas a domicilio (clsDomicilio) y citas  internas (clsInternas), es decir que realizar en el mismo Hospital
'SI LOGRAN REDUCIR MI CODIGO, el cual es demasiado básico :D, ENTONCES LO HACEN SABER. ;)

Module modListas
    Public LCitas As New ArrayList
    Public LPacientes As New ArrayList
    Public DniNuevo As String 'Usado para mover el valor del txtDNi de frmPaciente al txtDNI de frmCitaMedica
    Public Regresar As Integer '0: significa que viene del frmPrincipal       1:Significa que viene de frmCitaMedica

    Public Function BuscarDNI(ByVal Dni As String) As String
        Dim cad As String
        For Each obj As clsPaciente In LPacientes
            If obj.DNI = Dni Then
                cad = "DNI: " & obj.DNI & vbCrLf _
                    & "Nombres: " & obj.Nombre & vbCrLf _
                    & "Edad: " & obj.Edad & vbCrLf _
                    & "Sexo: " & obj.Sexo
                Return cad
            End If
        Next
        Return Nothing
    End Function

    Public Function IDCita_Existe(ByVal IDCita As String) As Boolean
        For Each obj As clsAtencion In LCitas
            If obj.IDAtencion = IDCita Then
                Return True
            End If
        Next
        Return False
    End Function


    Public Function BuscarCita(ByVal id As String) As String
        Dim cad As String
        Dim auxIn As clsInterna
        Dim auxDo As clsDomicilio
        For Each obj As clsAtencion In LCitas
            If obj.IDAtencion = id Then 'Si el ID existe
                If TypeOf obj Is clsInterna Then    'Si el obj es tipo Interna
                    auxIn = CType(obj, clsInterna)
                    cad = auxIn.Diagnostico & "-" & auxIn.DNIPaciente & "-" & auxIn.Fecha & "-" & auxIn.IDAtencion & "-" & auxIn.NumeroCons & "-" & auxIn.OrdenAt
                Else
                    auxDo = CType(obj, clsDomicilio)
                    cad = auxDo.Diagnostico & "-" & auxDo.DNIPaciente & "-" & auxDo.Fecha & "-" & auxDo.IDAtencion & "-" & auxDo.Direccion & "-" & auxDo.Hospitalizar
                End If
                Return cad
            End If
        Next
        Return Nothing
    End Function

    Public Function IdentificarTipoCita(ByVal id As String) As Integer
        'si el tipo de cita es Interna devolverá 0 de lo contrario devolverá 1
        For Each obj As clsAtencion In LCitas
            If obj.IDAtencion = id Then 'Si el ID existe
                If TypeOf obj Is clsInterna Then    'Si el obj es tipo Interna
                    Return 0
                Else
                    Return 1
                End If
            End If
        Next
        Return -1
    End Function

    Public Function BuscarNombrexDNi(ByVal DNI As String) As String
        Dim cad As String
        For Each obj As clsPaciente In LPacientes
            If obj.DNI = DNI Then
                cad = obj.Nombre
                Return cad
            End If
        Next
        Return Nothing
    End Function
End Module
