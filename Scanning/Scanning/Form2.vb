Imports System.ComponentModel
Imports System.Reflection.Emit
Imports System.Threading
Public Class Form2
    Private Options(8) As SubOptions

    Private MyParentHall As FloorHallways
    Private MyParentApartment As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = MakeCall
        Options(1) = MakeUrgentCall
        Options(2) = CloseWindow
        Options(3) = TransferHelp
        Options(4) = BathroomHelp
        Options(5) = BedroomHelp
        Options(6) = ReturnToUrgency
        Options(7) = CancelCall
        Options(8) = CallAgain

        For i = 0 To 8
            Options(i).Initialize()
        Next

        If parentForm.GetType() Is GetType(FloorHallways) Then
            MyParentHall = parentForm
        ElseIf parentForm.GetType() Is GetType(UserApartment) Then
            MyParentApartment = parentForm
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        StartScanning()
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

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick

        If scanninglevel = 0 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 3
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = ((focusIsOn + 1) Mod 4) + 3
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 2 Then
            Options(focusIsOn).LoseFocus()
            focusIsOn = ((focusIsOn + 1) Mod 2) + 7
            Options(focusIsOn).ReceiveFocus()
        End If

    End Sub

#End Region

#Region "Other events"

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Then
                focusIsOn = 2
            ElseIf focusIsOn = 1 Then
                focusIsOn = 2
            ElseIf focusIsOn = 2 Then
                Me.Close()
            End If
        ElseIf scanninglevel = 1 Then
            scanninglevel = 2
            If focusIsOn = 3 Then
                focusIsOn = 6
                TimerStart()
            ElseIf focusIsOn = 4 Then
                focusIsOn = 6
                TimerStart()
            ElseIf focusIsOn = 5 Then
                focusIsOn = 6
                TimerStart()
            ElseIf focusIsOn = 6 Then
                focusIsOn = 9
                scanninglevel = 0
            End If
        ElseIf scanninglevel = 2 Then
            If focusIsOn = 7 Then
                focusIsOn = 9
                scanninglevel = 0
            ElseIf focusIsOn = 8 Then

            End If

        End If

    End Sub
    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MyParentHall IsNot Nothing Then
            MyParentHall.ResumeScanning()
        ElseIf MyParentApartment IsNot Nothing Then
            MyParentApartment.ResumeScanning()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        While (PictureBox2.Location.X < 250)
            PictureBox2.Location = New Point(PictureBox2.Location.X + 1, PictureBox2.Location.Y)
        End While

    End Sub

#End Region

    Private Sub TimerStart()

        ScanningTimer.Enabled = False
        Label1.Text = ""

        ScanningTimer.Enabled = True
        Dim ThisMoment As Date
        ThisMoment = Now
        Label1.Text = "Your assistance should arrive at: (" & ThisMoment.Hour & "00:" & ThisMoment.Minute + 2 & ":00)"

    End Sub

End Class