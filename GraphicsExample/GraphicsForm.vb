Option Explicit On
Option Strict On

Public Class GraphicsForm


    Sub DrawLine()
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics 'Me.CreateGraphics
        Dim pen As New Pen(Color.Black)
        'actually draw the line
        g.DrawLine(pen, 0, 0, 100, 100)
        'free up resources
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCircle()
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics 'Me.CreateGraphics
        Dim pen As New Pen(Color.Red)
        g.DrawEllipse(pen, 0, 0, 100, 100)
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawCircle()
    End Sub

End Class
