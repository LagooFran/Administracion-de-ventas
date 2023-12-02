Public Class ProductoForm
    Private Sub LBL_Titulo_Click(sender As Object, e As EventArgs) Handles LBL_Titulo.Click

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_SubmitProducto_Click(sender As Object, e As EventArgs) Handles BTN_SubmitProducto.Click
        Try
            If String.IsNullOrEmpty(TBX_Nombre.Text) = True Or String.IsNullOrEmpty(TBX_Precio.Text) = True Or String.IsNullOrEmpty(TBX_Categoria.Text) = True Then
                Throw New Exception
            End If
            Dim prod As New CAPA_LOGICA.Producto(TBX_Nombre.Text, CDbl(TBX_Precio.Text), TBX_Categoria.Text)
            prod.Add_Producto()
            MsgBox("Producto cargado exitosamente")
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error al cargar el producto revise el ingreso")
        End Try

    End Sub
End Class