Imports System.ComponentModel

Public Class Entertainment

    Private mediaOptions(5) As SubOptions
    Private musicOptions(4) As SubOptions
    'Private programOptions(5) As SubOptions
    'Private movieOptions(0) As SubOptions
    'Private tvOptions(0) As SubOptions
    Private volumeOptions(3) As SubOptions

    Private musicGroup(8) As SubOptions

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        InitializeComponent()

        mediaOptions(0) = musicOption
        mediaOptions(1) = programOption
        mediaOptions(2) = movieOption
        mediaOptions(3) = tvOption
        mediaOptions(4) = volumeOption
        mediaOptions(5) = MainTaskBar.MenuBarOption

        For i = 0 To 5
            mediaOptions(i).Initialize()
        Next

        musicOptions(0) = artistOption
        musicOptions(1) = playlistOption
        musicOptions(2) = goBack
        musicOptions(3) = shuffle
        musicOptions(4) = MainTaskBar.Back

        For i = 0 To 4
            musicOptions(i).Initialize()
        Next

        musicGroup(0) = mainMenu
        musicGroup(1) = artistOption
        musicGroup(2) = playlistOption
        musicGroup(3) = goBack
        musicGroup(4) = play
        musicGroup(5) = goForward
        musicGroup(6) = shuffle
        musicGroup(7) = repeat
        musicGroup(8) = repeatOne

        volumeOptions(0) = volumeUp
        volumeOptions(1) = volumeDown
        volumeOptions(2) = volumeMute
        volumeOptions(3) = MainTaskBar.Back

        For i = 0 To 2
            volumeOptions.Initialize()
        Next

        MyParent = parentForm

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        StartScanning()
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
        End If
    End Sub

#End Region

#Region "Other events"

    Private currentlyShowing As SubOptions()

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Then
                If currentlyShowing IsNot Nothing Then
                    For i = 0 To currentlyShowing.Length - 1
                        currentlyShowing(i).Hide()
                    Next
                End If
                For i = 0 To 8
                    musicGroup(i).Show()
                Next
                currentlyShowing = musicGroup
                mediaOptions(focusIsOn).MenuBar = True
                mediaOptions(focusIsOn).StartInnerScanning(musicOptions)
            ElseIf focusIsOn = 1 Then

            ElseIf focusIsOn = 2 Then

            ElseIf focusIsOn = 3 Then

            ElseIf focusIsOn = 4 Then
                mediaOptions(focusIsOn).MenuBar = True
                mediaOptions(focusIsOn).StartInnerScanning(volumeOptions)
            ElseIf focusIsOn = 5 Then
                MainTaskBar.MenuBarOption.LoseFocus()
                MainTaskBar.MenuBarOption.MenuBar = True
                mediaOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())
            End If
        Else
            If MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                If focusIsOn = 5 Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
                    scanninglevel = 0
                Else
                    mediaOptions(focusIsOn).StopInnerScanning()
                    scanninglevel = 0
                End If
            ElseIf MainTaskBar.Assistance.BackColor = Color.LemonChiffon Then
                Dim Assistance As New assistance(Me)
                StopScanning()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()
            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then
                StopScanning()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Entertainment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub

#End Region

End Class