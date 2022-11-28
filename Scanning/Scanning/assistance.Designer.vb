<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assistance
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
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CallAgain = New Scanning.SubOptions()
        Me.CancelCall = New Scanning.SubOptions()
        Me.CallMenu = New Scanning.SubOptions()
        Me.ReturnToUrgency = New Scanning.SubOptions()
        Me.BedroomHelp = New Scanning.SubOptions()
        Me.BathroomHelp = New Scanning.SubOptions()
        Me.ReasonMenu = New Scanning.SubOptions()
        Me.CloseWindow = New Scanning.SubOptions()
        Me.MakeUrgentCall = New Scanning.SubOptions()
        Me.MakeCall = New Scanning.SubOptions()
        Me.UrgencyMenu = New Scanning.SubOptions()
        Me.AssistanceImage = New System.Windows.Forms.PictureBox()
        Me.AssistanceBackground = New System.Windows.Forms.PictureBox()
        CType(Me.CallAgain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CallMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnToUrgency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedroomHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BathroomHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReasonMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakeUrgentCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MakeCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UrgencyMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistanceImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistanceBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimerLabel.Font = New System.Drawing.Font("OCR A Extended", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.Location = New System.Drawing.Point(587, 286)
        Me.TimerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(169, 51)
        Me.TimerLabel.TabIndex = 4
        Me.TimerLabel.Text = "0 min"
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(661, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 50)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "seconds"
        Me.Label1.Visible = False
        '
        'CallAgain
        '
        Me.CallAgain.BackColor = System.Drawing.SystemColors.Control
        Me.CallAgain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CallAgain.Image = Global.Scanning.My.Resources.Resources.callAgainButton
        Me.CallAgain.Location = New System.Drawing.Point(460, 305)
        Me.CallAgain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAgain.Name = "CallAgain"
        Me.CallAgain.Size = New System.Drawing.Size(100, 100)
        Me.CallAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CallAgain.TabIndex = 16
        Me.CallAgain.TabStop = False
        '
        'CancelCall
        '
        Me.CancelCall.BackColor = System.Drawing.SystemColors.Control
        Me.CancelCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CancelCall.Image = Global.Scanning.My.Resources.Resources.cancelCall
        Me.CancelCall.Location = New System.Drawing.Point(345, 305)
        Me.CancelCall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelCall.Name = "CancelCall"
        Me.CancelCall.Size = New System.Drawing.Size(100, 100)
        Me.CancelCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CancelCall.TabIndex = 15
        Me.CancelCall.TabStop = False
        '
        'CallMenu
        '
        Me.CallMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CallMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CallMenu.Location = New System.Drawing.Point(331, 286)
        Me.CallMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallMenu.Name = "CallMenu"
        Me.CallMenu.Size = New System.Drawing.Size(249, 130)
        Me.CallMenu.TabIndex = 14
        Me.CallMenu.TabStop = False
        '
        'ReturnToUrgency
        '
        Me.ReturnToUrgency.BackColor = System.Drawing.SystemColors.Control
        Me.ReturnToUrgency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReturnToUrgency.Image = Global.Scanning.My.Resources.Resources.upArrowAssistance
        Me.ReturnToUrgency.Location = New System.Drawing.Point(576, 167)
        Me.ReturnToUrgency.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReturnToUrgency.Name = "ReturnToUrgency"
        Me.ReturnToUrgency.Size = New System.Drawing.Size(100, 100)
        Me.ReturnToUrgency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReturnToUrgency.TabIndex = 13
        Me.ReturnToUrgency.TabStop = False
        '
        'BedroomHelp
        '
        Me.BedroomHelp.BackColor = System.Drawing.SystemColors.Control
        Me.BedroomHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BedroomHelp.Image = Global.Scanning.My.Resources.Resources.bedButton
        Me.BedroomHelp.Location = New System.Drawing.Point(460, 167)
        Me.BedroomHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomHelp.Name = "BedroomHelp"
        Me.BedroomHelp.Size = New System.Drawing.Size(100, 100)
        Me.BedroomHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BedroomHelp.TabIndex = 12
        Me.BedroomHelp.TabStop = False
        '
        'BathroomHelp
        '
        Me.BathroomHelp.BackColor = System.Drawing.SystemColors.Control
        Me.BathroomHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BathroomHelp.Image = Global.Scanning.My.Resources.Resources.toiletButton
        Me.BathroomHelp.Location = New System.Drawing.Point(345, 167)
        Me.BathroomHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BathroomHelp.Name = "BathroomHelp"
        Me.BathroomHelp.Size = New System.Drawing.Size(100, 100)
        Me.BathroomHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BathroomHelp.TabIndex = 11
        Me.BathroomHelp.TabStop = False
        '
        'ReasonMenu
        '
        Me.ReasonMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ReasonMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReasonMenu.Location = New System.Drawing.Point(331, 151)
        Me.ReasonMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReasonMenu.Name = "ReasonMenu"
        Me.ReasonMenu.Size = New System.Drawing.Size(367, 130)
        Me.ReasonMenu.TabIndex = 9
        Me.ReasonMenu.TabStop = False
        '
        'CloseWindow
        '
        Me.CloseWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseWindow.Image = Global.Scanning.My.Resources.Resources.back_button
        Me.CloseWindow.Location = New System.Drawing.Point(576, 31)
        Me.CloseWindow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseWindow.Name = "CloseWindow"
        Me.CloseWindow.Size = New System.Drawing.Size(100, 100)
        Me.CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow.TabIndex = 8
        Me.CloseWindow.TabStop = False
        '
        'MakeUrgentCall
        '
        Me.MakeUrgentCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MakeUrgentCall.Image = Global.Scanning.My.Resources.Resources.urgentCall
        Me.MakeUrgentCall.Location = New System.Drawing.Point(460, 31)
        Me.MakeUrgentCall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MakeUrgentCall.Name = "MakeUrgentCall"
        Me.MakeUrgentCall.Size = New System.Drawing.Size(100, 100)
        Me.MakeUrgentCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MakeUrgentCall.TabIndex = 7
        Me.MakeUrgentCall.TabStop = False
        '
        'MakeCall
        '
        Me.MakeCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MakeCall.Image = Global.Scanning.My.Resources.Resources._call
        Me.MakeCall.Location = New System.Drawing.Point(345, 31)
        Me.MakeCall.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MakeCall.Name = "MakeCall"
        Me.MakeCall.Size = New System.Drawing.Size(100, 100)
        Me.MakeCall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MakeCall.TabIndex = 3
        Me.MakeCall.TabStop = False
        '
        'UrgencyMenu
        '
        Me.UrgencyMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UrgencyMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UrgencyMenu.Location = New System.Drawing.Point(331, 15)
        Me.UrgencyMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UrgencyMenu.Name = "UrgencyMenu"
        Me.UrgencyMenu.Size = New System.Drawing.Size(367, 130)
        Me.UrgencyMenu.TabIndex = 3
        Me.UrgencyMenu.TabStop = False
        '
        'AssistanceImage
        '
        Me.AssistanceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AssistanceImage.Image = Global.Scanning.My.Resources.Resources.assisstant
        Me.AssistanceImage.Location = New System.Drawing.Point(20, 15)
        Me.AssistanceImage.Margin = New System.Windows.Forms.Padding(4)
        Me.AssistanceImage.Name = "AssistanceImage"
        Me.AssistanceImage.Size = New System.Drawing.Size(303, 400)
        Me.AssistanceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AssistanceImage.TabIndex = 2
        Me.AssistanceImage.TabStop = False
        '
        'AssistanceBackground
        '
        Me.AssistanceBackground.BackColor = System.Drawing.Color.SandyBrown
        Me.AssistanceBackground.Location = New System.Drawing.Point(1, 2)
        Me.AssistanceBackground.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AssistanceBackground.Name = "AssistanceBackground"
        Me.AssistanceBackground.Size = New System.Drawing.Size(827, 430)
        Me.AssistanceBackground.TabIndex = 17
        Me.AssistanceBackground.TabStop = False
        '
        'Assistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 897)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CallAgain)
        Me.Controls.Add(Me.CancelCall)
        Me.Controls.Add(Me.CallMenu)
        Me.Controls.Add(Me.ReturnToUrgency)
        Me.Controls.Add(Me.BedroomHelp)
        Me.Controls.Add(Me.BathroomHelp)
        Me.Controls.Add(Me.ReasonMenu)
        Me.Controls.Add(Me.CloseWindow)
        Me.Controls.Add(Me.MakeUrgentCall)
        Me.Controls.Add(Me.MakeCall)
        Me.Controls.Add(Me.UrgencyMenu)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.AssistanceImage)
        Me.Controls.Add(Me.AssistanceBackground)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Assistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.CallAgain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CallMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnToUrgency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedroomHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BathroomHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReasonMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakeUrgentCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MakeCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UrgencyMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistanceImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistanceBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssistanceImage As PictureBox
    Friend WithEvents TimerLabel As Label
    Friend WithEvents ScanningTimer As Timer
    Friend WithEvents UrgencyMenu As SubOptions
    Friend WithEvents MakeCall As SubOptions
    Friend WithEvents MakeUrgentCall As SubOptions
    Friend WithEvents CloseWindow As SubOptions
    Friend WithEvents ReasonMenu As SubOptions
    Friend WithEvents BathroomHelp As SubOptions
    Friend WithEvents BedroomHelp As SubOptions
    Friend WithEvents ReturnToUrgency As SubOptions
    Friend WithEvents CallMenu As SubOptions
    Friend WithEvents CancelCall As SubOptions
    Friend WithEvents CallAgain As SubOptions
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AssistanceBackground As PictureBox
    Friend WithEvents Label1 As Label
End Class
