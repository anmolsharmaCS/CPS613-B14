<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TopMenu1 = New Scanning.TopMenu()
        Me.SubMenu1 = New Scanning.SubMenu()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SubMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.Scanning.My.Resources.Resources.help
        Me.Button1.Location = New System.Drawing.Point(7, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Scanning.My.Resources.Resources.musicnote
        Me.Button2.Location = New System.Drawing.Point(7, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 75)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Scanning.My.Resources.Resources.movie__1_
        Me.Button3.Location = New System.Drawing.Point(7, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 75)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TopMenu1
        '
        Me.TopMenu1.Location = New System.Drawing.Point(572, 24)
        Me.TopMenu1.Name = "TopMenu1"
        Me.TopMenu1.ScanningInterval = 1000
        Me.TopMenu1.Size = New System.Drawing.Size(36, 36)
        Me.TopMenu1.TabIndex = 3
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.Button6)
        Me.SubMenu1.Controls.Add(Me.Button5)
        Me.SubMenu1.Controls.Add(Me.Button4)
        Me.SubMenu1.Controls.Add(Me.Button1)
        Me.SubMenu1.Controls.Add(Me.Button3)
        Me.SubMenu1.Controls.Add(Me.Button2)
        Me.SubMenu1.Location = New System.Drawing.Point(43, 39)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(228, 416)
        Me.SubMenu1.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.Image = Global.Scanning.My.Resources.Resources.volumecontrol
        Me.Button6.Location = New System.Drawing.Point(110, 165)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 75)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Scanning.My.Resources.Resources.home
        Me.Button5.Location = New System.Drawing.Point(7, 327)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 75)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Scanning.My.Resources.Resources.television
        Me.Button4.Location = New System.Drawing.Point(7, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 75)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Scanning.My.Resources.Resources.background2
        Me.ClientSize = New System.Drawing.Size(596, 498)
        Me.Controls.Add(Me.SubMenu1)
        Me.Controls.Add(Me.TopMenu1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SubMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TopMenu1 As TopMenu
    Friend WithEvents SubMenu1 As SubMenu
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
End Class
