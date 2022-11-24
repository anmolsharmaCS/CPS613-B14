Imports System.ComponentModel

Public Class Livingroom

    Private Options(3) As SubOptions
    Private environment(2) As SubOptions
    Private Windows(1) As SubOptions

    Private ent As New Entertainment(Me)

    Public shutters(1) As PictureBox

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = MainTaskBar.MenuBarOption
        Options(1) = LivingroomWindow1
        Options(2) = entSystem
        Options(3) = envOption

        For i = 0 To 3
            Options(i).Initialize()
        Next


        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2

        Windows(0).Initialize()
        Windows(1).Initialize()

        environment(0) = lightOption
        environment(1) = fanOption
        environment(2) = exitLivingroomEnv

        For i = 0 To 2
            environment(i).Initialize()
        Next

        shutters(0) = livingroomShutters1
        shutters(1) = livingroomShutters2

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
        Else
            Options(focusIsOn).InnerScanningNext()
        End If
    End Sub


#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then

            If focusIsOn = 0 Then

                scanninglevel = 1
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then

                scanninglevel = 1
                WindowMenu.Show()
                Options(focusIsOn).StartInnerScanning(WindowMenu.GetTaskBarOptions)

            ElseIf focusIsOn = 2 Then

                StopScanning()
                ent.Show()
                ent.StartScanning()

            ElseIf focusIsOn = 3 Then

                scanninglevel = 1
                envOption.LoseFocus()
                exitLivingroomEnv.Show()
                Options(focusIsOn).StartInnerScanning(environment)

            End If

        Else

            If lightOption.BackColor = Color.LemonChiffon Then

                If lightOption.Tag = "on" Then

                    lightOption.Image = My.Resources.bulbUnlit
                    MyParent.livingroomLight.Image = My.Resources.bulbUnlit
                    lightOption.Tag = "off"

                ElseIf lightOption.Tag = "off" Then

                    lightOption.Image = My.Resources.bulbLit
                    MyParent.livingroomLight.Image = My.Resources.bulbLit
                    lightOption.Tag = "on"

                End If

            ElseIf fanOption.BackColor = Color.LemonChiffon Then

                If fanOption.Tag = "on" Then

                    fanOption.Image = My.Resources.fanOff
                    MyParent.livingroomFan.Image = My.Resources.fanOff
                    fanOption.Tag = "off"

                ElseIf fanOption.Tag = "off" Then

                    fanOption.Image = My.Resources.fanOn
                    MyParent.livingroomFan.Image = My.Resources.fanOn
                    fanOption.Tag = "on"

                End If

            ElseIf exitLivingroomEnv.BackColor = Color.LemonChiffon Then

                exitLivingroomEnv.Hide()
                envOption.StopInnerScanning()
                scanninglevel = 0

            ElseIf WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                Options(focusIsOn).StopInnerScanning()
                WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.windowControl.Tag = "open" Then

                    WindowMenu.windowControl.Image = My.Resources.WindowClosed
                    WindowMenu.windowControl.Tag = "closed"
                    For i = 0 To shutters.Length - 1

                        shutters(i).Hide()

                    Next
                    MyParent.LivingroomWindow1Shutters.Hide()
                    MyParent.LivingroomWindow2Shutters.Hide()

                ElseIf WindowMenu.windowControl.Tag = "closed" Then

                    WindowMenu.windowControl.Image = My.Resources.WindowOpen
                    WindowMenu.windowControl.Tag = "open"
                    For i = 0 To shutters.Length - 1

                        shutters(i).Show()

                    Next
                    MyParent.LivingroomWindow1Shutters.Show()
                    MyParent.LivingroomWindow2Shutters.Show()

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
                MainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()

            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then

                StopScanning()
                MainTaskBar.PreviousScreen.LoseFocus()
                MainTaskBar.exitTaskBar.Hide()
                Hide()
                MyParent.ResumeScanning()

            End If

        End If

    End Sub

    Private Sub Groups_ColorChanged(sender As Object, e As EventArgs) Handles LivingroomWindow1.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If LivingroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
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

    Private Sub Livingroom_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub

#End Region

End Class