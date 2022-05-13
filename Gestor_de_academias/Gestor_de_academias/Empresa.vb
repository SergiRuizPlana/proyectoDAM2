﻿Imports System.Data.SqlClient

Public Class Empresa

    Dim insert = False
    Dim cifEmpresa = ""
    Dim catCreate = False
    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.albara' Puede moverla o quitarla según sea necesario.
        Me.AlbaraTableAdapter.Fill(Me.Gestio_empresesDataSet.albara)

        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)

        Dim controls = {Panel1, Panel2, Panel3}
        Funciones.SetMultyRadius(controls)

        ComboBox1.SelectedValue = ""
        ComboBox1.SelectedText = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles createEmpresa.Click
        createLabel.Text = "Afegir nova empresa"
        EditCat.Visible = False
        categEmpFilter.Visible = False
        Panel2.Visible = False
        createEmpresa.Visible = False
        EditEmpresa.Visible = False
        empresaCif.Text = ""
        empresaNombre.Text = ""
        empresaAdresa.Text = ""
        empresaPhone.Text = ""
        EmpresaEmail.Text = ""
        empresaCif.Enabled = True
        Panel1.Visible = True
        insert = True

    End Sub

    Private Sub SearchEmp_Click(sender As Object, e As EventArgs) Handles searchEmp.Click
        Dim condicion = ""
        'Try
        If cifEmpFilter.Text <> "" Then
                condicion += "where e.cif like '%" & cifEmpFilter.Text & "%' "
            End If

            If nomEmpFilter.Text <> "" Then
                If condicion <> "" Then
                    condicion += " and e.nom like '%" & nomEmpFilter.Text & "%' "
                Else
                    condicion += " where e.nom like '%" & nomEmpFilter.Text & "%' "
                End If
            End If

            If adresaEmpFilter.Text <> "" Then
                If condicion <> "" Then
                    condicion += " and e.adreca like '%" & adresaEmpFilter.Text & "%' "
                Else
                    condicion += "where e.adreca like '%" & adresaEmpFilter.Text & "%' "
                End If
            End If

            If emailEmpFilter.Text <> "" Then
                If condicion <> "" Then
                    condicion += " and e.email like '%" & emailEmpFilter.Text & "%' "
                Else
                    condicion += " where e.email like '%" & emailEmpFilter.Text & "%' "
                End If
            End If

            If ComboBox1.SelectedValue <> "" Then
                If condicion <> "" Then
                    condicion += " and c.descripcio  like '" & ComboBox1.SelectedValue & "' "
                Else
                    condicion += " where c.descripcio  like '" & ComboBox1.SelectedValue & "' "
                End If
            End If

            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("pc_buscarEmpresa", startconexion.myConn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@condicion", SqlDbType.VarChar).Value = condicion

        da.Fill(dt)
            DataGridView1.DataSource = dt
        'Catch ex As Exception
        '    MsgBox("no")
        'End Try

    End Sub

    Private Sub SaveEmpresa_Click(sender As Object, e As EventArgs) Handles SaveEmpresa.Click
        Panel1.Visible = False
        EditCat.Visible = True
        categEmpFilter.Visible = True
        Panel2.Visible = True
        createEmpresa.Visible = True
        EditEmpresa.Visible = True
        Try
            If insert Then
                Me.EmpresaTableAdapter.InsertQuery(empresaCif.Text, empresaNombre.Text, empresaAdresa.Text, CPostal.Text, Ciutat.Text, Regio.Text, Pais.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue)
            Else
                Me.EmpresaTableAdapter.UpdateQuery(empresaNombre.Text, empresaAdresa.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue, cifEmpresa)
            End If
            Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)
            DataGridView1.DataSource = Me.Gestio_empresesDataSet.empresa
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs)
        Panel1.Visible = False
    End Sub

    Private Sub EditEmpresa_Click(sender As Object, e As EventArgs) Handles EditEmpresa.Click
        Try
            Panel1.Visible = True
            EditCat.Visible = False
            categEmpFilter.Visible = False
            Panel2.Visible = False
            createEmpresa.Visible = False
            EditEmpresa.Visible = False
            cifEmpresa = DataGridView1.SelectedRows(0).Cells.Item(0).Value

            createLabel.Text = "Editar " & DataGridView1.SelectedRows(0).Cells.Item(1).Value
            empresaCif.Text = DataGridView1.SelectedRows(0).Cells.Item(0).Value
            empresaCif.Enabled = False
            empresaNombre.Text = DataGridView1.SelectedRows(0).Cells.Item(1).Value
            empresaAdresa.Text = DataGridView1.SelectedRows(0).Cells.Item(2).Value
            empresaPhone.Text = DataGridView1.SelectedRows(0).Cells.Item(3).Value
            EmpresaEmail.Text = DataGridView1.SelectedRows(0).Cells.Item(4).Value

            Dim myCommand = New SqlCommand(" Select cod_categoria from categoria where descripcio=@descripcio ", startconexion.myConn)
            myCommand.Parameters.Add("@descripcio", SqlDbType.VarChar).Value = DataGridView1.SelectedRows(0).Cells.Item(5).Value
            Dim da As New SqlDataAdapter(myCommand)
            Dim dt As New DataTable
            da.Fill(dt)
            empresaCategoria.SelectedValue = dt.Rows(0).Item(0)

            insert = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CancelEmpresa_Click(sender As Object, e As EventArgs) Handles CancelEmpresa.Click
        Panel1.Visible = False
        EditCat.Visible = True
        categEmpFilter.Visible = True
        Panel2.Visible = True
        createEmpresa.Visible = True
        EditEmpresa.Visible = True
    End Sub

    Private Sub RestartFilterEmp_Click(sender As Object, e As EventArgs) Handles RestartFilterEmp.Click
        Try
            cifEmpFilter.Text = ""
            nomEmpFilter.Text = ""
            adresaEmpFilter.Text = ""
            emailEmpFilter.Text = ""
            ComboBox1.SelectedValue = ""
            ComboBox1.SelectedText = ""
            searchEmp.PerformClick()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SaveCat_Click(sender As Object, e As EventArgs) Handles saveCat.Click
        Me.CategoriaTableAdapter.Insert(Guid.NewGuid, catdescripcio.Text)
        Panel3.Visible = False
        CategoriaCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        CategoriaCreate.IconColor = Color.White
        Me.CategoriaTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria)
        catCreate = False
        categEmpFilter.Visible = True
        EditCat.Visible = True
        Panel2.Visible = True
        createEmpresa.Visible = True
        EditEmpresa.Visible = True
        Panel1.Visible = False

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles CategoriaCreate.Click
        If Not catCreate Then
            CategoriaCreate.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
            CategoriaCreate.IconColor = Color.Red
            Panel3.Visible = True
            catCreate = True
        Else
            CategoriaCreate.IconChar = FontAwesome.Sharp.IconChar.Edit
            CategoriaCreate.IconColor = Color.White
            Panel3.Visible = False
            catCreate = False
        End If
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Try
            Me.CategoriaTableAdapter.Delete(ComboBox2.SelectedValue, ComboBox2.Text)
            MsgBox("Categoria eliminada correctament.")

        Catch ex As Exception
            MessageBox.Show("No s'ha pogut esborrar, existeixen empreses que depenen d'aquesta categoria. Assignal's una categoria i esborra-la després.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        TextBox1.Text = ComboBox2.Text
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try
            Me.CategoriaTableAdapter.UpdateQuery(TextBox1.Text, ComboBox2.SelectedValue)
            Me.CategoriaTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria)
            Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)
            DataGridView1.DataSource = Gestio_empresesDataSet.empresa
            RestartFilterEmp.PerformClick()
            Panel3.Visible = False
            categEmpFilter.Visible = True
            Panel2.Visible = True
            createEmpresa.Visible = True
            EditEmpresa.Visible = True
            EditCat.Visible = True
            Panel1.Visible = False
        Catch ex As Exception
            MsgBox("No s'ha pogut actualitzar.")
        End Try

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Panel1.Visible = False
        Panel3.Visible = False
        EditCat.Visible = True
        categEmpFilter.Visible = True
        Panel2.Visible = True
        createEmpresa.Visible = True
        EditEmpresa.Visible = True
    End Sub

    Private Sub EditCat_Click(sender As Object, e As EventArgs) Handles EditCat.Click
        Panel1.Visible = False
        Panel3.Visible = True
        EditCat.Visible = False
        categEmpFilter.Visible = False
        Panel2.Visible = False
        createEmpresa.Visible = False
        EditEmpresa.Visible = False
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EmpresaTableAdapter.FillBy(Me.Gestio_empresesDataSet.empresa)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class