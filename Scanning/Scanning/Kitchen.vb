﻿Imports System.ComponentModel

Public Class Kitchen

    Private Options(3) As SubOptions
    Private environment(2) As SubOptions

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = cooking
        Options(1) = lightOption
        Options(2) = kitchenDoor
        Options(3) = MainTaskBar.MenuBarOption

        For i = 0 To 3
            Options(i).Initialize()
        Next

        environment(0) = lightOption
        environment(1) = fanOption
        environment(2) = MainTaskBar.PreviousScreen

        environment(1).Initialize()

        MyParent = parentForm

    End Sub

    Private Sub Kitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Groups_ColorChanged(sender As Object, e As EventArgs) Handles lightOption.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If lightOption.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To environment.Length - 2
                    environment(i).ReceiveFocus()
                Next
            Else
                For i = 1 To environment.Length - 2
                    environment(i).LoseFocus()
                Next
            End If
        End If
    End Sub



#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If scanninglevel = 0 Then
            If focusIsOn = 1 Then
                scanninglevel = 1
                Options(focusIsOn).StartInnerScanning(environment)
            ElseIf focusIsOn = 3 Then
                scanninglevel = 1
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())
            End If
        Else
            If lightOption.BackColor = Color.LemonChiffon Then
                If lightOption.Tag = "on" Then
                    lightOption.Image = My.Resources.bulbUnlit
                    MyParent.kitchenLight.Image = My.Resources.bulbUnlit
                    lightOption.Tag = "off"
                ElseIf lightOption.Tag = "off" Then
                    lightOption.Image = My.Resources.bulbLit
                    MyParent.kitchenLight.Image = My.Resources.bulbLit
                    lightOption.Tag = "on"
                End If
            ElseIf fanOption.BackColor = Color.LemonChiffon Then
                If fanOption.Tag = "on" Then
                    fanOption.Image = My.Resources.fanOff
                    MyParent.kitchenFan.Image = My.Resources.fanOff
                    fanOption.Tag = "off"
                ElseIf fanOption.Tag = "off" Then
                    fanOption.Image = My.Resources.fanOn
                    MyParent.kitchenFan.Image = My.Resources.fanOn
                    fanOption.Tag = "on"
                End If
            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then
                If focusIsOn = 6 Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
                    scanninglevel = 0
                Else
                    Options(focusIsOn).StopInnerScanning()
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
                Hide()
                MyParent.ResumeScanning()
            End If
        End If
    End Sub

    Private Sub Kitchen_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        MyParent.ResumeScanning()
    End Sub

#End Region

End Class