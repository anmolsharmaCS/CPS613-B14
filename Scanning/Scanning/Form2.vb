Imports System.ComponentModel

Public Class Form2
    Private tp As TopMenu
    'tp = TopMenu1

    Private MyParentHall As FloorHallways
    Private MyParentApartment As UserApartment

    Public Sub New(parentForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1, SubMenu2)
        Dim num As Integer = Me.Controls.Count

        If parentForm.GetType() Is GetType(FloorHallways) Then
            MyParentHall = parentForm
        ElseIf parentForm.GetType() Is GetType(UserApartment) Then
            MyParentApartment = parentForm
        End If

    End Sub


    Private Sub button_click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click
        TopMenu1.StopScanning()
        Dim b As Button = sender
        MsgBox(b.ToString() & " was selected")

        TopMenu1.ResumeScanning()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
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