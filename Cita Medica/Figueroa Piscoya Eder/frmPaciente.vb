Imports MiLibreria
Public Class frmPaciente

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        If Regresar = 1 Then  'significa que es llamado por el frmCitaMedica
            frmCitaMedica.txtDNI.Text = Me.txtDNI.Text
        End If
        Me.Close()
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress, txtEdad.KeyPress
        If AscW(e.KeyChar) <> 8 And (e.KeyChar < "0" Or e.KeyChar > "9") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRegitrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegitrar.Click
        Dim obj As clsPaciente
        If txtDNI.Text <> "" And txtNombres.Text <> "" And txtEdad.Text <> "" And (rbMasculino.Checked = True Or rbFemenino.Checked = True) Then
            Dim Sexo As String
            If rbMasculino.Checked = True Then
                Sexo = rbMasculino.Text
            Else
                Sexo = rbFemenino.Text
            End If

            obj = New clsPaciente(txtDNI.Text, CInt(txtEdad.Text), txtNombres.Text, Sexo)
            If Regresar = 1 Then    'es llamado por el frmCitaMedica
                DniNuevo = txtDNI.Text
            End If
            LPacientes.Add(obj)
            MsgBox("Paciente agregado exitosamente", MsgBoxStyle.Information, "Registrar Paciente")
            LimpiarControles()
        Else
            MsgBox("Complete todos los campos", MsgBoxStyle.Critical, "Registrar Paciente")
        End If
    End Sub

    Sub LimpiarControles()
        txtDNI.Text = ""
        txtNombres.Text = ""
        txtEdad.Text = ""
        rbMasculino.Checked = False
        rbFemenino.Checked = False
    End Sub

    Private Sub frmPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Regresar = 0 Then  'significa que ha sido llamado por el frmPrincipal
            btnRegresar.Text = "Salir"
        Else
            btnRegresar.Text = "Regresar"
        End If
    End Sub
End Class