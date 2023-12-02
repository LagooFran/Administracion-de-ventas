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
        db.Dispose()
        Return productos
    End Function


End Class
