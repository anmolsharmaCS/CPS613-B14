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
        Me.Back = New Scanning.SubOptions()
        Me.Navigate = New Scanning.SubOptions()
        Me.Assistance = New Scanning.SubOptions()
        Me.Communicate = New Scanning.SubOptions()
        Me.MenuBarOption = New Scanning.SubOptions()
        CType(Me.Back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Navigate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Assistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Communicate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Back.Image = Global.Scanning.My.Resources.Resources.back_button
        Me.Back.Location = New System.Drawing.Point(26, 16)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 100)
        Me.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Back.TabIndex = 6
        Me.Back.TabStop = False
        '
        'Navigate
        '
        Me.Navigate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Navigate.Image = Global.Scanning.My.Resources.Resources.navigation
        Me.Navigate.Location = New System.Drawing.Point(419, 16)
        Me.Navigate.Name = "Navigate"
        Me.Navigate.Size = New System.Drawing.Size(100, 100)
        Me.Navigate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Navigate.TabIndex = 4
        Me.Navigate.TabStop = False
        '
        'Assistance
        '
        Me.Assistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Assistance.Image = Global.Scanning.My.Resources.Resources.assisstant
        Me.Assistance.Location = New System.Drawing.Point(153, 16)
        Me.Assistance.Name = "Assistance"
        Me.Assistance.Size = New System.Drawing.Size(100, 100)
        Me.Assistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Assistance.TabIndex = 3
        Me.Assistance.TabStop = False
        '
        'Communicate
        '
        Me.Communicate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Communicate.Image = Global.Scanning.My.Resources.Resources.communication
        Me.Communicate.Location = New System.Drawing.Point(286, 16)
        Me.Communicate.Name = "Communicate"
        Me.Communicate.Size = New System.Drawing.Size(100, 100)
        Me.Communicate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Communicate.TabIndex = 2
        Me.Communicate.TabStop = False
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
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Navigate)
        Me.Controls.Add(Me.Assistance)
        Me.Controls.Add(Me.Communicate)
        Me.Controls.Add(Me.MenuBarOption)
        Me.Name = "MainTaskBar"
        Me.Size = New System.Drawing.Size(540, 132)
        CType(Me.Back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Navigate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Assistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Communicate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBarOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Communicate As SubOptions
    Friend WithEvents Assistance As SubOptions
    Friend WithEvents Navigate As SubOptions
    Friend WithEvents MenuBarOption As SubOptions
    Friend WithEvents Back As SubOptions
End Class
