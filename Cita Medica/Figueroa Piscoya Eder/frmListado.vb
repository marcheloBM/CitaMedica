Imports MiLibreria
Public Class frmListado

    Private Sub rbInterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInterna.CheckedChanged
        lvInterna.Visible = True
        lvDomicilio.Visible = False
        lvInterna.Items.Clear()
        For Each obj As clsAtencion In LCitas
            If TypeOf obj Is clsInterna Then
                Dim aux As clsInterna 'alamacenara el OBJ convertido a clsInterna
                Dim Fila As New ListViewItem
                aux = CType(obj, clsInterna)
                Fila.SubItems.Item(0).Text = aux.IDAtencion
                Fila.SubItems.Add(BuscarNombrexDNi(aux.DNIPaciente))
                Fila.SubItems.Add(aux.Diagnostico)
                Fila.SubItems.Add(CStr(aux.Fecha))
                Fila.SubItems.Add(CStr(aux.NumeroCons))
                Fila.SubItems.Add(aux.OrdenAt)
                lvInterna.Items.Add(Fila)
            End If
        Next
    End Sub

    Private Sub rbDomicilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDomicilio.CheckedChanged
        lvInterna.Visible = False
        lvDomicilio.Visible = True
        lvDomicilio.Items.Clear()
        For Each obj As clsAtencion In LCitas
            If TypeOf obj Is clsDomicilio Then
                Dim aux As clsDomicilio 'alamacenara el OBJ convertido a clsInterna
                Dim Fila As New ListViewItem
                aux = CType(obj, clsDomicilio)
                Fila.SubItems.Item(0).Text = aux.IDAtencion
                Fila.SubItems.Add(BuscarNombrexDNi(aux.DNIPaciente))
                Fila.SubItems.Add(aux.Diagnostico)
                Fila.SubItems.Add(CStr(aux.Fecha))
                Fila.SubItems.Add(aux.Direccion)
                If aux.Hospitalizar = True Then
                    Fila.SubItems.Add("Si")
                Else
                    Fila.SubItems.Add("No")
                End If
                lvDomicilio.Items.Add(Fila)
            End If
        Next
    End Sub
End Class