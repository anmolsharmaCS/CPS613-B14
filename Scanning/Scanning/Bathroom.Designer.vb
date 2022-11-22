<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bathroom
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
        Me.bathroomWindow = New Scanning.SubOptions()
        Me.bathroomDoor = New Scanning.SubOptions()
        Me.flushToilet = New Scanning.SubOptions()
        Me.fanOption = New Scanning.SubOptions()
        Me.lightOption = New Scanning.SubOptions()
        Me.bathroomBackground = New System.Windows.Forms.PictureBox()
        Me.ScanningTImer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bathroomWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flushToilet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(93, 454)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 2
        '
        'bathroomWindow
        '
        Me.bathroomWindow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.bathroomWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bathroomWindow.Location = New System.Drawing.Point(762, 134)
        Me.bathroomWindow.Name = "bathroomWindow"
        Me.bathroomWindow.Size = New System.Drawing.Size(15, 178)
        Me.bathroomWindow.TabIndex = 61
        Me.bathroomWindow.TabStop = False
        Me.bathroomWindow.Tag = ""
        '
        'bathroomDoor
        '
        Me.bathroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.bathroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bathroomDoor.Location = New System.Drawing.Point(20, 275)
        Me.bathroomDoor.Name = "bathroomDoor"
        Me.bathroomDoor.Size = New System.Drawing.Size(12, 123)
        Me.bathroomDoor.TabIndex = 60
        Me.bathroomDoor.TabStop = False
        '
        'flushToilet
        '
        Me.flushToilet.BackColor = System.Drawing.SystemColors.Control
        Me.flushToilet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.flushToilet.Image = Global.Scanning.My.Resources.Resources.flushToilet
        Me.flushToilet.Location = New System.Drawing.Point(83, 83)
        Me.flushToilet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flushToilet.Name = "flushToilet"
        Me.flushToilet.Size = New System.Drawing.Size(372, 267)
        Me.flushToilet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flushToilet.TabIndex = 58
        Me.flushToilet.TabStop = False
        Me.flushToilet.Tag = ""
        '
        'fanOption
        '
        Me.fanOption.BackColor = System.Drawing.SystemColors.Control
        Me.fanOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fanOption.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.fanOption.Location = New System.Drawing.Point(499, 237)
        Me.fanOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fanOption.Name = "fanOption"
        Me.fanOption.Size = New System.Drawing.Size(149, 113)
        Me.fanOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fanOption.TabIndex = 57
        Me.fanOption.TabStop = False
        Me.fanOption.Tag = "off"
        '
        'lightOption
        '
        Me.lightOption.BackColor = System.Drawing.SystemColors.Control
        Me.lightOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lightOption.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.lightOption.Location = New System.Drawing.Point(499, 83)
        Me.lightOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lightOption.Name = "lightOption"
        Me.lightOption.Size = New System.Drawing.Size(149, 113)
        Me.lightOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightOption.TabIndex = 56
        Me.lightOption.TabStop = False
        Me.lightOption.Tag = "off"
        '
        'bathroomBackground
        '
        Me.bathroomBackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.bathroomBackground.Location = New System.Drawing.Point(31, 17)
        Me.bathroomBackground.Margin = New System.Windows.Forms.Padding(4)
        Me.bathroomBackground.Name = "bathroomBackground"
        Me.bathroomBackground.Size = New System.Drawing.Size(739, 417)
        Me.bathroomBackground.TabIndex = 1
        Me.bathroomBackground.TabStop = False
        '
        'ScanningTImer
        '
        Me.ScanningTImer.Interval = 1000
        '
        'Bathroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.bathroomWindow)
        Me.Controls.Add(Me.bathroomDoor)
        Me.Controls.Add(Me.flushToilet)
        Me.Controls.Add(Me.fanOption)
        Me.Controls.Add(Me.lightOption)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.bathroomBackground)
        Me.KeyPreview = True
        Me.Name = "Bathroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bathroom"
        CType(Me.bathroomWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flushToilet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bathroomBackground As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents lightOption As SubOptions
    Friend WithEvents fanOption As SubOptions
    Friend WithEvents flushToilet As SubOptions
    Friend WithEvents bathroomDoor As SubOptions
    Friend WithEvents bathroomWindow As SubOptions
    Friend WithEvents ScanningTImer As Timer
End Class
