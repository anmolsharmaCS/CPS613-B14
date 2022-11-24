Public Class MainForm

    Private Options(4) As SubOptions

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Options(0) = Me.MainEntrance
        Me.Options(1) = Me.Floor1
        Me.Options(2) = Me.Floor2
        Me.Options(3) = Me.Floor3
        Me.Options(4) = Me.Floor4

        For i = 0 To 4
            Me.Options(i).Initialize()
        Next


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    ' Scanning method will be changed in final version, this is temporary to show we have something working
    Private scanninglevel As Integer
    Private focusIsOn As Integer
    Private doorOn As Integer = 0

    ' Start scanning on the first submenu
    Public Sub StartScanning()
        Me.scanninglevel = 0
        MainEntrance.ReceiveFocus()
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
        Me.scanninglevel = 1
        Me.Options(Me.focusIsOn).ReceiveFocus()
        Me.ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            If doorOn = 0 Then
                MainEntrance.ReceiveFocus()
                doorOn = 1
            ElseIf doorOn = 1 Then
                MainEntrance.LoseFocus()
                doorOn = 0
            End If
        ElseIf scanninglevel = 1 Then
            Me.Options(Me.focusIsOn).LoseFocus()
            Me.focusIsOn = (Me.focusIsOn + 1) Mod 5
            Me.Options(Me.focusIsOn).ReceiveFocus()
            If focusIsOn = 0 Or focusIsOn = 1 Then
                elevator.Top = 487
                elevatorCrack.Top = 487
            ElseIf focusIsOn = 2 Then
                elevator.Top = 337
                elevatorCrack.Top = 337
            ElseIf focusIsOn = 3 Then
                elevator.Top = 180
                elevatorCrack.Top = 180
            ElseIf focusIsOn = 4 Then
                elevator.Top = 22
                elevatorCrack.Top = 22
            End If
        Else
            Me.Options(Me.focusIsOn).InnerScanningNext()
        End If

    End Sub

#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim Floor As New FloorHallways(focusIsOn, Me)
        If scanninglevel = 0 Then
            scanninglevel = 1
            focusIsOn = 0
            building.Hide()
            window1.Hide()
            window2.Hide()
            window3.Hide()
            window4.Hide()
            window5.Hide()
            window6.Hide()
            window7.Hide()
            window8.Hide()
            window9.Hide()
            window10.Hide()
            window11.Hide()
            Options(Me.focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            If focusIsOn = 0 Then
                scanninglevel = 0
                building.Show()
                window1.Show()
                window2.Show()
                window3.Show()
                window4.Show()
                window5.Show()
                window6.Show()
                window7.Show()
                window8.Show()
                window9.Show()
                window10.Show()
                window11.Show()
                elevator.Top = 487
                elevatorCrack.Top = 487
            Else
                Options(focusIsOn).LoseFocus()
                StopScanning()
                Floor.Show()
                Floor.StartScanning()
            End If
        End If
    End Sub
#End Region
End Class

