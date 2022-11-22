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
        Me.FanControl = New Scanning.SubOptions()
        Me.LightControl = New Scanning.SubOptions()
        Me.Bed = New Scanning.SubOptions()
        Me.BedroomWindow3 = New Scanning.SubOptions()
        Me.BedroomWindow2 = New Scanning.SubOptions()
        Me.BedroomWindow1 = New Scanning.SubOptions()
        Me.BedroomDoor = New Scanning.SubOptions()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.FanControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(93, 457)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 54
        '
        'FanControl
        '
        Me.FanControl.BackColor = System.Drawing.SystemColors.Control
        Me.FanControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FanControl.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.FanControl.Location = New System.Drawing.Point(477, 233)
        Me.FanControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FanControl.Name = "FanControl"
        Me.FanControl.Size = New System.Drawing.Size(149, 113)
        Me.FanControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FanControl.TabIndex = 55
        Me.FanControl.TabStop = False
        Me.FanControl.Tag = "off"
        '
        'LightControl
        '
        Me.LightControl.BackColor = System.Drawing.SystemColors.Control
        Me.LightControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LightControl.Image = Global.Scanning.My.Resources.Resources.bulbLit
        Me.LightControl.Location = New System.Drawing.Point(477, 101)
        Me.LightControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LightControl.Name = "LightControl"
        Me.LightControl.Size = New System.Drawing.Size(149, 113)
        Me.LightControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LightControl.TabIndex = 53
        Me.LightControl.TabStop = False
        Me.LightControl.Tag = "on"
        '
        'Bed
        '
        Me.Bed.BackColor = System.Drawing.SystemColors.Control
        Me.Bed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bed.Image = Global.Scanning.My.Resources.Resources.bedUp
        Me.Bed.Location = New System.Drawing.Point(169, 101)
        Me.Bed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bed.Name = "Bed"
        Me.Bed.Size = New System.Drawing.Size(283, 245)
        Me.Bed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bed.TabIndex = 51
        Me.Bed.TabStop = False
        Me.Bed.Tag = "up"
        '
        'BedroomWindow3
        '
        Me.BedroomWindow3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow3.Location = New System.Drawing.Point(753, 135)
        Me.BedroomWindow3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow3.Name = "BedroomWindow3"
        Me.BedroomWindow3.Size = New System.Drawing.Size(15, 190)
        Me.BedroomWindow3.TabIndex = 50
        Me.BedroomWindow3.TabStop = False
        Me.BedroomWindow3.Tag = ""
        '
        'BedroomWindow2
        '
        Me.BedroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow2.Location = New System.Drawing.Point(495, 21)
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
        Me.BedroomWindow1.Location = New System.Drawing.Point(131, 21)
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
        Me.BedroomDoor.Location = New System.Drawing.Point(339, 423)
        Me.BedroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(113, 14)
        Me.BedroomDoor.TabIndex = 47
        Me.BedroomDoor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(31, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 417)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Bedroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.FanControl)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.LightControl)
        Me.Controls.Add(Me.Bed)
        Me.Controls.Add(Me.BedroomWindow3)
        Me.Controls.Add(Me.BedroomWindow2)
        Me.Controls.Add(Me.BedroomWindow1)
        Me.Controls.Add(Me.BedroomDoor)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Bedroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bedroom"
        CType(Me.FanControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BedroomDoor As SubOptions
    Friend WithEvents BedroomWindow1 As SubOptions
    Friend WithEvents BedroomWindow2 As SubOptions
    Friend WithEvents BedroomWindow3 As SubOptions
    Friend WithEvents Bed As SubOptions
    Friend WithEvents LightControl As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents FanControl As SubOptions
End Class
