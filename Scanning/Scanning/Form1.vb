Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim assistance As Form2 = New Form2()
        assistance.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Play Music
        TopMenu1.StopScanning()

        SubMenu4.Visible = False
        SubMenu4.Enabled = False

        SubMenu2.Visible = True
        SubMenu2.Enabled = True

        Button8.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        Button13.Visible = True
        Button14.Visible = True
        Button15.Visible = True
        Button16.Visible = True

        TopMenu1.Initialize(SubMenu2)
        TopMenu1.StartScanning()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Watch show
        TopMenu1.StopScanning()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Listen to program
        TopMenu1.StopScanning()

        SubMenu2.Visible = False
        SubMenu2.Enabled = False

        SubMenu4.Visible = True
        SubMenu4.Enabled = True

        Button24.Visible = True
        Button25.Visible = True
        Button26.Visible = True
        Button27.Visible = True
        Button28.Visible = True
        Button29.Visible = True
        Button30.Visible = True

        TopMenu1.Initialize(SubMenu4)
        TopMenu1.StartScanning()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim home As MainForm = New MainForm()
        home.Show()
        Me.Hide()

    End Sub
End Class