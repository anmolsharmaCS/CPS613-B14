Public Class DeveloperConsole
    Private Sub DoorbellButton_Click(sender As Object, e As EventArgs) Handles DoorbellButton.Click
        Dim DoorbellMenuForm As New DoorbellMenu()
        DoorbellMenuForm.Show()
    End Sub
End Class