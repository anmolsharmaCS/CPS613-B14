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
        Me.fanOption = New Scanning.SubOptions()
        Me.lightOption = New Scanning.SubOptions()
        Me.envOption = New Scanning.SubOptions()
        Me.LivingroomDoor = New Scanning.SubOptions()
        Me.LivingroomWindow2 = New Scanning.SubOptions()
        Me.LivingroomWindow1 = New Scanning.SubOptions()
        Me.entSystem = New Scanning.SubOptions()
        Me.exitLivingroomEnv = New Scanning.SubOptions()
        Me.WindowMenu = New Scanning.WindowMenu()
        CType(Me.livingroomBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomShutters2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomShutters1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.envOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitLivingroomEnv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'livingroomBackground
        '
        Me.livingroomBackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.livingroomBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.livingroomBackground.Location = New System.Drawing.Point(36, 52)
        Me.livingroomBackground.Margin = New System.Windows.Forms.Padding(4)
        Me.livingroomBackground.Name = "livingroomBackground"
        Me.livingroomBackground.Size = New System.Drawing.Size(686, 417)
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
        Me.MainTaskBar.Location = New System.Drawing.Point(120, 476)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(602, 132)
        Me.MainTaskBar.TabIndex = 73
        '
        'fanOption
        '
        Me.fanOption.BackColor = System.Drawing.SystemColors.Control
        Me.fanOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fanOption.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.fanOption.Location = New System.Drawing.Point(485, 283)
        Me.fanOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fanOption.Name = "fanOption"
        Me.fanOption.Size = New System.Drawing.Size(128, 112)
        Me.fanOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fanOption.TabIndex = 56
        Me.fanOption.TabStop = False
        Me.fanOption.Tag = "off"
        '
        'lightOption
        '
        Me.lightOption.BackColor = System.Drawing.SystemColors.Control
        Me.lightOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lightOption.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.lightOption.Location = New System.Drawing.Point(485, 167)
        Me.lightOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lightOption.Name = "lightOption"
        Me.lightOption.Size = New System.Drawing.Size(128, 112)
        Me.lightOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightOption.TabIndex = 55
        Me.lightOption.TabStop = False
        Me.lightOption.Tag = "off"
        '
        'envOption
        '
        Me.envOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.envOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.envOption.Location = New System.Drawing.Point(458, 149)
        Me.envOption.Name = "envOption"
        Me.envOption.Size = New System.Drawing.Size(173, 267)
        Me.envOption.TabIndex = 72
        Me.envOption.TabStop = False
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
        Me.entSystem.Location = New System.Drawing.Point(67, 149)
        Me.entSystem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.entSystem.Name = "entSystem"
        Me.entSystem.Size = New System.Drawing.Size(372, 267)
        Me.entSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.entSystem.TabIndex = 54
        Me.entSystem.TabStop = False
        Me.entSystem.Tag = ""
        '
        'exitLivingroomEnv
        '
        Me.exitLivingroomEnv.BackColor = System.Drawing.Color.Red
        Me.exitLivingroomEnv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitLivingroomEnv.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitLivingroomEnv.Location = New System.Drawing.Point(619, 131)
        Me.exitLivingroomEnv.Name = "exitLivingroomEnv"
        Me.exitLivingroomEnv.Size = New System.Drawing.Size(40, 40)
        Me.exitLivingroomEnv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitLivingroomEnv.TabIndex = 74
        Me.exitLivingroomEnv.TabStop = False
        Me.exitLivingroomEnv.Visible = False
        '
        'WindowMenu
        '
        Me.WindowMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WindowMenu.Location = New System.Drawing.Point(88, 178)
        Me.WindowMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.WindowMenu.Name = "WindowMenu"
        Me.WindowMenu.Size = New System.Drawing.Size(540, 183)
        Me.WindowMenu.TabIndex = 75
        Me.WindowMenu.Visible = False
        '
        'Livingroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.WindowMenu)
        Me.Controls.Add(Me.exitLivingroomEnv)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.fanOption)
        Me.Controls.Add(Me.lightOption)
        Me.Controls.Add(Me.envOption)
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
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.envOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitLivingroomEnv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents livingroomBackground As PictureBox
    Friend WithEvents entSystem As SubOptions
    Friend WithEvents lightOption As SubOptions
    Friend WithEvents fanOption As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents LivingroomWindow2 As SubOptions
    Friend WithEvents LivingroomDoor As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents livingroomShutters2 As PictureBox
    Friend WithEvents livingroomShutters1 As PictureBox
    Friend WithEvents envOption As SubOptions
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents exitLivingroomEnv As SubOptions
    Friend WithEvents WindowMenu As WindowMenu
End Class
