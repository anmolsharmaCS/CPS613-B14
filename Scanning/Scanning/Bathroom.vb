Imports System.ComponentModel

Public Class Bathroom

    Private Options(2) As SubOptions

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = flushToilet
        Options(1) = bathroomEnvironmentMenu.envMenuBackground
        Options(2) = bathroomMainTaskBar.MenuBarOption

        For i = 0 To 2
            Options(i).Initialize()
        Next

        MyParent = parentForm

    End Sub

#Region "Timer Properties and methods"

    ' Make the Scanningtimer interval accessible 
    Public Property ScanningInterval As Integer
        Get
            Return ScanningTImer.Interval
        End Get
        Set(value As Integer)
            ScanningTImer.Interval = value
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
        ScanningTImer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        ScanningTImer.Stop()
        Options(focusIsOn).LoseFocus()
        Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        scanninglevel = 0
        Options(focusIsOn).ReceiveFocus()
        ScanningTImer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTImer.Tick
        If scanninglevel = 0 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 3
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            Options(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            bathroomEnvironmentMenu.tempOption.InnerScanningNext()
        End If
    End Sub

#End Region

#Region "Keypress"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If scanninglevel = 0 Then

            If focusIsOn = 1 Then

                scanninglevel = 1
                bathroomEnvironmentMenu.exitEnvMenu.Show()
                bathroomEnvironmentMenu.envMenuBackground.LoseFocus()
                Options(focusIsOn).StartInnerScanning(bathroomEnvironmentMenu.GetTaskBarOptions)

            ElseIf focusIsOn = 2 Then

                scanninglevel = 1
                bathroomMainTaskBar.exitTaskBar.Show()
                bathroomMainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(bathroomMainTaskBar.GetTaskBarOptions())

            End If

        ElseIf scanninglevel = 1 Then

            If bathroomEnvironmentMenu.lights.BackColor = Color.LemonChiffon Then

                If bathroomEnvironmentMenu.lights.Tag = "on" Then
                    BathroomLightsDim()
                ElseIf bathroomEnvironmentMenu.lights.Tag = "dim" Then
                    BathroomLightsOff()
                ElseIf bathroomEnvironmentMenu.lights.Tag = "off" Then
                    BathroomLightsOn()
                End If

            ElseIf bathroomEnvironmentMenu.temperature.BackColor = Color.LemonChiffon Then

                scanninglevel = 2
                bathroomEnvironmentMenu.tempOption.StartInnerScanning(bathroomEnvironmentMenu.GetTempOptions)
                bathroomEnvironmentMenu.ToggleTempMenu(True)

            ElseIf bathroomEnvironmentMenu.fan.BackColor = Color.LemonChiffon Then

                If bathroomEnvironmentMenu.fan.Tag = "off" Then
                    BathroomFanLow()
                ElseIf bathroomEnvironmentMenu.fan.Tag = "low" Then
                    BathroomFanMedium()
                ElseIf bathroomEnvironmentMenu.fan.Tag = "medium" Then
                    BathroomFanHigh()
                ElseIf bathroomEnvironmentMenu.fan.Tag = "high" Then
                    BathroomFanOff()
                End If

            ElseIf bathroomEnvironmentMenu.exitEnvMenu.BackColor = Color.LemonChiffon Then

                bathroomEnvironmentMenu.exitEnvMenu.Hide()
                bathroomEnvironmentMenu.envMenuBackground.StopInnerScanning()
                scanninglevel = 0

            ElseIf bathroomMainTaskBar.exitTaskBar.BackColor = Color.LemonChiffon Then

                bathroomMainTaskBar.exitTaskBar.Hide()
                bathroomMainTaskBar.MenuBarOption.StopInnerScanning()
                scanninglevel = 0

            ElseIf bathroomMainTaskBar.Assistance.BackColor = Color.LemonChiffon Then

                Dim Assistance As New Assistance(Me)
                StopScanning()
                bathroomMainTaskBar.exitTaskBar.Hide()
                bathroomMainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()

            ElseIf bathroomMainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then

                StopScanning()
                bathroomMainTaskBar.exitTaskBar.Hide()
                bathroomMainTaskBar.PreviousScreen.LoseFocus()
                Hide()
                MyParent.ResumeScanning()

            End If

        ElseIf scanninglevel = 2 Then

            If bathroomEnvironmentMenu.upArrow.BackColor = Color.LemonChiffon Then

                bathroomEnvironmentMenu.tempLabel.Text = CInt(bathroomEnvironmentMenu.tempLabel.Text) + 1

            ElseIf bathroomEnvironmentMenu.downArrow.BackColor = Color.LemonChiffon Then

                bathroomEnvironmentMenu.tempLabel.Text = CInt(bathroomEnvironmentMenu.tempLabel.Text) - 1

            ElseIf bathroomEnvironmentMenu.exitTemp.BackColor = Color.LemonChiffon Then

                bathroomEnvironmentMenu.tempOption.StopInnerScanning()
                scanninglevel = 1
                bathroomEnvironmentMenu.ToggleTempMenu(False)

            End If

        End If

    End Sub

#End Region

#Region "Environment"

    Public Sub BathroomLightsOn()
        bathroomEnvironmentMenu.lights.Image = My.Resources.bulbLit
        bathroomEnvironmentMenu.lights.Tag = "on"
        MyParent.bathroomLight.Image = My.Resources.bulbLit
    End Sub

    Public Sub BathroomLightsOff()
        bathroomEnvironmentMenu.lights.Image = My.Resources.bulbUnlit
        bathroomEnvironmentMenu.lights.Tag = "off"
        MyParent.bathroomLight.Image = My.Resources.bulbUnlit
    End Sub

    Public Sub BathroomLightsDim()
        bathroomEnvironmentMenu.lights.Image = My.Resources.bulbDim
        bathroomEnvironmentMenu.lights.Tag = "dim"
        MyParent.bathroomLight.Image = My.Resources.bulbDim
    End Sub

    Public Sub BathroomFanHigh()
        bathroomEnvironmentMenu.fan.Image = My.Resources.fanHigh
        bathroomEnvironmentMenu.fan.Tag = "high"
        MyParent.bathroomFan.Image = My.Resources.fanHigh
    End Sub

    Public Sub BathroomFanMedium()
        bathroomEnvironmentMenu.fan.Image = My.Resources.fanMedium
        bathroomEnvironmentMenu.fan.Tag = "medium"
        MyParent.bathroomFan.Image = My.Resources.fanMedium
    End Sub

    Public Sub BathroomFanLow()
        bathroomEnvironmentMenu.fan.Image = My.Resources.fanLow
        bathroomEnvironmentMenu.fan.Tag = "low"
        MyParent.bathroomFan.Image = My.Resources.fanLow
    End Sub

    Public Sub BathroomFanOff()
        bathroomEnvironmentMenu.fan.Image = My.Resources.fanOff
        bathroomEnvironmentMenu.fan.Tag = "off"
        MyParent.bathroomFan.Image = My.Resources.fanOff
    End Sub

#End Region

    Private Sub Bathroom_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MyParent.ResumeScanning()
    End Sub

End Class