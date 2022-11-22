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

        ' Add any initialization after the Initial

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

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

        TopMenu1.Initialize(SubMenu8)
        TopMenu1.StartScanning()

        'Deselect the rest
        SubMenu6.Visible = False
        SubMenu6.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button53" Then
            TopMenu1.StopScanning()

            SubMenu8.Hide()
            TopMenu1.StartScanning()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim assistance As assistance = New assistance(Me)
        assistance.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        ' Play Music
        TopMenu1.StopScanning()


        TopMenu1.StartScanning()

        'Deselect the rest
        'Deselect the rest
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button51" Then
            TopMenu1.StopScanning()

            TopMenu1.StartScanning()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

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

        TopMenu1.Initialize(SubMenu6)
        TopMenu1.StartScanning()


        'Deselect the rest
        SubMenu8.Visible = False
        SubMenu8.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button52" Then
            TopMenu1.StopScanning()

            SubMenu6.Hide()
            TopMenu1.StartScanning()

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        ' Listen to program
        TopMenu1.StopScanning()
        TopMenu1.StartScanning()

        'Deselect the rest
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button50" Then
            TopMenu1.StopScanning()

            TopMenu1.StartScanning()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim home As MainForm = New MainForm()
        home.Show()
        Me.Hide()

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs)
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs)
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs)
        SendMessageW(Me.Handle, WM_APPCOMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

        TopMenu1.StopScanning()

        TopMenu1.StartScanning()

        'Deselect the rest
        SubMenu8.Visible = False
        SubMenu8.Enabled = False
        SubMenu6.Visible = False
        SubMenu6.Enabled = False

        Dim b As Button = sender
        If b.Name = "Button49" Then
            TopMenu1.StopScanning()
            TopMenu1.StartScanning()

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button20.Click, Button36.Click
        My.Computer.Audio.Play(My.Resources.canada, AudioPlayMode.Background)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button21.Click, Button37.Click
        My.Computer.Audio.Stop()
    End Sub


End Class