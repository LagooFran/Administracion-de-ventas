Public Class Producto
    Public nombre As String
    Public precio As Double
    Public categoria As String

    Public Sub New(nuevoNombre As String, nuevoPrecio As Double, nuevaCategoria As String)
        nombre = nuevoNombre
        precio = nuevoPrecio
        categoria = nuevaCategoria
    End Sub

    Public Shared Function Select_Productos()
        Dim oProducto As New CAPA_DATOS.Producto
        Return oProducto.Select_Productos
    End Function

    Public Function Add_Producto()
        Dim oProducto As New CAPA_DATOS.Producto
        oProducto.Add_Producto(nombre, precio, categoria)
        Return 0
    End Function
End Class
