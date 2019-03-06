<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modes))
        Me.lblAdventure = New System.Windows.Forms.Label()
        Me.lblProbability = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAdventure
        '
        Me.lblAdventure.BackColor = System.Drawing.Color.Transparent
        Me.lblAdventure.Font = New System.Drawing.Font("Press Start", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdventure.ForeColor = System.Drawing.Color.Red
        Me.lblAdventure.Location = New System.Drawing.Point(12, 41)
        Me.lblAdventure.Name = "lblAdventure"
        Me.lblAdventure.Size = New System.Drawing.Size(804, 153)
        Me.lblAdventure.TabIndex = 0
        Me.lblAdventure.Text = "ŒADVENTURE MODEŒ"
        '
        'lblProbability
        '
        Me.lblProbability.BackColor = System.Drawing.Color.Transparent
        Me.lblProbability.Font = New System.Drawing.Font("Press Start", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProbability.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProbability.Location = New System.Drawing.Point(12, 295)
        Me.lblProbability.Name = "lblProbability"
        Me.lblProbability.Size = New System.Drawing.Size(804, 153)
        Me.lblProbability.TabIndex = 1
        Me.lblProbability.Text = "%PROBABILITY MODE%"
        '
        'Modes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 474)
        Me.Controls.Add(Me.lblProbability)
        Me.Controls.Add(Me.lblAdventure)
        Me.Name = "Modes"
        Me.Text = "Modes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAdventure As System.Windows.Forms.Label
    Friend WithEvents lblProbability As System.Windows.Forms.Label
End Class
