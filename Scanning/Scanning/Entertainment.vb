Imports System.ComponentModel

Public Class Entertainment

    Private mediaOptions(6) As SubOptions
    Private musicOptions(4) As SubOptions
    Private audioOptions(4) As SubOptions
    Private movieOptions(4) As SubOptions
    Private tvOptions(7) As SubOptions
    Private volumeOptions(3) As SubOptions

    Private shuffleOptions(3) As SubOptions
    Private playPauseAudioOptions(3) As SubOptions
    Private playPauseVisualOptions(5) As SubOptions

    Private musicGroup(7) As SubOptions
    Private audioGroup(5) As SubOptions
    Private movieGroup(7) As SubOptions
    Private tvGroup(10) As SubOptions

    Private scanninglevel1 As SubOptions
    Private MyParent As Livingroom

    Public Sub New(parentForm)

        InitializeComponent()

        '
        'initialize top scanning level group
        '

        mediaOptions(0) = musicOption
        mediaOptions(1) = programOption
        mediaOptions(2) = movieOption
        mediaOptions(3) = tvOption
        mediaOptions(4) = volumeOption
        mediaOptions(5) = tvPower
        mediaOptions(6) = MainTaskBar.MenuBarOption

        For i = 0 To 6
            mediaOptions(i).Initialize()
        Next

        '
        'initialize middle scanning level groups
        '

        musicOptions(0) = artistOption
        musicOptions(1) = playlistOption
        musicOptions(2) = shuffle
        musicOptions(3) = goBack
        musicOptions(4) = MainTaskBar.Back

        For i = 0 To 4
            musicOptions(i).Initialize()
        Next

        audioOptions(0) = radio
        audioOptions(1) = podcast
        audioOptions(2) = recording
        audioOptions(3) = goBack
        audioOptions(4) = MainTaskBar.Back

        For i = 0 To 2
            audioOptions(i).Initialize()
        Next

        movieOptions(0) = Netflix
        movieOptions(1) = Hulu
        movieOptions(2) = Amazon
        movieOptions(3) = prevVideo
        movieOptions(4) = MainTaskBar.Back

        For i = 0 To 3
            movieOptions(i).Initialize()
        Next

        tvOptions(0) = Netflix
        tvOptions(1) = Hulu
        tvOptions(2) = Amazon
        tvOptions(3) = liveVideo
        tvOptions(4) = streamVideo
        tvOptions(5) = recordedVideo
        tvOptions(6) = prevVideo
        tvOptions(7) = MainTaskBar.Back

        For i = 3 To 5
            tvOptions(i).Initialize()
        Next

        volumeOptions(0) = volumeUp
        volumeOptions(1) = volumeDown
        volumeOptions(2) = volumeMute
        volumeOptions(3) = MainTaskBar.Back

        For i = 0 To 2
            volumeOptions.Initialize()
        Next

        '
        'initialize lower scanning level groups
        '

        shuffleOptions(0) = shuffle
        shuffleOptions(1) = repeat
        shuffleOptions(2) = repeatOne
        shuffleOptions(3) = MainTaskBar.Back

        For i = 1 To 2
            shuffleOptions(i).Initialize()
        Next

        playPauseAudioOptions(0) = goBack
        playPauseAudioOptions(1) = play
        playPauseAudioOptions(2) = goForward
        playPauseAudioOptions(3) = MainTaskBar.Back

        For i = 1 To 2
            playPauseAudioOptions(i).Initialize()
        Next

        playPauseVisualOptions(0) = prevVideo
        playPauseVisualOptions(1) = skipBack
        playPauseVisualOptions(2) = play
        playPauseVisualOptions(3) = skipForward
        playPauseVisualOptions(4) = nextVideo
        playPauseVisualOptions(5) = MainTaskBar.Back

        For i = 1 To 4
            playPauseVisualOptions(i).Initialize()
        Next

        '
        'create media groups
        '

        musicGroup(0) = artistOption
        musicGroup(1) = playlistOption
        musicGroup(2) = goBack
        musicGroup(3) = play
        musicGroup(4) = goForward
        musicGroup(5) = shuffle
        musicGroup(6) = repeat
        musicGroup(7) = repeatOne

        audioGroup(0) = radio
        audioGroup(1) = podcast
        audioGroup(2) = recording
        audioGroup(3) = goBack
        audioGroup(4) = play
        audioGroup(5) = goForward

        movieGroup(0) = Netflix
        movieGroup(1) = Hulu
        movieGroup(2) = Amazon
        movieGroup(3) = prevVideo
        movieGroup(4) = skipBack
        movieGroup(5) = play
        movieGroup(6) = skipForward
        movieGroup(7) = nextVideo

        tvGroup(0) = Netflix
        tvGroup(1) = Hulu
        tvGroup(2) = Amazon
        tvGroup(3) = liveVideo
        tvGroup(4) = streamVideo
        tvGroup(5) = recordedVideo
        tvGroup(6) = prevVideo
        tvGroup(7) = skipBack
        tvGroup(8) = play
        tvGroup(9) = skipForward
        tvGroup(10) = nextVideo

        '
        'assign parent form
        '

        MyParent = parentForm

    End Sub

    Private Sub Entertainment_Load(sender As Object, e As EventArgs) Handles Me.Load
        MainTaskBar.PreviousScreen.Image = My.Resources.livingroomButton
    End Sub

#Region "Timer Properties and methods"

    ' Make the Scanningtimer interval accessible 
    Public Property ScanningInterval As Integer
        Get
            Return ScanningTimer.Interval
        End Get
        Set(value As Integer)
            ScanningTimer.Interval = value
        End Set
    End Property
#End Region

#Region "Scanning functionality"

    Private scanninglevel As Integer
    Private focusIsOn As Integer

    ' Start scanning on the first submenu
    Public Sub StartScanning()
        scanninglevel = 0
        focusIsOn = 0
        mediaOptions(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        ScanningTimer.Stop()
        mediaOptions(focusIsOn).LoseFocus()
        Me.Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        scanninglevel = 0
        mediaOptions(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            mediaOptions(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 6
            mediaOptions(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            mediaOptions(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            scanninglevel1.InnerScanningNext()
        End If
    End Sub

    Private Sub goBack_ColorChanged(sender As Object, e As EventArgs) Handles goBack.BackColorChanged
        If scanninglevel = 1 And ScanningTimer.Enabled Then
            If goBack.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To playPauseAudioOptions.Length - 2
                    playPauseAudioOptions(i).ReceiveFocus()
                Next
            Else
                For i = 1 To playPauseAudioOptions.Length - 2
                    playPauseAudioOptions(i).LoseFocus()
                Next
            End If
        End If
    End Sub

    Private Sub shuffle_ColorChanged(sender As Object, e As EventArgs) Handles shuffle.BackColorChanged
        If scanninglevel = 1 And ScanningTimer.Enabled Then
            If shuffle.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To shuffleOptions.Length - 2
                    shuffleOptions(i).ReceiveFocus()
                Next
            Else
                For i = 1 To shuffleOptions.Length - 2
                    shuffleOptions(i).LoseFocus()
                Next
            End If
        End If
    End Sub

    Private Sub prevVideok_ColorChanged(sender As Object, e As EventArgs) Handles prevVideo.BackColorChanged
        If scanninglevel = 1 And ScanningTimer.Enabled Then
            If prevVideo.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To playPauseVisualOptions.Length - 2
                    playPauseVisualOptions(i).ReceiveFocus()
                Next
            Else
                For i = 1 To playPauseVisualOptions.Length - 2
                    playPauseVisualOptions(i).LoseFocus()
                Next
            End If
        End If
    End Sub

#End Region

#Region "Other events"

    Private currentlyShowing As SubOptions()

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub Entertainment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Then
                If currentlyShowing IsNot Nothing Then
                    For i = 0 To currentlyShowing.Length - 1
                        currentlyShowing(i).Hide()
                    Next
                End If
                For i = 0 To 7
                    musicGroup(i).Show()
                Next
                currentlyShowing = musicGroup
                mediaOptions(focusIsOn).StartInnerScanning(musicOptions)
            ElseIf focusIsOn = 1 Then
                If currentlyShowing IsNot Nothing Then
                    For i = 0 To currentlyShowing.Length - 1
                        currentlyShowing(i).Hide()
                    Next
                End If
                For i = 0 To 5
                    audioGroup(i).Show()
                Next
                currentlyShowing = audioGroup
                mediaOptions(focusIsOn).StartInnerScanning(audioOptions)
            ElseIf focusIsOn = 2 Then
                If currentlyShowing IsNot Nothing Then
                    For i = 0 To currentlyShowing.Length - 1
                        currentlyShowing(i).Hide()
                    Next
                End If
                For i = 0 To 7
                    movieGroup(i).Show()
                Next
                If tvPower.Tag = "off" Then
                    tvPower.Image = My.Resources.tvOn
                    tvPower.Tag = "on"
                End If
                currentlyShowing = movieGroup
                mediaOptions(focusIsOn).StartInnerScanning(movieOptions)
            ElseIf focusIsOn = 3 Then
                If currentlyShowing IsNot Nothing Then
                    For i = 0 To currentlyShowing.Length - 1
                        currentlyShowing(i).Hide()
                    Next
                End If
                For i = 0 To 10
                    tvGroup(i).Show()
                Next
                If tvPower.Tag = "off" Then
                    tvPower.Image = My.Resources.tvOn
                    tvPower.Tag = "on"
                End If
                currentlyShowing = tvGroup
                mediaOptions(focusIsOn).StartInnerScanning(tvOptions)
            ElseIf focusIsOn = 4 Then
                mediaOptions(focusIsOn).StartInnerScanning(volumeOptions)
            ElseIf focusIsOn = 5 Then
                If tvPower.Tag = "on" Then
                    tvPower.Image = My.Resources.tvOff
                    tvPower.Tag = "off"
                    If Netflix.Visible = True Then
                        For i = 0 To currentlyShowing.Length - 1
                            currentlyShowing(i).Hide()
                        Next
                    End If
                ElseIf tvPower.Tag = "off" Then
                    tvPower.Image = My.Resources.tvOn
                    tvPower.Tag = "on"
                End If
                scanninglevel = 0
            ElseIf focusIsOn = 6 Then
                MainTaskBar.MenuBarOption.LoseFocus()
                mediaOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())
            End If
        ElseIf scanninglevel = 1 Then
            If goBack.BackColor = Color.LemonChiffon Then
                scanninglevel = 2
                goBack.StartInnerScanning(playPauseAudioOptions)
                scanninglevel1 = goBack
            ElseIf shuffle.BackColor = Color.LemonChiffon Then
                scanninglevel = 2
                shuffle.StartInnerScanning(shuffleOptions)
                scanninglevel1 = shuffle
            ElseIf prevVideo.BackColor = Color.LemonChiffon Then
                scanninglevel = 2
                prevVideo.StartInnerScanning(playPauseVisualOptions)
                scanninglevel1 = prevVideo
            ElseIf MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                If focusIsOn = 5 Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
                    scanninglevel = 0
                Else
                    mediaOptions(focusIsOn).StopInnerScanning()
                    scanninglevel = 0
                End If
            ElseIf MainTaskBar.Assistance.BackColor = Color.LemonChiffon Then
                Dim Assistance As New Assistance(Me)
                StopScanning()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()
            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then
                StopScanning()
                MainTaskBar.PreviousScreen.LoseFocus()
                Me.Hide()
                MyParent.ResumeScanning()
            End If
        ElseIf scanninglevel = 2 Then
            If play.BackColor = Color.LemonChiffon Then
                If play.Tag = "play" Then
                    play.Image = My.Resources.pause
                    play.Tag = "pause"
                ElseIf play.Tag = "pause" Then
                    play.Image = My.Resources.play
                    play.Tag = "play"
                End If
            ElseIf shuffle.BackColor = Color.LemonChiffon Then
                If shuffle.Tag = "notShuffling" Then
                    shuffle.Image = My.Resources.shuffleActivated
                    play.Tag = "shuffling"
                ElseIf play.Tag = "shuffling" Then
                    play.Image = My.Resources.shuffle
                    play.Tag = "notShuffling"
                End If
            ElseIf repeat.BackColor = Color.LemonChiffon Then
                If repeat.Tag = "notRepeating" Then
                    repeat.Image = My.Resources.repeatActivated
                    repeatOne.Image = My.Resources.repeatOne
                    repeat.Tag = "repeating"
                ElseIf repeat.Tag = "repeating" Then
                    repeat.Image = My.Resources.repeat
                    repeat.Tag = "notRepeating"
                End If
            ElseIf repeatOne.BackColor = Color.LemonChiffon Then
                If repeatOne.Tag = "notRepeatingOne" Then
                    repeatOne.Image = My.Resources.repeatOneActivated
                    repeat.Image = My.Resources.repeat
                    repeatOne.Tag = "repeatingOne"
                ElseIf repeatOne.Tag = "repeatingOne" Then
                    repeatOne.Image = My.Resources.repeatOne
                    repeatOne.Tag = "notRepeatingOne"
                End If
            ElseIf MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                scanninglevel1.StopInnerScanning()
                scanninglevel = 1
            End If

        End If
    End Sub

    Private Sub Entertainment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub

#End Region

End Class