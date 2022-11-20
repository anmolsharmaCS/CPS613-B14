Imports System.ComponentModel

Public Class FloorHallways

    Private Options(6) As SubOptions
    Private MyParent As MainForm

    Public Sub New(floorNumber, parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        Label1.Text = floorNumber.ToString() & "01"
        Label2.Text = floorNumber.ToString() & "02"
        Label3.Text = floorNumber.ToString() & "03"
        Label4.Text = floorNumber.ToString() & "04"
        Label5.Text = floorNumber.ToString() & "05"
        Label6.Text = floorNumber.ToString() & "06"

        If Label2.Text = "402" Then
            Home.Show()
        Else
            Home.Hide()
        End If

        Options(0) = Elevator
        Options(1) = Apartment01
        Options(2) = Apartment02
        Options(3) = Apartment03
        Options(4) = Apartment04
        Options(5) = Apartment05
        Options(6) = Apartment06

        MyParent = parentForm

        For i = 0 To 6
            Me.Options(i).Initialize()
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.StartScanning()
    End Sub

#Region "Timer Properties and methods"

    ' Make the Scanningtimer interval accessible 
    Public Property ScanningInterval As Integer
        Get
            Return Me.ScanningTimer.Interval
        End Get
        Set(value As Integer)
            Me.ScanningTimer.Interval = value
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
            focusIsOn = (focusIsOn + 1) Mod 7
            Options(focusIsOn).ReceiveFocus()
        Else
            Options(focusIsOn).InnerScanningNext()
        End If

    End Sub

#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If focusIsOn = 2 And Label2.Text = "402" Then
            Dim Apartment As New UserApartment(Me)
            StopScanning()
            Apartment.Show()

        End If
    End Sub

    Private Sub FloorHallways_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub



#End Region

End Class