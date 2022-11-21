Public Class MainTaskBar

    Private TaskBarOptions(4) As SubOptions
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        TaskBarOptions(0) = Back
        TaskBarOptions(1) = Assistance
        TaskBarOptions(2) = Communicate
        TaskBarOptions(3) = Navigate
        TaskBarOptions(4) = PreviousScreen
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function GetTaskBarOptions()
        Return TaskBarOptions
    End Function

End Class
