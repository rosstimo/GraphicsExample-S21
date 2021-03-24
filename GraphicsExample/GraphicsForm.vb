Option Explicit On
Option Strict On

Imports System.Math
Imports System.Threading.Thread


Public Class GraphicsForm

    'Global fields for graphics object
    Dim g As Graphics 'instantiated globally, associated with PictureBox control on me.Load event
    Dim mainPen As New Pen(Color.Black)

    'point tracking
    Dim lastPoint As Point


    Sub DrawLineSegment(startPoint As Point, endPoint As Point)
        g.DrawLine(Me.mainPen, startPoint, endPoint)
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

    ''' <summary>
    ''' Mouse Events. Track Mouse Move Coordinates, Draw on Left Button,
    ''' Choose Pen color on middle mouse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
        PointStatusLabel.Text = $"({e.X},{e.Y})"
        MouseButtonStatusLabel.Text = $"{e.Button.ToString}"
        PenColorStatusLabel.Text = $"{Me.mainPen.Color.ToString}"

        'update last known point
        Me.lastPoint.X = e.X
        Me.lastPoint.Y = e.Y

    End Sub


    Sub DrawWave()
        Dim wave As Graphics = DisplayPictureBox.CreateGraphics
        Dim _start As Point
        Dim _end As Point

        'offset amount
        Dim yOffset As Single = CSng(DisplayPictureBox.Height / 2)
        wave.TranslateTransform(0, yOffset)

        'Scale 
        'This will be the width of the scaled graphics object 
        Dim xMax As Single = 360
        Dim xScale As Single = CSng(DisplayPictureBox.Width / xMax)
        'This will be the height of the scaled graphics object 
        Dim yMax As Single = 100
        'half the height in pixels is to 100 units
        '100 up, 100 down
        Dim yScale As Single = CSng(((DisplayPictureBox.Height) / 2) / yMax)
        wave.ScaleTransform(xScale, yScale) 'apply scale

        mainPen.Color = Color.Red

        'plot Sin
        _start.X = 0
        _start.Y = 0
        'Vi = Vp * sin(360 * f * t + theta) + DC
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Sin((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next

        mainPen.Color = Color.Green
        'plot Cos
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Cos((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next
        mainPen.Color = Color.Blue
        'plot Tan
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            Try
                _end.Y = CInt(yMax * Tan((PI / 180) * _end.X)) * -1
            Catch

            End Try

            wave.DrawLine(mainPen, _start, _end)

            _start.X = _end.X
            _start.Y = _end.Y
        Next

        wave.Dispose()
    End Sub

    ''' <summary>
    ''' Clear Event: Start shake sound, shake form, and refresh picture box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearEvent(sender As Object, e As EventArgs) Handles ClearButton.Click
        'TODO play shake sound
        ShakeSound()
        Shake()
        DisplayPictureBox.Refresh()
    End Sub
    Sub ShakeSound()
        'https://freesound.org/
        'play shake sound from project resources
        My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
    End Sub
    Sub Shake()
        Dim moveAmount = 50

        For i = 1 To 15
            Me.Top += moveAmount
            Me.Left += moveAmount
            Sleep(100)
            moveAmount *= -1
        Next

    End Sub

    'Update pen width
    Private Sub WidthToolStripTextBox(sender As Object, e As EventArgs) Handles PenWidthToolStripTextBox.LostFocus
        Try
            Me.mainPen.Width() = CSng(PenWidthToolStripTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub
    'Update pen color
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        Me.mainPen.Color = ColorDialog.Color
    End Sub
    'Button/Menu Events
    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        DrawWave()
    End Sub
    'Start Up/Shut Down program
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.g = Me.DisplayPictureBox.CreateGraphics
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
