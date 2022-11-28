<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeveloperConsole
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DoorbellButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(6, 30)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(304, 42)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Testing Console"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Use the buttons on this form to simulate"
        '
        'DoorbellButton
        '
        Me.DoorbellButton.Location = New System.Drawing.Point(86, 182)
        Me.DoorbellButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DoorbellButton.Name = "DoorbellButton"
        Me.DoorbellButton.Size = New System.Drawing.Size(145, 28)
        Me.DoorbellButton.TabIndex = 2
        Me.DoorbellButton.Text = "Ring Doorbell"
        Me.DoorbellButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "things such as the doorbell ringing"
        '
        'DeveloperConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 382)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DoorbellButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DeveloperConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DeveloperConsole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DoorbellButton As Button
    Friend WithEvents Label2 As Label
End Class
