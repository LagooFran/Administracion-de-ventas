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

    Public Function SelectByID_Producto(ID As Integer) As DataTable
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM productos WHERE ID=@ID", db)
        comm.Parameters.AddWithValue("@ID", ID)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim producto As New DataTable
        producto.Load(reader)
        comm.Dispose()
        db.Close()
        Return producto
    End Function

    Public Function FilterByName_Producto(nombre As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM productos where Nombre = @Nombre", db)
        comm.Parameters.AddWithValue("@Nombre", nombre)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim productos As New DataTable
        productos.Load(reader)
        comm.Dispose()
        db.Close()
        Return productos
    End Function

    Public Function FilterByCategory_Producto(categoria As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM productos where Categoria = @Categoria", db)
        comm.Parameters.AddWithValue("@Categoria", categoria)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim productos As New DataTable
        productos.Load(reader)
        comm.Dispose()
        db.Close()
        Return productos
    End Function

    Public Function FilterByCategoryAndName_Producto(categoria As String, nombre As String)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("SELECT * FROM productos where Categoria = @Categoria AND Nombre = @Nombre", db)
        comm.Parameters.AddWithValue("@Categoria", categoria)
        comm.Parameters.AddWithValue("@Nombre", nombre)
        Dim reader As SqlDataReader = comm.ExecuteReader()
        Dim productos As New DataTable
        productos.Load(reader)
        comm.Dispose()
        db.Close()
        Return productos
    End Function
    Public Function Delete_Producto(ID As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("DELETE FROM productos where ID = @ID", db)
        comm.Parameters.AddWithValue("@ID", ID)
        If MsgBox("Estas seguro de querer borrar el producto con el ID", MsgBoxStyle.YesNo, "Borrar producto") = MsgBoxResult.No Then
            MsgBox("Operacion cancelada")
        Else
            Try
                comm.ExecuteNonQuery()
                MsgBox("Producto borrado correctamente")
            Catch ex As Exception
                MsgBox("Error al borrar el producto")
            End Try

        End If

        comm.ExecuteNonQuery()
        db.Close()
        Return 0
    End Function

    Public Function Update_Producto(nombre As String, precio As Double, categoria As String, ID As Integer)
        Dim db As New SqlConnection(My.Settings.Connection)
        db.Open()
        Dim comm As New SqlCommand("UPDATE productos SET Nombre=@Nombre, Precio=@Precio, Categoria=@Categoria WHERE ID=@ID", db)
        comm.Parameters.AddWithValue("@Nombre", nombre)
        comm.Parameters.AddWithValue("@Precio", precio)
        comm.Parameters.AddWithValue("@Categoria", categoria)
        comm.Parameters.AddWithValue("@ID", ID)

        If MsgBox("Esta seguro que quiere actualizar la informacion del producto?", MsgBoxStyle.YesNo, "Actualizar informacion") = MsgBoxResult.No Then
            MsgBox("Operacion cancelada")
        Else
            Try
                comm.ExecuteNonQuery()
                MsgBox("Producto actualizado correctamente")
            Catch ex As Exception
                MsgBox("Error al actualizar el producto")
            End Try
        End If

        comm.ExecuteNonQuery()
        db.Close()
        Return 0
    End Function
End Class
