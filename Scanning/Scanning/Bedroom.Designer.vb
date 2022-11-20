<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bedroom
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.LightControl = New Scanning.SubOptions()
        Me.EnvControl = New Scanning.SubOptions()
        Me.Bed = New Scanning.SubOptions()
        Me.BedroomWindow3 = New Scanning.SubOptions()
        Me.BedroomWindow2 = New Scanning.SubOptions()
        Me.BedroomWindow1 = New Scanning.SubOptions()
        Me.BedroomDoor = New Scanning.SubOptions()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LightControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnvControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(172, 361)
        Me.MainTaskBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(405, 107)
        Me.MainTaskBar.TabIndex = 46
        '
        'LightControl
        '
        Me.LightControl.BackColor = System.Drawing.SystemColors.Control
        Me.LightControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LightControl.Image = Global.Scanning.My.Resources.Resources.bulb
        Me.LightControl.Location = New System.Drawing.Point(254, 130)
        Me.LightControl.Margin = New System.Windows.Forms.Padding(2)
        Me.LightControl.Name = "LightControl"
        Me.LightControl.Size = New System.Drawing.Size(112, 113)
        Me.LightControl.TabIndex = 53
        Me.LightControl.TabStop = False
        Me.LightControl.Tag = ""
        '
        'EnvControl
        '
        Me.EnvControl.BackColor = System.Drawing.SystemColors.Control
        Me.EnvControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EnvControl.Image = Global.Scanning.My.Resources.Resources.thermometer
        Me.EnvControl.Location = New System.Drawing.Point(434, 130)
        Me.EnvControl.Margin = New System.Windows.Forms.Padding(2)
        Me.EnvControl.Name = "EnvControl"
        Me.EnvControl.Size = New System.Drawing.Size(102, 113)
        Me.EnvControl.TabIndex = 52
        Me.EnvControl.TabStop = False
        Me.EnvControl.Tag = ""
        '
        'Bed
        '
        Me.Bed.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Bed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bed.Image = Global.Scanning.My.Resources.Resources.bed2
        Me.Bed.Location = New System.Drawing.Point(23, 124)
        Me.Bed.Margin = New System.Windows.Forms.Padding(2)
        Me.Bed.Name = "Bed"
        Me.Bed.Size = New System.Drawing.Size(163, 124)
        Me.Bed.TabIndex = 51
        Me.Bed.TabStop = False
        Me.Bed.Tag = ""
        '
        'BedroomWindow3
        '
        Me.BedroomWindow3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow3.Location = New System.Drawing.Point(565, 110)
        Me.BedroomWindow3.Margin = New System.Windows.Forms.Padding(2)
        Me.BedroomWindow3.Name = "BedroomWindow3"
        Me.BedroomWindow3.Size = New System.Drawing.Size(12, 155)
        Me.BedroomWindow3.TabIndex = 50
        Me.BedroomWindow3.TabStop = False
        Me.BedroomWindow3.Tag = ""
        '
        'BedroomWindow2
        '
        Me.BedroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow2.Location = New System.Drawing.Point(371, 17)
        Me.BedroomWindow2.Margin = New System.Windows.Forms.Padding(2)
        Me.BedroomWindow2.Name = "BedroomWindow2"
        Me.BedroomWindow2.Size = New System.Drawing.Size(110, 13)
        Me.BedroomWindow2.TabIndex = 49
        Me.BedroomWindow2.TabStop = False
        Me.BedroomWindow2.Tag = ""
        '
        'BedroomWindow1
        '
        Me.BedroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow1.Location = New System.Drawing.Point(98, 17)
        Me.BedroomWindow1.Margin = New System.Windows.Forms.Padding(2)
        Me.BedroomWindow1.Name = "BedroomWindow1"
        Me.BedroomWindow1.Size = New System.Drawing.Size(110, 13)
        Me.BedroomWindow1.TabIndex = 48
        Me.BedroomWindow1.TabStop = False
        Me.BedroomWindow1.Tag = ""
        '
        'BedroomDoor
        '
        Me.BedroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BedroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomDoor.Location = New System.Drawing.Point(254, 344)
        Me.BedroomDoor.Margin = New System.Windows.Forms.Padding(2)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(85, 12)
        Me.BedroomDoor.TabIndex = 47
        Me.BedroomDoor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(23, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(554, 339)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'Bedroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.LightControl)
        Me.Controls.Add(Me.EnvControl)
        Me.Controls.Add(Me.Bed)
        Me.Controls.Add(Me.BedroomWindow3)
        Me.Controls.Add(Me.BedroomWindow2)
        Me.Controls.Add(Me.BedroomWindow1)
        Me.Controls.Add(Me.BedroomDoor)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Bedroom"
        Me.Text = "Bedroom"
        CType(Me.LightControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnvControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents BedroomDoor As SubOptions
    Friend WithEvents BedroomWindow1 As SubOptions
    Friend WithEvents BedroomWindow2 As SubOptions
    Friend WithEvents BedroomWindow3 As SubOptions
    Friend WithEvents Bed As SubOptions
    Friend WithEvents EnvControl As SubOptions
    Friend WithEvents LightControl As SubOptions
    Friend WithEvents ScanningTimer As Timer
End Class
