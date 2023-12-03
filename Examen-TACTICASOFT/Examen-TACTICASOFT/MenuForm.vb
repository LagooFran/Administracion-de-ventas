Public Class BTN_IrADatos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_VerDatos.Click
        Dim tablas As New TablasForm
        tablas.Show()
    End Sub

    Private Sub BTN_CargarProducto_Click(sender As Object, e As EventArgs) Handles BTN_CargarProducto.Click
        Dim formProductos As New ProductoForm
        formProductos.Show()
    End Sub

    Private Sub BTN_CargarCliente_Click(sender As Object, e As EventArgs) Handles BTN_CargarCliente.Click
        Dim formClientes As New ClienteForm
        formClientes.Show()
    End Sub

    Private Sub BTN_AdmClientes_Click(sender As Object, e As EventArgs) Handles BTN_AdmClientes.Click
        Dim formAdmClientes As New ClientesAdmForm
        formAdmClientes.Show()
    End Sub
End Class