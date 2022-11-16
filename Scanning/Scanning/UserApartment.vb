Public Class UserApartment

    Private TopOptions(5) As SubOptions
    Private Windows(5) As SubOptions
    Private Doors(4) As SubOptions

    Private ent As New Form1()
    Private bedroomForm As New Bedroom()
    Private kitchenForm As New Kitchen()
    Private bathroomForm As New Bathroom()

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
        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2
        Windows(2) = BedroomWindow1
        Windows(3) = BedroomWindow2
        Windows(4) = BedroomWindow3
        Windows(5) = BathroomWindow
        Doors(0) = FrontDoor
        Doors(1) = KitchenDoor
        Doors(2) = LivingroomDoor
        Doors(3) = BedroomDoor
        Doors(4) = BathroomDoor

        For i = 0 To 5
            TopOptions(i).Initialize()
        Next

        For i = 0 To 5
            Windows(i).Initialize()
        Next

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
        Else
            TopOptions(focusIsOn).InnerScanningNext()
        End If
    End Sub

    Private Sub LivingroomWindow1_ColorChanged(sender As Object, e As EventArgs) Handles LivingroomWindow1.BackColorChanged, FrontDoor.BackColorChanged
        If scanninglevel = 0 And ScanningTimer.Enabled Then
            If LivingroomWindow1.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To Windows.Length - 1
                    Windows(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Windows.Length - 1
                    Windows(i).LoseFocus()
                Next
            End If

            If FrontDoor.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To Doors.Length - 1
                    Doors(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Doors.Length - 1
                    Doors(i).LoseFocus()
                Next
            End If

        End If
    End Sub



#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        scanninglevel = 1
        If focusIsOn = 0 Then
            StopScanning()
            ent.Show()
        ElseIf focusIsOn = 1 Then
            StopScanning()
            bedroomForm.Show()
        ElseIf focusIsOn = 2 Then
            StopScanning()
            kitchenForm.Show()
        ElseIf focusIsOn = 3 Then
            StopScanning()
            bathroomForm.Show()
        ElseIf focusIsOn = 4 Then
            TopOptions(focusIsOn).StartInnerScanning(Windows)
        ElseIf focusIsOn = 5 Then
            TopOptions(focusIsOn).StartInnerScanning(Doors)
        End If
    End Sub

#End Region

End Class