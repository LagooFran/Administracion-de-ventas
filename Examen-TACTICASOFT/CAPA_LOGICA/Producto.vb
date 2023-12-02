Public Class Producto
    Public Shared Function Select_Productos()
        Dim oProducto As New CAPA_DATOS.Producto
        Return oProducto.Select_Productos
    End Function

End Class
