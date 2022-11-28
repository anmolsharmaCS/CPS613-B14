Imports System.ComponentModel

Public Class FloorHallways

    Private Options(1) As SubOptions
    Private Apartments(6) As SubOptions
    Private doorBellOptions(1) As SubOptions

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

        Options(0) = MainTaskBar.MenuBarOption
        Options(1) = Apartment01

        For i = 0 To 1
            Options(i).Initialize()
        Next

        Apartments(0) = Apartment01
        Apartments(1) = Apartment02
        Apartments(2) = Apartment03
        Apartments(3) = Apartment04
        Apartments(4) = Apartment05
        Apartments(5) = Apartment06
        Apartments(6) = exitApartments

        For i = 0 To 6
            Apartments(i).Initialize()
        Next

        doorBellOptions(0) = doorbellOption
        doorBellOptions(1) = exitDoorbell

        doorBellOptions(0).Initialize()
        doorBellOptions(1).Initialize()

        waitingForResponse.MyParent = Me
        MyParent = parentForm

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
        focusIsOn = (focusIsOn + 1) Mod 2
        Me.Options(focusIsOn).ReceiveFocus()
        Me.ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick

        If scanninglevel = 0 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 2
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            Options(focusIsOn).InnerScanningNext()
        ElseIf scanninglevel = 2 Then
            doorbellOption.InnerScanningNext()
        End If

    End Sub

#End Region

#Region "KeyPress"
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Then
                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                Options(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then
                exitApartments.Show()
                Options(focusIsOn).StartInnerScanning(Apartments)

            End If
        ElseIf scanninglevel = 1 Then
            If focusIsOn = 0 Then
                If MainTaskBar.exitTaskBar.BackColor = Color.LemonChiffon Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
                    scanninglevel = 0
                    MainTaskBar.exitTaskBar.Hide()
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
                    Close()
                ElseIf exitApartments.BackColor = Color.LemonChiffon Then
                    Apartment01.StopInnerScanning()
                    scanninglevel = 0
                    exitApartments.Hide()

                End If
            Else
                If Apartment02.BackColor = Color.LemonChiffon And Label2.Text = "402" Then
                    Apartment02.LoseFocus()
                    StopScanning()
                    exitApartments.Hide()
                    Apartment.Show()
                    Apartment.StartScanning()
                Else
                    scanninglevel = 2
                    exitDoorbell.Show()
                    doorbellOption.Show()
                    doorbellOption.StartInnerScanning(doorBellOptions)
                End If
            End If
        ElseIf scanninglevel = 2 Then
            If exitDoorbell.BackColor = Color.LemonChiffon Then
                exitDoorbell.Hide()
                doorbellOption.Hide()
                doorbellOption.StopInnerScanning()

                waitingForResponse.ellipseTimer.Enabled = False
                waitingForResponse.dot1.Hide()
                waitingForResponse.dot2.Hide()
                waitingForResponse.dot3.Hide()
                waitingForResponse.countDown = 0
                waitingForResponse.dotNumber = 0

                doorbellOption.Tag = "doorbell"
                doorbellOption.Image = My.Resources.doorbell

                scanninglevel = 1

            ElseIf doorbellOption.BackColor = Color.LemonChiffon Then
                If doorbellOption.Tag = "doorbell" Then
                    waitingForResponse.ellipseTimer.Enabled = True
                    doorbellOption.Tag = "cancelDoorbell"
                    doorbellOption.Image = My.Resources.doorbellCancel

                ElseIf doorbellOption.Tag = "cancelDoorbell" Then
                    waitingForResponse.ellipseTimer.Enabled = False
                    waitingForResponse.dot1.Hide()
                    waitingForResponse.dot2.Hide()
                    waitingForResponse.dot3.Hide()
                    waitingForResponse.countDown = 0
                    waitingForResponse.dotNumber = 0

                    doorbellOption.Tag = "doorbell"
                    doorbellOption.Image = My.Resources.doorbell
                ElseIf doorbellOption.Tag = "enter" Then
                    exitDoorbell.Hide()
                    doorbellOption.Hide()
                    doorbellOption.StopInnerScanning()

                    waitingForResponse.ellipseTimer.Enabled = False
                    waitingForResponse.dot1.Hide()
                    waitingForResponse.dot2.Hide()
                    waitingForResponse.dot3.Hide()
                    waitingForResponse.countDown = 0
                    waitingForResponse.dotNumber = 0

                    doorbellOption.Tag = "doorbell"
                    doorbellOption.Image = My.Resources.doorbell

                    'Apartment02.LoseFocus()
                    StopScanning()
                    exitApartments.Hide()
                    Dim friendApt As New FriendApartment(Me)
                    friendApt.Show()
                    friendApt.StartScanning()

                End If
            End If
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

    Private Sub FloorHallways_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub


#End Region

End Class