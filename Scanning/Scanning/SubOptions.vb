Imports System.Reflection

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

    Public Sub SetOriginalColor(newColor As Color)
        originalColor = newColor
    End Sub

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
    Public includeAllOptions As Boolean = False
    Public Sub StartInnerScanning(givenOptions As SubOptions())
        Options = givenOptions
        activeOption = 0
        If includeAllOptions Then
            For i = 1 To Options.Length - 1
                Options(i).BackColor = Options(i).originalColor
            Next

        Else
            For i = 0 To Options.Length - 1
                Options(i).BackColor = Options(i).originalColor
            Next
        End If
        GiveFocusToButton(activeOption)
    End Sub

    Public Sub InnerScanningNext()
        TakeFocusFromButton(activeOption)
        If includeAllOptions Then
            activeOption = (activeOption + 1) Mod (Options.Length + 1)
        Else
            activeOption = (activeOption + 1) Mod (Options.Length)
        End If
        GiveFocusToButton(activeOption)
    End Sub

    ' You can customize the look and feel of the inner scanning in these two routines
    Private Sub TakeFocusFromButton(index As Integer)

        If includeAllOptions Then
            If index = 0 Then
                For i = 0 To Options.Length - 1
                    Options(i).BackColor = Options(i).originalColor
                Next
            Else
                Options(index - 1).BackColor = Options(index - 1).originalColor
            End If
        Else
            Options(index).BackColor = Options(index).originalColor
        End If
    End Sub

    Private Sub GiveFocusToButton(index As Integer)

        If includeAllOptions Then
            If index = 0 Then
                For i = 0 To Options.Length - 2
                    Options(i).BackColor = Color.LemonChiffon
                Next
            Else
                Options(index - 1).BackColor = Color.LemonChiffon
            End If
        Else
            Options(index).BackColor = Color.LemonChiffon
        End If
    End Sub

    Public Sub StopInnerScanning()
        If includeAllOptions Then
            For i = 1 To Options.Length - 1
                Options(i).BackColor = Options(i).originalColor
            Next
        Else
            For i = 0 To Options.Length - 1
                Options(i).BackColor = Options(i).originalColor
            Next
        End If
    End Sub

#End Region

End Class
