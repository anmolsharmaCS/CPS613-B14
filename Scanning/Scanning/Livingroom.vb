Imports System.ComponentModel

Public Class Livingroom

    Private Options(3) As SubOptions
    Private Windows(2) As SubOptions

    Private ent As New Entertainment(Me)

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = MainTaskBar.MenuBarOption
        Options(1) = entSystem
        Options(2) = LivingroomWindow1
        Options(3) = livingroomEnvironmentMenu.envMenuBackground

        For i = 0 To 3
            Options(i).Initialize()
        Next


        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2
        Windows(2) = exitWindowSelection

        For i = 0 To 2
            Windows(i).Initialize()
        Next

        WindowMenu.windowControl.Image = My.Resources.WindowClosed
        WindowMenu.windowControl.Tag = "closed"

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
        Focus()
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
            If livingroomEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then
                livingroomEnvironmentMenu.tempOption.InnerScanningNext()
            Else
                WindowMenu.MenuBarOption.InnerScanningNext()
            End If
        End If
    End Sub


#End Region

#Region "Key Press"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then

            If focusIsOn = 0 Then

                scanninglevel = 1
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then

                StopScanning()
                ent.Show()
                ent.StartScanning()

            ElseIf focusIsOn = 2 Then

                scanninglevel = 1
                exitWindowSelection.Show()
                LivingroomWindow1.includeAllOptions = True
                LivingroomWindow1.StartInnerScanning(Windows)

            ElseIf focusIsOn = 3 Then

                scanninglevel = 1
                livingroomEnvironmentMenu.exitEnvMenu.Show()
                livingroomEnvironmentMenu.envMenuBackground.LoseFocus()
                Options(focusIsOn).StartInnerScanning(livingroomEnvironmentMenu.GetTaskBarOptions)

            End If

        ElseIf scanninglevel = 1 Then

            If livingroomEnvironmentMenu.lights.BackColor = Color.LemonChiffon Then

                If livingroomEnvironmentMenu.lights.Tag = "on" Then
                    LivingroomLightsDim()
                ElseIf livingroomEnvironmentMenu.lights.Tag = "dim" Then
                    LivingroomLightsOff()
                ElseIf livingroomEnvironmentMenu.lights.Tag = "off" Then
                    LivingroomLightsOn()
                End If

            ElseIf livingroomEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then

                scanninglevel = 2
                livingroomEnvironmentMenu.tempOption.StartInnerScanning(livingroomEnvironmentMenu.GetTempOptions)
                livingroomEnvironmentMenu.ToggleTempMenu(True)

            ElseIf livingroomEnvironmentMenu.fan.BackColor = Color.LemonChiffon Then

                If livingroomEnvironmentMenu.fan.Tag = "off" Then

                    LivingroomFanLow()

                ElseIf livingroomEnvironmentMenu.fan.Tag = "low" Then

                    LivingroomFanMedium()

                ElseIf livingroomEnvironmentMenu.fan.Tag = "medium" Then

                    LivingroomFanHigh()

                ElseIf livingroomEnvironmentMenu.fan.Tag = "high" Then

                    LivingroomFanOff()

                End If

            ElseIf livingroomEnvironmentMenu.exitEnvMenu.BackColor = Color.LemonChiffon Then

                livingroomEnvironmentMenu.exitEnvMenu.Hide()
                livingroomEnvironmentMenu.envMenuBackground.StopInnerScanning()
                scanninglevel = 0

            ElseIf focusIsOn = 2 Then

                If exitWindowSelection.BackColor = Color.LemonChiffon Then

                    exitWindowSelection.Hide()
                    LivingroomWindow1.StopInnerScanning()
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
                Hide()
                MyParent.ResumeScanning()

            End If

        ElseIf scanninglevel = 2 Then

            If livingroomEnvironmentMenu.upArrow.BackColor = Color.LemonChiffon Then

                livingroomEnvironmentMenu.tempLabel.Text = CInt(livingroomEnvironmentMenu.tempLabel.Text) + 1

            ElseIf livingroomEnvironmentMenu.downArrow.BackColor = Color.LemonChiffon Then

                livingroomEnvironmentMenu.tempLabel.Text = CInt(livingroomEnvironmentMenu.tempLabel.Text) - 1

            ElseIf livingroomEnvironmentMenu.exitTemp.BackColor = Color.LemonChiffon Then

                livingroomEnvironmentMenu.tempOption.StopInnerScanning()
                scanninglevel = 1
                livingroomEnvironmentMenu.ToggleTempMenu(False)

            ElseIf WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                Options(focusIsOn).StopInnerScanning()
                WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.windowControl.Tag = "open" Then

                    LivingroomWindowsClose()

                ElseIf WindowMenu.windowControl.Tag = "closed" Then

                    LivingroomWindowsOpen()

                End If

            ElseIf Me.WindowMenu.blindControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.blindControl.Tag = "open" Then

                    LivingroomBlindsClose()

                ElseIf WindowMenu.blindControl.Tag = "closed" Then

                    LivingroomBlindsOpen()

                End If

            End If

        End If

    End Sub

#End Region

#Region "Environment"

    Public Sub LivingroomWindowsOpen()
        WindowMenu.windowControl.Image = My.Resources.WindowOpen
        WindowMenu.windowControl.Tag = "open"

        If ScanningTimer.Enabled = False Then
            livingroomShutters1.Show()
            livingroomShutters2.Show()

            MyParent.LivingroomWindow1Shutters.Show()
            MyParent.LivingroomWindow2Shutters.Show()

        Else

            If LivingroomWindow1.BackColor = Color.LemonChiffon Then
                livingroomShutters1.Show()
                MyParent.LivingroomWindow1Shutters.Show()
            End If

            If LivingroomWindow2.BackColor = Color.LemonChiffon Then
                livingroomShutters2.Show()
                MyParent.LivingroomWindow2Shutters.Show()
            End If

        End If

    End Sub


    Public Sub LivingroomWindowsClose()
        WindowMenu.windowControl.Image = My.Resources.WindowClosed
        WindowMenu.windowControl.Tag = "closed"

        If ScanningTimer.Enabled = False Then
            livingroomShutters1.Hide()
            livingroomShutters2.Hide()

            MyParent.LivingroomWindow2Shutters.Hide()
            MyParent.LivingroomWindow1Shutters.Hide()

        Else

            If LivingroomWindow1.BackColor = Color.LemonChiffon Then
                livingroomShutters1.Hide()
                MyParent.LivingroomWindow1Shutters.Hide()
            End If

            If LivingroomWindow2.BackColor = Color.LemonChiffon Then
                livingroomShutters2.Hide()
                MyParent.LivingroomWindow2Shutters.Hide()
            End If

        End If

    End Sub


    Public Sub LivingroomBlindsOpen()
        WindowMenu.blindControl.Image = My.Resources.BlindsOpen
        WindowMenu.blindControl.Tag = "open"

        If ScanningTimer.Enabled Then

            If LivingroomWindow1.BackColor = Color.LemonChiffon Then
                livingroomBlinds1.Hide()
                MyParent.livingroomWindow1Blinds.Hide()
            End If

            If LivingroomWindow2.BackColor = Color.LemonChiffon Then
                livingroomBlinds2.Hide()
                MyParent.livingroomWindow2Blinds.Hide()
            End If

        Else

            livingroomBlinds1.Hide()
            MyParent.livingroomWindow1Blinds.Hide()

            livingroomBlinds2.Hide()
            MyParent.livingroomWindow2Blinds.Hide()

        End If

    End Sub


    Public Sub LivingroomBlindsClose()
        WindowMenu.blindControl.Image = My.Resources.BlindsClosed
        WindowMenu.blindControl.Tag = "closed"

        If ScanningTimer.Enabled Then

            If LivingroomWindow1.BackColor = Color.LemonChiffon Then
                livingroomBlinds1.Show()
                MyParent.livingroomWindow1Blinds.Show()
            End If

            If LivingroomWindow2.BackColor = Color.LemonChiffon Then
                livingroomBlinds2.Show()
                MyParent.livingroomWindow2Blinds.Show()
            End If

        Else

            livingroomBlinds1.Show()
            MyParent.livingroomWindow1Blinds.Show()

            livingroomBlinds2.Show()
            MyParent.livingroomWindow2Blinds.Show()

        End If

    End Sub

    Public Sub LivingroomLightsOn()
        livingroomEnvironmentMenu.lights.Image = My.Resources.bulbLit
        livingroomEnvironmentMenu.lights.Tag = "on"
        MyParent.livingroomLight.Image = My.Resources.bulbLit
    End Sub

    Public Sub LivingroomLightsDim()
        livingroomEnvironmentMenu.lights.Image = My.Resources.bulbDim
        livingroomEnvironmentMenu.lights.Tag = "dim"
        MyParent.livingroomLight.Image = My.Resources.bulbDim
    End Sub

    Public Sub LivingroomLightsOff()
        livingroomEnvironmentMenu.lights.Image = My.Resources.bulbUnlit
        livingroomEnvironmentMenu.lights.Tag = "off"
        MyParent.livingroomLight.Image = My.Resources.bulbUnlit
    End Sub

    Public Sub LivingroomFanHigh()
        livingroomEnvironmentMenu.fan.Image = My.Resources.fanHigh
        livingroomEnvironmentMenu.fan.Tag = "high"
        MyParent.livingroomFan.Image = My.Resources.fanHigh
    End Sub

    Public Sub LivingroomFanMedium()
        livingroomEnvironmentMenu.fan.Image = My.Resources.fanMedium
        livingroomEnvironmentMenu.fan.Tag = "medium"
        MyParent.livingroomFan.Image = My.Resources.fanMedium
    End Sub

    Public Sub LivingroomFanLow()
        livingroomEnvironmentMenu.fan.Image = My.Resources.fanLow
        livingroomEnvironmentMenu.fan.Tag = "low"
        MyParent.livingroomFan.Image = My.Resources.fanLow
    End Sub

    Public Sub LivingroomFanOff()
        livingroomEnvironmentMenu.fan.Image = My.Resources.fanOff
        livingroomEnvironmentMenu.fan.Tag = "off"
        MyParent.livingroomFan.Image = My.Resources.fanOff
    End Sub

#End Region

    Private Sub Groups_ColorChanged(sender As Object, e As EventArgs) Handles LivingroomWindow1.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If LivingroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
                LivingroomWindow2.ReceiveFocus()
            Else
                LivingroomWindow2.LoseFocus()
            End If
        End If
    End Sub


    Private Sub Livingroom_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        MyParent.ResumeScanning()
    End Sub

End Class