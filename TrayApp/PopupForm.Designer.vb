﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopupForm
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
        Me.httpLocalhost = New System.Windows.Forms.Button()
        Me.WSL = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'httpLocalhost
        '
        Me.httpLocalhost.Location = New System.Drawing.Point(13, 12)
        Me.httpLocalhost.Margin = New System.Windows.Forms.Padding(4)
        Me.httpLocalhost.Name = "httpLocalhost"
        Me.httpLocalhost.Size = New System.Drawing.Size(119, 28)
        Me.httpLocalhost.TabIndex = 1
        Me.httpLocalhost.Text = "http://localhost"
        Me.httpLocalhost.UseVisualStyleBackColor = True
        '
        'WSL
        '
        Me.WSL.Location = New System.Drawing.Point(140, 12)
        Me.WSL.Margin = New System.Windows.Forms.Padding(4)
        Me.WSL.Name = "WSL"
        Me.WSL.Size = New System.Drawing.Size(115, 28)
        Me.WSL.TabIndex = 2
        Me.WSL.Text = "Default Distro"
        Me.WSL.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PopupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 53)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WSL)
        Me.Controls.Add(Me.httpLocalhost)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apache2 Launcher Backend"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents httpLocalhost As System.Windows.Forms.Button
    Friend WithEvents WSL As Button
    Friend WithEvents Button1 As Button
End Class
