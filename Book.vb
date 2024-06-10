Public Class Libro
    Public Property Titulo As String
    Public Property Autor As String
    Public Property Paginas As Integer
    Public Property Precio As Decimal
    Public Property Sucursal As String

    Public Sub New(ByVal titulo As String, ByVal autor As String, ByVal paginas As Integer, ByVal precio As Decimal, ByVal sucursal As String)
        Me.Titulo = titulo
        Me.Autor = autor
        Me.Paginas = paginas
        Me.Precio = precio
        Me.Sucursal = sucursal
    End Sub
End Class

