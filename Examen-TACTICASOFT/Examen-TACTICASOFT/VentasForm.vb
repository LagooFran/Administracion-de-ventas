Public Class VentasForm
    Private clientes As New DataTable
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientes = CAPA_LOGICA.Cliente.Select_Clientes
        DGV_Clientes.DataSource = clientes
        Dim ids As New List(Of Integer)
        For Each row As DataRow In clientes.Rows
            ids.Add(row.Item("ID"))
        Next
        CMBX_ClienteSeleccionado.DataSource = ids
    End Sub

    Private Sub BTN_Filtrar_Click(sender As Object, e As EventArgs) Handles BTN_Filtrar.Click
        If String.IsNullOrEmpty(TXB_Filtro.Text) = True Then
            clientes = CAPA_LOGICA.Cliente.Select_Clientes
            DGV_Clientes.DataSource = clientes
            Dim ids As New List(Of Integer)
            For Each row As DataRow In clientes.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ClienteSeleccionado.DataSource = ids
        Else
            clientes = CAPA_LOGICA.Cliente.FilterByName_Clientes(TXB_Filtro.Text)
            DGV_Clientes.DataSource = clientes
            Dim ids As New List(Of Integer)
            For Each row As DataRow In clientes.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ClienteSeleccionado.DataSource = ids
        End If
    End Sub

    Private Sub BTN_Siguiente_Click(sender As Object, e As EventArgs) Handles BTN_Siguiente.Click
        Try
            Dim venta As New CAPA_LOGICA.Venta(CInt(CMBX_ClienteSeleccionado.Text), DTP_Fecha.Value)
            Dim id As Integer
            id = venta.Add_Venta()
            Me.Hide()
            Dim formVentas2 As New VentasForm2(id)
            formVentas2.Show()
        Catch ex As Exception
            MsgBox("Error al inicializar la venta. Selecciono un cliente?")
        End Try

    End Sub

    Private Sub DGV_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentClick

    End Sub
End Class