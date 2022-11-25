<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class waiting
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dot3 = New System.Windows.Forms.PictureBox()
        Me.dot2 = New System.Windows.Forms.PictureBox()
        Me.dot1 = New System.Windows.Forms.PictureBox()
        Me.ellipseTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dot3
        '
        Me.dot3.Image = Global.Scanning.My.Resources.Resources.ellipse
        Me.dot3.Location = New System.Drawing.Point(152, 10)
        Me.dot3.Name = "dot3"
        Me.dot3.Size = New System.Drawing.Size(50, 50)
        Me.dot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot3.TabIndex = 2
        Me.dot3.TabStop = False
        Me.dot3.Visible = False
        '
        'dot2
        '
        Me.dot2.Image = Global.Scanning.My.Resources.Resources.ellipse
        Me.dot2.Location = New System.Drawing.Point(81, 10)
        Me.dot2.Name = "dot2"
        Me.dot2.Size = New System.Drawing.Size(50, 50)
        Me.dot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot2.TabIndex = 3
        Me.dot2.TabStop = False
        Me.dot2.Visible = False
        '
        'dot1
        '
        Me.dot1.Image = Global.Scanning.My.Resources.Resources.ellipse
        Me.dot1.Location = New System.Drawing.Point(10, 10)
        Me.dot1.Name = "dot1"
        Me.dot1.Size = New System.Drawing.Size(50, 50)
        Me.dot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot1.TabIndex = 4
        Me.dot1.TabStop = False
        Me.dot1.Visible = False
        '
        'ellipseTimer
        '
        Me.ellipseTimer.Interval = 300
        '
        'waiting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dot1)
        Me.Controls.Add(Me.dot2)
        Me.Controls.Add(Me.dot3)
        Me.Name = "waiting"
        Me.Size = New System.Drawing.Size(213, 71)
        CType(Me.dot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dot3 As PictureBox
    Friend WithEvents dot2 As PictureBox
    Friend WithEvents dot1 As PictureBox
    Friend WithEvents ellipseTimer As Timer
End Class
