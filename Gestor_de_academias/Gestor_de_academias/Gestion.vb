Imports System.Data.SqlClient

Public Class Gestion
    Private Sub empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Application.DoEvents()
        While DataGridView1.Width > 600
            DataGridView1.Width -= 10
            Threading.Thread.Sleep(10)
        End While
        Panel1.Visible = True


        'Empresa.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        My.Application.DoEvents()

        While DataGridView1.Width < 1000
            DataGridView1.Width += 5
            Threading.Thread.Sleep(1)
        End While
        Dim a = empresaCategoria.SelectedValue.ToString
        Me.EmpresaTableAdapter.InsertQuery(empresaCif.Text, empresaNombre.Text, empresaAdresa.Text, empresaPhone.Text, EmpresaEmail.Text, empresaCategoria.SelectedValue)
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Panel1.Visible = False
        My.Application.DoEvents()

        While DataGridView1.Width < 1000
            DataGridView1.Width += 5
            Threading.Thread.Sleep(1)
        End While
    End Sub

    Private Sub EditEmpresa_Click(sender As Object, e As EventArgs) Handles EditEmpresa.Click
        Dim empresaCif = DataGridView1.SelectedRows(0).Cells.Item(0).Value
        Dim a = 0
    End Sub
End Class