Imports System.Data.SqlClient

Public Class Empresa

    Dim insert = False
    Dim cifEmpresa = ""
    Private Sub empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)

        Funciones.setRadius(Panel1)
        Funciones.setRadius(Panel2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        empresaCif.Text = ""
        empresaNombre.Text = ""
        empresaAdresa.Text = ""
        empresaPhone.Text = ""
        EmpresaEmail.Text = ""
        Panel1.Visible = True
        insert = True
    End Sub

    Private Sub searchEmp_Click(sender As Object, e As EventArgs) Handles searchEmp.Click
        Dim condicion = ""
        If TextBox1.Text <> "" Then
            condicion += "e.cif like '%" & TextBox1.Text & "%' "
        End If

        If TextBox2.Text <> "" Then
            If condicion <> "" Then
                condicion += " and e.nom like '%" & TextBox2.Text & "%' "
            Else
                condicion += " e.nom like '%" & TextBox2.Text & "%' "
            End If
        End If

        If TextBox3.Text <> "" Then
            If condicion <> "" Then
                condicion += " and e.adreca like '%" & TextBox3.Text & "%' "
            Else
                condicion += " e.adreca like '%" & TextBox3.Text & "%' "
            End If
        End If

        If TextBox4.Text <> "" Then
            If condicion <> "" Then
                condicion += " and e.email like '%" & TextBox4.Text & "%' "
            Else
                condicion += " e.email like '%" & TextBox4.Text & "%' "
            End If
        End If

        If ComboBox1.SelectedValue <> "all" Then
            If condicion <> "" Then
                condicion += " and c.descripcio  like '" & ComboBox1.SelectedValue & "' "
            Else
                condicion += " c.descripcio  like '" & ComboBox1.SelectedValue & "' "
            End If
        End If

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("pc_buscarEmpresa", startconexion.myConn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@codicion", SqlDbType.VarChar).Value = condicion

        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
        If insert Then
            Me.EmpresaTableAdapter.InsertQuery(empresaCif.Text, empresaNombre.Text, empresaAdresa.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue)
        Else
            Me.EmpresaTableAdapter.UpdateQuery(empresaNombre.Text, empresaAdresa.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue, cifEmpresa)
        End If
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Panel1.Visible = False
    End Sub

    Private Sub EditEmpresa_Click(sender As Object, e As EventArgs) Handles EditEmpresa.Click

        Panel1.Visible = True
        cifEmpresa = DataGridView1.SelectedRows(0).Cells.Item(0).Value

        empresaCif.Text = DataGridView1.SelectedRows(0).Cells.Item(0).Value
        empresaNombre.Text = DataGridView1.SelectedRows(0).Cells.Item(1).Value
        empresaAdresa.Text = DataGridView1.SelectedRows(0).Cells.Item(2).Value
        empresaPhone.Text = DataGridView1.SelectedRows(0).Cells.Item(3).Value
        EmpresaEmail.Text = DataGridView1.SelectedRows(0).Cells.Item(4).Value
        empresaCategoria.SelectedText = ""
        empresaCategoria.SelectedText = DataGridView1.SelectedRows(0).Cells.Item(5).Value
        insert = False
    End Sub
End Class