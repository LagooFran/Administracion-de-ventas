Public Class ClienteForm
    Private Sub BTN_SubmitCliente_Click(sender As Object, e As EventArgs) Handles BTN_SubmitCliente.Click
        Try
            If String.IsNullOrEmpty(TBX_Nombre.Text) = True Or String.IsNullOrEmpty(TBX_Telefono.Text) = True Or String.IsNullOrEmpty(TBX_Correo.Text) = True Then
                Throw New Exception
            End If
            Dim cl As New CAPA_LOGICA.Cliente(TBX_Nombre.Text, TBX_Telefono.Text, TBX_Correo.Text)
            cl.Add_Cliente()
            MsgBox("Cliente cargado exitosamente")
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error al cargar el producto revise el ingreso")
        End Try
    End Sub
End Class