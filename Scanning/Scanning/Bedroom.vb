Imports System.ComponentModel

Public Class Bedroom
    Private TopOptions(4) As SubOptions
    Private environment(2) As SubOptions
    Private Windows(3) As SubOptions
    Private MyParent As UserApartment

    Public Sub New(parentForm As UserApartment)
        ' This call is required by the designer.
        InitializeComponent()

        'MyParent = ParentForm
        TopOptions(0) = Bed
        TopOptions(1) = LightControl
        TopOptions(2) = BedroomWindow1
        TopOptions(3) = BedroomDoor
        TopOptions(4) = MainTaskBar.MenuBarOption

        For i = 0 To 4
            TopOptions(i).Initialize()
        Next

        environment(0) = LightControl
        environment(1) = FanControl
        environment(2) = MainTaskBar.Back

        environment(2).Initialize()

        Windows(0) = BedroomWindow1
        Windows(1) = BedroomWindow2
        Windows(2) = BedroomWindow3
        Windows(3) = MainTaskBar.Back

        For i = 0 To 2
            Windows(i).Initialize()
        Next

        MyParent = parentForm

    End Sub
    Private Sub Bedroom_Load(sender As Object, e As EventArgs) Handles Me.Load
        MainTaskBar.PreviousScreen.Image = My.Resources.apartmentButton
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
            focusIsOn = (focusIsOn + 1) Mod 5
            TopOptions(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            TopOptions(focusIsOn).InnerScanningNext()
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
                For i = 1 To Windows.Length - 2
                    Windows(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Windows.Length - 2
                    Windows(i).LoseFocus()
                Next
            End If

        End If
    End Sub



#End Region

#Region "Other Events"

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 Then
            If focusIsOn = 0 Then
                If Bed.Tag = "up" Then
                    Bed.Image = My.Resources.bedDown
                    Bed.Tag = "down"
                ElseIf Bed.Tag = "down" Then
                    Bed.Image = My.Resources.bedUp
                    Bed.Tag = "up"
                End If
            ElseIf focusIsOn = 1 Then
                scanninglevel = 1
                TopOptions(focusIsOn).StartInnerScanning(environment)
            ElseIf focusIsOn = 4 Then
                scanninglevel = 1
                MainTaskBar.MenuBarOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())
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

            ElseIf MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                If focusIsOn = 5 Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
                    scanninglevel = 0
                Else
                    TopOptions(focusIsOn).StopInnerScanning()
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

        End If
    End Sub

    Private Sub Bedroom_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub
#End Region

End Class