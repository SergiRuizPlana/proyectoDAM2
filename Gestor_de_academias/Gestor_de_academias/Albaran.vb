Imports System.Data.SqlClient
Public Class Albaran

    Private currentForm As Form
    Dim num_alb As String
    Dim codi_producte As String
    Dim nom As String
    Dim cif As String
    Dim adreca As String
    Dim cp As String
    Dim ciutat As String
    Dim regio As String
    Dim pais As String
    Dim telf As String
    Dim email As String
    Dim categoria As String
    Dim baseimp As Decimal
    Dim codcat() As Char
    Dim codi_c As String
    Dim desc_c() As Char
    Dim descompte As Double
    Dim basetotal As Decimal
    Dim ivafinal As Decimal
    Dim perc As Decimal
    Dim sum As Decimal
    Dim percfinal As Decimal
    Dim impostfinal As Decimal
    Dim total As Decimal
    Dim ok1 As Integer
    Dim ok2 As Integer
    Dim dt_final As New Gestio_empresesDataSet.testDataTable
    Dim oldcbc As String
    Dim oldcbt As String
    Dim check As integer

    Public Sub OpenForm(form As Form)
        If currentForm IsNot form Then
            If currentForm IsNot Nothing Then currentForm.Close()
            currentForm = form
            currentForm.TopLevel = False
            currentForm.FormBorderStyle = FormBorderStyle.None
            currentForm.Dock = DockStyle.Fill
            Panel2.Controls.Add(currentForm)
            form.BringToFront()
            form.Show()
        End If

    End Sub


    Private Sub Albaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet1.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter1.Fill(Me.Gestio_empresesDataSet1.empresa)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet1.albara' Puede moverla o quitarla según sea necesario.
        Me.AlbaraTableAdapter.Fill(Me.Gestio_empresesDataSet1.albara)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet1.albara_test' Puede moverla o quitarla según sea necesario.
        Me.Albara_testTableAdapter.Fill(Me.Gestio_empresesDataSet1.albara_test)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet1.albara' Puede moverla o quitarla según sea necesario.
        Me.AlbaraTableAdapter.Fill(Me.Gestio_empresesDataSet1.albara)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter1.Fill(Me.Gestio_empresesDataSet1.empresa)

        Funciones.SetMultyRadius({Panel1})
        Funciones.SetMultyRadius({Panel3})
        OpenForm(Modelo_albaran)

    End Sub

    Private Sub createAlbara_Click(sender As Object, e As EventArgs) Handles createAlbara.Click
        ' Obra els panels que contenen tant el menú per crear l'albarà, com el mateix albarà per ser guardat i poder-lo imprimir.
        Panel3.Visible = True
        Panel2.Visible = True
        ' També emplena el Combobox de les categories dels tests sense repetir valors, ja que per restriccions no em deixava fer-ho amb el propi DataSet.
        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Categoria_testTableAdapter1.Fill(dt)
        Dim cbvalues(dt.Rows.Count - 1) As String
        Dim check As Integer

        For i = 0 To dt.Rows.Count - 1
            If Not dt.Rows(i) Is Nothing Then
                cbvalues(i) = dt.Rows(i).Item("descripcio").ToString
            End If
        Next
        ComboBoxCategoriaTest.Items.Add("")
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
        ComboBoxCategoriaTest.Items.RemoveAt(0)

    End Sub

    Private Sub closeCreateAlbara_Click(sender As Object, e As EventArgs) Handles closeCreateAlbara.Click

        refresh_all()
        Panel3.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub searchAlb_Click(sender As Object, e As EventArgs) Handles searchAlb.Click
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
            cif = Me.EmpresaTableAdapter1.GetCif(value).ToString
            Me.AlbaraTableAdapter.FillBy(Me.Gestio_empresesDataSet1.albara, cif)
            DataGridAlbara.DataSource = Me.Gestio_empresesDataSet1.albara
        ElseIf value = "1" Then
            MessageBox.Show("No hi ha cap empresa a la base de dades amb aquest nom", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RestartFilterAlb.PerformClick()
        End If

        If DataGridAlbara.Rows.Count - 1 = 0 Then
            MessageBox.Show("Empresa donada d'alta, pendent de signar contracte!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub


    Private Sub ComboBoxSearchEmpAlbara_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchEmpAlbara.SelectedIndexChanged

        If ComboBoxSearchEmpAlbara.SelectedIndex > -1 Then

            nom = Me.EmpresaTableAdapter1.GetNom(ComboBoxSearchEmpAlbara.Text)
            cif = Me.EmpresaTableAdapter1.GetCif(ComboBoxSearchEmpAlbara.Text)
            adreca = Me.EmpresaTableAdapter1.GetAddress(ComboBoxSearchEmpAlbara.Text)
            cp = Me.EmpresaTableAdapter1.GetCP(ComboBoxSearchEmpAlbara.Text)
            ciutat = Me.EmpresaTableAdapter1.GetCity(ComboBoxSearchEmpAlbara.Text)
            regio = Me.EmpresaTableAdapter1.GetRegio(ComboBoxSearchEmpAlbara.Text)
            pais = Me.EmpresaTableAdapter1.GetPais(ComboBoxSearchEmpAlbara.Text)
            telf = Me.EmpresaTableAdapter1.GetTelf(ComboBoxSearchEmpAlbara.Text)
            email = Me.EmpresaTableAdapter1.GetEmail(ComboBoxSearchEmpAlbara.Text)

            Modelo_albaran.lblEmpresa.Text = nom
            Modelo_albaran.lblcif.Text = cif
            Modelo_albaran.lblAddress.Text = adreca
            Modelo_albaran.lblCpCity.Text = cp & " " & ciutat
            Modelo_albaran.lblRegionCountry.Text = regio & " (" & pais & ")"
            Modelo_albaran.lblTelf.Text = telf
            Modelo_albaran.lblemail.Text = email

            TextSearchEmpAlbara.Text = ComboBoxSearchEmpAlbara.Text
        End If

    End Sub

    Private Sub ButtonSearchEmpAlb_Click(sender As Object, e As EventArgs) Handles ButtonSearchEmpAlb.Click
        If TextSearchEmpAlbara.Text.Length > 0 Then
            ComboBoxSearchEmpAlbara.SelectedIndex = ComboBoxSearchEmpAlbara.FindString(TextSearchEmpAlbara.Text)
        Else
            ErrorProvider1.SetError(TextSearchEmpAlbara, "Si us plau, introdueix alguna dada")
        End If
    End Sub

    Private Sub TextSearchEmpAlbara_TextChanged(sender As Object, e As EventArgs) Handles TextSearchEmpAlbara.TextChanged
        If TextSearchEmpAlbara.Text.Length > 0 Then
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub ButtonOkEmpresa_Click(sender As Object, e As EventArgs) Handles ButtonOkEmpresa.Click

        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Dim cat() As Char
        Dim data As String
        Dim dat() As Char
        Dim c() As Char
        Dim i As Integer = 0
        data = Date.Now.ToString
        Modelo_albaran.lblDate.Text = data

        If TextSearchEmpAlbara.Text.Length > 0 Then
            ok1 += 1
            categoria = Me.CategoriaTableAdapter1.GetCategoriaEmpresa(ComboBoxSearchEmpAlbara.Text)
            cat = categoria.ToCharArray
            dat = data.ToCharArray
            c = cif.ToCharArray
            num_alb = cat(0).ToString.ToUpper & cat(1).ToString.ToUpper & cat(2).ToString.ToUpper & "-" & dat(0) & dat(1) & dat(3) & dat(4) & dat(8) & dat(9) & dat(11) & dat(12) & dat(14) & dat(15) & "-" & c(0) & c(1) & c(2) & c(3)

            Modelo_albaran.lblnumAlb.Text = num_alb
        Else
            ok1 = 0
            MessageBox.Show("Selecciona una empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub ButtonCreateAlbara_Click(sender As Object, e As EventArgs) Handles ButtonCreateAlbara.Click
        Try

            Dim datafinal As Date = DateTime.Now
            Me.AlbaraTableAdapter.InsertQuery(num_alb, cif, datafinal, total)
            Me.AlbaraTableAdapter.Fill(Me.Gestio_empresesDataSet1.albara)
            DataGridAlbara.DataSource = Gestio_empresesDataSet1.albara
            insertAlbara_test_final()
            MessageBox.Show("Contracte generat correctament.", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.DefaultExt = "bmp"
            saveFileDialog.Filter = "Bitmap files|*.bmp"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim width As Integer = Panel2.Width
                Dim height As Integer = Panel2.Height
                Dim bitMap As New Bitmap(width, height)
                Dim rec As New Rectangle(0, 0, width, height)
                Panel2.DrawToBitmap(bitMap, rec)
                bitMap.Save(saveFileDialog.FileName)
            End If
            ok1 = 0
            ok2 = 0
            closeCreateAlbara.PerformClick()

        Catch
            MessageBox.Show("Revisa les dades introduïdes i clica tots els botons d'acceptar correctament", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchQtyTestAlb_Click(sender As Object, e As EventArgs) Handles SearchQtyTestAlb.Click

        If TextBoxInsertQtyTest.Text.Length > 0 And TextBoxIVAAlb.Text.Length > 0 Then
            If ComboBoxCategoriaTest.Text = oldcbc And ComboBoxTamanyTest.Text = oldcbt Then
                MessageBox.Show("Ja has introduït aquesta categoria a l'albarà, selecciona'n una altra o torna a començar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                insertAlbara_test()
                If check = 0 Then
                    ok2 += 1
                    If TextBoxDiscountAlb.Text.Length = 0 Then
                        TextBoxDiscountAlb.Text = "0"
                    End If
                    codi_c = Me.Categoria_testTableAdapter1.GetCodCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text).ToString
                    codcat = codi_c.ToCharArray
                    desc_c = ComboBoxCategoriaTest.Text.ToCharArray
                    codi_producte = desc_c(0).ToString.ToUpper & desc_c(1).ToString.ToUpper & desc_c(2).ToString.ToUpper & "-" & codcat(0).ToString.ToUpper & codcat(1).ToString.ToUpper & codcat(2).ToString.ToUpper & codcat(3).ToString.ToUpper & codcat(4).ToString.ToUpper & "-" & ComboBoxTamanyTest.Text.ToString
                    descompte = ((Me.Categoria_testTableAdapter1.GetPreuCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text) * TextBoxInsertQtyTest.Text) * TextBoxDiscountAlb.Text) / 100
                    basetotal = (TextBoxInsertQtyTest.Text * Me.Categoria_testTableAdapter1.GetPreuCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text).ToString) - descompte
                    ivafinal = (basetotal * TextBoxIVAAlb.Text) / 100
                    baseimp = baseimp + basetotal
                    Modelo_albaran.DataGridAlbara.Rows.Add(codi_producte, TextBoxInsertQtyTest.Text, Me.Categoria_testTableAdapter1.GetPreuCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text).ToString, TextBoxDiscountAlb.Text, Format(basetotal, "0.00"), TextBoxIVAAlb.Text, Format(ivafinal, "0.00"))
                    For Each row As DataGridViewRow In Modelo_albaran.DataGridAlbara.Rows
                        If Not row Is Nothing Then
                            perc = perc + ((row.Cells("Column6").Value / 100) * row.Cells("Column5").Value)
                            sum = sum + row.Cells("Column5").Value
                        End If
                    Next
                    percfinal = (perc / sum) * 100
                    impostfinal = (baseimp / 100) * percfinal
                    total = baseimp + impostfinal
                    Modelo_albaran.Label20.Text = Format(baseimp, "0.00")
                    Modelo_albaran.Label17.Text = Fix(percfinal)
                    Modelo_albaran.Label27.Text = Format(impostfinal, "0.00")
                    Modelo_albaran.Label13.Text = Format(total, "0.00")
                    oldcbc = ComboBoxCategoriaTest.Text
                    oldcbt = ComboBoxTamanyTest.Text
                Else
                    check = 0
                End If
            End If
                Else
            ok2 = 0
            MessageBox.Show("Completa tots els camps, si us plau.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        perc = 0
        sum = 0
    End Sub


    Private Sub TextBoxInsertQtyTest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInsertQtyTest.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub


    Private Sub RestartFilterAlb_Click(sender As Object, e As EventArgs) Handles RestartFilterAlb.Click
        Me.AlbaraTableAdapter.Fill(Me.Gestio_empresesDataSet1.albara)
        DataGridAlbara.DataSource = Me.Gestio_empresesDataSet1.albara
        nomEmpFilter.Text = ""
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub ComboBoxCategoriaTest_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxCategoriaTest.SelectedIndexChanged
        Dim dt As New Gestio_empresesDataSet.categoria_testDataTable
        Categoria_testTableAdapter1.Fill(dt)
        Categoria_testTableAdapter1.FillBy(dt, ComboBoxCategoriaTest.Text.ToString)
        ComboBoxTamanyTest.DataSource = dt
        ComboBoxTamanyTest.DisplayMember = dt.Columns("tamany").ToString
        ComboBoxTamanyTest.ValueMember = dt.Columns("cod_categoria").ToString

    End Sub

    Private Sub nomEmpFilter_TextChanged(sender As Object, e As EventArgs) Handles nomEmpFilter.TextChanged
        If nomEmpFilter.Text.Length > 0 Then
            ComboBox1.SelectedIndex = -1
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub refresh_all()
        TextSearchEmpAlbara.Text = ""
        ComboBoxSearchEmpAlbara.SelectedIndex = -1
        ComboBoxCategoriaTest.SelectedIndex = -1
        ComboBoxTamanyTest.SelectedIndex = -1
        TextBoxInsertQtyTest.Text = ""
        TextBoxDiscountAlb.Text = "0"
        TextBoxIVAAlb.Text = "21"
        Modelo_albaran.lblnumAlb.Text = ""
        Modelo_albaran.lblemail.Text = ""
        Modelo_albaran.lblEmpresa.Text = ""
        Modelo_albaran.lblAddress.Text = ""
        Modelo_albaran.lblCpCity.Text = ""
        Modelo_albaran.lblRegionCountry.Text = ""
        Modelo_albaran.lblTelf.Text = ""
        Modelo_albaran.lblcif.Text = ""
        Modelo_albaran.lblDate.Text = ""
        Modelo_albaran.Label20.Text = ""
        Modelo_albaran.Label17.Text = ""
        Modelo_albaran.Label27.Text = ""
        Modelo_albaran.Label13.Text = ""
        Modelo_albaran.DataGridAlbara.Rows.Clear()

    End Sub

    Function insertAlbara_test()

        Dim myCommand = New SqlCommand(" SELECT TOP " & TextBoxInsertQtyTest.Text & " t.codi_test, t.cod_categoria, ct.descripcio, ct.tamany, ct.preu 
                                             FROM test t
                                             INNER JOIN categoria_test ct ON ct.cod_categoria = t.cod_categoria
                                             WHERE ct.descripcio = '" & ComboBoxCategoriaTest.Text & "' AND ct.tamany = " & ComboBoxTamanyTest.Text & " 
                                             AND t.codi_test NOT IN(SELECT at.codi_test
					                         FROM albara_test at 
					                         INNER JOIN albara a ON a.num_albara = at.num_albara
					                         AND a.cif = '" & cif & "')", Form1.myConn)

        Dim da As New SqlDataAdapter(myCommand)
        Dim dt As New Gestio_empresesDataSet.testDataTable
        da.Fill(dt)

        If dt.Rows.Count = TextBoxInsertQtyTest.Text Then

            For i = 0 To dt.Rows.Count - 1
                Dim ct As New Guid(dt(i).Item("codi_test").ToString)
                Dim cc As New Guid(dt(i).Item("cod_categoria").ToString)
                dt_final.Rows.Add(ct, cc, dt.Rows(i).Item("descripcio").ToString, dt.Rows(i).Item("tamany").ToString, dt.Rows(i).Item("preu").ToString)
            Next

        Else
            MessageBox.Show("Queden " & dt.Rows.Count & " unitats disponibles en la categoria " & ComboBoxCategoriaTest.Text & "-" & ComboBoxTamanyTest.Text &
                   " per aquesta empresa, ja que les altres ja les ha fet anar o les té en vigor. Canvia el valor de quantitat de tests o comunica-ho", "ALERTA ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            check = 1
        End If


    End Function

    Function insertAlbara_test_final()

        For i = 0 To dt_final.Rows.Count - 1
            Dim ct As New Guid(dt_final(i).Item("codi_test").ToString)
            Me.Albara_testTableAdapter.InsertQuery(num_alb, ct)
        Next


    End Function

End Class