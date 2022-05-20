Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo
Public Class Form1

    Public myConn As SqlConnection
    ReadOnly tryUseDB = "use gestio_empreses"
    Dim myCommand As SqlCommand
    Dim sqlServerName = "DESKTOP-ASGK7M9\SQLSERVER"
    Private currentForm As Form

    Public Sub OpenForm(form As Form)
        If currentForm IsNot form Then
            If currentForm IsNot Nothing Then currentForm.Close()
            currentForm = form
            currentForm.TopLevel = False
            currentForm.FormBorderStyle = FormBorderStyle.None
            currentForm.Dock = DockStyle.Fill
            Panel4.Controls.Add(currentForm)
            form.BringToFront()
            form.Show()
        End If

    End Sub
    Private Sub Empresas_Click(sender As Object, e As EventArgs) Handles Empresas.Click
        OpenForm(Empresa)
        Label1.Text = "Empreses"
    End Sub

    Private Sub Contratos_Click(sender As Object, e As EventArgs) Handles Contratos.Click
        OpenForm(Contrato)
        Label1.Text = "Contractes"
    End Sub

    Private Sub Albaranes_Click(sender As Object, e As EventArgs) Handles Albaranes.Click
        OpenForm(Albaran)
        Label1.Text = "Albarans"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            myConn = New SqlConnection("Server=" & sqlServerName & ";" & "Integrated Security = True")

                myCommand = New SqlCommand(tryUseDB, myConn)
                myConn.Open()
                If myConn.State = ConnectionState.Open Then

                End If
                Try
                    myCommand.ExecuteNonQuery()
                Catch ex As Exception
                    If MsgBox("La database no existe." & vbCrLf & "Quieres crear la database?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        Funciones.CreateDatabase(sqlServerName)
                    End If
                End Try
            Catch ex As Exception
                MsgBox("la conexion ha fallado: " & ex.Message)
            End Try

            Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
            Dim dt As New Gestio_empresesDataSet.contracteDataTable
            Me.ContracteTableAdapter.FillByTop6ASC(dt)
            DataGridView1.DataSource = dt
            Dim dt2 As New Gestio_empresesDataSet.contracteDataTable
            Me.ContracteTableAdapter.FillByTop6Desc(dt2)
            DataGridView2.DataSource = dt2


            Dim dt3 As New Gestio_empresesDataSet.contracteDataTable
            Me.ContracteTableAdapter.Fill(dt3)
            Dim da As New SqlDataAdapter("pc_exp_contracte", myConn)


            For i = 0 To dt3.Rows.Count - 1
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.Add("@ncontracte", SqlDbType.VarChar).Value = dt3.Rows(i).Item("cod_contracte").ToString
            Next

            Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
        Contrato.DataGridView1.DataSource = Me.Gestio_empresesDataSet.contracte
    End Sub

    Private Sub HomeB_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        If currentForm IsNot Nothing Then currentForm.Close()
        Label1.Text = "Home"
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        OpenForm(Tests)
        Label1.Text = "Tests"
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Form2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Empresas.PerformClick()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Contratos.PerformClick()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Albaranes.PerformClick()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        IconButton2.PerformClick()
    End Sub

End Class