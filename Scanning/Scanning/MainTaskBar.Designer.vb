<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainTaskBar
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitTaskBar = New Scanning.SubOptions()
        Me.PreviousScreen = New Scanning.SubOptions()
        Me.Navigate = New Scanning.SubOptions()
        Me.Assistance = New Scanning.SubOptions()
        Me.Communicate = New Scanning.SubOptions()
        Me.MenuBarOption = New Scanning.SubOptions()
        CType(Me.exitTaskBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Navigate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Assistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Communicate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitTaskBar
        '
        Me.exitTaskBar.BackColor = System.Drawing.Color.Red
        Me.exitTaskBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitTaskBar.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitTaskBar.Location = New System.Drawing.Point(444, 16)
        Me.exitTaskBar.Name = "exitTaskBar"
        Me.exitTaskBar.Size = New System.Drawing.Size(51, 45)
        Me.exitTaskBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitTaskBar.TabIndex = 47
        Me.exitTaskBar.TabStop = False
        Me.exitTaskBar.Visible = False
        '
        'PreviousScreen
        '
        Me.PreviousScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PreviousScreen.Image = Global.Scanning.My.Resources.Resources.back_button
        Me.PreviousScreen.Location = New System.Drawing.Point(20, 16)
        Me.PreviousScreen.Name = "PreviousScreen"
        Me.PreviousScreen.Size = New System.Drawing.Size(100, 100)
        Me.PreviousScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PreviousScreen.TabIndex = 6
        Me.PreviousScreen.TabStop = False
        '
        'Navigate
        '
        Me.Navigate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Navigate.Image = Global.Scanning.My.Resources.Resources.navigation
        Me.Navigate.Location = New System.Drawing.Point(338, 16)
        Me.Navigate.Name = "Navigate"
        Me.Navigate.Size = New System.Drawing.Size(100, 100)
        Me.Navigate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Navigate.TabIndex = 4
        Me.Navigate.TabStop = False
        '
        'Assistance
        '
        Me.Assistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Assistance.Image = Global.Scanning.My.Resources.Resources.assisstant
        Me.Assistance.Location = New System.Drawing.Point(126, 16)
        Me.Assistance.Name = "Assistance"
        Me.Assistance.Size = New System.Drawing.Size(100, 100)
        Me.Assistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Assistance.TabIndex = 3
        Me.Assistance.TabStop = False
        '
        'Communicate
        '
        Me.Communicate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Communicate.Image = Global.Scanning.My.Resources.Resources.communication
        Me.Communicate.Location = New System.Drawing.Point(232, 16)
        Me.Communicate.Name = "Communicate"
        Me.Communicate.Size = New System.Drawing.Size(100, 100)
        Me.Communicate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Communicate.TabIndex = 2
        Me.Communicate.TabStop = False
        '
        'MenuBarOption
        '
        Me.MenuBarOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuBarOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MenuBarOption.Location = New System.Drawing.Point(0, 0)
        Me.MenuBarOption.Name = "MenuBarOption"
        Me.MenuBarOption.Size = New System.Drawing.Size(501, 132)
        Me.MenuBarOption.TabIndex = 9
        Me.MenuBarOption.TabStop = False
        '
        'MainTaskBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.exitTaskBar)
        Me.Controls.Add(Me.PreviousScreen)
        Me.Controls.Add(Me.Navigate)
        Me.Controls.Add(Me.Assistance)
        Me.Controls.Add(Me.Communicate)
        Me.Controls.Add(Me.MenuBarOption)
        Me.Name = "MainTaskBar"
        Me.Size = New System.Drawing.Size(501, 132)
        CType(Me.exitTaskBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Navigate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Assistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Communicate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Communicate As SubOptions
    Friend WithEvents Assistance As SubOptions
    Friend WithEvents Navigate As SubOptions
    Friend WithEvents PreviousScreen As SubOptions
    Friend WithEvents MenuBarOption As SubOptions
    Friend WithEvents exitTaskBar As SubOptions
End Class
