<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bedroom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.WindowMenu = New Scanning.WindowMenu()
        Me.bedroomEnvironmentMenu = New Scanning.EnvironmentMenu()
        Me.exitWindowSelection = New Scanning.SubOptions()
        Me.bedroomBlinds2 = New System.Windows.Forms.PictureBox()
        Me.bedroomBlinds1 = New System.Windows.Forms.PictureBox()
        Me.bedroomShutters2 = New System.Windows.Forms.PictureBox()
        Me.bedroomShutters1 = New System.Windows.Forms.PictureBox()
        Me.Bed = New Scanning.SubOptions()
        Me.BedroomWindow2 = New Scanning.SubOptions()
        Me.BedroomWindow1 = New Scanning.SubOptions()
        Me.BedroomDoor = New Scanning.SubOptions()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.vaccuumButton = New Scanning.SubOptions()
        Me.vaccuumOption = New Scanning.SubOptions()
        CType(Me.exitWindowSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomBlinds2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomBlinds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomShutters2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomShutters1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(122, 554)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(648, 132)
        Me.MainTaskBar.TabIndex = 54
        '
        'WindowMenu
        '
        Me.WindowMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WindowMenu.Location = New System.Drawing.Point(128, 201)
        Me.WindowMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.WindowMenu.Name = "WindowMenu"
        Me.WindowMenu.Size = New System.Drawing.Size(540, 183)
        Me.WindowMenu.TabIndex = 71
        Me.WindowMenu.Visible = False
        '
        'bedroomEnvironmentMenu
        '
        Me.bedroomEnvironmentMenu.Location = New System.Drawing.Point(777, 43)
        Me.bedroomEnvironmentMenu.Name = "bedroomEnvironmentMenu"
        Me.bedroomEnvironmentMenu.Size = New System.Drawing.Size(255, 513)
        Me.bedroomEnvironmentMenu.TabIndex = 73
        '
        'exitWindowSelection
        '
        Me.exitWindowSelection.BackColor = System.Drawing.Color.Red
        Me.exitWindowSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitWindowSelection.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitWindowSelection.Location = New System.Drawing.Point(699, 25)
        Me.exitWindowSelection.Name = "exitWindowSelection"
        Me.exitWindowSelection.Size = New System.Drawing.Size(45, 45)
        Me.exitWindowSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitWindowSelection.TabIndex = 80
        Me.exitWindowSelection.TabStop = False
        Me.exitWindowSelection.Visible = False
        '
        'bedroomBlinds2
        '
        Me.bedroomBlinds2.Image = Global.Scanning.My.Resources.Resources.blinds
        Me.bedroomBlinds2.Location = New System.Drawing.Point(495, 52)
        Me.bedroomBlinds2.Name = "bedroomBlinds2"
        Me.bedroomBlinds2.Size = New System.Drawing.Size(146, 39)
        Me.bedroomBlinds2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomBlinds2.TabIndex = 76
        Me.bedroomBlinds2.TabStop = False
        Me.bedroomBlinds2.Visible = False
        '
        'bedroomBlinds1
        '
        Me.bedroomBlinds1.Image = Global.Scanning.My.Resources.Resources.blinds
        Me.bedroomBlinds1.Location = New System.Drawing.Point(131, 52)
        Me.bedroomBlinds1.Name = "bedroomBlinds1"
        Me.bedroomBlinds1.Size = New System.Drawing.Size(146, 39)
        Me.bedroomBlinds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomBlinds1.TabIndex = 75
        Me.bedroomBlinds1.TabStop = False
        Me.bedroomBlinds1.Visible = False
        '
        'bedroomShutters2
        '
        Me.bedroomShutters2.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.bedroomShutters2.Location = New System.Drawing.Point(459, 9)
        Me.bedroomShutters2.Name = "bedroomShutters2"
        Me.bedroomShutters2.Size = New System.Drawing.Size(209, 28)
        Me.bedroomShutters2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomShutters2.TabIndex = 70
        Me.bedroomShutters2.TabStop = False
        '
        'bedroomShutters1
        '
        Me.bedroomShutters1.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.bedroomShutters1.Location = New System.Drawing.Point(93, 9)
        Me.bedroomShutters1.Name = "bedroomShutters1"
        Me.bedroomShutters1.Size = New System.Drawing.Size(214, 28)
        Me.bedroomShutters1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomShutters1.TabIndex = 69
        Me.bedroomShutters1.TabStop = False
        '
        'Bed
        '
        Me.Bed.BackColor = System.Drawing.SystemColors.Control
        Me.Bed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bed.Image = Global.Scanning.My.Resources.Resources.bedUp
        Me.Bed.Location = New System.Drawing.Point(249, 181)
        Me.Bed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bed.Name = "Bed"
        Me.Bed.Size = New System.Drawing.Size(283, 245)
        Me.Bed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bed.TabIndex = 51
        Me.Bed.TabStop = False
        Me.Bed.Tag = "up"
        '
        'BedroomWindow2
        '
        Me.BedroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow2.Location = New System.Drawing.Point(495, 37)
        Me.BedroomWindow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow2.Name = "BedroomWindow2"
        Me.BedroomWindow2.Size = New System.Drawing.Size(146, 16)
        Me.BedroomWindow2.TabIndex = 49
        Me.BedroomWindow2.TabStop = False
        Me.BedroomWindow2.Tag = ""
        '
        'BedroomWindow1
        '
        Me.BedroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow1.Location = New System.Drawing.Point(131, 37)
        Me.BedroomWindow1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow1.Name = "BedroomWindow1"
        Me.BedroomWindow1.Size = New System.Drawing.Size(146, 16)
        Me.BedroomWindow1.TabIndex = 48
        Me.BedroomWindow1.TabStop = False
        Me.BedroomWindow1.Tag = ""
        '
        'BedroomDoor
        '
        Me.BedroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BedroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomDoor.Location = New System.Drawing.Point(339, 543)
        Me.BedroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(113, 5)
        Me.BedroomDoor.TabIndex = 47
        Me.BedroomDoor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(31, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 504)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'vaccuumButton
        '
        Me.vaccuumButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumButton.Image = Global.Scanning.My.Resources.Resources.roomba
        Me.vaccuumButton.Location = New System.Drawing.Point(791, 568)
        Me.vaccuumButton.Name = "vaccuumButton"
        Me.vaccuumButton.Size = New System.Drawing.Size(112, 100)
        Me.vaccuumButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vaccuumButton.TabIndex = 82
        Me.vaccuumButton.TabStop = False
        '
        'vaccuumOption
        '
        Me.vaccuumOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.vaccuumOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumOption.Location = New System.Drawing.Point(776, 555)
        Me.vaccuumOption.Name = "vaccuumOption"
        Me.vaccuumOption.Size = New System.Drawing.Size(145, 131)
        Me.vaccuumOption.TabIndex = 81
        Me.vaccuumOption.TabStop = False
        '
        'Bedroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.vaccuumButton)
        Me.Controls.Add(Me.vaccuumOption)
        Me.Controls.Add(Me.exitWindowSelection)
        Me.Controls.Add(Me.bedroomBlinds2)
        Me.Controls.Add(Me.bedroomBlinds1)
        Me.Controls.Add(Me.bedroomEnvironmentMenu)
        Me.Controls.Add(Me.WindowMenu)
        Me.Controls.Add(Me.bedroomShutters2)
        Me.Controls.Add(Me.bedroomShutters1)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.Bed)
        Me.Controls.Add(Me.BedroomWindow2)
        Me.Controls.Add(Me.BedroomWindow1)
        Me.Controls.Add(Me.BedroomDoor)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bedroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bedroom"
        CType(Me.exitWindowSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomBlinds2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomBlinds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomShutters2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomShutters1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BedroomDoor As SubOptions
    Friend WithEvents BedroomWindow1 As SubOptions
    Friend WithEvents BedroomWindow2 As SubOptions
    Friend WithEvents Bed As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents bedroomShutters1 As PictureBox
    Friend WithEvents bedroomShutters2 As PictureBox
    Friend WithEvents WindowMenu As WindowMenu
    Friend WithEvents bedroomEnvironmentMenu As EnvironmentMenu
    Friend WithEvents bedroomBlinds1 As PictureBox
    Friend WithEvents bedroomBlinds2 As PictureBox
    Friend WithEvents exitWindowSelection As SubOptions
    Friend WithEvents vaccuumButton As SubOptions
    Friend WithEvents vaccuumOption As SubOptions
End Class
