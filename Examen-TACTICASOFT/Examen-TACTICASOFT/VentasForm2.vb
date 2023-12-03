Public Class VentasForm2
    Private productos As New DataTable
    Private productosAgregados As New DataTable
    Private id As Integer
    Private idItem As Integer = 0


    Public Sub New(nuevoID As Integer)
        InitializeComponent()
        id = nuevoID
    End Sub
    Private Sub BTN_Agregar_Click(sender As Object, e As EventArgs) Handles BTN_Agregar.Click
        Dim item As New CAPA_LOGICA.VentaItem(id, CInt(CMBX_ProductoSeleccionado.Text), CDbl(CAPA_LOGICA.Producto.SelectByID_Productos(CInt(CMBX_ProductoSeleccionado.Text)).Item("Precio")), NUD_Cantidad.Value)
        idItem = idItem + 1
        productosAgregados.Rows.Add(idItem, item.IDVenta, item.IDProducto, item.precioUnitario, item.cantidad, item.precioTotal)
        DGV_ProductosAgregados.DataSource = productosAgregados
        Dim idsAgg As New List(Of Integer)
        For Each row As DataRow In productosAgregados.Rows
            idsAgg.Add(row.Item("ID"))
        Next
        CMBX_SeleccionEliminar.DataSource = idsAgg
    End Sub

    Private Sub VentasForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productos = CAPA_LOGICA.Producto.Select_Productos
        DGV_Productos.DataSource = productos
        Dim ids As New List(Of Integer)
        For Each row As DataRow In productos.Rows
            ids.Add(row.Item("ID"))
        Next
        CMBX_ProductoSeleccionado.DataSource = ids
        productosAgregados.Columns.Add("ID", GetType(Integer))
        productosAgregados.Columns.Add("IDVenta", GetType(Integer))
        productosAgregados.Columns.Add("IDProducto", GetType(Integer))
        productosAgregados.Columns.Add("PrecioUnitario", GetType(Double))
        productosAgregados.Columns.Add("Cantidad", GetType(Integer))
        productosAgregados.Columns.Add("PrecioTotal", GetType(Double))
        DGV_ProductosAgregados.DataSource = productosAgregados
    End Sub

    Private Sub BTN_Filtrar_Click(sender As Object, e As EventArgs) Handles BTN_Filtrar.Click
        If String.IsNullOrEmpty(TXB_FiltroNombre.Text) = True And String.IsNullOrEmpty(TXB_FiltroCategoria.Text) = True Then
            productos = CAPA_LOGICA.Producto.Select_Productos
            DGV_Productos.DataSource = productos
            Dim ids As New List(Of Integer)
            For Each row As DataRow In productos.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ProductoSeleccionado.DataSource = ids
        ElseIf String.IsNullOrEmpty(TXB_FiltroNombre.Text) = False And String.IsNullOrEmpty(TXB_FiltroCategoria.Text) = True Then
            productos = CAPA_LOGICA.Producto.FilterByName_Productos(TXB_FiltroNombre.Text)
            DGV_Productos.DataSource = productos
            Dim ids As New List(Of Integer)
            For Each row As DataRow In productos.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ProductoSeleccionado.DataSource = ids
        ElseIf String.IsNullOrEmpty(TXB_FiltroNombre.Text) = True And String.IsNullOrEmpty(TXB_FiltroCategoria.Text) = False Then
            productos = CAPA_LOGICA.Producto.FilterByCategory_Productos(TXB_FiltroCategoria.Text)
            DGV_Productos.DataSource = productos
            Dim ids As New List(Of Integer)
            For Each row As DataRow In productos.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ProductoSeleccionado.DataSource = ids
        ElseIf String.IsNullOrEmpty(TXB_FiltroNombre.Text) = False And String.IsNullOrEmpty(TXB_FiltroCategoria.Text) = False Then
            productos = CAPA_LOGICA.Producto.FilterByCategoryAndName_Productos(TXB_FiltroCategoria.Text, TXB_FiltroNombre.Text)
            DGV_Productos.DataSource = productos
            Dim ids As New List(Of Integer)
            For Each row As DataRow In productos.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ProductoSeleccionado.DataSource = ids
        End If
    End Sub

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        Try
            Dim busqueda As DataRow() = productosAgregados.Select("ID=" + CMBX_SeleccionEliminar.Text)
            productosAgregados.Rows().Remove(busqueda(0))
            productosAgregados.AcceptChanges()
            DGV_ProductosAgregados.DataSource = productosAgregados
            Dim idsAgg As New List(Of Integer)
            For Each row As DataRow In productosAgregados.Rows
                idsAgg.Add(row.Item("ID"))
            Next
            CMBX_SeleccionEliminar.DataSource = idsAgg
        Catch ex As Exception
            MsgBox("No se encontro el producto a borrar")
        End Try

    End Sub

    Private Sub BTN_Siguiente_Click(sender As Object, e As EventArgs) Handles BTN_Siguiente.Click
        Try
            If productosAgregados.Rows.Count = 0 Then
                Throw New Exception
            Else
                Dim final As Double
                For Each row As DataRow In productosAgregados.Rows
                    Dim item As New CAPA_LOGICA.VentaItem(row.Item("IDVenta"), row.Item("IDProducto"), row.Item("PrecioUnitario"), row.Item("Cantidad"))
                    item.Add_Item()
                    final = final + row.Item("PrecioTotal")
                Next
                CAPA_LOGICA.Venta.UpdateTotal_Venta(final, id)
                MsgBox("Venta creada correcatamente")
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error al crear la venta")
        End Try
    End Sub

    Private Sub VentasForm2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Esta seguro que desea cancelar el registro de la venta?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            CAPA_LOGICA.Venta.Delete_Venta(id)
        Else
            e.Cancel = True
        End If
    End Sub
End Class