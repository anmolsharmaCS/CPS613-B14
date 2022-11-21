Imports System.Runtime.InteropServices

Public Class entertainmentSystem

    Private Const APPCOMMAND_VOLUME_MUTE = &H80000
    Private Const APPCOMMAND_VOLUME_UP = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN = &H90000
    Private Const WM_APPCOMAND = &H319
    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hwnd As IntPtr, ByVal mag As Integer, ByVal y As IntPtr, ByVal x As Integer) As Long
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1, SubMenu3)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button53.Click

        TopMenu1.StopScanning()

        SubMenu8.Visible = True
        SubMenu8.Enabled = True

        Button17.Visible = True
        Button18.Visible = True
        Button19.Visible = True
        Button20.Visible = True
        Button21.Visible = True
        Button22.Visible = True
        Button23.Visible = True
        Button31.Visible = True
        Button32.Visible = True
        Button33.Visible = True
        Button53.Visible = True

        TopMenu1.Initialize(SubMenu8)
        TopMenu1.StartScanning()

        'Deselect the rest
        SubMenu2.Visible = False
        SubMenu2.Enabled = False
        SubMenu4.Visible = False
        SubMenu4.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False
        SubMenu7.Visible = False
        SubMenu7.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button53" Then
            TopMenu1.StopScanning()

            SubMenu8.Hide()
            TopMenu1.Initialize(SubMenu1, SubMenu3)
            TopMenu1.StartScanning()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim assistance As assistance = New assistance(Me)
        assistance.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button51.Click

        ' Play Music
        TopMenu1.StopScanning()

        SubMenu2.BringToFront()

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
        Button51.Visible = True

        TopMenu1.Initialize(SubMenu2)
        TopMenu1.StartScanning()

        'Deselect the rest
        'Deselect the rest
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False
        SubMenu4.Visible = False
        SubMenu4.Enabled = False
        SubMenu7.Visible = False
        SubMenu7.Enabled = False

        SubMenu4.Hide()
        SubMenu4.SendToBack()

        Dim b As Button = sender
        If b.Name = "Button51" Then
            TopMenu1.StopScanning()

            SubMenu2.Hide()
            TopMenu1.Initialize(SubMenu1, SubMenu3)
            TopMenu1.StartScanning()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button52.Click

        ' Watch show
        TopMenu1.StopScanning()

        SubMenu6.Visible = True
        SubMenu6.Enabled = True

        'Button33.Visible = True
        'Button34.Visible = True
        Button35.Visible = True
        Button36.Visible = True
        Button37.Visible = True
        Button38.Visible = True
        Button39.Visible = True
        Button40.Visible = True
        Button41.Visible = True
        Button42.Visible = True
        Button43.Visible = True
        Button44.Visible = True
        Button52.Visible = True

        TopMenu1.Initialize(SubMenu6)
        TopMenu1.StartScanning()


        'Deselect the rest
        SubMenu2.Visible = False
        SubMenu2.Enabled = False
        SubMenu4.Visible = False
        SubMenu4.Enabled = False
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu7.Visible = False
        SubMenu7.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button52" Then
            TopMenu1.StopScanning()

            SubMenu6.Hide()
            TopMenu1.Initialize(SubMenu1, SubMenu3)
            TopMenu1.StartScanning()

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click, Button50.Click
        ' Listen to program
        TopMenu1.StopScanning()


        SubMenu2.Hide()
        SubMenu2.SendToBack()
        SubMenu4.BringToFront()

        SubMenu4.Visible = True
        SubMenu4.Enabled = True

        Button24.Visible = True
        Button25.Visible = True
        Button26.Visible = True
        Button27.Visible = True
        Button28.Visible = True
        Button29.Visible = True
        Button30.Visible = True
        Button50.Visible = True

        TopMenu1.Initialize(SubMenu4)
        TopMenu1.StartScanning()

        'Deselect the rest
        SubMenu2.Visible = False
        SubMenu2.Enabled = False
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False
        SubMenu7.Visible = False
        SubMenu7.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button50" Then
            TopMenu1.StopScanning()

            SubMenu4.Hide()
            TopMenu1.Initialize(SubMenu1, SubMenu3)
            TopMenu1.StartScanning()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim home As MainForm = New MainForm()
        home.Show()
        Me.Hide()

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button49.Click
        SubMenu7.Visible = True
        SubMenu7.Enabled = True

        Button45.Visible = True
        Button46.Visible = True
        Button47.Visible = True
        Button49.Visible = True

        TopMenu1.StopScanning()

        TopMenu1.Initialize(SubMenu7)
        TopMenu1.StartScanning()

        'Deselect the rest
        SubMenu2.Visible = False
        SubMenu2.Enabled = False
        SubMenu4.Visible = False
        SubMenu4.Enabled = False
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button49" Then
            TopMenu1.StopScanning()

            SubMenu7.Hide()
            TopMenu1.Initialize(SubMenu1, SubMenu3)
            TopMenu1.StartScanning()

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click, Button29.Click, Button20.Click, Button36.Click
        My.Computer.Audio.Play(My.Resources.canada, AudioPlayMode.Background)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click, Button28.Click, Button21.Click, Button37.Click
        My.Computer.Audio.Stop()
    End Sub


End Class