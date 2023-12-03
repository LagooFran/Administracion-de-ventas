Public Class ClienteForm
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

    Private Sub BTN_SubmitCliente_Click(sender As Object, e As EventArgs) Handles BTN_SubmitCliente.Click
        If modo = 1 Then
            Try
                If String.IsNullOrEmpty(TBX_Nombre.Text) = True Or String.IsNullOrEmpty(TBX_Telefono.Text) = True Or String.IsNullOrEmpty(TBX_Correo.Text) = True Then
                    Throw New Exception
                End If
                Dim cl As New CAPA_LOGICA.Cliente(TBX_Nombre.Text, TBX_Telefono.Text, TBX_Correo.Text)
                cl.Add_Cliente()
                MsgBox("Cliente cargado exitosamente")
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error al cargar el producto revise el ingreso")
            End Try
        End If
        If modo = 2 Then
            Try
                If String.IsNullOrEmpty(TBX_Nombre.Text) = True Or String.IsNullOrEmpty(TBX_Telefono.Text) = True Or String.IsNullOrEmpty(TBX_Correo.Text) = True Then
                    Throw New Exception
                End If
                CAPA_LOGICA.Cliente.Update_Clientes(TBX_Nombre.Text, TBX_Telefono.Text, TBX_Correo.Text, ID)
                Me.Hide()
            Catch ex As Exception
                MsgBox("Error al cargar el producto revise el ingreso")
            End Try
        End If
    End Sub

    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modo = 1 Then
            LBL_Titulo.Text = "Cargar un nuevo" & vbCrLf & "cliente"
            BTN_SubmitCliente.Text = "Cargar cliente"
        End If
        If modo = 2 Then
            LBL_Titulo.Text = "Actualizar un" & vbCrLf & "cliente"
            BTN_SubmitCliente.Text = "Actualizar cliente"
            Dim cliente As DataRow
            cliente = CAPA_LOGICA.Cliente.SelectByID_Clientes(ID)
            TBX_Nombre.Text = cliente.Item("Cliente")
            TBX_Telefono.Text = cliente.Item("Telefono")
            TBX_Correo.Text = cliente.Item("Correo")
        End If
    End Sub

    Private Sub LBL_Titulo_Click(sender As Object, e As EventArgs) Handles LBL_Titulo.Click

    End Sub
End Class