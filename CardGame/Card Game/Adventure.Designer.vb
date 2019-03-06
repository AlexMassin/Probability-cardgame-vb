<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adventure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adventure))
        Me.picCompCard2 = New System.Windows.Forms.PictureBox()
        Me.picCompCard3 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard2 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard3 = New System.Windows.Forms.PictureBox()
        Me.picCompCard1 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard1 = New System.Windows.Forms.PictureBox()
        Me.lblPCount = New System.Windows.Forms.Label()
        Me.lblCCount = New System.Windows.Forms.Label()
        Me.lblPWins = New System.Windows.Forms.Label()
        Me.lblCWins = New System.Windows.Forms.Label()
        Me.lblPHealth = New System.Windows.Forms.Label()
        Me.lblCHealth = New System.Windows.Forms.Label()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picCompCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCompCard2
        '
        Me.picCompCard2.BackgroundImage = CType(resources.GetObject("picCompCard2.BackgroundImage"), System.Drawing.Image)
        Me.picCompCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCompCard2.Location = New System.Drawing.Point(749, 41)
        Me.picCompCard2.Name = "picCompCard2"
        Me.picCompCard2.Size = New System.Drawing.Size(146, 225)
        Me.picCompCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCompCard2.TabIndex = 5
        Me.picCompCard2.TabStop = False
        '
        'picCompCard3
        '
        Me.picCompCard3.BackgroundImage = CType(resources.GetObject("picCompCard3.BackgroundImage"), System.Drawing.Image)
        Me.picCompCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCompCard3.Location = New System.Drawing.Point(901, 41)
        Me.picCompCard3.Name = "picCompCard3"
        Me.picCompCard3.Size = New System.Drawing.Size(146, 225)
        Me.picCompCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCompCard3.TabIndex = 4
        Me.picCompCard3.TabStop = False
        '
        'picPlayerCard2
        '
        Me.picPlayerCard2.BackgroundImage = CType(resources.GetObject("picPlayerCard2.BackgroundImage"), System.Drawing.Image)
        Me.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerCard2.Location = New System.Drawing.Point(168, 41)
        Me.picPlayerCard2.Name = "picPlayerCard2"
        Me.picPlayerCard2.Size = New System.Drawing.Size(146, 225)
        Me.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayerCard2.TabIndex = 3
        Me.picPlayerCard2.TabStop = False
        '
        'picPlayerCard3
        '
        Me.picPlayerCard3.BackgroundImage = CType(resources.GetObject("picPlayerCard3.BackgroundImage"), System.Drawing.Image)
        Me.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerCard3.Location = New System.Drawing.Point(320, 41)
        Me.picPlayerCard3.Name = "picPlayerCard3"
        Me.picPlayerCard3.Size = New System.Drawing.Size(146, 225)
        Me.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayerCard3.TabIndex = 2
        Me.picPlayerCard3.TabStop = False
        '
        'picCompCard1
        '
        Me.picCompCard1.BackgroundImage = CType(resources.GetObject("picCompCard1.BackgroundImage"), System.Drawing.Image)
        Me.picCompCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCompCard1.Location = New System.Drawing.Point(597, 41)
        Me.picCompCard1.Name = "picCompCard1"
        Me.picCompCard1.Size = New System.Drawing.Size(146, 225)
        Me.picCompCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCompCard1.TabIndex = 1
        Me.picCompCard1.TabStop = False
        '
        'picPlayerCard1
        '
        Me.picPlayerCard1.BackgroundImage = CType(resources.GetObject("picPlayerCard1.BackgroundImage"), System.Drawing.Image)
        Me.picPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerCard1.Location = New System.Drawing.Point(16, 41)
        Me.picPlayerCard1.Name = "picPlayerCard1"
        Me.picPlayerCard1.Size = New System.Drawing.Size(146, 225)
        Me.picPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayerCard1.TabIndex = 0
        Me.picPlayerCard1.TabStop = False
        '
        'lblPCount
        '
        Me.lblPCount.AutoSize = True
        Me.lblPCount.BackColor = System.Drawing.Color.Transparent
        Me.lblPCount.Font = New System.Drawing.Font("Press Start", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPCount.ForeColor = System.Drawing.Color.White
        Me.lblPCount.Location = New System.Drawing.Point(241, 297)
        Me.lblPCount.Name = "lblPCount"
        Me.lblPCount.Size = New System.Drawing.Size(0, 21)
        Me.lblPCount.TabIndex = 7
        '
        'lblCCount
        '
        Me.lblCCount.AutoSize = True
        Me.lblCCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCCount.Font = New System.Drawing.Font("Press Start", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCount.ForeColor = System.Drawing.Color.White
        Me.lblCCount.Location = New System.Drawing.Point(745, 304)
        Me.lblCCount.Name = "lblCCount"
        Me.lblCCount.Size = New System.Drawing.Size(0, 21)
        Me.lblCCount.TabIndex = 8
        '
        'lblPWins
        '
        Me.lblPWins.AutoSize = True
        Me.lblPWins.BackColor = System.Drawing.Color.Transparent
        Me.lblPWins.Font = New System.Drawing.Font("Press Start", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWins.ForeColor = System.Drawing.Color.White
        Me.lblPWins.Location = New System.Drawing.Point(87, 339)
        Me.lblPWins.Name = "lblPWins"
        Me.lblPWins.Size = New System.Drawing.Size(0, 21)
        Me.lblPWins.TabIndex = 9
        '
        'lblCWins
        '
        Me.lblCWins.AutoSize = True
        Me.lblCWins.BackColor = System.Drawing.Color.Transparent
        Me.lblCWins.Font = New System.Drawing.Font("Press Start", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCWins.ForeColor = System.Drawing.Color.White
        Me.lblCWins.Location = New System.Drawing.Point(873, 339)
        Me.lblCWins.Name = "lblCWins"
        Me.lblCWins.Size = New System.Drawing.Size(0, 21)
        Me.lblCWins.TabIndex = 10
        '
        'lblPHealth
        '
        Me.lblPHealth.AutoSize = True
        Me.lblPHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblPHealth.Font = New System.Drawing.Font("Press Start", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHealth.ForeColor = System.Drawing.Color.Red
        Me.lblPHealth.Location = New System.Drawing.Point(28, 395)
        Me.lblPHealth.Name = "lblPHealth"
        Me.lblPHealth.Size = New System.Drawing.Size(390, 29)
        Me.lblPHealth.TabIndex = 11
        Me.lblPHealth.Text = "Health: ŒŒŒŒŒ"
        '
        'lblCHealth
        '
        Me.lblCHealth.AutoSize = True
        Me.lblCHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblCHealth.Font = New System.Drawing.Font("Press Start", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHealth.ForeColor = System.Drawing.Color.Red
        Me.lblCHealth.Location = New System.Drawing.Point(657, 395)
        Me.lblCHealth.Name = "lblCHealth"
        Me.lblCHealth.Size = New System.Drawing.Size(390, 29)
        Me.lblCHealth.TabIndex = 12
        Me.lblCHealth.Text = "Health: ŒŒŒŒŒ"
        '
        'lblTies
        '
        Me.lblTies.AutoSize = True
        Me.lblTies.BackColor = System.Drawing.Color.Transparent
        Me.lblTies.Font = New System.Drawing.Font("Press Start", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTies.ForeColor = System.Drawing.Color.White
        Me.lblTies.Location = New System.Drawing.Point(466, 403)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(0, 21)
        Me.lblTies.TabIndex = 13
        '
        'btnShuffle
        '
        Me.btnShuffle.BackColor = System.Drawing.Color.Transparent
        Me.btnShuffle.Font = New System.Drawing.Font("Press Start", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShuffle.ForeColor = System.Drawing.Color.White
        Me.btnShuffle.Location = New System.Drawing.Point(448, 280)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(190, 62)
        Me.btnShuffle.TabIndex = 6
        Me.btnShuffle.Text = "Draw"
        Me.btnShuffle.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Press Start", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(164, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Press Start", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(735, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Computer"
        '
        'Adventure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTies)
        Me.Controls.Add(Me.lblCHealth)
        Me.Controls.Add(Me.lblPHealth)
        Me.Controls.Add(Me.lblCWins)
        Me.Controls.Add(Me.lblPWins)
        Me.Controls.Add(Me.lblCCount)
        Me.Controls.Add(Me.lblPCount)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.picCompCard2)
        Me.Controls.Add(Me.picCompCard3)
        Me.Controls.Add(Me.picPlayerCard2)
        Me.Controls.Add(Me.picPlayerCard3)
        Me.Controls.Add(Me.picCompCard1)
        Me.Controls.Add(Me.picPlayerCard1)
        Me.Name = "Adventure"
        Me.Text = "Adventure"
        CType(Me.picCompCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCompCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCompCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCompCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPCount As System.Windows.Forms.Label
    Friend WithEvents lblCCount As System.Windows.Forms.Label
    Friend WithEvents lblPWins As System.Windows.Forms.Label
    Friend WithEvents lblCWins As System.Windows.Forms.Label
    Friend WithEvents lblPHealth As System.Windows.Forms.Label
    Friend WithEvents lblCHealth As System.Windows.Forms.Label
    Friend WithEvents lblTies As System.Windows.Forms.Label
    Friend WithEvents btnShuffle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
