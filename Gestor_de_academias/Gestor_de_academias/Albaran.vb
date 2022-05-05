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
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter1.Fill(Me.Gestio_empresesDataSet1.empresa)


        OpenForm(Modelo_albaran)

    End Sub

    Private Sub createAlbara_Click(sender As Object, e As EventArgs) Handles createAlbara.Click
        Panel3.Visible = True
        'ComboBoxCategoriaTest.SelectedIndex = 0

    End Sub

    Private Sub closeCreateAlbara_Click(sender As Object, e As EventArgs) Handles closeCreateAlbara.Click
        Panel3.Visible = False
    End Sub

    Private Sub searchAlb_Click(sender As Object, e As EventArgs) Handles searchAlb.Click
        Dim condicion = ""
        Try
            If cifEmpFilter.Text <> "" Then
                condicion += "where a.cif like '%" & cifEmpFilter.Text & "%' "
            End If

            If numAlbFilter.Text <> "" Then
                If condicion <> "" Then
                    condicion += " and a.num_albara like '%" & numAlbFilter.Text & "%' "
                Else
                    condicion += " where a.num_albara like '%" & numAlbFilter.Text & "%' "
                End If
            End If

            If DataCreacioFilter.Value <> "" Then
                If condicion <> "" Then
                    condicion += " and a.data like '%" & DataCreacioFilter.Value & "%' "
                Else
                    condicion += "where a.data like '%" & DataCreacioFilter.Value & "%' "
                End If
            End If


            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("pc_buscarEmpresa", startconexion.myConn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.Add("@codicion", SqlDbType.VarChar).Value = condicion

            da.Fill(dt)
            DataGridAlbara.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ComboBoxSearchEmpAlbara_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearchEmpAlbara.SelectedIndexChanged

        If ComboBoxSearchEmpAlbara.SelectedIndex > -1 Then

            'Me.EmpresaTableAdapter1.Fill(Me.Gestio_empresesDataSet1.empresa)
            'Modelo_albaran.lblEmpresa.Text = Me.Gestio_empresesDataSet1.empresa.Rows(0)("nom")




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
        Dim cat() As Char
        Dim data As String
        Dim dat() As Char
        Dim c() As Char
        data = Date.Now.ToString
        Modelo_albaran.lblDate.Text = data

        If TextSearchEmpAlbara.Text.Length > 0 Then
            categoria = Me.CategoriaTableAdapter1.GetCategoriaEmpresa(ComboBoxSearchEmpAlbara.Text)
            cat = categoria.ToCharArray
            dat = data.ToCharArray
            c = cif.ToCharArray
            num_alb = cat(0).ToString.ToUpper & cat(1).ToString.ToUpper & cat(2).ToString.ToUpper & "-" & dat(0) & dat(1) & dat(3) & dat(4) & dat(8) & dat(9) & dat(11) & dat(12) & dat(14) & dat(15) & "-" & c(0) & c(1) & c(2) & c(3)

            Modelo_albaran.lblnumAlb.Text = num_alb
        Else
            MsgBox("Selecciona una empresa.")
        End If

    End Sub

    Private Sub ButtonCreateAlbara_Click(sender As Object, e As EventArgs) Handles ButtonCreateAlbara.Click
        ' Fer l'insert 
    End Sub

    Private Sub SearchQtyTestAlb_Click(sender As Object, e As EventArgs) Handles SearchQtyTestAlb.Click
        Dim codcat() As Char
        Dim codi_c As String
        Dim desc_c() As Char
        Dim descompte As Double
        Dim basetotal As Decimal
        Dim ivafinal As Decimal
        If TextBoxInsertQtyTest.Text.Length > 0 Then
            codi_c = Me.Categoria_testTableAdapter1.GetCodCategoria(ComboBoxCategoriaTest.Text).ToString
            codcat = codi_c.ToCharArray
            desc_c = ComboBoxCategoriaTest.Text.ToCharArray
            codi_producte = desc_c(0).ToString.ToUpper & desc_c(1).ToString.ToUpper & desc_c(2).ToString.ToUpper & "-" & codcat(0).ToString.ToUpper & codcat(1).ToString.ToUpper & codcat(2).ToString.ToUpper & codcat(3).ToString.ToUpper & codcat(4).ToString.ToUpper
            descompte = ((Me.Categoria_testTableAdapter1.GetPreuCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text) * TextBoxInsertQtyTest.Text) * TextBoxDiscountAlb.Text) / 100
            basetotal = (TextBoxInsertQtyTest.Text * Me.Categoria_testTableAdapter1.GetPreuCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text).ToString) - descompte
            ivafinal = (basetotal * TextBoxIVAAlb.Text) / 100
            Modelo_albaran.DataGridAlbara.Rows.Add(codi_producte, TextBoxInsertQtyTest.Text, Me.Categoria_testTableAdapter1.GetPreuCategoria(ComboBoxCategoriaTest.Text, ComboBoxTamanyTest.Text).ToString, TextBoxDiscountAlb.Text, Decimal.Round(basetotal, 2), TextBoxIVAAlb.Text, Decimal.Round(ivafinal, 2))

        Else
            ErrorProvider1.SetError(TextBoxInsertQtyTest, "Inserta una quantitat")
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

    Private Sub ComboBoxCategoriaTest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategoriaTest.SelectedIndexChanged

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.Categoria_testTableAdapter1.FillBy1(Me.Gestio_empresesDataSet1.categoria_test)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByDescripcioForComboToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Categoria_testTableAdapter1.FillByDescripcioForCombo(Me.Gestio_empresesDataSet1.categoria_test)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class