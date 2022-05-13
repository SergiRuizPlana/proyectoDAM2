Public Class Form1

    Private currentForm As Form

    Public Sub OpenForm(form As Form)
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
        OpenForm(Empresa)
        Label1.Text = "Empreses"
        Funciones.SetColorToCOntrols({HomeBtn, Empresas, Albaranes, Contratos}, {81, 112, 253})
        sender.BackColor = Color.FromArgb(81, 140, 225)
    End Sub

    Private Sub Contratos_Click(sender As Object, e As EventArgs) Handles Contratos.Click
        OpenForm(Contrato)
        Label1.Text = "Contractes"
        Funciones.SetColorToCOntrols({HomeBtn, Empresas, Albaranes, Contratos}, {81, 112, 253})
        sender.BackColor = Color.FromArgb(81, 140, 225)
    End Sub

    Private Sub Albaranes_Click(sender As Object, e As EventArgs) Handles Albaranes.Click
        OpenForm(Albaran)
        Label1.Text = "Albarans"
        Funciones.SetColorToCOntrols({HomeBtn, Empresas, Albaranes, Contratos}, {81, 112, 253})
        sender.BackColor = Color.FromArgb(81, 140, 225)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.contracte' Puede moverla o quitarla según sea necesario.
        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
        startconexion.Visible = False
    End Sub

    Private Sub HomeB_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        If currentForm IsNot Nothing Then currentForm.Close()
        Funciones.SetColorToCOntrols({HomeBtn, Empresas, Albaranes, Contratos}, {81, 112, 253})
        sender.BackColor = Color.FromArgb(81, 140, 225)

        Label1.Text = "Home"
    End Sub

End Class