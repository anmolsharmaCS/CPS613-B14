Imports System.ComponentModel
Imports System.Reflection.Emit
Imports System.Threading
Public Class Assistance
    Private Options(7) As SubOptions

    Private MyParentHall As FloorHallways
    Private MyParentApartment As UserApartment
    Private MyParentBedroom As Bedroom
    Private MyParentBathroom As Bathroom
    Private MyParentKitchen As Kitchen
    Private MyParentLivingroom As Livingroom
    Private MyParentEnt As Entertainment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Options(0) = MakeCall
        Options(1) = MakeUrgentCall
        Options(2) = CloseWindow
        'Options(3) = TransferHelp
        Options(3) = BathroomHelp
        Options(4) = BedroomHelp
        Options(5) = ReturnToUrgency
        Options(6) = CancelCall
        Options(7) = CallAgain

        For i = 0 To 7
            Options(i).Initialize()
        Next

        ReasonMenu_Inactive()
        CallMenu_Inactive()



        If parentForm.GetType() Is GetType(FloorHallways) Then
            MyParentHall = parentForm
        ElseIf parentForm.GetType() Is GetType(UserApartment) Then
            MyParentApartment = parentForm
        ElseIf parentForm.GetType() Is GetType(Bedroom) Then
            MyParentBedroom = parentForm
        ElseIf parentForm.GetType() Is GetType(Bathroom) Then
            MyParentBathroom = parentForm
        ElseIf parentForm.GetType() Is GetType(Kitchen) Then
            MyParentKitchen = parentForm
        ElseIf parentForm.GetType() Is GetType(Livingroom) Then
            MyParentLivingroom = parentForm
        ElseIf parentForm.GetType() Is GetType(Entertainment) Then
            MyParentEnt = parentForm
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
    Private topSelection As Integer

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
            focusIsOn = ((focusIsOn - 2) Mod 4) + 3
            Options(focusIsOn).ReceiveFocus()
        ElseIf scanninglevel = 2 Then
            If Timer1Seconds < 60 Then
                focusIsOn = 7
                Options(focusIsOn).ReceiveFocus()
            Else
                Options(focusIsOn).LoseFocus()
                focusIsOn = ((focusIsOn - 6) Mod 2) + 7
                Options(focusIsOn).ReceiveFocus()
            End If
        End If

    End Sub

#End Region

#Region "Menu Appearances"

    Private Sub ReasonMenu_Active()
        ReasonMenu.BackColor = SystemColors.GradientActiveCaption
        'TransferHelp.BackColor = SystemColors.Control
        BathroomHelp.BackColor = SystemColors.Control
        BedroomHelp.BackColor = SystemColors.Control
        ReturnToUrgency.BackColor = SystemColors.Control

        'TransferHelp.SetOriginalColor(SystemColors.Control)
        BathroomHelp.SetOriginalColor(SystemColors.Control)
        BedroomHelp.SetOriginalColor(SystemColors.Control)
        ReturnToUrgency.SetOriginalColor(SystemColors.Control)
    End Sub

    Private Sub ReasonMenu_Inactive()
        ReasonMenu.BackColor = SystemColors.ControlDarkDark
        'TransferHelp.BackColor = SystemColors.ButtonShadow
        BathroomHelp.BackColor = SystemColors.ButtonShadow
        BedroomHelp.BackColor = SystemColors.ButtonShadow
        ReturnToUrgency.BackColor = SystemColors.ButtonShadow

        'TransferHelp.SetOriginalColor(SystemColors.ButtonShadow)
        BathroomHelp.SetOriginalColor(SystemColors.ButtonShadow)
        BedroomHelp.SetOriginalColor(SystemColors.ButtonShadow)
        ReturnToUrgency.SetOriginalColor(SystemColors.ButtonShadow)
    End Sub

    Private Sub CallMenu_Active()
        CallMenu.BackColor = SystemColors.GradientActiveCaption
        CancelCall.BackColor = SystemColors.Control
        CallAgain.BackColor = SystemColors.ButtonShadow

        CancelCall.SetOriginalColor(SystemColors.Control)
        CallAgain.SetOriginalColor(SystemColors.Control)
    End Sub

    Private Sub CallMenu_Inactive()
        CallMenu.BackColor = SystemColors.ControlDarkDark
        CancelCall.BackColor = SystemColors.ButtonShadow
        CallAgain.BackColor = SystemColors.ButtonShadow

        CancelCall.SetOriginalColor(SystemColors.ButtonShadow)
        CallAgain.SetOriginalColor(SystemColors.ButtonShadow)
    End Sub

#End Region

#Region "Other events"

    Private Timer1Seconds As Integer

    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If scanninglevel = 0 Then
            scanninglevel = 1
            If focusIsOn = 0 Or focusIsOn = 1 Then
                ReasonMenu_Active()
                topSelection = focusIsOn
                focusIsOn = 2
            ElseIf focusIsOn = 2 Then
                Me.Close()
            End If
        ElseIf scanninglevel = 1 Then
            scanninglevel = 2
            If focusIsOn = 3 Or focusIsOn = 4 Then
                CallMenu_Active()
                focusIsOn = 5
                TimerStart()
            ElseIf focusIsOn = 5 Then
                Options(topSelection).LoseFocus()
                ReasonMenu_Inactive()
                focusIsOn = 7
                scanninglevel = 0
            End If
        ElseIf scanninglevel = 2 Then
            If focusIsOn = 6 Then
                Timer1.Enabled = False
                TimerLabel.Hide()
                scanninglevel = 0
                focusIsOn = 7
                Options(topSelection).LoseFocus()
                ReasonMenu_Inactive()
                CallMenu_Inactive()
            ElseIf focusIsOn = 7 Then
                CallAgain.BackColor = SystemColors.ButtonShadow
                TimerStart()
            End If

        End If

    End Sub
    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MyParentHall IsNot Nothing Then
            MyParentHall.ResumeScanning()
        ElseIf MyParentApartment IsNot Nothing Then
            MyParentApartment.ResumeScanning()
        ElseIf MyParentBedroom IsNot Nothing Then
            MyParentBedroom.ResumeScanning()
        ElseIf MyParentBathroom IsNot Nothing Then
            MyParentBathroom.ResumeScanning()
        ElseIf MyParentKitchen IsNot Nothing Then
            MyParentKitchen.ResumeScanning()
        ElseIf MyParentLivingroom IsNot Nothing Then
            MyParentLivingroom.ResumeScanning()
        ElseIf MyParentEnt IsNot Nothing Then
            MyParentEnt.ResumeScanning()
        End If
    End Sub

    Private Sub TimerStart()
        Timer1Seconds = 0
        Timer1.Enabled = True
        TimerLabel.Show()
        Dim ThisMoment As Date = Now
        TimerLabel.Text = 60
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Start()
        Timer1.Interval = 1000

        If TimerLabel.Text = "0" Then
            TimerLabel.Text = "0  min"
            Timer1.Enabled = False
            Label1.Visible = False
            CallAgain.BackColor = SystemColors.Control
        Else
            TimerLabel.ForeColor = Color.Blue
            TimerLabel.Text = Val(TimerLabel.Text) - 1
            Label1.Visible = True
            Label1.ForeColor = Color.Blue
        End If


        Timer1Seconds = Timer1Seconds + 1

        ' If Timer1Seconds Mod 2 = 0 Then
        'TimerLabel.ForeColor = Color.Black
        ' Else
        'TimerLabel.ForeColor = Color.Blue
        '  End If

        ' If Timer1Seconds = 60 Then
        'CallAgain.BackColor = SystemColors.Control
        'TimerLabel.Text = "0  min"
        'End If

    End Sub


#End Region

End Class
