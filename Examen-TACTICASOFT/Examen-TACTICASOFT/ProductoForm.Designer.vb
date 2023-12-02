<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoForm
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
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.TBX_Nombre = New System.Windows.Forms.TextBox()
        Me.TBX_Categoria = New System.Windows.Forms.TextBox()
        Me.TBX_Precio = New System.Windows.Forms.TextBox()
        Me.LBL_Nombre = New System.Windows.Forms.Label()
        Me.LBL_Categoria = New System.Windows.Forms.Label()
        Me.LBL_Precio = New System.Windows.Forms.Label()
        Me.BTN_SubmitProducto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(272, 82)
        Me.LBL_Titulo.TabIndex = 0
        Me.LBL_Titulo.Text = "Cargar un nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "producto"
        '
        'TBX_Nombre
        '
        Me.TBX_Nombre.Location = New System.Drawing.Point(19, 143)
        Me.TBX_Nombre.Name = "TBX_Nombre"
        Me.TBX_Nombre.Size = New System.Drawing.Size(255, 20)
        Me.TBX_Nombre.TabIndex = 1
        '
        'TBX_Categoria
        '
        Me.TBX_Categoria.Location = New System.Drawing.Point(19, 207)
        Me.TBX_Categoria.Name = "TBX_Categoria"
        Me.TBX_Categoria.Size = New System.Drawing.Size(255, 20)
        Me.TBX_Categoria.TabIndex = 2
        '
        'TBX_Precio
        '
        Me.TBX_Precio.Location = New System.Drawing.Point(19, 275)
        Me.TBX_Precio.Name = "TBX_Precio"
        Me.TBX_Precio.Size = New System.Drawing.Size(255, 20)
        Me.TBX_Precio.TabIndex = 3
        '
        'LBL_Nombre
        '
        Me.LBL_Nombre.AutoSize = True
        Me.LBL_Nombre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Nombre.Location = New System.Drawing.Point(18, 121)
        Me.LBL_Nombre.Name = "LBL_Nombre"
        Me.LBL_Nombre.Size = New System.Drawing.Size(146, 19)
        Me.LBL_Nombre.TabIndex = 4
        Me.LBL_Nombre.Text = "Nombre del producto:"
        '
        'LBL_Categoria
        '
        Me.LBL_Categoria.AutoSize = True
        Me.LBL_Categoria.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Categoria.Location = New System.Drawing.Point(18, 185)
        Me.LBL_Categoria.Name = "LBL_Categoria"
        Me.LBL_Categoria.Size = New System.Drawing.Size(71, 19)
        Me.LBL_Categoria.TabIndex = 5
        Me.LBL_Categoria.Text = "Categoria:"
        '
        'LBL_Precio
        '
        Me.LBL_Precio.AutoSize = True
        Me.LBL_Precio.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Precio.Location = New System.Drawing.Point(18, 253)
        Me.LBL_Precio.Name = "LBL_Precio"
        Me.LBL_Precio.Size = New System.Drawing.Size(50, 19)
        Me.LBL_Precio.TabIndex = 6
        Me.LBL_Precio.Text = "Precio:"
        '
        'BTN_SubmitProducto
        '
        Me.BTN_SubmitProducto.Location = New System.Drawing.Point(19, 331)
        Me.BTN_SubmitProducto.Name = "BTN_SubmitProducto"
        Me.BTN_SubmitProducto.Size = New System.Drawing.Size(255, 57)
        Me.BTN_SubmitProducto.TabIndex = 7
        Me.BTN_SubmitProducto.Text = "Cargar producto"
        Me.BTN_SubmitProducto.UseVisualStyleBackColor = True
        '
        'ProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 400)
        Me.Controls.Add(Me.BTN_SubmitProducto)
        Me.Controls.Add(Me.LBL_Precio)
        Me.Controls.Add(Me.LBL_Categoria)
        Me.Controls.Add(Me.LBL_Nombre)
        Me.Controls.Add(Me.TBX_Precio)
        Me.Controls.Add(Me.TBX_Categoria)
        Me.Controls.Add(Me.TBX_Nombre)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Name = "ProductoForm"
        Me.Text = "Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents TBX_Nombre As TextBox
    Friend WithEvents TBX_Categoria As TextBox
    Friend WithEvents TBX_Precio As TextBox
    Friend WithEvents LBL_Nombre As Label
    Friend WithEvents LBL_Categoria As Label
    Friend WithEvents LBL_Precio As Label
    Friend WithEvents BTN_SubmitProducto As Button
End Class
