Option Explicit On
Option Strict On

Imports System.Math


Public Class GraphicsForm

    'Global fields for graphics object
    Dim g As Graphics 'instantiated globally, associated with PictureBox control on me.Load event
    Dim mainPen As New Pen(Color.Black)

    'point tracking
    Dim lastPoint As Point

    Sub DrawLineSegment(startPoint As Point, endPoint As Point)
        g.DrawLine(Me.mainPen, startPoint, endPoint)
    End Sub

    Private Sub DisplayPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown, DisplayPictureBox.MouseMove

        'action selection based on mouse button
        Select Case e.Button.ToString
            Case "Left"
                DrawLineSegment(lastPoint, e.Location)
            Case "Right"
                'Not used due to context menu implementation
            Case "Middle"
                ColorDialog.ShowDialog()
                Me.mainPen.Color = ColorDialog.Color
            Case "None"
                'TODO
        End Select

        'Update info
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {Me.mainPen.Color.ToString}"

        'update last known point
        Me.lastPoint.X = e.X
        Me.lastPoint.Y = e.Y

    End Sub

    'needs testing  with global
    Sub UpdateParms()
        'g.PageUnit = GraphicsUnit.Pixel
        'g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

        'Scale 
        'This will be the width of the scaled graphics object 
        Dim xMax As Single = 360
        Dim xScale As Single = CSng(DisplayPictureBox.Width / xMax)

        'This will be the height of the scaled graphics object 
        Dim yMax As Single = 100
        'half the height in pixels is to 100 units
        '100 up, 100 down
        Dim yScale As Single = CSng(((DisplayPictureBox.Height) / 2) / yMax)
        Me.g.ScaleTransform(xScale, yScale) 'apply scale

        'Offset 
        'y=0 to vertical center
        Dim yOffset As Single = CSng(yMax)
        'left edge
        Dim xOffset As Single
        Me.g.TranslateTransform(xOffset, yOffset)

        'Rotation 0
        Dim rotation As Single
        Me.g.RotateTransform(rotation)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'TODO play shake sound
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

        Dim div As Double = DisplayPictureBox.Width / 10
        Dim maxX = DisplayPictureBox.Width / div
        Dim plotPoint As Point
        Dim offset As Integer = CInt(DisplayPictureBox.Height / 2)
        Dim maxY As Double = DisplayPictureBox.Height

        degrees = (180 / PI)
        'For i = 0 To maxX 'Step div
        '    plotPoint.X = CInt(i)
        '    plotPoint.Y = CInt(maxY * Sin(2 * PI * i))
        '    DrawLineSegment(plotPoint.X, plotPoint.Y, LastPoint(,, False).X, LastPoint(,, False).Y)
        '    LastPoint(plotPoint.X, plotPoint.Y)
        'Next


    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        DrawWave()
    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.g = Me.DisplayPictureBox.CreateGraphics
    End Sub
End Class
