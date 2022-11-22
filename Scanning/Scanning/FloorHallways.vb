Imports System.ComponentModel

Public Class FloorHallways

    Private Options(2) As SubOptions
    Private Apartments(6) As SubOptions
    Private MyParent As MainForm
    Private Apartment As New UserApartment(Me)

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
        Options(2) = MainTaskBar.MenuBarOption

        For i = 0 To 2
            Options(i).Initialize()
        Next

        Apartments(0) = Apartment01
        Apartments(1) = Apartment02
        Apartments(2) = Apartment03
        Apartments(3) = Apartment04
        Apartments(4) = Apartment05
        Apartments(5) = Apartment06
        Apartments(6) = MainTaskBar.Back

        For i = 0 To 6
            Apartments(i).Initialize()
        Next

        MyParent = parentForm

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        MainTaskBar.PreviousScreen.Image = My.Resources.buildingButton
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
        Me.scanninglevel = 0
        Me.focusIsOn = 0
        Me.Options(Me.focusIsOn).ReceiveFocus()
        Me.ScanningTimer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        Me.ScanningTimer.Stop()
        Me.Options(Me.focusIsOn).LoseFocus()
        Me.Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        Me.scanninglevel = 0
        focusIsOn = (focusIsOn + 1) Mod 3
        Me.Options(focusIsOn).ReceiveFocus()
        Me.ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick

        If scanninglevel = 0 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 3
            Options(focusIsOn).ReceiveFocus()
        Else
            Options(focusIsOn).InnerScanningNext()
        End If

    End Sub

#End Region

#Region "Other events"

    Private Sub Apartment01_ColorChanged(sender As Object, e As EventArgs) Handles Apartment01.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If Apartment01.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To Apartments.Length - 2
                    Apartments(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Apartments.Length - 2
                    Apartments(i).LoseFocus()
                Next
            End If

        End If
    End Sub

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Then
                StopScanning()
                Me.Close()

            ElseIf focusIsOn = 1 Then
                Options(focusIsOn).StartInnerScanning(Apartments)

            ElseIf focusIsOn = 2 Then
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())
            End If
        Else
            If MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                If focusIsOn = 1 Then
                    Apartment01.StopInnerScanning()
                    scanninglevel = 0
                ElseIf focusIsOn = 2 Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
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
            ElseIf Apartment02.BackColor = Color.LemonChiffon And Label2.Text = "402" Then
                Apartment02.LoseFocus()
                StopScanning()
                Apartment.Show()
                Apartment.StartScanning()
            End If
        End If

    End Sub

    Private Sub FloorHallways_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub


#End Region

End Class