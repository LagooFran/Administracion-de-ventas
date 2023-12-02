<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BTN_IrADatos
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_CargarProducto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ver datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_CargarProducto
        '
        Me.BTN_CargarProducto.Location = New System.Drawing.Point(264, 12)
        Me.BTN_CargarProducto.Name = "BTN_CargarProducto"
        Me.BTN_CargarProducto.Size = New System.Drawing.Size(134, 46)
        Me.BTN_CargarProducto.TabIndex = 1
        Me.BTN_CargarProducto.Text = "Cargar Nuevo Producto"
        Me.BTN_CargarProducto.UseVisualStyleBackColor = True
        '
        'BTN_IrADatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 277)
        Me.Controls.Add(Me.BTN_CargarProducto)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BTN_IrADatos"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_CargarProducto As Button
End Class
