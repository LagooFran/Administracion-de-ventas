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
        Dim oItem As New CAPA_DATOS.VentaItem
        Return oItem.Select_Items
    End Function

    Public Shared Function GetRelatedTo_Items(IDVenta As Integer) As DataTable
        Dim oItem As New CAPA_DATOS.VentaItem
        Return oItem.GetRelatedTo_Item(IDVenta)
    End Function

    Public Shared Function GetRelatedToProd_Items(IDProducto As Integer) As DataTable
        Dim oItem As New CAPA_DATOS.VentaItem
        Return oItem.GetRelatedToProd_Item(IDProducto)
    End Function

    Public Function Add_Item()
        Dim oitem As New CAPA_DATOS.VentaItem
        oitem.Add_Item(IDVenta, IDProducto, precioUnitario, cantidad, precioTotal)
        Return 0
    End Function

    Public Shared Function DeleteRelatedTo_Items(IDVenta As Integer)
        Dim oItem As New CAPA_DATOS.VentaItem
        oItem.DeleteRelatedTo_Item(IDVenta)
        Return 0
    End Function
End Class
