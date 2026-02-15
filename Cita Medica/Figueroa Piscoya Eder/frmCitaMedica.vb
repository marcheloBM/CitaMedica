Imports MiLibreria
Public Class frmCitaMedica

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim Existe As String
        Existe = BuscarDNI(txtDNI.Text)
        If Existe <> Nothing Then

            txtDNI.Enabled = False
            btnBuscar.Enabled = False

            gbAtencion.Enabled = True
            gbGenerales.Enabled = True
            gbInterna.Enabled = True
            gbDomicilio.Enabled = True

            Button1.Enabled = True

            MsgBox("Paciente encontrado" & vbCrLf & Existe, MsgBoxStyle.Information, "Buscar Paciente")
        Else
            If MsgBox("El Paciente no existe." & vbCrLf & "¿Desea registralo ahora mismo?", MsgBoxStyle.YesNo, "Buscar") = vbYes Then
                Dim objFrm As New frmPaciente
                objFrm.txtDNI.Text = Me.txtDNI.Text
                Regresar = 1 'Significa que el FRM es llamado por frmCitaMedica
                objFrm.ShowDialog()
                txtDNI.Text = DniNuevo
                If txtDNI.Text <> "" Then
                    txtDNI.Enabled = False
                    btnBuscar.Enabled = False
                    gbAtencion.Enabled = True
                    gbGenerales.Enabled = True
                    gbInterna.Enabled = True
                    gbDomicilio.Enabled = True
                    Button1.Enabled = True
                    DniNuevo = ""   'Una vez usado la variable, le borro el contenido, para su nuevo uso
                End If
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If AscW(e.KeyChar) <> 8 And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDCita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDCita.KeyPress
        If (e.KeyChar < "A" Or e.KeyChar > "Z") And AscW(e.KeyChar) <> 8 And (e.KeyChar < "a" Or e.KeyChar > "z") And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumConsultorio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumConsultorio.KeyPress
        If AscW(e.KeyChar) <> 8 And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmCitaMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Estado_Inicial()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As clsAtencion
        Dim cad As String
        If rbInterna.Checked = True Then
            If txtIDCita.Text.Trim <> "" And txtDiagnostico.Text.Trim <> "" And txtNumConsultorio.Text.Trim <> "" And txtOrden.Text.Trim <> "" Then
                If IDCita_Existe(txtIDCita.Text.Trim) = False Then
                    obj = New clsInterna(txtDiagnostico.Text, txtDNI.Text, dtpFecha.Value, txtIDCita.Text, CInt(txtNumConsultorio.Text), txtOrden.Text)
                    LCitas.Add(obj)
                    MsgBox("Cita Medica Agregada.", MsgBoxStyle.Information, "Registrar Cita Médica")
                    cad = txtIDCita.Text & "-" & txtDNI.Text
                    lstCitas.Items.Add(cad)
                    Estado_Inicial()
                Else
                    MsgBox("El ID de la Cita ya Existe." & vbCrLf & "Elija otro ID.", MsgBoxStyle.Exclamation, "Registrar Cita Médica")
                End If
            Else
                MsgBox("Complete los datos", MsgBoxStyle.Critical, "Registrar Cita Médica")
            End If
        Else
            Dim Hospital As Boolean 'para ver si ha marcado SI o NO necesita hospitalizacion
            If txtIDCita.Text.Trim <> "" And txtDiagnostico.Text.Trim <> "" And txtDomicilio.Text.Trim <> "" And (rbSi.Checked = True Or rbNo.Checked = True) Then
                If rbSi.Checked = True Then
                    Hospital = True
                Else
                    Hospital = False
                End If
                obj = New clsDomicilio(txtDiagnostico.Text, txtDNI.Text, dtpFecha.Value, txtIDCita.Text, txtDomicilio.Text, Hospital)
                LCitas.Add(obj)
                MsgBox("Cita Medica Agregada.", MsgBoxStyle.Information, "Registrar Cita Médica")
                cad = txtIDCita.Text & "-" & txtDNI.Text
                lstCitas.Items.Add(cad)
                Estado_Inicial()
            Else
                MsgBox("Complete los datos", MsgBoxStyle.Critical, "Registrar Cita Médica")
            End If

        End If


    End Sub

    Private Sub rbInterna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInterna.CheckedChanged
        gbInterna.Show()
        gbDomicilio.Hide()
    End Sub

    Private Sub rbDomicilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDomicilio.CheckedChanged
        gbInterna.Hide()
        gbDomicilio.Show()
    End Sub

    Sub LlenarListBox()
        lstCitas.Items.Clear()
        Dim cad As String
        For Each obj As clsAtencion In LCitas
            cad = obj.IDAtencion & "-" & obj.DNIPaciente
            lstCitas.Items.Add(cad)
        Next
    End Sub

    Sub LimpiarControles()
        txtDNI.Text = ""
        rbInterna.Checked = True
        rbDomicilio.Checked = False
        txtIDCita.Text = ""
        txtDiagnostico.Text = ""
        dtpFecha.Value = Today
        txtNumConsultorio.Text = ""
        txtOrden.Text = ""
        txtDomicilio.Text = ""
        rbSi.Checked = False
        rbNo.Checked = False
    End Sub

    Sub DesabilitarControles()
        txtDNI.Enabled = True
        btnBuscar.Enabled = True
        gbAtencion.Enabled = False
        gbGenerales.Enabled = False
        gbInterna.Enabled = False
        gbDomicilio.Enabled = False
        Button1.Enabled = False
    End Sub

    Sub Estado_Inicial()
        DesabilitarControles()
        LimpiarControles()
        LlenarListBox()
    End Sub

    Private Sub lstCitas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCitas.SelectedIndexChanged
        Dim cad() As String
        Dim Datos As String
        Dim Tipo As Integer '0:Cita Interna      1:Cita Domicilio
        DesabilitarControles()
        cad = Split(CStr(lstCitas.SelectedItem), "-")   'Separo la cadena seleccionada del ListBox
        Tipo = IdentificarTipoCita(cad(0))      'Busca si es Interno(0) o Domicilio(1)
        Datos = BuscarCita(cad(0))  'Envio el IdAtencion ke sta en cad(0) y recibo una cadena con todos los datos de la Cita
        cad = Split(Datos, "-")     'separo la Cadena de datos de la Cita
        'Desablito el txtBuscar y el btnBuscar:
        txtDNI.Enabled = False
        btnBuscar.Enabled = False
        'Completo los controles generales:
        txtDiagnostico.Text = cad(0)
        txtDNI.Text = cad(1)
        dtpFecha.Value = CDate(cad(2))
        txtIDCita.Text = cad(3)
        'Completo los controles especificos:
        If Tipo = 0 Then    'Si el Tipo es Interno(0)
            gbInterna.Show()
            gbDomicilio.Hide()
            rbInterna.Checked = True
            rbDomicilio.Checked = False
            txtNumConsultorio.Text = cad(4)
            txtOrden.Text = cad(5)
        End If
        If Tipo = 1 Then    'Si el Tipo es Domicilio(1)
            gbInterna.Hide()
            gbDomicilio.Show()
            rbInterna.Checked = False
            rbDomicilio.Checked = True
            txtDomicilio.Text = cad(4)
            If cad(5) = "True" Then
                rbSi.Checked = True
                rbNo.Checked = False
            Else
                rbNo.Checked = True
                rbSi.Checked = False
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Estado_Inicial()
    End Sub
End Class