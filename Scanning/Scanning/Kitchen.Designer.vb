<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.kitchenbackground = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cooking = New Scanning.SubOptions()
        Me.kitchenDoor = New Scanning.SubOptions()
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.kitchenEnvironmentMenu = New Scanning.EnvironmentMenu()
        Me.vaccuumButton = New Scanning.SubOptions()
        Me.vaccuumOption = New Scanning.SubOptions()
        CType(Me.kitchenbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kitchenbackground
        '
        Me.kitchenbackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.kitchenbackground.Location = New System.Drawing.Point(13, 13)
        Me.kitchenbackground.Margin = New System.Windows.Forms.Padding(4)
        Me.kitchenbackground.Name = "kitchenbackground"
        Me.kitchenbackground.Size = New System.Drawing.Size(739, 512)
        Me.kitchenbackground.TabIndex = 1
        Me.kitchenbackground.TabStop = False
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'cooking
        '
        Me.cooking.BackColor = System.Drawing.SystemColors.Control
        Me.cooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cooking.Image = Global.Scanning.My.Resources.Resources.cooking
        Me.cooking.Location = New System.Drawing.Point(196, 127)
        Me.cooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cooking.Name = "cooking"
        Me.cooking.Size = New System.Drawing.Size(372, 267)
        Me.cooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cooking.TabIndex = 61
        Me.cooking.TabStop = False
        Me.cooking.Tag = ""
        '
        'kitchenDoor
        '
        Me.kitchenDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.kitchenDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kitchenDoor.Location = New System.Drawing.Point(748, 286)
        Me.kitchenDoor.Name = "kitchenDoor"
        Me.kitchenDoor.Size = New System.Drawing.Size(5, 123)
        Me.kitchenDoor.TabIndex = 60
        Me.kitchenDoor.TabStop = False
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(103, 532)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(650, 132)
        Me.MainTaskBar.TabIndex = 2
        '
        'kitchenEnvironmentMenu
        '
        Me.kitchenEnvironmentMenu.Location = New System.Drawing.Point(769, 13)
        Me.kitchenEnvironmentMenu.Name = "kitchenEnvironmentMenu"
        Me.kitchenEnvironmentMenu.Size = New System.Drawing.Size(255, 513)
        Me.kitchenEnvironmentMenu.TabIndex = 62
        '
        'vaccuumButton
        '
        Me.vaccuumButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumButton.Image = Global.Scanning.My.Resources.Resources.roomba
        Me.vaccuumButton.Location = New System.Drawing.Point(784, 545)
        Me.vaccuumButton.Name = "vaccuumButton"
        Me.vaccuumButton.Size = New System.Drawing.Size(112, 100)
        Me.vaccuumButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vaccuumButton.TabIndex = 75
        Me.vaccuumButton.TabStop = False
        '
        'vaccuumOption
        '
        Me.vaccuumOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.vaccuumOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumOption.Location = New System.Drawing.Point(769, 532)
        Me.vaccuumOption.Name = "vaccuumOption"
        Me.vaccuumOption.Size = New System.Drawing.Size(145, 131)
        Me.vaccuumOption.TabIndex = 74
        Me.vaccuumOption.TabStop = False
        '
        'Kitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.vaccuumButton)
        Me.Controls.Add(Me.vaccuumOption)
        Me.Controls.Add(Me.kitchenEnvironmentMenu)
        Me.Controls.Add(Me.cooking)
        Me.Controls.Add(Me.kitchenDoor)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.kitchenbackground)
        Me.KeyPreview = True
        Me.Name = "Kitchen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KitchenForm"
        CType(Me.kitchenbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents kitchenbackground As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents kitchenDoor As SubOptions
    Friend WithEvents cooking As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents kitchenEnvironmentMenu As EnvironmentMenu
    Friend WithEvents vaccuumButton As SubOptions
    Friend WithEvents vaccuumOption As SubOptions
End Class
