Imports System.ComponentModel

Public Class Bedroom
    Private TopOptions(3) As SubOptions
    Private Windows(2) As SubOptions
    Private MyParent As UserApartment

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'MyParent = ParentForm
        TopOptions(0) = Bed
        TopOptions(1) = LightControl
        TopOptions(2) = EnvControl
        TopOptions(3) = BedroomDoor
        Windows(0) = BedroomWindow1
        Windows(1) = BedroomWindow2
        Windows(2) = BedroomWindow3

        ' Add any initialization after the InitializeComponent() call.
        For i = 0 To 2
            Me.TopOptions(i).Initialize()
            Me.Windows(i).Initialize()
        Next
        Me.TopOptions(3).Initialize()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub BedroomWindow1_ColorChanged(sender As Object, e As EventArgs) Handles BedroomWindow1.BackColorChanged, BedroomDoor.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If BedroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To Windows.Length - 1
                    Windows(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Windows.Length - 1
                    Windows(i).LoseFocus()
                Next
            End If

        End If
    End Sub



#End Region

End Class