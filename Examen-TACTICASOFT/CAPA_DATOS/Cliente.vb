Imports System.Data.SqlClient
Imports System.Data


Public Class Cliente

    Public Function Select_Clientes() As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM clientes")
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim clientes As New DataTable
        clientes.Load(reader)
        Return clientes
        comm.Dispose()
        db.Dispose()
    End Function


End Class
