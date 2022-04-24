Module Funciones

    Function genrateRandomId()
        Randomize()
        Dim rn As New Random()
        Dim id = ""
        For i = 0 To 15

        Next

    End Function


    Sub setRadius(obj As Object)
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




End Module
