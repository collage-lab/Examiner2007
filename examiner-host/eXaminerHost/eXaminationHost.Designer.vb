<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eXaminationHost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eXaminationHost))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SystemTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SystemTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.About_TrayMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenu_newExam = New System.Windows.Forms.ToolStripMenuItem
        Me.StopExam_TrayMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HideTool_TrayMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.Exit_TrayMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGrideTab = New System.Windows.Forms.TabControl
        Me.StartPage = New System.Windows.Forms.TabPage
        Me.LabelDurationOfExam = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LabelNoofQuestions = New System.Windows.Forms.Label
        Me.LabelEndingtime = New System.Windows.Forms.Label
        Me.LabelStartingTime = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LabelExamStatus = New System.Windows.Forms.Label
        Me.LabelExamLoaded = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Results = New System.Windows.Forms.TabPage
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.TimerRefreshGrid = New System.Windows.Forms.Timer(Me.components)
        Me.PButton_layout = New System.Windows.Forms.Button
        Me.PButtonExit = New System.Windows.Forms.Button
        Me.PButtonSaveResults = New System.Windows.Forms.Button
        Me.PButtonStopExam = New System.Windows.Forms.Button
        Me.PButtonAbout = New System.Windows.Forms.Button
        Me.PButtonLoadNewExam = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PButtonHide = New System.Windows.Forms.Button
        Me.SystemTrayMenu.SuspendLayout()
        Me.DataGrideTab.SuspendLayout()
        Me.StartPage.SuspendLayout()
        Me.Results.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SystemTrayIcon
        '
        Me.SystemTrayIcon.ContextMenuStrip = Me.SystemTrayMenu
        Me.SystemTrayIcon.Icon = CType(resources.GetObject("SystemTrayIcon.Icon"), System.Drawing.Icon)
        Me.SystemTrayIcon.Text = "Examiner 2007"
        Me.SystemTrayIcon.Visible = True
        '
        'SystemTrayMenu
        '
        Me.SystemTrayMenu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About_TrayMenu, Me.ToolStripMenu_newExam, Me.StopExam_TrayMenu, Me.HideTool_TrayMenu, Me.Exit_TrayMenu})
        Me.SystemTrayMenu.Name = "SystemTrayMenu"
        Me.SystemTrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SystemTrayMenu.ShowImageMargin = False
        Me.SystemTrayMenu.Size = New System.Drawing.Size(148, 114)
        '
        'About_TrayMenu
        '
        Me.About_TrayMenu.Name = "About_TrayMenu"
        Me.About_TrayMenu.Size = New System.Drawing.Size(147, 22)
        Me.About_TrayMenu.Text = "About"
        '
        'ToolStripMenu_newExam
        '
        Me.ToolStripMenu_newExam.Enabled = False
        Me.ToolStripMenu_newExam.Name = "ToolStripMenu_newExam"
        Me.ToolStripMenu_newExam.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenu_newExam.Text = "Load New Exam"
        '
        'StopExam_TrayMenu
        '
        Me.StopExam_TrayMenu.Name = "StopExam_TrayMenu"
        Me.StopExam_TrayMenu.Size = New System.Drawing.Size(147, 22)
        Me.StopExam_TrayMenu.Text = "Stop  Exam"
        '
        'HideTool_TrayMenu
        '
        Me.HideTool_TrayMenu.Name = "HideTool_TrayMenu"
        Me.HideTool_TrayMenu.Size = New System.Drawing.Size(147, 22)
        Me.HideTool_TrayMenu.Text = "Hide Host"
        '
        'Exit_TrayMenu
        '
        Me.Exit_TrayMenu.Enabled = False
        Me.Exit_TrayMenu.Name = "Exit_TrayMenu"
        Me.Exit_TrayMenu.Size = New System.Drawing.Size(147, 22)
        Me.Exit_TrayMenu.Text = "Exit"
        '
        'DataGrideTab
        '
        Me.DataGrideTab.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.DataGrideTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrideTab.Controls.Add(Me.StartPage)
        Me.DataGrideTab.Controls.Add(Me.Results)
        Me.DataGrideTab.Location = New System.Drawing.Point(156, 162)
        Me.DataGrideTab.Multiline = True
        Me.DataGrideTab.Name = "DataGrideTab"
        Me.DataGrideTab.SelectedIndex = 0
        Me.DataGrideTab.Size = New System.Drawing.Size(710, 497)
        Me.DataGrideTab.TabIndex = 4
        '
        'StartPage
        '
        Me.StartPage.BackColor = System.Drawing.Color.Transparent
        Me.StartPage.BackgroundImage = CType(resources.GetObject("StartPage.BackgroundImage"), System.Drawing.Image)
        Me.StartPage.Controls.Add(Me.LabelDurationOfExam)
        Me.StartPage.Controls.Add(Me.Label6)
        Me.StartPage.Controls.Add(Me.LabelNoofQuestions)
        Me.StartPage.Controls.Add(Me.LabelEndingtime)
        Me.StartPage.Controls.Add(Me.LabelStartingTime)
        Me.StartPage.Controls.Add(Me.Label11)
        Me.StartPage.Controls.Add(Me.LabelExamStatus)
        Me.StartPage.Controls.Add(Me.LabelExamLoaded)
        Me.StartPage.Controls.Add(Me.Label5)
        Me.StartPage.Controls.Add(Me.Label4)
        Me.StartPage.Controls.Add(Me.Label3)
        Me.StartPage.Controls.Add(Me.Label2)
        Me.StartPage.Controls.Add(Me.Label1)
        Me.StartPage.Location = New System.Drawing.Point(4, 22)
        Me.StartPage.Name = "StartPage"
        Me.StartPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPage.Size = New System.Drawing.Size(702, 471)
        Me.StartPage.TabIndex = 0
        Me.StartPage.Text = "Start Page"
        '
        'LabelDurationOfExam
        '
        Me.LabelDurationOfExam.AutoSize = True
        Me.LabelDurationOfExam.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelDurationOfExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDurationOfExam.Location = New System.Drawing.Point(197, 389)
        Me.LabelDurationOfExam.Name = "LabelDurationOfExam"
        Me.LabelDurationOfExam.Size = New System.Drawing.Size(11, 16)
        Me.LabelDurationOfExam.TabIndex = 14
        Me.LabelDurationOfExam.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Duration of exam"
        '
        'LabelNoofQuestions
        '
        Me.LabelNoofQuestions.AutoSize = True
        Me.LabelNoofQuestions.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelNoofQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNoofQuestions.Location = New System.Drawing.Point(197, 343)
        Me.LabelNoofQuestions.Name = "LabelNoofQuestions"
        Me.LabelNoofQuestions.Size = New System.Drawing.Size(11, 16)
        Me.LabelNoofQuestions.TabIndex = 12
        Me.LabelNoofQuestions.Text = ":"
        '
        'LabelEndingtime
        '
        Me.LabelEndingtime.AutoSize = True
        Me.LabelEndingtime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelEndingtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEndingtime.Location = New System.Drawing.Point(197, 295)
        Me.LabelEndingtime.Name = "LabelEndingtime"
        Me.LabelEndingtime.Size = New System.Drawing.Size(0, 16)
        Me.LabelEndingtime.TabIndex = 11
        '
        'LabelStartingTime
        '
        Me.LabelStartingTime.AutoSize = True
        Me.LabelStartingTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelStartingTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStartingTime.Location = New System.Drawing.Point(197, 250)
        Me.LabelStartingTime.Name = "LabelStartingTime"
        Me.LabelStartingTime.Size = New System.Drawing.Size(11, 16)
        Me.LabelStartingTime.TabIndex = 10
        Me.LabelStartingTime.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Exam Status         :"
        '
        'LabelExamStatus
        '
        Me.LabelExamStatus.AutoSize = True
        Me.LabelExamStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelExamStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExamStatus.Location = New System.Drawing.Point(197, 210)
        Me.LabelExamStatus.Name = "LabelExamStatus"
        Me.LabelExamStatus.Size = New System.Drawing.Size(57, 16)
        Me.LabelExamStatus.TabIndex = 7
        Me.LabelExamStatus.Text = "Running"
        '
        'LabelExamLoaded
        '
        Me.LabelExamLoaded.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelExamLoaded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExamLoaded.Location = New System.Drawing.Point(197, 152)
        Me.LabelExamLoaded.Name = "LabelExamLoaded"
        Me.LabelExamLoaded.Size = New System.Drawing.Size(490, 46)
        Me.LabelExamLoaded.TabIndex = 5
        Me.LabelExamLoaded.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No of Questions   :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ending Time        :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Starting Time       :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Loaded         :"
        '
        'Results
        '
        Me.Results.Controls.Add(Me.DataGrid)
        Me.Results.Location = New System.Drawing.Point(4, 22)
        Me.Results.Name = "Results"
        Me.Results.Padding = New System.Windows.Forms.Padding(3)
        Me.Results.Size = New System.Drawing.Size(702, 471)
        Me.Results.TabIndex = 1
        Me.Results.Text = "Exam Results"
        Me.Results.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid.Location = New System.Drawing.Point(3, 3)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.Size = New System.Drawing.Size(696, 465)
        Me.DataGrid.TabIndex = 0
        '
        'TimerRefreshGrid
        '
        Me.TimerRefreshGrid.Interval = 1000
        '
        'PButton_layout
        '
        Me.PButton_layout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButton_layout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PButton_layout.BackgroundImage = CType(resources.GetObject("PButton_layout.BackgroundImage"), System.Drawing.Image)
        Me.PButton_layout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButton_layout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButton_layout.Location = New System.Drawing.Point(110, 7)
        Me.PButton_layout.Name = "PButton_layout"
        Me.PButton_layout.Size = New System.Drawing.Size(73, 73)
        Me.PButton_layout.TabIndex = 13
        Me.PButton_layout.UseVisualStyleBackColor = False
        '
        'PButtonExit
        '
        Me.PButtonExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButtonExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PButtonExit.BackgroundImage = CType(resources.GetObject("PButtonExit.BackgroundImage"), System.Drawing.Image)
        Me.PButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButtonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButtonExit.Enabled = False
        Me.PButtonExit.Location = New System.Drawing.Point(479, 7)
        Me.PButtonExit.Name = "PButtonExit"
        Me.PButtonExit.Size = New System.Drawing.Size(73, 73)
        Me.PButtonExit.TabIndex = 12
        Me.PButtonExit.UseVisualStyleBackColor = False
        '
        'PButtonSaveResults
        '
        Me.PButtonSaveResults.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButtonSaveResults.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PButtonSaveResults.BackgroundImage = CType(resources.GetObject("PButtonSaveResults.BackgroundImage"), System.Drawing.Image)
        Me.PButtonSaveResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButtonSaveResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButtonSaveResults.Enabled = False
        Me.PButtonSaveResults.Location = New System.Drawing.Point(387, 7)
        Me.PButtonSaveResults.Name = "PButtonSaveResults"
        Me.PButtonSaveResults.Size = New System.Drawing.Size(73, 73)
        Me.PButtonSaveResults.TabIndex = 15
        Me.PButtonSaveResults.UseVisualStyleBackColor = False
        '
        'PButtonStopExam
        '
        Me.PButtonStopExam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButtonStopExam.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PButtonStopExam.BackgroundImage = CType(resources.GetObject("PButtonStopExam.BackgroundImage"), System.Drawing.Image)
        Me.PButtonStopExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButtonStopExam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButtonStopExam.Location = New System.Drawing.Point(297, 7)
        Me.PButtonStopExam.Name = "PButtonStopExam"
        Me.PButtonStopExam.Size = New System.Drawing.Size(73, 73)
        Me.PButtonStopExam.TabIndex = 14
        Me.PButtonStopExam.UseVisualStyleBackColor = False
        '
        'PButtonAbout
        '
        Me.PButtonAbout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButtonAbout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PButtonAbout.BackgroundImage = CType(resources.GetObject("PButtonAbout.BackgroundImage"), System.Drawing.Image)
        Me.PButtonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButtonAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButtonAbout.Location = New System.Drawing.Point(574, 7)
        Me.PButtonAbout.Name = "PButtonAbout"
        Me.PButtonAbout.Size = New System.Drawing.Size(73, 73)
        Me.PButtonAbout.TabIndex = 10
        Me.PButtonAbout.UseVisualStyleBackColor = False
        '
        'PButtonLoadNewExam
        '
        Me.PButtonLoadNewExam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButtonLoadNewExam.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PButtonLoadNewExam.BackgroundImage = CType(resources.GetObject("PButtonLoadNewExam.BackgroundImage"), System.Drawing.Image)
        Me.PButtonLoadNewExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButtonLoadNewExam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButtonLoadNewExam.Enabled = False
        Me.PButtonLoadNewExam.Location = New System.Drawing.Point(20, 9)
        Me.PButtonLoadNewExam.Name = "PButtonLoadNewExam"
        Me.PButtonLoadNewExam.Size = New System.Drawing.Size(73, 73)
        Me.PButtonLoadNewExam.TabIndex = 11
        Me.PButtonLoadNewExam.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.PButtonHide)
        Me.Panel1.Controls.Add(Me.PButtonLoadNewExam)
        Me.Panel1.Controls.Add(Me.PButtonStopExam)
        Me.Panel1.Controls.Add(Me.PButtonAbout)
        Me.Panel1.Controls.Add(Me.PButtonExit)
        Me.Panel1.Controls.Add(Me.PButtonSaveResults)
        Me.Panel1.Controls.Add(Me.PButton_layout)
        Me.Panel1.Location = New System.Drawing.Point(176, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 90)
        Me.Panel1.TabIndex = 0
        '
        'PButtonHide
        '
        Me.PButtonHide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PButtonHide.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PButtonHide.BackgroundImage = CType(resources.GetObject("PButtonHide.BackgroundImage"), System.Drawing.Image)
        Me.PButtonHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PButtonHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PButtonHide.Location = New System.Drawing.Point(203, 7)
        Me.PButtonHide.Name = "PButtonHide"
        Me.PButtonHide.Size = New System.Drawing.Size(73, 73)
        Me.PButtonHide.TabIndex = 16
        Me.PButtonHide.UseVisualStyleBackColor = False
        '
        'eXaminationHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGrideTab)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "eXaminationHost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eXaminationHost"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SystemTrayMenu.ResumeLayout(False)
        Me.DataGrideTab.ResumeLayout(False)
        Me.StartPage.ResumeLayout(False)
        Me.StartPage.PerformLayout()
        Me.Results.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents SystemTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents About_TrayMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopExam_TrayMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideTool_TrayMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exit_TrayMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGrideTab As System.Windows.Forms.TabControl
    Friend WithEvents StartPage As System.Windows.Forms.TabPage
    Friend WithEvents Results As System.Windows.Forms.TabPage
    Private WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PButton_layout As System.Windows.Forms.Button
    Friend WithEvents PButtonExit As System.Windows.Forms.Button
    Friend WithEvents PButtonSaveResults As System.Windows.Forms.Button
    Friend WithEvents PButtonStopExam As System.Windows.Forms.Button
    Friend WithEvents PButtonAbout As System.Windows.Forms.Button
    Friend WithEvents PButtonLoadNewExam As System.Windows.Forms.Button
    Public WithEvents SystemTrayIcon As System.Windows.Forms.NotifyIcon
    Public WithEvents TimerRefreshGrid As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PButtonHide As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenu_newExam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelExamStatus As System.Windows.Forms.Label
    Friend WithEvents LabelExamLoaded As System.Windows.Forms.Label
    Friend WithEvents LabelNoofQuestions As System.Windows.Forms.Label
    Friend WithEvents LabelEndingtime As System.Windows.Forms.Label
    Friend WithEvents LabelStartingTime As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelDurationOfExam As System.Windows.Forms.Label
End Class
