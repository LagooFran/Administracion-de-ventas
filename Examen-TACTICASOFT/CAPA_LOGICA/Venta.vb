Public Class Venta
    Public idCliente As Integer
    Public fecha As Date
    Public total As Double

    Public Sub New(nuevoCliente As Integer, nuevaFecha As Date)
        idCliente = nuevoCliente
        fecha = nuevaFecha
        total = 0
    End Sub
    Public Shared Function Select_Ventas()
        Dim oVenta As New CAPA_DATOS.Venta
        Return oVenta.Select_Ventas
    End Function
    Public Shared Function UpdateTotal_Venta(nuevoTotal As Double, ID As Integer)
        Dim oVenta As New CAPA_DATOS.Venta
        oVenta.UpdateTotal_Venta(nuevoTotal, ID)
        Return 0
    End Function
    Public Shared Function GetRelatedTo_Ventas(IDCliente As Integer)
        Dim oVenta As New CAPA_DATOS.Venta
        Return oVenta.GetRelatedTo_Venta(IDCliente)
    End Function
    Public Function Add_Venta() As Integer
        Dim oVenta As New CAPA_DATOS.Venta
        Dim id As New DataTable
        id = oVenta.Add_Venta(fecha, idCliente)
        Return CInt(id.Rows(0).Item(0))
    End Function

    Public Shared Function Delete_Venta(ID As Integer)
        Dim oVenta As New CAPA_DATOS.Venta
        oVenta.Delete_Venta(ID)
    End Function
End Class
