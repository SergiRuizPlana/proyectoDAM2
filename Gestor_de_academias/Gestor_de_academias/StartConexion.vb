Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo

Public Class startconexion

    Public myConn As SqlConnection
    Dim tryUseDB = "use gestio_empreses"
    Dim myCommand As SqlCommand
    Dim sqlServerName


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row As DataRow
        'Dim dtServers As DataTable = SmoApplication.EnumAvailableSqlServers(True)
        'For Each row In dtServers.Rows
        '    sqlServerName = row.ItemArray(0)
        'Next

        Dim a = 0
        Try
            'myConn = New SqlConnection("Server=" & sqlServerName & ";" & "Integrated Security = True")
            myConn = New SqlConnection("Server=DESKTOP-LRLD5GA\SQLEXPRESS;" & "Integrated Security = True")

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

        Dim myConn As SqlConnection = New SqlConnection("Server=" & sqlServerName & ";" & "Integrated Security = false")

        str = "CREATE DATABASE gestio_empreses"

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            myConn.Close()


            myConn = New SqlConnection("Server=" & ";" & "Initial Catalog=gestio_empreses;" & "Integrated Security = True")
            myConn.Open()
            str = "CREATE TABLE categoria (" &
                " cod_categoria varchar(30) PRIMARY KEY default NEWID()," &
                " descripcio VARCHAR(244) Not NULL" &
                " );" &
                " CREATE TABLE empresa (" &
                " cif VARCHAR(30) PRIMARY KEY," &
                " nom VARCHAR(30) Not NULL," &
                " adreca VARCHAR(50)," &
                " telf VARCHAR(14) Not NULL," &
                " email VARCHAR(50)," &
                " cod_categoria varchar(30) REFERENCES categoria(cod_categoria)" &
                " );" &
                " CREATE TABLE contracte (" &
                " cod_contracte Int PRIMARY KEY," &
                " cif VARCHAR(30) REFERENCES empresa(cif)," &
                " data_inici Date DEFAULT GETDATE()," &
                " tests_mensuals int" &
                " );" &
                " CREATE TABLE categoria_test (" &
                " cod_categoria varchar(30) PRIMARY KEY default NEWID()," &
                " descripcio VARCHAR(244) Not NULL" &
                " ); " &
                " CREATE TABLE test (" &
                " codi_test Int PRIMARY KEY, " &
                " total_preg Int Not NULL," &
                " cod_categoria varchar(30) REFERENCES categoria_test(cod_categoria)," &
                " preu Decimal(3, 2) Not NULL," &
                " );" &
                " CREATE TABLE albara (" &
                " num_albara Int PRIMARY KEY," &
                " cif VARCHAR(30) REFERENCES empresa(cif)," &
                " Data Date DEFAULT GETDATE()" &
                " );" &
                "CREATE TABLE albara_test (" &
                " num_albara Int REFERENCES albara(num_albara)," &
                " codi_test Int REFERENCES test(codi_test)," &
                " realitzat bit DEFAULT 0," &
                " PRIMARY KEY(num_albara, codi_test)" &
                " );"

            myCommand = New SqlCommand(str, myConn)
            myCommand.ExecuteNonQuery()

            str = "create proc pc_buscarEmpresa" &
               " @codicion varchar(max)" &
               " as" &
               " begin " &
               " Declare @query NVARCHAR(4000) " &
               " Set @query ='SELECT  e.cif, e.nom, e.adreca, e.telf, e.email, c.descripcio AS categoria, COUNT(at.num_albara) AS total_tests," &
               " (SELECT COUNT(at2.num_albara) AS Expr1 From albara_test As at2 INNER JOIN albara AS a2 ON a2.num_albara = at2.num_albara WHERE (a2.cif = e.cif) And (at2.realitzat = 1)) AS tests_realitzats," &
               " (SELECT COUNT(at2.num_albara) AS Expr1 From albara_test As at2 INNER JOIN albara AS a2 ON a2.num_albara = at2.num_albara WHERE        (a2.cif = e.cif) And (at2.realitzat = 0)) AS tests_disponibles, SUM(t.preu) AS preu_total" &
               " From empresa As e LEFT JOIN" &
               " albara AS a ON a.cif = e.cif LEFT JOIN" &
               " albara_test AS at ON at.num_albara = a.num_albara LEFT JOIN" &
               " test AS t ON t.codi_test = at.codi_test INNER JOIN" &
               " categoria AS c ON e.cod_categoria = c.cod_categoria" &
               " where '+@codicion+'" &
               " GROUP BY e.cif, e.nom, e.adreca, e.telf, e.email, c.descripcio'" &
               " exec sp_executesql  @query" &
               " End"
            myCommand = New SqlCommand(Str, myConn)
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Nota par que funcionen los filtros de busqueda hay que reiniciar la aplicacion.", "Formulas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If myConn.State = ConnectionState.Open Then
                Empresa.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Comprueba la conexion", "Formulas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub startconexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.PerformClick()
    End Sub
End Class

