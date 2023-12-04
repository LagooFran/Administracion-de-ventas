<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.LBL_Fecha = New System.Windows.Forms.Label()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.TXB_Filtro = New System.Windows.Forms.TextBox()
        Me.LBL_Filtrar = New System.Windows.Forms.Label()
        Me.DGV_Clientes = New System.Windows.Forms.DataGridView()
        Me.LBL_Seleccion = New System.Windows.Forms.Label()
        Me.CMBX_ClienteSeleccionado = New System.Windows.Forms.ComboBox()
        Me.BTN_Siguiente = New System.Windows.Forms.Button()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(280, 41)
        Me.LBL_Titulo.TabIndex = 9
        Me.LBL_Titulo.Text = "Cargar una venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 41)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "1.Informacion Basica"
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.Location = New System.Drawing.Point(19, 138)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(303, 20)
        Me.DTP_Fecha.TabIndex = 11
        '
        'LBL_Fecha
        '
        Me.LBL_Fecha.AutoSize = True
        Me.LBL_Fecha.Location = New System.Drawing.Point(19, 119)
        Me.LBL_Fecha.Name = "LBL_Fecha"
        Me.LBL_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.LBL_Fecha.TabIndex = 12
        Me.LBL_Fecha.Text = "Fecha:"
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Location = New System.Drawing.Point(125, 223)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Filtrar.TabIndex = 16
        Me.BTN_Filtrar.Text = "Filtrar"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'TXB_Filtro
        '
        Me.TXB_Filtro.Location = New System.Drawing.Point(19, 226)
        Me.TXB_Filtro.Name = "TXB_Filtro"
        Me.TXB_Filtro.Size = New System.Drawing.Size(100, 20)
        Me.TXB_Filtro.TabIndex = 15
        '
        'LBL_Filtrar
        '
        Me.LBL_Filtrar.AutoSize = True
        Me.LBL_Filtrar.Location = New System.Drawing.Point(16, 210)
        Me.LBL_Filtrar.Name = "LBL_Filtrar"
        Me.LBL_Filtrar.Size = New System.Drawing.Size(88, 13)
        Me.LBL_Filtrar.TabIndex = 14
        Me.LBL_Filtrar.Text = "Filtrar por nombre"
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Clientes.Location = New System.Drawing.Point(19, 252)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.Size = New System.Drawing.Size(528, 228)
        Me.DGV_Clientes.TabIndex = 13
        '
        'LBL_Seleccion
        '
        Me.LBL_Seleccion.AutoSize = True
        Me.LBL_Seleccion.Location = New System.Drawing.Point(16, 165)
        Me.LBL_Seleccion.Name = "LBL_Seleccion"
        Me.LBL_Seleccion.Size = New System.Drawing.Size(42, 13)
        Me.LBL_Seleccion.TabIndex = 18
        Me.LBL_Seleccion.Text = "Cliente:"
        '
        'CMBX_ClienteSeleccionado
        '
        Me.CMBX_ClienteSeleccionado.FormattingEnabled = True
        Me.CMBX_ClienteSeleccionado.Location = New System.Drawing.Point(19, 181)
        Me.CMBX_ClienteSeleccionado.Name = "CMBX_ClienteSeleccionado"
        Me.CMBX_ClienteSeleccionado.Size = New System.Drawing.Size(303, 21)
        Me.CMBX_ClienteSeleccionado.TabIndex = 17
        '
        'BTN_Siguiente
        '
        Me.BTN_Siguiente.Location = New System.Drawing.Point(369, 138)
        Me.BTN_Siguiente.Name = "BTN_Siguiente"
        Me.BTN_Siguiente.Size = New System.Drawing.Size(154, 64)
        Me.BTN_Siguiente.TabIndex = 19
        Me.BTN_Siguiente.Text = "Siguiente"
        Me.BTN_Siguiente.UseVisualStyleBackColor = True
        '
        'VentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 492)
        Me.Controls.Add(Me.BTN_Siguiente)
        Me.Controls.Add(Me.LBL_Seleccion)
        Me.Controls.Add(Me.CMBX_ClienteSeleccionado)
        Me.Controls.Add(Me.BTN_Filtrar)
        Me.Controls.Add(Me.TXB_Filtro)
        Me.Controls.Add(Me.LBL_Filtrar)
        Me.Controls.Add(Me.DGV_Clientes)
        Me.Controls.Add(Me.LBL_Fecha)
        Me.Controls.Add(Me.DTP_Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "VentasForm"
        Me.Text = "Cargar una venta 1."
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP_Fecha As DateTimePicker
    Friend WithEvents LBL_Fecha As Label
    Friend WithEvents BTN_Filtrar As Button
    Friend WithEvents TXB_Filtro As TextBox
    Friend WithEvents LBL_Filtrar As Label
    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents LBL_Seleccion As Label
    Friend WithEvents CMBX_ClienteSeleccionado As ComboBox
    Friend WithEvents BTN_Siguiente As Button
End Class
