Imports System.Data.SqlClient
Imports System.Data
Public Class Producto


    Public Function Select_Productos() As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM productos", db)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim productos As New DataTable
        productos.Load(reader)
        comm.Dispose()
        db.Close()
        Return productos
    End Function

    Public Function Add_Producto(nombre As String, precio As Double, categoria As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("", db)

        comm.CommandText = "INSERT INTO productos(Nombre,Precio,Categoria) VALUES (@Nombre,@Precio,@Categoria)"
        comm.Parameters.AddWithValue("@Nombre", nombre)
        comm.Parameters.AddWithValue("@precio", precio)
        comm.Parameters.AddWithValue("@categoria", categoria)

        comm.ExecuteNonQuery()
        comm.Dispose()
        db.Close()
        Return 0
    End Function


End Class
