Imports System.ComponentModel

Public Class UserApartment

    Private TopOptions(4) As SubOptions
    Private Rooms(4) As SubOptions
    Private Windows(3) As SubOptions

    Private livingroomForm As New Livingroom(Me)
    Private bedroomForm As New Bedroom(Me)
    Private kitchenForm As New Kitchen(Me)
    Private bathroomForm As New Bathroom(Me)


    Private shutters(3) As PictureBox
    Private MyParent As FloorHallways

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopOptions(0) = MainTaskBar.MenuBarOption
        TopOptions(1) = LivingRoom
        TopOptions(2) = LivingroomWindow1
        TopOptions(3) = EnvironmentMenu.envMenuBackground
        TopOptions(4) = vaccuumOption

        For i = 0 To 4
            TopOptions(i).Initialize()
        Next

        Rooms(0) = LivingRoom
        Rooms(1) = Bedroom
        Rooms(2) = Kitchen
        Rooms(3) = Bathroom
        Rooms(4) = exitRooms

        For i = 0 To 4
            Rooms(i).Initialize()
        Next

        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2
        Windows(2) = BedroomWindow1
        Windows(3) = BedroomWindow2

        For i = 0 To 3
            Windows(i).Initialize()
        Next

        shutters(0) = LivingroomWindow1Shutters
        shutters(1) = LivingroomWindow2Shutters
        shutters(2) = BedroomWindow1Shutters
        shutters(3) = BedroomWindow2Shutters

        MyParent = parentForm

        livingroomLight.Parent = LivingRoom
        bedroomLight.Parent = Bedroom
        kitchenLight.Parent = Kitchen
        bathroomLight.Parent = Bathroom

        livingroomFan.Parent = LivingRoom
        bedroomFan.Parent = Bedroom
        kitchenFan.Parent = Kitchen
        bathroomFan.Parent = Bathroom

        livingroomHumidity.Parent = LivingRoom
        bedroomHumidity.Parent = Bedroom
        kitchenHumidity.Parent = Kitchen
        bathroomHUmidity.Parent = Bathroom

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

    Public Sub ResumeScanning()
        scanninglevel = 0
        focusIsOn = 0
        TopOptions(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            TopOptions(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 5
            TopOptions(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            TopOptions(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            EnvironmentMenu.tempOption.InnerScanningNext()
        End If
    End Sub

#End Region

#Region "KeyPress"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then

            If focusIsOn = 0 Then

                scanninglevel = 1
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then

                scanninglevel = 1
                exitRooms.Show()
                TopOptions(focusIsOn).StartInnerScanning(Rooms)

            ElseIf focusIsOn = 2 Then

                scanninglevel = 1
                Me.WindowMenu.Visible = True
                TopOptions(focusIsOn).StartInnerScanning(WindowMenu.GetTaskBarOptions())

            ElseIf focusIsOn = 3 Then

                scanninglevel = 1
                EnvironmentMenu.exitEnvMenu.Show()
                EnvironmentMenu.envMenuBackground.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(EnvironmentMenu.GetTaskBarOptions)

            End If

        ElseIf scanninglevel = 1 Then

            If LivingRoom.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                livingroomForm.Show()
                livingroomForm.StartScanning()

            ElseIf Bedroom.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                bedroomForm.Show()
                bedroomForm.StartScanning()

            ElseIf Kitchen.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                kitchenForm.Show()
                kitchenForm.StartScanning()

            ElseIf Bathroom.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                bathroomForm.Show()
                bathroomForm.StartScanning()

            ElseIf exitRooms.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                scanninglevel = 0
                exitRooms.Hide()

            ElseIf Me.WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                WindowChange()

            ElseIf Me.WindowMenu.blindControl.BackColor = Color.LemonChiffon Then

                BlindsChange()

            ElseIf WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                Me.WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf EnvironmentMenu.lights.BackColor = Color.LemonChiffon Then

                LightsChange()

            ElseIf EnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then

                scanninglevel = 2
                EnvironmentMenu.tempOption.StartInnerScanning(EnvironmentMenu.GetTempOptions)
                EnvironmentMenu.ToggleTempMenu(True)

            ElseIf EnvironmentMenu.fan.BackColor = Color.LemonChiffon Then

                FanChange()

            ElseIf EnvironmentMenu.exitEnvMenu.BackColor = Color.LemonChiffon Then

                EnvironmentMenu.exitEnvMenu.Hide()
                EnvironmentMenu.envMenuBackground.StopInnerScanning()
                scanninglevel = 0

            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then

                StopScanning()
                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.PreviousScreen.LoseFocus()
                Hide()
                MyParent.ResumeScanning()

            ElseIf MainTaskBar.Assistance.BackColor = Color.LemonChiffon Then

                Dim Assistance As New Assistance(Me)
                StopScanning()
                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()

            ElseIf MainTaskBar.exitTaskBar.BackColor = Color.LemonChiffon Then

                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                scanninglevel = 0

            End If

        ElseIf scanninglevel = 2 Then

            If EnvironmentMenu.upArrow.BackColor = Color.LemonChiffon Then

                EnvironmentMenu.tempLabel.Text = CInt(EnvironmentMenu.tempLabel.Text) + 1

                livingroomForm.livingroomEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text
                bedroomForm.bedroomEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text
                kitchenForm.kitchenEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text
                bathroomForm.bathroomEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text

            ElseIf EnvironmentMenu.downArrow.BackColor = Color.LemonChiffon Then

                EnvironmentMenu.tempLabel.Text = CInt(EnvironmentMenu.tempLabel.Text) - 1

                livingroomForm.livingroomEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text
                bedroomForm.bedroomEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text
                kitchenForm.kitchenEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text
                bathroomForm.bathroomEnvironmentMenu.tempLabel.Text = EnvironmentMenu.tempLabel.Text

            ElseIf EnvironmentMenu.exitTemp.BackColor = Color.LemonChiffon Then

                EnvironmentMenu.tempOption.StopInnerScanning()
                scanninglevel = 1
                EnvironmentMenu.ToggleTempMenu(False)

            End If
        End If
    End Sub




#End Region

#Region "Environment"

    Private Sub WindowChange()
        If WindowMenu.windowControl.Tag = "open" Then

            WindowMenu.windowControl.Image = My.Resources.WindowHalfOpen
            WindowMenu.windowControl.Tag = "half_open"
            bedroomForm.BedroomWindowsHalfOpen()
            livingroomForm.LivingroomWindowsHalfOpen()

        ElseIf WindowMenu.windowControl.Tag = "half_open" Then

            WindowMenu.windowControl.Image = My.Resources.WindowSlightlyOpen
            WindowMenu.windowControl.Tag = "slightly_open"
            bedroomForm.BedroomWindowsSlightlyOpen()
            livingroomForm.LivingroomWindowsSlightlyOpen()

        ElseIf WindowMenu.windowControl.Tag = "slightly_open" Then

            WindowMenu.windowControl.Image = My.Resources.WindowClosed
            WindowMenu.windowControl.Tag = "closed"
            bedroomForm.BedroomWindowsClose()
            livingroomForm.LivingroomWindowsClose()

        ElseIf WindowMenu.windowControl.Tag = "closed" Then

            WindowMenu.windowControl.Image = My.Resources.WindowOpen
            WindowMenu.windowControl.Tag = "open"
            bedroomForm.BedroomWindowsOpen()
            livingroomForm.LivingroomWindowsOpen()

        End If
    End Sub

    Private Sub BlindsChange()
        If WindowMenu.blindControl.Tag = "open" Then

            WindowMenu.blindControl.Image = My.Resources.BlindsHalfOpen
            WindowMenu.blindControl.Tag = "half_open"
            bedroomForm.BedroomBlindsHalfOpen()
            livingroomForm.LivingroomBlindsHalfOpen()

        ElseIf WindowMenu.blindControl.Tag = "half_open" Then

            WindowMenu.blindControl.Image = My.Resources.BlindsSlightlyOpen
            WindowMenu.blindControl.Tag = "slightly_open"
            bedroomForm.BedroomBlindsSlightlyOpen()
            livingroomForm.LivingroomBlindsSlightlyOpen()

        ElseIf WindowMenu.blindControl.Tag = "slightly_open" Then

            WindowMenu.blindControl.Image = My.Resources.BlindsClosed
            WindowMenu.blindControl.Tag = "closed"
            bedroomForm.BedroomBlindsClose()
            livingroomForm.LivingroomBlindsClose()

        ElseIf WindowMenu.blindControl.Tag = "closed" Then

            WindowMenu.blindControl.Image = My.Resources.BlindsOpen
            WindowMenu.blindControl.Tag = "open"
            bedroomForm.BedroomBlindsOpen()
            livingroomForm.LivingroomBlindsOpen()

        End If
    End Sub

    Private Sub LightsChange()
        If EnvironmentMenu.lights.Tag = "on" Then

            EnvironmentMenu.lights.Tag = "dim"
            EnvironmentMenu.lights.Image = My.Resources.bulbDim

            livingroomForm.LivingroomLightsDim()
            bedroomForm.BedroomLightsDim()
            kitchenForm.KitchenLightsDim()
            bathroomForm.BathroomLightsDim()

        ElseIf EnvironmentMenu.lights.Tag = "dim" Then

            EnvironmentMenu.lights.Tag = "off"
            EnvironmentMenu.lights.Image = My.Resources.bulbUnlit

            livingroomForm.LivingroomLightsOff()
            bedroomForm.BedroomLightsOff()
            kitchenForm.KitchenLightsOff()
            bathroomForm.BathroomLightsOff()

        ElseIf EnvironmentMenu.lights.Tag = "off" Then

            EnvironmentMenu.lights.Tag = "on"
            EnvironmentMenu.lights.Image = My.Resources.bulbLit

            livingroomForm.LivingroomLightsOn()
            bedroomForm.BedroomLightsOn()
            kitchenForm.KitchenLightsOn()
            bathroomForm.BathroomLightsOn()

        End If
    End Sub

    Private Sub FanChange()
        If EnvironmentMenu.fan.Tag = "off" Then

            EnvironmentMenu.fan.Tag = "low"
            EnvironmentMenu.fan.Image = My.Resources.fanLow

            livingroomForm.LivingroomFanLow()
            bedroomForm.BedroomFanLow()
            kitchenForm.KitchenFanLow()
            bathroomForm.BathroomFanLow()

        ElseIf EnvironmentMenu.fan.Tag = "low" Then

            EnvironmentMenu.fan.Tag = "medium"
            EnvironmentMenu.fan.Image = My.Resources.fanMedium

            livingroomForm.LivingroomFanMedium()
            bedroomForm.BedroomFanMedium()
            kitchenForm.KitchenFanMedium()
            bathroomForm.BathroomFanMedium()

        ElseIf EnvironmentMenu.fan.Tag = "medium" Then

            EnvironmentMenu.fan.Tag = "high"
            EnvironmentMenu.fan.Image = My.Resources.fanHigh

            livingroomForm.LivingroomFanHigh()
            bedroomForm.BedroomFanHigh()
            kitchenForm.KitchenFanHigh()
            bathroomForm.BathroomFanHigh()

        ElseIf EnvironmentMenu.fan.Tag = "high" Then

            EnvironmentMenu.fan.Tag = "off"
            EnvironmentMenu.fan.Image = My.Resources.fanOff

            livingroomForm.LivingroomFanOff()
            bedroomForm.BedroomFanOff()
            kitchenForm.KitchenFanOff()
            bathroomForm.BathroomFanOff()

        End If
    End Sub

#End Region

#Region "Other methods"

    Private Sub LivingroomWindow1_ColorChanged(sender As Object, e As EventArgs) Handles LivingRoom.BackColorChanged, LivingroomWindow1.BackColorChanged

        If scanninglevel = 0 And ScanningTimer.Enabled Then

            If LivingRoom.BackColor.Equals(Color.LemonChiffon) Then

                For i = 1 To Rooms.Length - 2
                    Rooms(i).ReceiveFocus()
                Next

            Else

                For i = 1 To Rooms.Length - 2
                    Rooms(i).LoseFocus()
                Next

            End If

            If LivingroomWindow1.BackColor.Equals(Color.LemonChiffon) Then

                For i = 1 To Windows.Length - 1
                    Windows(i).ReceiveFocus()
                Next

            Else

                For i = 1 To Windows.Length - 1
                    Windows(i).LoseFocus()
                Next

            End If

        End If
    End Sub


    Private Sub UserApartment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub
#End Region

End Class