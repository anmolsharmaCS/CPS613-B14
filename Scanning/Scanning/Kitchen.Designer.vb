<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen
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
        Me.kitchenbackground = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.exitEnv = New Scanning.SubOptions()
        Me.fanOption = New Scanning.SubOptions()
        Me.lightOption = New Scanning.SubOptions()
        Me.envOption = New Scanning.SubOptions()
        Me.cooking = New Scanning.SubOptions()
        Me.kitchenDoor = New Scanning.SubOptions()
        Me.MainTaskBar = New Scanning.MainTaskBar()
        CType(Me.kitchenbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitEnv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.envOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kitchenbackground
        '
        Me.kitchenbackground.BackColor = System.Drawing.SystemColors.ControlDark
        Me.kitchenbackground.Location = New System.Drawing.Point(13, 13)
        Me.kitchenbackground.Margin = New System.Windows.Forms.Padding(4)
        Me.kitchenbackground.Name = "kitchenbackground"
        Me.kitchenbackground.Size = New System.Drawing.Size(739, 417)
        Me.kitchenbackground.TabIndex = 1
        Me.kitchenbackground.TabStop = False
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'exitEnv
        '
        Me.exitEnv.BackColor = System.Drawing.Color.Red
        Me.exitEnv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitEnv.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitEnv.Location = New System.Drawing.Point(619, 78)
        Me.exitEnv.Name = "exitEnv"
        Me.exitEnv.Size = New System.Drawing.Size(40, 40)
        Me.exitEnv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitEnv.TabIndex = 73
        Me.exitEnv.TabStop = False
        Me.exitEnv.Visible = False
        '
        'fanOption
        '
        Me.fanOption.BackColor = System.Drawing.SystemColors.Control
        Me.fanOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fanOption.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.fanOption.Location = New System.Drawing.Point(485, 243)
        Me.fanOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fanOption.Name = "fanOption"
        Me.fanOption.Size = New System.Drawing.Size(128, 112)
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
        Me.lightOption.Location = New System.Drawing.Point(485, 115)
        Me.lightOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lightOption.Name = "lightOption"
        Me.lightOption.Size = New System.Drawing.Size(128, 112)
        Me.lightOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightOption.TabIndex = 56
        Me.lightOption.TabStop = False
        Me.lightOption.Tag = "off"
        '
        'envOption
        '
        Me.envOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.envOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.envOption.Location = New System.Drawing.Point(462, 98)
        Me.envOption.Name = "envOption"
        Me.envOption.Size = New System.Drawing.Size(173, 267)
        Me.envOption.TabIndex = 74
        Me.envOption.TabStop = False
        '
        'cooking
        '
        Me.cooking.BackColor = System.Drawing.SystemColors.Control
        Me.cooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cooking.Image = Global.Scanning.My.Resources.Resources.cooking
        Me.cooking.Location = New System.Drawing.Point(75, 98)
        Me.cooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cooking.Name = "cooking"
        Me.cooking.Size = New System.Drawing.Size(372, 267)
        Me.cooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cooking.TabIndex = 61
        Me.cooking.TabStop = False
        Me.cooking.Tag = ""
        '
        'kitchenDoor
        '
        Me.kitchenDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.kitchenDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kitchenDoor.Location = New System.Drawing.Point(748, 286)
        Me.kitchenDoor.Name = "kitchenDoor"
        Me.kitchenDoor.Size = New System.Drawing.Size(5, 123)
        Me.kitchenDoor.TabIndex = 60
        Me.kitchenDoor.TabStop = False
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(75, 437)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 2
        '
        'Kitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.exitEnv)
        Me.Controls.Add(Me.fanOption)
        Me.Controls.Add(Me.lightOption)
        Me.Controls.Add(Me.envOption)
        Me.Controls.Add(Me.cooking)
        Me.Controls.Add(Me.kitchenDoor)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.kitchenbackground)
        Me.KeyPreview = True
        Me.Name = "Kitchen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KitchenForm"
        CType(Me.kitchenbackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitEnv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fanOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.envOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenDoor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents kitchenbackground As PictureBox
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents lightOption As SubOptions
    Friend WithEvents fanOption As SubOptions
    Friend WithEvents kitchenDoor As SubOptions
    Friend WithEvents cooking As SubOptions
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents exitEnv As SubOptions
    Friend WithEvents envOption As SubOptions
End Class
