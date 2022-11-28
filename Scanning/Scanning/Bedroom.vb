Imports System.ComponentModel

Public Class Bedroom
    Private Options(4) As SubOptions
    Private Windows(2) As SubOptions
    Private MyParent As UserApartment

    Public Sub New(parentForm As UserApartment)
        ' This call is required by the designer.
        InitializeComponent()

        Options(0) = MainTaskBar.MenuBarOption
        Options(1) = Bed
        Options(2) = BedroomWindow1
        Options(3) = bedroomEnvironmentMenu.envMenuBackground
        Options(4) = vaccuumOption

        For i = 0 To 4
            Options(i).Initialize()
        Next

        Windows(0) = BedroomWindow1
        Windows(1) = BedroomWindow2
        Windows(2) = exitWindowSelection

        For i = 0 To 2
            Windows(i).Initialize()
        Next

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
        Options(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        ScanningTimer.Stop()
        Options(focusIsOn).LoseFocus()
        Me.Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        scanninglevel = 0
        Options(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 5
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            Options(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            If bedroomEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then
                bedroomEnvironmentMenu.tempOption.InnerScanningNext()
            Else
                WindowMenu.MenuBarOption.InnerScanningNext()
            End If
        End If
    End Sub



#End Region

#Region "Key Press"

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 Then

            If focusIsOn = 0 Then

                scanninglevel = 1
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then

                If Bed.Tag = "up" Then
                    Bed.Image = My.Resources.bedDown
                    Bed.Tag = "down"
                ElseIf Bed.Tag = "down" Then
                    Bed.Image = My.Resources.bedUp
                    Bed.Tag = "up"
                End If

            ElseIf focusIsOn = 2 Then

                scanninglevel = 1
                exitWindowSelection.Show()
                BedroomWindow1.includeAllOptions = True
                BedroomWindow1.StartInnerScanning(Windows)

            ElseIf focusIsOn = 3 Then

                scanninglevel = 1
                bedroomEnvironmentMenu.exitEnvMenu.Show()
                bedroomEnvironmentMenu.envMenuBackground.LoseFocus()
                Options(focusIsOn).StartInnerScanning(bedroomEnvironmentMenu.GetTaskBarOptions)

            End If
        ElseIf scanninglevel = 1 Then
            If bedroomEnvironmentMenu.lights.BackColor = Color.LemonChiffon Then

                If bedroomEnvironmentMenu.lights.Tag = "on" Then
                    BedroomLightsDim()
                ElseIf bedroomEnvironmentMenu.lights.Tag = "dim" Then
                    BedroomLightsOff()
                ElseIf bedroomEnvironmentMenu.lights.Tag = "off" Then
                    BedroomLightsOn()
                End If

            ElseIf bedroomEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then

                scanninglevel = 2
                bedroomEnvironmentMenu.tempOption.StartInnerScanning(bedroomEnvironmentMenu.GetTempOptions)
                bedroomEnvironmentMenu.ToggleTempMenu(True)

            ElseIf bedroomEnvironmentMenu.fan.BackColor = Color.LemonChiffon Then

                If bedroomEnvironmentMenu.fan.Tag = "off" Then

                    BedroomFanLow()

                ElseIf bedroomEnvironmentMenu.fan.Tag = "low" Then

                    BedroomFanMedium()

                ElseIf bedroomEnvironmentMenu.fan.Tag = "medium" Then

                    BedroomFanHigh()

                ElseIf bedroomEnvironmentMenu.fan.Tag = "high" Then

                    BedroomFanOff()

                End If

            ElseIf bedroomEnvironmentMenu.exitEnvMenu.BackColor = Color.LemonChiffon Then

                bedroomEnvironmentMenu.exitEnvMenu.Hide()
                bedroomEnvironmentMenu.envMenuBackground.StopInnerScanning()
                scanninglevel = 0

            ElseIf focusIsOn = 2 Then

                If exitWindowSelection.BackColor = Color.LemonChiffon Then

                    exitWindowSelection.Hide()
                    BedroomWindow1.StopInnerScanning()
                    scanninglevel = 0

                Else

                    scanninglevel = 2
                    exitWindowSelection.Hide()
                    WindowMenu.Show()
                    WindowMenu.MenuBarOption.StartInnerScanning(WindowMenu.GetTaskBarOptions)

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

        ElseIf scanninglevel = 2 Then

            If bedroomEnvironmentMenu.upArrow.BackColor = Color.LemonChiffon Then

                bedroomEnvironmentMenu.tempLabel.Text = CInt(bedroomEnvironmentMenu.tempLabel.Text) + 1

            ElseIf bedroomEnvironmentMenu.downArrow.BackColor = Color.LemonChiffon Then

                bedroomEnvironmentMenu.tempLabel.Text = CInt(bedroomEnvironmentMenu.tempLabel.Text) - 1

            ElseIf bedroomEnvironmentMenu.exitTemp.BackColor = Color.LemonChiffon Then

                bedroomEnvironmentMenu.tempOption.StopInnerScanning()
                scanninglevel = 1
                bedroomEnvironmentMenu.ToggleTempMenu(False)

            ElseIf WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                Options(focusIsOn).StopInnerScanning()
                WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.windowControl.Tag = "open" Then

                    BedroomWindowsHalfOpen()

                ElseIf WindowMenu.windowControl.Tag = "half_open" Then

                    BedroomWindowsSlightlyOpen()

                ElseIf WindowMenu.windowControl.Tag = "slightly_open" Then

                    BedroomWindowsClose()

                ElseIf WindowMenu.windowControl.Tag = "closed" Then

                    BedroomWindowsOpen()

                End If

            ElseIf WindowMenu.blindControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.blindControl.Tag = "open" Then

                    BedroomBlindsHalfOpen()

                ElseIf WindowMenu.blindControl.Tag = "half_open" Then

                    BedroomBlindsSlightlyOpen()

                ElseIf WindowMenu.blindControl.Tag = "slightly_open" Then

                    BedroomBlindsClose()

                ElseIf WindowMenu.blindControl.Tag = "closed" Then

                    BedroomBlindsOpen()

                End If

            End If

        End If
    End Sub

#End Region

#Region "Environment"

    Public Sub BedroomWindowsOpen()
        WindowMenu.windowControl.Image = My.Resources.WindowOpen
        WindowMenu.windowControl.Tag = "open"

        If ScanningTimer.Enabled = False Then
            bedroomShutters1.Show()
            bedroomShutters2.Show()

            MyParent.BedroomWindow1Shutters.Show()
            MyParent.BedroomWindow2Shutters.Show()

        Else

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomShutters1.Show()
                MyParent.BedroomWindow1Shutters.Show()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomShutters2.Show()
                MyParent.BedroomWindow2Shutters.Show()
            End If

        End If

    End Sub

    Public Sub BedroomWindowsHalfOpen()

        WindowMenu.windowControl.Image = My.Resources.WindowHalfOpen
        WindowMenu.windowControl.Tag = "half_open"

        If ScanningTimer.Enabled = False Then
            bedroomShutters1.Hide()
            bedroomShutters2.Hide()

            MyParent.BedroomWindow1Shutters.Hide()
            MyParent.BedroomWindow2Shutters.Hide()

        Else

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomShutters1.Hide()
                MyParent.BedroomWindow1Shutters.Hide()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomShutters2.Hide()
                MyParent.BedroomWindow2Shutters.Hide()
            End If

        End If

    End Sub

    Public Sub BedroomWindowsSlightlyOpen()

        WindowMenu.windowControl.Image = My.Resources.WindowSlightlyOpen
        WindowMenu.windowControl.Tag = "slightly_open"

        If ScanningTimer.Enabled = False Then
            bedroomShutters1.Hide()
            bedroomShutters2.Hide()

            MyParent.BedroomWindow1Shutters.Hide()
            MyParent.BedroomWindow2Shutters.Hide()

        Else

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomShutters1.Hide()
                MyParent.BedroomWindow1Shutters.Hide()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomShutters2.Hide()
                MyParent.BedroomWindow2Shutters.Hide()
            End If

        End If

    End Sub

    Public Sub BedroomWindowsClose()
        WindowMenu.windowControl.Image = My.Resources.WindowClosed
        WindowMenu.windowControl.Tag = "closed"

        If ScanningTimer.Enabled = False Then
            bedroomShutters1.Hide()
            bedroomShutters2.Hide()

            MyParent.BedroomWindow1Shutters.Hide()
            MyParent.BedroomWindow2Shutters.Hide()

        Else

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomShutters1.Hide()
                MyParent.BedroomWindow1Shutters.Hide()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomShutters2.Hide()
                MyParent.BedroomWindow2Shutters.Hide()
            End If

        End If

    End Sub


    Public Sub BedroomBlindsOpen()
        WindowMenu.blindControl.Image = My.Resources.BlindsOpen
        WindowMenu.blindControl.Tag = "open"

        If ScanningTimer.Enabled Then

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomBlinds1.Hide()
                MyParent.bedroomWindow1Blinds.Hide()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomBlinds2.Hide()
                MyParent.bedroomWindow2Blinds.Hide()
            End If

        Else

            bedroomBlinds1.Hide()
            MyParent.bedroomWindow1Blinds.Hide()

            bedroomBlinds2.Hide()
            MyParent.bedroomWindow2Blinds.Hide()

        End If

    End Sub

    Public Sub BedroomBlindsHalfOpen()

        WindowMenu.blindControl.Image = My.Resources.BlindsHalfOpen
        WindowMenu.blindControl.Tag = "half_open"

        If ScanningTimer.Enabled Then

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomBlinds1.Show()
                MyParent.bedroomWindow1Blinds.Show()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomBlinds2.Show()
                MyParent.bedroomWindow2Blinds.Show()
            End If

        Else

            bedroomBlinds1.Show()
            MyParent.bedroomWindow1Blinds.Show()

            bedroomBlinds2.Show()
            MyParent.bedroomWindow2Blinds.Show()

        End If

    End Sub

    Public Sub BedroomBlindsSlightlyOpen()

        WindowMenu.blindControl.Image = My.Resources.BlindsSlightlyOpen
        WindowMenu.blindControl.Tag = "slightly_open"

        If ScanningTimer.Enabled Then

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomBlinds1.Show()
                MyParent.bedroomWindow1Blinds.Show()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomBlinds2.Show()
                MyParent.bedroomWindow2Blinds.Show()
            End If

        Else

            bedroomBlinds1.Show()
            MyParent.bedroomWindow1Blinds.Show()

            bedroomBlinds2.Show()
            MyParent.bedroomWindow2Blinds.Show()

        End If

    End Sub

    Public Sub BedroomBlindsClose()
        WindowMenu.blindControl.Image = My.Resources.BlindsClosed
        WindowMenu.blindControl.Tag = "closed"

        If ScanningTimer.Enabled Then

            If BedroomWindow1.BackColor = Color.LemonChiffon Then
                bedroomBlinds1.Show()
                MyParent.bedroomWindow1Blinds.Show()
            End If

            If BedroomWindow2.BackColor = Color.LemonChiffon Then
                bedroomBlinds2.Show()
                MyParent.bedroomWindow2Blinds.Show()
            End If

        Else

            bedroomBlinds1.Show()
            MyParent.bedroomWindow1Blinds.Show()

            bedroomBlinds2.Show()
            MyParent.bedroomWindow2Blinds.Show()

        End If

    End Sub


    Public Sub BedroomLightsOn()
        bedroomEnvironmentMenu.lights.Image = My.Resources.bulbLit
        bedroomEnvironmentMenu.lights.Tag = "on"
        MyParent.bedroomLight.Image = My.Resources.bulbLit
    End Sub

    Public Sub BedroomLightsDim()
        bedroomEnvironmentMenu.lights.Image = My.Resources.bulbDim
        bedroomEnvironmentMenu.lights.Tag = "dim"
        MyParent.bedroomLight.Image = My.Resources.bulbDim
    End Sub

    Public Sub BedroomLightsOff()
        bedroomEnvironmentMenu.lights.Image = My.Resources.bulbUnlit
        bedroomEnvironmentMenu.lights.Tag = "off"
        MyParent.bedroomLight.Image = My.Resources.bulbUnlit
    End Sub

    Public Sub BedroomFanHigh()
        bedroomEnvironmentMenu.fan.Image = My.Resources.fanHigh
        bedroomEnvironmentMenu.fan.Tag = "high"
        MyParent.bedroomFan.Image = My.Resources.fanHigh
    End Sub

    Public Sub BedroomFanMedium()
        bedroomEnvironmentMenu.fan.Image = My.Resources.fanMedium
        bedroomEnvironmentMenu.fan.Tag = "medium"
        MyParent.bedroomFan.Image = My.Resources.fanMedium
    End Sub

    Public Sub BedroomFanLow()
        bedroomEnvironmentMenu.fan.Image = My.Resources.fanLow
        bedroomEnvironmentMenu.fan.Tag = "low"
        MyParent.bedroomFan.Image = My.Resources.fanLow
    End Sub

    Public Sub BedroomFanOff()
        bedroomEnvironmentMenu.fan.Image = My.Resources.fanOff
        bedroomEnvironmentMenu.fan.Tag = "off"
        MyParent.bedroomFan.Image = My.Resources.fanOff
    End Sub



#End Region

    Private Sub Groups_ColorChanged(sender As Object, e As EventArgs) Handles BedroomWindow1.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then

            If BedroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
                BedroomWindow2.ReceiveFocus()
            Else
                BedroomWindow2.LoseFocus()
            End If

        End If
    End Sub

    Private Sub Bedroom_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub

End Class