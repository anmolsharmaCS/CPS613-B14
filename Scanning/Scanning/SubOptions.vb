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
    Public MenuBar As Boolean = False
    Public Sub StartInnerScanning(givenOptions As SubOptions())
        Options = givenOptions
        activeOption = 0
        If MenuBar Then
            For i = 0 To Options.Length - 1
                Options(i).BackColor = Options(i).originalColor
            Next
        Else
            For i = 1 To Options.Length - 1
                Options(i).BackColor = originalColor
            Next
        End If
        GiveFocusToButton(activeOption)
    End Sub

    Public Sub InnerScanningNext()
        TakeFocusFromButton(activeOption)
        If MenuBar Then
            activeOption = (activeOption + 1) Mod (Options.Length)
        Else
            activeOption = (activeOption + 1) Mod (Options.Length + 1)
        End If
        GiveFocusToButton(activeOption)
    End Sub

    ' You can customize the look and feel of the inner scanning in these two routines
    Private Sub TakeFocusFromButton(index As Integer)

        If MenuBar Then
            Options(index).BackColor = Options(index).originalColor
        Else
            If index = 0 Then
                For i = 0 To Options.Length - 1
                    Options(i).BackColor = originalColor
                Next
            Else
                Options(index - 1).BackColor = originalColor
            End If
        End If
    End Sub

    Private Sub GiveFocusToButton(index As Integer)

        If MenuBar Then
            Options(index).BackColor = Color.LemonChiffon
        Else
            If index = 0 Then
                For i = 0 To Options.Length - 1
                    Options(i).BackColor = Color.LemonChiffon
                Next
            Else
                Options(index - 1).BackColor = Color.LemonChiffon
            End If
        End If
    End Sub

    Public Sub StopInnerScanning()
        If MenuBar Then
            For i = 0 To Options.Length - 1
                Options(i).BackColor = Options(i).originalColor
            Next
        Else
            For i = 1 To Options.Length - 1
                Options(i).BackColor = originalColor
            Next
        End If
    End Sub

#End Region

End Class
