Imports System.Data.SqlClient

Public Class startconexion

    Public myConn As SqlConnection
    Dim machineName = Environment.MachineName.ToString()
    Dim tryUseDB = "use gestio_empreses"
    Dim myCommand As SqlCommand


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            myConn = New SqlConnection("Server=" & machineName & "\SQLEXPRESS;" & "Integrated Security = True")
            myCommand = New SqlCommand(tryUseDB, myConn)
            myConn.Open()
            If myConn.State = ConnectionState.Open Then
                Label1.Text = "Conectado"
            End If
            Try
                myCommand.ExecuteNonQuery()
            Catch ex As Exception
                If MsgBox("La database no existe." & vbCrLf & "Quieres crear la database?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    createDatabase()
                End If
            End Try
        Catch ex As Exception
            MsgBox("la conexion ha fallado: " & ex.Message)
        End Try
    End Sub



    ''' <summary>
    ''' Creacion de la database y los procedures de busqueda
    ''' </summary>
    Private Sub createDatabase()
        Dim str As String

        Dim myConn As SqlConnection = New SqlConnection("Server=" & machineName & "\SQLEXPRESS;" & "Integrated Security = True")

        str = "CREATE DATABASE gestio_empreses"

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            myConn.Close()


            myConn = New SqlConnection("Server=DESKTOP-LRLD5GA\SQLEXPRESS;" & "Initial Catalog=gestio_empreses;" & "Integrated Security = True")
            myConn.Open()
            str = "CREATE TABLE categoria (" &
                "cod_categoria Int PRIMARY KEY," &
                "descripcio VARCHAR(244) Not NULL" &
                ");" &
                "CREATE TABLE empresa (" &
                "cif VARCHAR(30) PRIMARY KEY," &
                "nom VARCHAR(30) Not NULL," &
                "adreca VARCHAR(50)," &
                "telf VARCHAR(14) Not NULL," &
                "email VARCHAR(50)," &
                "cod_categoria INT REFERENCES categoria(cod_categoria)," &
                "consum Int DEFAULT 0" &
                ");" &
                "CREATE TABLE contracte (" &
                "cod_contracte Int PRIMARY KEY," &
                "cif VARCHAR(30) REFERENCES empresa(cif)," &
                "data_inici Date DEFAULT GETDATE()" &
                ");" &
                "CREATE TABLE categoria_test (" &
                "cod_categoria Int PRIMARY KEY," &
                "descripcio VARCHAR(244) Not NULL" &
                "); " &
                "CREATE TABLE test (" &
                "codi_test Int PRIMARY KEY, " &
                "total_preg Int Not NULL," &
                "cod_categoria Int REFERENCES categoria_test(cod_categoria)," &
                "preu Decimal(3, 2) Not NULL," &
                ");" &
                "CREATE TABLE albara (" &
                "num_albara Int PRIMARY KEY," &
                "cif VARCHAR(30) REFERENCES empresa(cif)," &
                "Data Date DEFAULT GETDATE()" &
                ");" &
                "CREATE TABLE albara_test (" &
                "num_albara Int REFERENCES albara(num_albara)," &
                "codi_test Int REFERENCES test(codi_test)," &
                "PRIMARY KEY(num_albara, codi_test)" &
                ");"

            myCommand = New SqlCommand(str, myConn)
            myCommand.ExecuteNonQuery()



            If MessageBox.Show("La database y los procedures se han creado correctamente.", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information) = MsgBoxResult.Ok Then

            End If

            MessageBox.Show("Nota par que funcionen los filtros de busqueda hay que reiniciar la aplicacion.", "Formulas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If myConn.State = ConnectionState.Open Then
                Gestion.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Comprueba la conexion", "Formulas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class

