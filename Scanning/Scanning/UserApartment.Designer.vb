<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserApartment
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
        Me.Kitchen = New System.Windows.Forms.PictureBox()
        Me.LivingRoom = New System.Windows.Forms.PictureBox()
        Me.Bathroom = New System.Windows.Forms.PictureBox()
        Me.BedRoom = New System.Windows.Forms.PictureBox()
        Me.apartment = New System.Windows.Forms.PictureBox()
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kitchen
        '
        Me.Kitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Kitchen.Image = Global.Scanning.My.Resources.Resources.kitchen
        Me.Kitchen.Location = New System.Drawing.Point(24, 233)
        Me.Kitchen.Name = "Kitchen"
        Me.Kitchen.Size = New System.Drawing.Size(308, 189)
        Me.Kitchen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Kitchen.TabIndex = 3
        Me.Kitchen.TabStop = False
        '
        'LivingRoom
        '
        Me.LivingRoom.BackgroundImage = Global.Scanning.My.Resources.Resources.woodFloor
        Me.LivingRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LivingRoom.Image = Global.Scanning.My.Resources.Resources.livingRoom
        Me.LivingRoom.Location = New System.Drawing.Point(24, 23)
        Me.LivingRoom.Name = "LivingRoom"
        Me.LivingRoom.Size = New System.Drawing.Size(308, 214)
        Me.LivingRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LivingRoom.TabIndex = 2
        Me.LivingRoom.TabStop = False
        '
        'Bathroom
        '
        Me.Bathroom.BackColor = System.Drawing.Color.SteelBlue
        Me.Bathroom.BackgroundImage = Global.Scanning.My.Resources.Resources.bathroomFloor
        Me.Bathroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bathroom.Image = Global.Scanning.My.Resources.Resources.toilet__1_
        Me.Bathroom.Location = New System.Drawing.Point(330, 23)
        Me.Bathroom.Name = "Bathroom"
        Me.Bathroom.Size = New System.Drawing.Size(416, 162)
        Me.Bathroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bathroom.TabIndex = 1
        Me.Bathroom.TabStop = False
        '
        'BedRoom
        '
        Me.BedRoom.BackgroundImage = Global.Scanning.My.Resources.Resources.woodFloor
        Me.BedRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BedRoom.Image = Global.Scanning.My.Resources.Resources.bed__1_
        Me.BedRoom.Location = New System.Drawing.Point(420, 257)
        Me.BedRoom.Name = "BedRoom"
        Me.BedRoom.Size = New System.Drawing.Size(326, 165)
        Me.BedRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BedRoom.TabIndex = 0
        Me.BedRoom.TabStop = False
        '
        'apartment
        '
        Me.apartment.BackColor = System.Drawing.Color.DarkGray
        Me.apartment.Location = New System.Drawing.Point(16, 15)
        Me.apartment.Name = "apartment"
        Me.apartment.Size = New System.Drawing.Size(738, 417)
        Me.apartment.TabIndex = 5
        Me.apartment.TabStop = False
        '
        'UserApartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Kitchen)
        Me.Controls.Add(Me.LivingRoom)
        Me.Controls.Add(Me.Bathroom)
        Me.Controls.Add(Me.BedRoom)
        Me.Controls.Add(Me.apartment)
        Me.Name = "UserApartment"
        Me.Text = "UserApartment"
        CType(Me.Kitchen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivingRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bathroom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BedRoom As PictureBox
    Friend WithEvents Bathroom As PictureBox
    Friend WithEvents LivingRoom As PictureBox
    Friend WithEvents Kitchen As PictureBox
    Friend WithEvents apartment As PictureBox
End Class
