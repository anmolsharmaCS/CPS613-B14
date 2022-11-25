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
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LivingroomWindow2Shutters = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow1Shutters = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow2Shutters = New System.Windows.Forms.PictureBox()
        Me.LivingroomWindow1Shutters = New System.Windows.Forms.PictureBox()
        Me.livingroomFan = New System.Windows.Forms.PictureBox()
        Me.kitchenFan = New System.Windows.Forms.PictureBox()
        Me.bathroomFan = New System.Windows.Forms.PictureBox()
        Me.bedroomFan = New System.Windows.Forms.PictureBox()
        Me.bathroomLight = New System.Windows.Forms.PictureBox()
        Me.bedroomLight = New System.Windows.Forms.PictureBox()
        Me.kitchenLight = New System.Windows.Forms.PictureBox()
        Me.livingroomLight = New System.Windows.Forms.PictureBox()
        Me.apartment = New System.Windows.Forms.PictureBox()
        Me.livingroomHumidity = New System.Windows.Forms.PictureBox()
        Me.bathroomHUmidity = New System.Windows.Forms.PictureBox()
        Me.kitchenHumidity = New System.Windows.Forms.PictureBox()
        Me.bedroomHumidity = New System.Windows.Forms.PictureBox()
        Me.EnvironmentMenu = New Scanning.EnvironmentMenu()
        Me.WindowMenu = New Scanning.WindowMenu()
        Me.exitRooms = New Scanning.SubOptions()
        Me.MainTaskBar = New Scanning.MainTaskBar()
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
        CType(Me.LivingroomWindow2Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomHUmidity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomHumidity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'LivingroomWindow2Shutters
        '
        Me.LivingroomWindow2Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.LivingroomWindow2Shutters.Location = New System.Drawing.Point(169, 6)
        Me.LivingroomWindow2Shutters.Name = "LivingroomWindow2Shutters"
        Me.LivingroomWindow2Shutters.Size = New System.Drawing.Size(137, 28)
        Me.LivingroomWindow2Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LivingroomWindow2Shutters.TabIndex = 54
        Me.LivingroomWindow2Shutters.TabStop = False
        Me.LivingroomWindow2Shutters.Visible = False
        '
        'BedroomWindow1Shutters
        '
        Me.BedroomWindow1Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.BedroomWindow1Shutters.Location = New System.Drawing.Point(343, 6)
        Me.BedroomWindow1Shutters.Name = "BedroomWindow1Shutters"
        Me.BedroomWindow1Shutters.Size = New System.Drawing.Size(137, 28)
        Me.BedroomWindow1Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BedroomWindow1Shutters.TabIndex = 53
        Me.BedroomWindow1Shutters.TabStop = False
        '
        'BedroomWindow2Shutters
        '
        Me.BedroomWindow2Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.BedroomWindow2Shutters.Location = New System.Drawing.Point(583, 6)
        Me.BedroomWindow2Shutters.Name = "BedroomWindow2Shutters"
        Me.BedroomWindow2Shutters.Size = New System.Drawing.Size(137, 28)
        Me.BedroomWindow2Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BedroomWindow2Shutters.TabIndex = 52
        Me.BedroomWindow2Shutters.TabStop = False
        '
        'LivingroomWindow1Shutters
        '
        Me.LivingroomWindow1Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.LivingroomWindow1Shutters.Location = New System.Drawing.Point(12, 6)
        Me.LivingroomWindow1Shutters.Name = "LivingroomWindow1Shutters"
        Me.LivingroomWindow1Shutters.Size = New System.Drawing.Size(137, 28)
        Me.LivingroomWindow1Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LivingroomWindow1Shutters.TabIndex = 51
        Me.LivingroomWindow1Shutters.TabStop = False
        Me.LivingroomWindow1Shutters.Visible = False
        '
        'livingroomFan
        '
        Me.livingroomFan.BackColor = System.Drawing.Color.Transparent
        Me.livingroomFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.livingroomFan.Location = New System.Drawing.Point(2, 57)
        Me.livingroomFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.livingroomFan.Name = "livingroomFan"
        Me.livingroomFan.Size = New System.Drawing.Size(55, 41)
        Me.livingroomFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomFan.TabIndex = 43
        Me.livingroomFan.TabStop = False
        '
        'kitchenFan
        '
        Me.kitchenFan.BackColor = System.Drawing.Color.Transparent
        Me.kitchenFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.kitchenFan.Location = New System.Drawing.Point(2, 57)
        Me.kitchenFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kitchenFan.Name = "kitchenFan"
        Me.kitchenFan.Size = New System.Drawing.Size(55, 41)
        Me.kitchenFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kitchenFan.TabIndex = 42
        Me.kitchenFan.TabStop = False
        '
        'bathroomFan
        '
        Me.bathroomFan.BackColor = System.Drawing.Color.Transparent
        Me.bathroomFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.bathroomFan.Location = New System.Drawing.Point(2, 57)
        Me.bathroomFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bathroomFan.Name = "bathroomFan"
        Me.bathroomFan.Size = New System.Drawing.Size(55, 41)
        Me.bathroomFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bathroomFan.TabIndex = 41
        Me.bathroomFan.TabStop = False
        '
        'bedroomFan
        '
        Me.bedroomFan.BackColor = System.Drawing.Color.Transparent
        Me.bedroomFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.bedroomFan.Location = New System.Drawing.Point(2, 57)
        Me.bedroomFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bedroomFan.Name = "bedroomFan"
        Me.bedroomFan.Size = New System.Drawing.Size(55, 41)
        Me.bedroomFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomFan.TabIndex = 40
        Me.bedroomFan.TabStop = False
        '
        'bathroomLight
        '
        Me.bathroomLight.BackColor = System.Drawing.Color.Transparent
        Me.bathroomLight.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.bathroomLight.Location = New System.Drawing.Point(2, 12)
        Me.bathroomLight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bathroomLight.Name = "bathroomLight"
        Me.bathroomLight.Size = New System.Drawing.Size(55, 41)
        Me.bathroomLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bathroomLight.TabIndex = 39
        Me.bathroomLight.TabStop = False
        '
        'bedroomLight
        '
        Me.bedroomLight.BackColor = System.Drawing.Color.Transparent
        Me.bedroomLight.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.bedroomLight.Location = New System.Drawing.Point(2, 12)
        Me.bedroomLight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bedroomLight.Name = "bedroomLight"
        Me.bedroomLight.Size = New System.Drawing.Size(55, 41)
        Me.bedroomLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomLight.TabIndex = 38
        Me.bedroomLight.TabStop = False
        '
        'kitchenLight
        '
        Me.kitchenLight.BackColor = System.Drawing.Color.Transparent
        Me.kitchenLight.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.kitchenLight.Location = New System.Drawing.Point(2, 12)
        Me.kitchenLight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kitchenLight.Name = "kitchenLight"
        Me.kitchenLight.Size = New System.Drawing.Size(55, 41)
        Me.kitchenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kitchenLight.TabIndex = 37
        Me.kitchenLight.TabStop = False
        '
        'livingroomLight
        '
        Me.livingroomLight.BackColor = System.Drawing.Color.Transparent
        Me.livingroomLight.Image = Global.Scanning.My.Resources.Resources.bulbUnlit
        Me.livingroomLight.Location = New System.Drawing.Point(2, 12)
        Me.livingroomLight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.livingroomLight.Name = "livingroomLight"
        Me.livingroomLight.Size = New System.Drawing.Size(55, 41)
        Me.livingroomLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomLight.TabIndex = 36
        Me.livingroomLight.TabStop = False
        '
        'apartment
        '
        Me.apartment.BackColor = System.Drawing.Color.SandyBrown
        Me.apartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apartment.Location = New System.Drawing.Point(12, 37)
        Me.apartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.apartment.Name = "apartment"
        Me.apartment.Size = New System.Drawing.Size(738, 514)
        Me.apartment.TabIndex = 5
        Me.apartment.TabStop = False
        '
        'livingroomHumidity
        '
        Me.livingroomHumidity.BackColor = System.Drawing.Color.Transparent
        Me.livingroomHumidity.Image = Global.Scanning.My.Resources.Resources.humidity
        Me.livingroomHumidity.Location = New System.Drawing.Point(2, 102)
        Me.livingroomHumidity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.livingroomHumidity.Name = "livingroomHumidity"
        Me.livingroomHumidity.Size = New System.Drawing.Size(55, 41)
        Me.livingroomHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomHumidity.TabIndex = 62
        Me.livingroomHumidity.TabStop = False
        '
        'bathroomHUmidity
        '
        Me.bathroomHUmidity.BackColor = System.Drawing.Color.Transparent
        Me.bathroomHUmidity.Image = Global.Scanning.My.Resources.Resources.humidity
        Me.bathroomHUmidity.Location = New System.Drawing.Point(2, 102)
        Me.bathroomHUmidity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bathroomHUmidity.Name = "bathroomHUmidity"
        Me.bathroomHUmidity.Size = New System.Drawing.Size(55, 41)
        Me.bathroomHUmidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bathroomHUmidity.TabIndex = 63
        Me.bathroomHUmidity.TabStop = False
        '
        'kitchenHumidity
        '
        Me.kitchenHumidity.BackColor = System.Drawing.Color.Transparent
        Me.kitchenHumidity.Image = Global.Scanning.My.Resources.Resources.humidity
        Me.kitchenHumidity.Location = New System.Drawing.Point(2, 102)
        Me.kitchenHumidity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kitchenHumidity.Name = "kitchenHumidity"
        Me.kitchenHumidity.Size = New System.Drawing.Size(55, 41)
        Me.kitchenHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kitchenHumidity.TabIndex = 64
        Me.kitchenHumidity.TabStop = False
        '
        'bedroomHumidity
        '
        Me.bedroomHumidity.BackColor = System.Drawing.Color.Transparent
        Me.bedroomHumidity.Image = Global.Scanning.My.Resources.Resources.humidity
        Me.bedroomHumidity.Location = New System.Drawing.Point(2, 102)
        Me.bedroomHumidity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bedroomHumidity.Name = "bedroomHumidity"
        Me.bedroomHumidity.Size = New System.Drawing.Size(55, 41)
        Me.bedroomHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bedroomHumidity.TabIndex = 65
        Me.bedroomHumidity.TabStop = False
        '
        'EnvironmentMenu
        '
        Me.EnvironmentMenu.Location = New System.Drawing.Point(757, 37)
        Me.EnvironmentMenu.Name = "EnvironmentMenu"
        Me.EnvironmentMenu.Size = New System.Drawing.Size(276, 513)
        Me.EnvironmentMenu.TabIndex = 67
        '
        'WindowMenu
        '
        Me.WindowMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WindowMenu.Location = New System.Drawing.Point(111, 192)
        Me.WindowMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.WindowMenu.Name = "WindowMenu"
        Me.WindowMenu.Size = New System.Drawing.Size(540, 183)
        Me.WindowMenu.TabIndex = 60
        Me.WindowMenu.Visible = False
        '
        'exitRooms
        '
        Me.exitRooms.BackColor = System.Drawing.Color.Red
        Me.exitRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.exitRooms.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitRooms.Location = New System.Drawing.Point(687, 55)
        Me.exitRooms.Name = "exitRooms"
        Me.exitRooms.Size = New System.Drawing.Size(51, 45)
        Me.exitRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitRooms.TabIndex = 59
        Me.exitRooms.TabStop = False
        Me.exitRooms.Visible = False
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(252, 555)
        Me.MainTaskBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(499, 132)
        Me.MainTaskBar.TabIndex = 35
        '
        'LivingroomDoor
        '
        Me.LivingroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LivingroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomDoor.Location = New System.Drawing.Point(326, 238)
        Me.LivingroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomDoor.Name = "LivingroomDoor"
        Me.LivingroomDoor.Size = New System.Drawing.Size(5, 64)
        Me.LivingroomDoor.TabIndex = 33
        Me.LivingroomDoor.TabStop = False
        '
        'BathroomDoor
        '
        Me.BathroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BathroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BathroomDoor.Location = New System.Drawing.Point(410, 381)
        Me.BathroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BathroomDoor.Name = "BathroomDoor"
        Me.BathroomDoor.Size = New System.Drawing.Size(5, 64)
        Me.BathroomDoor.TabIndex = 32
        Me.BathroomDoor.TabStop = False
        '
        'KitchenDoor
        '
        Me.KitchenDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.KitchenDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KitchenDoor.Location = New System.Drawing.Point(326, 381)
        Me.KitchenDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KitchenDoor.Name = "KitchenDoor"
        Me.KitchenDoor.Size = New System.Drawing.Size(5, 64)
        Me.KitchenDoor.TabIndex = 31
        Me.KitchenDoor.TabStop = False
        '
        'BedroomDoor
        '
        Me.BedroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BedroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomDoor.Location = New System.Drawing.Point(503, 231)
        Me.BedroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(63, 5)
        Me.BedroomDoor.TabIndex = 30
        Me.BedroomDoor.TabStop = False
        '
        'LivingroomWindow2
        '
        Me.LivingroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow2.Location = New System.Drawing.Point(192, 34)
        Me.LivingroomWindow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomWindow2.Name = "LivingroomWindow2"
        Me.LivingroomWindow2.Size = New System.Drawing.Size(98, 16)
        Me.LivingroomWindow2.TabIndex = 28
        Me.LivingroomWindow2.TabStop = False
        Me.LivingroomWindow2.Tag = ""
        '
        'BedroomWindow1
        '
        Me.BedroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow1.Location = New System.Drawing.Point(364, 34)
        Me.BedroomWindow1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow1.Name = "BedroomWindow1"
        Me.BedroomWindow1.Size = New System.Drawing.Size(98, 16)
        Me.BedroomWindow1.TabIndex = 27
        Me.BedroomWindow1.TabStop = False
        Me.BedroomWindow1.Tag = ""
        '
        'BedroomWindow2
        '
        Me.BedroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow2.Location = New System.Drawing.Point(604, 34)
        Me.BedroomWindow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow2.Name = "BedroomWindow2"
        Me.BedroomWindow2.Size = New System.Drawing.Size(98, 16)
        Me.BedroomWindow2.TabIndex = 26
        Me.BedroomWindow2.TabStop = False
        Me.BedroomWindow2.Tag = ""
        '
        'FrontDoor
        '
        Me.FrontDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.FrontDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrontDoor.Location = New System.Drawing.Point(337, 548)
        Me.FrontDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FrontDoor.Name = "FrontDoor"
        Me.FrontDoor.Size = New System.Drawing.Size(63, 5)
        Me.FrontDoor.TabIndex = 23
        Me.FrontDoor.TabStop = False
        '
        'LivingroomWindow1
        '
        Me.LivingroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow1.Location = New System.Drawing.Point(31, 34)
        Me.LivingroomWindow1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomWindow1.Name = "LivingroomWindow1"
        Me.LivingroomWindow1.Size = New System.Drawing.Size(98, 16)
        Me.LivingroomWindow1.TabIndex = 22
        Me.LivingroomWindow1.TabStop = False
        Me.LivingroomWindow1.Tag = "5"
        '
        'Bathroom
        '
        Me.Bathroom.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Bathroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bathroom.Image = Global.Scanning.My.Resources.Resources.toilet
        Me.Bathroom.Location = New System.Drawing.Point(412, 311)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(339, 239)
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
        Me.Bedroom.Location = New System.Drawing.Point(326, 37)
        Me.Bedroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bedroom.Name = "Bedroom"
        Me.Bedroom.Size = New System.Drawing.Size(423, 196)
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
        Me.LivingRoom.Location = New System.Drawing.Point(12, 37)
        Me.LivingRoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingRoom.Name = "LivingRoom"
        Me.LivingRoom.Size = New System.Drawing.Size(317, 280)
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
        Me.Kitchen.Location = New System.Drawing.Point(12, 311)
        Me.Kitchen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Kitchen.Name = "Kitchen"
        Me.Kitchen.Size = New System.Drawing.Size(317, 239)
        Me.Kitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Kitchen.TabIndex = 18
        Me.Kitchen.TabStop = False
        Me.Kitchen.Tag = "0"
        '
        'UserApartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.EnvironmentMenu)
        Me.Controls.Add(Me.bedroomHumidity)
        Me.Controls.Add(Me.kitchenHumidity)
        Me.Controls.Add(Me.bathroomHUmidity)
        Me.Controls.Add(Me.livingroomHumidity)
        Me.Controls.Add(Me.WindowMenu)
        Me.Controls.Add(Me.exitRooms)
        Me.Controls.Add(Me.LivingroomWindow2Shutters)
        Me.Controls.Add(Me.BedroomWindow1Shutters)
        Me.Controls.Add(Me.BedroomWindow2Shutters)
        Me.Controls.Add(Me.LivingroomWindow1Shutters)
        Me.Controls.Add(Me.livingroomFan)
        Me.Controls.Add(Me.kitchenFan)
        Me.Controls.Add(Me.bathroomFan)
        Me.Controls.Add(Me.bedroomFan)
        Me.Controls.Add(Me.bathroomLight)
        Me.Controls.Add(Me.bedroomLight)
        Me.Controls.Add(Me.kitchenLight)
        Me.Controls.Add(Me.livingroomLight)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UserApartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserApartment"
        CType(Me.LivingroomWindow2Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomHumidity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomHUmidity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenHumidity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomHumidity, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents apartment As PictureBox
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents Kitchen As SubOptions
    Friend WithEvents LivingRoom As SubOptions
    Friend WithEvents Bedroom As SubOptions
    Friend WithEvents Bathroom As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents FrontDoor As SubOptions
    Friend WithEvents BedroomWindow2 As SubOptions
    Friend WithEvents BedroomWindow1 As SubOptions
    Friend WithEvents LivingroomWindow2 As SubOptions
    Friend WithEvents BedroomDoor As SubOptions
    Friend WithEvents KitchenDoor As SubOptions
    Friend WithEvents BathroomDoor As SubOptions
    Friend WithEvents LivingroomDoor As SubOptions
    Friend WithEvents MainTaskBar As MainTaskBar
    Friend WithEvents livingroomLight As PictureBox
    Friend WithEvents kitchenLight As PictureBox
    Friend WithEvents bedroomLight As PictureBox
    Friend WithEvents bathroomLight As PictureBox
    Friend WithEvents bedroomFan As PictureBox
    Friend WithEvents bathroomFan As PictureBox
    Friend WithEvents kitchenFan As PictureBox
    Friend WithEvents livingroomFan As PictureBox
    Friend WithEvents LivingroomWindow1Shutters As PictureBox
    Friend WithEvents BedroomWindow2Shutters As PictureBox
    Friend WithEvents BedroomWindow1Shutters As PictureBox
    Friend WithEvents LivingroomWindow2Shutters As PictureBox
    Friend WithEvents exitRooms As SubOptions
    Friend WithEvents WindowMenu As WindowMenu
    Friend WithEvents livingroomHumidity As PictureBox
    Friend WithEvents bathroomHUmidity As PictureBox
    Friend WithEvents kitchenHumidity As PictureBox
    Friend WithEvents bedroomHumidity As PictureBox
    Friend WithEvents EnvironmentMenu As EnvironmentMenu
End Class
