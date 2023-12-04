Imports System.Data.SqlClient
Imports System.Data
Public Class Venta

    Public Function Select_Ventas() As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM ventas", db)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim ventas As New DataTable
        ventas.Load(reader)
        comm.Dispose()
        db.Dispose()
        Return ventas
    End Function

    Public Function Add_Venta(fecha As Date, idCliente As Integer) As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("", db)

        comm.CommandText = "INSERT INTO ventas(IDCliente,Fecha,Total) VALUES (@IDCliente,@Fecha,@Total) SELECT SCOPE_IDENTITY()"
        comm.Parameters.AddWithValue("@IDCliente", idCliente)
        comm.Parameters.AddWithValue("@Fecha", fecha)
        comm.Parameters.AddWithValue("@Total", 0)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim id As New DataTable
        id.Load(reader)
        comm.Dispose()
        db.Close()
        Return id
    End Function

    Public Function UpdateTotal_Venta(total As Double, ID As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("UPDATE ventas SET Total=@Total WHERE ID=@ID", db)
        comm.Parameters.AddWithValue("@Total", total)
        comm.Parameters.AddWithValue("@ID", ID)
        comm.ExecuteNonQuery()
        comm.Dispose()
        db.Close()
        Return 0
    End Function

    Public Function Delete_Venta(ID As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("DELETE FROM ventas where ID = @ID", db)
        comm.Parameters.AddWithValue("@ID", ID)
        comm.ExecuteNonQuery()
        db.Close()
        Return 0
    End Function

    Public Function GetRelatedTo_Venta(IDCliente As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM ventas WHERE IDCliente = @IDCliente", db)
        comm.Parameters.AddWithValue("@IDCliente", IDCliente)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim ventas As New DataTable
        ventas.Load(reader)
        comm.Dispose()
        db.Close()
        Return ventas
    End Function

End Class
