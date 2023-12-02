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

End Class
