Imports System.Data.SqlClient

Public Class Gestion
    Private Sub empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myCommand = New SqlCommand(" Select * from empresa", startconexion.myConn)
        Dim da As New SqlDataAdapter(myCommand)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Empresa.Show()
    End Sub
End Class