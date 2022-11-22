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
        Me.OpenBlinds = New Scanning.SubOptions()
        Me.CloseBlinds = New Scanning.SubOptions()
        Me.OpenWindows = New Scanning.SubOptions()
        Me.CloseWindows = New Scanning.SubOptions()
        Me.MenuBarOption = New Scanning.SubOptions()
        CType(Me.OpenBlinds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseBlinds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenBlinds
        '
        Me.OpenBlinds.Image = Global.Scanning.My.Resources.Resources.BlindsOpen
        Me.OpenBlinds.Location = New System.Drawing.Point(214, 160)
        Me.OpenBlinds.Name = "OpenBlinds"
        Me.OpenBlinds.Size = New System.Drawing.Size(150, 100)
        Me.OpenBlinds.TabIndex = 4
        Me.OpenBlinds.TabStop = False
        '
        'CloseBlinds
        '
        Me.CloseBlinds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseBlinds.Image = Global.Scanning.My.Resources.Resources.BlindsClosed
        Me.CloseBlinds.Location = New System.Drawing.Point(44, 160)
        Me.CloseBlinds.Name = "CloseBlinds"
        Me.CloseBlinds.Size = New System.Drawing.Size(150, 100)
        Me.CloseBlinds.TabIndex = 3
        Me.CloseBlinds.TabStop = False
        '
        'OpenWindows
        '
        Me.OpenWindows.Image = Global.Scanning.My.Resources.Resources.WindowOpen
        Me.OpenWindows.Location = New System.Drawing.Point(214, 35)
        Me.OpenWindows.Name = "OpenWindows"
        Me.OpenWindows.Size = New System.Drawing.Size(150, 100)
        Me.OpenWindows.TabIndex = 2
        Me.OpenWindows.TabStop = False
        '
        'CloseWindows
        '
        Me.CloseWindows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseWindows.Image = Global.Scanning.My.Resources.Resources.WindowClosed
        Me.CloseWindows.Location = New System.Drawing.Point(44, 35)
        Me.CloseWindows.Name = "CloseWindows"
        Me.CloseWindows.Size = New System.Drawing.Size(150, 100)
        Me.CloseWindows.TabIndex = 1
        Me.CloseWindows.TabStop = False
        '
        'MenuBarOption
        '
        Me.MenuBarOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuBarOption.Location = New System.Drawing.Point(0, 0)
        Me.MenuBarOption.Name = "MenuBarOption"
        Me.MenuBarOption.Size = New System.Drawing.Size(408, 294)
        Me.MenuBarOption.TabIndex = 0
        Me.MenuBarOption.TabStop = False
        '
        'WindowMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OpenBlinds)
        Me.Controls.Add(Me.CloseBlinds)
        Me.Controls.Add(Me.OpenWindows)
        Me.Controls.Add(Me.CloseWindows)
        Me.Controls.Add(Me.MenuBarOption)
        Me.Name = "WindowMenu"
        Me.Size = New System.Drawing.Size(408, 294)
        CType(Me.OpenBlinds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseBlinds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenWindows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuBarOption As SubOptions
    Friend WithEvents CloseWindows As SubOptions
    Friend WithEvents OpenWindows As SubOptions
    Friend WithEvents CloseBlinds As SubOptions
    Friend WithEvents OpenBlinds As SubOptions
End Class
