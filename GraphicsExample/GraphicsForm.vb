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

    'Private Sub DisplayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove
    '    Static oldX As Integer
    '    Static oldY As Integer
    '    If oldX <> 0 And oldY <> 0 Then
    '        'MouseDraw(oldX, oldY, e.X, e.Y)
    '    End If
    '    'Me.Text = $"({e.X},{e.Y})"
    '    oldX = e.X
    '    oldY = e.Y
    'End Sub

    Sub MouseDraw(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, penColor As Color)
        'constructor for the graphics object
        Dim g As Graphics = DisplayPictureBox.CreateGraphics 'Me.CreateGraphics
        'Dim penColor As Color
        'penColor = Color.Red
        Dim pen As New Pen(penColor)
        'actually draw the line
        g.DrawLine(pen, x1, y1, x2, y2)
        'free up resources
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown, DisplayPictureBox.MouseMove
        Static oldX As Integer
        Static oldY As Integer
        Static penColor As Color

        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {penColor.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                MouseDraw(oldX, oldY, e.X, e.Y, penColor)
            Case "Right"

            Case "Middle"
                ColorDialog.ShowDialog()
                penColor = ColorDialog.Color
            Case "None"

            Case Else
                MsgBox("It Got Weird")
        End Select
        oldX = e.X
        oldY = e.Y
    End Sub

End Class
