Imports System.Data.SqlClient

Public Class Empresa
    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myCommand = New SqlCommand("Select * from categoria", startconexion.myConn)
        Dim dr As SqlDataReader = myCommand.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        empresaCategoria.ValueMember = "cod_categoria"
        empresaCategoria.DisplayMember = "descripcio"
        empresaCategoria.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myCommand = New SqlCommand("insert into empresa values (@cif,@nom,@adresa,@phone,@email,@categoria,0) ", startconexion.myConn)
        myCommand.Parameters.Add("@cif", SqlDbType.VarChar).Value = empresaCif.Text
        myCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = empresaNombre.Text
        myCommand.Parameters.Add("@adresa", SqlDbType.VarChar).Value = empresaAdresa.Text
        myCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = empresaPhone.Text
        myCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = EmpresaEmail.Text
        myCommand.Parameters.Add("@categoria", SqlDbType.VarChar).Value = empresaCategoria.SelectedValue


        myCommand.ExecuteNonQuery()


        myCommand = New SqlCommand(" Select * from empresa", startconexion.myConn)
        Dim da As New SqlDataAdapter(myCommand)
        Dim dt As New DataTable
        da.Fill(dt)
        Gestion.DataGridView1.DataSource = dt

        Me.Close()
    End Sub
End Class