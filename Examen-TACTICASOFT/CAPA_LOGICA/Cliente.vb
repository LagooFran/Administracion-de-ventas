Public Class Cliente

    Public cliente As String
    Public telefono As String
    Public correo As String

    Public Sub New(nuevoNombre As String, nuevoTelefono As String, nuevoCorreo As String)
        cliente = nuevoNombre
        telefono = nuevoTelefono
        correo = nuevoCorreo
    End Sub

    Public Function Add_Cliente()
        Dim oCliente As New CAPA_DATOS.Cliente
        oCliente.Add_Cliente(cliente, CInt(telefono), correo)
        Return 0
    End Function

    Public Shared Function Select_Clientes() As DataTable
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.Select_Clientes
    End Function

    Public Shared Function SelectByID_Clientes(ID As Integer) As DataRow
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.SelectByID_Cliente(ID).Select("ID=" & ID).FirstOrDefault
    End Function

    Public Shared Function FilterByName_Clientes(cliente As String) As DataTable
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.FilterByName_Cliente(cliente)
    End Function

    Public Shared Function Delete_Clientes(ID As Integer)
        Dim oCliente As New CAPA_DATOS.Cliente
        oCliente.Delete_Cliente(ID)
        Return 0
    End Function

    Public Shared Function Update_Clientes(nuevoNombre As String, nuevoTelefono As String, nuevoCorreo As String, ID As Integer)
        Dim oCliente As New CAPA_DATOS.Cliente
        oCliente.Update_Cliente(nuevoNombre, nuevoTelefono, nuevoCorreo, ID)
        Return 0
    End Function

End Class
