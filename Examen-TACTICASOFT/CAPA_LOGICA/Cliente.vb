Public Class Cliente

    Public cliente As String
    Public telefono As String
    Public correo As String

    Public Sub New(nuevoNombre As String, nuevoTelefono As String, nuevaCategoria As String)
        cliente = nuevoNombre
        telefono = nuevoTelefono
        correo = nuevaCategoria
    End Sub

    Public Shared Function Select_Clientes()
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.Select_Clientes
    End Function

    Public Function Add_Cliente()
        Dim oCliente As New CAPA_DATOS.Cliente
        oCliente.Add_Cliente(cliente, CInt(telefono), correo)
        Return 0
    End Function

    Public Shared Function FilterByName_Clientes(cliente As String)
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.FilterByName_Cliente(cliente)
    End Function

    Public Shared Function Delete_Clientes(ID As Integer)
        Dim oCliente As New CAPA_DATOS.Cliente
        oCliente.Delete_Cliente(ID)
        Return 0
    End Function



End Class
