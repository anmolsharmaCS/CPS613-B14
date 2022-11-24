<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FloorHallways
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Home = New System.Windows.Forms.PictureBox()
        Me.ElevatorDoorLine = New System.Windows.Forms.PictureBox()
        Me.Floor = New System.Windows.Forms.PictureBox()
        Me.exitApartments = New Scanning.SubOptions()
        Me.door06 = New Scanning.SubOptions()
        Me.door05 = New Scanning.SubOptions()
        Me.door04 = New Scanning.SubOptions()
        Me.door03 = New Scanning.SubOptions()
        Me.door02 = New Scanning.SubOptions()
        Me.door01 = New Scanning.SubOptions()
        Me.Elevator = New Scanning.SubOptions()
        Me.Apartment06 = New Scanning.SubOptions()
        Me.Apartment05 = New Scanning.SubOptions()
        Me.Apartment04 = New Scanning.SubOptions()
        Me.Apartment03 = New Scanning.SubOptions()
        Me.Apartment02 = New Scanning.SubOptions()
        Me.Apartment01 = New Scanning.SubOptions()
        Me.MainTaskBar = New Scanning.MainTaskBar()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElevatorDoorLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitApartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Elevator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apartment06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apartment05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apartment04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apartment03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apartment02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Apartment01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 35)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 35)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(619, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 35)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 35)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(369, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 35)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(619, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 35)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "000"
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.DarkKhaki
        Me.Home.Image = Global.Scanning.My.Resources.Resources.house
        Me.Home.Location = New System.Drawing.Point(359, 71)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(82, 81)
        Me.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Home.TabIndex = 44
        Me.Home.TabStop = False
        '
        'ElevatorDoorLine
        '
        Me.ElevatorDoorLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ElevatorDoorLine.Location = New System.Drawing.Point(31, 226)
        Me.ElevatorDoorLine.Name = "ElevatorDoorLine"
        Me.ElevatorDoorLine.Size = New System.Drawing.Size(39, 1)
        Me.ElevatorDoorLine.TabIndex = 37
        Me.ElevatorDoorLine.TabStop = False
        '
        'Floor
        '
        Me.Floor.BackColor = System.Drawing.Color.BurlyWood
        Me.Floor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Floor.Location = New System.Drawing.Point(31, 21)
        Me.Floor.Name = "Floor"
        Me.Floor.Size = New System.Drawing.Size(738, 417)
        Me.Floor.TabIndex = 6
        Me.Floor.TabStop = False
        '
        'exitApartments
        '
        Me.exitApartments.BackColor = System.Drawing.Color.Red
        Me.exitApartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exitApartments.Image = Global.Scanning.My.Resources.Resources._exit
        Me.exitApartments.Location = New System.Drawing.Point(739, 12)
        Me.exitApartments.Name = "exitApartments"
        Me.exitApartments.Size = New System.Drawing.Size(51, 45)
        Me.exitApartments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitApartments.TabIndex = 46
        Me.exitApartments.TabStop = False
        Me.exitApartments.Visible = False
        '
        'door06
        '
        Me.door06.BackColor = System.Drawing.Color.SaddleBrown
        Me.door06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.door06.Location = New System.Drawing.Point(628, 265)
        Me.door06.Name = "door06"
        Me.door06.Size = New System.Drawing.Size(54, 7)
        Me.door06.TabIndex = 36
        Me.door06.TabStop = False
        '
        'door05
        '
        Me.door05.BackColor = System.Drawing.Color.SaddleBrown
        Me.door05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.door05.Location = New System.Drawing.Point(373, 265)
        Me.door05.Name = "door05"
        Me.door05.Size = New System.Drawing.Size(54, 7)
        Me.door05.TabIndex = 35
        Me.door05.TabStop = False
        '
        'door04
        '
        Me.door04.BackColor = System.Drawing.Color.SaddleBrown
        Me.door04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.door04.Location = New System.Drawing.Point(127, 265)
        Me.door04.Name = "door04"
        Me.door04.Size = New System.Drawing.Size(54, 7)
        Me.door04.TabIndex = 34
        Me.door04.TabStop = False
        '
        'door03
        '
        Me.door03.BackColor = System.Drawing.Color.SaddleBrown
        Me.door03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.door03.Location = New System.Drawing.Point(628, 189)
        Me.door03.Name = "door03"
        Me.door03.Size = New System.Drawing.Size(54, 7)
        Me.door03.TabIndex = 33
        Me.door03.TabStop = False
        '
        'door02
        '
        Me.door02.BackColor = System.Drawing.Color.SaddleBrown
        Me.door02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.door02.Location = New System.Drawing.Point(373, 187)
        Me.door02.Name = "door02"
        Me.door02.Size = New System.Drawing.Size(54, 7)
        Me.door02.TabIndex = 32
        Me.door02.TabStop = False
        '
        'door01
        '
        Me.door01.BackColor = System.Drawing.Color.SaddleBrown
        Me.door01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.door01.Location = New System.Drawing.Point(127, 187)
        Me.door01.Name = "door01"
        Me.door01.Size = New System.Drawing.Size(54, 7)
        Me.door01.TabIndex = 31
        Me.door01.TabStop = False
        '
        'Elevator
        '
        Me.Elevator.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Elevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Elevator.Location = New System.Drawing.Point(31, 189)
        Me.Elevator.Name = "Elevator"
        Me.Elevator.Size = New System.Drawing.Size(39, 81)
        Me.Elevator.TabIndex = 13
        Me.Elevator.TabStop = False
        '
        'Apartment06
        '
        Me.Apartment06.BackColor = System.Drawing.Color.DarkKhaki
        Me.Apartment06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apartment06.Location = New System.Drawing.Point(523, 268)
        Me.Apartment06.Name = "Apartment06"
        Me.Apartment06.Size = New System.Drawing.Size(246, 170)
        Me.Apartment06.TabIndex = 12
        Me.Apartment06.TabStop = False
        '
        'Apartment05
        '
        Me.Apartment05.BackColor = System.Drawing.Color.DarkKhaki
        Me.Apartment05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apartment05.Location = New System.Drawing.Point(277, 268)
        Me.Apartment05.Name = "Apartment05"
        Me.Apartment05.Size = New System.Drawing.Size(246, 170)
        Me.Apartment05.TabIndex = 11
        Me.Apartment05.TabStop = False
        '
        'Apartment04
        '
        Me.Apartment04.BackColor = System.Drawing.Color.DarkKhaki
        Me.Apartment04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apartment04.Location = New System.Drawing.Point(31, 268)
        Me.Apartment04.Name = "Apartment04"
        Me.Apartment04.Size = New System.Drawing.Size(246, 170)
        Me.Apartment04.TabIndex = 10
        Me.Apartment04.TabStop = False
        '
        'Apartment03
        '
        Me.Apartment03.BackColor = System.Drawing.Color.DarkKhaki
        Me.Apartment03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apartment03.Location = New System.Drawing.Point(523, 21)
        Me.Apartment03.Name = "Apartment03"
        Me.Apartment03.Size = New System.Drawing.Size(246, 170)
        Me.Apartment03.TabIndex = 9
        Me.Apartment03.TabStop = False
        '
        'Apartment02
        '
        Me.Apartment02.BackColor = System.Drawing.Color.DarkKhaki
        Me.Apartment02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apartment02.Location = New System.Drawing.Point(277, 21)
        Me.Apartment02.Name = "Apartment02"
        Me.Apartment02.Size = New System.Drawing.Size(246, 170)
        Me.Apartment02.TabIndex = 8
        Me.Apartment02.TabStop = False
        '
        'Apartment01
        '
        Me.Apartment01.BackColor = System.Drawing.Color.DarkKhaki
        Me.Apartment01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Apartment01.Location = New System.Drawing.Point(31, 21)
        Me.Apartment01.Name = "Apartment01"
        Me.Apartment01.Size = New System.Drawing.Size(246, 170)
        Me.Apartment01.TabIndex = 7
        Me.Apartment01.TabStop = False
        '
        'MainTaskBar
        '
        Me.MainTaskBar.Location = New System.Drawing.Point(167, 457)
        Me.MainTaskBar.Name = "MainTaskBar"
        Me.MainTaskBar.Size = New System.Drawing.Size(602, 132)
        Me.MainTaskBar.TabIndex = 47
        '
        'FloorHallways
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.MainTaskBar)
        Me.Controls.Add(Me.exitApartments)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ElevatorDoorLine)
        Me.Controls.Add(Me.door06)
        Me.Controls.Add(Me.door05)
        Me.Controls.Add(Me.door04)
        Me.Controls.Add(Me.door03)
        Me.Controls.Add(Me.door02)
        Me.Controls.Add(Me.door01)
        Me.Controls.Add(Me.Elevator)
        Me.Controls.Add(Me.Apartment06)
        Me.Controls.Add(Me.Apartment05)
        Me.Controls.Add(Me.Apartment04)
        Me.Controls.Add(Me.Apartment03)
        Me.Controls.Add(Me.Apartment02)
        Me.Controls.Add(Me.Apartment01)
        Me.Controls.Add(Me.Floor)
        Me.KeyPreview = True
        Me.Name = "FloorHallways"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FloorHallways"
        CType(Me.Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElevatorDoorLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitApartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Elevator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apartment06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apartment05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apartment04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apartment03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apartment02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Apartment01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Floor As PictureBox
    Friend WithEvents Apartment01 As SubOptions
    Friend WithEvents Apartment02 As SubOptions
    Friend WithEvents Apartment03 As SubOptions
    Friend WithEvents Apartment04 As SubOptions
    Friend WithEvents Apartment05 As SubOptions
    Friend WithEvents Apartment06 As SubOptions
    Friend WithEvents Elevator As SubOptions
    Friend WithEvents door01 As SubOptions
    Friend WithEvents door02 As SubOptions
    Friend WithEvents door03 As SubOptions
    Friend WithEvents door04 As SubOptions
    Friend WithEvents door05 As SubOptions
    Friend WithEvents door06 As SubOptions
    Friend WithEvents ElevatorDoorLine As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Home As PictureBox
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents exitApartments As SubOptions
    Friend WithEvents MainTaskBar As MainTaskBar
End Class
