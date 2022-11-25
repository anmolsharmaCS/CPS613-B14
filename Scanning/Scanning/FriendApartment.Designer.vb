<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendApartment
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
        Me.exitRooms = New Scanning.SubOptions()
        Me.LivingroomDoor = New Scanning.SubOptions()
        Me.BathroomDoor = New Scanning.SubOptions()
        Me.KitchenDoor = New Scanning.SubOptions()
        Me.BedroomDoor = New Scanning.SubOptions()
        Me.LivingroomWindow2 = New Scanning.SubOptions()
        Me.BedroomWindow1 = New Scanning.SubOptions()
        Me.BedroomWindow2 = New Scanning.SubOptions()
        Me.FrontDoor = New Scanning.SubOptions()
        Me.LivingroomWindow1 = New Scanning.SubOptions()
        Me.Bathroom = New Scanning.SubOptions()
        Me.Bedroom = New Scanning.SubOptions()
        Me.LivingRoom = New Scanning.SubOptions()
        Me.Kitchen = New Scanning.SubOptions()
        Me.apartment = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.exitRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KitchenDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bedroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(252, 559)
        Me.MainTaskBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(499, 132)
        Me.MainTaskBar.TabIndex = 86
        '
        'exitRooms
        '
        Me.exitRooms.BackColor = System.Drawing.Color.Red
        Me.exitRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitRooms.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitRooms.Location = New System.Drawing.Point(687, 59)
        Me.exitRooms.Name = "exitRooms"
        Me.exitRooms.Size = New System.Drawing.Size(51, 45)
        Me.exitRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitRooms.TabIndex = 99
        Me.exitRooms.TabStop = False
        Me.exitRooms.Visible = False
        '
        'LivingroomDoor
        '
        Me.LivingroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LivingroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomDoor.Location = New System.Drawing.Point(326, 242)
        Me.LivingroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomDoor.Name = "LivingroomDoor"
        Me.LivingroomDoor.Size = New System.Drawing.Size(5, 64)
        Me.LivingroomDoor.TabIndex = 85
        Me.LivingroomDoor.TabStop = False
        '
        'BathroomDoor
        '
        Me.BathroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BathroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BathroomDoor.Location = New System.Drawing.Point(410, 385)
        Me.BathroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BathroomDoor.Name = "BathroomDoor"
        Me.BathroomDoor.Size = New System.Drawing.Size(5, 64)
        Me.BathroomDoor.TabIndex = 84
        Me.BathroomDoor.TabStop = False
        '
        'KitchenDoor
        '
        Me.KitchenDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.KitchenDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KitchenDoor.Location = New System.Drawing.Point(326, 385)
        Me.KitchenDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KitchenDoor.Name = "KitchenDoor"
        Me.KitchenDoor.Size = New System.Drawing.Size(5, 64)
        Me.KitchenDoor.TabIndex = 83
        Me.KitchenDoor.TabStop = False
        '
        'BedroomDoor
        '
        Me.BedroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BedroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomDoor.Location = New System.Drawing.Point(503, 235)
        Me.BedroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(63, 5)
        Me.BedroomDoor.TabIndex = 82
        Me.BedroomDoor.TabStop = False
        '
        'LivingroomWindow2
        '
        Me.LivingroomWindow2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LivingroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow2.Location = New System.Drawing.Point(192, 38)
        Me.LivingroomWindow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomWindow2.Name = "LivingroomWindow2"
        Me.LivingroomWindow2.Size = New System.Drawing.Size(98, 16)
        Me.LivingroomWindow2.TabIndex = 81
        Me.LivingroomWindow2.TabStop = False
        Me.LivingroomWindow2.Tag = ""
        '
        'BedroomWindow1
        '
        Me.BedroomWindow1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BedroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow1.Location = New System.Drawing.Point(364, 38)
        Me.BedroomWindow1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow1.Name = "BedroomWindow1"
        Me.BedroomWindow1.Size = New System.Drawing.Size(98, 16)
        Me.BedroomWindow1.TabIndex = 80
        Me.BedroomWindow1.TabStop = False
        Me.BedroomWindow1.Tag = ""
        '
        'BedroomWindow2
        '
        Me.BedroomWindow2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BedroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow2.Location = New System.Drawing.Point(604, 38)
        Me.BedroomWindow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow2.Name = "BedroomWindow2"
        Me.BedroomWindow2.Size = New System.Drawing.Size(98, 16)
        Me.BedroomWindow2.TabIndex = 79
        Me.BedroomWindow2.TabStop = False
        Me.BedroomWindow2.Tag = ""
        '
        'FrontDoor
        '
        Me.FrontDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.FrontDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrontDoor.Location = New System.Drawing.Point(337, 552)
        Me.FrontDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FrontDoor.Name = "FrontDoor"
        Me.FrontDoor.Size = New System.Drawing.Size(63, 5)
        Me.FrontDoor.TabIndex = 78
        Me.FrontDoor.TabStop = False
        '
        'LivingroomWindow1
        '
        Me.LivingroomWindow1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LivingroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow1.Location = New System.Drawing.Point(31, 38)
        Me.LivingroomWindow1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomWindow1.Name = "LivingroomWindow1"
        Me.LivingroomWindow1.Size = New System.Drawing.Size(98, 16)
        Me.LivingroomWindow1.TabIndex = 77
        Me.LivingroomWindow1.TabStop = False
        Me.LivingroomWindow1.Tag = "5"
        '
        'Bathroom
        '
        Me.Bathroom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Bathroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bathroom.Image = Global.Scanning.My.Resources.Resources.toilet
        Me.Bathroom.Location = New System.Drawing.Point(412, 315)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(339, 239)
        Me.Bathroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bathroom.TabIndex = 76
        Me.Bathroom.TabStop = False
        Me.Bathroom.Tag = "0"
        '
        'Bedroom
        '
        Me.Bedroom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Bedroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bedroom.Image = Global.Scanning.My.Resources.Resources.bed__1_
        Me.Bedroom.Location = New System.Drawing.Point(326, 41)
        Me.Bedroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(423, 196)
        Me.Bedroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bedroom.TabIndex = 75
        Me.Bedroom.TabStop = False
        Me.Bedroom.Tag = "0"
        '
        'LivingRoom
        '
        Me.LivingRoom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LivingRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingRoom.Image = Global.Scanning.My.Resources.Resources.livingRoom
        Me.LivingRoom.Location = New System.Drawing.Point(12, 41)
        Me.LivingRoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingRoom.Name = "LivingRoom"
        Me.LivingRoom.Size = New System.Drawing.Size(317, 280)
        Me.LivingRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LivingRoom.TabIndex = 74
        Me.LivingRoom.TabStop = False
        Me.LivingRoom.Tag = "0"
        '
        'Kitchen
        '
        Me.Kitchen.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Kitchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kitchen.Image = Global.Scanning.My.Resources.Resources.kitchen
        Me.Kitchen.Location = New System.Drawing.Point(12, 315)
        Me.Kitchen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Kitchen.Name = "Kitchen"
        Me.Kitchen.Size = New System.Drawing.Size(317, 239)
        Me.Kitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Kitchen.TabIndex = 73
        Me.Kitchen.TabStop = False
        Me.Kitchen.Tag = "0"
        '
        'apartment
        '
        Me.apartment.BackColor = System.Drawing.Color.SandyBrown
        Me.apartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apartment.Location = New System.Drawing.Point(12, 41)
        Me.apartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.apartment.Name = "apartment"
        Me.apartment.Size = New System.Drawing.Size(738, 514)
        Me.apartment.TabIndex = 72
        Me.apartment.TabStop = False
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'FriendApartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.exitRooms)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.LivingroomDoor)
        Me.Controls.Add(Me.BathroomDoor)
        Me.Controls.Add(Me.KitchenDoor)
        Me.Controls.Add(Me.BedroomDoor)
        Me.Controls.Add(Me.LivingroomWindow2)
        Me.Controls.Add(Me.BedroomWindow1)
        Me.Controls.Add(Me.BedroomWindow2)
        Me.Controls.Add(Me.FrontDoor)
        Me.Controls.Add(Me.LivingroomWindow1)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.Bedroom)
        Me.Controls.Add(Me.LivingRoom)
        Me.Controls.Add(Me.Kitchen)
        Me.Controls.Add(Me.apartment)
        Me.KeyPreview = True
        Me.Name = "FriendApartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FriendAparment"
        CType(Me.exitRooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KitchenDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bedroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exitRooms As SubOptions
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents LivingroomDoor As SubOptions
    Friend WithEvents BathroomDoor As SubOptions
    Friend WithEvents KitchenDoor As SubOptions
    Friend WithEvents BedroomDoor As SubOptions
    Friend WithEvents LivingroomWindow2 As SubOptions
    Friend WithEvents BedroomWindow1 As SubOptions
    Friend WithEvents BedroomWindow2 As SubOptions
    Friend WithEvents FrontDoor As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents Bathroom As SubOptions
    Friend WithEvents Bedroom As SubOptions
    Friend WithEvents LivingRoom As SubOptions
    Friend WithEvents Kitchen As SubOptions
    Friend WithEvents apartment As PictureBox
    Friend WithEvents ScanningTimer As Timer
End Class
