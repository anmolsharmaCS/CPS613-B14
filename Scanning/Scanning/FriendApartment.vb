Public Class FriendApartment

    Private TopOptions(1) As SubOptions
    Private Rooms(4) As SubOptions

    Private MyParent As FloorHallways

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopOptions(0) = MainTaskBar.MenuBarOption
        TopOptions(1) = LivingRoom

        For i = 0 To 1
            TopOptions(i).Initialize()
        Next

        Rooms(0) = LivingRoom
        Rooms(1) = Bedroom
        Rooms(2) = Kitchen
        Rooms(3) = Bathroom
        Rooms(4) = exitRooms

        For i = 0 To 4
            Rooms(i).Initialize()
        Next

        MyParent = parentForm

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

    Public Sub ResumeScanning()
        scanninglevel = 0
        focusIsOn = 0
        TopOptions(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            TopOptions(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod 2
            TopOptions(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            TopOptions(focusIsOn).InnerScanningNext()
        End If
    End Sub

#End Region

#Region "KeyPress"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then

            scanninglevel = 1
            If focusIsOn = 0 Then

                MainTaskBar.exitTaskBar.Show()
                MainTaskBar.MenuBarOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())

            ElseIf focusIsOn = 1 Then

                exitRooms.Show()
                TopOptions(focusIsOn).StartInnerScanning(Rooms)

            End If

        ElseIf scanninglevel = 1 Then

            If exitRooms.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                scanninglevel = 0
                exitRooms.Hide()

            ElseIf MainTaskBar.PreviousScreen.BackColor = Color.LemonChiffon Then

                StopScanning()
                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.PreviousScreen.LoseFocus()
                Hide()
                MyParent.ResumeScanning()

            ElseIf MainTaskBar.Assistance.BackColor = Color.LemonChiffon Then

                Dim Assistance As New Assistance(Me)
                StopScanning()
                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                Assistance.Show()

            ElseIf MainTaskBar.exitTaskBar.BackColor = Color.LemonChiffon Then

                MainTaskBar.exitTaskBar.Hide()
                MainTaskBar.MenuBarOption.StopInnerScanning()
                scanninglevel = 0

            End If

        End If
    End Sub

#End Region

#Region "Other methods"

    Private Sub Livingroom_ColorChanged(sender As Object, e As EventArgs) Handles LivingRoom.BackColorChanged

        If scanninglevel = 0 And ScanningTimer.Enabled Then

            If LivingRoom.BackColor.Equals(Color.LemonChiffon) Then

                For i = 1 To Rooms.Length - 2
                    Rooms(i).ReceiveFocus()
                Next

            Else

                For i = 1 To Rooms.Length - 2
                    Rooms(i).LoseFocus()
                Next

            End If

        End If
    End Sub

    Private Sub FriendApartment_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub

#End Region

End Class