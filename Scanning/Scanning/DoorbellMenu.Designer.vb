<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoorbellMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoorbellMenu))
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenDoor = New Scanning.SubOptions()
        Me.CloseDoor = New Scanning.SubOptions()
        Me.DoorbellIcon = New System.Windows.Forms.PictureBox()
        CType(Me.OpenDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorbellIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'OpenDoor
        '
        Me.OpenDoor.BackColor = System.Drawing.SystemColors.Control
        Me.OpenDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OpenDoor.Image = CType(resources.GetObject("OpenDoor.Image"), System.Drawing.Image)
        Me.OpenDoor.Location = New System.Drawing.Point(280, 15)
        Me.OpenDoor.Margin = New System.Windows.Forms.Padding(4)
        Me.OpenDoor.Name = "OpenDoor"
        Me.OpenDoor.Size = New System.Drawing.Size(196, 175)
        Me.OpenDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OpenDoor.TabIndex = 2
        Me.OpenDoor.TabStop = False
        '
        'CloseDoor
        '
        Me.CloseDoor.BackColor = System.Drawing.SystemColors.Control
        Me.CloseDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseDoor.Image = Global.Scanning.My.Resources.Resources.rejectVisitor
        Me.CloseDoor.Location = New System.Drawing.Point(484, 15)
        Me.CloseDoor.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseDoor.Name = "CloseDoor"
        Me.CloseDoor.Size = New System.Drawing.Size(199, 176)
        Me.CloseDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseDoor.TabIndex = 1
        Me.CloseDoor.TabStop = False
        '
        'DoorbellIcon
        '
        Me.DoorbellIcon.BackColor = System.Drawing.Color.Olive
        Me.DoorbellIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DoorbellIcon.Image = Global.Scanning.My.Resources.Resources.doorbell
        Me.DoorbellIcon.Location = New System.Drawing.Point(16, 15)
        Me.DoorbellIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.DoorbellIcon.Name = "DoorbellIcon"
        Me.DoorbellIcon.Size = New System.Drawing.Size(195, 175)
        Me.DoorbellIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DoorbellIcon.TabIndex = 0
        Me.DoorbellIcon.TabStop = False
        '
        'DoorbellMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(699, 204)
        Me.Controls.Add(Me.OpenDoor)
        Me.Controls.Add(Me.CloseDoor)
        Me.Controls.Add(Me.DoorbellIcon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DoorbellMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRIEND NAME is at your door"
        CType(Me.OpenDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoorbellIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DoorbellIcon As PictureBox
    Friend WithEvents CloseDoor As SubOptions
    Friend WithEvents OpenDoor As SubOptions
    Friend WithEvents ScanningTimer As Timer
End Class
