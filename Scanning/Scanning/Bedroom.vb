Imports System.ComponentModel

Public Class Bedroom
    Private Options(3) As SubOptions
    Private Windows(1) As SubOptions
    Private MyParent As UserApartment

    Public Sub New(parentForm As UserApartment)
        ' This call is required by the designer.
        InitializeComponent()

        Options(0) = MainTaskBar.MenuBarOption
        Options(1) = Bed
        Options(2) = BedroomWindow1
        Options(3) = bedroomEnvironmentMenu.envMenuBackground

        For i = 0 To 3
            Options(i).Initialize()
        Next

        Windows(0) = BedroomWindow1
        Windows(1) = BedroomWindow2

        For i = 0 To 1
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
            focusIsOn = (focusIsOn + 1) Mod 4
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            Options(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            bedroomEnvironmentMenu.tempOption.InnerScanningNext()
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
                WindowMenu.Show()
                Options(focusIsOn).StartInnerScanning(WindowMenu.GetTaskBarOptions)

            ElseIf focusIsOn = 3 Then

                scanninglevel = 1
                bedroomEnvironmentMenu.exitEnvMenu.Show()
                bedroomEnvironmentMenu.envMenuBackground.LoseFocus()
                Options(focusIsOn).StartInnerScanning(bedroomEnvironmentMenu.GetTaskBarOptions)

            End If
        ElseIf scanninglevel = 1 Then
            If bedroomEnvironmentMenu.lights.BackColor = Color.LemonChiffon Then

                If bedroomEnvironmentMenu.lights.Tag = "on" Then

                    BedroomLightsOff()

                ElseIf bedroomEnvironmentMenu.lights.Tag = "off" Then

                    BedroomLightsOn()

                End If

            ElseIf bedroomEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then

                scanninglevel = 2
                bedroomEnvironmentMenu.tempOption.StartInnerScanning(bedroomEnvironmentMenu.GetTempOptions)
                bedroomEnvironmentMenu.ToggleTempMenu(True)

            ElseIf bedroomEnvironmentMenu.fan.BackColor = Color.LemonChiffon Then

                If bedroomEnvironmentMenu.fan.Tag = "on" Then

                    BedroomFanOff()

                ElseIf bedroomEnvironmentMenu.fan.Tag = "off" Then

                    BedroomFanOn()

                End If

            ElseIf bedroomEnvironmentMenu.exitEnvMenu.BackColor = Color.LemonChiffon Then

                bedroomEnvironmentMenu.exitEnvMenu.Hide()
                bedroomEnvironmentMenu.envMenuBackground.StopInnerScanning()
                scanninglevel = 0

            ElseIf WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                Options(focusIsOn).StopInnerScanning()
                Me.WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf Me.WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.windowControl.Tag = "open" Then

                    BedroomWindowsClose()

                ElseIf WindowMenu.windowControl.Tag = "closed" Then

                    BedroomWindowsOpen()

                End If

            ElseIf Me.WindowMenu.blindControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.blindControl.Tag = "open" Then

                    BedroomBlindsClose()

                ElseIf WindowMenu.blindControl.Tag = "closed" Then

                    BedroomBlindsOpen()

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

            End If

        End If
    End Sub

#End Region

#Region "Environment"

    Public Sub BedroomWindowsOpen()

        WindowMenu.windowControl.Image = My.Resources.WindowOpen
        WindowMenu.windowControl.Tag = "open"

        bedroomShutters1.Show()
        bedroomShutters2.Show()

        MyParent.BedroomWindow1Shutters.Show()
        MyParent.BedroomWindow2Shutters.Show()

    End Sub


    Public Sub BedroomWindowsClose()

        WindowMenu.windowControl.Image = My.Resources.WindowClosed
        WindowMenu.windowControl.Tag = "closed"

        bedroomShutters1.Hide()
        bedroomShutters2.Hide()

        MyParent.BedroomWindow1Shutters.Hide()
        MyParent.BedroomWindow2Shutters.Hide()
    End Sub

    Public Sub BedroomBlindsOpen()

        WindowMenu.blindControl.Image = My.Resources.BlindsOpen
        WindowMenu.blindControl.Tag = "open"

        bedroomBlinds1.Hide()
        bedroomBlinds2.Hide()

        MyParent.bedroomWindow1Blinds.Hide()
        MyParent.bedroomWindow2Blinds.Hide()

    End Sub


    Public Sub BedroomBlindsClose()

        WindowMenu.blindControl.Image = My.Resources.BlindsClosed
        WindowMenu.blindControl.Tag = "closed"

        bedroomBlinds1.Show()
        bedroomBlinds2.Show()

        MyParent.bedroomWindow1Blinds.Show()
        MyParent.bedroomWindow2Blinds.Show()

    End Sub


    Public Sub BedroomLightsOn()
        bedroomEnvironmentMenu.lights.Image = My.Resources.bulbLit
        bedroomEnvironmentMenu.lights.Tag = "on"
        MyParent.bedroomLight.Image = My.Resources.bulbLit
    End Sub

    Public Sub BedroomLightsOff()
        bedroomEnvironmentMenu.lights.Image = My.Resources.bulbUnlit
        bedroomEnvironmentMenu.lights.Tag = "off"
        MyParent.bedroomLight.Image = My.Resources.bulbUnlit
    End Sub

    Public Sub BedroomFanOn()
        bedroomEnvironmentMenu.fan.Image = My.Resources.fanOn
        bedroomEnvironmentMenu.fan.Tag = "on"
        MyParent.bedroomFan.Image = My.Resources.fanOn
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

End Class