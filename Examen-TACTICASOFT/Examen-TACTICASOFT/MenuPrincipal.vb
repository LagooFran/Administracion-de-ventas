Public Class MenuPrincipal
    Private clientes As New DataTable

    Private Sub DGV_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentClick

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientes = CAPA_LOGICA.Cliente.Select_Clientes
        DGV_Clientes.DataSource = clientes
    End Sub
End Class
