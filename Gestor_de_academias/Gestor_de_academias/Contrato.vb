

Public Class Contrato

    Private currentForm As Form
    Dim num_contracte As String
    Dim data As String
    Dim qtyCat As Integer
    Dim okempresa As Integer
    Dim okqty As Integer
    Dim nom As String
    Dim cif As String
    Dim cp As String
    Dim adreca As String
    Dim ciutat As String
    Dim regio As String
    Dim pais As String
    Dim okdelete As Integer

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

        ComboBox1.SelectedIndex = -1

        If Me.Gestio_empresesDataSet.contracte.Rows.Count = 0 Then
            DataGridView1.Visible = False
        End If
        Funciones.SetMultyRadius({Panel1})
        Funciones.SetMultyRadius({Panel6})
        OpenForm(Modelo_contrato)

    End Sub


    Private Sub closeCreateContracte_Click(sender As Object, e As EventArgs) Handles closeCreateContracte.Click
        refresh_all()
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
        okempresa = 0
        If TextSearchEmp.TextLength > 0 Then
            okempresa += 1
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

        If okempresa = 1 And okqty = 1 Then
            Try
                Dim dt As New Gestio_empresesDataSet.contracteDataTable
                Me.ContracteTableAdapter.FillBy(dt, cif)
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("cif").ToString.Contains(cif) Then
                        If MessageBox.Show("Aquesta empresa ja té un contracte en vigor. Vols afegir-ne un altre?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                            Dim datafinal As DateTime = DateTime.Now
                            Dim cod_cont As Integer = Convert.ToInt64(num_contracte)
                            Dim qty As Integer = Convert.ToInt32(TextBoxInsertQtyTest.Text)
                            Me.ContracteTableAdapter.InsertQuery(cod_cont, cif, datafinal, qty, datafinal)
                            Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
                            DataGridView1.DataSource = Gestio_empresesDataSet.contracte
                            MessageBox.Show("Contracte generat correctament.", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim saveFileDialog As New SaveFileDialog()
                            saveFileDialog.DefaultExt = "bmp"
                            saveFileDialog.Filter = "Bitmap files|*.bmp"

                            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                                Dim width As Integer = Panel5.Width
                                Dim height As Integer = Panel5.Height
                                Dim bitMap As New Bitmap(width, height)
                                Dim rec As New Rectangle(0, 0, width, height)
                                Panel5.DrawToBitmap(bitMap, rec)
                                bitMap.Save(saveFileDialog.FileName)
                            End If
                            closeCreateContracte.PerformClick()
                            Exit For
                        Else
                            closeCreateContracte.PerformClick()
                            Exit For
                        End If
                    Else
                        Dim datafinal As DateTime = DateTime.Now
                        Dim cod_cont As Integer = Convert.ToInt64(num_contracte)
                        Dim qty As Integer = Convert.ToInt32(TextBoxInsertQtyTest.Text)
                        Me.ContracteTableAdapter.InsertQuery(cod_cont, cif, datafinal, qty, datafinal)
                        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
                        DataGridView1.DataSource = Gestio_empresesDataSet.contracte
                        MessageBox.Show("Contracte generat correctament.", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim saveFileDialog As New SaveFileDialog()
                        saveFileDialog.DefaultExt = "bmp"
                        saveFileDialog.Filter = "Bitmap files|*.bmp"

                        If saveFileDialog.ShowDialog() = DialogResult.OK Then
                            Dim width As Integer = Panel5.Width
                            Dim height As Integer = Panel5.Height
                            Dim bitMap As New Bitmap(width, height)
                            Dim rec As New Rectangle(0, 0, width, height)
                            Panel5.DrawToBitmap(bitMap, rec)
                            bitMap.Save(saveFileDialog.FileName)
                        End If
                        closeCreateContracte.PerformClick()
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show("Espera uns segons a tornar a fer un contracte amb la mateixa empresa...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else

            MessageBox.Show("Introdueix totes les dades", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            okempresa = 0
            okqty = 0
            refresh_all()
        End If



    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        okqty = 0
        If TextBoxInsertQtyTest.TextLength > 0 Then
            okqty += 1
            Modelo_contrato.Label19.Text = TextBoxInsertQtyTest.Text
            Dim data2() As Char
            Dim datafinal As String
            qtyCat += 1

            data = Date.Now.ToString
            data2 = data.ToCharArray

            For i = 0 To 9
                datafinal = datafinal & data2(i)
            Next
            Modelo_contrato.Label34.Text = datafinal
            num_contracte = data2(0) & data2(1) & data2(3) & data2(4) & data2(8) & data2(9) & data2(11) & data2(12) & data2(14) & data2(15)
            Modelo_contrato.Label32.Text = num_contracte
        Else
            ErrorProvider1.SetError(TextBoxInsertQtyTest, "Si us plau, introdueix una quantitat.")
        End If
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub crearContracte_Click(sender As Object, e As EventArgs) Handles crearContracte.Click

        Panel5.Visible = True
        Panel6.Visible = True

    End Sub

    Private Sub refresh_all()
        Modelo_contrato.Refresh()
        TextSearchEmp.Text = ""
        ComboBoxSearchEmp.SelectedIndex = 0
        okempresa = 0
        TextBoxInsertQtyTest.Text = ""
        okqty = 0
        qtyCat = 0
        Modelo_contrato.Label13.Text = ""
        Modelo_contrato.Label6.Text = ""
        Modelo_contrato.Label12.Text = ""
        Modelo_contrato.Label11.Text = " "
        Modelo_contrato.Label7.Text = ""
        Modelo_contrato.Label19.Text = ""
        Modelo_contrato.Label32.Text = ""
        Modelo_contrato.Label34.Text = ""
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        Dim value As String
        If nomEmpFilter.Text.Length > 0 And ComboBox1.SelectedIndex = -1 Then
            For i = 0 To ComboBox1.Items.Count - 1
                ComboBox1.SelectedIndex = i
                If ComboBox1.Text.ToString.ToLower().Contains(nomEmpFilter.Text) Or ComboBox1.Text.ToString.ToUpper().Contains(nomEmpFilter.Text) Then
                    nomEmpFilter.Text = ComboBox1.Text.ToString
                    value = nomEmpFilter.Text
                    ComboBox1.SelectedIndex = i
                    Exit For
                Else
                    ComboBox1.SelectedIndex = -1
                    value = "1"
                End If
            Next
        ElseIf nomEmpFilter.Text.Length = 0 And ComboBox1.SelectedIndex > -1 Then
            value = ComboBox1.Text
        ElseIf ComboBox1.SelectedIndex = -1 And nomEmpFilter.Text.Length = 0 Then
            value = ""
        End If

        If value <> "" And value <> "1" Then
            cif = Me.EmpresaTableAdapter.GetCif(value).ToString
            Me.ContracteTableAdapter.FillBy(Me.Gestio_empresesDataSet.contracte, cif)
            DataGridView1.DataSource = Me.Gestio_empresesDataSet.contracte
        ElseIf value = "1" Then
            MessageBox.Show("No hi ha cap empresa a la base de dades amb aquest nom", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            IconButton5.PerformClick()
        End If

        If DataGridView1.Rows.Count - 1 = 0 Then
            MessageBox.Show("Empresa donada d'alta, pendent de signar contracte!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub nomEmpFilter_TextChanged(sender As Object, e As EventArgs) Handles nomEmpFilter.TextChanged
        If nomEmpFilter.Text.Length > 0 Then
            ComboBox1.SelectedIndex = -1
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
        DataGridView1.DataSource = Me.Gestio_empresesDataSet.contracte
        nomEmpFilter.Text = ""
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If okdelete = 1 Then
            If MessageBox.Show("Estàs segur de voler esborrar aquest contracte?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Me.ContracteTableAdapter.DeleteQuery(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("CodcontracteDataGridViewTextBoxColumn").Value.ToString)
                Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
                DataGridView1.DataSource = Me.Gestio_empresesDataSet.contracte
                MessageBox.Show("Contracte eliminat correctament.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        okdelete = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        okdelete += 1
        If MessageBox.Show("Vols visualitzar les dades d'aquest contracte?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Try
                okdelete = 0
                Panel5.Visible = True
                closeShowContract.Visible = True
                Dim dt As New Gestio_empresesDataSet.empresaDataTable
                Me.EmpresaTableAdapter.FillBy2(dt, DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("CifDataGridViewTextBoxColumn").Value.ToString)
                nom = dt.Rows(0).Item("nom").ToString
                cif = dt.Rows(0).Item("cif").ToString
                adreca = dt.Rows(0).Item("adreca").ToString
                cp = dt.Rows(0).Item("cp").ToString
                ciutat = dt.Rows(0).Item("ciutat").ToString
                regio = dt.Rows(0).Item("regio").ToString
                pais = dt.Rows(0).Item("pais").ToString

                Modelo_contrato.Label13.Text = nom
                Modelo_contrato.Label6.Text = "CIF: " & cif.ToUpper
                Modelo_contrato.Label12.Text = adreca
                Modelo_contrato.Label11.Text = cp & " " & ciutat
                Modelo_contrato.Label7.Text = regio & " (" & pais & ")"
                Modelo_contrato.Label19.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("TestsmensualsDataGridViewTextBoxColumn").Value.ToString
                Modelo_contrato.Label32.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("CodcontracteDataGridViewTextBoxColumn").Value.ToString
                Modelo_contrato.Label34.Text = CDate(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("FechaultimamodificaioDataGridViewTextBoxColumn").Value).ToString("dd/MM/yyyy")
            Catch
                MessageBox.Show("Error al mostrar el contracte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub closeShowContract_Click(sender As Object, e As EventArgs) Handles closeShowContract.Click
        Panel5.Visible = False
        closeShowContract.Visible = False
    End Sub
End Class