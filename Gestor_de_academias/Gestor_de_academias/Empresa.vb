Imports System.Data.SqlClient

Public Class Empresa

    Dim insert = False
    Dim cifEmpresa = ""
    Dim catCreate = False
    Private Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)

        Dim controls = {Panel1, Panel2}
        Funciones.SetMultyRadius(controls)

        ComboBox1.SelectedValue = ""
        ComboBox1.SelectedText = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles createEmpresa.Click

        createLabel.Text = "Crear nueva Empresa"
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
        Try
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
            da.SelectCommand.Parameters.Add("@codicion", SqlDbType.VarChar).Value = condicion

            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SaveEmpresa_Click(sender As Object, e As EventArgs) Handles SaveEmpresa.Click
        Panel1.Visible = False
        Try
            If insert Then
                Me.EmpresaTableAdapter.InsertQuery(empresaCif.Text, empresaNombre.Text, empresaAdresa.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue)
            Else
                Me.EmpresaTableAdapter.UpdateQuery(empresaNombre.Text, empresaAdresa.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue, cifEmpresa)
            End If
            Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Panel1.Visible = False
    End Sub

    Private Sub EditEmpresa_Click(sender As Object, e As EventArgs) Handles EditEmpresa.Click
        Try
            Panel1.Visible = True
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

    Private Sub saveCat_Click(sender As Object, e As EventArgs) Handles saveCat.Click
        Me.CategoriaTableAdapter.Insert(Guid.NewGuid, catdescripcio.Text)
        Panel3.Visible = False

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles CategoriaCreate.Click
        If Not catCreate Then
            CategoriaCreate.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
            CategoriaCreate.IconColor = Color.Red
            Panel2.Visible = True
        End If
    End Sub
End Class