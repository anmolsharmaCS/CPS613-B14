Public Class DoorbellMenu

    Private Options(1) As SubOptions

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Options(0) = Me.OpenDoor
        Options(1) = Me.CloseDoor

        For i = 0 To 1
            Options(i).Initialize()
        Next

        Me.StartScanning()
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
        Me.Focus()
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
            focusIsOn = (focusIsOn + 1) Mod 2
            Options(focusIsOn).ReceiveFocus()
        End If
    End Sub

#End Region

#Region "Key Press"

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Me.OpenDoor.BackColor = Color.LemonChiffon Then

            Me.Close()
            Me.Dispose()
        ElseIf Me.CloseDoor.BackColor = Color.LemonChiffon Then

            Me.Close()
            Me.Dispose()
        End If
    End Sub

#End Region

End Class