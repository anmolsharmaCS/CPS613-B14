Public Class Form2
    Private tp As TopMenu
    'tp = TopMenu1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1, SubMenu2)
        Dim num As Integer = Me.Controls.Count
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
End Class