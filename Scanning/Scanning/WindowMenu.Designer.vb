<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowMenu
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
        Me.blindControl = New Scanning.SubOptions()
        Me.windowControl = New Scanning.SubOptions()
        Me.MenuBarOption = New Scanning.SubOptions()
        CType(Me.blindControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.windowControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blindControl
        '
        Me.blindControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.blindControl.Image = Global.Scanning.My.Resources.Resources.BlindsOpen
        Me.blindControl.Location = New System.Drawing.Point(287, 23)
        Me.blindControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.blindControl.Name = "blindControl"
        Me.blindControl.Size = New System.Drawing.Size(200, 123)
        Me.blindControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blindControl.TabIndex = 4
        Me.blindControl.TabStop = False
        Me.blindControl.Tag = "open"
        '
        'windowControl
        '
        Me.windowControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.windowControl.Image = Global.Scanning.My.Resources.Resources.WindowOpen
        Me.windowControl.Location = New System.Drawing.Point(42, 23)
        Me.windowControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.windowControl.Name = "windowControl"
        Me.windowControl.Size = New System.Drawing.Size(200, 123)
        Me.windowControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.windowControl.TabIndex = 2
        Me.windowControl.TabStop = False
        Me.windowControl.Tag = "open"
        '
        'MenuBarOption
        '
        Me.MenuBarOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuBarOption.Location = New System.Drawing.Point(0, 0)
        Me.MenuBarOption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MenuBarOption.Name = "MenuBarOption"
        Me.MenuBarOption.Size = New System.Drawing.Size(544, 186)
        Me.MenuBarOption.TabIndex = 0
        Me.MenuBarOption.TabStop = False
        '
        'WindowMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.blindControl)
        Me.Controls.Add(Me.windowControl)
        Me.Controls.Add(Me.MenuBarOption)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "WindowMenu"
        Me.Size = New System.Drawing.Size(540, 183)
        CType(Me.blindControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.windowControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuBarOption As SubOptions
    Friend WithEvents windowControl As SubOptions
    Friend WithEvents blindControl As SubOptions
End Class
