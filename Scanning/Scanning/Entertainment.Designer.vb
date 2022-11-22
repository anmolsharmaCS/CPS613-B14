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
        Me.components = New System.ComponentModel.Container()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.streamVideo = New Scanning.SubOptions()
        Me.recordedVideo = New Scanning.SubOptions()
        Me.liveVideo = New Scanning.SubOptions()
        Me.prevVideo = New Scanning.SubOptions()
        Me.nextVideo = New Scanning.SubOptions()
        Me.skipBack = New Scanning.SubOptions()
        Me.skipForward = New Scanning.SubOptions()
        Me.Netflix = New Scanning.SubOptions()
        Me.Hulu = New Scanning.SubOptions()
        Me.Amazon = New Scanning.SubOptions()
        Me.podcast = New Scanning.SubOptions()
        Me.recording = New Scanning.SubOptions()
        Me.radio = New Scanning.SubOptions()
        Me.playlistOption = New Scanning.SubOptions()
        Me.artistOption = New Scanning.SubOptions()
        Me.goForward = New Scanning.SubOptions()
        Me.goBack = New Scanning.SubOptions()
        Me.shuffle = New Scanning.SubOptions()
        Me.repeat = New Scanning.SubOptions()
        Me.repeatOne = New Scanning.SubOptions()
        Me.play = New Scanning.SubOptions()
        Me.volumeMute = New Scanning.SubOptions()
        Me.volumeDown = New Scanning.SubOptions()
        Me.volumeUp = New Scanning.SubOptions()
        Me.volumeOption = New Scanning.SubOptions()
        Me.programOption = New Scanning.SubOptions()
        Me.tvOption = New Scanning.SubOptions()
        Me.movieOption = New Scanning.SubOptions()
        Me.musicOption = New Scanning.SubOptions()
        Me.entertainmentMenu = New Scanning.SubOptions()
        Me.volumeMenu = New System.Windows.Forms.PictureBox()
        Me.mainMenu = New Scanning.SubOptions()
        Me.entertainmentBackground = New System.Windows.Forms.PictureBox()
        Me.tvPower = New Scanning.SubOptions()
        CType(Me.streamVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recordedVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.liveVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prevVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skipBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skipForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Netflix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hulu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amazon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.podcast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recording, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playlistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.artistOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shuffle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repeatOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.programOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tvOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movieOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.musicOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entertainmentMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volumeMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entertainmentBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tvPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(161, 556)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 19
        '
        'streamVideo
        '
        Me.streamVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.streamVideo.Image = Global.Scanning.My.Resources.Resources.stream
        Me.streamVideo.Location = New System.Drawing.Point(211, 307)
        Me.streamVideo.Name = "streamVideo"
        Me.streamVideo.Size = New System.Drawing.Size(131, 90)
        Me.streamVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.streamVideo.TabIndex = 54
        Me.streamVideo.TabStop = False
        Me.streamVideo.Visible = False
        '
        'recordedVideo
        '
        Me.recordedVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recordedVideo.Image = Global.Scanning.My.Resources.Resources.recordedVideo
        Me.recordedVideo.Location = New System.Drawing.Point(363, 307)
        Me.recordedVideo.Name = "recordedVideo"
        Me.recordedVideo.Size = New System.Drawing.Size(129, 90)
        Me.recordedVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.recordedVideo.TabIndex = 53
        Me.recordedVideo.TabStop = False
        Me.recordedVideo.Visible = False
        '
        'liveVideo
        '
        Me.liveVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.liveVideo.Image = Global.Scanning.My.Resources.Resources.live
        Me.liveVideo.Location = New System.Drawing.Point(58, 307)
        Me.liveVideo.Name = "liveVideo"
        Me.liveVideo.Size = New System.Drawing.Size(131, 90)
        Me.liveVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.liveVideo.TabIndex = 52
        Me.liveVideo.TabStop = False
        Me.liveVideo.Visible = False
        '
        'prevVideo
        '
        Me.prevVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.prevVideo.Image = Global.Scanning.My.Resources.Resources.previousVideo
        Me.prevVideo.Location = New System.Drawing.Point(58, 441)
        Me.prevVideo.Name = "prevVideo"
        Me.prevVideo.Size = New System.Drawing.Size(70, 70)
        Me.prevVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.prevVideo.TabIndex = 51
        Me.prevVideo.TabStop = False
        Me.prevVideo.Visible = False
        '
        'nextVideo
        '
        Me.nextVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nextVideo.Image = Global.Scanning.My.Resources.Resources.nextVideo
        Me.nextVideo.Location = New System.Drawing.Point(422, 441)
        Me.nextVideo.Name = "nextVideo"
        Me.nextVideo.Size = New System.Drawing.Size(70, 70)
        Me.nextVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nextVideo.TabIndex = 50
        Me.nextVideo.TabStop = False
        Me.nextVideo.Visible = False
        '
        'skipBack
        '
        Me.skipBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.skipBack.Image = Global.Scanning.My.Resources.Resources.skipBack
        Me.skipBack.Location = New System.Drawing.Point(134, 421)
        Me.skipBack.Name = "skipBack"
        Me.skipBack.Size = New System.Drawing.Size(90, 90)
        Me.skipBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.skipBack.TabIndex = 49
        Me.skipBack.TabStop = False
        Me.skipBack.Visible = False
        '
        'skipForward
        '
        Me.skipForward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.skipForward.Image = Global.Scanning.My.Resources.Resources.skipForward
        Me.skipForward.Location = New System.Drawing.Point(326, 421)
        Me.skipForward.Name = "skipForward"
        Me.skipForward.Size = New System.Drawing.Size(90, 90)
        Me.skipForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.skipForward.TabIndex = 48
        Me.skipForward.TabStop = False
        Me.skipForward.Visible = False
        '
        'Netflix
        '
        Me.Netflix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Netflix.Image = Global.Scanning.My.Resources.Resources.netflix
        Me.Netflix.Location = New System.Drawing.Point(58, 170)
        Me.Netflix.Name = "Netflix"
        Me.Netflix.Size = New System.Drawing.Size(131, 131)
        Me.Netflix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Netflix.TabIndex = 47
        Me.Netflix.TabStop = False
        Me.Netflix.Visible = False
        '
        'Hulu
        '
        Me.Hulu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Hulu.Image = Global.Scanning.My.Resources.Resources.hulu
        Me.Hulu.Location = New System.Drawing.Point(211, 170)
        Me.Hulu.Name = "Hulu"
        Me.Hulu.Size = New System.Drawing.Size(131, 131)
        Me.Hulu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hulu.TabIndex = 46
        Me.Hulu.TabStop = False
        Me.Hulu.Visible = False
        '
        'Amazon
        '
        Me.Amazon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Amazon.Image = Global.Scanning.My.Resources.Resources.prime
        Me.Amazon.Location = New System.Drawing.Point(363, 170)
        Me.Amazon.Name = "Amazon"
        Me.Amazon.Size = New System.Drawing.Size(131, 131)
        Me.Amazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Amazon.TabIndex = 45
        Me.Amazon.TabStop = False
        Me.Amazon.Visible = False
        '
        'podcast
        '
        Me.podcast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.podcast.Image = Global.Scanning.My.Resources.Resources.podcast
        Me.podcast.Location = New System.Drawing.Point(211, 170)
        Me.podcast.Name = "podcast"
        Me.podcast.Size = New System.Drawing.Size(131, 131)
        Me.podcast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.podcast.TabIndex = 44
        Me.podcast.TabStop = False
        Me.podcast.Visible = False
        '
        'recording
        '
        Me.recording.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recording.Image = Global.Scanning.My.Resources.Resources.localRecording
        Me.recording.Location = New System.Drawing.Point(363, 170)
        Me.recording.Name = "recording"
        Me.recording.Size = New System.Drawing.Size(131, 131)
        Me.recording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.recording.TabIndex = 43
        Me.recording.TabStop = False
        Me.recording.Visible = False
        '
        'radio
        '
        Me.radio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.radio.Image = Global.Scanning.My.Resources.Resources.radio
        Me.radio.Location = New System.Drawing.Point(58, 170)
        Me.radio.Name = "radio"
        Me.radio.Size = New System.Drawing.Size(131, 131)
        Me.radio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.radio.TabIndex = 42
        Me.radio.TabStop = False
        Me.radio.Visible = False
        '
        'playlistOption
        '
        Me.playlistOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.playlistOption.Image = Global.Scanning.My.Resources.Resources.playlist
        Me.playlistOption.Location = New System.Drawing.Point(58, 243)
        Me.playlistOption.Name = "playlistOption"
        Me.playlistOption.Size = New System.Drawing.Size(436, 58)
        Me.playlistOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playlistOption.TabIndex = 40
        Me.playlistOption.TabStop = False
        Me.playlistOption.Visible = False
        '
        'artistOption
        '
        Me.artistOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.artistOption.Image = Global.Scanning.My.Resources.Resources.artist
        Me.artistOption.Location = New System.Drawing.Point(58, 170)
        Me.artistOption.Name = "artistOption"
        Me.artistOption.Size = New System.Drawing.Size(436, 58)
        Me.artistOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.artistOption.TabIndex = 39
        Me.artistOption.TabStop = False
        Me.artistOption.Visible = False
        '
        'goForward
        '
        Me.goForward.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.goForward.Image = Global.Scanning.My.Resources.Resources.forward
        Me.goForward.Location = New System.Drawing.Point(326, 421)
        Me.goForward.Name = "goForward"
        Me.goForward.Size = New System.Drawing.Size(90, 90)
        Me.goForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goForward.TabIndex = 38
        Me.goForward.TabStop = False
        Me.goForward.Visible = False
        '
        'goBack
        '
        Me.goBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.goBack.Image = Global.Scanning.My.Resources.Resources.rewind
        Me.goBack.Location = New System.Drawing.Point(134, 421)
        Me.goBack.Name = "goBack"
        Me.goBack.Size = New System.Drawing.Size(90, 90)
        Me.goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goBack.TabIndex = 37
        Me.goBack.TabStop = False
        Me.goBack.Visible = False
        '
        'shuffle
        '
        Me.shuffle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.shuffle.Image = Global.Scanning.My.Resources.Resources.shuffle
        Me.shuffle.Location = New System.Drawing.Point(164, 345)
        Me.shuffle.Name = "shuffle"
        Me.shuffle.Size = New System.Drawing.Size(70, 70)
        Me.shuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shuffle.TabIndex = 36
        Me.shuffle.TabStop = False
        Me.shuffle.Tag = "notShuffling"
        Me.shuffle.Visible = False
        '
        'repeat
        '
        Me.repeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.repeat.Image = Global.Scanning.My.Resources.Resources.repeat
        Me.repeat.Location = New System.Drawing.Point(240, 345)
        Me.repeat.Name = "repeat"
        Me.repeat.Size = New System.Drawing.Size(70, 70)
        Me.repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.repeat.TabIndex = 35
        Me.repeat.TabStop = False
        Me.repeat.Tag = "notRepeating"
        Me.repeat.Visible = False
        '
        'repeatOne
        '
        Me.repeatOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.repeatOne.Image = Global.Scanning.My.Resources.Resources.repeatOne
        Me.repeatOne.Location = New System.Drawing.Point(316, 345)
        Me.repeatOne.Name = "repeatOne"
        Me.repeatOne.Size = New System.Drawing.Size(70, 70)
        Me.repeatOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.repeatOne.TabIndex = 34
        Me.repeatOne.TabStop = False
        Me.repeatOne.Tag = "notRepeatingOne"
        Me.repeatOne.Visible = False
        '
        'play
        '
        Me.play.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.play.Image = Global.Scanning.My.Resources.Resources.play
        Me.play.Location = New System.Drawing.Point(230, 421)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(90, 90)
        Me.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.play.TabIndex = 33
        Me.play.TabStop = False
        Me.play.Tag = "play"
        Me.play.Visible = False
        '
        'volumeMute
        '
        Me.volumeMute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumeMute.Image = Global.Scanning.My.Resources.Resources.volumemute
        Me.volumeMute.Location = New System.Drawing.Point(526, 411)
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
        Me.volumeDown.Location = New System.Drawing.Point(526, 288)
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
        Me.volumeUp.Location = New System.Drawing.Point(526, 170)
        Me.volumeUp.Name = "volumeUp"
        Me.volumeUp.Size = New System.Drawing.Size(100, 100)
        Me.volumeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volumeUp.TabIndex = 28
        Me.volumeUp.TabStop = False
        '
        'volumeOption
        '
        Me.volumeOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.volumeOption.Image = Global.Scanning.My.Resources.Resources.volumeControl
        Me.volumeOption.Location = New System.Drawing.Point(526, 35)
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
        Me.programOption.Location = New System.Drawing.Point(170, 35)
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
        Me.tvOption.Location = New System.Drawing.Point(410, 35)
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
        Me.movieOption.Location = New System.Drawing.Point(290, 35)
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
        Me.musicOption.Location = New System.Drawing.Point(49, 35)
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
        Me.entertainmentMenu.Location = New System.Drawing.Point(32, 24)
        Me.entertainmentMenu.Name = "entertainmentMenu"
        Me.entertainmentMenu.Size = New System.Drawing.Size(608, 129)
        Me.entertainmentMenu.TabIndex = 20
        Me.entertainmentMenu.TabStop = False
        '
        'volumeMenu
        '
        Me.volumeMenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.volumeMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.volumeMenu.Location = New System.Drawing.Point(516, 159)
        Me.volumeMenu.Name = "volumeMenu"
        Me.volumeMenu.Size = New System.Drawing.Size(124, 367)
        Me.volumeMenu.TabIndex = 29
        Me.volumeMenu.TabStop = False
        '
        'mainMenu
        '
        Me.mainMenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.mainMenu.Location = New System.Drawing.Point(32, 159)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(478, 367)
        Me.mainMenu.TabIndex = 41
        Me.mainMenu.TabStop = False
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
        'tvPower
        '
        Me.tvPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tvPower.Image = Global.Scanning.My.Resources.Resources.tvOff
        Me.tvPower.Location = New System.Drawing.Point(646, 24)
        Me.tvPower.Name = "tvPower"
        Me.tvPower.Size = New System.Drawing.Size(183, 129)
        Me.tvPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tvPower.TabIndex = 55
        Me.tvPower.TabStop = False
        '
        'Entertainment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.tvPower)
        Me.Controls.Add(Me.streamVideo)
        Me.Controls.Add(Me.recordedVideo)
        Me.Controls.Add(Me.liveVideo)
        Me.Controls.Add(Me.prevVideo)
        Me.Controls.Add(Me.nextVideo)
        Me.Controls.Add(Me.skipBack)
        Me.Controls.Add(Me.skipForward)
        Me.Controls.Add(Me.Netflix)
        Me.Controls.Add(Me.Hulu)
        Me.Controls.Add(Me.Amazon)
        Me.Controls.Add(Me.podcast)
        Me.Controls.Add(Me.recording)
        Me.Controls.Add(Me.radio)
        Me.Controls.Add(Me.playlistOption)
        Me.Controls.Add(Me.artistOption)
        Me.Controls.Add(Me.goForward)
        Me.Controls.Add(Me.goBack)
        Me.Controls.Add(Me.shuffle)
        Me.Controls.Add(Me.repeat)
        Me.Controls.Add(Me.repeatOne)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.volumeMute)
        Me.Controls.Add(Me.volumeDown)
        Me.Controls.Add(Me.volumeUp)
        Me.Controls.Add(Me.volumeOption)
        Me.Controls.Add(Me.programOption)
        Me.Controls.Add(Me.tvOption)
        Me.Controls.Add(Me.movieOption)
        Me.Controls.Add(Me.musicOption)
        Me.Controls.Add(Me.entertainmentMenu)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.volumeMenu)
        Me.Controls.Add(Me.mainMenu)
        Me.Controls.Add(Me.entertainmentBackground)
        Me.KeyPreview = True
        Me.Name = "Entertainment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "off"
        Me.Text = "Entertainment"
        CType(Me.streamVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recordedVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.liveVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prevVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skipBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skipForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Netflix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hulu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amazon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.podcast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recording, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playlistOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.artistOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shuffle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repeatOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.programOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tvOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movieOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.musicOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entertainmentMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volumeMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entertainmentBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tvPower, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents volumeUp As SubOptions
    Friend WithEvents volumeMenu As PictureBox
    Friend WithEvents volumeDown As SubOptions
    Friend WithEvents volumeMute As SubOptions
    Friend WithEvents play As SubOptions
    Friend WithEvents repeatOne As SubOptions
    Friend WithEvents repeat As SubOptions
    Friend WithEvents shuffle As SubOptions
    Friend WithEvents goBack As SubOptions
    Friend WithEvents goForward As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents artistOption As SubOptions
    Friend WithEvents playlistOption As SubOptions
    Friend WithEvents mainMenu As SubOptions
    Friend WithEvents radio As SubOptions
    Friend WithEvents recording As SubOptions
    Friend WithEvents podcast As SubOptions
    Friend WithEvents Amazon As SubOptions
    Friend WithEvents Hulu As SubOptions
    Friend WithEvents Netflix As SubOptions
    Friend WithEvents skipForward As SubOptions
    Friend WithEvents skipBack As SubOptions
    Friend WithEvents nextVideo As SubOptions
    Friend WithEvents prevVideo As SubOptions
    Friend WithEvents liveVideo As SubOptions
    Friend WithEvents recordedVideo As SubOptions
    Friend WithEvents streamVideo As SubOptions
    Friend WithEvents tvPower As SubOptions
End Class
