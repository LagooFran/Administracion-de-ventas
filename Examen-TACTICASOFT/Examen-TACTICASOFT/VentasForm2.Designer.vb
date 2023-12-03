<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm2
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
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.TXB_FiltroCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_Seleccion = New System.Windows.Forms.Label()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.CMBX_ProductoSeleccionado = New System.Windows.Forms.ComboBox()
        Me.TXB_FiltroNombre = New System.Windows.Forms.TextBox()
        Me.LBL_Filtrar = New System.Windows.Forms.Label()
        Me.DGV_Productos = New System.Windows.Forms.DataGridView()
        Me.BTN_Agregar = New System.Windows.Forms.Button()
        Me.LBL_Cantidad = New System.Windows.Forms.Label()
        Me.DGV_ProductosAgregados = New System.Windows.Forms.DataGridView()
        Me.NUD_Cantidad = New System.Windows.Forms.NumericUpDown()
        Me.LBL_SeleccionEliminar = New System.Windows.Forms.Label()
        Me.CMBX_SeleccionEliminar = New System.Windows.Forms.ComboBox()
        Me.BTN_Eliminar = New System.Windows.Forms.Button()
        Me.BTN_Siguiente = New System.Windows.Forms.Button()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ProductosAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 41)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "1.Agregar Productos"
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(12, 7)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(280, 41)
        Me.LBL_Titulo.TabIndex = 11
        Me.LBL_Titulo.Text = "Cargar una venta"
        '
        'TXB_FiltroCategoria
        '
        Me.TXB_FiltroCategoria.Location = New System.Drawing.Point(19, 168)
        Me.TXB_FiltroCategoria.Name = "TXB_FiltroCategoria"
        Me.TXB_FiltroCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TXB_FiltroCategoria.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Filtrar por categoria"
        '
        'LBL_Seleccion
        '
        Me.LBL_Seleccion.AutoSize = True
        Me.LBL_Seleccion.Location = New System.Drawing.Point(330, 197)
        Me.LBL_Seleccion.Name = "LBL_Seleccion"
        Me.LBL_Seleccion.Size = New System.Drawing.Size(121, 13)
        Me.LBL_Seleccion.TabIndex = 27
        Me.LBL_Seleccion.Text = "Producto Seleccionado:"
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Location = New System.Drawing.Point(231, 166)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(96, 23)
        Me.BTN_Filtrar.TabIndex = 26
        Me.BTN_Filtrar.Text = "Filtrar"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'CMBX_ProductoSeleccionado
        '
        Me.CMBX_ProductoSeleccionado.FormattingEnabled = True
        Me.CMBX_ProductoSeleccionado.Location = New System.Drawing.Point(333, 213)
        Me.CMBX_ProductoSeleccionado.Name = "CMBX_ProductoSeleccionado"
        Me.CMBX_ProductoSeleccionado.Size = New System.Drawing.Size(121, 21)
        Me.CMBX_ProductoSeleccionado.TabIndex = 25
        '
        'TXB_FiltroNombre
        '
        Me.TXB_FiltroNombre.Location = New System.Drawing.Point(125, 169)
        Me.TXB_FiltroNombre.Name = "TXB_FiltroNombre"
        Me.TXB_FiltroNombre.Size = New System.Drawing.Size(100, 20)
        Me.TXB_FiltroNombre.TabIndex = 24
        '
        'LBL_Filtrar
        '
        Me.LBL_Filtrar.AutoSize = True
        Me.LBL_Filtrar.Location = New System.Drawing.Point(122, 153)
        Me.LBL_Filtrar.Name = "LBL_Filtrar"
        Me.LBL_Filtrar.Size = New System.Drawing.Size(88, 13)
        Me.LBL_Filtrar.TabIndex = 23
        Me.LBL_Filtrar.Text = "Filtrar por nombre"
        '
        'DGV_Productos
        '
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Location = New System.Drawing.Point(19, 194)
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.Size = New System.Drawing.Size(308, 228)
        Me.DGV_Productos.TabIndex = 22
        '
        'BTN_Agregar
        '
        Me.BTN_Agregar.Location = New System.Drawing.Point(333, 279)
        Me.BTN_Agregar.Name = "BTN_Agregar"
        Me.BTN_Agregar.Size = New System.Drawing.Size(121, 48)
        Me.BTN_Agregar.TabIndex = 30
        Me.BTN_Agregar.Text = "--->"
        Me.BTN_Agregar.UseVisualStyleBackColor = True
        '
        'LBL_Cantidad
        '
        Me.LBL_Cantidad.AutoSize = True
        Me.LBL_Cantidad.Location = New System.Drawing.Point(330, 237)
        Me.LBL_Cantidad.Name = "LBL_Cantidad"
        Me.LBL_Cantidad.Size = New System.Drawing.Size(52, 13)
        Me.LBL_Cantidad.TabIndex = 32
        Me.LBL_Cantidad.Text = "Cantidad:"
        '
        'DGV_ProductosAgregados
        '
        Me.DGV_ProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ProductosAgregados.Location = New System.Drawing.Point(460, 194)
        Me.DGV_ProductosAgregados.Name = "DGV_ProductosAgregados"
        Me.DGV_ProductosAgregados.Size = New System.Drawing.Size(308, 228)
        Me.DGV_ProductosAgregados.TabIndex = 33
        '
        'NUD_Cantidad
        '
        Me.NUD_Cantidad.Location = New System.Drawing.Point(333, 253)
        Me.NUD_Cantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_Cantidad.Name = "NUD_Cantidad"
        Me.NUD_Cantidad.Size = New System.Drawing.Size(121, 20)
        Me.NUD_Cantidad.TabIndex = 34
        Me.NUD_Cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LBL_SeleccionEliminar
        '
        Me.LBL_SeleccionEliminar.AutoSize = True
        Me.LBL_SeleccionEliminar.Location = New System.Drawing.Point(330, 336)
        Me.LBL_SeleccionEliminar.Name = "LBL_SeleccionEliminar"
        Me.LBL_SeleccionEliminar.Size = New System.Drawing.Size(121, 13)
        Me.LBL_SeleccionEliminar.TabIndex = 36
        Me.LBL_SeleccionEliminar.Text = "Producto Seleccionado:"
        '
        'CMBX_SeleccionEliminar
        '
        Me.CMBX_SeleccionEliminar.FormattingEnabled = True
        Me.CMBX_SeleccionEliminar.Location = New System.Drawing.Point(333, 352)
        Me.CMBX_SeleccionEliminar.Name = "CMBX_SeleccionEliminar"
        Me.CMBX_SeleccionEliminar.Size = New System.Drawing.Size(121, 21)
        Me.CMBX_SeleccionEliminar.TabIndex = 35
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.Location = New System.Drawing.Point(333, 379)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(121, 43)
        Me.BTN_Eliminar.TabIndex = 37
        Me.BTN_Eliminar.Text = "<---"
        Me.BTN_Eliminar.UseVisualStyleBackColor = True
        '
        'BTN_Siguiente
        '
        Me.BTN_Siguiente.Location = New System.Drawing.Point(644, 455)
        Me.BTN_Siguiente.Name = "BTN_Siguiente"
        Me.BTN_Siguiente.Size = New System.Drawing.Size(121, 43)
        Me.BTN_Siguiente.TabIndex = 38
        Me.BTN_Siguiente.Text = "Siguiente"
        Me.BTN_Siguiente.UseVisualStyleBackColor = True
        '
        'VentasForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 510)
        Me.Controls.Add(Me.BTN_Siguiente)
        Me.Controls.Add(Me.BTN_Eliminar)
        Me.Controls.Add(Me.LBL_SeleccionEliminar)
        Me.Controls.Add(Me.CMBX_SeleccionEliminar)
        Me.Controls.Add(Me.NUD_Cantidad)
        Me.Controls.Add(Me.DGV_ProductosAgregados)
        Me.Controls.Add(Me.LBL_Cantidad)
        Me.Controls.Add(Me.BTN_Agregar)
        Me.Controls.Add(Me.TXB_FiltroCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_Seleccion)
        Me.Controls.Add(Me.BTN_Filtrar)
        Me.Controls.Add(Me.CMBX_ProductoSeleccionado)
        Me.Controls.Add(Me.TXB_FiltroNombre)
        Me.Controls.Add(Me.LBL_Filtrar)
        Me.Controls.Add(Me.DGV_Productos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Name = "VentasForm2"
        Me.Text = "VentasForm2"
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ProductosAgregados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents TXB_FiltroCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_Seleccion As Label
    Friend WithEvents BTN_Filtrar As Button
    Friend WithEvents CMBX_ProductoSeleccionado As ComboBox
    Friend WithEvents TXB_FiltroNombre As TextBox
    Friend WithEvents LBL_Filtrar As Label
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents BTN_Agregar As Button
    Friend WithEvents LBL_Cantidad As Label
    Friend WithEvents DGV_ProductosAgregados As DataGridView
    Friend WithEvents NUD_Cantidad As NumericUpDown
    Friend WithEvents LBL_SeleccionEliminar As Label
    Friend WithEvents CMBX_SeleccionEliminar As ComboBox
    Friend WithEvents BTN_Eliminar As Button
    Friend WithEvents BTN_Siguiente As Button
End Class
