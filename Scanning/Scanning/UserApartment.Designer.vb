<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserApartment
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
        Me.apartment = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow3 = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow2 = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow1 = New System.Windows.Forms.PictureBox()
        Me.LivingRoomWindow2 = New System.Windows.Forms.PictureBox()
        Me.BathroomWindow = New System.Windows.Forms.PictureBox()
        Me.LivingroomDoor = New System.Windows.Forms.PictureBox()
        Me.BathroomDoor = New System.Windows.Forms.PictureBox()
        Me.KitchenDoor = New System.Windows.Forms.PictureBox()
        Me.BedroomDoor = New System.Windows.Forms.PictureBox()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FrontDoor = New Scanning.SubOptions()
        Me.LivingroomWindow1 = New Scanning.SubOptions()
        Me.Bathroom = New Scanning.SubOptions()
        Me.Bedroom = New Scanning.SubOptions()
        Me.LivingRoom = New Scanning.SubOptions()
        Me.Kitchen = New Scanning.SubOptions()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingRoomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KitchenDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bedroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'apartment
        '
        Me.apartment.BackColor = System.Drawing.Color.SandyBrown
        Me.apartment.Location = New System.Drawing.Point(16, 15)
        Me.apartment.Name = "apartment"
        Me.apartment.Size = New System.Drawing.Size(738, 417)
        Me.apartment.TabIndex = 5
        Me.apartment.TabStop = False
        '
        'BedroomWindow3
        '
        Me.BedroomWindow3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow3.Location = New System.Drawing.Point(748, 51)
        Me.BedroomWindow3.Name = "BedroomWindow3"
        Me.BedroomWindow3.Size = New System.Drawing.Size(15, 98)
        Me.BedroomWindow3.TabIndex = 7
        Me.BedroomWindow3.TabStop = False
        '
        'BedroomWindow2
        '
        Me.BedroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow2.Location = New System.Drawing.Point(609, 12)
        Me.BedroomWindow2.Name = "BedroomWindow2"
        Me.BedroomWindow2.Size = New System.Drawing.Size(98, 15)
        Me.BedroomWindow2.TabIndex = 8
        Me.BedroomWindow2.TabStop = False
        '
        'BedroomWindow1
        '
        Me.BedroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow1.Location = New System.Drawing.Point(372, 12)
        Me.BedroomWindow1.Name = "BedroomWindow1"
        Me.BedroomWindow1.Size = New System.Drawing.Size(98, 15)
        Me.BedroomWindow1.TabIndex = 9
        Me.BedroomWindow1.TabStop = False
        '
        'LivingRoomWindow2
        '
        Me.LivingRoomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingRoomWindow2.Location = New System.Drawing.Point(202, 12)
        Me.LivingRoomWindow2.Name = "LivingRoomWindow2"
        Me.LivingRoomWindow2.Size = New System.Drawing.Size(98, 15)
        Me.LivingRoomWindow2.TabIndex = 10
        Me.LivingRoomWindow2.TabStop = False
        '
        'BathroomWindow
        '
        Me.BathroomWindow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BathroomWindow.Location = New System.Drawing.Point(748, 296)
        Me.BathroomWindow.Name = "BathroomWindow"
        Me.BathroomWindow.Size = New System.Drawing.Size(15, 98)
        Me.BathroomWindow.TabIndex = 12
        Me.BathroomWindow.TabStop = False
        '
        'LivingroomDoor
        '
        Me.LivingroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LivingroomDoor.Location = New System.Drawing.Point(327, 189)
        Me.LivingroomDoor.Name = "LivingroomDoor"
        Me.LivingroomDoor.Size = New System.Drawing.Size(15, 64)
        Me.LivingroomDoor.TabIndex = 13
        Me.LivingroomDoor.TabStop = False
        '
        'BathroomDoor
        '
        Me.BathroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BathroomDoor.Location = New System.Drawing.Point(406, 314)
        Me.BathroomDoor.Name = "BathroomDoor"
        Me.BathroomDoor.Size = New System.Drawing.Size(15, 64)
        Me.BathroomDoor.TabIndex = 14
        Me.BathroomDoor.TabStop = False
        '
        'KitchenDoor
        '
        Me.KitchenDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.KitchenDoor.Location = New System.Drawing.Point(327, 314)
        Me.KitchenDoor.Name = "KitchenDoor"
        Me.KitchenDoor.Size = New System.Drawing.Size(15, 64)
        Me.KitchenDoor.TabIndex = 15
        Me.KitchenDoor.TabStop = False
        '
        'BedroomDoor
        '
        Me.BedroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BedroomDoor.Location = New System.Drawing.Point(523, 180)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(64, 15)
        Me.BedroomDoor.TabIndex = 16
        Me.BedroomDoor.TabStop = False
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'FrontDoor
        '
        Me.FrontDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.FrontDoor.Location = New System.Drawing.Point(338, 427)
        Me.FrontDoor.Name = "FrontDoor"
        Me.FrontDoor.Size = New System.Drawing.Size(64, 15)
        Me.FrontDoor.TabIndex = 23
        Me.FrontDoor.TabStop = False
        '
        'LivingroomWindow1
        '
        Me.LivingroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow1.Location = New System.Drawing.Point(39, 12)
        Me.LivingroomWindow1.Name = "LivingroomWindow1"
        Me.LivingroomWindow1.Size = New System.Drawing.Size(98, 15)
        Me.LivingroomWindow1.TabIndex = 22
        Me.LivingroomWindow1.TabStop = False
        Me.LivingroomWindow1.Tag = "5"
        '
        'Bathroom
        '
        Me.Bathroom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Bathroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bathroom.Image = Global.Scanning.My.Resources.Resources.toilet
        Me.Bathroom.Location = New System.Drawing.Point(415, 260)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(339, 172)
        Me.Bathroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bathroom.TabIndex = 21
        Me.Bathroom.TabStop = False
        Me.Bathroom.Tag = "0"
        '
        'Bedroom
        '
        Me.Bedroom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Bedroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bedroom.Image = Global.Scanning.My.Resources.Resources.bed__1_
        Me.Bedroom.Location = New System.Drawing.Point(331, 15)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(423, 174)
        Me.Bedroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bedroom.TabIndex = 20
        Me.Bedroom.TabStop = False
        Me.Bedroom.Tag = "0"
        '
        'LivingRoom
        '
        Me.LivingRoom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LivingRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingRoom.Image = Global.Scanning.My.Resources.Resources.livingRoom
        Me.LivingRoom.Location = New System.Drawing.Point(16, 15)
        Me.LivingRoom.Name = "LivingRoom"
        Me.LivingRoom.Size = New System.Drawing.Size(316, 239)
        Me.LivingRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LivingRoom.TabIndex = 19
        Me.LivingRoom.TabStop = False
        Me.LivingRoom.Tag = "0"
        '
        'Kitchen
        '
        Me.Kitchen.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Kitchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Kitchen.Image = Global.Scanning.My.Resources.Resources.kitchen
        Me.Kitchen.Location = New System.Drawing.Point(16, 253)
        Me.Kitchen.Name = "Kitchen"
        Me.Kitchen.Size = New System.Drawing.Size(316, 179)
        Me.Kitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Kitchen.TabIndex = 18
        Me.Kitchen.TabStop = False
        Me.Kitchen.Tag = "0"
        '
        'UserApartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 568)
        Me.Controls.Add(Me.FrontDoor)
        Me.Controls.Add(Me.LivingroomWindow1)
        Me.Controls.Add(Me.BathroomWindow)
        Me.Controls.Add(Me.LivingroomDoor)
        Me.Controls.Add(Me.LivingRoomWindow2)
        Me.Controls.Add(Me.BedroomWindow1)
        Me.Controls.Add(Me.BedroomWindow2)
        Me.Controls.Add(Me.BedroomDoor)
        Me.Controls.Add(Me.BedroomWindow3)
        Me.Controls.Add(Me.BathroomDoor)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.Bedroom)
        Me.Controls.Add(Me.LivingRoom)
        Me.Controls.Add(Me.KitchenDoor)
        Me.Controls.Add(Me.Kitchen)
        Me.Controls.Add(Me.apartment)
        Me.Name = "UserApartment"
        Me.Text = "UserApartment"
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingRoomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KitchenDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bedroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents apartment As PictureBox
    Friend WithEvents BedroomWindow3 As PictureBox
    Friend WithEvents BedroomWindow2 As PictureBox
    Friend WithEvents BedroomWindow1 As PictureBox
    Friend WithEvents LivingRoomWindow2 As PictureBox
    Friend WithEvents BathroomWindow As PictureBox
    Friend WithEvents LivingroomDoor As PictureBox
    Friend WithEvents BathroomDoor As PictureBox
    Friend WithEvents KitchenDoor As PictureBox
    Friend WithEvents BedroomDoor As PictureBox
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents Kitchen As SubOptions
    Friend WithEvents LivingRoom As SubOptions
    Friend WithEvents Bedroom As SubOptions
    Friend WithEvents Bathroom As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents FrontDoor As SubOptions
End Class
