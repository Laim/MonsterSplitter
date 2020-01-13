<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAppNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitAppNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecommendNewFeaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportAnIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbCSVPath = New System.Windows.Forms.TextBox()
        Me.lblCSVPath = New System.Windows.Forms.Label()
        Me.btnSplitCSV = New System.Windows.Forms.Button()
        Me.nudLinesPerCSV = New System.Windows.Forms.NumericUpDown()
        Me.lblLinesPerCSV = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblConsole = New System.Windows.Forms.Label()
        Me.lbConsole = New System.Windows.Forms.ListBox()
        Me.DatabaseDataSet = New MonsterSplitter.MonsterSplitterDataSet()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsDatabaseConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsDatabaseConnectionType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cbCSVHeader = New System.Windows.Forms.CheckBox()
        Me.MonsterSplitterDataSet1 = New MonsterSplitter.MonsterSplitterDataSet()
        Me.MenuStrip.SuspendLayout()
        CType(Me.nudLinesPerCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.MonsterSplitterDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'AppToolStripMenuItem
        '
        Me.AppToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutAppNameToolStripMenuItem, Me.ToolStripSeparator1, Me.PreferencesToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitAppNameToolStripMenuItem})
        Me.AppToolStripMenuItem.Name = "AppToolStripMenuItem"
        Me.AppToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AppToolStripMenuItem.Text = "{AppName}"
        '
        'AboutAppNameToolStripMenuItem
        '
        Me.AboutAppNameToolStripMenuItem.Name = "AboutAppNameToolStripMenuItem"
        Me.AboutAppNameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutAppNameToolStripMenuItem.Text = "About {AppName}"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Enabled = False
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'QuitAppNameToolStripMenuItem
        '
        Me.QuitAppNameToolStripMenuItem.Name = "QuitAppNameToolStripMenuItem"
        Me.QuitAppNameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitAppNameToolStripMenuItem.Text = "Quit {AppName}"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SplitHistoryToolStripMenuItem})
        Me.ViewToolStripMenuItem.Enabled = False
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SplitHistoryToolStripMenuItem
        '
        Me.SplitHistoryToolStripMenuItem.Name = "SplitHistoryToolStripMenuItem"
        Me.SplitHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SplitHistoryToolStripMenuItem.Text = "Split History"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator3, Me.RecommendNewFeaturesToolStripMenuItem, Me.ReportAnIssueToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Enabled = False
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(213, 6)
        '
        'RecommendNewFeaturesToolStripMenuItem
        '
        Me.RecommendNewFeaturesToolStripMenuItem.Name = "RecommendNewFeaturesToolStripMenuItem"
        Me.RecommendNewFeaturesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RecommendNewFeaturesToolStripMenuItem.Text = "Recommend New Features"
        '
        'ReportAnIssueToolStripMenuItem
        '
        Me.ReportAnIssueToolStripMenuItem.Name = "ReportAnIssueToolStripMenuItem"
        Me.ReportAnIssueToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ReportAnIssueToolStripMenuItem.Text = "Report an Issue"
        '
        'tbCSVPath
        '
        Me.tbCSVPath.Location = New System.Drawing.Point(15, 52)
        Me.tbCSVPath.Name = "tbCSVPath"
        Me.tbCSVPath.Size = New System.Drawing.Size(276, 20)
        Me.tbCSVPath.TabIndex = 1
        Me.tbCSVPath.Text = "C:\Users\Laim.McKenzie\Downloads\Book1.csv"
        '
        'lblCSVPath
        '
        Me.lblCSVPath.AutoSize = True
        Me.lblCSVPath.Location = New System.Drawing.Point(12, 36)
        Me.lblCSVPath.Name = "lblCSVPath"
        Me.lblCSVPath.Size = New System.Drawing.Size(53, 13)
        Me.lblCSVPath.TabIndex = 2
        Me.lblCSVPath.Text = "CSV Path"
        '
        'btnSplitCSV
        '
        Me.btnSplitCSV.Location = New System.Drawing.Point(378, 50)
        Me.btnSplitCSV.Name = "btnSplitCSV"
        Me.btnSplitCSV.Size = New System.Drawing.Size(75, 23)
        Me.btnSplitCSV.TabIndex = 3
        Me.btnSplitCSV.Text = "Split"
        Me.btnSplitCSV.UseVisualStyleBackColor = True
        '
        'nudLinesPerCSV
        '
        Me.nudLinesPerCSV.Location = New System.Drawing.Point(15, 99)
        Me.nudLinesPerCSV.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudLinesPerCSV.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudLinesPerCSV.Name = "nudLinesPerCSV"
        Me.nudLinesPerCSV.Size = New System.Drawing.Size(120, 20)
        Me.nudLinesPerCSV.TabIndex = 4
        Me.nudLinesPerCSV.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'lblLinesPerCSV
        '
        Me.lblLinesPerCSV.AutoSize = True
        Me.lblLinesPerCSV.Location = New System.Drawing.Point(12, 83)
        Me.lblLinesPerCSV.Name = "lblLinesPerCSV"
        Me.lblLinesPerCSV.Size = New System.Drawing.Size(69, 13)
        Me.lblLinesPerCSV.TabIndex = 5
        Me.lblLinesPerCSV.Text = "Lines per File"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(297, 50)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lblConsole
        '
        Me.lblConsole.AutoSize = True
        Me.lblConsole.Location = New System.Drawing.Point(12, 129)
        Me.lblConsole.Name = "lblConsole"
        Me.lblConsole.Size = New System.Drawing.Size(45, 13)
        Me.lblConsole.TabIndex = 8
        Me.lblConsole.Text = "Console"
        '
        'lbConsole
        '
        Me.lbConsole.FormattingEnabled = True
        Me.lbConsole.Location = New System.Drawing.Point(12, 146)
        Me.lbConsole.Name = "lbConsole"
        Me.lbConsole.Size = New System.Drawing.Size(441, 69)
        Me.lbConsole.TabIndex = 9
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "MonsterSplitterDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDatabaseConnection, Me.tsDatabaseConnectionType})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 227)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(462, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsDatabaseConnection
        '
        Me.tsDatabaseConnection.Enabled = False
        Me.tsDatabaseConnection.Name = "tsDatabaseConnection"
        Me.tsDatabaseConnection.Size = New System.Drawing.Size(123, 17)
        Me.tsDatabaseConnection.Text = "Database Connection:"
        Me.tsDatabaseConnection.Visible = False
        '
        'tsDatabaseConnectionType
        '
        Me.tsDatabaseConnectionType.Enabled = False
        Me.tsDatabaseConnectionType.Name = "tsDatabaseConnectionType"
        Me.tsDatabaseConnectionType.Size = New System.Drawing.Size(40, 17)
        Me.tsDatabaseConnectionType.Text = "{Type}"
        Me.tsDatabaseConnectionType.Visible = False
        '
        'cbCSVHeader
        '
        Me.cbCSVHeader.AutoSize = True
        Me.cbCSVHeader.Location = New System.Drawing.Point(141, 100)
        Me.cbCSVHeader.Name = "cbCSVHeader"
        Me.cbCSVHeader.Size = New System.Drawing.Size(162, 17)
        Me.cbCSVHeader.TabIndex = 11
        Me.cbCSVHeader.Text = "Include headers on every file"
        Me.cbCSVHeader.UseVisualStyleBackColor = True
        '
        'MonsterSplitterDataSet1
        '
        Me.MonsterSplitterDataSet1.DataSetName = "MonsterSplitterDataSet"
        Me.MonsterSplitterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 249)
        Me.Controls.Add(Me.cbCSVHeader)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbConsole)
        Me.Controls.Add(Me.lblConsole)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblLinesPerCSV)
        Me.Controls.Add(Me.nudLinesPerCSV)
        Me.Controls.Add(Me.btnSplitCSV)
        Me.Controls.Add(Me.lblCSVPath)
        Me.Controls.Add(Me.tbCSVPath)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.nudLinesPerCSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.MonsterSplitterDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents AppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAppNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitAppNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RecommendNewFeaturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportAnIssueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbCSVPath As TextBox
    Friend WithEvents lblCSVPath As Label
    Friend WithEvents btnSplitCSV As Button
    Friend WithEvents nudLinesPerCSV As NumericUpDown
    Friend WithEvents lblLinesPerCSV As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblConsole As Label
    Friend WithEvents lbConsole As ListBox
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseDataSet As MonsterSplitterDataSet
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsDatabaseConnection As ToolStripStatusLabel
    Friend WithEvents tsDatabaseConnectionType As ToolStripStatusLabel
    Friend WithEvents SplitHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbCSVHeader As CheckBox
    Friend WithEvents MonsterSplitterDataSet1 As MonsterSplitterDataSet
End Class
