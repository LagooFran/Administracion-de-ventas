Public Class Cliente

    Public cliente As String
    Public telefono As String
    Public correo As String

    Public Sub New(nuevoNombre As String, nuevoPrecio As String, nuevaCategoria As String)
        cliente = nuevoNombre
        telefono = nuevoPrecio
        correo = nuevaCategoria
    End Sub

    Public Shared Function Select_Clientes()
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.Select_Clientes
    End Function

    Public Function Add_Cliente()
        Dim oCliente As New CAPA_DATOS.Cliente
        oCliente.Add_Producto(cliente, telefono, correo)
        Return 0
    End Function

End Class
