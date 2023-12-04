<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosAdmForm
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
        Me.LBL_Seleccion = New System.Windows.Forms.Label()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.BTN_Modificar = New System.Windows.Forms.Button()
        Me.BTN_Eliminar = New System.Windows.Forms.Button()
        Me.CMBX_ProductoSeleccionado = New System.Windows.Forms.ComboBox()
        Me.TXB_FiltroNombre = New System.Windows.Forms.TextBox()
        Me.LBL_Filtrar = New System.Windows.Forms.Label()
        Me.DGV_Productos = New System.Windows.Forms.DataGridView()
        Me.TXB_FiltroCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_Seleccion
        '
        Me.LBL_Seleccion.AutoSize = True
        Me.LBL_Seleccion.Location = New System.Drawing.Point(196, 113)
        Me.LBL_Seleccion.Name = "LBL_Seleccion"
        Me.LBL_Seleccion.Size = New System.Drawing.Size(121, 13)
        Me.LBL_Seleccion.TabIndex = 19
        Me.LBL_Seleccion.Text = "Producto Seleccionado:"
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Location = New System.Drawing.Point(118, 129)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Filtrar.TabIndex = 18
        Me.BTN_Filtrar.Text = "Filtrar"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(4, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(211, 48)
        Me.LBL_Titulo.TabIndex = 17
        Me.LBL_Titulo.Text = "Productos:"
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Location = New System.Drawing.Point(406, 127)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(133, 23)
        Me.BTN_Modificar.TabIndex = 16
        Me.BTN_Modificar.Text = "Modificar informacion"
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.Location = New System.Drawing.Point(326, 127)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Eliminar.TabIndex = 15
        Me.BTN_Eliminar.Text = "Eliminar"
        Me.BTN_Eliminar.UseVisualStyleBackColor = True
        '
        'CMBX_ProductoSeleccionado
        '
        Me.CMBX_ProductoSeleccionado.FormattingEnabled = True
        Me.CMBX_ProductoSeleccionado.Location = New System.Drawing.Point(199, 129)
        Me.CMBX_ProductoSeleccionado.Name = "CMBX_ProductoSeleccionado"
        Me.CMBX_ProductoSeleccionado.Size = New System.Drawing.Size(121, 21)
        Me.CMBX_ProductoSeleccionado.TabIndex = 14
        '
        'TXB_FiltroNombre
        '
        Me.TXB_FiltroNombre.Location = New System.Drawing.Point(12, 93)
        Me.TXB_FiltroNombre.Name = "TXB_FiltroNombre"
        Me.TXB_FiltroNombre.Size = New System.Drawing.Size(100, 20)
        Me.TXB_FiltroNombre.TabIndex = 13
        '
        'LBL_Filtrar
        '
        Me.LBL_Filtrar.AutoSize = True
        Me.LBL_Filtrar.Location = New System.Drawing.Point(9, 77)
        Me.LBL_Filtrar.Name = "LBL_Filtrar"
        Me.LBL_Filtrar.Size = New System.Drawing.Size(88, 13)
        Me.LBL_Filtrar.TabIndex = 12
        Me.LBL_Filtrar.Text = "Filtrar por nombre"
        '
        'DGV_Productos
        '
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Location = New System.Drawing.Point(12, 158)
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.Size = New System.Drawing.Size(528, 228)
        Me.DGV_Productos.TabIndex = 11
        '
        'TXB_FiltroCategoria
        '
        Me.TXB_FiltroCategoria.Location = New System.Drawing.Point(12, 132)
        Me.TXB_FiltroCategoria.Name = "TXB_FiltroCategoria"
        Me.TXB_FiltroCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TXB_FiltroCategoria.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Filtrar por categoria"
        '
        'ProductosAdmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 401)
        Me.Controls.Add(Me.TXB_FiltroCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_Seleccion)
        Me.Controls.Add(Me.BTN_Filtrar)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Controls.Add(Me.BTN_Modificar)
        Me.Controls.Add(Me.BTN_Eliminar)
        Me.Controls.Add(Me.CMBX_ProductoSeleccionado)
        Me.Controls.Add(Me.TXB_FiltroNombre)
        Me.Controls.Add(Me.LBL_Filtrar)
        Me.Controls.Add(Me.DGV_Productos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductosAdmForm"
        Me.Text = "Productos"
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Seleccion As Label
    Friend WithEvents BTN_Filtrar As Button
    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents BTN_Modificar As Button
    Friend WithEvents BTN_Eliminar As Button
    Friend WithEvents CMBX_ProductoSeleccionado As ComboBox
    Friend WithEvents TXB_FiltroNombre As TextBox
    Friend WithEvents LBL_Filtrar As Label
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents TXB_FiltroCategoria As TextBox
    Friend WithEvents Label1 As Label
End Class
