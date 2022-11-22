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
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.LivingroomDoor = New Scanning.SubOptions()
        Me.LivingroomWindow2 = New Scanning.SubOptions()
        Me.LivingroomWindow1 = New Scanning.SubOptions()
        Me.fanOption = New Scanning.SubOptions()
        Me.lightOption = New Scanning.SubOptions()
        Me.entSystem = New Scanning.SubOptions()
        Me.livingroomBackground = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(40, 441)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 2
        '
        'LivingroomDoor
        '
        Me.LivingroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LivingroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomDoor.Location = New System.Drawing.Point(714, 293)
        Me.LivingroomDoor.Name = "LivingroomDoor"
        Me.LivingroomDoor.Size = New System.Drawing.Size(12, 123)
        Me.LivingroomDoor.TabIndex = 59
        Me.LivingroomDoor.TabStop = False
        '
        'LivingroomWindow2
        '
        Me.LivingroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow2.Location = New System.Drawing.Point(430, 12)
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
        Me.LivingroomWindow1.Location = New System.Drawing.Point(83, 12)
        Me.LivingroomWindow1.Name = "LivingroomWindow1"
        Me.LivingroomWindow1.Size = New System.Drawing.Size(178, 15)
        Me.LivingroomWindow1.TabIndex = 57
        Me.LivingroomWindow1.TabStop = False
        Me.LivingroomWindow1.Tag = ""
        '
        'fanOption
        '
        Me.fanOption.BackColor = System.Drawing.SystemColors.Control
        Me.fanOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fanOption.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.fanOption.Location = New System.Drawing.Point(484, 233)
        Me.fanOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fanOption.Name = "fanOption"
        Me.fanOption.Size = New System.Drawing.Size(149, 113)
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
        Me.lightOption.Location = New System.Drawing.Point(484, 79)
        Me.lightOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lightOption.Name = "lightOption"
        Me.lightOption.Size = New System.Drawing.Size(149, 113)
        Me.lightOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightOption.TabIndex = 55
        Me.lightOption.TabStop = False
        Me.lightOption.Tag = "off"
        '
        'entSystem
        '
        Me.entSystem.BackColor = System.Drawing.SystemColors.Control
        Me.entSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.entSystem.Image = Global.Scanning.My.Resources.Resources.television
        Me.entSystem.Location = New System.Drawing.Point(83, 79)
        Me.entSystem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.entSystem.Name = "entSystem"
        Me.entSystem.Size = New System.Drawing.Size(372, 267)
        Me.entSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.entSystem.TabIndex = 54
        Me.entSystem.TabStop = False
        Me.entSystem.Tag = ""
        '
        'livingroomBackground
        '
        Me.livingroomBackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.livingroomBackground.Location = New System.Drawing.Point(31, 17)
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
        'Livingroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.LivingroomDoor)
        Me.Controls.Add(Me.LivingroomWindow2)
        Me.Controls.Add(Me.LivingroomWindow1)
        Me.Controls.Add(Me.fanOption)
        Me.Controls.Add(Me.lightOption)
        Me.Controls.Add(Me.entSystem)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.livingroomBackground)
        Me.KeyPreview = True
        Me.Name = "Livingroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Livingroom"
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents livingroomBackground As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents entSystem As SubOptions
    Friend WithEvents lightOption As SubOptions
    Friend WithEvents fanOption As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents LivingroomWindow2 As SubOptions
    Friend WithEvents LivingroomDoor As SubOptions
    Friend WithEvents ScanningTimer As Timer
End Class
