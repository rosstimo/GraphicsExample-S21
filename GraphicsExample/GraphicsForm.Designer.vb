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
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DisplayPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(732, 305)
        Me.DisplayPictureBox.TabIndex = 0
        Me.DisplayPictureBox.TabStop = False
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(270, 13)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(148, 81)
        Me.DrawButton.TabIndex = 1
        Me.DrawButton.Text = "&Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(424, 13)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(148, 81)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(578, 13)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(148, 81)
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
        Me.GroupBox.Location = New System.Drawing.Point(12, 323)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(732, 100)
        Me.GroupBox.TabIndex = 4
        Me.GroupBox.TabStop = False
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 435)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Griphics"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents DrawButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox As GroupBox
End Class
