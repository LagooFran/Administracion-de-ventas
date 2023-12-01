Public Class Cliente
    Public Shared Function Select_Clientes()
        Dim oCliente As New CAPA_DATOS.Cliente
        Return oCliente.Select_Clientes
    End Function

End Class
