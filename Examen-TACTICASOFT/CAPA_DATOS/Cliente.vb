Imports System.Data.SqlClient
Imports System.Data

Public Class Cliente

    Public Function Select_Clientes() As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM clientes", db)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim clientes As New DataTable
        clientes.Load(reader)
        comm.Dispose()
        db.Dispose()
        Return clientes
    End Function


End Class
