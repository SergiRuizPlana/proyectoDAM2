Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo

Public Class startconexion

    Public myConn As SqlConnection
    ReadOnly tryUseDB = "use gestio_empreses"
    Dim myCommand As SqlCommand
    Dim sqlServerName = "DESKTOP-LRLD5GA\SQLEXPRESS"


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim row As DataRow
        'Dim dtServers As DataTable = SmoApplication.EnumAvailableSqlServers(True)
        'For Each row In dtServers.Rows
        '    sqlServerName = row.ItemArray(0)
        'Next
        Try
            'myConn = New SqlConnection("Server=" & sqlServerName & ";" & "Integrated Security = True")
            myConn = New SqlConnection("Server=" & sqlServerName & ";" & "Integrated Security = True")

            myCommand = New SqlCommand(tryUseDB, myConn)
            myConn.Open()
            If myConn.State = ConnectionState.Open Then
                Label1.Text = "Conectado"
                Form1.Show()
            End If
            Try
                myCommand.ExecuteNonQuery()
            Catch ex As Exception
                If MsgBox("La database no existe." & vbCrLf & "Quieres crear la database?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Funciones.createDatabase(sqlServerName)
                End If
            End Try
        Catch ex As Exception
            MsgBox("la conexion ha fallado: " & ex.Message)
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If myConn.State = ConnectionState.Open Then

            End If

        Catch ex As Exception
            MessageBox.Show("Comprueba la conexion", "Formulas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Startconexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.PerformClick()
    End Sub
End Class

