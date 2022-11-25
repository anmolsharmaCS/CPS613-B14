Public Class waiting

    Public MyParent As FloorHallways
    Public dotNumber = 0
    Public countDown = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ellipseTimer.Tick
        If countDown = 16 Then
            ellipseTimer.Enabled = False
            dot1.Hide()
            dot2.Hide()
            dot3.Hide()
            dotNumber = 0
            countDown = 0
            MyParent.doorbellOption.Image = My.Resources.enterFriendApartment
            MyParent.doorbellOption.Tag = "enter"
        ElseIf dotNumber = 0 Then
            dot1.Show()
        ElseIf dotNumber = 1 Then
            dot2.Show()
        ElseIf dotNumber = 2 Then
            dot3.Show()
        ElseIf dotNumber = 3 Then
            dot1.Hide()
            dot2.Hide()
            dot3.Hide()
        End If
        countDown = countDown + 1
        dotNumber = (dotNumber + 1) Mod 4
    End Sub

End Class
