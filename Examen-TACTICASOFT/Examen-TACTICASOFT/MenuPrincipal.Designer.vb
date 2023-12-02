<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.TC_Datos = New System.Windows.Forms.TabControl()
        Me.TBP_Clientes = New System.Windows.Forms.TabPage()
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView()
        Me.TBP_Productos = New System.Windows.Forms.TabPage()
        Me.LBL_Datos = New System.Windows.Forms.Label()
        Me.TBP_Ventas = New System.Windows.Forms.TabPage()
        Me.TBP_Items = New System.Windows.Forms.TabPage()
        Me.DGV_Productos = New System.Windows.Forms.DataGridView()
        Me.DGV_Ventas = New System.Windows.Forms.DataGridView()
        Me.DGV_Items = New System.Windows.Forms.DataGridView()
        Me.TC_Datos.SuspendLayout()
        Me.TBP_Clientes.SuspendLayout()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBP_Productos.SuspendLayout()
        Me.TBP_Ventas.SuspendLayout()
        Me.TBP_Items.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TC_Datos
        '
        Me.TC_Datos.Controls.Add(Me.TBP_Clientes)
        Me.TC_Datos.Controls.Add(Me.TBP_Productos)
        Me.TC_Datos.Controls.Add(Me.TBP_Ventas)
        Me.TC_Datos.Controls.Add(Me.TBP_Items)
        Me.TC_Datos.Location = New System.Drawing.Point(12, 72)
        Me.TC_Datos.Name = "TC_Datos"
        Me.TC_Datos.SelectedIndex = 0
        Me.TC_Datos.Size = New System.Drawing.Size(415, 296)
        Me.TC_Datos.TabIndex = 0
        '
        'TBP_Clientes
        '
        Me.TBP_Clientes.Controls.Add(Me.DGV_Clientes)
        Me.TBP_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.TBP_Clientes.Name = "TBP_Clientes"
        Me.TBP_Clientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TBP_Clientes.Size = New System.Drawing.Size(407, 270)
        Me.TBP_Clientes.TabIndex = 0
        Me.TBP_Clientes.Text = "Clientes"
        Me.TBP_Clientes.UseVisualStyleBackColor = True
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Location = New System.Drawing.Point(6, 6)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.Size = New System.Drawing.Size(395, 258)
        Me.DGV_Clientes.TabIndex = 0
        '
        'TBP_Productos
        '
        Me.TBP_Productos.Controls.Add(Me.DGV_Productos)
        Me.TBP_Productos.Location = New System.Drawing.Point(4, 22)
        Me.TBP_Productos.Name = "TBP_Productos"
        Me.TBP_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.TBP_Productos.Size = New System.Drawing.Size(407, 270)
        Me.TBP_Productos.TabIndex = 1
        Me.TBP_Productos.Text = "Productos"
        Me.TBP_Productos.UseVisualStyleBackColor = True
        '
        'LBL_Datos
        '
        Me.LBL_Datos.AutoSize = True
        Me.LBL_Datos.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Datos.Location = New System.Drawing.Point(8, 11)
        Me.LBL_Datos.Name = "LBL_Datos"
        Me.LBL_Datos.Size = New System.Drawing.Size(123, 48)
        Me.LBL_Datos.TabIndex = 1
        Me.LBL_Datos.Text = "Datos"
        '
        'TBP_Ventas
        '
        Me.TBP_Ventas.Controls.Add(Me.DGV_Ventas)
        Me.TBP_Ventas.Location = New System.Drawing.Point(4, 22)
        Me.TBP_Ventas.Name = "TBP_Ventas"
        Me.TBP_Ventas.Size = New System.Drawing.Size(407, 270)
        Me.TBP_Ventas.TabIndex = 2
        Me.TBP_Ventas.Text = "Ventas"
        Me.TBP_Ventas.UseVisualStyleBackColor = True
        '
        'TBP_Items
        '
        Me.TBP_Items.Controls.Add(Me.DGV_Items)
        Me.TBP_Items.Location = New System.Drawing.Point(4, 22)
        Me.TBP_Items.Name = "TBP_Items"
        Me.TBP_Items.Size = New System.Drawing.Size(407, 270)
        Me.TBP_Items.TabIndex = 3
        Me.TBP_Items.Text = "Items (Test)"
        Me.TBP_Items.UseVisualStyleBackColor = True
        '
        'DGV_Productos
        '
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Location = New System.Drawing.Point(6, 6)
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.Size = New System.Drawing.Size(395, 258)
        Me.DGV_Productos.TabIndex = 2
        '
        'DGV_Ventas
        '
        Me.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ventas.Location = New System.Drawing.Point(6, 6)
        Me.DGV_Ventas.Name = "DGV_Ventas"
        Me.DGV_Ventas.Size = New System.Drawing.Size(395, 258)
        Me.DGV_Ventas.TabIndex = 3
        '
        'DGV_Items
        '
        Me.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Items.Location = New System.Drawing.Point(6, 6)
        Me.DGV_Items.Name = "DGV_Items"
        Me.DGV_Items.Size = New System.Drawing.Size(395, 258)
        Me.DGV_Items.TabIndex = 4
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 393)
        Me.Controls.Add(Me.LBL_Datos)
        Me.Controls.Add(Me.TC_Datos)
        Me.Name = "MenuPrincipal"
        Me.Text = "Form1"
        Me.TC_Datos.ResumeLayout(False)
        Me.TBP_Clientes.ResumeLayout(False)
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBP_Productos.ResumeLayout(False)
        Me.TBP_Ventas.ResumeLayout(False)
        Me.TBP_Items.ResumeLayout(False)
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TC_Datos As TabControl
    Friend WithEvents TBP_Clientes As TabPage
    Friend WithEvents TBP_Productos As TabPage
    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents LBL_Datos As Label
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents TBP_Ventas As TabPage
    Friend WithEvents DGV_Ventas As DataGridView
    Friend WithEvents TBP_Items As TabPage
    Friend WithEvents DGV_Items As DataGridView
End Class
