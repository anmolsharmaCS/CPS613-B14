﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tempLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BedroomWindow3Shutters = New System.Windows.Forms.PictureBox()
        Me.BathroomWindowShutters = New System.Windows.Forms.PictureBox()
        Me.LivingroomWindow2Shutters = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow1Shutters = New System.Windows.Forms.PictureBox()
        Me.BedroomWindow2Shutters = New System.Windows.Forms.PictureBox()
        Me.LivingroomWindow1Shutters = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.livingroomFan = New System.Windows.Forms.PictureBox()
        Me.kitchenFan = New System.Windows.Forms.PictureBox()
        Me.bathroomFan = New System.Windows.Forms.PictureBox()
        Me.bedroomFan = New System.Windows.Forms.PictureBox()
        Me.bathroomLight = New System.Windows.Forms.PictureBox()
        Me.bedroomLight = New System.Windows.Forms.PictureBox()
        Me.kitchenLight = New System.Windows.Forms.PictureBox()
        Me.livingroomLight = New System.Windows.Forms.PictureBox()
        Me.apartment = New System.Windows.Forms.PictureBox()
        Me.downArrow = New Scanning.SubOptions()
        Me.upArrow = New Scanning.SubOptions()
        Me.tempOption = New Scanning.SubOptions()
        Me.WindowMenu = New Scanning.WindowMenu()
        Me.MainTaskBar = New Scanning.MainTaskBar()
        Me.LivingroomDoor = New Scanning.SubOptions()
        Me.BathroomDoor = New Scanning.SubOptions()
        Me.KitchenDoor = New Scanning.SubOptions()
        Me.BedroomDoor = New Scanning.SubOptions()
        Me.BathroomWindow = New Scanning.SubOptions()
        Me.LivingroomWindow2 = New Scanning.SubOptions()
        Me.BedroomWindow1 = New Scanning.SubOptions()
        Me.BedroomWindow2 = New Scanning.SubOptions()
        Me.BedroomWindow3 = New Scanning.SubOptions()
        Me.FrontDoor = New Scanning.SubOptions()
        Me.LivingroomWindow1 = New Scanning.SubOptions()
        Me.Bathroom = New Scanning.SubOptions()
        Me.Bedroom = New Scanning.SubOptions()
        Me.LivingRoom = New Scanning.SubOptions()
        Me.Kitchen = New Scanning.SubOptions()
        CType(Me.BedroomWindow3Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomWindowShutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow1Shutters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bathroomLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bedroomLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kitchenLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.livingroomLight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.downArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KitchenDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tempLabel
        '
        Me.tempLabel.AutoSize = True
        Me.tempLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempLabel.Location = New System.Drawing.Point(876, 182)
        Me.tempLabel.Name = "tempLabel"
        Me.tempLabel.Size = New System.Drawing.Size(48, 32)
        Me.tempLabel.TabIndex = 46
        Me.tempLabel.Text = "20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(919, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 32)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "°C"
        '
        'BedroomWindow3Shutters
        '
        Me.BedroomWindow3Shutters.Image = Global.Scanning.My.Resources.Resources.openWindowSideways
        Me.BedroomWindow3Shutters.Location = New System.Drawing.Point(798, 57)
        Me.BedroomWindow3Shutters.Name = "BedroomWindow3Shutters"
        Me.BedroomWindow3Shutters.Size = New System.Drawing.Size(28, 137)
        Me.BedroomWindow3Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BedroomWindow3Shutters.TabIndex = 57
        Me.BedroomWindow3Shutters.TabStop = False
        '
        'BathroomWindowShutters
        '
        Me.BathroomWindowShutters.Image = Global.Scanning.My.Resources.Resources.openWindowSideways
        Me.BathroomWindowShutters.Location = New System.Drawing.Point(795, 299)
        Me.BathroomWindowShutters.Name = "BathroomWindowShutters"
        Me.BathroomWindowShutters.Size = New System.Drawing.Size(28, 137)
        Me.BathroomWindowShutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BathroomWindowShutters.TabIndex = 56
        Me.BathroomWindowShutters.TabStop = False
        '
        'LivingroomWindow2Shutters
        '
        Me.LivingroomWindow2Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.LivingroomWindow2Shutters.Location = New System.Drawing.Point(207, 9)
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
        Me.BedroomWindow1Shutters.Location = New System.Drawing.Point(381, 9)
        Me.BedroomWindow1Shutters.Name = "BedroomWindow1Shutters"
        Me.BedroomWindow1Shutters.Size = New System.Drawing.Size(137, 28)
        Me.BedroomWindow1Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BedroomWindow1Shutters.TabIndex = 53
        Me.BedroomWindow1Shutters.TabStop = False
        '
        'BedroomWindow2Shutters
        '
        Me.BedroomWindow2Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.BedroomWindow2Shutters.Location = New System.Drawing.Point(621, 9)
        Me.BedroomWindow2Shutters.Name = "BedroomWindow2Shutters"
        Me.BedroomWindow2Shutters.Size = New System.Drawing.Size(137, 28)
        Me.BedroomWindow2Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BedroomWindow2Shutters.TabIndex = 52
        Me.BedroomWindow2Shutters.TabStop = False
        '
        'LivingroomWindow1Shutters
        '
        Me.LivingroomWindow1Shutters.Image = Global.Scanning.My.Resources.Resources.openwindow
        Me.LivingroomWindow1Shutters.Location = New System.Drawing.Point(50, 9)
        Me.LivingroomWindow1Shutters.Name = "LivingroomWindow1Shutters"
        Me.LivingroomWindow1Shutters.Size = New System.Drawing.Size(137, 28)
        Me.LivingroomWindow1Shutters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LivingroomWindow1Shutters.TabIndex = 51
        Me.LivingroomWindow1Shutters.TabStop = False
        Me.LivingroomWindow1Shutters.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.Image = Global.Scanning.My.Resources.Resources.temp
        Me.PictureBox1.Location = New System.Drawing.Point(884, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'livingroomFan
        '
        Me.livingroomFan.BackColor = System.Drawing.Color.Transparent
        Me.livingroomFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.livingroomFan.Location = New System.Drawing.Point(2, 69)
        Me.livingroomFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.livingroomFan.Name = "livingroomFan"
        Me.livingroomFan.Size = New System.Drawing.Size(71, 53)
        Me.livingroomFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomFan.TabIndex = 43
        Me.livingroomFan.TabStop = False
        '
        'kitchenFan
        '
        Me.kitchenFan.BackColor = System.Drawing.Color.Transparent
        Me.kitchenFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.kitchenFan.Location = New System.Drawing.Point(2, 69)
        Me.kitchenFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kitchenFan.Name = "kitchenFan"
        Me.kitchenFan.Size = New System.Drawing.Size(71, 53)
        Me.kitchenFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.kitchenFan.TabIndex = 42
        Me.kitchenFan.TabStop = False
        '
        'bathroomFan
        '
        Me.bathroomFan.BackColor = System.Drawing.Color.Transparent
        Me.bathroomFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.bathroomFan.Location = New System.Drawing.Point(2, 69)
        Me.bathroomFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bathroomFan.Name = "bathroomFan"
        Me.bathroomFan.Size = New System.Drawing.Size(71, 53)
        Me.bathroomFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bathroomFan.TabIndex = 41
        Me.bathroomFan.TabStop = False
        '
        'bedroomFan
        '
        Me.bedroomFan.BackColor = System.Drawing.Color.Transparent
        Me.bedroomFan.Image = Global.Scanning.My.Resources.Resources.fanOff
        Me.bedroomFan.Location = New System.Drawing.Point(2, 69)
        Me.bedroomFan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bedroomFan.Name = "bedroomFan"
        Me.bedroomFan.Size = New System.Drawing.Size(71, 53)
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
        Me.bathroomLight.Size = New System.Drawing.Size(71, 53)
        Me.bathroomLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bathroomLight.TabIndex = 39
        Me.bathroomLight.TabStop = False
        '
        'bedroomLight
        '
        Me.bedroomLight.BackColor = System.Drawing.Color.Transparent
        Me.bedroomLight.Image = Global.Scanning.My.Resources.Resources.bulbLit
        Me.bedroomLight.Location = New System.Drawing.Point(2, 12)
        Me.bedroomLight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bedroomLight.Name = "bedroomLight"
        Me.bedroomLight.Size = New System.Drawing.Size(71, 53)
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
        Me.kitchenLight.Size = New System.Drawing.Size(71, 53)
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
        Me.livingroomLight.Size = New System.Drawing.Size(71, 53)
        Me.livingroomLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.livingroomLight.TabIndex = 36
        Me.livingroomLight.TabStop = False
        '
        'apartment
        '
        Me.apartment.BackColor = System.Drawing.Color.SandyBrown
        Me.apartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apartment.Location = New System.Drawing.Point(50, 40)
        Me.apartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.apartment.Name = "apartment"
        Me.apartment.Size = New System.Drawing.Size(738, 417)
        Me.apartment.TabIndex = 5
        Me.apartment.TabStop = False
        '
        'downArrow
        '
        Me.downArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.downArrow.Image = Global.Scanning.My.Resources.Resources.downarrow
        Me.downArrow.Location = New System.Drawing.Point(886, 230)
        Me.downArrow.Name = "downArrow"
        Me.downArrow.Size = New System.Drawing.Size(66, 50)
        Me.downArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.downArrow.TabIndex = 49
        Me.downArrow.TabStop = False
        '
        'upArrow
        '
        Me.upArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.upArrow.Image = Global.Scanning.My.Resources.Resources.uparrow
        Me.upArrow.Location = New System.Drawing.Point(886, 123)
        Me.upArrow.Name = "upArrow"
        Me.upArrow.Size = New System.Drawing.Size(66, 50)
        Me.upArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.upArrow.TabIndex = 48
        Me.upArrow.TabStop = False
        '
        'tempOption
        '
        Me.tempOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.tempOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tempOption.Location = New System.Drawing.Point(852, 33)
        Me.tempOption.Name = "tempOption"
        Me.tempOption.Size = New System.Drawing.Size(135, 262)
        Me.tempOption.TabIndex = 45
        Me.tempOption.TabStop = False
        '
        'WindowMenu
        '
        Me.WindowMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WindowMenu.Location = New System.Drawing.Point(132, 75)
        Me.WindowMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.WindowMenu.Name = "WindowMenu"
        Me.WindowMenu.Size = New System.Drawing.Size(543, 184)
        Me.WindowMenu.TabIndex = 44
        Me.WindowMenu.Visible = False
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(111, 473)
        Me.MainTaskBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(677, 132)
        Me.MainTaskBar.TabIndex = 35
        '
        'LivingroomDoor
        '
        Me.LivingroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.LivingroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomDoor.Location = New System.Drawing.Point(364, 215)
        Me.LivingroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingroomDoor.Name = "LivingroomDoor"
        Me.LivingroomDoor.Size = New System.Drawing.Size(15, 64)
        Me.LivingroomDoor.TabIndex = 33
        Me.LivingroomDoor.TabStop = False
        '
        'BathroomDoor
        '
        Me.BathroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BathroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BathroomDoor.Location = New System.Drawing.Point(439, 345)
        Me.BathroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BathroomDoor.Name = "BathroomDoor"
        Me.BathroomDoor.Size = New System.Drawing.Size(15, 64)
        Me.BathroomDoor.TabIndex = 32
        Me.BathroomDoor.TabStop = False
        '
        'KitchenDoor
        '
        Me.KitchenDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.KitchenDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KitchenDoor.Location = New System.Drawing.Point(364, 345)
        Me.KitchenDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KitchenDoor.Name = "KitchenDoor"
        Me.KitchenDoor.Size = New System.Drawing.Size(15, 64)
        Me.KitchenDoor.TabIndex = 31
        Me.KitchenDoor.TabStop = False
        '
        'BedroomDoor
        '
        Me.BedroomDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.BedroomDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomDoor.Location = New System.Drawing.Point(540, 215)
        Me.BedroomDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomDoor.Name = "BedroomDoor"
        Me.BedroomDoor.Size = New System.Drawing.Size(63, 16)
        Me.BedroomDoor.TabIndex = 30
        Me.BedroomDoor.TabStop = False
        '
        'BathroomWindow
        '
        Me.BathroomWindow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BathroomWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BathroomWindow.Location = New System.Drawing.Point(782, 325)
        Me.BathroomWindow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BathroomWindow.Name = "BathroomWindow"
        Me.BathroomWindow.Size = New System.Drawing.Size(15, 98)
        Me.BathroomWindow.TabIndex = 29
        Me.BathroomWindow.TabStop = False
        Me.BathroomWindow.Tag = ""
        '
        'LivingroomWindow2
        '
        Me.LivingroomWindow2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow2.Location = New System.Drawing.Point(230, 37)
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
        Me.BedroomWindow1.Location = New System.Drawing.Point(402, 37)
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
        Me.BedroomWindow2.Location = New System.Drawing.Point(642, 37)
        Me.BedroomWindow2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow2.Name = "BedroomWindow2"
        Me.BedroomWindow2.Size = New System.Drawing.Size(98, 16)
        Me.BedroomWindow2.TabIndex = 26
        Me.BedroomWindow2.TabStop = False
        Me.BedroomWindow2.Tag = ""
        '
        'BedroomWindow3
        '
        Me.BedroomWindow3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BedroomWindow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BedroomWindow3.Location = New System.Drawing.Point(782, 75)
        Me.BedroomWindow3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomWindow3.Name = "BedroomWindow3"
        Me.BedroomWindow3.Size = New System.Drawing.Size(15, 98)
        Me.BedroomWindow3.TabIndex = 24
        Me.BedroomWindow3.TabStop = False
        Me.BedroomWindow3.Tag = ""
        '
        'FrontDoor
        '
        Me.FrontDoor.BackColor = System.Drawing.Color.SaddleBrown
        Me.FrontDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrontDoor.Location = New System.Drawing.Point(372, 452)
        Me.FrontDoor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FrontDoor.Name = "FrontDoor"
        Me.FrontDoor.Size = New System.Drawing.Size(63, 16)
        Me.FrontDoor.TabIndex = 23
        Me.FrontDoor.TabStop = False
        '
        'LivingroomWindow1
        '
        Me.LivingroomWindow1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LivingroomWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LivingroomWindow1.Location = New System.Drawing.Point(69, 37)
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
        Me.Bathroom.Location = New System.Drawing.Point(450, 285)
        Me.Bathroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Bedroom.Location = New System.Drawing.Point(364, 40)
        Me.Bedroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.LivingRoom.Location = New System.Drawing.Point(50, 40)
        Me.LivingRoom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LivingRoom.Name = "LivingRoom"
        Me.LivingRoom.Size = New System.Drawing.Size(317, 240)
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
        Me.Kitchen.Location = New System.Drawing.Point(50, 279)
        Me.Kitchen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Kitchen.Name = "Kitchen"
        Me.Kitchen.Size = New System.Drawing.Size(317, 179)
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
        Me.Controls.Add(Me.BedroomWindow3Shutters)
        Me.Controls.Add(Me.BathroomWindowShutters)
        Me.Controls.Add(Me.LivingroomWindow2Shutters)
        Me.Controls.Add(Me.BedroomWindow1Shutters)
        Me.Controls.Add(Me.BedroomWindow2Shutters)
        Me.Controls.Add(Me.LivingroomWindow1Shutters)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.downArrow)
        Me.Controls.Add(Me.upArrow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tempLabel)
        Me.Controls.Add(Me.tempOption)
        Me.Controls.Add(Me.WindowMenu)
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
        Me.Controls.Add(Me.BathroomWindow)
        Me.Controls.Add(Me.LivingroomWindow2)
        Me.Controls.Add(Me.BedroomWindow1)
        Me.Controls.Add(Me.BedroomWindow2)
        Me.Controls.Add(Me.BedroomWindow3)
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
        CType(Me.BedroomWindow3Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomWindowShutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow2Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1Shutters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bathroomLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bedroomLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kitchenLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.livingroomLight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.downArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KitchenDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingroomWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bedroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents apartment As PictureBox
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents Kitchen As SubOptions
    Friend WithEvents LivingRoom As SubOptions
    Friend WithEvents Bedroom As SubOptions
    Friend WithEvents Bathroom As SubOptions
    Friend WithEvents LivingroomWindow1 As SubOptions
    Friend WithEvents FrontDoor As SubOptions
    Friend WithEvents BedroomWindow3 As SubOptions
    Friend WithEvents BedroomWindow2 As SubOptions
    Friend WithEvents BedroomWindow1 As SubOptions
    Friend WithEvents LivingroomWindow2 As SubOptions
    Friend WithEvents BathroomWindow As SubOptions
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
    Friend WithEvents WindowMenu As WindowMenu
    Friend WithEvents tempOption As SubOptions
    Friend WithEvents tempLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents upArrow As SubOptions
    Friend WithEvents downArrow As SubOptions
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LivingroomWindow1Shutters As PictureBox
    Friend WithEvents BedroomWindow2Shutters As PictureBox
    Friend WithEvents BedroomWindow1Shutters As PictureBox
    Friend WithEvents LivingroomWindow2Shutters As PictureBox
    Friend WithEvents BathroomWindowShutters As PictureBox
    Friend WithEvents BedroomWindow3Shutters As PictureBox
End Class
