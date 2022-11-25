<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnvironmentMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tempLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitTemp = New Scanning.SubOptions()
        Me.downArrow = New Scanning.SubOptions()
        Me.upArrow = New Scanning.SubOptions()
        Me.tempOption = New Scanning.SubOptions()
        Me.exitEnvMenu = New Scanning.SubOptions()
        Me.humidity = New Scanning.SubOptions()
        Me.temperature = New Scanning.SubOptions()
        Me.fan = New Scanning.SubOptions()
        Me.lights = New Scanning.SubOptions()
        Me.envMenuBackground = New Scanning.SubOptions()
        CType(Me.exitTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.downArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitEnvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.humidity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lights, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.envMenuBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tempLabel
        '
        Me.tempLabel.AutoSize = True
        Me.tempLabel.BackColor = System.Drawing.Color.Transparent
        Me.tempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempLabel.Location = New System.Drawing.Point(26, 188)
        Me.tempLabel.Name = "tempLabel"
        Me.tempLabel.Size = New System.Drawing.Size(48, 32)
        Me.tempLabel.TabIndex = 63
        Me.tempLabel.Text = "20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 32)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "°C"
        '
        'exitTemp
        '
        Me.exitTemp.BackColor = System.Drawing.Color.Red
        Me.exitTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitTemp.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitTemp.Location = New System.Drawing.Point(208, 107)
        Me.exitTemp.Name = "exitTemp"
        Me.exitTemp.Size = New System.Drawing.Size(40, 40)
        Me.exitTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitTemp.TabIndex = 67
        Me.exitTemp.TabStop = False
        Me.exitTemp.Visible = False
        '
        'downArrow
        '
        Me.downArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.downArrow.Image = Global.Scanning.My.Resources.Resources.downarrow
        Me.downArrow.Location = New System.Drawing.Point(166, 237)
        Me.downArrow.Name = "downArrow"
        Me.downArrow.Size = New System.Drawing.Size(66, 50)
        Me.downArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.downArrow.TabIndex = 66
        Me.downArrow.TabStop = False
        Me.downArrow.Visible = False
        '
        'upArrow
        '
        Me.upArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.upArrow.Image = Global.Scanning.My.Resources.Resources.uparrow
        Me.upArrow.Location = New System.Drawing.Point(166, 153)
        Me.upArrow.Name = "upArrow"
        Me.upArrow.Size = New System.Drawing.Size(66, 50)
        Me.upArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.upArrow.TabIndex = 65
        Me.upArrow.TabStop = False
        Me.upArrow.Visible = False
        '
        'tempOption
        '
        Me.tempOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tempOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tempOption.Location = New System.Drawing.Point(150, 107)
        Me.tempOption.Name = "tempOption"
        Me.tempOption.Size = New System.Drawing.Size(98, 205)
        Me.tempOption.TabIndex = 62
        Me.tempOption.TabStop = False
        Me.tempOption.Visible = False
        '
        'exitEnvMenu
        '
        Me.exitEnvMenu.BackColor = System.Drawing.Color.Red
        Me.exitEnvMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitEnvMenu.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitEnvMenu.Location = New System.Drawing.Point(93, 0)
        Me.exitEnvMenu.Name = "exitEnvMenu"
        Me.exitEnvMenu.Size = New System.Drawing.Size(51, 45)
        Me.exitEnvMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitEnvMenu.TabIndex = 48
        Me.exitEnvMenu.TabStop = False
        Me.exitEnvMenu.Visible = False
        '
        'humidity
        '
        Me.humidity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.humidity.Image = Global.Scanning.My.Resources.Resources.humidity
        Me.humidity.Location = New System.Drawing.Point(15, 366)
        Me.humidity.Name = "humidity"
        Me.humidity.Size = New System.Drawing.Size(111, 100)
        Me.humidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.humidity.TabIndex = 14
        Me.humidity.TabStop = False
        Me.humidity.Tag = "off"
        '
        'temperature
        '
        Me.temperature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.temperature.Image = Global.Scanning.My.Resources.Resources.temp
        Me.temperature.Location = New System.Drawing.Point(15, 154)
        Me.temperature.Name = "temperature"
        Me.temperature.Size = New System.Drawing.Size(111, 100)
        Me.temperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.temperature.TabIndex = 13
        Me.temperature.TabStop = False
        '
        'fan
        '
        Me.fan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.fan.Location = New System.Drawing.Point(15, 260)
        Me.fan.Name = "fan"
        Me.fan.Size = New System.Drawing.Size(111, 100)
        Me.fan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fan.TabIndex = 12
        Me.fan.TabStop = False
        Me.fan.Tag = "off"
        '
        'lights
        '
        Me.lights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lights.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.lights.Location = New System.Drawing.Point(15, 48)
        Me.lights.Name = "lights"
        Me.lights.Size = New System.Drawing.Size(111, 100)
        Me.lights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lights.TabIndex = 11
        Me.lights.TabStop = False
        Me.lights.Tag = "off"
        '
        'envMenuBackground
        '
        Me.envMenuBackground.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.envMenuBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.envMenuBackground.Location = New System.Drawing.Point(0, 0)
        Me.envMenuBackground.Name = "envMenuBackground"
        Me.envMenuBackground.Size = New System.Drawing.Size(144, 510)
        Me.envMenuBackground.TabIndex = 15
        Me.envMenuBackground.TabStop = False
        '
        'EnvironmentMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.exitTemp)
        Me.Controls.Add(Me.downArrow)
        Me.Controls.Add(Me.upArrow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tempLabel)
        Me.Controls.Add(Me.tempOption)
        Me.Controls.Add(Me.exitEnvMenu)
        Me.Controls.Add(Me.humidity)
        Me.Controls.Add(Me.temperature)
        Me.Controls.Add(Me.fan)
        Me.Controls.Add(Me.lights)
        Me.Controls.Add(Me.envMenuBackground)
        Me.Name = "EnvironmentMenu"
        Me.Size = New System.Drawing.Size(255, 513)
        CType(Me.exitTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.downArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitEnvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.humidity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.temperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lights, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.envMenuBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lights As SubOptions
    Friend WithEvents fan As SubOptions
    Friend WithEvents temperature As SubOptions
    Friend WithEvents humidity As SubOptions
    Friend WithEvents envMenuBackground As SubOptions
    Friend WithEvents exitEnvMenu As SubOptions
    Friend WithEvents tempLabel As Label
    Friend WithEvents exitTemp As SubOptions
    Friend WithEvents downArrow As SubOptions
    Friend WithEvents upArrow As SubOptions
    Friend WithEvents Label1 As Label
    Friend WithEvents tempOption As SubOptions
End Class
