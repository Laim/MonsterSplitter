<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.rtbAboutInfo = New System.Windows.Forms.RichTextBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(240, 63)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(124, 30)
        Me.lblAppName.TabIndex = 1
        Me.lblAppName.Text = "{AppName}"
        '
        'lblAppVersion
        '
        Me.lblAppVersion.AutoSize = True
        Me.lblAppVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAppVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppVersion.Location = New System.Drawing.Point(240, 93)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(134, 30)
        Me.lblAppVersion.TabIndex = 2
        Me.lblAppVersion.Text = "Version {Ver}"
        '
        'rtbAboutInfo
        '
        Me.rtbAboutInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbAboutInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtbAboutInfo.HideSelection = False
        Me.rtbAboutInfo.Location = New System.Drawing.Point(12, 192)
        Me.rtbAboutInfo.Name = "rtbAboutInfo"
        Me.rtbAboutInfo.ReadOnly = True
        Me.rtbAboutInfo.Size = New System.Drawing.Size(429, 145)
        Me.rtbAboutInfo.TabIndex = 3
        Me.rtbAboutInfo.Text = ""
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.BackgroundImage = Global.MonsterSplitter.My.Resources.Resources.monstersplit_170
        Me.pbLogo.InitialImage = Nothing
        Me.pbLogo.Location = New System.Drawing.Point(12, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(170, 170)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!)
        Me.lblCopyright.Location = New System.Drawing.Point(168, 343)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(167, 13)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "{Copyright}. All rights reserved."
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 361)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.rtbAboutInfo)
        Me.Controls.Add(Me.lblAppVersion)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.pbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About {AppName}"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblAppVersion As Label
    Friend WithEvents rtbAboutInfo As RichTextBox
    Friend WithEvents lblCopyright As Label
End Class
