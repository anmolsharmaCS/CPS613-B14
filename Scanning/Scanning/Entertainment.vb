Public Class Entertainment

    Private mediaOptions(5) As SubOptions
    Private musicOptions(8) As SubOptions
    Private programOptions(5)

    Private MyParent As UserApartment

    Public Sub New(parentForm)

        InitializeComponent()

        mediaOptions(0) = musicOption
        mediaOptions(1) = programOption
        mediaOptions(2) = movieOption
        mediaOptions(3) = tvOption
        mediaOptions(4) = volumeOption
        mediaOptions(5) = MainTaskBar.MenuBarOption

        For i = 0 To 5
            mediaOptions(i).Initialize()
        Next




        MyParent = parentForm

    End Sub

End Class