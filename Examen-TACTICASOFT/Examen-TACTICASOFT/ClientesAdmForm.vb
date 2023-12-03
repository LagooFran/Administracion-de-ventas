Public Class ClientesAdmForm

    Private clientes As New DataTable

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXB_Filtro.TextChanged

    End Sub

    Private Sub ClientesAdmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientes = CAPA_LOGICA.Cliente.Select_Clientes
        DGV_Clientes.DataSource = clientes
        Dim ids As New List(Of Integer)
        For Each row As DataRow In clientes.Rows
            ids.Add(row.Item("ID"))
        Next
        CMBX_ClienteSeleccionado.DataSource = ids
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentClick

    End Sub

    Private Sub BTN_Filtrar_Click(sender As Object, e As EventArgs) Handles BTN_Filtrar.Click
        If String.IsNullOrEmpty(TXB_Filtro.Text) = True Then
            clientes = CAPA_LOGICA.Cliente.Select_Clientes
            DGV_Clientes.DataSource = clientes
            Dim ids As New List(Of Integer)
            For Each row As DataRow In clientes.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ClienteSeleccionado.DataSource = ids
        Else
            clientes = CAPA_LOGICA.Cliente.FilterByName_Clientes(TXB_Filtro.Text)
            DGV_Clientes.DataSource = clientes
            Dim ids As New List(Of Integer)
            For Each row As DataRow In clientes.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ClienteSeleccionado.DataSource = ids
        End If
    End Sub

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        CAPA_LOGICA.Cliente.Delete_Clientes(CInt(CMBX_ClienteSeleccionado.Text))
        If String.IsNullOrEmpty(TXB_Filtro.Text) = True Then
            clientes = CAPA_LOGICA.Cliente.Select_Clientes
            DGV_Clientes.DataSource = clientes
            Dim ids As New List(Of Integer)
            For Each row As DataRow In clientes.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ClienteSeleccionado.DataSource = ids
        Else
            clientes = CAPA_LOGICA.Cliente.FilterByName_Clientes(TXB_Filtro.Text)
            DGV_Clientes.DataSource = clientes
            Dim ids As New List(Of Integer)
            For Each row As DataRow In clientes.Rows
                ids.Add(row.Item("ID"))
            Next
            CMBX_ClienteSeleccionado.DataSource = ids
        End If
    End Sub

    Private Sub BTN_Modificar_Click(sender As Object, e As EventArgs) Handles BTN_Modificar.Click
        Try
            If String.IsNullOrEmpty(CMBX_ClienteSeleccionado.Text) = False Then
                Dim formClientes As New ClienteForm(2, CInt(CMBX_ClienteSeleccionado.Text))
                formClientes.Show()
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MsgBox("Seleccione un ID de un cliente para modificarlo")
        End Try
    End Sub
End Class