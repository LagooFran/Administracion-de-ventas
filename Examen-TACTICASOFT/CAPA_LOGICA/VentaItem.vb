Public Class VentaItem

    Public IDVenta As Integer
    Public IDProducto As Integer
    Public precioUnitario As Double
    Public cantidad As Integer
    Public precioTotal As Double

    Public Sub New(nuevoIDVenta As Integer, nuevoIDProducto As Integer, nuevoPrecioUnitario As Double, nuevaCantidad As Integer)
        IDVenta = nuevoIDVenta
        IDProducto = nuevoIDProducto
        precioUnitario = nuevoPrecioUnitario
        cantidad = nuevaCantidad
        precioTotal = cantidad * precioUnitario
    End Sub
    Public Shared Function Select_Items()
        Dim oVentaItem As New CAPA_DATOS.VentaItem
        Return oVentaItem.Select_Items
    End Function

    Public Function Add_Item() As Integer
        Dim oitem As New CAPA_DATOS.VentaItem
        oitem.Add_Item(IDVenta, IDProducto, precioUnitario, cantidad, precioTotal)
    End Function

End Class
