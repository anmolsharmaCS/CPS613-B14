Public Class WindowMenu
    Private TaskBarOptions(1) As SubOptions

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TaskBarOptions(0) = Me.windowControl
        TaskBarOptions(1) = Me.blindControl
    End Sub

    Public Function GetTaskBarOptions()
        Return TaskBarOptions
    End Function
End Class
