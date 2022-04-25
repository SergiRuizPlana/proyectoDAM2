Imports System.Data.SqlClient

Module Funciones

    Sub SetRadius(obj As Object)
        Dim dgp As New Drawing2D.GraphicsPath
        dgp.StartFigure()

        dgp.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        dgp.AddLine(40, 0, obj.width - 40, 0)


        dgp.AddArc(New Rectangle(obj.width - 40, 0, 40, 40), -90, 90)
        dgp.AddLine(obj.width, 40, obj.width, obj.height - 40)

        dgp.AddArc(New Rectangle(obj.width - 40, obj.height - 40, 40, 40), 0, 90)
        dgp.AddLine(obj.width - 40, obj.height, 40, obj.height)

        dgp.AddArc(New Rectangle(0, obj.height - 40, 40, 40), 90, 90)
        dgp.CloseFigure()

        obj.Region = New Region(dgp)
    End Sub

    Sub SetMultyRadius(controls As Array)
        For Each control In controls
            SetRadius(control)
        Next
    End Sub


    ''' <summary>
    ''' Creacion de la database y los procedures de busqueda
    ''' </summary>
    Sub createDatabase(ByVal sqlServerName)
        Dim str As String

        Dim myConn As SqlConnection = New SqlConnection("Server=" & sqlServerName & ";" & "Integrated Security = false")

        str = "CREATE DATABASE gestio_empreses"

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            myConn.Close()


            myConn = New SqlConnection("Server=" & sqlServerName & ";" & "Initial Catalog=gestio_empreses;" & "Integrated Security = True")
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
                " cod_categoria varchar(30) REFERENCES categoria(cod_categoria)," &
                 "fecha_ultima_modificaio date default  GETDATE()" &
                " );" &
                " CREATE TABLE contracte (" &
                " cod_contracte Int PRIMARY KEY," &
                " cif VARCHAR(30) REFERENCES empresa(cif)," &
                " data_inici Date DEFAULT GETDATE()," &
                " tests_mensuals int," &
                "fecha_ultima_modificaio date default  GETDATE()" &
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
                " Data Date DEFAULT GETDATE()," &
                "fecha_ultima_modificaio date default  GETDATE()" &
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
               "  ' +@codicion+' " &
               " GROUP BY e.cif, e.nom, e.adreca, e.telf, e.email, c.descripcio'" &
               " exec sp_executesql  @query" &
               " End"
            myCommand = New SqlCommand(str, myConn)
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Nota par que funcionen los filtros de busqueda hay que reiniciar la aplicacion.", "Formulas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Sub setColorToCOntrols(ByVal controls As Array, ByVal colorRgb As Array)
        For Each control In controls
            control.BackColor = Color.FromArgb(colorRgb(0), colorRgb(1), colorRgb(2))
        Next
    End Sub

End Module
