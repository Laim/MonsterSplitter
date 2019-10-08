<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.TCPreferences = New System.Windows.Forms.TabControl()
        Me.TPGeneral = New System.Windows.Forms.TabPage()
        Me.lblLogErrors = New System.Windows.Forms.Label()
        Me.lblTrackInfo = New System.Windows.Forms.Label()
        Me.cbLogErrors = New System.Windows.Forms.CheckBox()
        Me.cbTrack = New System.Windows.Forms.CheckBox()
        Me.TPSplitter = New System.Windows.Forms.TabPage()
        Me.lblSplitPathInfo = New System.Windows.Forms.Label()
        Me.btnSplitPathBrowse = New System.Windows.Forms.Button()
        Me.tbSplitPath = New System.Windows.Forms.TextBox()
        Me.lblSplitPath = New System.Windows.Forms.Label()
        Me.TCPreferences.SuspendLayout()
        Me.TPGeneral.SuspendLayout()
        Me.TPSplitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'TCPreferences
        '
        Me.TCPreferences.Controls.Add(Me.TPGeneral)
        Me.TCPreferences.Controls.Add(Me.TPSplitter)
        Me.TCPreferences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPreferences.Location = New System.Drawing.Point(0, 0)
        Me.TCPreferences.Name = "TCPreferences"
        Me.TCPreferences.SelectedIndex = 0
        Me.TCPreferences.Size = New System.Drawing.Size(475, 186)
        Me.TCPreferences.TabIndex = 0
        '
        'TPGeneral
        '
        Me.TPGeneral.Controls.Add(Me.lblLogErrors)
        Me.TPGeneral.Controls.Add(Me.lblTrackInfo)
        Me.TPGeneral.Controls.Add(Me.cbLogErrors)
        Me.TPGeneral.Controls.Add(Me.cbTrack)
        Me.TPGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TPGeneral.Name = "TPGeneral"
        Me.TPGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TPGeneral.Size = New System.Drawing.Size(467, 160)
        Me.TPGeneral.TabIndex = 0
        Me.TPGeneral.Text = "General"
        Me.TPGeneral.UseVisualStyleBackColor = True
        '
        'lblLogErrors
        '
        Me.lblLogErrors.AutoSize = True
        Me.lblLogErrors.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblLogErrors.Location = New System.Drawing.Point(35, 103)
        Me.lblLogErrors.Name = "lblLogErrors"
        Me.lblLogErrors.Size = New System.Drawing.Size(405, 26)
        Me.lblLogErrors.TabIndex = 3
        Me.lblLogErrors.Text = "Logging all errors may result in increased disk space, however will result in bet" &
    "ter and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "easier troubleshooting of issues.  Enabling this will store logs in the" &
    " Database."
        '
        'lblTrackInfo
        '
        Me.lblTrackInfo.AutoSize = True
        Me.lblTrackInfo.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblTrackInfo.Location = New System.Drawing.Point(35, 44)
        Me.lblTrackInfo.Name = "lblTrackInfo"
        Me.lblTrackInfo.Size = New System.Drawing.Size(401, 26)
        Me.lblTrackInfo.TabIndex = 2
        Me.lblTrackInfo.Text = "Tracking split files will store information about the files being split, such as " &
    "file name, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "size, date/time and line count."
        '
        'cbLogErrors
        '
        Me.cbLogErrors.AutoSize = True
        Me.cbLogErrors.Location = New System.Drawing.Point(38, 83)
        Me.cbLogErrors.Name = "cbLogErrors"
        Me.cbLogErrors.Size = New System.Drawing.Size(87, 17)
        Me.cbLogErrors.TabIndex = 1
        Me.cbLogErrors.Text = "Log all Errors"
        Me.cbLogErrors.UseVisualStyleBackColor = True
        '
        'cbTrack
        '
        Me.cbTrack.AutoSize = True
        Me.cbTrack.Location = New System.Drawing.Point(38, 24)
        Me.cbTrack.Name = "cbTrack"
        Me.cbTrack.Size = New System.Drawing.Size(101, 17)
        Me.cbTrack.TabIndex = 0
        Me.cbTrack.Text = "Track Split Files"
        Me.cbTrack.UseVisualStyleBackColor = True
        '
        'TPSplitter
        '
        Me.TPSplitter.Controls.Add(Me.lblSplitPathInfo)
        Me.TPSplitter.Controls.Add(Me.btnSplitPathBrowse)
        Me.TPSplitter.Controls.Add(Me.tbSplitPath)
        Me.TPSplitter.Controls.Add(Me.lblSplitPath)
        Me.TPSplitter.Location = New System.Drawing.Point(4, 22)
        Me.TPSplitter.Name = "TPSplitter"
        Me.TPSplitter.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSplitter.Size = New System.Drawing.Size(467, 160)
        Me.TPSplitter.TabIndex = 1
        Me.TPSplitter.Text = "Splitter"
        Me.TPSplitter.UseVisualStyleBackColor = True
        '
        'lblSplitPathInfo
        '
        Me.lblSplitPathInfo.AutoSize = True
        Me.lblSplitPathInfo.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblSplitPathInfo.Location = New System.Drawing.Point(38, 63)
        Me.lblSplitPathInfo.Name = "lblSplitPathInfo"
        Me.lblSplitPathInfo.Size = New System.Drawing.Size(368, 13)
        Me.lblSplitPathInfo.TabIndex = 3
        Me.lblSplitPathInfo.Text = "The Custom Split Path will overide the default path location for every file split" &
    "."
        '
        'btnSplitPathBrowse
        '
        Me.btnSplitPathBrowse.Location = New System.Drawing.Point(349, 38)
        Me.btnSplitPathBrowse.Name = "btnSplitPathBrowse"
        Me.btnSplitPathBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnSplitPathBrowse.TabIndex = 2
        Me.btnSplitPathBrowse.Text = "Browse"
        Me.btnSplitPathBrowse.UseVisualStyleBackColor = True
        '
        'tbSplitPath
        '
        Me.tbSplitPath.Location = New System.Drawing.Point(41, 40)
        Me.tbSplitPath.Name = "tbSplitPath"
        Me.tbSplitPath.Size = New System.Drawing.Size(302, 20)
        Me.tbSplitPath.TabIndex = 1
        Me.tbSplitPath.Text = "{directory}"
        '
        'lblSplitPath
        '
        Me.lblSplitPath.AutoSize = True
        Me.lblSplitPath.Location = New System.Drawing.Point(38, 24)
        Me.lblSplitPath.Name = "lblSplitPath"
        Me.lblSplitPath.Size = New System.Drawing.Size(90, 13)
        Me.lblSplitPath.TabIndex = 0
        Me.lblSplitPath.Text = "Custom Split Path"
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 186)
        Me.Controls.Add(Me.TCPreferences)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferences"
        Me.TCPreferences.ResumeLayout(False)
        Me.TPGeneral.ResumeLayout(False)
        Me.TPGeneral.PerformLayout()
        Me.TPSplitter.ResumeLayout(False)
        Me.TPSplitter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCPreferences As TabControl
    Friend WithEvents TPGeneral As TabPage
    Friend WithEvents TPSplitter As TabPage
    Friend WithEvents lblTrackInfo As Label
    Friend WithEvents cbLogErrors As CheckBox
    Friend WithEvents cbTrack As CheckBox
    Friend WithEvents lblLogErrors As Label
    Friend WithEvents btnSplitPathBrowse As Button
    Friend WithEvents tbSplitPath As TextBox
    Friend WithEvents lblSplitPath As Label
    Friend WithEvents lblSplitPathInfo As Label
End Class
