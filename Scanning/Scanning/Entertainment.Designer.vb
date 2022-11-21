<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entertainment
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
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.goForward = New Scanning.SubOptions()
        Me.goBack = New Scanning.SubOptions()
        Me.SubOptions5 = New Scanning.SubOptions()
        Me.SubOptions4 = New Scanning.SubOptions()
        Me.SubOptions3 = New Scanning.SubOptions()
        Me.play = New Scanning.SubOptions()
        Me.volumeMute = New Scanning.SubOptions()
        Me.volumeDown = New Scanning.SubOptions()
        Me.volumeUp = New Scanning.SubOptions()
        Me.mainMenu = New System.Windows.Forms.PictureBox()
        Me.volumeOption = New Scanning.SubOptions()
        Me.programOption = New Scanning.SubOptions()
        Me.tvOption = New Scanning.SubOptions()
        Me.movieOption = New Scanning.SubOptions()
        Me.musicOption = New Scanning.SubOptions()
        Me.entertainmentMenu = New Scanning.SubOptions()
        Me.volumeMenu = New System.Windows.Forms.PictureBox()
        Me.entertainmentBackground = New System.Windows.Forms.PictureBox()
        CType(Me.goForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubOptions5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubOptions4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubOptions3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.programOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tvOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movieOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entertainmentMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entertainmentBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(161, 554)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 19
        '
        'goForward
        '
        Me.goForward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.goForward.Image = Global.Scanning.My.Resources.Resources.forward
        Me.goForward.Location = New System.Drawing.Point(428, 308)
        Me.goForward.Name = "goForward"
        Me.goForward.Size = New System.Drawing.Size(100, 100)
        Me.goForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goForward.TabIndex = 38
        Me.goForward.TabStop = False
        '
        'goBack
        '
        Me.goBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.goBack.Image = Global.Scanning.My.Resources.Resources.rewind
        Me.goBack.Location = New System.Drawing.Point(186, 308)
        Me.goBack.Name = "goBack"
        Me.goBack.Size = New System.Drawing.Size(100, 100)
        Me.goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goBack.TabIndex = 37
        Me.goBack.TabStop = False
        '
        'SubOptions5
        '
        Me.SubOptions5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions5.Image = Global.Scanning.My.Resources.Resources.volumemute
        Me.SubOptions5.Location = New System.Drawing.Point(186, 414)
        Me.SubOptions5.Name = "SubOptions5"
        Me.SubOptions5.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions5.TabIndex = 36
        Me.SubOptions5.TabStop = False
        '
        'SubOptions4
        '
        Me.SubOptions4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions4.Image = Global.Scanning.My.Resources.Resources.volumemute
        Me.SubOptions4.Location = New System.Drawing.Point(306, 414)
        Me.SubOptions4.Name = "SubOptions4"
        Me.SubOptions4.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions4.TabIndex = 35
        Me.SubOptions4.TabStop = False
        '
        'SubOptions3
        '
        Me.SubOptions3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions3.Image = Global.Scanning.My.Resources.Resources.volumemute
        Me.SubOptions3.Location = New System.Drawing.Point(428, 414)
        Me.SubOptions3.Name = "SubOptions3"
        Me.SubOptions3.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions3.TabIndex = 34
        Me.SubOptions3.TabStop = False
        '
        'play
        '
        Me.play.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.play.Image = Global.Scanning.My.Resources.Resources.play
        Me.play.Location = New System.Drawing.Point(306, 308)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(100, 100)
        Me.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.play.TabIndex = 33
        Me.play.TabStop = False
        '
        'volumeMute
        '
        Me.volumeMute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumeMute.Image = Global.Scanning.My.Resources.Resources.volumemute
        Me.volumeMute.Location = New System.Drawing.Point(604, 411)
        Me.volumeMute.Name = "volumeMute"
        Me.volumeMute.Size = New System.Drawing.Size(100, 100)
        Me.volumeMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volumeMute.TabIndex = 31
        Me.volumeMute.TabStop = False
        '
        'volumeDown
        '
        Me.volumeDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumeDown.Image = Global.Scanning.My.Resources.Resources.volumedown
        Me.volumeDown.Location = New System.Drawing.Point(604, 288)
        Me.volumeDown.Name = "volumeDown"
        Me.volumeDown.Size = New System.Drawing.Size(100, 100)
        Me.volumeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volumeDown.TabIndex = 30
        Me.volumeDown.TabStop = False
        '
        'volumeUp
        '
        Me.volumeUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumeUp.Image = Global.Scanning.My.Resources.Resources.volumeup
        Me.volumeUp.Location = New System.Drawing.Point(604, 170)
        Me.volumeUp.Name = "volumeUp"
        Me.volumeUp.Size = New System.Drawing.Size(100, 100)
        Me.volumeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volumeUp.TabIndex = 28
        Me.volumeUp.TabStop = False
        '
        'mainMenu
        '
        Me.mainMenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.mainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainMenu.Location = New System.Drawing.Point(110, 159)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(478, 367)
        Me.mainMenu.TabIndex = 27
        Me.mainMenu.TabStop = False
        '
        'volumeOption
        '
        Me.volumeOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumeOption.Image = Global.Scanning.My.Resources.Resources.volumeControl
        Me.volumeOption.Location = New System.Drawing.Point(604, 35)
        Me.volumeOption.Name = "volumeOption"
        Me.volumeOption.Size = New System.Drawing.Size(100, 100)
        Me.volumeOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volumeOption.TabIndex = 26
        Me.volumeOption.TabStop = False
        '
        'programOption
        '
        Me.programOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.programOption.Image = Global.Scanning.My.Resources.Resources.program
        Me.programOption.Location = New System.Drawing.Point(248, 35)
        Me.programOption.Name = "programOption"
        Me.programOption.Size = New System.Drawing.Size(100, 100)
        Me.programOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.programOption.TabIndex = 25
        Me.programOption.TabStop = False
        '
        'tvOption
        '
        Me.tvOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tvOption.Image = Global.Scanning.My.Resources.Resources.tvshow
        Me.tvOption.Location = New System.Drawing.Point(488, 35)
        Me.tvOption.Name = "tvOption"
        Me.tvOption.Size = New System.Drawing.Size(100, 100)
        Me.tvOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tvOption.TabIndex = 24
        Me.tvOption.TabStop = False
        '
        'movieOption
        '
        Me.movieOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.movieOption.Image = Global.Scanning.My.Resources.Resources.movie
        Me.movieOption.Location = New System.Drawing.Point(368, 35)
        Me.movieOption.Name = "movieOption"
        Me.movieOption.Size = New System.Drawing.Size(100, 100)
        Me.movieOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.movieOption.TabIndex = 23
        Me.movieOption.TabStop = False
        '
        'musicOption
        '
        Me.musicOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.musicOption.Image = Global.Scanning.My.Resources.Resources.music
        Me.musicOption.Location = New System.Drawing.Point(127, 35)
        Me.musicOption.Name = "musicOption"
        Me.musicOption.Size = New System.Drawing.Size(100, 100)
        Me.musicOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.musicOption.TabIndex = 21
        Me.musicOption.TabStop = False
        '
        'entertainmentMenu
        '
        Me.entertainmentMenu.BackColor = System.Drawing.Color.Purple
        Me.entertainmentMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.entertainmentMenu.Location = New System.Drawing.Point(110, 24)
        Me.entertainmentMenu.Name = "entertainmentMenu"
        Me.entertainmentMenu.Size = New System.Drawing.Size(608, 129)
        Me.entertainmentMenu.TabIndex = 20
        Me.entertainmentMenu.TabStop = False
        '
        'volumeMenu
        '
        Me.volumeMenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.volumeMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.volumeMenu.Location = New System.Drawing.Point(594, 159)
        Me.volumeMenu.Name = "volumeMenu"
        Me.volumeMenu.Size = New System.Drawing.Size(124, 367)
        Me.volumeMenu.TabIndex = 29
        Me.volumeMenu.TabStop = False
        '
        'entertainmentBackground
        '
        Me.entertainmentBackground.BackColor = System.Drawing.Color.Thistle
        Me.entertainmentBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.entertainmentBackground.Location = New System.Drawing.Point(12, 12)
        Me.entertainmentBackground.Name = "entertainmentBackground"
        Me.entertainmentBackground.Size = New System.Drawing.Size(826, 527)
        Me.entertainmentBackground.TabIndex = 18
        Me.entertainmentBackground.TabStop = False
        '
        'Entertainment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.goForward)
        Me.Controls.Add(Me.goBack)
        Me.Controls.Add(Me.SubOptions5)
        Me.Controls.Add(Me.SubOptions4)
        Me.Controls.Add(Me.SubOptions3)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.volumeMute)
        Me.Controls.Add(Me.volumeDown)
        Me.Controls.Add(Me.volumeUp)
        Me.Controls.Add(Me.mainMenu)
        Me.Controls.Add(Me.volumeOption)
        Me.Controls.Add(Me.programOption)
        Me.Controls.Add(Me.tvOption)
        Me.Controls.Add(Me.movieOption)
        Me.Controls.Add(Me.musicOption)
        Me.Controls.Add(Me.entertainmentMenu)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.volumeMenu)
        Me.Controls.Add(Me.entertainmentBackground)
        Me.Name = "Entertainment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entertainment"
        CType(Me.goForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubOptions5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubOptions4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubOptions3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.programOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tvOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movieOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entertainmentMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entertainmentBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents entertainmentBackground As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents entertainmentMenu As SubOptions
    Friend WithEvents musicOption As SubOptions
    Friend WithEvents movieOption As SubOptions
    Friend WithEvents tvOption As SubOptions
    Friend WithEvents programOption As SubOptions
    Friend WithEvents volumeOption As SubOptions
    Friend WithEvents mainMenu As PictureBox
    Friend WithEvents volumeUp As SubOptions
    Friend WithEvents volumeMenu As PictureBox
    Friend WithEvents volumeDown As SubOptions
    Friend WithEvents volumeMute As SubOptions
    Friend WithEvents play As SubOptions
    Friend WithEvents SubOptions3 As SubOptions
    Friend WithEvents SubOptions4 As SubOptions
    Friend WithEvents SubOptions5 As SubOptions
    Friend WithEvents goBack As SubOptions
    Friend WithEvents goForward As SubOptions
End Class
