Option Explicit On
Option Strict On

Public Class GraphicsForm
    'Global fields
    Dim mainPen As New Pen(Color.Black)

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'DrawLine()
        'DrawCircle()
        'LastPoint(100, 100)
        'LastPoint(10, 10)
        'LastPoint(3, 77)
        'Me.Text = CStr(LastPoint(,, False).Y)
        'Me.Text = CStr(LastPoint().Y)
        'Console.WriteLine()


    End Sub

    Sub DrawLineSegment(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer) ', penColor As Color)
        Dim g As Graphics = DisplayPictureBox.CreateGraphics 'Me.CreateGraphics
        'Use Global Pen
        'Dim pen As New Pen(penColor)
        'Pen.Width() = 5

        'Draw line segment
        g.DrawLine(Me.mainPen, x1, y1, x2, y2)
        'free up resources
        'pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown, DisplayPictureBox.MouseMove
        'Static oldX As Integer
        'Static oldY As Integer

        'Dim myPoint As Point
        'myPoint.X = 0
        'myPoint.Y = 0

        'Use Global
        'Static penColor As Color

        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {Me.mainPen.Color.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                DrawLineSegment(LastPoint(,, False).X, LastPoint(,, False).Y, e.X, e.Y)
            Case "Right"

            Case "Middle"
                ColorDialog.ShowDialog()
                Me.mainPen.Color = ColorDialog.Color
            Case "None"

            Case Else
                MsgBox("It Got Weird")
        End Select
        'oldX = e.X
        'oldY = e.Y
        LastPoint(e.X, e.Y)

    End Sub

    Function LastPoint(Optional x As Integer = 0, Optional y As Integer = 0, Optional update As Boolean = True) As Point
        Static _lastPoint As Point

        If update = True Then
            _lastPoint.X = x
            _lastPoint.Y = y
        End If

        Return _lastPoint
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'DisplayPictureBox.BackColor = Color.LightBlue
        'DisplayPictureBox.BackColor = SystemColors.Control
        DisplayPictureBox.Refresh()
    End Sub

    Private Sub WidthToolStripTextBox() Handles PenWidthToolStripTextBox.LostFocus
        Try
            Me.mainPen.Width() = CSng(PenWidthToolStripTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        Me.mainPen.Color = ColorDialog.Color
    End Sub

    Sub DrawWave()
        Dim degrees As Double
        Dim angle As Double

        degrees = (180 / System.Math.PI)


        System.Math.Sin(1)

    End Sub

End Class
