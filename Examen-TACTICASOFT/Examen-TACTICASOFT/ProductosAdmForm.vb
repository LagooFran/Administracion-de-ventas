Public Class ProductosAdmForm

    Private productos As New DataTable
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

    Private Sub DGV_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Productos.CellContentClick

    End Sub

    Private Sub ProductosAdmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productos = CAPA_LOGICA.Producto.Select_Productos
        DGV_Productos.DataSource = productos
        Dim ids As New List(Of Integer)
        For Each row As DataRow In productos.Rows
            ids.Add(row.Item("ID"))
        Next
        CMBX_ProductoSeleccionado.DataSource = ids
    End Sub

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        CAPA_LOGICA.Producto.Delete_Productos(CInt(CMBX_ProductoSeleccionado.Text))
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

    Private Sub BTN_Modificar_Click(sender As Object, e As EventArgs) Handles BTN_Modificar.Click
        Try
            If String.IsNullOrEmpty(CMBX_ProductoSeleccionado.Text) = False Then
                Dim formProductos As New ProductoForm(2, CInt(CMBX_ProductoSeleccionado.Text))
                formProductos.Show()
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MsgBox("Seleccione un ID de un producto para modificarlo")
        End Try
    End Sub
End Class