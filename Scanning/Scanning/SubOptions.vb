Public Class SubOptions

    Inherits PictureBox

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

#Region "Variables"

    Private Options As SubOptions()
    Private activeOption As Integer
    Private originalColor As Color

#End Region

#Region "Initialize"

    Public Sub Initialize()
        originalColor = BackColor
    End Sub

#End Region

#Region "Outer Scanning"

    ' You can customize the look and feel of the outer scanning in these routines

    Public Sub ReceiveFocus()
        BackColor = Color.LemonChiffon
    End Sub

    Public Sub LoseFocus()
        'TakeFocusFromButton(activebutton)
        BackColor = originalColor
    End Sub

#End Region

#Region "Inner Scanning"

    Public Sub StartInnerScanning(givenOptions As SubOptions())
        Options = givenOptions
        activeOption = 0
        For i = 1 To Options.Length - 1
            Options(i).BackColor = originalColor
        Next
        GiveFocusToButton(activeOption)
    End Sub

    Public Sub InnerScanningNext()
        TakeFocusFromButton(activeOption)
        activeOption = (activeOption + 1) Mod (Options.Length + 1)
        GiveFocusToButton(activeOption)
    End Sub

    ' You can customize the look and feel of the inner scanning in these two routines
    Private Sub TakeFocusFromButton(index As Integer)
        If index = 0 Then
            For i = 0 To Options.Length - 1
                Options(i).BackColor = originalColor
            Next
        Else
            Options(index - 1).BackColor = originalColor
        End If

    End Sub

    Private Sub GiveFocusToButton(index As Integer)
        If index = 0 Then
            For i = 0 To Options.Length - 1
                Options(i).BackColor = Color.LemonChiffon
            Next
        Else
            Options(index - 1).BackColor = Color.LemonChiffon
        End If
    End Sub

#End Region

End Class
