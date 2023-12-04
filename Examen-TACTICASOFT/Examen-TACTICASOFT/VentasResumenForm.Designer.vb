<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasResumenForm
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
        Me.DGV_Ventas = New System.Windows.Forms.DataGridView()
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.DGV_Items = New System.Windows.Forms.DataGridView()
        Me.CMBX_Ventas = New System.Windows.Forms.ComboBox()
        Me.LBL_Seleccionar = New System.Windows.Forms.Label()
        Me.BTN_Eliminar = New System.Windows.Forms.Button()
        Me.LBL_Items = New System.Windows.Forms.Label()
        Me.DGV_ProductosReporte = New System.Windows.Forms.DataGridView()
        Me.DGV_VentasPorCliente = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_VentasXMes = New System.Windows.Forms.Label()
        Me.BTN_Actualizar = New System.Windows.Forms.Button()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ProductosReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_VentasPorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Ventas
        '
        Me.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ventas.Location = New System.Drawing.Point(12, 73)
        Me.DGV_Ventas.Name = "DGV_Ventas"
        Me.DGV_Ventas.Size = New System.Drawing.Size(379, 187)
        Me.DGV_Ventas.TabIndex = 0
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(149, 48)
        Me.LBL_Titulo.TabIndex = 7
        Me.LBL_Titulo.Text = "Ventas:"
        '
        'DGV_Items
        '
        Me.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Items.Location = New System.Drawing.Point(551, 73)
        Me.DGV_Items.Name = "DGV_Items"
        Me.DGV_Items.Size = New System.Drawing.Size(432, 187)
        Me.DGV_Items.TabIndex = 8
        '
        'CMBX_Ventas
        '
        Me.CMBX_Ventas.FormattingEnabled = True
        Me.CMBX_Ventas.Location = New System.Drawing.Point(397, 97)
        Me.CMBX_Ventas.Name = "CMBX_Ventas"
        Me.CMBX_Ventas.Size = New System.Drawing.Size(148, 21)
        Me.CMBX_Ventas.TabIndex = 9
        '
        'LBL_Seleccionar
        '
        Me.LBL_Seleccionar.AutoSize = True
        Me.LBL_Seleccionar.Location = New System.Drawing.Point(398, 78)
        Me.LBL_Seleccionar.Name = "LBL_Seleccionar"
        Me.LBL_Seleccionar.Size = New System.Drawing.Size(117, 13)
        Me.LBL_Seleccionar.TabIndex = 10
        Me.LBL_Seleccionar.Text = "Seleccionar una venta:"
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.Location = New System.Drawing.Point(401, 124)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(144, 82)
        Me.BTN_Eliminar.TabIndex = 12
        Me.BTN_Eliminar.Text = "Eliminar venta"
        Me.BTN_Eliminar.UseVisualStyleBackColor = True
        '
        'LBL_Items
        '
        Me.LBL_Items.AutoSize = True
        Me.LBL_Items.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Items.Location = New System.Drawing.Point(555, 9)
        Me.LBL_Items.Name = "LBL_Items"
        Me.LBL_Items.Size = New System.Drawing.Size(127, 48)
        Me.LBL_Items.TabIndex = 13
        Me.LBL_Items.Text = "Items:"
        '
        'DGV_ProductosReporte
        '
        Me.DGV_ProductosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ProductosReporte.Location = New System.Drawing.Point(12, 327)
        Me.DGV_ProductosReporte.Name = "DGV_ProductosReporte"
        Me.DGV_ProductosReporte.Size = New System.Drawing.Size(432, 187)
        Me.DGV_ProductosReporte.TabIndex = 14
        '
        'DGV_VentasPorCliente
        '
        Me.DGV_VentasPorCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VentasPorCliente.Location = New System.Drawing.Point(551, 327)
        Me.DGV_VentasPorCliente.Name = "DGV_VentasPorCliente"
        Me.DGV_VentasPorCliente.Size = New System.Drawing.Size(432, 187)
        Me.DGV_VentasPorCliente.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 48)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ventas por productos:"
        '
        'LBL_VentasXMes
        '
        Me.LBL_VentasXMes.AutoSize = True
        Me.LBL_VentasXMes.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_VentasXMes.Location = New System.Drawing.Point(555, 276)
        Me.LBL_VentasXMes.Name = "LBL_VentasXMes"
        Me.LBL_VentasXMes.Size = New System.Drawing.Size(351, 48)
        Me.LBL_VentasXMes.TabIndex = 18
        Me.LBL_VentasXMes.Text = "Ventas por cliente:"
        '
        'BTN_Actualizar
        '
        Me.BTN_Actualizar.Location = New System.Drawing.Point(450, 327)
        Me.BTN_Actualizar.Name = "BTN_Actualizar"
        Me.BTN_Actualizar.Size = New System.Drawing.Size(95, 187)
        Me.BTN_Actualizar.TabIndex = 19
        Me.BTN_Actualizar.Text = "Actualizar"
        Me.BTN_Actualizar.UseVisualStyleBackColor = True
        '
        'VentasResumenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 534)
        Me.Controls.Add(Me.BTN_Actualizar)
        Me.Controls.Add(Me.LBL_VentasXMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_VentasPorCliente)
        Me.Controls.Add(Me.DGV_ProductosReporte)
        Me.Controls.Add(Me.LBL_Items)
        Me.Controls.Add(Me.BTN_Eliminar)
        Me.Controls.Add(Me.LBL_Seleccionar)
        Me.Controls.Add(Me.CMBX_Ventas)
        Me.Controls.Add(Me.DGV_Items)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Controls.Add(Me.DGV_Ventas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VentasResumenForm"
        Me.Text = "Resumen de ventas"
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ProductosReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_VentasPorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Ventas As DataGridView
    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents DGV_Items As DataGridView
    Friend WithEvents CMBX_Ventas As ComboBox
    Friend WithEvents LBL_Seleccionar As Label
    Friend WithEvents BTN_Eliminar As Button
    Friend WithEvents LBL_Items As Label
    Friend WithEvents DGV_ProductosReporte As DataGridView
    Friend WithEvents DGV_VentasPorCliente As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_VentasXMes As Label
    Friend WithEvents BTN_Actualizar As Button
End Class
