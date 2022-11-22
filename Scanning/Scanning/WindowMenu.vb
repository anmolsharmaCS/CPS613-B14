Public Class WindowMenu
    Private TaskBarOptions(3) As SubOptions

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TaskBarOptions(0) = Me.CloseWindows
        TaskBarOptions(1) = Me.OpenWindows
        TaskBarOptions(2) = Me.CloseBlinds
        TaskBarOptions(3) = Me.OpenBlinds
    End Sub

    Public Function GetTaskBarOptions()
        Return TaskBarOptions
    End Function
End Class
