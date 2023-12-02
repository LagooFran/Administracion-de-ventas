Public Class MenuPrincipal
    Private clientes As New DataTable
    Private productos As New DataTable
    Private ventas As New DataTable
    Private items As New DataTable

    Private Sub DGV_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentClick

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientes = CAPA_LOGICA.Cliente.Select_Clientes
        DGV_Clientes.DataSource = clientes
        productos = CAPA_LOGICA.Producto.Select_Productos
        DGV_Productos.DataSource = productos
        ventas = CAPA_LOGICA.Venta.Select_Ventas
        DGV_Ventas.DataSource = ventas
        items = CAPA_LOGICA.VentaItem.Select_Items
        DGV_Items.DataSource = items
    End Sub
End Class
