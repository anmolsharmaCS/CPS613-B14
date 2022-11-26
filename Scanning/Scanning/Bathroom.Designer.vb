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
        Me.bathroomBackground = New System.Windows.Forms.PictureBox()
        Me.ScanningTImer = New System.Windows.Forms.Timer(Me.components)
        Me.bathroomDoor = New Scanning.SubOptions()
        Me.flushToilet = New Scanning.SubOptions()
        Me.bathroomMainTaskBar = New Scanning.MainTaskBar()
        Me.bathroomEnvironmentMenu = New Scanning.EnvironmentMenu()
        Me.vaccuumButton = New Scanning.SubOptions()
        Me.vaccuumOption = New Scanning.SubOptions()
        CType(Me.bathroomBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flushToilet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bathroomBackground
        '
        Me.bathroomBackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.bathroomBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bathroomBackground.Location = New System.Drawing.Point(31, 17)
        Me.bathroomBackground.Margin = New System.Windows.Forms.Padding(4)
        Me.bathroomBackground.Name = "bathroomBackground"
        Me.bathroomBackground.Size = New System.Drawing.Size(739, 508)
        Me.bathroomBackground.TabIndex = 1
        Me.bathroomBackground.TabStop = False
        '
        'ScanningTImer
        '
        Me.ScanningTImer.Interval = 1000
        '
        'bathroomDoor
        '
        Me.bathroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.bathroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bathroomDoor.Location = New System.Drawing.Point(27, 275)
        Me.bathroomDoor.Name = "bathroomDoor"
        Me.bathroomDoor.Size = New System.Drawing.Size(5, 123)
        Me.bathroomDoor.TabIndex = 60
        Me.bathroomDoor.TabStop = False
        '
        'flushToilet
        '
        Me.flushToilet.BackColor = System.Drawing.SystemColors.Control
        Me.flushToilet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.flushToilet.Image = Global.Scanning.My.Resources.Resources.flushToilet
        Me.flushToilet.Location = New System.Drawing.Point(223, 117)
        Me.flushToilet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flushToilet.Name = "flushToilet"
        Me.flushToilet.Size = New System.Drawing.Size(372, 267)
        Me.flushToilet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flushToilet.TabIndex = 58
        Me.flushToilet.TabStop = False
        Me.flushToilet.Tag = ""
        '
        'bathroomMainTaskBar
        '
        Me.bathroomMainTaskBar.Location = New System.Drawing.Point(121, 532)
        Me.bathroomMainTaskBar.Name = "bathroomMainTaskBar"
        Me.bathroomMainTaskBar.Size = New System.Drawing.Size(649, 132)
        Me.bathroomMainTaskBar.TabIndex = 2
        '
        'bathroomEnvironmentMenu
        '
        Me.bathroomEnvironmentMenu.Location = New System.Drawing.Point(777, 12)
        Me.bathroomEnvironmentMenu.Name = "bathroomEnvironmentMenu"
        Me.bathroomEnvironmentMenu.Size = New System.Drawing.Size(255, 513)
        Me.bathroomEnvironmentMenu.TabIndex = 66
        '
        'vaccuumButton
        '
        Me.vaccuumButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.vaccuumButton.Image = Global.Scanning.My.Resources.Resources.roomba
        Me.vaccuumButton.Location = New System.Drawing.Point(791, 544)
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
        Me.vaccuumOption.Location = New System.Drawing.Point(776, 531)
        Me.vaccuumOption.Name = "vaccuumOption"
        Me.vaccuumOption.Size = New System.Drawing.Size(145, 131)
        Me.vaccuumOption.TabIndex = 74
        Me.vaccuumOption.TabStop = False
        '
        'Bathroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.vaccuumButton)
        Me.Controls.Add(Me.vaccuumOption)
        Me.Controls.Add(Me.bathroomEnvironmentMenu)
        Me.Controls.Add(Me.bathroomDoor)
        Me.Controls.Add(Me.flushToilet)
        Me.Controls.Add(Me.bathroomMainTaskBar)
        Me.Controls.Add(Me.bathroomBackground)
        Me.KeyPreview = True
        Me.Name = "Bathroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bathroom"
        CType(Me.bathroomBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flushToilet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vaccuumOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bathroomBackground As PictureBox
    Friend WithEvents bathroomMainTaskBar As MainTaskBar
    Friend WithEvents flushToilet As SubOptions
    Friend WithEvents bathroomDoor As SubOptions
    Friend WithEvents ScanningTImer As Timer
    Friend WithEvents bathroomEnvironmentMenu As EnvironmentMenu
    Friend WithEvents vaccuumButton As SubOptions
    Friend WithEvents vaccuumOption As SubOptions
End Class
