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

    Public Function Add_Producto(cliente As String, telefono As Double, correo As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("", db)

        comm.CommandText = "INSERT INTO clientes(Cliente,Telefono,Correo) VALUES (@Cliente,@Telefono,@Correo)"
        comm.Parameters.AddWithValue("@Cliente", cliente)
        comm.Parameters.AddWithValue("@Telefono", telefono)
        comm.Parameters.AddWithValue("@Correo", correo)

        comm.ExecuteNonQuery()

        Return 0
    End Function
End Class
