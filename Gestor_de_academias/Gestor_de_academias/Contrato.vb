Public Class Contrato
    Private currentForm As Form
    Dim num_contracte As String
    Dim data As String
    Dim qtyCat As Integer
    Dim nom As String
    Dim cif As String
    Dim cp As String
    Dim adreca As String
    Dim ciutat As String
    Dim regio As String
    Dim pais As String

    Public Sub OpenForm(form As Form)
        If currentForm IsNot form Then
            If currentForm IsNot Nothing Then currentForm.Close()
            currentForm = form
            currentForm.TopLevel = False
            currentForm.FormBorderStyle = FormBorderStyle.None
            currentForm.Dock = DockStyle.Fill
            Panel5.Controls.Add(currentForm)
            form.BringToFront()
            form.Show()
        End If

    End Sub
    Private Sub Contrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria_test' Puede moverla o quitarla según sea necesario.
        Me.Categoria_testTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria_test)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.contracte' Puede moverla o quitarla según sea necesario.
        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.contracte' Puede moverla o quitarla según sea necesario.
        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)

        If Me.Gestio_empresesDataSet.contracte.Rows.Count = 0 Then
            DataGridView1.Visible = False
        End If
        Funciones.SetMultyRadius({Panel1})
        OpenForm(Modelo_contrato)

    End Sub


    Private Sub closeCreateAlbara_Click(sender As Object, e As EventArgs) Handles closeCreateAlbara.Click
        Panel5.Visible = False
        Panel6.Visible = False
    End Sub

    Private Sub ButtonSearchEmp_Click(sender As Object, e As EventArgs) Handles ButtonSearchEmp.Click


        If TextSearchEmp.Text.Length > 0 Then
            ComboBoxSearchEmp.SelectedIndex = ComboBoxSearchEmp.FindString(TextSearchEmp.Text)
        Else
            ErrorProvider1.SetError(TextSearchEmp, "Si us plau, introdueix alguna dada")
        End If



    End Sub

    Private Sub ButtonOkEmpresa_Click(sender As Object, e As EventArgs) Handles ButtonOkEmpresa.Click

        If TextSearchEmp.TextLength > 0 Then

            nom = Me.EmpresaTableAdapter.GetNom(ComboBoxSearchEmp.Text)
            cif = Me.EmpresaTableAdapter.GetCif(ComboBoxSearchEmp.Text)
            adreca = Me.EmpresaTableAdapter.GetAddress(ComboBoxSearchEmp.Text)
            cp = Me.EmpresaTableAdapter.GetCP(ComboBoxSearchEmp.Text)
            ciutat = Me.EmpresaTableAdapter.GetCity(ComboBoxSearchEmp.Text)
            regio = Me.EmpresaTableAdapter.GetRegio(ComboBoxSearchEmp.Text)
            pais = Me.EmpresaTableAdapter.GetPais(ComboBoxSearchEmp.Text)

            Modelo_contrato.Label13.Text = nom
            Modelo_contrato.Label6.Text = "CIF: " & cif.ToUpper
            Modelo_contrato.Label12.Text = adreca
            Modelo_contrato.Label11.Text = cp & " " & ciutat
            Modelo_contrato.Label7.Text = regio & " (" & pais & ")"

        Else
            ErrorProvider1.SetError(TextSearchEmp, "Si us plau, introdueix alguna dada")
        End If
    End Sub

    Private Sub TextSearchEmp_TextChanged(sender As Object, e As EventArgs) Handles TextSearchEmp.TextChanged
        If TextSearchEmp.Text.Length > 0 Then
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBoxInsertQtyTest_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInsertQtyTest.TextChanged
        If TextBoxInsertQtyTest.Text.Length > 0 Then
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBoxInsertQtyTest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInsertQtyTest.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub ComboBoxSearchEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchEmp.SelectedIndexChanged
        TextSearchEmp.Text = ComboBoxSearchEmp.Text
    End Sub

    Private Sub ButtonCreateContract_Click(sender As Object, e As EventArgs) Handles ButtonCreateContract.Click
        Dim datafinal As DateTime = DateTime.Now
        Dim cod_cont As Integer = Convert.ToInt64(num_contracte)
        Dim qty As Integer = Convert.ToInt32(TextBoxInsertQtyTest.Text)
        Try
            Me.ContracteTableAdapter.InsertQuery(cod_cont, cif, datafinal, qty, datafinal)
            Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
            DataGridView1.DataSource = Gestio_empresesDataSet.contracte

            MsgBox("El contracte s'ha generat correctament.")
        Catch ex As Exception
            MsgBox("Error. Revisa les dades introduides...")
        End Try

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If TextBoxInsertQtyTest.TextLength > 0 Then
            Modelo_contrato.Label19.Text = TextBoxInsertQtyTest.Text
        Else
            ErrorProvider1.SetError(TextBoxInsertQtyTest, "Si us plau, introdueix una quantitat.")
        End If
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim data2() As Char
        Dim datafinal As String
        qtyCat += 1
        If qtyCat = 1 Then
            Modelo_contrato.Label22.Text = ComboBoxCategoriaTest.Text
        ElseIf qtyCat = 2 Then
            Modelo_contrato.Label23.Text = ComboBoxCategoriaTest.Text
        ElseIf qtyCat = 3 Then
            Modelo_contrato.Label24.Text = ComboBoxCategoriaTest.Text
        ElseIf qtyCat = 4 Then
            Modelo_contrato.Label25.Text = ComboBoxCategoriaTest.Text
        ElseIf qtyCat = 5 Then
            Modelo_contrato.Label26.Text = ComboBoxCategoriaTest.Text
        ElseIf qtyCat > 5 Then
            MsgBox("No es poden afegir mes categories.")
        End If

        data = Date.Now.ToString
        data2 = data.ToCharArray

        For i = 0 To 9
            datafinal = datafinal & data2(i)
        Next
        Modelo_contrato.Label34.Text = datafinal
        num_contracte = data2(0) & data2(1) & data2(3) & data2(4) & data2(8) & data2(9) & data2(11) & data2(12) & data2(14) & data2(15)
        Modelo_contrato.Label32.Text = num_contracte

    End Sub

    Private Sub crearContracte_Click(sender As Object, e As EventArgs) Handles crearContracte.Click
        Panel5.Visible = True
        Panel6.Visible = True
    End Sub
End Class