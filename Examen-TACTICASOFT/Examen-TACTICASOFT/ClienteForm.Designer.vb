<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
        Me.BTN_SubmitCliente = New System.Windows.Forms.Button()
        Me.LBL_Correo = New System.Windows.Forms.Label()
        Me.LBL_Telefono = New System.Windows.Forms.Label()
        Me.LBL_Nombre = New System.Windows.Forms.Label()
        Me.TBX_Correo = New System.Windows.Forms.TextBox()
        Me.TBX_Telefono = New System.Windows.Forms.TextBox()
        Me.TBX_Nombre = New System.Windows.Forms.TextBox()
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_SubmitCliente
        '
        Me.BTN_SubmitCliente.Location = New System.Drawing.Point(19, 331)
        Me.BTN_SubmitCliente.Name = "BTN_SubmitCliente"
        Me.BTN_SubmitCliente.Size = New System.Drawing.Size(255, 57)
        Me.BTN_SubmitCliente.TabIndex = 15
        Me.BTN_SubmitCliente.Text = "Cargar cliente"
        Me.BTN_SubmitCliente.UseVisualStyleBackColor = True
        '
        'LBL_Correo
        '
        Me.LBL_Correo.AutoSize = True
        Me.LBL_Correo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Correo.Location = New System.Drawing.Point(18, 253)
        Me.LBL_Correo.Name = "LBL_Correo"
        Me.LBL_Correo.Size = New System.Drawing.Size(54, 19)
        Me.LBL_Correo.TabIndex = 14
        Me.LBL_Correo.Text = "Correo:"
        '
        'LBL_Telefono
        '
        Me.LBL_Telefono.AutoSize = True
        Me.LBL_Telefono.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Telefono.Location = New System.Drawing.Point(18, 185)
        Me.LBL_Telefono.Name = "LBL_Telefono"
        Me.LBL_Telefono.Size = New System.Drawing.Size(65, 19)
        Me.LBL_Telefono.TabIndex = 13
        Me.LBL_Telefono.Text = "Telefono:"
        '
        'LBL_Nombre
        '
        Me.LBL_Nombre.AutoSize = True
        Me.LBL_Nombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Nombre.Location = New System.Drawing.Point(18, 121)
        Me.LBL_Nombre.Name = "LBL_Nombre"
        Me.LBL_Nombre.Size = New System.Drawing.Size(129, 19)
        Me.LBL_Nombre.TabIndex = 12
        Me.LBL_Nombre.Text = "Nombre del cliente:"
        '
        'TBX_Correo
        '
        Me.TBX_Correo.Location = New System.Drawing.Point(19, 275)
        Me.TBX_Correo.Name = "TBX_Correo"
        Me.TBX_Correo.Size = New System.Drawing.Size(255, 20)
        Me.TBX_Correo.TabIndex = 11
        '
        'TBX_Telefono
        '
        Me.TBX_Telefono.Location = New System.Drawing.Point(19, 207)
        Me.TBX_Telefono.Name = "TBX_Telefono"
        Me.TBX_Telefono.Size = New System.Drawing.Size(255, 20)
        Me.TBX_Telefono.TabIndex = 10
        '
        'TBX_Nombre
        '
        Me.TBX_Nombre.Location = New System.Drawing.Point(19, 143)
        Me.TBX_Nombre.Name = "TBX_Nombre"
        Me.TBX_Nombre.Size = New System.Drawing.Size(255, 20)
        Me.TBX_Nombre.TabIndex = 9
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(272, 82)
        Me.LBL_Titulo.TabIndex = 8
        Me.LBL_Titulo.Text = "Cargar un nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cliente"
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 400)
        Me.Controls.Add(Me.BTN_SubmitCliente)
        Me.Controls.Add(Me.LBL_Correo)
        Me.Controls.Add(Me.LBL_Telefono)
        Me.Controls.Add(Me.LBL_Nombre)
        Me.Controls.Add(Me.TBX_Correo)
        Me.Controls.Add(Me.TBX_Telefono)
        Me.Controls.Add(Me.TBX_Nombre)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Name = "ClienteForm"
        Me.Text = "ClienteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_SubmitCliente As Button
    Friend WithEvents LBL_Correo As Label
    Friend WithEvents LBL_Telefono As Label
    Friend WithEvents LBL_Nombre As Label
    Friend WithEvents TBX_Correo As TextBox
    Friend WithEvents TBX_Telefono As TextBox
    Friend WithEvents TBX_Nombre As TextBox
    Friend WithEvents LBL_Titulo As Label
End Class
