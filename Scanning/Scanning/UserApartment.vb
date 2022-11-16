﻿Public Class UserApartment

    Private TopOptions(5) As SubOptions
    Private Windows(5) As SubOptions
    Private Doors(4) As SubOptions

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopOptions(0) = LivingRoom
        TopOptions(1) = Bedroom
        TopOptions(2) = Kitchen
        TopOptions(3) = Bathroom
        TopOptions(4) = LivingroomWindow1
        TopOptions(5) = FrontDoor

        For i = 0 To 5
            TopOptions(i).Initialize()
        Next

        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2
        Windows(2) = BedroomWindow1
        Windows(3) = BedroomWindow2
        Windows(4) = BedroomWindow3
        Windows(5) = BathroomWindow

        For i = 0 To 5
            Windows(i).Initialize()
        Next

        Doors(0) = FrontDoor
        Doors(1) = LivingroomDoor
        Doors(2) = BedroomDoor
        Doors(3) = KitchenDoor
        Doors(4) = BathroomDoor

        For i = 0 To 4
            Doors(i).Initialize()
        Next

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        StartScanning()
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
            focusIsOn = (focusIsOn + 1) Mod 6
            TopOptions(focusIsOn).ReceiveFocus()
            'Else
            'TopOptions(focusIsOn).InnerScanningNext()
        End If
    End Sub

    ' When the user selects a submenu, start scanning within that submenu
    'Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
    'scanninglevel = 1
    'TopOptions(focusIsOn).StartInnerScanning()
    'End Sub

    Private Sub LivingroomWindow1_ColorChanged(sender As Object, e As EventArgs) Handles LivingroomWindow1.BackColorChanged, FrontDoor.BackColorChanged
        If scanninglevel = 0 Then
            If LivingroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
                LivingroomWindow2.ReceiveFocus()
                BedroomWindow1.ReceiveFocus()
                BedroomWindow2.ReceiveFocus()
                BedroomWindow3.ReceiveFocus()
                BathroomWindow.ReceiveFocus()
            Else
                LivingroomWindow2.LoseFocus()
                BedroomWindow1.LoseFocus()
                BedroomWindow2.LoseFocus()
                BedroomWindow3.LoseFocus()
                BathroomWindow.LoseFocus()
            End If

            If FrontDoor.BackColor.Equals(Color.LemonChiffon) Then
                LivingroomDoor.ReceiveFocus()
                BedroomDoor.ReceiveFocus()
                KitchenDoor.ReceiveFocus()
                BathroomDoor.ReceiveFocus()
            Else
                LivingroomDoor.LoseFocus()
                BedroomDoor.LoseFocus()
                KitchenDoor.LoseFocus()
                BathroomDoor.LoseFocus()
            End If

        End If
    End Sub

#End Region


End Class