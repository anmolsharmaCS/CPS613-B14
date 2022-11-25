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
        Me.livingroomBlinds2 = New System.Windows.Forms.PictureBox()
        Me.livingroomBlinds1 = New System.Windows.Forms.PictureBox()
        Me.exitWindowSelection = New Scanning.SubOptions()
        CType(Me.livingroomBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomShutters2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomShutters1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBlinds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitWindowSelection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MainTaskBar.Location = New System.Drawing.Point(230, 571)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(504, 132)
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
        'livingroomBlinds2
        '
        Me.livingroomBlinds2.Image = Global.Scanning.My.Resources.Resources.blinds
        Me.livingroomBlinds2.Location = New System.Drawing.Point(435, 61)
        Me.livingroomBlinds2.Name = "livingroomBlinds2"
        Me.livingroomBlinds2.Size = New System.Drawing.Size(178, 52)
        Me.livingroomBlinds2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds2.TabIndex = 77
        Me.livingroomBlinds2.TabStop = False
        Me.livingroomBlinds2.Visible = False
        '
        'livingroomBlinds1
        '
        Me.livingroomBlinds1.Image = Global.Scanning.My.Resources.Resources.blinds
        Me.livingroomBlinds1.Location = New System.Drawing.Point(88, 61)
        Me.livingroomBlinds1.Name = "livingroomBlinds1"
        Me.livingroomBlinds1.Size = New System.Drawing.Size(178, 52)
        Me.livingroomBlinds1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomBlinds1.TabIndex = 78
        Me.livingroomBlinds1.TabStop = False
        Me.livingroomBlinds1.Visible = False
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
        'Livingroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.exitWindowSelection)
        Me.Controls.Add(Me.livingroomBlinds1)
        Me.Controls.Add(Me.livingroomBlinds2)
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
        CType(Me.livingroomBlinds2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBlinds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitWindowSelection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents livingroomBlinds2 As PictureBox
    Friend WithEvents livingroomBlinds1 As PictureBox
    Friend WithEvents exitWindowSelection As SubOptions
End Class
