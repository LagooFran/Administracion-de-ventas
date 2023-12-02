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

End Class
