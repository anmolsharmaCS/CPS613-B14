Imports System.ComponentModel

Public Class Kitchen

    Private Options(2) As SubOptions

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = cooking
        Options(1) = kitchenEnvironmentMenu.envMenuBackground
        Options(2) = MainTaskBar.MenuBarOption

        For i = 0 To 2
            Options(i).Initialize()
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
            focusIsOn = (focusIsOn + 1) Mod 3
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            Options(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            kitchenEnvironmentMenu.tempOption.InnerScanningNext()
        End If
    End Sub

#End Region

#Region "Key Press"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If scanninglevel = 0 Then

            If focusIsOn = 1 Then

                scanninglevel = 1
                kitchenEnvironmentMenu.exitEnvMenu.Show()
                kitchenEnvironmentMenu.envMenuBackground.LoseFocus()
                Options(focusIsOn).StartInnerScanning(kitchenEnvironmentMenu.GetTaskBarOptions)

            ElseIf focusIsOn = 2 Then

                scanninglevel = 1
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            End If

        ElseIf scanninglevel = 1 Then

            If kitchenEnvironmentMenu.lights.BackColor = Color.LemonChiffon Then

                If kitchenEnvironmentMenu.lights.Tag = "on" Then
                    KitchenLightsDim()
                ElseIf kitchenEnvironmentMenu.lights.Tag = "dim" Then
                    KitchenLightsOff()
                ElseIf kitchenEnvironmentMenu.lights.Tag = "off" Then
                    KitchenLightsOn()
                End If

            ElseIf kitchenEnvironmentMenu.fan.BackColor = Color.LemonChiffon Then

                If kitchenEnvironmentMenu.fan.Tag = "off" Then
                    KitchenFanLow()
                ElseIf kitchenEnvironmentMenu.fan.Tag = "low" Then
                    KitchenFanMedium()
                ElseIf kitchenEnvironmentMenu.fan.Tag = "medium" Then
                    KitchenFanHigh()
                ElseIf kitchenEnvironmentMenu.fan.Tag = "high" Then
                    KitchenFanOff()
                End If

            ElseIf kitchenEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then

                scanninglevel = 2
                kitchenEnvironmentMenu.tempOption.StartInnerScanning(kitchenEnvironmentMenu.GetTempOptions)
                kitchenEnvironmentMenu.ToggleTempMenu(True)

            ElseIf kitchenEnvironmentMenu.exitEnvMenu.BackColor = Color.LemonChiffon Then

                kitchenEnvironmentMenu.exitEnvMenu.Hide()
                kitchenEnvironmentMenu.envMenuBackground.StopInnerScanning()
                scanninglevel = 0

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
                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.PreviousScreen.LoseFocus()
                Hide()
                MyParent.ResumeScanning()

            End If

        ElseIf scanninglevel = 2 Then

            If kitchenEnvironmentMenu.upArrow.BackColor = Color.LemonChiffon Then

                kitchenEnvironmentMenu.tempLabel.Text = CInt(kitchenEnvironmentMenu.tempLabel.Text) + 1

            ElseIf kitchenEnvironmentMenu.downArrow.BackColor = Color.LemonChiffon Then

                kitchenEnvironmentMenu.tempLabel.Text = CInt(kitchenEnvironmentMenu.tempLabel.Text) - 1

            ElseIf kitchenEnvironmentMenu.exitTemp.BackColor = Color.LemonChiffon Then

                kitchenEnvironmentMenu.tempOption.StopInnerScanning()
                scanninglevel = 1
                kitchenEnvironmentMenu.ToggleTempMenu(False)

            End If
        End If
    End Sub

#End Region

#Region "Environment"

    Public Sub KitchenLightsOn()
        kitchenEnvironmentMenu.lights.Image = My.Resources.bulbLit
        kitchenEnvironmentMenu.lights.Tag = "on"
        MyParent.kitchenLight.Image = My.Resources.bulbLit
    End Sub

    Public Sub KitchenLightsDim()
        kitchenEnvironmentMenu.lights.Image = My.Resources.bulbDim
        kitchenEnvironmentMenu.lights.Tag = "dim"
        MyParent.kitchenLight.Image = My.Resources.bulbDim
    End Sub

    Public Sub KitchenLightsOff()
        kitchenEnvironmentMenu.lights.Image = My.Resources.bulbUnlit
        kitchenEnvironmentMenu.lights.Tag = "off"
        MyParent.kitchenLight.Image = My.Resources.bulbUnlit
    End Sub

    Public Sub KitchenFanHigh()
        kitchenEnvironmentMenu.fan.Image = My.Resources.fanHigh
        kitchenEnvironmentMenu.fan.Tag = "high"
        MyParent.kitchenFan.Image = My.Resources.fanHigh
    End Sub

    Public Sub KitchenFanMedium()
        kitchenEnvironmentMenu.fan.Image = My.Resources.fanMedium
        kitchenEnvironmentMenu.fan.Tag = "medium"
        MyParent.kitchenFan.Image = My.Resources.fanMedium
    End Sub

    Public Sub KitchenFanLow()
        kitchenEnvironmentMenu.fan.Image = My.Resources.fanLow
        kitchenEnvironmentMenu.fan.Tag = "low"
        MyParent.kitchenFan.Image = My.Resources.fanLow
    End Sub

    Public Sub KitchenFanOff()
        kitchenEnvironmentMenu.fan.Image = My.Resources.fanOff
        kitchenEnvironmentMenu.fan.Tag = "off"
        MyParent.kitchenFan.Image = My.Resources.fanOff
    End Sub

#End Region

    Private Sub Kitchen_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MyParent.ResumeScanning()
    End Sub

End Class