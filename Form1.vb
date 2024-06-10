Imports System.IO

Partial Public Class Form1
    Inherits Form

    Private biblioteca As Biblioteca

    Public Sub New()
        InitializeComponent()
        biblioteca = New Biblioteca(100)
        ConfigurarListView()
        ' Configurar columnas del ListView
        lstvLibros.View = View.Details
        lstvLibros.Columns.Add("Título", 150)
        lstvLibros.Columns.Add("Autor", 150)
        lstvLibros.Columns.Add("Páginas", 70)
        lstvLibros.Columns.Add("Precio", 70)
        lstvLibros.Columns.Add("Sucursal", 100)
    End Sub

    Private Sub ConfigurarListView()
        AddHandler lstvLibros.MouseDoubleClick, AddressOf lstvLibros_MouseDoubleClick
    End Sub

    Private Sub btnaddbook_Click(sender As Object, e As EventArgs)
        Dim titulo As String = txtTitulo.Text
        Dim autor As String = txtAutor.Text
        Dim sucursal As String = txtSucursal.Text ' Nueva entrada para la sucursal
        Dim paginas As Integer
        Dim precio As Decimal
        If Integer.TryParse(txtPaginas.Text, paginas) AndAlso Decimal.TryParse(txtPrice.Text, precio) Then
            Dim libro As New Libro(titulo, autor, paginas, precio, sucursal)
            biblioteca.AgregarLibro(libro)
            ActualizarListaLibros()
        Else
            MessageBox.Show("Por favor, ingrese datos válidos para páginas y precio.")
        End If
    End Sub

    Private Sub ActualizarListaLibros()
        lstvLibros.Items.Clear()
        For Each libro In biblioteca.ObtenerLibros()
            Dim item As New ListViewItem(New String() {libro.Titulo, libro.Autor, libro.Paginas.ToString(), libro.Precio.ToString("C"), libro.Sucursal})
            lstvLibros.Items.Add(item)
        Next
    End Sub

    Private Sub LimpiarCampos()
        txtTitulo.Clear()
        txtAutor.Clear()
        txtPaginas.Clear()
        txtPrice.Clear()
        txtSucursal.Clear() ' Limpiar también la sucursal
    End Sub

    Private Sub btnExportJSON_Click(sender As Object, e As EventArgs)
        If lstvLibros.Items.Count = 0 Then
            MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Archivos JSON (*.json)|*.json"
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Biblioteca.ExportarAJson(biblioteca, saveFileDialog.FileName)
            MessageBox.Show("Biblioteca exportada exitosamente.")
        End If
    End Sub

    Private Sub btnExportWord_Click(sender As Object, e As EventArgs)
        If lstvLibros.Items.Count = 0 Then
            MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Archivos Word (*.docx)|*.docx"
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ExportarADocx(biblioteca, saveFileDialog.FileName)
            MessageBox.Show("Biblioteca exportada exitosamente a Word.")
            Process.Start(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs)
        If lstvLibros.Items.Count = 0 Then
            MessageBox.Show("No hay libros para exportar.")
            Return
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx"
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Try
                Exportador.ExportarAExcel(saveFileDialog.FileName, biblioteca.ObtenerLibros)
                MessageBox.Show("Datos exportados exitosamente a Excel.")
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al exportar a Excel: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnChargingtxt_Click(sender As Object, e As EventArgs)
        Try
            Dim openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            If openFileDialog.ShowDialog = DialogResult.OK Then
                CargarDesdeTxt(openFileDialog.FileName)
                MessageBox.Show("Biblioteca cargada exitosamente desde el archivo TXT.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al cargar desde el archivo TXT: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSavetxt_Click(sender As Object, e As EventArgs)
        Try
            Dim saveFileDialog As New SaveFileDialog
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
            If saveFileDialog.ShowDialog = DialogResult.OK Then
                GuardarATxt(saveFileDialog.FileName)
                MessageBox.Show("Biblioteca guardada exitosamente en el archivo TXT.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar en el archivo TXT: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarDesdeTxt(rutaArchivo As String)
        biblioteca = New Biblioteca(100) ' Reiniciar la biblioteca
        Dim lineas() As String = File.ReadAllLines(rutaArchivo)
        For Each linea As String In lineas
            Dim partes() As String = linea.Split(";"c)
            If partes.Length = 5 Then
                Dim titulo As String = partes(0)
                Dim autor As String = partes(1)
                Dim sucursal As String = partes(4)
                Dim paginas As Integer
                Dim precio As Decimal
                If Integer.TryParse(partes(2), paginas) AndAlso Decimal.TryParse(partes(3), precio) Then
                    Dim libro As New Libro(titulo, autor, paginas, precio, sucursal)
                    Try
                        biblioteca.AgregarLibro(libro)
                    Catch ex As InvalidOperationException
                        ' Ignorar si no hay más espacio en la biblioteca
                        Exit For
                    End Try
                End If
            End If
        Next
        ActualizarListaLibros()
    End Sub

    Private Sub GuardarATxt(rutaArchivo As String)
        Dim lineas As New List(Of String)()
        For Each libro As Libro In biblioteca.ObtenerLibros()
            lineas.Add($"{libro.Titulo};{libro.Autor};{libro.Paginas};{libro.Precio};{libro.Sucursal}")
        Next
        File.WriteAllLines(rutaArchivo, lineas)
    End Sub

    Private Sub btnEliminarLibro_Click(sender As Object, e As EventArgs)
        If lstvLibros.SelectedItems.Count > 0 Then
            Dim titulo As String = lstvLibros.SelectedItems(0).Text
            Dim libroAEliminar = biblioteca.ObtenerLibros.FirstOrDefault(Function(l) l.Titulo = titulo)
            If libroAEliminar IsNot Nothing Then
                biblioteca.EliminarLibro(libroAEliminar)
                ActualizarListaLibros()
                MessageBox.Show("Libro eliminado exitosamente.")
            End If
        Else
            MessageBox.Show("Por favor, selecciona un libro para eliminar.")
        End If
    End Sub

    Private Sub lstvLibros_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If lstvLibros.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lstvLibros.SelectedItems(0)
            Dim titulo As String = selectedItem.SubItems(0).Text
            Dim autor As String = selectedItem.SubItems(1).Text
            Dim paginas As Integer = Integer.Parse(selectedItem.SubItems(2).Text)
            Dim precio As Decimal = Decimal.Parse(selectedItem.SubItems(3).Text, System.Globalization.NumberStyles.Currency)
            Dim sucursal As String = selectedItem.SubItems(4).Text

            ' Ocultar Form1
            Me.Hide()

            Dim formAccion As New FormActionBook(titulo, autor, paginas, precio, sucursal)
            formAccion.ShowDialog()

            ' Elimina el libro de la lista después de que el FormActionBook se cierre, asumiendo que se ha vendido o prestado
            biblioteca.EliminarLibro(New Libro(titulo, autor, paginas, precio, sucursal))

            ' Mostrar Form1 nuevamente
            Me.Show()

            ' Actualizar el ListView
            ActualizarListaLibros()
        End If
    End Sub
End Class

