<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListado
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
        Me.gbAtencion = New System.Windows.Forms.GroupBox()
        Me.rbDomicilio = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rbInterna = New System.Windows.Forms.RadioButton()
        Me.gbDomicilio = New System.Windows.Forms.GroupBox()
        Me.lvInterna = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvDomicilio = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbAtencion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbDomicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAtencion
        '
        Me.gbAtencion.Controls.Add(Me.rbDomicilio)
        Me.gbAtencion.Controls.Add(Me.GroupBox2)
        Me.gbAtencion.Controls.Add(Me.rbInterna)
        Me.gbAtencion.Location = New System.Drawing.Point(13, 13)
        Me.gbAtencion.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAtencion.Name = "gbAtencion"
        Me.gbAtencion.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAtencion.Size = New System.Drawing.Size(813, 66)
        Me.gbAtencion.TabIndex = 4
        Me.gbAtencion.TabStop = False
        Me.gbAtencion.Text = "Elija Tipo de Atención"
        '
        'rbDomicilio
        '
        Me.rbDomicilio.AutoSize = True
        Me.rbDomicilio.Location = New System.Drawing.Point(401, 25)
        Me.rbDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDomicilio.Name = "rbDomicilio"
        Me.rbDomicilio.Size = New System.Drawing.Size(67, 17)
        Me.rbDomicilio.TabIndex = 1
        Me.rbDomicilio.Text = "Domicilio"
        Me.rbDomicilio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(813, 322)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado por Tipo"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(7, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(800, 292)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID Cita"
        Me.ColumnHeader7.Width = 69
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nombre"
        Me.ColumnHeader8.Width = 260
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Diagnóstico"
        Me.ColumnHeader9.Width = 137
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Fecha"
        Me.ColumnHeader10.Width = 91
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "N° Consultorio"
        Me.ColumnHeader11.Width = 118
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Orden Atención"
        Me.ColumnHeader12.Width = 121
        '
        'rbInterna
        '
        Me.rbInterna.AutoSize = True
        Me.rbInterna.Location = New System.Drawing.Point(82, 25)
        Me.rbInterna.Margin = New System.Windows.Forms.Padding(4)
        Me.rbInterna.Name = "rbInterna"
        Me.rbInterna.Size = New System.Drawing.Size(58, 17)
        Me.rbInterna.TabIndex = 0
        Me.rbInterna.Text = "Interna"
        Me.rbInterna.UseVisualStyleBackColor = True
        '
        'gbDomicilio
        '
        Me.gbDomicilio.Controls.Add(Me.lvInterna)
        Me.gbDomicilio.Controls.Add(Me.lvDomicilio)
        Me.gbDomicilio.Location = New System.Drawing.Point(14, 86)
        Me.gbDomicilio.Name = "gbDomicilio"
        Me.gbDomicilio.Size = New System.Drawing.Size(813, 322)
        Me.gbDomicilio.TabIndex = 8
        Me.gbDomicilio.TabStop = False
        Me.gbDomicilio.Text = "Listado por Tipo"
        '
        'lvInterna
        '
        Me.lvInterna.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvInterna.GridLines = True
        Me.lvInterna.Location = New System.Drawing.Point(7, 24)
        Me.lvInterna.Name = "lvInterna"
        Me.lvInterna.Size = New System.Drawing.Size(800, 292)
        Me.lvInterna.TabIndex = 1
        Me.lvInterna.UseCompatibleStateImageBehavior = False
        Me.lvInterna.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Cita"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 260
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Diagnóstico"
        Me.ColumnHeader3.Width = 137
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha"
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "N° Consultorio"
        Me.ColumnHeader5.Width = 115
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Orden Atención"
        Me.ColumnHeader6.Width = 123
        '
        'lvDomicilio
        '
        Me.lvDomicilio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lvDomicilio.GridLines = True
        Me.lvDomicilio.Location = New System.Drawing.Point(7, 24)
        Me.lvDomicilio.Name = "lvDomicilio"
        Me.lvDomicilio.Size = New System.Drawing.Size(800, 292)
        Me.lvDomicilio.TabIndex = 0
        Me.lvDomicilio.UseCompatibleStateImageBehavior = False
        Me.lvDomicilio.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ID Cita"
        Me.ColumnHeader13.Width = 69
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Nombre"
        Me.ColumnHeader14.Width = 260
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Diagnóstico"
        Me.ColumnHeader15.Width = 137
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Fecha"
        Me.ColumnHeader16.Width = 91
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Dirección"
        Me.ColumnHeader17.Width = 169
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Hospitalizar"
        Me.ColumnHeader18.Width = 69
        '
        'frmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 420)
        Me.Controls.Add(Me.gbDomicilio)
        Me.Controls.Add(Me.gbAtencion)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de Citas Médicas por Tipo"
        Me.gbAtencion.ResumeLayout(False)
        Me.gbAtencion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbDomicilio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbAtencion As System.Windows.Forms.GroupBox
    Friend WithEvents rbDomicilio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents rbInterna As System.Windows.Forms.RadioButton
    Friend WithEvents gbDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents lvDomicilio As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInterna As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
