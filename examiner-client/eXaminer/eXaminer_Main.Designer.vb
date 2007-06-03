<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eXaminer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eXaminer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.RecentMenuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.File1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.File2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.File3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.File4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.File5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.OnlineHelpMenuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.IntegrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutAboutMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.TimeAllocation = New System.Windows.Forms.GroupBox
        Me.TimeAlloc = New NumericTextBox.TimeTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Que_Type = New System.Windows.Forms.GroupBox
        Me.YorN_RB = New System.Windows.Forms.RadioButton
        Me.TorF_RB = New System.Windows.Forms.RadioButton
        Me.MCMA_RB = New System.Windows.Forms.RadioButton
        Me.MCSA_RB = New System.Windows.Forms.RadioButton
        Me.FinB_RB = New System.Windows.Forms.RadioButton
        Me.Choice_no = New System.Windows.Forms.GroupBox
        Me.Choice = New System.Windows.Forms.ComboBox
        Me.Marks = New System.Windows.Forms.GroupBox
        Me.WAns = New NumericTextBox.NumericTextBox
        Me.CAns = New NumericTextBox.NumericTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ControlPanel = New System.Windows.Forms.Panel
        Me.PanelNext = New System.Windows.Forms.Button
        Me.PanelBack = New System.Windows.Forms.Button
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrayAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.TrayLoadExam = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.TrayShow = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.TrayExit = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DLoadConnection = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DLoadAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.EventLog1 = New System.Diagnostics.EventLog
        Me.StartPanel = New System.Windows.Forms.Panel
        Me.MainPanel = New System.Windows.Forms.Panel
        Me.Question_no = New System.Windows.Forms.Label
        Me.Next_1 = New System.Windows.Forms.Button
        Me.QuestionRText = New System.Windows.Forms.RichTextBox
        Me.ATB = New System.Windows.Forms.TextBox
        Me.PreviousQue = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BTB = New System.Windows.Forms.TextBox
        Me.Clear = New System.Windows.Forms.Button
        Me.CTB = New System.Windows.Forms.TextBox
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.DTB = New System.Windows.Forms.TextBox
        Me.ACB = New System.Windows.Forms.CheckBox
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.BCB = New System.Windows.Forms.CheckBox
        Me.ETB = New System.Windows.Forms.TextBox
        Me.CCB = New System.Windows.Forms.CheckBox
        Me.ARB = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.BRB = New System.Windows.Forms.RadioButton
        Me.DCB = New System.Windows.Forms.CheckBox
        Me.CRB = New System.Windows.Forms.RadioButton
        Me.Delete = New System.Windows.Forms.Button
        Me.FIB3 = New System.Windows.Forms.TextBox
        Me.DRB = New System.Windows.Forms.RadioButton
        Me.ECB = New System.Windows.Forms.CheckBox
        Me.FIB1 = New System.Windows.Forms.TextBox
        Me.ERB = New System.Windows.Forms.RadioButton
        Me.TRB = New System.Windows.Forms.RadioButton
        Me.FIB4 = New System.Windows.Forms.TextBox
        Me.FRB = New System.Windows.Forms.RadioButton
        Me.FIB5 = New System.Windows.Forms.TextBox
        Me.FIB2 = New System.Windows.Forms.TextBox
        Me.Blank = New System.Windows.Forms.Button
        Me.CurrQst = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Background_panel = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TimeAllocation.SuspendLayout()
        Me.Que_Type.SuspendLayout()
        Me.Choice_no.SuspendLayout()
        Me.Marks.SuspendLayout()
        Me.ControlPanel.SuspendLayout()
        Me.TrayMenu.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.Background_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditToolStripMenuItem, Me.AboutMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1000, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMenuFile, Me.OpenMenuFile, Me.SaveMenuFile, Me.SaveAsMenuFile, Me.CloseMenuFile, Me.ExitMenuFile, Me.ToolStripSeparator1, Me.RecentMenuFile})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(35, 20)
        Me.FileMenu.Text = "File"
        '
        'NewMenuFile
        '
        Me.NewMenuFile.Image = CType(resources.GetObject("NewMenuFile.Image"), System.Drawing.Image)
        Me.NewMenuFile.Name = "NewMenuFile"
        Me.NewMenuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.NewMenuFile.Text = "New "
        '
        'OpenMenuFile
        '
        Me.OpenMenuFile.Image = CType(resources.GetObject("OpenMenuFile.Image"), System.Drawing.Image)
        Me.OpenMenuFile.Name = "OpenMenuFile"
        Me.OpenMenuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.OpenMenuFile.Text = "Open"
        '
        'SaveMenuFile
        '
        Me.SaveMenuFile.Enabled = False
        Me.SaveMenuFile.Image = CType(resources.GetObject("SaveMenuFile.Image"), System.Drawing.Image)
        Me.SaveMenuFile.Name = "SaveMenuFile"
        Me.SaveMenuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.SaveMenuFile.Text = "Save"
        '
        'SaveAsMenuFile
        '
        Me.SaveAsMenuFile.Enabled = False
        Me.SaveAsMenuFile.Image = CType(resources.GetObject("SaveAsMenuFile.Image"), System.Drawing.Image)
        Me.SaveAsMenuFile.Name = "SaveAsMenuFile"
        Me.SaveAsMenuFile.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.SaveAsMenuFile.Text = "Save As"
        '
        'CloseMenuFile
        '
        Me.CloseMenuFile.Enabled = False
        Me.CloseMenuFile.Image = CType(resources.GetObject("CloseMenuFile.Image"), System.Drawing.Image)
        Me.CloseMenuFile.Name = "CloseMenuFile"
        Me.CloseMenuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CloseMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.CloseMenuFile.Text = "Close"
        '
        'ExitMenuFile
        '
        Me.ExitMenuFile.Name = "ExitMenuFile"
        Me.ExitMenuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.ExitMenuFile.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'RecentMenuFile
        '
        Me.RecentMenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File1ToolStripMenuItem, Me.File2ToolStripMenuItem, Me.File3ToolStripMenuItem, Me.File4ToolStripMenuItem, Me.File5ToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.RecentMenuFile.Enabled = False
        Me.RecentMenuFile.Name = "RecentMenuFile"
        Me.RecentMenuFile.Size = New System.Drawing.Size(192, 22)
        Me.RecentMenuFile.Text = "Recent Files"
        '
        'File1ToolStripMenuItem
        '
        Me.File1ToolStripMenuItem.Name = "File1ToolStripMenuItem"
        Me.File1ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.File1ToolStripMenuItem.Text = "File1"
        '
        'File2ToolStripMenuItem
        '
        Me.File2ToolStripMenuItem.Name = "File2ToolStripMenuItem"
        Me.File2ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.File2ToolStripMenuItem.Text = "File2"
        '
        'File3ToolStripMenuItem
        '
        Me.File3ToolStripMenuItem.Name = "File3ToolStripMenuItem"
        Me.File3ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.File3ToolStripMenuItem.Text = "File3"
        '
        'File4ToolStripMenuItem
        '
        Me.File4ToolStripMenuItem.Name = "File4ToolStripMenuItem"
        Me.File4ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.File4ToolStripMenuItem.Text = "File4"
        '
        'File5ToolStripMenuItem
        '
        Me.File5ToolStripMenuItem.Name = "File5ToolStripMenuItem"
        Me.File5ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.File5ToolStripMenuItem.Text = "File5"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Enabled = False
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        Me.ClearToolStripMenuItem.Visible = False
        '
        'AboutMenu
        '
        Me.AboutMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpMenuAbout, Me.OnlineHelpMenuHelp, Me.IntegrationToolStripMenuItem, Me.AboutAboutMenu})
        Me.AboutMenu.Name = "AboutMenu"
        Me.AboutMenu.Size = New System.Drawing.Size(48, 20)
        Me.AboutMenu.Text = "About"
        '
        'HelpMenuAbout
        '
        Me.HelpMenuAbout.Image = CType(resources.GetObject("HelpMenuAbout.Image"), System.Drawing.Image)
        Me.HelpMenuAbout.Name = "HelpMenuAbout"
        Me.HelpMenuAbout.Size = New System.Drawing.Size(139, 22)
        Me.HelpMenuAbout.Text = "Help"
        '
        'OnlineHelpMenuHelp
        '
        Me.OnlineHelpMenuHelp.Name = "OnlineHelpMenuHelp"
        Me.OnlineHelpMenuHelp.Size = New System.Drawing.Size(139, 22)
        Me.OnlineHelpMenuHelp.Text = "Online Help"
        '
        'IntegrationToolStripMenuItem
        '
        Me.IntegrationToolStripMenuItem.Name = "IntegrationToolStripMenuItem"
        Me.IntegrationToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.IntegrationToolStripMenuItem.Text = "Integration"
        '
        'AboutAboutMenu
        '
        Me.AboutAboutMenu.Name = "AboutAboutMenu"
        Me.AboutAboutMenu.Size = New System.Drawing.Size(139, 22)
        Me.AboutAboutMenu.Text = "About"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(1000, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = " "
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(210, 17)
        Me.StatusLabel.Text = " eXaminer a complete examination solution"
        '
        'TimeAllocation
        '
        Me.TimeAllocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeAllocation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TimeAllocation.Controls.Add(Me.TimeAlloc)
        Me.TimeAllocation.Controls.Add(Me.Label7)
        Me.TimeAllocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TimeAllocation.ForeColor = System.Drawing.Color.Black
        Me.TimeAllocation.Location = New System.Drawing.Point(793, 571)
        Me.TimeAllocation.Name = "TimeAllocation"
        Me.TimeAllocation.Size = New System.Drawing.Size(192, 60)
        Me.TimeAllocation.TabIndex = 3
        Me.TimeAllocation.TabStop = False
        Me.TimeAllocation.Text = "Time Allocation"
        '
        'TimeAlloc
        '
        Me.TimeAlloc.Location = New System.Drawing.Point(105, 27)
        Me.TimeAlloc.Name = "TimeAlloc"
        Me.TimeAlloc.Size = New System.Drawing.Size(44, 20)
        Me.TimeAlloc.TabIndex = 1
        Me.TimeAlloc.Text = "60"
        Me.TimeAlloc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Time in Sec"
        '
        'Que_Type
        '
        Me.Que_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Que_Type.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Que_Type.Controls.Add(Me.YorN_RB)
        Me.Que_Type.Controls.Add(Me.TorF_RB)
        Me.Que_Type.Controls.Add(Me.MCMA_RB)
        Me.Que_Type.Controls.Add(Me.MCSA_RB)
        Me.Que_Type.Controls.Add(Me.FinB_RB)
        Me.Que_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Que_Type.ForeColor = System.Drawing.Color.Black
        Me.Que_Type.Location = New System.Drawing.Point(793, 191)
        Me.Que_Type.Name = "Que_Type"
        Me.Que_Type.Size = New System.Drawing.Size(192, 179)
        Me.Que_Type.TabIndex = 0
        Me.Que_Type.TabStop = False
        Me.Que_Type.Text = "Question Type"
        '
        'YorN_RB
        '
        Me.YorN_RB.AutoSize = True
        Me.YorN_RB.Location = New System.Drawing.Point(17, 144)
        Me.YorN_RB.Name = "YorN_RB"
        Me.YorN_RB.Size = New System.Drawing.Size(72, 17)
        Me.YorN_RB.TabIndex = 4
        Me.YorN_RB.Text = "Yes or No"
        Me.YorN_RB.UseVisualStyleBackColor = True
        '
        'TorF_RB
        '
        Me.TorF_RB.AutoSize = True
        Me.TorF_RB.Location = New System.Drawing.Point(17, 119)
        Me.TorF_RB.Name = "TorF_RB"
        Me.TorF_RB.Size = New System.Drawing.Size(87, 17)
        Me.TorF_RB.TabIndex = 3
        Me.TorF_RB.Text = "True or False"
        Me.TorF_RB.UseVisualStyleBackColor = True
        '
        'MCMA_RB
        '
        Me.MCMA_RB.AutoSize = True
        Me.MCMA_RB.Location = New System.Drawing.Point(17, 61)
        Me.MCMA_RB.Name = "MCMA_RB"
        Me.MCMA_RB.Size = New System.Drawing.Size(174, 17)
        Me.MCMA_RB.TabIndex = 1
        Me.MCMA_RB.Text = "Multiple Choice Multiple Answer"
        Me.MCMA_RB.UseVisualStyleBackColor = True
        '
        'MCSA_RB
        '
        Me.MCSA_RB.AutoSize = True
        Me.MCSA_RB.Checked = True
        Me.MCSA_RB.Location = New System.Drawing.Point(17, 33)
        Me.MCSA_RB.Name = "MCSA_RB"
        Me.MCSA_RB.Size = New System.Drawing.Size(167, 17)
        Me.MCSA_RB.TabIndex = 0
        Me.MCSA_RB.TabStop = True
        Me.MCSA_RB.Text = "Multiple Choice Single Answer"
        Me.MCSA_RB.UseVisualStyleBackColor = True
        '
        'FinB_RB
        '
        Me.FinB_RB.AutoSize = True
        Me.FinB_RB.Location = New System.Drawing.Point(17, 92)
        Me.FinB_RB.Name = "FinB_RB"
        Me.FinB_RB.Size = New System.Drawing.Size(101, 17)
        Me.FinB_RB.TabIndex = 2
        Me.FinB_RB.Text = "Fill in the Blanks"
        Me.FinB_RB.UseVisualStyleBackColor = True
        '
        'Choice_no
        '
        Me.Choice_no.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Choice_no.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Choice_no.Controls.Add(Me.Choice)
        Me.Choice_no.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Choice_no.ForeColor = System.Drawing.Color.Black
        Me.Choice_no.Location = New System.Drawing.Point(795, 497)
        Me.Choice_no.Name = "Choice_no"
        Me.Choice_no.Size = New System.Drawing.Size(192, 53)
        Me.Choice_no.TabIndex = 2
        Me.Choice_no.TabStop = False
        Me.Choice_no.Text = "No of Choice"
        '
        'Choice
        '
        Me.Choice.FormattingEnabled = True
        Me.Choice.Items.AddRange(New Object() {"2", "3", "4", "5"})
        Me.Choice.Location = New System.Drawing.Point(63, 19)
        Me.Choice.Name = "Choice"
        Me.Choice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Choice.Size = New System.Drawing.Size(74, 21)
        Me.Choice.Sorted = True
        Me.Choice.TabIndex = 0
        Me.Choice.Text = "5"
        '
        'Marks
        '
        Me.Marks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Marks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Marks.Controls.Add(Me.WAns)
        Me.Marks.Controls.Add(Me.CAns)
        Me.Marks.Controls.Add(Me.Label4)
        Me.Marks.Controls.Add(Me.Label3)
        Me.Marks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Marks.ForeColor = System.Drawing.Color.Black
        Me.Marks.Location = New System.Drawing.Point(795, 384)
        Me.Marks.Name = "Marks"
        Me.Marks.Size = New System.Drawing.Size(192, 94)
        Me.Marks.TabIndex = 1
        Me.Marks.TabStop = False
        Me.Marks.Text = "Marks"
        '
        'WAns
        '
        Me.WAns.Location = New System.Drawing.Point(122, 61)
        Me.WAns.Name = "WAns"
        Me.WAns.Size = New System.Drawing.Size(44, 20)
        Me.WAns.TabIndex = 5
        Me.WAns.Text = "0"
        Me.WAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CAns
        '
        Me.CAns.Location = New System.Drawing.Point(122, 24)
        Me.CAns.Name = "CAns"
        Me.CAns.Size = New System.Drawing.Size(44, 20)
        Me.CAns.TabIndex = 4
        Me.CAns.Text = "1"
        Me.CAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Wrong  Answer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Correct Answer  "
        '
        'ControlPanel
        '
        Me.ControlPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.ControlPanel.Controls.Add(Me.PanelNext)
        Me.ControlPanel.Controls.Add(Me.PanelBack)
        Me.ControlPanel.Location = New System.Drawing.Point(802, 55)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(182, 33)
        Me.ControlPanel.TabIndex = 6
        Me.ControlPanel.Visible = False
        '
        'PanelNext
        '
        Me.PanelNext.BackgroundImage = CType(resources.GetObject("PanelNext.BackgroundImage"), System.Drawing.Image)
        Me.PanelNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelNext.Enabled = False
        Me.PanelNext.Location = New System.Drawing.Point(108, 2)
        Me.PanelNext.Name = "PanelNext"
        Me.PanelNext.Size = New System.Drawing.Size(28, 29)
        Me.PanelNext.TabIndex = 3
        Me.PanelNext.Text = " "
        Me.PanelNext.UseVisualStyleBackColor = True
        '
        'PanelBack
        '
        Me.PanelBack.BackgroundImage = CType(resources.GetObject("PanelBack.BackgroundImage"), System.Drawing.Image)
        Me.PanelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelBack.Enabled = False
        Me.PanelBack.Location = New System.Drawing.Point(49, 2)
        Me.PanelBack.Name = "PanelBack"
        Me.PanelBack.Size = New System.Drawing.Size(28, 29)
        Me.PanelBack.TabIndex = 2
        Me.PanelBack.Text = " "
        Me.PanelBack.UseVisualStyleBackColor = True
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TrayIcon.BalloonTipText = "eXaminer a complete examination Solution"
        Me.TrayIcon.BalloonTipTitle = "About"
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "eXaminer"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayAbout, Me.ToolStripSeparator9, Me.TrayLoadExam, Me.ToolStripSeparator10, Me.TrayShow, Me.ToolStripSeparator11, Me.TrayExit})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.ShowImageMargin = False
        Me.TrayMenu.Size = New System.Drawing.Size(113, 110)
        '
        'TrayAbout
        '
        Me.TrayAbout.Name = "TrayAbout"
        Me.TrayAbout.Size = New System.Drawing.Size(112, 22)
        Me.TrayAbout.Text = "About"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(109, 6)
        '
        'TrayLoadExam
        '
        Me.TrayLoadExam.Name = "TrayLoadExam"
        Me.TrayLoadExam.Size = New System.Drawing.Size(112, 22)
        Me.TrayLoadExam.Text = "Load Exam"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(109, 6)
        '
        'TrayShow
        '
        Me.TrayShow.Name = "TrayShow"
        Me.TrayShow.Size = New System.Drawing.Size(112, 22)
        Me.TrayShow.Text = "Hide"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(109, 6)
        '
        'TrayExit
        '
        Me.TrayExit.Name = "TrayExit"
        Me.TrayExit.Size = New System.Drawing.Size(112, 22)
        Me.TrayExit.Text = "Exit"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        Me.OleDbSelectCommand1.Connection = Me.DLoadConnection
        '
        'DLoadConnection
        '
        Me.DLoadConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.DLoadConnection
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("QuestionNo", System.Data.OleDb.OleDbType.[Integer], 0, "QuestionNo"), New System.Data.OleDb.OleDbParameter("Question", System.Data.OleDb.OleDbType.VarWChar, 0, "Question"), New System.Data.OleDb.OleDbParameter("OptionA", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionA"), New System.Data.OleDb.OleDbParameter("OptionB", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionB"), New System.Data.OleDb.OleDbParameter("OptionC", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionC"), New System.Data.OleDb.OleDbParameter("OptionD", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionD"), New System.Data.OleDb.OleDbParameter("OptionE", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionE"), New System.Data.OleDb.OleDbParameter("AnswerA", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerA"), New System.Data.OleDb.OleDbParameter("AnswerB", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerB"), New System.Data.OleDb.OleDbParameter("AnswerC", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerC"), New System.Data.OleDb.OleDbParameter("AnswerD", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerD"), New System.Data.OleDb.OleDbParameter("AnswerE", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerE"), New System.Data.OleDb.OleDbParameter("OptionNo", System.Data.OleDb.OleDbType.[Integer], 0, "OptionNo"), New System.Data.OleDb.OleDbParameter("QuestionType", System.Data.OleDb.OleDbType.[Integer], 0, "QuestionType"), New System.Data.OleDb.OleDbParameter("CAnswer", System.Data.OleDb.OleDbType.[Integer], 0, "CAnswer"), New System.Data.OleDb.OleDbParameter("WAnswer", System.Data.OleDb.OleDbType.[Integer], 0, "WAnswer"), New System.Data.OleDb.OleDbParameter("ExamTime", System.Data.OleDb.OleDbType.[Integer], 0, "ExamTime")})
        '
        'DLoadAdapter
        '
        Me.DLoadAdapter.InsertCommand = Me.OleDbInsertCommand1
        Me.DLoadAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.DLoadAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Questions", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("QuestionNo", "QuestionNo"), New System.Data.Common.DataColumnMapping("Question", "Question"), New System.Data.Common.DataColumnMapping("OptionA", "OptionA"), New System.Data.Common.DataColumnMapping("OptionB", "OptionB"), New System.Data.Common.DataColumnMapping("OptionC", "OptionC"), New System.Data.Common.DataColumnMapping("OptionD", "OptionD"), New System.Data.Common.DataColumnMapping("OptionE", "OptionE"), New System.Data.Common.DataColumnMapping("AnswerA", "AnswerA"), New System.Data.Common.DataColumnMapping("AnswerB", "AnswerB"), New System.Data.Common.DataColumnMapping("AnswerC", "AnswerC"), New System.Data.Common.DataColumnMapping("AnswerD", "AnswerD"), New System.Data.Common.DataColumnMapping("AnswerE", "AnswerE"), New System.Data.Common.DataColumnMapping("OptionNo", "OptionNo"), New System.Data.Common.DataColumnMapping("QuestionType", "QuestionType"), New System.Data.Common.DataColumnMapping("CAnswer", "CAnswer"), New System.Data.Common.DataColumnMapping("WAnswer", "WAnswer"), New System.Data.Common.DataColumnMapping("ExamTime", "ExamTime")})})
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'StartPanel
        '
        Me.StartPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.StartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StartPanel.Location = New System.Drawing.Point(786, 102)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(211, 569)
        Me.StartPanel.TabIndex = 5
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BackgroundImage = CType(resources.GetObject("MainPanel.BackgroundImage"), System.Drawing.Image)
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainPanel.Controls.Add(Me.Label5)
        Me.MainPanel.Controls.Add(Me.CurrQst)
        Me.MainPanel.Controls.Add(Me.Blank)
        Me.MainPanel.Controls.Add(Me.FIB2)
        Me.MainPanel.Controls.Add(Me.FIB5)
        Me.MainPanel.Controls.Add(Me.FRB)
        Me.MainPanel.Controls.Add(Me.FIB4)
        Me.MainPanel.Controls.Add(Me.TRB)
        Me.MainPanel.Controls.Add(Me.ERB)
        Me.MainPanel.Controls.Add(Me.FIB1)
        Me.MainPanel.Controls.Add(Me.ECB)
        Me.MainPanel.Controls.Add(Me.DRB)
        Me.MainPanel.Controls.Add(Me.FIB3)
        Me.MainPanel.Controls.Add(Me.Delete)
        Me.MainPanel.Controls.Add(Me.CRB)
        Me.MainPanel.Controls.Add(Me.DCB)
        Me.MainPanel.Controls.Add(Me.BRB)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Controls.Add(Me.ARB)
        Me.MainPanel.Controls.Add(Me.CCB)
        Me.MainPanel.Controls.Add(Me.ETB)
        Me.MainPanel.Controls.Add(Me.BCB)
        Me.MainPanel.Controls.Add(Me.ButtonOK)
        Me.MainPanel.Controls.Add(Me.ACB)
        Me.MainPanel.Controls.Add(Me.DTB)
        Me.MainPanel.Controls.Add(Me.ButtonUpdate)
        Me.MainPanel.Controls.Add(Me.CTB)
        Me.MainPanel.Controls.Add(Me.Clear)
        Me.MainPanel.Controls.Add(Me.BTB)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Controls.Add(Me.PreviousQue)
        Me.MainPanel.Controls.Add(Me.ATB)
        Me.MainPanel.Controls.Add(Me.QuestionRText)
        Me.MainPanel.Controls.Add(Me.Next_1)
        Me.MainPanel.Controls.Add(Me.Question_no)
        Me.MainPanel.Location = New System.Drawing.Point(27, 44)
        Me.MainPanel.MaximumSize = New System.Drawing.Size(694, 553)
        Me.MainPanel.MinimumSize = New System.Drawing.Size(694, 553)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(694, 553)
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Visible = False
        '
        'Question_no
        '
        Me.Question_no.AutoSize = True
        Me.Question_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Question_no.Location = New System.Drawing.Point(138, 14)
        Me.Question_no.Name = "Question_no"
        Me.Question_no.Size = New System.Drawing.Size(14, 13)
        Me.Question_no.TabIndex = 2
        Me.Question_no.Text = "1"
        '
        'Next_1
        '
        Me.Next_1.Enabled = False
        Me.Next_1.Location = New System.Drawing.Point(568, 493)
        Me.Next_1.Name = "Next_1"
        Me.Next_1.Size = New System.Drawing.Size(89, 25)
        Me.Next_1.TabIndex = 22
        Me.Next_1.Text = "Next >>"
        Me.Next_1.UseVisualStyleBackColor = True
        '
        'QuestionRText
        '
        Me.QuestionRText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionRText.Location = New System.Drawing.Point(45, 36)
        Me.QuestionRText.Name = "QuestionRText"
        Me.QuestionRText.Size = New System.Drawing.Size(610, 146)
        Me.QuestionRText.TabIndex = 0
        Me.QuestionRText.Text = "Type Your Questions here."
        '
        'ATB
        '
        Me.ATB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATB.Location = New System.Drawing.Point(98, 232)
        Me.ATB.Name = "ATB"
        Me.ATB.Size = New System.Drawing.Size(545, 22)
        Me.ATB.TabIndex = 3
        '
        'PreviousQue
        '
        Me.PreviousQue.Enabled = False
        Me.PreviousQue.Location = New System.Drawing.Point(32, 493)
        Me.PreviousQue.Name = "PreviousQue"
        Me.PreviousQue.Size = New System.Drawing.Size(89, 25)
        Me.PreviousQue.TabIndex = 24
        Me.PreviousQue.Text = "<< Back"
        Me.PreviousQue.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Question NO :"
        '
        'BTB
        '
        Me.BTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTB.Location = New System.Drawing.Point(98, 283)
        Me.BTB.Name = "BTB"
        Me.BTB.Size = New System.Drawing.Size(545, 22)
        Me.BTB.TabIndex = 6
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(242, 493)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(89, 25)
        Me.Clear.TabIndex = 23
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'CTB
        '
        Me.CTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTB.Location = New System.Drawing.Point(98, 333)
        Me.CTB.Name = "CTB"
        Me.CTB.Size = New System.Drawing.Size(545, 22)
        Me.CTB.TabIndex = 8
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Enabled = False
        Me.ButtonUpdate.Location = New System.Drawing.Point(458, 493)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(89, 25)
        Me.ButtonUpdate.TabIndex = 41
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'DTB
        '
        Me.DTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTB.Location = New System.Drawing.Point(98, 380)
        Me.DTB.Name = "DTB"
        Me.DTB.Size = New System.Drawing.Size(545, 22)
        Me.DTB.TabIndex = 10
        '
        'ACB
        '
        Me.ACB.AutoSize = True
        Me.ACB.Checked = True
        Me.ACB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ACB.Location = New System.Drawing.Point(45, 237)
        Me.ACB.Name = "ACB"
        Me.ACB.Size = New System.Drawing.Size(33, 17)
        Me.ACB.TabIndex = 37
        Me.ACB.Text = "A"
        Me.ACB.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(348, 493)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(89, 25)
        Me.ButtonOK.TabIndex = 40
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'BCB
        '
        Me.BCB.AutoSize = True
        Me.BCB.Location = New System.Drawing.Point(45, 286)
        Me.BCB.Name = "BCB"
        Me.BCB.Size = New System.Drawing.Size(33, 17)
        Me.BCB.TabIndex = 38
        Me.BCB.Text = "B"
        Me.BCB.UseVisualStyleBackColor = True
        '
        'ETB
        '
        Me.ETB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ETB.Location = New System.Drawing.Point(98, 426)
        Me.ETB.Name = "ETB"
        Me.ETB.Size = New System.Drawing.Size(545, 22)
        Me.ETB.TabIndex = 12
        '
        'CCB
        '
        Me.CCB.AutoSize = True
        Me.CCB.Location = New System.Drawing.Point(45, 338)
        Me.CCB.Name = "CCB"
        Me.CCB.Size = New System.Drawing.Size(33, 17)
        Me.CCB.TabIndex = 39
        Me.CCB.Text = "C"
        Me.CCB.UseVisualStyleBackColor = True
        '
        'ARB
        '
        Me.ARB.AutoSize = True
        Me.ARB.Checked = True
        Me.ARB.Location = New System.Drawing.Point(45, 237)
        Me.ARB.Name = "ARB"
        Me.ARB.Size = New System.Drawing.Size(32, 17)
        Me.ARB.TabIndex = 19
        Me.ARB.TabStop = True
        Me.ARB.Text = "A"
        Me.ARB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Answers"
        '
        'BRB
        '
        Me.BRB.AutoSize = True
        Me.BRB.Location = New System.Drawing.Point(45, 286)
        Me.BRB.Name = "BRB"
        Me.BRB.Size = New System.Drawing.Size(32, 17)
        Me.BRB.TabIndex = 20
        Me.BRB.Text = "B"
        Me.BRB.UseVisualStyleBackColor = True
        '
        'DCB
        '
        Me.DCB.AutoSize = True
        Me.DCB.Location = New System.Drawing.Point(45, 385)
        Me.DCB.Name = "DCB"
        Me.DCB.Size = New System.Drawing.Size(34, 17)
        Me.DCB.TabIndex = 40
        Me.DCB.Text = "D"
        Me.DCB.UseVisualStyleBackColor = True
        '
        'CRB
        '
        Me.CRB.AutoSize = True
        Me.CRB.Location = New System.Drawing.Point(45, 338)
        Me.CRB.Name = "CRB"
        Me.CRB.Size = New System.Drawing.Size(32, 17)
        Me.CRB.TabIndex = 21
        Me.CRB.Text = "C"
        Me.CRB.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Location = New System.Drawing.Point(137, 493)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(89, 25)
        Me.Delete.TabIndex = 42
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'FIB3
        '
        Me.FIB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIB3.Location = New System.Drawing.Point(224, 332)
        Me.FIB3.Name = "FIB3"
        Me.FIB3.Size = New System.Drawing.Size(243, 22)
        Me.FIB3.TabIndex = 33
        '
        'DRB
        '
        Me.DRB.AutoSize = True
        Me.DRB.Location = New System.Drawing.Point(45, 385)
        Me.DRB.Name = "DRB"
        Me.DRB.Size = New System.Drawing.Size(33, 17)
        Me.DRB.TabIndex = 22
        Me.DRB.Text = "D"
        Me.DRB.UseVisualStyleBackColor = True
        '
        'ECB
        '
        Me.ECB.AutoSize = True
        Me.ECB.Location = New System.Drawing.Point(45, 427)
        Me.ECB.Name = "ECB"
        Me.ECB.Size = New System.Drawing.Size(33, 17)
        Me.ECB.TabIndex = 41
        Me.ECB.Text = "E"
        Me.ECB.UseVisualStyleBackColor = True
        '
        'FIB1
        '
        Me.FIB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIB1.Location = New System.Drawing.Point(224, 231)
        Me.FIB1.Name = "FIB1"
        Me.FIB1.Size = New System.Drawing.Size(243, 22)
        Me.FIB1.TabIndex = 30
        '
        'ERB
        '
        Me.ERB.AutoSize = True
        Me.ERB.Location = New System.Drawing.Point(44, 428)
        Me.ERB.Name = "ERB"
        Me.ERB.Size = New System.Drawing.Size(32, 17)
        Me.ERB.TabIndex = 23
        Me.ERB.Text = "E"
        Me.ERB.UseVisualStyleBackColor = True
        '
        'TRB
        '
        Me.TRB.AutoSize = True
        Me.TRB.Checked = True
        Me.TRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRB.Location = New System.Drawing.Point(242, 332)
        Me.TRB.Name = "TRB"
        Me.TRB.Size = New System.Drawing.Size(58, 20)
        Me.TRB.TabIndex = 42
        Me.TRB.TabStop = True
        Me.TRB.Text = "True"
        Me.TRB.UseVisualStyleBackColor = True
        '
        'FIB4
        '
        Me.FIB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIB4.Location = New System.Drawing.Point(224, 381)
        Me.FIB4.Name = "FIB4"
        Me.FIB4.Size = New System.Drawing.Size(244, 22)
        Me.FIB4.TabIndex = 34
        '
        'FRB
        '
        Me.FRB.AutoSize = True
        Me.FRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FRB.Location = New System.Drawing.Point(392, 332)
        Me.FRB.Name = "FRB"
        Me.FRB.Size = New System.Drawing.Size(65, 20)
        Me.FRB.TabIndex = 43
        Me.FRB.Text = "False"
        Me.FRB.UseVisualStyleBackColor = True
        '
        'FIB5
        '
        Me.FIB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIB5.Location = New System.Drawing.Point(224, 426)
        Me.FIB5.Name = "FIB5"
        Me.FIB5.Size = New System.Drawing.Size(243, 22)
        Me.FIB5.TabIndex = 35
        '
        'FIB2
        '
        Me.FIB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIB2.Location = New System.Drawing.Point(224, 286)
        Me.FIB2.Name = "FIB2"
        Me.FIB2.Size = New System.Drawing.Size(243, 22)
        Me.FIB2.TabIndex = 32
        '
        'Blank
        '
        Me.Blank.Location = New System.Drawing.Point(224, 197)
        Me.Blank.Name = "Blank"
        Me.Blank.Size = New System.Drawing.Size(244, 25)
        Me.Blank.TabIndex = 40
        Me.Blank.Text = "Blank"
        Me.Blank.UseVisualStyleBackColor = True
        '
        'CurrQst
        '
        Me.CurrQst.AutoSize = True
        Me.CurrQst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrQst.Location = New System.Drawing.Point(183, 14)
        Me.CurrQst.Name = "CurrQst"
        Me.CurrQst.Size = New System.Drawing.Size(14, 13)
        Me.CurrQst.TabIndex = 44
        Me.CurrQst.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "of"
        '
        'Background_panel
        '
        Me.Background_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Background_panel.BackgroundImage = CType(resources.GetObject("Background_panel.BackgroundImage"), System.Drawing.Image)
        Me.Background_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Background_panel.Controls.Add(Me.MainPanel)
        Me.Background_panel.Location = New System.Drawing.Point(3, 28)
        Me.Background_panel.Name = "Background_panel"
        Me.Background_panel.Size = New System.Drawing.Size(753, 656)
        Me.Background_panel.TabIndex = 4
        '
        'eXaminer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 696)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.StartPanel)
        Me.Controls.Add(Me.ControlPanel)
        Me.Controls.Add(Me.Background_panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Marks)
        Me.Controls.Add(Me.Que_Type)
        Me.Controls.Add(Me.TimeAllocation)
        Me.Controls.Add(Me.Choice_no)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "eXaminer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eXam editer 2007"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TimeAllocation.ResumeLayout(False)
        Me.TimeAllocation.PerformLayout()
        Me.Que_Type.ResumeLayout(False)
        Me.Que_Type.PerformLayout()
        Me.Choice_no.ResumeLayout(False)
        Me.Marks.ResumeLayout(False)
        Me.Marks.PerformLayout()
        Me.ControlPanel.ResumeLayout(False)
        Me.TrayMenu.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.Background_panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpMenuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutAboutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExitMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TorF_RB As System.Windows.Forms.RadioButton
    Friend WithEvents FinB_RB As System.Windows.Forms.RadioButton
    Friend WithEvents MCMA_RB As System.Windows.Forms.RadioButton
    Friend WithEvents MCSA_RB As System.Windows.Forms.RadioButton
    Friend WithEvents YorN_RB As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Choice As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ControlPanel As System.Windows.Forms.Panel
    Friend WithEvents PanelBack As System.Windows.Forms.Button
    Friend WithEvents PanelNext As System.Windows.Forms.Button
    Friend WithEvents WAns As NumericTextBox.NumericTextBox
    Friend WithEvents CAns As NumericTextBox.NumericTextBox
    Friend WithEvents TimeAlloc As NumericTextBox.TimeTextBox
    Friend WithEvents TrayExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayLoadExam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Private WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Private WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents TrayShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents Que_Type As System.Windows.Forms.GroupBox
    Private WithEvents Marks As System.Windows.Forms.GroupBox
    Private WithEvents Choice_no As System.Windows.Forms.GroupBox
    Private WithEvents TimeAllocation As System.Windows.Forms.GroupBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DLoadConnection As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DLoadAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RecentMenuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents File1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents File2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents File3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents File4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents File5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntegrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartPanel As System.Windows.Forms.Panel
    Friend WithEvents Background_panel As System.Windows.Forms.Panel
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CurrQst As System.Windows.Forms.Label
    Friend WithEvents Blank As System.Windows.Forms.Button
    Friend WithEvents FIB2 As System.Windows.Forms.TextBox
    Friend WithEvents FIB5 As System.Windows.Forms.TextBox
    Friend WithEvents FRB As System.Windows.Forms.RadioButton
    Friend WithEvents FIB4 As System.Windows.Forms.TextBox
    Friend WithEvents TRB As System.Windows.Forms.RadioButton
    Friend WithEvents ERB As System.Windows.Forms.RadioButton
    Friend WithEvents FIB1 As System.Windows.Forms.TextBox
    Friend WithEvents ECB As System.Windows.Forms.CheckBox
    Friend WithEvents DRB As System.Windows.Forms.RadioButton
    Friend WithEvents FIB3 As System.Windows.Forms.TextBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents CRB As System.Windows.Forms.RadioButton
    Friend WithEvents DCB As System.Windows.Forms.CheckBox
    Friend WithEvents BRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ARB As System.Windows.Forms.RadioButton
    Friend WithEvents CCB As System.Windows.Forms.CheckBox
    Friend WithEvents ETB As System.Windows.Forms.TextBox
    Friend WithEvents BCB As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ACB As System.Windows.Forms.CheckBox
    Friend WithEvents DTB As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents CTB As System.Windows.Forms.TextBox
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents BTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PreviousQue As System.Windows.Forms.Button
    Friend WithEvents ATB As System.Windows.Forms.TextBox
    Friend WithEvents QuestionRText As System.Windows.Forms.RichTextBox
    Friend WithEvents Next_1 As System.Windows.Forms.Button
    Friend WithEvents Question_no As System.Windows.Forms.Label

End Class
