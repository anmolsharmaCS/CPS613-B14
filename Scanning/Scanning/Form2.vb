Imports System.ComponentModel
Imports System.Threading
Public Class Form2
    Private tp As TopMenu
    'tp = TopMenu1

    Private MyParentHall As FloorHallways
    Private MyParentApartment As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1)

        If parentForm.GetType() Is GetType(FloorHallways) Then
            MyParentHall = parentForm
        ElseIf parentForm.GetType() Is GetType(UserApartment) Then
            MyParentApartment = parentForm
        End If

    End Sub




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopMenu1.StartScanning()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Console.WriteLine(PictureBox1.Location.X)
        ' Console.WriteLine(PictureBox1.Location.Y)

        While (PictureBox2.Location.X < 250)
            PictureBox2.Location = New Point(PictureBox2.Location.X + 1, PictureBox2.Location.Y)
        End While

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        TopMenu1.StopScanning()


        SubMenu2.Enabled = True

        TopMenu1.Initialize(SubMenu2)
        TopMenu1.StartScanning()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click, Button20.Click, Button21.Click

        Timer1.Enabled = False
        Label1.Text = ""

        Timer1.Enabled = True

        Dim ThisMoment As Date
        ThisMoment = Now
        Label1.Text = "Your assistance should arrive at: (" & ThisMoment.Hour & "00:" & ThisMoment.Minute + 2 & ":00)"

        TopMenu1.StopScanning()

        TopMenu1.Initialize(SubMenu3)
        TopMenu1.StartScanning()

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click, Button25.Click
        TopMenu1.StopScanning()

        TopMenu1.Initialize(SubMenu1)
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Timer1.Enabled = False
        Label1.Text = ""

        Timer1.Enabled = True
        Dim ThisMoment As Date
        ThisMoment = Now
        Label1.Text = "Your assistance should arrive at: (" & ThisMoment.Hour & "00:" & ThisMoment.Minute + 2 & ":00)"


        TopMenu1.StopScanning()

        TopMenu1.Initialize(SubMenu3)
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Timer1.Enabled = False
        Label1.Text = ""
        PictureBox2.Location = New Point(15, 350)

        TopMenu1.StopScanning()

        TopMenu1.Initialize(SubMenu1)
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Label1.Text = ""
        PictureBox2.Location = New Point(15, 350)
        Timer1.Enabled = False
        Timer1.Enabled = True
        Dim ThisMoment As Date
        ThisMoment = Now
        Label1.Text = "Your assistance should arrive at: (" & ThisMoment.Hour & "00:" & ThisMoment.Minute + 2 & ":00)"

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim home As MainForm = New MainForm()
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MyParentHall IsNot Nothing Then
            MyParentHall.ResumeScanning()
        ElseIf MyParentApartment IsNot Nothing Then
            MyParentApartment.ResumeScanning()
        End If
    End Sub
End Class