Public Class SubOptions

    Inherits PictureBox

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

#Region "Variables"

    Private innerOptions As Integer
    Private Options As SubOptions()
    Private activebutton As Integer
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


#End Region

End Class
