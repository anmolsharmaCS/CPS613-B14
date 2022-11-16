Public Class MainForm


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu.Initialize(SubMenu1, SubMenu2, SubMenu3)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopMenu.StartScanning()
    End Sub


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles help.Click, Button3.Click, ent.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click
        TopMenu.StopScanning()
        Dim b As Button = sender
        MsgBox(b.ToString() & " was selected")
        'TopMenu.ResumeScanning()

        If b.Name = "ent" Then

            Dim ent As Form1 = New Form1()
            ent.Show()

        ElseIf b.Name = "help" Then

            Dim assistance As Form2 = New Form2()
            assistance.Show()
        End If


        TopMenu.ResumeScanning()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TopMenu.StopScanning()
        Dim userApt As UserApartment = New UserApartment()
        userApt.Show()
    End Sub

End Class