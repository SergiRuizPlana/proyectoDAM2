Imports System.Data.SqlClient
Public Class Albaran

    Private currentForm As Form

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
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.categoria_test' Puede moverla o quitarla según sea necesario.
        Me.Categoria_testTableAdapter.Fill(Me.Gestio_empresesDataSet.categoria_test)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.test' Puede moverla o quitarla según sea necesario.
        Me.TestTableAdapter.Fill(Me.Gestio_empresesDataSet.test)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Gestio_empresesDataSet.empresa)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.albara' Puede moverla o quitarla según sea necesario.
        Me.AlbaraTableAdapter.Fill(Me.Gestio_empresesDataSet.albara)
        OpenForm(Modelo_albaran)

    End Sub

    Private Sub createAlbara_Click(sender As Object, e As EventArgs) Handles createAlbara.Click
        Panel3.Visible = True
        Panel4.Visible = False
        RadioButtonCrearAuto.Checked = True

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

    Private Sub RadioButtonCrearManual_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCrearManual.CheckedChanged
        If RadioButtonCrearAuto.Checked = True Then
            GroupBoxQtyTests.Enabled = True
            GroupBoxSearchTest.Enabled = False
        ElseIf RadioButtonCrearManual.Checked = True Then
            GroupBoxQtyTests.Enabled = False
            GroupBoxSearchTest.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonCrearAuto_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCrearAuto.CheckedChanged
        If RadioButtonCrearAuto.Checked = True Then
            GroupBoxQtyTests.Enabled = True
            GroupBoxSearchTest.Enabled = False
        ElseIf RadioButtonCrearManual.Checked = True Then
            GroupBoxQtyTests.Enabled = False
            GroupBoxSearchTest.Enabled = True
        End If
    End Sub

    Private Sub ButtonCreateAlbara_Click(sender As Object, e As EventArgs) Handles ButtonCreateAlbara.Click

    End Sub

    Private Sub EditAlbara_Click(sender As Object, e As EventArgs) Handles EditAlbara.Click
        Panel4.Visible = True
        Panel3.Visible = False
    End Sub

    Private Sub ButtonEditAlbaraBack_Click(sender As Object, e As EventArgs) Handles ButtonEditAlbaraBack.Click
        Panel4.Visible = False
    End Sub

    Private Sub ButtonCreateNewAlbaraEdit_Click(sender As Object, e As EventArgs) Handles ButtonSaveAlbaraEdit.Click

    End Sub
End Class