Public Class NuevoJuego
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles btnPrincipiante.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnPrincipiante.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnPrincipiante.Region = New Region(buttonPath)

    End Sub

    Private Sub Button2_Paint(sender As Object, e As PaintEventArgs) Handles btnFacil.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnFacil.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnFacil.Region = New Region(buttonPath)

    End Sub

    Private Sub Button3_Paint(sender As Object, e As PaintEventArgs) Handles btnIntermedio.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnIntermedio.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnIntermedio.Region = New Region(buttonPath)

    End Sub

    Private Sub Button4_Paint(sender As Object, e As PaintEventArgs) Handles btnAvanzado.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnAvanzado.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnAvanzado.Region = New Region(buttonPath)

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnPrincipiante.MouseHover
        btnPrincipiante.Size = New Size(width:=270, height:=41)
    End Sub

    Private Sub btnPrincipiante_MouseLeave(sender As Object, e As EventArgs) Handles btnPrincipiante.MouseLeave
        btnPrincipiante.Size = New Size(width:=261, height:=30)
    End Sub
End Class