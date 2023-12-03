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

    Public Shared Function SelectByID_Productos(ID As Integer) As DataRow
        Dim oProducto As New CAPA_DATOS.Producto
        Return oProducto.SelectByID_Producto(ID).Select("ID=" & ID).FirstOrDefault
    End Function

    Public Shared Function FilterByName_Productos(nombre As String) As DataTable
        Dim oProducto As New CAPA_DATOS.Producto
        Return oProducto.FilterByName_Producto(nombre)
    End Function

    Public Shared Function FilterByCategory_Productos(categoria As String) As DataTable
        Dim oProducto As New CAPA_DATOS.Producto
        Return oProducto.FilterByCategory_Producto(categoria)
    End Function

    Public Shared Function FilterByCategoryAndName_Productos(categoria As String, nombre As String) As DataTable
        Dim oProducto As New CAPA_DATOS.Producto
        Return oProducto.FilterByCategoryAndName_Producto(categoria, nombre)
    End Function

    Public Shared Function Delete_Productos(ID As Integer)
        Dim oProducto As New CAPA_DATOS.Producto
        oProducto.Delete_Producto(ID)
        Return 0
    End Function

    Public Shared Function Update_Producto(nuevoNombre As String, nuevoPrecio As Double, nuevaCategoria As String, ID As Integer)
        Dim oCliente As New CAPA_DATOS.Producto
        oCliente.Update_Producto(nuevoNombre, nuevoPrecio, nuevaCategoria, ID)
        Return 0
    End Function
End Class
