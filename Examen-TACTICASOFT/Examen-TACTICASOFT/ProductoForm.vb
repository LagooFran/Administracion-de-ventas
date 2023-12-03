Public Class ProductoForm

    'modo 1 para crear nuevo modo 2 para actualizar'
    Public modo As Integer
    Public ID As Integer

    Public Sub New(nuevoModo As Integer, nuevoID As Integer)
        InitializeComponent()
        modo = nuevoModo
        ID = nuevoID
    End Sub

    Public Sub New(nuevoModo As Integer)
        InitializeComponent()
        modo = nuevoModo
    End Sub

    Private Sub LBL_Titulo_Click(sender As Object, e As EventArgs) Handles LBL_Titulo.Click

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modo = 1 Then
            LBL_Titulo.Text = "Cargar un nuevo" & vbCrLf & "producto"
            BTN_SubmitProducto.Text = "Cargar producto"
        End If
        If modo = 2 Then
            LBL_Titulo.Text = "Actualizar un" & vbCrLf & "producto"
            BTN_SubmitProducto.Text = "Actualizar producto"
            Dim producto As DataRow
            producto = CAPA_LOGICA.Producto.SelectByID_Productos(ID)
            TBX_Nombre.Text = producto.Item("Nombre")
            TBX_Precio.Text = producto.Item("Precio")
            TBX_Categoria.Text = producto.Item("Categoria")
        End If
    End Sub

    Private Sub BTN_SubmitProducto_Click(sender As Object, e As EventArgs) Handles BTN_SubmitProducto.Click
        If modo = 1 Then
            Try
                If String.IsNullOrEmpty(TBX_Nombre.Text) = True Or String.IsNullOrEmpty(TBX_Precio.Text) = True Or String.IsNullOrEmpty(TBX_Categoria.Text) = True Then
                    Throw New Exception
                End If
                Dim cl As New CAPA_LOGICA.Producto(TBX_Nombre.Text, CDbl(TBX_Precio.Text), TBX_Categoria.Text)
                cl.Add_Producto()
                MsgBox("Producto cargado exitosamente")
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error al cargar el producto revise el ingreso")
            End Try
        End If
        If modo = 2 Then
            Try
                If String.IsNullOrEmpty(TBX_Nombre.Text) = True Or String.IsNullOrEmpty(TBX_Precio.Text) = True Or String.IsNullOrEmpty(TBX_Categoria.Text) = True Then
                    Throw New Exception
                End If
                CAPA_LOGICA.Producto.Update_Producto(TBX_Nombre.Text, CDbl(TBX_Precio.Text), TBX_Categoria.Text, ID)
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error al actualizar el producto revise el ingreso")
            End Try
        End If

    End Sub
End Class