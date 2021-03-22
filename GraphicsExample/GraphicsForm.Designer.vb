<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplayPictureBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.DisplayPictureBox.Location = New System.Drawing.Point(8, 8)
        Me.DisplayPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(488, 198)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WidthToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(241, 101)
        '
        'WidthToolStripMenuItem
        '
        Me.WidthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenWidthToolStripTextBox})
        Me.WidthToolStripMenuItem.Name = "WidthToolStripMenuItem"
        Me.WidthToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
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
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(180, 8)
        Me.DrawButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(99, 53)
        Me.DrawButton.TabIndex = 1
        Me.DrawButton.Text = "&Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(283, 8)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(99, 53)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(385, 8)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 53)
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
        Me.GroupBox.Location = New System.Drawing.Point(8, 210)
        Me.GroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox.Size = New System.Drawing.Size(488, 65)
        Me.GroupBox.TabIndex = 4
        Me.GroupBox.TabStop = False
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 283)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Griphics"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

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
End Class
