Imports System.ComponentModel

Public Class UserApartment

    Private TopOptions(4) As SubOptions
    Private Rooms(4) As SubOptions
    Private Windows(6) As SubOptions
    Private Doors(5) As SubOptions
    Private temperature(2) As SubOptions

    Private livingroomForm As New Livingroom(Me)
    Private bedroomForm As New Bedroom(Me)
    Private kitchenForm As New Kitchen(Me)
    Private bathroomForm As New Bathroom(Me)

    Private MyParent As FloorHallways

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopOptions(0) = MainTaskBar.MenuBarOption
        TopOptions(1) = LivingRoom
        TopOptions(2) = LivingroomWindow1
        TopOptions(3) = FrontDoor
        TopOptions(4) = tempOption

        For i = 0 To 4
            TopOptions(i).Initialize()
        Next

        Rooms(0) = LivingRoom
        Rooms(1) = Bedroom
        Rooms(2) = Kitchen
        Rooms(3) = Bathroom
        Rooms(4) = MainTaskBar.Back

        For i = 0 To 3
            Rooms(i).Initialize()
        Next

        Windows(0) = LivingroomWindow1
        Windows(1) = LivingroomWindow2
        Windows(2) = BedroomWindow1
        Windows(3) = BedroomWindow2
        Windows(4) = BedroomWindow3
        Windows(5) = BathroomWindow
        Windows(6) = MainTaskBar.Back

        For i = 0 To 6
            Windows(i).Initialize()
        Next

        temperature(0) = upArrow
        temperature(1) = downArrow
        temperature(2) = MainTaskBar.Back

        For i = 0 To 1
            temperature(i).Initialize()
        Next

        Doors(0) = FrontDoor
        Doors(1) = KitchenDoor
        Doors(2) = LivingroomDoor
        Doors(3) = BedroomDoor
        Doors(4) = BathroomDoor
        Doors(5) = MainTaskBar.Back

        For i = 0 To 5
            Doors(i).Initialize()
        Next

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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        MainTaskBar.PreviousScreen.Image = My.Resources.hallwayButton
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
            focusIsOn = (focusIsOn + 1) Mod 5
            TopOptions(focusIsOn).ReceiveFocus()
        ElseIf focusIsOn = 2 Then
            Me.WindowMenu.MenuBarOption.InnerScanningNext()
        Else
            TopOptions(focusIsOn).InnerScanningNext()
        End If
    End Sub

    Private Sub LivingroomWindow1_ColorChanged(sender As Object, e As EventArgs) Handles LivingRoom.BackColorChanged, LivingroomWindow1.BackColorChanged, FrontDoor.BackColorChanged
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
                For i = 1 To Windows.Length - 2
                    Windows(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Windows.Length - 2
                    Windows(i).LoseFocus()
                Next
            End If

            If FrontDoor.BackColor.Equals(Color.LemonChiffon) Then
                For i = 1 To Doors.Length - 2
                    Doors(i).ReceiveFocus()
                Next
            Else
                For i = 1 To Doors.Length - 2
                    Doors(i).LoseFocus()
                Next
            End If

        End If
    End Sub



#End Region

#Region "Other events"

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Then
                MainTaskBar.MenuBarOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(MainTaskBar.GetTaskBarOptions())
            ElseIf focusIsOn = 1 Then
                TopOptions(focusIsOn).StartInnerScanning(Rooms)
            ElseIf focusIsOn = 2 Then
                'TopOptions(focusIsOn).includeAllOptions = True
                'TopOptions(focusIsOn).StartInnerScanning(Windows)
                Me.WindowMenu.Visible = True
                Dim Options As SubOptions() = Me.WindowMenu.GetTaskBarOptions()
                ReDim Preserve Options(Options.Length)
                Options(Options.Length - 1) = Me.MainTaskBar.Back
                Me.WindowMenu.MenuBarOption.StartInnerScanning(Options)
            ElseIf focusIsOn = 3 Then
                TopOptions(focusIsOn).includeAllOptions = True
                TopOptions(focusIsOn).StartInnerScanning(Doors)
            ElseIf focusIsOn = 4 Then
                tempOption.LoseFocus()
                TopOptions(focusIsOn).StartInnerScanning(temperature)
            End If
        ElseIf focusIsOn = 2 Then
            If MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                Me.WindowMenu.MenuBarOption.StopInnerScanning()
                Me.WindowMenu.Visible = False
                scanninglevel = 0
            ElseIf Me.WindowMenu.CloseWindows.BackColor = Color.LemonChiffon Then
                Me.WindowMenu.CloseWindows.BorderStyle = BorderStyle.Fixed3D
                Me.WindowMenu.OpenWindows.BorderStyle = BorderStyle.None
            ElseIf Me.WindowMenu.OpenWindows.BackColor = Color.LemonChiffon Then
                Me.WindowMenu.OpenWindows.BorderStyle = BorderStyle.Fixed3D
                Me.WindowMenu.CloseWindows.BorderStyle = BorderStyle.None
            ElseIf Me.WindowMenu.CloseBlinds.BackColor = Color.LemonChiffon Then
                Me.WindowMenu.CloseBlinds.BorderStyle = BorderStyle.Fixed3D
                Me.WindowMenu.OpenBlinds.BorderStyle = BorderStyle.None
            ElseIf Me.WindowMenu.OpenBlinds.BackColor = Color.LemonChiffon Then
                Me.WindowMenu.OpenBlinds.BorderStyle = BorderStyle.Fixed3D
                Me.WindowMenu.CloseBlinds.BorderStyle = BorderStyle.None
            End If
        ElseIf scanninglevel = 1 Then
            If LivingRoom.BackColor = Color.LemonChiffon Then
                StopScanning()
                livingroomForm.Show()
                livingroomForm.StartScanning()
            ElseIf Bedroom.BackColor = Color.LemonChiffon Then
                StopScanning()
                bedroomForm.Show()
                bedroomForm.StartScanning()
            ElseIf Kitchen.BackColor = Color.LemonChiffon Then
                StopScanning()
                kitchenForm.Show()
                kitchenForm.StartScanning()
            ElseIf Bathroom.BackColor = Color.LemonChiffon Then
                StopScanning()
                bathroomForm.Show()
                bathroomForm.StartScanning()
            ElseIf MainTaskBar.Back.BackColor = Color.LemonChiffon Then
                If focusIsOn = 6 Then
                    MainTaskBar.MenuBarOption.StopInnerScanning()
                    scanninglevel = 0
                Else
                    TopOptions(focusIsOn).StopInnerScanning()
                    scanninglevel = 0
                End If
            ElseIf upArrow.BackColor = Color.LemonChiffon Then

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
            End If
        End If
    End Sub

    Private Sub UserApartment_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyParent.ResumeScanning()
    End Sub

#End Region

End Class