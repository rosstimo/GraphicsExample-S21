<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GraphicsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WidthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenWidthToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.PointStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MouseButtonStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PenColorStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.yScaleStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.xScaleStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dxStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dyStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RotationStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplayPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DisplayPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(732, 341)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WidthToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(133, 68)
        '
        'WidthToolStripMenuItem
        '
        Me.WidthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenWidthToolStripTextBox})
        Me.WidthToolStripMenuItem.Name = "WidthToolStripMenuItem"
        Me.WidthToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.WidthToolStripMenuItem.Text = "&Width"
        '
        'PenWidthToolStripTextBox
        '
        Me.PenWidthToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PenWidthToolStripTextBox.Name = "PenWidthToolStripTextBox"
        Me.PenWidthToolStripTextBox.Size = New System.Drawing.Size(100, 31)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(270, 12)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(148, 82)
        Me.DrawButton.TabIndex = 1
        Me.DrawButton.Text = "&Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(424, 12)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(148, 82)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(578, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(148, 82)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.DrawButton)
        Me.GroupBox.Controls.Add(Me.ExitButton)
        Me.GroupBox.Controls.Add(Me.ClearButton)
        Me.GroupBox.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(732, 100)
        Me.GroupBox.TabIndex = 4
        Me.GroupBox.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointStatusLabel, Me.MouseButtonStatusLabel, Me.PenColorStatusLabel, Me.xScaleStatusLabel, Me.yScaleStatusLabel, Me.dxStatusLabel, Me.dyStatusLabel, Me.RotationStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(772, 32)
        Me.StatusStrip.TabIndex = 5
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'PointStatusLabel
        '
        Me.PointStatusLabel.Name = "PointStatusLabel"
        Me.PointStatusLabel.Size = New System.Drawing.Size(47, 25)
        Me.PointStatusLabel.Text = "(X,Y)"
        '
        'MouseButtonStatusLabel
        '
        Me.MouseButtonStatusLabel.Name = "MouseButtonStatusLabel"
        Me.MouseButtonStatusLabel.Size = New System.Drawing.Size(66, 25)
        Me.MouseButtonStatusLabel.Text = "Mouse"
        '
        'PenColorStatusLabel
        '
        Me.PenColorStatusLabel.Name = "PenColorStatusLabel"
        Me.PenColorStatusLabel.Size = New System.Drawing.Size(55, 25)
        Me.PenColorStatusLabel.Text = "Color"
        '
        'yScaleStatusLabel
        '
        Me.yScaleStatusLabel.Name = "yScaleStatusLabel"
        Me.yScaleStatusLabel.Size = New System.Drawing.Size(61, 25)
        Me.yScaleStatusLabel.Text = "yScale"
        '
        'xScaleStatusLabel
        '
        Me.xScaleStatusLabel.Name = "xScaleStatusLabel"
        Me.xScaleStatusLabel.Size = New System.Drawing.Size(60, 25)
        Me.xScaleStatusLabel.Text = "xScale"
        '
        'dxStatusLabel
        '
        Me.dxStatusLabel.Name = "dxStatusLabel"
        Me.dxStatusLabel.Size = New System.Drawing.Size(31, 25)
        Me.dxStatusLabel.Text = "dx"
        '
        'dyStatusLabel
        '
        Me.dyStatusLabel.Name = "dyStatusLabel"
        Me.dyStatusLabel.Size = New System.Drawing.Size(32, 25)
        Me.dyStatusLabel.Text = "dy"
        '
        'RotationStatusLabel
        '
        Me.RotationStatusLabel.Name = "RotationStatusLabel"
        Me.RotationStatusLabel.Size = New System.Drawing.Size(79, 25)
        Me.RotationStatusLabel.Text = "Rotation"
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 527)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Griphics"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents DrawButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents WidthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenWidthToolStripTextBox As ToolStripTextBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents PointStatusLabel As ToolStripStatusLabel
    Friend WithEvents MouseButtonStatusLabel As ToolStripStatusLabel
    Friend WithEvents PenColorStatusLabel As ToolStripStatusLabel
    Friend WithEvents xScaleStatusLabel As ToolStripStatusLabel
    Friend WithEvents yScaleStatusLabel As ToolStripStatusLabel
    Friend WithEvents dxStatusLabel As ToolStripStatusLabel
    Friend WithEvents dyStatusLabel As ToolStripStatusLabel
    Friend WithEvents RotationStatusLabel As ToolStripStatusLabel
End Class
