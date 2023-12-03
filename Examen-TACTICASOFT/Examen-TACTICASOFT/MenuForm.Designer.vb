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
        Me.BTN_VerDatos = New System.Windows.Forms.Button()
        Me.BTN_CargarProducto = New System.Windows.Forms.Button()
        Me.BTN_AdmProductos = New System.Windows.Forms.Button()
        Me.BTN_CargarCliente = New System.Windows.Forms.Button()
        Me.BTN_AdmClientes = New System.Windows.Forms.Button()
        Me.BTN_CargarVenta = New System.Windows.Forms.Button()
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_Informes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_VerDatos
        '
        Me.BTN_VerDatos.Location = New System.Drawing.Point(333, 60)
        Me.BTN_VerDatos.Name = "BTN_VerDatos"
        Me.BTN_VerDatos.Size = New System.Drawing.Size(134, 389)
        Me.BTN_VerDatos.TabIndex = 0
        Me.BTN_VerDatos.Text = "Ver datos"
        Me.BTN_VerDatos.UseVisualStyleBackColor = True
        '
        'BTN_CargarProducto
        '
        Me.BTN_CargarProducto.Location = New System.Drawing.Point(20, 252)
        Me.BTN_CargarProducto.Name = "BTN_CargarProducto"
        Me.BTN_CargarProducto.Size = New System.Drawing.Size(134, 46)
        Me.BTN_CargarProducto.TabIndex = 1
        Me.BTN_CargarProducto.Text = "Cargar Nuevo Producto"
        Me.BTN_CargarProducto.UseVisualStyleBackColor = True
        '
        'BTN_AdmProductos
        '
        Me.BTN_AdmProductos.Location = New System.Drawing.Point(160, 252)
        Me.BTN_AdmProductos.Name = "BTN_AdmProductos"
        Me.BTN_AdmProductos.Size = New System.Drawing.Size(134, 46)
        Me.BTN_AdmProductos.TabIndex = 2
        Me.BTN_AdmProductos.Text = "Administracion de productos"
        Me.BTN_AdmProductos.UseVisualStyleBackColor = True
        '
        'BTN_CargarCliente
        '
        Me.BTN_CargarCliente.Location = New System.Drawing.Point(20, 137)
        Me.BTN_CargarCliente.Name = "BTN_CargarCliente"
        Me.BTN_CargarCliente.Size = New System.Drawing.Size(134, 46)
        Me.BTN_CargarCliente.TabIndex = 3
        Me.BTN_CargarCliente.Text = "Cargar un nuevo cliente"
        Me.BTN_CargarCliente.UseVisualStyleBackColor = True
        '
        'BTN_AdmClientes
        '
        Me.BTN_AdmClientes.Location = New System.Drawing.Point(160, 137)
        Me.BTN_AdmClientes.Name = "BTN_AdmClientes"
        Me.BTN_AdmClientes.Size = New System.Drawing.Size(134, 46)
        Me.BTN_AdmClientes.TabIndex = 4
        Me.BTN_AdmClientes.Text = "Administracion de clientes"
        Me.BTN_AdmClientes.UseVisualStyleBackColor = True
        '
        'BTN_CargarVenta
        '
        Me.BTN_CargarVenta.Location = New System.Drawing.Point(20, 375)
        Me.BTN_CargarVenta.Name = "BTN_CargarVenta"
        Me.BTN_CargarVenta.Size = New System.Drawing.Size(134, 46)
        Me.BTN_CargarVenta.TabIndex = 5
        Me.BTN_CargarVenta.Text = "Cargar una venta"
        Me.BTN_CargarVenta.UseVisualStyleBackColor = True
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(4, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(478, 48)
        Me.LBL_Titulo.TabIndex = 6
        Me.LBL_Titulo.Text = "Sistema de admnistracion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Clientes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 48)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Productos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 48)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ventas:"
        '
        'BTN_Informes
        '
        Me.BTN_Informes.Location = New System.Drawing.Point(160, 375)
        Me.BTN_Informes.Name = "BTN_Informes"
        Me.BTN_Informes.Size = New System.Drawing.Size(134, 46)
        Me.BTN_Informes.TabIndex = 10
        Me.BTN_Informes.Text = "Ventas e informes"
        Me.BTN_Informes.UseVisualStyleBackColor = True
        '
        'BTN_IrADatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.BTN_Informes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Controls.Add(Me.BTN_CargarVenta)
        Me.Controls.Add(Me.BTN_AdmClientes)
        Me.Controls.Add(Me.BTN_CargarCliente)
        Me.Controls.Add(Me.BTN_AdmProductos)
        Me.Controls.Add(Me.BTN_CargarProducto)
        Me.Controls.Add(Me.BTN_VerDatos)
        Me.Name = "BTN_IrADatos"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_VerDatos As Button
    Friend WithEvents BTN_CargarProducto As Button
    Friend WithEvents BTN_AdmProductos As Button
    Friend WithEvents BTN_CargarCliente As Button
    Friend WithEvents BTN_AdmClientes As Button
    Friend WithEvents BTN_CargarVenta As Button
    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_Informes As Button
End Class
