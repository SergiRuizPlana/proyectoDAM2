Public Class Form1

    Private currentForm As Form

    Public Sub openForm(form As Form)
        If currentForm IsNot form Then
            If currentForm IsNot Nothing Then currentForm.Close()
            currentForm = form
            currentForm.TopLevel = False
            currentForm.FormBorderStyle = FormBorderStyle.None
            currentForm.Dock = DockStyle.Fill
            Panel4.Controls.Add(currentForm)
            form.BringToFront()
            form.Show()

        End If

    End Sub
    Private Sub Empresas_Click(sender As Object, e As EventArgs) Handles Empresas.Click
        openForm(Empresa)
    End Sub

    Private Sub Contratos_Click(sender As Object, e As EventArgs) Handles Contratos.Click
        openForm(Contrato)
    End Sub

    Private Sub Albaranes_Click(sender As Object, e As EventArgs) Handles Albaranes.Click
        openForm(Albaran)
    End Sub

    Private Sub Test_Click(sender As Object, e As EventArgs) Handles Tests.Click
        openForm(Test)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        startconexion.Visible = False
    End Sub
End Class