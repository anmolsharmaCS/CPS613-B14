Public Class MainForm

    Private Options(4) As SubOptions
    Private Floor As New FloorHallways(focusIsOn, Me)

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
        Me.Options(Me.focusIsOn).ReceiveFocus()
        Me.ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            Me.Options(Me.focusIsOn).LoseFocus()
            Me.focusIsOn = (Me.focusIsOn + 1) Mod 5
            Me.Options(Me.focusIsOn).ReceiveFocus()
        Else
            Me.Options(Me.focusIsOn).InnerScanningNext()
        End If

    End Sub

#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If focusIsOn = 0 Then
            StopScanning()
            ' This is also temporary, will likely implement all screens in one form in final product rather than using separate forms
            ' This will make the transition look better and it will make it easier to have some components which are present on all screens
            ' In addition, this does not lead to the correct screen for the selected item, they all lead to a placeholder to show that it works
            Floor.Show()
        Else
            Options(focusIsOn).LoseFocus()
            StopScanning()
            Floor.Show()
            Floor.StartScanning()
        End If
    End Sub

#End Region
End Class

