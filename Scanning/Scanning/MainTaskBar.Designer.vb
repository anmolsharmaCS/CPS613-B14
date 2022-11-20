<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainTaskBar
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
        Me.SubOptions1 = New Scanning.SubOptions()
        Me.SubOptions4 = New Scanning.SubOptions()
        Me.SubOptions3 = New Scanning.SubOptions()
        Me.SubOptions2 = New Scanning.SubOptions()
        Me.MenuBarOption = New Scanning.SubOptions()
        CType(Me.SubOptions1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubOptions4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubOptions3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubOptions2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubOptions1
        '
        Me.SubOptions1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions1.Image = Global.Scanning.My.Resources.Resources.back_button
        Me.SubOptions1.Location = New System.Drawing.Point(26, 16)
        Me.SubOptions1.Name = "SubOptions1"
        Me.SubOptions1.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions1.TabIndex = 6
        Me.SubOptions1.TabStop = False
        '
        'SubOptions4
        '
        Me.SubOptions4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions4.Image = Global.Scanning.My.Resources.Resources.navigation
        Me.SubOptions4.Location = New System.Drawing.Point(419, 16)
        Me.SubOptions4.Name = "SubOptions4"
        Me.SubOptions4.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions4.TabIndex = 4
        Me.SubOptions4.TabStop = False
        '
        'SubOptions3
        '
        Me.SubOptions3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions3.Image = Global.Scanning.My.Resources.Resources.assisstant
        Me.SubOptions3.Location = New System.Drawing.Point(153, 16)
        Me.SubOptions3.Name = "SubOptions3"
        Me.SubOptions3.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions3.TabIndex = 3
        Me.SubOptions3.TabStop = False
        '
        'SubOptions2
        '
        Me.SubOptions2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubOptions2.Image = Global.Scanning.My.Resources.Resources.communication
        Me.SubOptions2.Location = New System.Drawing.Point(286, 16)
        Me.SubOptions2.Name = "SubOptions2"
        Me.SubOptions2.Size = New System.Drawing.Size(100, 100)
        Me.SubOptions2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubOptions2.TabIndex = 2
        Me.SubOptions2.TabStop = False
        '
        'MenuBarOption
        '
        Me.MenuBarOption.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuBarOption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MenuBarOption.Location = New System.Drawing.Point(-98, 0)
        Me.MenuBarOption.Name = "MenuBarOption"
        Me.MenuBarOption.Size = New System.Drawing.Size(638, 132)
        Me.MenuBarOption.TabIndex = 5
        Me.MenuBarOption.TabStop = False
        '
        'MainTaskBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubOptions1)
        Me.Controls.Add(Me.SubOptions4)
        Me.Controls.Add(Me.SubOptions3)
        Me.Controls.Add(Me.SubOptions2)
        Me.Controls.Add(Me.MenuBarOption)
        Me.Name = "MainTaskBar"
        Me.Size = New System.Drawing.Size(540, 132)
        CType(Me.SubOptions1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubOptions4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubOptions3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubOptions2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubOptions2 As SubOptions
    Friend WithEvents SubOptions3 As SubOptions
    Friend WithEvents SubOptions4 As SubOptions
    Friend WithEvents MenuBarOption As SubOptions
    Friend WithEvents SubOptions1 As SubOptions
End Class
