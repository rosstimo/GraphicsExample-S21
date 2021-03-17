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

    Private Sub DisplayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove
        Static oldX As Integer
        Static oldY As Integer
        Me.Text = $"({e.X},{e.Y})"
        MouseDraw(oldX, oldY, e.X, e.Y)
        oldX = e.X
        oldY = e.Y
    End Sub

    Sub MouseDraw(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics 'Me.CreateGraphics
        Dim pen As New Pen(Color.Black)
        'actually draw the line
        g.DrawLine(pen, x1, y1, x2, y2)
        'free up resources
        pen.Dispose()
        g.Dispose()
    End Sub

End Class
