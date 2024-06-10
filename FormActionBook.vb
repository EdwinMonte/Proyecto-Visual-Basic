Partial Public Class FormActionBook
    Inherits Form

    Private biblioteca As Biblioteca
    Private titulo As String
    Private autor As String
    Private paginas As Integer
    Private precio As Decimal
    Private sucursal As String

    Public Property LibroSeleccionado As Libro

    Public Sub New(titulo As String, autor As String, paginas As Integer, precio As Decimal, sucursal As String)
        InitializeComponent()
        lblTitle.Text = $"Título: {titulo}"
        lblPrice.Text = $"Precio: {precio:C}"
        lblSucursal.Text = $"Sucursal: {sucursal}"
        LibroSeleccionado = New Libro(titulo, autor, paginas, precio, sucursal)
    End Sub

    Private Sub btnToLend_Click(sender As Object, e As EventArgs) Handles btnToLend.Click
        MessageBox.Show($"El libro '{LibroSeleccionado.Titulo}' ha sido prestado.")
        Me.Close()
    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        MessageBox.Show($"El libro '{LibroSeleccionado.Titulo}' ha sido vendido.")
        Me.Close()
    End Sub
End Class
