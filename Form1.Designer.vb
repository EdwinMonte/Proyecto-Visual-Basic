<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtSucursal = New TextBox()
        lblSucursal = New Label()
        txtPrice = New TextBox()
        lblPrecio = New Label()
        lblPages = New Label()
        lblAuthor = New Label()
        lbltitle = New Label()
        btnSavetxt = New Button()
        btnChargingtxt = New Button()
        btnExportExcel = New Button()
        btnExportWord = New Button()
        btnExportJSON = New Button()
        btnaddbook = New Button()
        txtPaginas = New TextBox()
        txtAutor = New TextBox()
        txtTitulo = New TextBox()
        btnEliminarLibro = New Button()
        lstvLibros = New ListView()
        SuspendLayout()
        ' 
        ' txtSucursal
        ' 
        txtSucursal.Location = New Point(115, 266)
        txtSucursal.Multiline = True
        txtSucursal.Name = "txtSucursal"
        txtSucursal.Size = New Size(125, 34)
        txtSucursal.TabIndex = 65
        ' 
        ' lblSucursal
        ' 
        lblSucursal.AutoSize = True
        lblSucursal.Location = New Point(30, 274)
        lblSucursal.Name = "lblSucursal"
        lblSucursal.Size = New Size(63, 20)
        lblSucursal.TabIndex = 64
        lblSucursal.Text = "Sucursal"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(103, 217)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(137, 34)
        txtPrice.TabIndex = 63
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrecio.Location = New Point(29, 217)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(54, 25)
        lblPrecio.TabIndex = 62
        lblPrecio.Text = "Price"
        ' 
        ' lblPages
        ' 
        lblPages.AutoSize = True
        lblPages.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPages.Location = New Point(21, 165)
        lblPages.Name = "lblPages"
        lblPages.Size = New Size(62, 25)
        lblPages.TabIndex = 61
        lblPages.Text = "Pages"
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAuthor.Location = New Point(21, 112)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(72, 25)
        lblAuthor.TabIndex = 60
        lblAuthor.Text = "Author"
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitle.Location = New Point(21, 62)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(50, 25)
        lbltitle.TabIndex = 59
        lbltitle.Text = "Title"
        ' 
        ' btnSavetxt
        ' 
        btnSavetxt.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSavetxt.Location = New Point(29, 371)
        btnSavetxt.Name = "btnSavetxt"
        btnSavetxt.Size = New Size(125, 38)
        btnSavetxt.TabIndex = 58
        btnSavetxt.Text = "Save txt"
        btnSavetxt.UseVisualStyleBackColor = True
        ' 
        ' btnChargingtxt
        ' 
        btnChargingtxt.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChargingtxt.Location = New Point(30, 415)
        btnChargingtxt.Name = "btnChargingtxt"
        btnChargingtxt.Size = New Size(125, 42)
        btnChargingtxt.TabIndex = 57
        btnChargingtxt.Text = "Charging txt"
        btnChargingtxt.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = Color.Lime
        btnExportExcel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportExcel.Location = New Point(160, 371)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(122, 38)
        btnExportExcel.TabIndex = 56
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnExportWord
        ' 
        btnExportWord.BackColor = SystemColors.Highlight
        btnExportWord.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportWord.Location = New Point(89, 463)
        btnExportWord.Name = "btnExportWord"
        btnExportWord.Size = New Size(122, 44)
        btnExportWord.TabIndex = 55
        btnExportWord.Text = "Export Word"
        btnExportWord.UseVisualStyleBackColor = False
        ' 
        ' btnExportJSON
        ' 
        btnExportJSON.BackColor = SystemColors.GrayText
        btnExportJSON.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportJSON.Location = New Point(161, 415)
        btnExportJSON.Name = "btnExportJSON"
        btnExportJSON.Size = New Size(122, 42)
        btnExportJSON.TabIndex = 54
        btnExportJSON.Text = "Export JSON"
        btnExportJSON.UseVisualStyleBackColor = False
        ' 
        ' btnaddbook
        ' 
        btnaddbook.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnaddbook.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnaddbook.ForeColor = Color.Black
        btnaddbook.Location = New Point(30, 315)
        btnaddbook.Name = "btnaddbook"
        btnaddbook.Size = New Size(219, 34)
        btnaddbook.TabIndex = 53
        btnaddbook.Text = "Add book"
        btnaddbook.UseVisualStyleBackColor = False
        ' 
        ' txtPaginas
        ' 
        txtPaginas.Location = New Point(103, 153)
        txtPaginas.Multiline = True
        txtPaginas.Name = "txtPaginas"
        txtPaginas.Size = New Size(137, 37)
        txtPaginas.TabIndex = 52
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(103, 101)
        txtAutor.Multiline = True
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(137, 36)
        txtAutor.TabIndex = 51
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(89, 53)
        txtTitulo.Multiline = True
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(151, 34)
        txtTitulo.TabIndex = 50
        ' 
        ' btnEliminarLibro
        ' 
        btnEliminarLibro.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminarLibro.Location = New Point(1176, 32)
        btnEliminarLibro.Name = "btnEliminarLibro"
        btnEliminarLibro.Size = New Size(131, 42)
        btnEliminarLibro.TabIndex = 67
        btnEliminarLibro.Text = "Delete book"
        btnEliminarLibro.UseVisualStyleBackColor = True
        ' 
        ' lstvLibros
        ' 
        lstvLibros.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstvLibros.Location = New Point(301, 32)
        lstvLibros.Name = "lstvLibros"
        lstvLibros.Size = New Size(851, 632)
        lstvLibros.TabIndex = 66
        lstvLibros.UseCompatibleStateImageBehavior = False
        lstvLibros.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 707)
        Controls.Add(btnEliminarLibro)
        Controls.Add(lstvLibros)
        Controls.Add(txtSucursal)
        Controls.Add(lblSucursal)
        Controls.Add(txtPrice)
        Controls.Add(lblPrecio)
        Controls.Add(lblPages)
        Controls.Add(lblAuthor)
        Controls.Add(lbltitle)
        Controls.Add(btnSavetxt)
        Controls.Add(btnChargingtxt)
        Controls.Add(btnExportExcel)
        Controls.Add(btnExportWord)
        Controls.Add(btnExportJSON)
        Controls.Add(btnaddbook)
        Controls.Add(txtPaginas)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtSucursal As TextBox
    Private WithEvents lblSucursal As Label
    Private WithEvents txtPrice As TextBox
    Private WithEvents lblPrecio As Label
    Private WithEvents lblPages As Label
    Private WithEvents lblAuthor As Label
    Private WithEvents lbltitle As Label
    Private WithEvents btnSavetxt As Button
    Private WithEvents btnChargingtxt As Button
    Private WithEvents btnExportExcel As Button
    Private WithEvents btnExportWord As Button
    Private WithEvents btnExportJSON As Button
    Private WithEvents btnaddbook As Button
    Private WithEvents txtPaginas As TextBox
    Private WithEvents txtAutor As TextBox
    Private WithEvents txtTitulo As TextBox
    Private WithEvents btnEliminarLibro As Button
    Private WithEvents lstvLibros As ListView

End Class
