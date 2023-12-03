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
        db.Close()
        Return clientes
    End Function

    Public Function SelectByID_Cliente(ID As Integer) As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM clientes WHERE ID=@ID", db)
        comm.Parameters.AddWithValue("@ID", ID)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim cliente As New DataTable
        cliente.Load(reader)
        comm.Dispose()
        db.Close()
        Return cliente
    End Function

    Public Function Add_Cliente(cliente As String, telefono As Integer, correo As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("", db)
        comm.CommandText = "INSERT INTO clientes(Cliente,Telefono,Correo) VALUES (@Cliente,@Telefono,@Correo)"
        comm.Parameters.AddWithValue("@Cliente", cliente)
        comm.Parameters.AddWithValue("@Telefono", telefono)
        comm.Parameters.AddWithValue("@Correo", correo)
        comm.ExecuteNonQuery()
        comm.Dispose()
        db.Close()
        Return 0
    End Function

    Public Function FilterByName_Cliente(cliente As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM clientes where Cliente = @Cliente", db)
        comm.Parameters.AddWithValue("@Cliente", cliente)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim clientes As New DataTable
        clientes.Load(reader)
        comm.Dispose()
        db.Close()
        Return clientes
    End Function

    Public Function Delete_Cliente(ID As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("DELETE FROM clientes where ID = @ID", db)
        comm.Parameters.AddWithValue("@ID", ID)
        If MsgBox("Estas seguro de querer borrar el cliente con el ID", MsgBoxStyle.YesNo, "Borrar Cliente") = MsgBoxResult.No Then
            MsgBox("Operacion cancelada")
        Else
            Try
                comm.ExecuteNonQuery()
                MsgBox("Cliente borrado correctamente")
            Catch ex As Exception
                MsgBox("Error al borrar el cliente")
            End Try

        End If

        comm.ExecuteNonQuery()
        db.Close()
        Return 0
    End Function

    Public Function Update_Cliente(cliente As String, telefono As Integer, correo As String, ID As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("UPDATE clientes SET Cliente=@Cliente, Telefono=@Telefono, Correo=@Correo WHERE ID=@ID", db)
        comm.Parameters.AddWithValue("@Cliente", cliente)
        comm.Parameters.AddWithValue("@Telefono", telefono)
        comm.Parameters.AddWithValue("@Correo", correo)
        comm.Parameters.AddWithValue("@ID", ID)

        If MsgBox("Esta seguro que quiere actualizar la informacion del cliente?", MsgBoxStyle.YesNo, "Actualizar informacion") = MsgBoxResult.No Then
            MsgBox("Operacion cancelada")
        Else
            Try
                comm.ExecuteNonQuery()
                MsgBox("Cliente actualizado correctamente")
            Catch ex As Exception
                MsgBox("Error al actualizar el cliente")
            End Try
        End If

        comm.ExecuteNonQuery()
        db.Close()
        Return 0
    End Function

End Class
