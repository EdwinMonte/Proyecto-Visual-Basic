Imports System.Diagnostics
Imports System.IO
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Newtonsoft.Json

Public Module Exportador
    Public Sub ExportarADocx(biblioteca As Biblioteca, filePath As String)
        Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document)
            Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
            mainPart.Document = New Document()
            Dim body As New Body()

            For Each libro As Libro In biblioteca.ObtenerLibros()
                Dim paragraph As New Paragraph()
                Dim run As New Run()
                run.Append(New Text($"{libro.Titulo}, {libro.Autor}, {libro.Paginas} páginas, {libro.Precio:C}, Sucursal: {libro.Sucursal}"))
                paragraph.Append(run)
                body.Append(paragraph)
            Next

            mainPart.Document.Append(body)
            mainPart.Document.Save()
        End Using

        ' Abre el archivo DOCX
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub

    Public Sub ExportarAExcel(rutaArchivo As String, libros As Libro())
        Using workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Libros")

            worksheet.Cell(1, 1).Value = "Título"
            worksheet.Cell(1, 2).Value = "Autor"
            worksheet.Cell(1, 3).Value = "Páginas"
            worksheet.Cell(1, 4).Value = "Precio"
            worksheet.Cell(1, 5).Value = "Sucursal"

            For i As Integer = 0 To libros.Length - 1
                worksheet.Cell(i + 2, 1).Value = libros(i).Titulo
                worksheet.Cell(i + 2, 2).Value = libros(i).Autor
                worksheet.Cell(i + 2, 3).Value = libros(i).Paginas
                worksheet.Cell(i + 2, 4).Value = libros(i).Precio
                worksheet.Cell(i + 2, 5).Value = libros(i).Sucursal
            Next

            workbook.SaveAs(rutaArchivo)
        End Using

        ' Abre el archivo Excel
        Process.Start(New ProcessStartInfo(rutaArchivo) With {.UseShellExecute = True})
    End Sub

    Public Sub ExportarAJson(biblioteca As Biblioteca, filePath As String)
        Dim json As String = JsonConvert.SerializeObject(biblioteca.ObtenerLibros(), Formatting.Indented)
        File.WriteAllText(filePath, json)

        ' Abre el archivo JSON
        Process.Start(New ProcessStartInfo(filePath) With {.UseShellExecute = True})
    End Sub
End Module

