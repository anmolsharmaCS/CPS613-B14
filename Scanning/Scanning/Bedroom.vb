Imports System.ComponentModel

Public Class Bedroom
    Private TopOptions(3) As SubOptions
    Private environment(2) As SubOptions
    Private Windows(1) As SubOptions
    Public shutters(1) As PictureBox
    Private MyParent As UserApartment

    Public Sub New(parentForm As UserApartment)
        ' This call is required by the designer.
        InitializeComponent()

        TopOptions(0) = MainTaskBar.MenuBarOption
        TopOptions(1) = BedroomWindow1
        TopOptions(2) = Bed
        TopOptions(3) = envOption

        For i = 0 To 3
            TopOptions(i).Initialize()
        Next

        environment(0) = LightControl
        environment(1) = FanControl
        environment(2) = exitEnv

        For i = 0 To 2
            environment.Initialize()
        Next

        Windows(0) = BedroomWindow1
        Windows(1) = BedroomWindow2

        For i = 0 To 1
            Windows(i).Initialize()
        Next

        shutters(0) = bedroomShutters1
        shutters(1) = bedroomShutters2

        MyParent = parentForm

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
        TopOptions(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        ScanningTimer.Stop()
        TopOptions(focusIsOn).LoseFocus()
        Me.Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        scanninglevel = 0
        TopOptions(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            TopOptions(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 4
            TopOptions(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            TopOptions(focusIsOn).InnerScanningNext()
        End If
    End Sub



#End Region

#Region "Other Events"

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 Then

            If focusIsOn = 0 Then

                scanninglevel = 1
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then

                scanninglevel = 1
                WindowMenu.Show()
                TopOptions(focusIsOn).StartInnerScanning(WindowMenu.GetTaskBarOptions)

            ElseIf focusIsOn = 2 Then

                If Bed.Tag = "up" Then
                    Bed.Image = My.Resources.bedDown
                    Bed.Tag = "down"
                ElseIf Bed.Tag = "down" Then
                    Bed.Image = My.Resources.bedUp
                    Bed.Tag = "up"
                End If

            ElseIf focusIsOn = 3 Then
                scanninglevel = 1
                envOption.LoseFocus()
                exitEnv.Show()
                TopOptions(focusIsOn).StartInnerScanning(environment)
            End If
        ElseIf scanninglevel = 1 Then
            If LightControl.BackColor = Color.LemonChiffon Then

                If LightControl.Tag = "on" Then

                    LightControl.Image = My.Resources.bulbUnlit
                    MyParent.bedroomLight.Image = My.Resources.bulbUnlit
                    LightControl.Tag = "off"

                ElseIf LightControl.Tag = "off" Then

                    LightControl.Image = My.Resources.bulbLit
                    MyParent.bedroomLight.Image = My.Resources.bulbLit
                    LightControl.Tag = "on"

                End If

            ElseIf FanControl.BackColor = Color.LemonChiffon Then

                If FanControl.Tag = "on" Then

                    FanControl.Image = My.Resources.fanOff
                    MyParent.bedroomFan.Image = My.Resources.fanOff
                    FanControl.Tag = "off"

                ElseIf FanControl.Tag = "off" Then

                    FanControl.Image = My.Resources.fanOn
                    MyParent.bedroomFan.Image = My.Resources.fanOn
                    FanControl.Tag = "on"

                End If

            ElseIf exitEnv.BackColor = Color.LemonChiffon Then

                exitEnv.Hide()
                envOption.StopInnerScanning()
                scanninglevel = 0

            ElseIf WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                Me.WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf Me.WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.windowControl.Tag = "open" Then

                    WindowMenu.windowControl.Image = My.Resources.WindowClosed
                    WindowMenu.windowControl.Tag = "closed"
                    For i = 0 To shutters.Length - 1

                        shutters(i).Hide()

                    Next
                    MyParent.BedroomWindow1Shutters.Hide()
                    MyParent.BedroomWindow2Shutters.Hide()

                ElseIf WindowMenu.windowControl.Tag = "closed" Then

                    WindowMenu.windowControl.Image = My.Resources.WindowOpen
                    WindowMenu.windowControl.Tag = "open"
                    For i = 0 To shutters.Length - 1

                        shutters(i).Show()

                    Next
                    MyParent.BedroomWindow1Shutters.Show()
                    MyParent.BedroomWindow2Shutters.Show()

                End If

            ElseIf Me.WindowMenu.blindControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.blindControl.Tag = "open" Then

                    WindowMenu.blindControl.Image = My.Resources.BlindsClosed
                    WindowMenu.blindControl.Tag = "closed"
                    'For i = 0 To blinds.Length - 1
                    'blinds(i).Hide()
                    'Next

                ElseIf WindowMenu.blindControl.Tag = "closed" Then

                    WindowMenu.blindControl.Image = My.Resources.BlindsOpen
                    WindowMenu.blindControl.Tag = "open"
                    'For i = 0 To blinds.Length - 1
                    'blinds(i).Show()
                    'Next

                End If

            ElseIf MainTaskBar.exitTaskBar.BackColor = Color.LemonChiffon Then

                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                scanninglevel = 0

            ElseIf MainTaskBar.Assistance.BackColor = Color.LemonChiffon Then

                Dim Assistance As New Assistance(Me)
                StopScanning()
                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()

            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then

                StopScanning()
                MainTaskBar.PreviousScreen.LoseFocus()
                MainTaskBar.exitTaskBar.Hide()
                Me.Hide()
                MyParent.ResumeScanning()

            End If

        End If
    End Sub

    Private Sub Groups_ColorChanged(sender As Object, e As EventArgs) Handles BedroomWindow1.BackColorChanged, LightControl.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If LightControl.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To environment.Length - 2
                    environment(i).ReceiveFocus()
                Next
            Else
                For i = 1 To environment.Length - 2
                    environment(i).LoseFocus()
                Next
            End If

            If BedroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
                For i = 0 To Windows.Length - 1
                    Windows(i).ReceiveFocus()
                Next
            Else
                For i = 0 To Windows.Length - 1
                    Windows(i).LoseFocus()
                Next
            End If

        End If
    End Sub

    Private Sub Bedroom_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub
#End Region

End Class