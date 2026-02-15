Imports MiLibreria
Public Class frmPrincipal

    Private Sub CitaMédicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CitaMédicaToolStripMenuItem.Click
        Dim objFrm As New frmCitaMedica
        objFrm.ShowDialog()
    End Sub

    Private Sub PacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteToolStripMenuItem.Click
        Regresar = 0
        Dim objFrm As New frmPaciente
        objFrm.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Registros de Prueba
        Dim obj1 As New clsInterna("Reservado", "72019283", Today, "A001", 20, "Orden 01")
        Dim obj2 As New clsDomicilio("Conjuntivitis", "98765432", Today, "A002", "Calle Grau 123", False)
        LCitas.Add(obj1)
        LCitas.Add(obj2)
        Dim obj3 As New clsPaciente("72019283", 25, "Carlos Rodriguez Silva", "Masculino")
        Dim obj4 As New clsPaciente("98765432", 18, "Rosa Altamirano Diaz", "Femenino")
        LPacientes.Add(obj3)
        LPacientes.Add(obj4)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListadoDeCitasMedicasPorTipoDeAtencionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeCitasMedicasPorTipoDeAtencionToolStripMenuItem.Click
        Dim objFrm As New frmListado
        objFrm.ShowDialog()
    End Sub
End Class
