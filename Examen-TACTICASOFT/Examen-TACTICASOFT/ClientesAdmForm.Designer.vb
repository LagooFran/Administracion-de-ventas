<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesAdmForm
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
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView()
        Me.LBL_Filtrar = New System.Windows.Forms.Label()
        Me.TXB_Filtro = New System.Windows.Forms.TextBox()
        Me.CMBX_ClienteSeleccionado = New System.Windows.Forms.ComboBox()
        Me.BTN_Eliminar = New System.Windows.Forms.Button()
        Me.BTN_Modificar = New System.Windows.Forms.Button()
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.LBL_Seleccion = New System.Windows.Forms.Label()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Location = New System.Drawing.Point(12, 130)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.Size = New System.Drawing.Size(528, 228)
        Me.DGV_Clientes.TabIndex = 0
        '
        'LBL_Filtrar
        '
        Me.LBL_Filtrar.AutoSize = True
        Me.LBL_Filtrar.Location = New System.Drawing.Point(9, 88)
        Me.LBL_Filtrar.Name = "LBL_Filtrar"
        Me.LBL_Filtrar.Size = New System.Drawing.Size(88, 13)
        Me.LBL_Filtrar.TabIndex = 1
        Me.LBL_Filtrar.Text = "Filtrar por nombre"
        '
        'TXB_Filtro
        '
        Me.TXB_Filtro.Location = New System.Drawing.Point(12, 104)
        Me.TXB_Filtro.Name = "TXB_Filtro"
        Me.TXB_Filtro.Size = New System.Drawing.Size(100, 20)
        Me.TXB_Filtro.TabIndex = 2
        '
        'CMBX_ClienteSeleccionado
        '
        Me.CMBX_ClienteSeleccionado.FormattingEnabled = True
        Me.CMBX_ClienteSeleccionado.Location = New System.Drawing.Point(199, 102)
        Me.CMBX_ClienteSeleccionado.Name = "CMBX_ClienteSeleccionado"
        Me.CMBX_ClienteSeleccionado.Size = New System.Drawing.Size(121, 21)
        Me.CMBX_ClienteSeleccionado.TabIndex = 3
        '
        'BTN_Eliminar
        '
        Me.BTN_Eliminar.Location = New System.Drawing.Point(326, 102)
        Me.BTN_Eliminar.Name = "BTN_Eliminar"
        Me.BTN_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Eliminar.TabIndex = 4
        Me.BTN_Eliminar.Text = "Eliminar"
        Me.BTN_Eliminar.UseVisualStyleBackColor = True
        '
        'BTN_Modificar
        '
        Me.BTN_Modificar.Location = New System.Drawing.Point(407, 102)
        Me.BTN_Modificar.Name = "BTN_Modificar"
        Me.BTN_Modificar.Size = New System.Drawing.Size(133, 23)
        Me.BTN_Modificar.TabIndex = 5
        Me.BTN_Modificar.Text = "Modificar informacion"
        Me.BTN_Modificar.UseVisualStyleBackColor = True
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(4, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(170, 48)
        Me.LBL_Titulo.TabIndex = 8
        Me.LBL_Titulo.Text = "Clientes:"
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Location = New System.Drawing.Point(118, 101)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Filtrar.TabIndex = 9
        Me.BTN_Filtrar.Text = "Filtrar"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'LBL_Seleccion
        '
        Me.LBL_Seleccion.AutoSize = True
        Me.LBL_Seleccion.Location = New System.Drawing.Point(196, 86)
        Me.LBL_Seleccion.Name = "LBL_Seleccion"
        Me.LBL_Seleccion.Size = New System.Drawing.Size(107, 13)
        Me.LBL_Seleccion.TabIndex = 10
        Me.LBL_Seleccion.Text = "Cliente Seleccionado"
        '
        'ClientesAdmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 375)
        Me.Controls.Add(Me.LBL_Seleccion)
        Me.Controls.Add(Me.BTN_Filtrar)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Controls.Add(Me.BTN_Modificar)
        Me.Controls.Add(Me.BTN_Eliminar)
        Me.Controls.Add(Me.CMBX_ClienteSeleccionado)
        Me.Controls.Add(Me.TXB_Filtro)
        Me.Controls.Add(Me.LBL_Filtrar)
        Me.Controls.Add(Me.DGV_Clientes)
        Me.Name = "ClientesAdmForm"
        Me.Text = "ClientesAdmForm"
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents LBL_Filtrar As Label
    Friend WithEvents TXB_Filtro As TextBox
    Friend WithEvents CMBX_ClienteSeleccionado As ComboBox
    Friend WithEvents BTN_Eliminar As Button
    Friend WithEvents BTN_Modificar As Button
    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents BTN_Filtrar As Button
    Friend WithEvents LBL_Seleccion As Label
End Class
