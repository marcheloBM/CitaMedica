<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCitaMedica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbAtencion = New System.Windows.Forms.GroupBox()
        Me.rbDomicilio = New System.Windows.Forms.RadioButton()
        Me.rbInterna = New System.Windows.Forms.RadioButton()
        Me.gbGenerales = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDCita = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbInterna = New System.Windows.Forms.GroupBox()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.txtNumConsultorio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDomicilio = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstCitas = New System.Windows.Forms.ListBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbAtencion.SuspendLayout()
        Me.gbGenerales.SuspendLayout()
        Me.gbInterna.SuspendLayout()
        Me.gbDomicilio.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese DNI:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(130, 10)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(176, 24)
        Me.txtDNI.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(312, 7)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(138, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar DNI"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gbAtencion
        '
        Me.gbAtencion.Controls.Add(Me.rbDomicilio)
        Me.gbAtencion.Controls.Add(Me.rbInterna)
        Me.gbAtencion.Location = New System.Drawing.Point(38, 61)
        Me.gbAtencion.Name = "gbAtencion"
        Me.gbAtencion.Size = New System.Drawing.Size(412, 66)
        Me.gbAtencion.TabIndex = 3
        Me.gbAtencion.TabStop = False
        Me.gbAtencion.Text = "Elija Tipo de Atención"
        '
        'rbDomicilio
        '
        Me.rbDomicilio.AutoSize = True
        Me.rbDomicilio.Location = New System.Drawing.Point(258, 23)
        Me.rbDomicilio.Name = "rbDomicilio"
        Me.rbDomicilio.Size = New System.Drawing.Size(67, 17)
        Me.rbDomicilio.TabIndex = 1
        Me.rbDomicilio.Text = "Domicilio"
        Me.rbDomicilio.UseVisualStyleBackColor = True
        '
        'rbInterna
        '
        Me.rbInterna.AutoSize = True
        Me.rbInterna.Checked = True
        Me.rbInterna.Location = New System.Drawing.Point(48, 23)
        Me.rbInterna.Name = "rbInterna"
        Me.rbInterna.Size = New System.Drawing.Size(58, 17)
        Me.rbInterna.TabIndex = 0
        Me.rbInterna.TabStop = True
        Me.rbInterna.Text = "Interna"
        Me.rbInterna.UseVisualStyleBackColor = True
        '
        'gbGenerales
        '
        Me.gbGenerales.Controls.Add(Me.dtpFecha)
        Me.gbGenerales.Controls.Add(Me.Label4)
        Me.gbGenerales.Controls.Add(Me.txtDiagnostico)
        Me.gbGenerales.Controls.Add(Me.Label3)
        Me.gbGenerales.Controls.Add(Me.txtIDCita)
        Me.gbGenerales.Controls.Add(Me.Label2)
        Me.gbGenerales.Location = New System.Drawing.Point(38, 133)
        Me.gbGenerales.Name = "gbGenerales"
        Me.gbGenerales.Size = New System.Drawing.Size(412, 130)
        Me.gbGenerales.TabIndex = 4
        Me.gbGenerales.TabStop = False
        Me.gbGenerales.Text = "Datos Generales"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(127, 89)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(141, 24)
        Me.dtpFecha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Cita:"
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Location = New System.Drawing.Point(127, 59)
        Me.txtDiagnostico.MaxLength = 100
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(279, 24)
        Me.txtDiagnostico.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Diagnóstico:"
        '
        'txtIDCita
        '
        Me.txtIDCita.Location = New System.Drawing.Point(127, 29)
        Me.txtIDCita.MaxLength = 10
        Me.txtIDCita.Name = "txtIDCita"
        Me.txtIDCita.Size = New System.Drawing.Size(176, 24)
        Me.txtIDCita.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Cita:"
        '
        'gbInterna
        '
        Me.gbInterna.Controls.Add(Me.txtOrden)
        Me.gbInterna.Controls.Add(Me.txtNumConsultorio)
        Me.gbInterna.Controls.Add(Me.Label6)
        Me.gbInterna.Controls.Add(Me.Label5)
        Me.gbInterna.Location = New System.Drawing.Point(38, 269)
        Me.gbInterna.Name = "gbInterna"
        Me.gbInterna.Size = New System.Drawing.Size(412, 104)
        Me.gbInterna.TabIndex = 5
        Me.gbInterna.TabStop = False
        Me.gbInterna.Text = "Cita Interna"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(165, 53)
        Me.txtOrden.MaxLength = 100
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(241, 24)
        Me.txtOrden.TabIndex = 3
        '
        'txtNumConsultorio
        '
        Me.txtNumConsultorio.Location = New System.Drawing.Point(165, 23)
        Me.txtNumConsultorio.MaxLength = 2
        Me.txtNumConsultorio.Name = "txtNumConsultorio"
        Me.txtNumConsultorio.Size = New System.Drawing.Size(78, 24)
        Me.txtNumConsultorio.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Orden de Atencion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Num. Consultorio:"
        '
        'gbDomicilio
        '
        Me.gbDomicilio.Controls.Add(Me.rbNo)
        Me.gbDomicilio.Controls.Add(Me.rbSi)
        Me.gbDomicilio.Controls.Add(Me.txtDomicilio)
        Me.gbDomicilio.Controls.Add(Me.Label7)
        Me.gbDomicilio.Controls.Add(Me.Label8)
        Me.gbDomicilio.Location = New System.Drawing.Point(38, 269)
        Me.gbDomicilio.Name = "gbDomicilio"
        Me.gbDomicilio.Size = New System.Drawing.Size(412, 104)
        Me.gbDomicilio.TabIndex = 6
        Me.gbDomicilio.TabStop = False
        Me.gbDomicilio.Text = "Cita a Domicilio"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(274, 54)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 5
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(183, 54)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(34, 17)
        Me.rbSi.TabIndex = 4
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(106, 20)
        Me.txtDomicilio.MaxLength = 100
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(300, 24)
        Me.txtDomicilio.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Necesita Hospitalizar:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Dirección:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 55)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Registrar Atencion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstCitas)
        Me.GroupBox3.Location = New System.Drawing.Point(574, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 363)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Citas"
        '
        'lstCitas
        '
        Me.lstCitas.FormattingEnabled = True
        Me.lstCitas.ItemHeight = 18
        Me.lstCitas.Location = New System.Drawing.Point(6, 23)
        Me.lstCitas.Name = "lstCitas"
        Me.lstCitas.Size = New System.Drawing.Size(232, 328)
        Me.lstCitas.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(456, 162)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 38)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmCitaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(826, 389)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbInterna)
        Me.Controls.Add(Me.gbGenerales)
        Me.Controls.Add(Me.gbDomicilio)
        Me.Controls.Add(Me.gbAtencion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmCitaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registrar Cita Medica"
        Me.gbAtencion.ResumeLayout(False)
        Me.gbAtencion.PerformLayout()
        Me.gbGenerales.ResumeLayout(False)
        Me.gbGenerales.PerformLayout()
        Me.gbInterna.ResumeLayout(False)
        Me.gbInterna.PerformLayout()
        Me.gbDomicilio.ResumeLayout(False)
        Me.gbDomicilio.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbAtencion As System.Windows.Forms.GroupBox
    Friend WithEvents rbDomicilio As System.Windows.Forms.RadioButton
    Friend WithEvents rbInterna As System.Windows.Forms.RadioButton
    Friend WithEvents gbGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiagnostico As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIDCita As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbInterna As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtNumConsultorio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCitas As System.Windows.Forms.ListBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
