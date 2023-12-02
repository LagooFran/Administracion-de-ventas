Public Class BTN_IrADatos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tablas As New TablasForm
        tablas.Show()
    End Sub

    Private Sub BTN_CargarProducto_Click(sender As Object, e As EventArgs) Handles BTN_CargarProducto.Click
        Dim formProductos As New ProductoForm
        formProductos.Show()
    End Sub
End Class