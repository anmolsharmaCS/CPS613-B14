Imports System.ComponentModel

Public Class UserApartment

    Private TopOptions(4) As SubOptions
    Private Rooms(4) As SubOptions
    Private Windows(3) As SubOptions
    Private temperature(2) As SubOptions

    Private livingroomForm As New Livingroom(Me)
    Private bedroomForm As New Bedroom(Me)
    Private kitchenForm As New Kitchen(Me)
    Private bathroomForm As New Bathroom(Me)


    Private shutters(3) As PictureBox
    Private MyParent As FloorHallways

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopOptions(0) = MainTaskBar.MenuBarOption
        TopOptions(1) = LivingRoom
        TopOptions(2) = LivingroomWindow1
        TopOptions(3) = tempOption

        For i = 0 To 3
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

        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2
        Windows(2) = BedroomWindow1
        Windows(3) = BedroomWindow2

        For i = 0 To 3
            Windows(i).Initialize()
        Next

        temperature(0) = upArrow
        temperature(1) = downArrow
        temperature(2) = exitTemp

        For i = 0 To 2
            temperature(i).Initialize()
        Next

        shutters(0) = LivingroomWindow1Shutters
        shutters(1) = LivingroomWindow2Shutters
        shutters(2) = BedroomWindow1Shutters
        shutters(3) = BedroomWindow2Shutters

        MyParent = parentForm

        livingroomLight.Parent = LivingRoom
        bedroomLight.Parent = Bedroom
        kitchenLight.Parent = Kitchen
        bathroomLight.Parent = Bathroom

        livingroomFan.Parent = LivingRoom
        bedroomFan.Parent = Bedroom
        kitchenFan.Parent = Kitchen
        bathroomFan.Parent = Bathroom

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
            focusIsOn = (focusIsOn + 1) Mod 4
            TopOptions(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 1 Then
            TopOptions(focusIsOn).InnerScanningNext()
        End If
    End Sub

#End Region

#Region "Other events"

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

            ElseIf focusIsOn = 2 Then

                Me.WindowMenu.Visible = True
                TopOptions(focusIsOn).StartInnerScanning(WindowMenu.GetTaskBarOptions())

            ElseIf focusIsOn = 3 Then

                exitTemp.Show()
                tempOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(temperature)

            End If

        ElseIf scanninglevel = 1 Then

            If WindowMenu.exitWindows.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                Me.WindowMenu.Visible = False
                scanninglevel = 0

            ElseIf Me.WindowMenu.windowControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.windowControl.Tag = "open" Then

                    WindowMenu.windowControl.Image = My.Resources.WindowClosed
                    WindowMenu.windowControl.Tag = "closed"
                    For i = 0 To shutters.Length - 1

                        shutters(i).Hide()

                    Next
                    For i = 0 To bedroomForm.shutters.Length - 1

                        bedroomForm.shutters(i).Hide()

                    Next
                    bedroomForm.WindowMenu.windowControl.Image = My.Resources.WindowClosed
                    bedroomForm.WindowMenu.windowControl.Tag = "closed"
                    For i = 0 To livingroomForm.shutters.Length - 1

                        livingroomForm.shutters(i).Hide()

                    Next
                    livingroomForm.WindowMenu.windowControl.Image = My.Resources.WindowClosed
                    livingroomForm.WindowMenu.windowControl.Tag = "closed"

                ElseIf WindowMenu.windowControl.Tag = "closed" Then

                    WindowMenu.windowControl.Image = My.Resources.WindowOpen
                    WindowMenu.windowControl.Tag = "open"
                    For i = 0 To shutters.Length - 1

                        shutters(i).Show()

                    Next
                    For i = 0 To bedroomForm.shutters.Length - 1

                        bedroomForm.shutters(i).Show()

                    Next
                    bedroomForm.WindowMenu.windowControl.Image = My.Resources.WindowOpen
                    bedroomForm.WindowMenu.windowControl.Tag = "open"
                    For i = 0 To livingroomForm.shutters.Length - 1

                        livingroomForm.shutters(i).Show()

                    Next
                    livingroomForm.WindowMenu.windowControl.Image = My.Resources.WindowOpen
                    livingroomForm.WindowMenu.windowControl.Tag = "open"

                End If

            ElseIf Me.WindowMenu.blindControl.BackColor = Color.LemonChiffon Then

                If WindowMenu.blindControl.Tag = "open" Then

                    WindowMenu.blindControl.Image = My.Resources.BlindsClosed
                    WindowMenu.blindControl.Tag = "closed"
                    'For i = 0 To blinds.Length - 1
                    'blinds(i).Hide()
                    'Next

                ElseIf WindowMenu.blindControl.Tag = "closed" Then

                    WindowMenu.blindControl.Image = My.Resources.BlindsOpen
                    WindowMenu.blindControl.Tag = "open"
                    'For i = 0 To blinds.Length - 1
                    'blinds(i).Show()
                    'Next

                End If

            ElseIf LivingRoom.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                livingroomForm.Show()
                livingroomForm.StartScanning()

            ElseIf Bedroom.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                bedroomForm.Show()
                bedroomForm.StartScanning()

            ElseIf Kitchen.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                kitchenForm.Show()
                kitchenForm.StartScanning()

            ElseIf Bathroom.BackColor = Color.LemonChiffon Then

                StopScanning()
                exitRooms.Hide()
                bathroomForm.Show()
                bathroomForm.StartScanning()

            ElseIf exitRooms.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                scanninglevel = 0
                exitRooms.Hide()

            ElseIf upArrow.BackColor = Color.LemonChiffon Then

                tempLabel.Text = CInt(tempLabel.Text) + 1

            ElseIf downArrow.BackColor = Color.LemonChiffon Then

                tempLabel.Text = CInt(tempLabel.Text) - 1

            ElseIf exitTemp.BackColor = Color.LemonChiffon Then

                TopOptions(focusIsOn).StopInnerScanning()
                scanninglevel = 0
                exitTemp.Hide()

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

    Private Sub LivingroomWindow1_ColorChanged(sender As Object, e As EventArgs) Handles LivingRoom.BackColorChanged, LivingroomWindow1.BackColorChanged

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

            If LivingroomWindow1.BackColor.Equals(Color.LemonChiffon) Then

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

    Private Sub UserApartment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub


#End Region

End Class