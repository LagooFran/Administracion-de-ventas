Imports System.Data.SqlClient
Imports System.Data
Public Class VentaItem


    Public Function Select_Items() As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM ventasitems", db)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim items As New DataTable
        items.Load(reader)
        comm.Dispose()
        db.Dispose()
        Return items
    End Function

    Public Function Add_Item(IDVenta As Integer, IDProducto As Integer, precioUnitario As Double, cantidad As Integer, precioTotal As Double) As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("", db)

        comm.CommandText = "INSERT INTO ventasitems(IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta,@IDProducto,@PrecioUnitario,@Cantidad,@PrecioTotal)"
        comm.Parameters.AddWithValue("@IDVenta", IDVenta)
        comm.Parameters.AddWithValue("@IDProducto", IDProducto)
        comm.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
        comm.Parameters.AddWithValue("@Cantidad", cantidad)
        comm.Parameters.AddWithValue("@PrecioTotal", precioTotal)

        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim id As New DataTable
        id.Load(reader)
        comm.Dispose()
        db.Close()
        Return id
    End Function

    Public Function GetRelatedTo_Item(IDVenta As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM ventasitems WHERE IDVenta = @IDVenta", db)
        comm.Parameters.AddWithValue("@IDVenta", IDVenta)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim items As New DataTable
        items.Load(reader)
        comm.Dispose()
        db.Close()
        Return items
    End Function

    Public Function GetRelatedToProd_Item(IDProducto As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM ventasitems WHERE IDProducto = @IDProducto", db)
        comm.Parameters.AddWithValue("@IDProducto", IDProducto)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim items As New DataTable
        items.Load(reader)
        comm.Dispose()
        db.Close()
        Return items
    End Function

    Public Function DeleteRelatedTo_Item(IDVenta As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("DELETE FROM ventasitems where IDVenta = @IDVenta", db)
        comm.Parameters.AddWithValue("@IDVenta", IDVenta)
        comm.ExecuteNonQuery()
        db.Close()
        Return 0
    End Function



End Class
