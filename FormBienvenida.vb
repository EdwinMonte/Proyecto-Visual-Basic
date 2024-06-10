Partial Public Class FormBienvenida
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        ' Validar datos de usuario y almacenarlos en variables o propiedades
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
