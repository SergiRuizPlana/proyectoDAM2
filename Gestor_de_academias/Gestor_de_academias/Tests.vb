Public Class Tests

    Dim okcell As Integer
    Dim cod_cat As String
    Private Sub Tests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet2.test' Puede moverla o quitarla según sea necesario.
        Me.TestTableAdapter.Fill(Me.Gestio_empresesDataSet2.test)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet1.test' Puede moverla o quitarla según sea necesario.
        Me.TestTableAdapter.Fill(Me.Gestio_empresesDataSet1.test)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria_test' Puede moverla o quitarla según sea necesario.
        Me.Categoria_testTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria_test)

        Funciones.SetMultyRadius({Panel1})
        Funciones.SetMultyRadius({Panel2})
        Funciones.SetMultyRadius({Panel3})
        Funciones.SetMultyRadius({Panel4})
        fillCombo()

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim value As String
        If nomCategoria.Text.Length > 0 And ComboBoxCategoriaTest.SelectedIndex = -1 Then
            For i = 0 To ComboBoxCategoriaTest.Items.Count - 1
                ComboBoxCategoriaTest.SelectedIndex = i
                If ComboBoxCategoriaTest.Text.ToString.ToLower().Contains(nomCategoria.Text) Or ComboBoxCategoriaTest.Text.ToString.ToUpper().Contains(nomCategoria.Text) Then
                    nomCategoria.Text = ComboBoxCategoriaTest.Text.ToString
                    value = nomCategoria.Text
                    ComboBoxCategoriaTest.SelectedIndex = i
                    Exit For
                Else
                    ComboBoxCategoriaTest.SelectedIndex = -1
                    value = "1"
                End If
            Next
        ElseIf nomCategoria.Text.Length = 0 And ComboBoxCategoriaTest.SelectedIndex > -1 Then
            value = ComboBoxCategoriaTest.Text
        ElseIf ComboBoxCategoriaTest.SelectedIndex = -1 And nomCategoria.Text.Length = 0 Then
            value = ""
        End If

        If value <> "" And value <> "1" Then
            Me.TestTableAdapter.FillBy(Me.Gestio_empresesDataSet.test, value)
            DataGridView1.DataSource = Me.Gestio_empresesDataSet.test
            ComboBoxCategoriaTest.SelectedIndex = -1
            nomCategoria.Text = ""
        ElseIf value = "1" Then
            MessageBox.Show("No hi ha cap categoria a la base de dades amb aquest nom", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxCategoriaTest.SelectedIndex = -1
            nomCategoria.Text = ""
        Else
            IconButton5.PerformClick()
        End If

        If DataGridView1.Rows.Count - 1 = 0 Then
            MessageBox.Show("´Registra una categoria o un test.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub nomCategoria_TextChanged(sender As Object, e As EventArgs) Handles nomCategoria.TextChanged
        If nomCategoria.Text.Length = 0 Then
            ComboBoxCategoriaTest.Enabled = True
        Else
            ComboBoxCategoriaTest.Enabled = False
        End If
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.TestTableAdapter.Fill(Me.Gestio_empresesDataSet.test)
        DataGridView1.DataSource = Me.Gestio_empresesDataSet.test
        nomCategoria.Text = ""
        ComboBoxCategoriaTest.SelectedIndex = -1
        fillCombo()
    End Sub


    Private Sub closeUpdateCategoria_Click(sender As Object, e As EventArgs) Handles closeUpdateCategoria.Click
        Panel2.Visible = False
        IconButton10.PerformClick()
        TextBoxNom.Text = ""
        TextBoxTamany.Text = ""
        TextBoxPreu.Text = ""

        ComboBoxCategoriaTest.Items.Clear()
        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Categoria_testTableAdapter.Fill(dt)
        Dim cbvalues(dt.Rows.Count - 1) As String
        Dim check As Integer
        ComboBoxCategoriaTest.Items.Add("")

        For i = 0 To dt.Rows.Count - 1
            If Not dt.Rows(i) Is Nothing Then
                cbvalues(i) = dt.Rows(i).Item("descripcio").ToString
            End If
        Next
        For i = 0 To cbvalues.Length - 1
            For j = 0 To ComboBoxCategoriaTest.Items.Count - 1
                ComboBoxCategoriaTest.SelectedIndex = j
                If ComboBoxCategoriaTest.Text = cbvalues(i) Then
                    check += 1
                End If
            Next
            If check = 0 Then
                ComboBoxCategoriaTest.Items.Add(cbvalues(i))
            End If
            check = 0
        Next
        ComboBoxCategoriaTest.Items.Remove("")
        ComboBoxCategoriaTest.SelectedIndex = -1

        IconButton5.PerformClick()


    End Sub

    Private Sub SaveEmpresa_Click(sender As Object, e As EventArgs) Handles SaveEmpresa.Click
        Dim check As Boolean = False
        Try
            Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
            Categoria_testTableAdapter.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("descripcio").ToString.Contains(TextBoxNom.Text) And dt.Rows(i).Item("tamany").ToString.Contains(TextBoxTamany.Text) Then
                    check = True
                End If
            Next
            If check = True Then
                MessageBox.Show("Aquesta categoria ja existeix.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.Categoria_testTableAdapter.InsertQuery(TextBoxNom.Text, TextBoxTamany.Text, TextBoxPreu.Text)
                fillCombo()
                MessageBox.Show("Categoria introduïda satisfactòriament.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                closeUpdateCategoria.PerformClick()
            End If
        Catch
            MessageBox.Show("Revisa les dades introduïdes, si us plau.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TextBoxTamany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTamany.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If okcell = 1 Then
            Try
                Dim cc As New Guid(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("codi_test").Value.ToString)
                If MessageBox.Show("Estàs segur de voler esborrar aquest test?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    Me.TestTableAdapter.DeleteQuery(cc)
                    Me.TestTableAdapter.Fill(Me.Gestio_empresesDataSet.test)
                    DataGridView1.DataSource = Me.Gestio_empresesDataSet.test
                    MessageBox.Show("Test eliminat satisfactòriament.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch
                MessageBox.Show("No es pot esborrar aquest test, ja que hi ha usuaris que estàn fent ús d'ell. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Selecciona el codi del test que vols eliminar.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        okcell = 0
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        okcell += 1
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Panel3.Visible = True
        If okcell = 0 Then
            Label14.Text = "Total"
            Label13.Text = Me.TestTableAdapter.GetAlltests.ToString
            Label11.Text = Me.Albara_testTableAdapter.getAllDoneTests.ToString
            Label12.Text = Label13.Text - Label11.Text
            Label10.Text = FormatNumber(((Me.Albara_testTableAdapter.getAllDoneTests * 100) / Me.TestTableAdapter.GetAlltests).ToString, 2) & " %"
        Else
            Label14.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("descripcio").Value.ToString & " - " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("tamany").Value.ToString
            Dim cc As New Guid(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("cod_categoria").Value.ToString)
            Label13.Text = Me.TestTableAdapter.GetAllTestsByCategoria(cc)
            Label11.Text = Me.Albara_testTableAdapter.GetAllDoneByCategoria(cc)
            Label12.Text = Label13.Text - Label11.Text
            Label10.Text = FormatNumber((Label11.Text * 100) / Label13.Text, 2) & " %"
        End If
        okcell = 0
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Panel3.Visible = False
    End Sub

    Private Sub ComboBoxCategoriaTest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategoriaTest.SelectedIndexChanged

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Panel2.Visible = True
        ComboBox2.Items.Clear()
        For Each item As String In ComboBoxCategoriaTest.Items
            ComboBox2.Items.Add(item)
        Next
    End Sub

    Public Sub fillCombo()
        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Categoria_testTableAdapter.Fill(dt)
        Dim cbvalues(dt.Rows.Count - 1) As String
        Dim check As Integer
        ComboBoxCategoriaTest.Items.Add("")

        For i = 0 To dt.Rows.Count - 1
            If Not dt.Rows(i) Is Nothing Then
                cbvalues(i) = dt.Rows(i).Item("descripcio").ToString
            End If
        Next
        For i = 0 To cbvalues.Length - 1
            For j = 0 To ComboBoxCategoriaTest.Items.Count - 1
                ComboBoxCategoriaTest.SelectedIndex = j
                If ComboBoxCategoriaTest.Text = cbvalues(i) Then
                    check += 1
                End If
            Next
            If check = 0 Then
                ComboBoxCategoriaTest.Items.Add(cbvalues(i))
            End If
            check = 0
        Next
        ComboBoxCategoriaTest.Items.Remove("")
        ComboBoxCategoriaTest.SelectedIndex = -1
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Categoria_testTableAdapter.FillBy(dt, ComboBox2.Text)
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i).Item("tamany").ToString)
        Next

    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            Try
                Me.Categoria_testTableAdapter.DeleteQuery(ComboBox2.Text, ComboBox1.Text)
                MessageBox.Show("Categoria eliminada satisfactòriament.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                closeUpdateCategoria.PerformClick()
                fillCombo()
            Catch ex As Exception
                MessageBox.Show("No es pot esborrar aquesta categoria, ja que hi ha tests que la tenen assignada canvial's la categoria i torna-ho a intentar. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Selecciona categoria i tamany. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            GroupBox3.Visible = True
            Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
            Me.Categoria_testTableAdapter.FillBy1(dt, ComboBox2.Text, ComboBox1.Text)
            cod_cat = dt.Rows(0).Item("cod_categoria").ToString
            TextBox1.Text = dt.Rows(0).Item("descripcio").ToString
            TextBox2.Text = dt.Rows(0).Item("tamany").ToString
            TextBox3.Text = dt.Rows(0).Item("preu").ToString
        Else
            MessageBox.Show("Selecciona categoria i tamany. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        GroupBox3.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        Dim cc As New Guid(cod_cat)
        Try
            Me.Categoria_testTableAdapter.UpdateQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text, cc)
            MessageBox.Show("Categoria modificada satisfactòriament.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fillCombo()
            ComboBoxCategoriaTest.SelectedIndex = -1
            closeUpdateCategoria.PerformClick()
        Catch
            MessageBox.Show("No es pot modificar aquesta categoria.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub crearTest_Click(sender As Object, e As EventArgs) Handles crearTest.Click
        Panel4.Visible = True
        ComboBox4.Items.Clear()
        For Each item As String In ComboBoxCategoriaTest.Items
            ComboBox4.Items.Add(item)
        Next

    End Sub

    Private Sub IconButton15_Click(sender As Object, e As EventArgs) Handles IconButton15.Click
        Panel4.Visible = False
        ComboBox4.Text = ""
        ComboBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ComboBox3.Text = ""
        ComboBox3.Items.Clear()
        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Categoria_testTableAdapter.FillBy(dt, ComboBox4.Text)
        For i = 0 To dt.Rows.Count - 1
            ComboBox3.Items.Add(dt.Rows(i).Item("tamany").ToString)
        Next
    End Sub

    Private Sub IconButton16_Click(sender As Object, e As EventArgs) Handles IconButton16.Click
        Dim cc As New Guid()
        Try
            cc = Me.Categoria_testTableAdapter.GetCodCategoria(ComboBox4.Text, ComboBox3.Text)
            For i = 0 To Integer.Parse(TextBox4.Text)
                Me.TestTableAdapter.InsertQuery(cc)
            Next
            DataGridView1.DataSource = Me.Gestio_empresesDataSet.test
            MessageBox.Show("Test insertat satisfactòriament.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IconButton5.PerformClick()
            IconButton15.PerformClick()
        Catch
            MessageBox.Show("No s'ha pogut insertar, selecciona tots els camps requerits.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class