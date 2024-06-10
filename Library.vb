Imports System.IO
Imports System.Text.Json

Public Class Biblioteca
    Private libros() As Libro
    Private indice As Integer

    Public Sub New(ByVal tamañoMaximo As Integer)
        ReDim libros(tamañoMaximo - 1)
        indice = 0
    End Sub

    Public Function ObtenerLibros() As Libro()
        ' Retorna solo los elementos llenos del arreglo
        Return libros.Where(Function(libro) libro IsNot Nothing).ToArray()
    End Function

    Public Sub AgregarLibro(ByVal libro As Libro)
        If indice < libros.Length Then
            libros(indice) = libro
            indice += 1
        Else
            Throw New InvalidOperationException("No hay espacio para más libros en la biblioteca.")
        End If
    End Sub

    Public Sub EliminarLibro(ByVal libro As Libro)
        For i As Integer = 0 To libros.Length - 1
            If libros(i) IsNot Nothing AndAlso libros(i).Equals(libro) Then
                libros(i) = Nothing
                ' Compactar el arreglo
                For j As Integer = i To libros.Length - 2
                    libros(j) = libros(j + 1)
                Next
                libros(libros.Length - 1) = Nothing
                indice -= 1
                Exit For
            End If
        Next
    End Sub

    Public Shared Sub ExportarAJson(ByVal biblioteca As Biblioteca, ByVal rutaArchivo As String)
        Dim json As String = JsonSerializer.Serialize(biblioteca.libros)
        File.WriteAllText(rutaArchivo, json)
    End Sub
End Class

