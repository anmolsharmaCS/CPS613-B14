Public Class EnvironmentMenu

    Public envOptions(4) As SubOptions
    Public tempOptions(2) As SubOptions

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        envOptions(0) = lights
        envOptions(1) = temperature
        envOptions(2) = fan
        envOptions(3) = humidity
        envOptions(4) = exitEnvMenu

        tempOptions(0) = upArrow
        tempOptions(1) = downArrow
        tempOptions(2) = exitTemp

        exitEnvMenu.SetOriginalColor(Color.Red)
        exitTemp.SetOriginalColor(Color.Red)

    End Sub

    Public Function GetTaskBarOptions()
        Return envOptions
    End Function

    Public Function GetTempOptions()
        Return tempOptions
    End Function

    Public Sub ToggleTempMenu(showing As Boolean)
        tempOption.Visible = showing
        upArrow.Visible = showing
        downArrow.Visible = showing
        exitTemp.Visible = showing
    End Sub

End Class
