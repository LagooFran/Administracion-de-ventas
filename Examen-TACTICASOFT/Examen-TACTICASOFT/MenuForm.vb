Public Class BTN_IrADatos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_VerDatos.Click
        Dim tablas As New TablasForm
        tablas.Show()
    End Sub

    Private Sub BTN_CargarProducto_Click(sender As Object, e As EventArgs) Handles BTN_CargarProducto.Click
        Dim formProductos As New ProductoForm(1)
        formProductos.Show()
    End Sub

    Private Sub BTN_CargarCliente_Click(sender As Object, e As EventArgs) Handles BTN_CargarCliente.Click
        Dim formClientes As New ClienteForm(1)
        formClientes.Show()
    End Sub

    Private Sub BTN_AdmClientes_Click(sender As Object, e As EventArgs) Handles BTN_AdmClientes.Click
        Dim formAdmClientes As New ClientesAdmForm
        formAdmClientes.Show()
    End Sub

    Private Sub BTN_IrADatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_AdmProductos_Click(sender As Object, e As EventArgs) Handles BTN_AdmProductos.Click
        Dim formAdmProductos As New ProductosAdmForm
        formAdmProductos.Show()
    End Sub

    Private Sub BTN_CargarVenta_Click(sender As Object, e As EventArgs) Handles BTN_CargarVenta.Click
        Dim formVentas1 As New VentasForm
        formVentas1.Show()
    End Sub
End Class