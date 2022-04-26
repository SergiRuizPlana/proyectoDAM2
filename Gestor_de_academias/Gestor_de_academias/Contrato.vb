Public Class Contrato
    Private Sub Contrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.contracte' Puede moverla o quitarla según sea necesario.
        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)
        'TODO: esta línea de código carga datos en la tabla 'Gestio_empresesDataSet.contracte' Puede moverla o quitarla según sea necesario.
        Me.ContracteTableAdapter.Fill(Me.Gestio_empresesDataSet.contracte)

        If Me.Gestio_empresesDataSet.contracte.Rows.Count = 0 Then
            DataGridView1.Visible = False
            Label2.Visible = True
        End If
        Funciones.SetMultyRadius({Panel1})
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class