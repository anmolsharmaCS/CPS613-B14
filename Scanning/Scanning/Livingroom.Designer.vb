<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Livingroom
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
        Me.livingroomBackground = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.livingroomShutters2 = New System.Windows.Forms.PictureBox()
        Me.livingroomShutters1 = New System.Windows.Forms.PictureBox()
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.LivingroomDoor = New Scanning.SubOptions()
        Me.LivingroomWindow2 = New Scanning.SubOptions()
        Me.LivingroomWindow1 = New Scanning.SubOptions()
        Me.entSystem = New Scanning.SubOptions()
        Me.WindowMenu = New Scanning.WindowMenu()
        Me.livingroomEnvironmentMenu = New Scanning.EnvironmentMenu()
        Me.livingroomBlinds2Half = New System.Windows.Forms.PictureBox()
        Me.livingroomBlinds1Half = New System.Windows.Forms.PictureBox()
        Me.exitWindowSelection = New Scanning.SubOptions()
        Me.vaccuumButton = New Scanning.SubOptions()
        Me.vaccuumOption = New Scanning.SubOptions()
        Me.livingroomBlinds1Closed = New System.Windows.Forms.PictureBox()
        Me.livingroomBlinds1OpenSlats = New System.Windows.Forms.PictureBox()
        Me.livingroomBlinds2Closed = New System.Windows.Forms.PictureBox()
        Me.livingroomBlinds2OpenSlats = New System.Windows.Forms.PictureBox()
        Me.livingroomWindow1Half = New System.Windows.Forms.PictureBox()
        Me.livingroomWindow2Half = New System.Windows.Forms.PictureBox()
        Me.livingroomWindow1Slightly = New System.Windows.Forms.PictureBox()
        Me.livingroomWindow2Slightly = New System.Windows.Forms.PictureBox()
        CType(Me.livingroomBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomShutters2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomShutters1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds2Half, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds1Half, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitWindowSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds1Closed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds1OpenSlats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds2Closed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds2OpenSlats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomWindow1Half, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomWindow2Half, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomWindow1Slightly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomWindow2Slightly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'livingroomBackground
        '
        Me.livingroomBackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.livingroomBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.livingroomBackground.Location = New System.Drawing.Point(36, 52)
        Me.livingroomBackground.Margin = New System.Windows.Forms.Padding(4)
        Me.livingroomBackground.Name = "livingroomBackground"
        Me.livingroomBackground.Size = New System.Drawing.Size(686, 513)
        Me.livingroomBackground.TabIndex = 1
        Me.livingroomBackground.TabStop = False
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'livingroomShutters2
        '
        Me.livingroomShutters2.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.livingroomShutters2.Location = New System.Drawing.Point(390, 20)
        Me.livingroomShutters2.Name = "livingroomShutters2"
        Me.livingroomShutters2.Size = New System.Drawing.Size(256, 28)
        Me.livingroomShutters2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomShutters2.TabIndex = 70
        Me.livingroomShutters2.TabStop = False
        Me.livingroomShutters2.Visible = False
        '
        'livingroomShutters1
        '
        Me.livingroomShutters1.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.livingroomShutters1.Location = New System.Drawing.Point(67, 20)
        Me.livingroomShutters1.Name = "livingroomShutters1"
        Me.livingroomShutters1.Size = New System.Drawing.Size(214, 28)
        Me.livingroomShutters1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomShutters1.TabIndex = 71
        Me.livingroomShutters1.TabStop = False
        Me.livingroomShutters1.Visible = False
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(75, 572)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(649, 132)
        Me.MainTaskBar.TabIndex = 73
        '
        'LivingroomDoor
        '
        Me.LivingroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LivingroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomDoor.Location = New System.Drawing.Point(719, 328)
        Me.LivingroomDoor.Name = "LivingroomDoor"
        Me.LivingroomDoor.Size = New System.Drawing.Size(5, 123)
        Me.LivingroomDoor.TabIndex = 59
        Me.LivingroomDoor.TabStop = False
        '
        'LivingroomWindow2
        '
        Me.LivingroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow2.Location = New System.Drawing.Point(435, 47)
        Me.LivingroomWindow2.Name = "LivingroomWindow2"
        Me.LivingroomWindow2.Size = New System.Drawing.Size(178, 15)
        Me.LivingroomWindow2.TabIndex = 58
        Me.LivingroomWindow2.TabStop = False
        Me.LivingroomWindow2.Tag = ""
        '
        'LivingroomWindow1
        '
        Me.LivingroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow1.Location = New System.Drawing.Point(88, 47)
        Me.LivingroomWindow1.Name = "LivingroomWindow1"
        Me.LivingroomWindow1.Size = New System.Drawing.Size(178, 15)
        Me.LivingroomWindow1.TabIndex = 57
        Me.LivingroomWindow1.TabStop = False
        Me.LivingroomWindow1.Tag = ""
        '
        'entSystem
        '
        Me.entSystem.BackColor = System.Drawing.SystemColors.Control
        Me.entSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.entSystem.Image = Global.Scanning.My.Resources.Resources.television
        Me.entSystem.Location = New System.Drawing.Point(190, 178)
        Me.entSystem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.entSystem.Name = "entSystem"
        Me.entSystem.Size = New System.Drawing.Size(372, 267)
        Me.entSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.entSystem.TabIndex = 54
        Me.entSystem.TabStop = False
        Me.entSystem.Tag = ""
        '
        'WindowMenu
        '
        Me.WindowMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WindowMenu.Location = New System.Drawing.Point(106, 218)
        Me.WindowMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.WindowMenu.Name = "WindowMenu"
        Me.WindowMenu.Size = New System.Drawing.Size(540, 183)
        Me.WindowMenu.TabIndex = 75
        Me.WindowMenu.Visible = False
        '
        'livingroomEnvironmentMenu
        '
        Me.livingroomEnvironmentMenu.Location = New System.Drawing.Point(730, 52)
        Me.livingroomEnvironmentMenu.Name = "livingroomEnvironmentMenu"
        Me.livingroomEnvironmentMenu.Size = New System.Drawing.Size(255, 513)
        Me.livingroomEnvironmentMenu.TabIndex = 76
        '
        'livingroomBlinds2Half
        '
        Me.livingroomBlinds2Half.Image = Global.Scanning.My.Resources.Resources.blinds
        Me.livingroomBlinds2Half.Location = New System.Drawing.Point(435, 61)
        Me.livingroomBlinds2Half.Name = "livingroomBlinds2Half"
        Me.livingroomBlinds2Half.Size = New System.Drawing.Size(178, 52)
        Me.livingroomBlinds2Half.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds2Half.TabIndex = 77
        Me.livingroomBlinds2Half.TabStop = False
        Me.livingroomBlinds2Half.Visible = False
        '
        'livingroomBlinds1Half
        '
        Me.livingroomBlinds1Half.Image = Global.Scanning.My.Resources.Resources.blinds
        Me.livingroomBlinds1Half.Location = New System.Drawing.Point(88, 61)
        Me.livingroomBlinds1Half.Name = "livingroomBlinds1Half"
        Me.livingroomBlinds1Half.Size = New System.Drawing.Size(178, 52)
        Me.livingroomBlinds1Half.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds1Half.TabIndex = 78
        Me.livingroomBlinds1Half.TabStop = False
        Me.livingroomBlinds1Half.Visible = False
        '
        'exitWindowSelection
        '
        Me.exitWindowSelection.BackColor = System.Drawing.Color.Red
        Me.exitWindowSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitWindowSelection.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitWindowSelection.Location = New System.Drawing.Point(671, 33)
        Me.exitWindowSelection.Name = "exitWindowSelection"
        Me.exitWindowSelection.Size = New System.Drawing.Size(45, 45)
        Me.exitWindowSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitWindowSelection.TabIndex = 79
        Me.exitWindowSelection.TabStop = False
        Me.exitWindowSelection.Visible = False
        '
        'vaccuumButton
        '
        Me.vaccuumButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumButton.Image = Global.Scanning.My.Resources.Resources.roomba
        Me.vaccuumButton.Location = New System.Drawing.Point(745, 584)
        Me.vaccuumButton.Name = "vaccuumButton"
        Me.vaccuumButton.Size = New System.Drawing.Size(112, 100)
        Me.vaccuumButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vaccuumButton.TabIndex = 81
        Me.vaccuumButton.TabStop = False
        '
        'vaccuumOption
        '
        Me.vaccuumOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.vaccuumOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumOption.Location = New System.Drawing.Point(730, 571)
        Me.vaccuumOption.Name = "vaccuumOption"
        Me.vaccuumOption.Size = New System.Drawing.Size(145, 131)
        Me.vaccuumOption.TabIndex = 80
        Me.vaccuumOption.TabStop = False
        '
        'livingroomBlinds1Closed
        '
        Me.livingroomBlinds1Closed.Image = Global.Scanning.My.Resources.Resources.blindsClosedApt
        Me.livingroomBlinds1Closed.Location = New System.Drawing.Point(88, 61)
        Me.livingroomBlinds1Closed.Name = "livingroomBlinds1Closed"
        Me.livingroomBlinds1Closed.Size = New System.Drawing.Size(178, 99)
        Me.livingroomBlinds1Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds1Closed.TabIndex = 82
        Me.livingroomBlinds1Closed.TabStop = False
        Me.livingroomBlinds1Closed.Visible = False
        '
        'livingroomBlinds1OpenSlats
        '
        Me.livingroomBlinds1OpenSlats.BackColor = System.Drawing.SystemColors.ControlDark
        Me.livingroomBlinds1OpenSlats.Image = Global.Scanning.My.Resources.Resources.openSlatsApt
        Me.livingroomBlinds1OpenSlats.Location = New System.Drawing.Point(88, 61)
        Me.livingroomBlinds1OpenSlats.Name = "livingroomBlinds1OpenSlats"
        Me.livingroomBlinds1OpenSlats.Size = New System.Drawing.Size(178, 99)
        Me.livingroomBlinds1OpenSlats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds1OpenSlats.TabIndex = 83
        Me.livingroomBlinds1OpenSlats.TabStop = False
        Me.livingroomBlinds1OpenSlats.Visible = False
        '
        'livingroomBlinds2Closed
        '
        Me.livingroomBlinds2Closed.Image = Global.Scanning.My.Resources.Resources.blindsClosedApt
        Me.livingroomBlinds2Closed.Location = New System.Drawing.Point(435, 61)
        Me.livingroomBlinds2Closed.Name = "livingroomBlinds2Closed"
        Me.livingroomBlinds2Closed.Size = New System.Drawing.Size(178, 99)
        Me.livingroomBlinds2Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds2Closed.TabIndex = 85
        Me.livingroomBlinds2Closed.TabStop = False
        Me.livingroomBlinds2Closed.Visible = False
        '
        'livingroomBlinds2OpenSlats
        '
        Me.livingroomBlinds2OpenSlats.BackColor = System.Drawing.SystemColors.ControlDark
        Me.livingroomBlinds2OpenSlats.Image = Global.Scanning.My.Resources.Resources.openSlatsApt
        Me.livingroomBlinds2OpenSlats.Location = New System.Drawing.Point(435, 61)
        Me.livingroomBlinds2OpenSlats.Name = "livingroomBlinds2OpenSlats"
        Me.livingroomBlinds2OpenSlats.Size = New System.Drawing.Size(178, 99)
        Me.livingroomBlinds2OpenSlats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds2OpenSlats.TabIndex = 86
        Me.livingroomBlinds2OpenSlats.TabStop = False
        Me.livingroomBlinds2OpenSlats.Visible = False
        '
        'livingroomWindow1Half
        '
        Me.livingroomWindow1Half.Image = Global.Scanning.My.Resources.Resources.openwindowhalf
        Me.livingroomWindow1Half.Location = New System.Drawing.Point(67, -46)
        Me.livingroomWindow1Half.Name = "livingroomWindow1Half"
        Me.livingroomWindow1Half.Size = New System.Drawing.Size(214, 94)
        Me.livingroomWindow1Half.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomWindow1Half.TabIndex = 87
        Me.livingroomWindow1Half.TabStop = False
        Me.livingroomWindow1Half.Visible = False
        '
        'livingroomWindow2Half
        '
        Me.livingroomWindow2Half.Image = Global.Scanning.My.Resources.Resources.openwindowhalf
        Me.livingroomWindow2Half.Location = New System.Drawing.Point(412, -46)
        Me.livingroomWindow2Half.Name = "livingroomWindow2Half"
        Me.livingroomWindow2Half.Size = New System.Drawing.Size(214, 94)
        Me.livingroomWindow2Half.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomWindow2Half.TabIndex = 88
        Me.livingroomWindow2Half.TabStop = False
        Me.livingroomWindow2Half.Visible = False
        '
        'livingroomWindow1Slightly
        '
        Me.livingroomWindow1Slightly.Image = Global.Scanning.My.Resources.Resources.openwindowslightly
        Me.livingroomWindow1Slightly.Location = New System.Drawing.Point(67, -46)
        Me.livingroomWindow1Slightly.Name = "livingroomWindow1Slightly"
        Me.livingroomWindow1Slightly.Size = New System.Drawing.Size(214, 94)
        Me.livingroomWindow1Slightly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomWindow1Slightly.TabIndex = 89
        Me.livingroomWindow1Slightly.TabStop = False
        Me.livingroomWindow1Slightly.Visible = False
        '
        'livingroomWindow2Slightly
        '
        Me.livingroomWindow2Slightly.Image = Global.Scanning.My.Resources.Resources.openwindowslightly
        Me.livingroomWindow2Slightly.Location = New System.Drawing.Point(412, -46)
        Me.livingroomWindow2Slightly.Name = "livingroomWindow2Slightly"
        Me.livingroomWindow2Slightly.Size = New System.Drawing.Size(214, 94)
        Me.livingroomWindow2Slightly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomWindow2Slightly.TabIndex = 90
        Me.livingroomWindow2Slightly.TabStop = False
        Me.livingroomWindow2Slightly.Visible = False
        '
        'Livingroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.livingroomWindow2Slightly)
        Me.Controls.Add(Me.livingroomWindow1Slightly)
        Me.Controls.Add(Me.livingroomWindow2Half)
        Me.Controls.Add(Me.livingroomWindow1Half)
        Me.Controls.Add(Me.livingroomBlinds2OpenSlats)
        Me.Controls.Add(Me.livingroomBlinds2Closed)
        Me.Controls.Add(Me.livingroomBlinds1OpenSlats)
        Me.Controls.Add(Me.livingroomBlinds1Closed)
        Me.Controls.Add(Me.vaccuumButton)
        Me.Controls.Add(Me.vaccuumOption)
        Me.Controls.Add(Me.exitWindowSelection)
        Me.Controls.Add(Me.livingroomBlinds1Half)
        Me.Controls.Add(Me.livingroomBlinds2Half)
        Me.Controls.Add(Me.livingroomEnvironmentMenu)
        Me.Controls.Add(Me.WindowMenu)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.livingroomShutters1)
        Me.Controls.Add(Me.livingroomShutters2)
        Me.Controls.Add(Me.LivingroomDoor)
        Me.Controls.Add(Me.LivingroomWindow2)
        Me.Controls.Add(Me.LivingroomWindow1)
        Me.Controls.Add(Me.entSystem)
        Me.Controls.Add(Me.livingroomBackground)
        Me.KeyPreview = True
        Me.Name = "Livingroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Livingroom"
        CType(Me.livingroomBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomShutters2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomShutters1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds2Half, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds1Half, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitWindowSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds1Closed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds1OpenSlats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds2Closed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds2OpenSlats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomWindow1Half, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomWindow2Half, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomWindow1Slightly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomWindow2Slightly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents livingroomBackground As PictureBox
    Friend WithEvents entSystem As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents LivingroomWindow2 As SubOptions
    Friend WithEvents LivingroomDoor As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents livingroomShutters2 As PictureBox
    Friend WithEvents livingroomShutters1 As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents WindowMenu As WindowMenu
    Friend WithEvents livingroomEnvironmentMenu As EnvironmentMenu
    Friend WithEvents livingroomBlinds2Half As PictureBox
    Friend WithEvents livingroomBlinds1Half As PictureBox
    Friend WithEvents exitWindowSelection As SubOptions
    Friend WithEvents vaccuumButton As SubOptions
    Friend WithEvents vaccuumOption As SubOptions
    Friend WithEvents livingroomBlinds1Closed As PictureBox
    Friend WithEvents livingroomBlinds1OpenSlats As PictureBox
    Friend WithEvents livingroomBlinds2Closed As PictureBox
    Friend WithEvents livingroomBlinds2OpenSlats As PictureBox
    Friend WithEvents livingroomWindow1Half As PictureBox
    Friend WithEvents livingroomWindow2Half As PictureBox
    Friend WithEvents livingroomWindow1Slightly As PictureBox
    Friend WithEvents livingroomWindow2Slightly As PictureBox
End Class
