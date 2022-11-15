<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.TopMenu1 = New Scanning.TopMenu()
        Me.SubMenu1 = New Scanning.SubMenu()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SubMenu2 = New Scanning.SubMenu()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SubMenu1.SuspendLayout()
        Me.SubMenu2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopMenu1
        '
        Me.TopMenu1.Location = New System.Drawing.Point(752, 13)
        Me.TopMenu1.Name = "TopMenu1"
        Me.TopMenu1.ScanningInterval = 1000
        Me.TopMenu1.Size = New System.Drawing.Size(36, 36)
        Me.TopMenu1.TabIndex = 0
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.Button11)
        Me.SubMenu1.Controls.Add(Me.Button10)
        Me.SubMenu1.Controls.Add(Me.Button9)
        Me.SubMenu1.Controls.Add(Me.Button8)
        Me.SubMenu1.Location = New System.Drawing.Point(227, 33)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(448, 98)
        Me.SubMenu1.TabIndex = 1
        '
        'Button11
        '
        Me.Button11.Image = Global.Scanning.My.Resources.Resources.cancel
        Me.Button11.Location = New System.Drawing.Point(345, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(96, 86)
        Me.Button11.TabIndex = 3
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Image = Global.Scanning.My.Resources.Resources.CallAgain__1_
        Me.Button10.Location = New System.Drawing.Point(231, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(96, 86)
        Me.Button10.TabIndex = 2
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = Global.Scanning.My.Resources.Resources.notUrgent__1_
        Me.Button9.Location = New System.Drawing.Point(119, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 86)
        Me.Button9.TabIndex = 1
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Scanning.My.Resources.Resources.urgent__1_
        Me.Button8.Location = New System.Drawing.Point(3, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 86)
        Me.Button8.TabIndex = 0
        Me.Button8.UseVisualStyleBackColor = True
        '
        'SubMenu2
        '
        Me.SubMenu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu2.Controls.Add(Me.Button12)
        Me.SubMenu2.Controls.Add(Me.Button13)
        Me.SubMenu2.Controls.Add(Me.Button14)
        Me.SubMenu2.Location = New System.Drawing.Point(227, 137)
        Me.SubMenu2.Name = "SubMenu2"
        Me.SubMenu2.Size = New System.Drawing.Size(448, 92)
        Me.SubMenu2.TabIndex = 3
        '
        'Button12
        '
        Me.Button12.Image = Global.Scanning.My.Resources.Resources.transfer__1_
        Me.Button12.Location = New System.Drawing.Point(3, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(96, 86)
        Me.Button12.TabIndex = 0
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Image = Global.Scanning.My.Resources.Resources.bed__1_
        Me.Button13.Location = New System.Drawing.Point(119, 4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(96, 86)
        Me.Button13.TabIndex = 1
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Image = Global.Scanning.My.Resources.Resources.toilet__1_
        Me.Button14.Location = New System.Drawing.Point(231, 4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(96, 86)
        Me.Button14.TabIndex = 2
        Me.Button14.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Scanning.My.Resources.Resources.assisstant
        Me.PictureBox1.Location = New System.Drawing.Point(12, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 308)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Image = Global.Scanning.My.Resources.Resources.cancel
        Me.Button4.Location = New System.Drawing.Point(345, -2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 86)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Scanning.My.Resources.Resources.urgent__1_
        Me.Button1.Location = New System.Drawing.Point(-2, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 86)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button3
        '
        Me.Button3.Image = Global.Scanning.My.Resources.Resources.CallAgain__1_
        Me.Button3.Location = New System.Drawing.Point(228, -2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 86)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Scanning.My.Resources.Resources.notUrgent__1_
        Me.Button2.Location = New System.Drawing.Point(115, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 86)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Scanning.My.Resources.Resources.toilet__1_
        Me.Button7.Location = New System.Drawing.Point(228, -2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 86)
        Me.Button7.TabIndex = 2
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.Scanning.My.Resources.Resources.bed__1_
        Me.Button6.Location = New System.Drawing.Point(115, -2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 86)
        Me.Button6.TabIndex = 1
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Image = Global.Scanning.My.Resources.Resources.transfer__1_
        Me.Button5.Location = New System.Drawing.Point(-2, -2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 86)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Scanning.My.Resources.Resources.background2
        Me.ClientSize = New System.Drawing.Size(696, 348)
        Me.Controls.Add(Me.SubMenu1)
        Me.Controls.Add(Me.SubMenu2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TopMenu1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.SubMenu1.ResumeLayout(False)
        Me.SubMenu2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopMenu1 As TopMenu
    Friend WithEvents SubMenu1 As SubMenu
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SubMenu2 As SubMenu
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
End Class
