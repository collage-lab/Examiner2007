<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartSelector))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBoxConfigure = New System.Windows.Forms.PictureBox
        Me.PictureBoxStartExam = New System.Windows.Forms.PictureBox
        Me.PictureBoxLoadExam = New System.Windows.Forms.PictureBox
        Me.Configure3 = New System.Windows.Forms.PictureBox
        Me.Startexam3 = New System.Windows.Forms.PictureBox
        Me.Loadexam3 = New System.Windows.Forms.PictureBox
        Me.Configure2 = New System.Windows.Forms.PictureBox
        Me.Startexam2 = New System.Windows.Forms.PictureBox
        Me.Loadexam2 = New System.Windows.Forms.PictureBox
        Me.Configure1 = New System.Windows.Forms.PictureBox
        Me.Startexam1 = New System.Windows.Forms.PictureBox
        Me.Loadexam1 = New System.Windows.Forms.PictureBox
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.ODbConnection = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.LoadAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxConfigure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStartExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLoadExam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Configure3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Startexam3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loadexam3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Configure2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Startexam2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loadexam2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Configure1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Startexam1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loadexam1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBoxConfigure)
        Me.Panel1.Controls.Add(Me.PictureBoxStartExam)
        Me.Panel1.Controls.Add(Me.PictureBoxLoadExam)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 268)
        Me.Panel1.TabIndex = 0
        '
        'PictureBoxConfigure
        '
        Me.PictureBoxConfigure.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.Config_1
        Me.PictureBoxConfigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxConfigure.Location = New System.Drawing.Point(321, 52)
        Me.PictureBoxConfigure.Name = "PictureBoxConfigure"
        Me.PictureBoxConfigure.Size = New System.Drawing.Size(108, 154)
        Me.PictureBoxConfigure.TabIndex = 2
        Me.PictureBoxConfigure.TabStop = False
        '
        'PictureBoxStartExam
        '
        Me.PictureBoxStartExam.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.StartExam_1
        Me.PictureBoxStartExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxStartExam.Location = New System.Drawing.Point(182, 52)
        Me.PictureBoxStartExam.Name = "PictureBoxStartExam"
        Me.PictureBoxStartExam.Size = New System.Drawing.Size(108, 154)
        Me.PictureBoxStartExam.TabIndex = 1
        Me.PictureBoxStartExam.TabStop = False
        '
        'PictureBoxLoadExam
        '
        Me.PictureBoxLoadExam.BackgroundImage = CType(resources.GetObject("PictureBoxLoadExam.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLoadExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxLoadExam.Location = New System.Drawing.Point(45, 52)
        Me.PictureBoxLoadExam.MaximumSize = New System.Drawing.Size(108, 154)
        Me.PictureBoxLoadExam.MinimumSize = New System.Drawing.Size(108, 154)
        Me.PictureBoxLoadExam.Name = "PictureBoxLoadExam"
        Me.PictureBoxLoadExam.Size = New System.Drawing.Size(108, 154)
        Me.PictureBoxLoadExam.TabIndex = 0
        Me.PictureBoxLoadExam.TabStop = False
        '
        'Configure3
        '
        Me.Configure3.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.Config_3
        Me.Configure3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Configure3.Location = New System.Drawing.Point(334, 520)
        Me.Configure3.Name = "Configure3"
        Me.Configure3.Size = New System.Drawing.Size(21, 21)
        Me.Configure3.TabIndex = 11
        Me.Configure3.TabStop = False
        '
        'Startexam3
        '
        Me.Startexam3.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.StartExam_31
        Me.Startexam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Startexam3.Location = New System.Drawing.Point(334, 449)
        Me.Startexam3.Name = "Startexam3"
        Me.Startexam3.Size = New System.Drawing.Size(21, 21)
        Me.Startexam3.TabIndex = 10
        Me.Startexam3.TabStop = False
        '
        'Loadexam3
        '
        Me.Loadexam3.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.LoadExam_3
        Me.Loadexam3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Loadexam3.Location = New System.Drawing.Point(334, 375)
        Me.Loadexam3.Name = "Loadexam3"
        Me.Loadexam3.Size = New System.Drawing.Size(21, 21)
        Me.Loadexam3.TabIndex = 9
        Me.Loadexam3.TabStop = False
        '
        'Configure2
        '
        Me.Configure2.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.Config_2
        Me.Configure2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Configure2.Location = New System.Drawing.Point(207, 520)
        Me.Configure2.Name = "Configure2"
        Me.Configure2.Size = New System.Drawing.Size(21, 21)
        Me.Configure2.TabIndex = 8
        Me.Configure2.TabStop = False
        '
        'Startexam2
        '
        Me.Startexam2.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.StartExam_2
        Me.Startexam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Startexam2.Location = New System.Drawing.Point(207, 449)
        Me.Startexam2.Name = "Startexam2"
        Me.Startexam2.Size = New System.Drawing.Size(21, 21)
        Me.Startexam2.TabIndex = 7
        Me.Startexam2.TabStop = False
        '
        'Loadexam2
        '
        Me.Loadexam2.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.LoadExam_2
        Me.Loadexam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Loadexam2.Location = New System.Drawing.Point(207, 375)
        Me.Loadexam2.Name = "Loadexam2"
        Me.Loadexam2.Size = New System.Drawing.Size(21, 21)
        Me.Loadexam2.TabIndex = 6
        Me.Loadexam2.TabStop = False
        '
        'Configure1
        '
        Me.Configure1.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.Config_1
        Me.Configure1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Configure1.Location = New System.Drawing.Point(80, 520)
        Me.Configure1.Name = "Configure1"
        Me.Configure1.Size = New System.Drawing.Size(21, 21)
        Me.Configure1.TabIndex = 5
        Me.Configure1.TabStop = False
        '
        'Startexam1
        '
        Me.Startexam1.BackgroundImage = Global.Examiner_2007.My.Resources.Resources.StartExam_1
        Me.Startexam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Startexam1.Location = New System.Drawing.Point(80, 449)
        Me.Startexam1.Name = "Startexam1"
        Me.Startexam1.Size = New System.Drawing.Size(21, 21)
        Me.Startexam1.TabIndex = 4
        Me.Startexam1.TabStop = False
        '
        'Loadexam1
        '
        Me.Loadexam1.BackgroundImage = CType(resources.GetObject("Loadexam1.BackgroundImage"), System.Drawing.Image)
        Me.Loadexam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Loadexam1.Location = New System.Drawing.Point(80, 375)
        Me.Loadexam1.Name = "Loadexam1"
        Me.Loadexam1.Size = New System.Drawing.Size(21, 21)
        Me.Loadexam1.TabIndex = 3
        Me.Loadexam1.TabStop = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT     Questions.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Questions"
        Me.OleDbSelectCommand1.Connection = Me.ODbConnection
        '
        'ODbConnection
        '
        Me.ODbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Examiner2007.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.ODbConnection
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("QuestionNo", System.Data.OleDb.OleDbType.[Integer], 0, "QuestionNo"), New System.Data.OleDb.OleDbParameter("Question", System.Data.OleDb.OleDbType.VarWChar, 0, "Question"), New System.Data.OleDb.OleDbParameter("OptionA", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionA"), New System.Data.OleDb.OleDbParameter("OptionB", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionB"), New System.Data.OleDb.OleDbParameter("OptionC", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionC"), New System.Data.OleDb.OleDbParameter("OptionD", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionD"), New System.Data.OleDb.OleDbParameter("OptionE", System.Data.OleDb.OleDbType.VarWChar, 0, "OptionE"), New System.Data.OleDb.OleDbParameter("AnswerA", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerA"), New System.Data.OleDb.OleDbParameter("AnswerB", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerB"), New System.Data.OleDb.OleDbParameter("AnswerC", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerC"), New System.Data.OleDb.OleDbParameter("AnswerD", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerD"), New System.Data.OleDb.OleDbParameter("AnswerE", System.Data.OleDb.OleDbType.VarWChar, 0, "AnswerE"), New System.Data.OleDb.OleDbParameter("OptionNo", System.Data.OleDb.OleDbType.[Integer], 0, "OptionNo"), New System.Data.OleDb.OleDbParameter("QuestionType", System.Data.OleDb.OleDbType.[Integer], 0, "QuestionType"), New System.Data.OleDb.OleDbParameter("CAnswer", System.Data.OleDb.OleDbType.[Integer], 0, "CAnswer"), New System.Data.OleDb.OleDbParameter("WAnswer", System.Data.OleDb.OleDbType.[Integer], 0, "WAnswer"), New System.Data.OleDb.OleDbParameter("ExamTime", System.Data.OleDb.OleDbType.[Integer], 0, "ExamTime")})
        '
        'LoadAdapter
        '
        Me.LoadAdapter.InsertCommand = Me.OleDbInsertCommand1
        Me.LoadAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.LoadAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Questions", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("QuestionNo", "QuestionNo"), New System.Data.Common.DataColumnMapping("Question", "Question"), New System.Data.Common.DataColumnMapping("OptionA", "OptionA"), New System.Data.Common.DataColumnMapping("OptionB", "OptionB"), New System.Data.Common.DataColumnMapping("OptionC", "OptionC"), New System.Data.Common.DataColumnMapping("OptionD", "OptionD"), New System.Data.Common.DataColumnMapping("OptionE", "OptionE"), New System.Data.Common.DataColumnMapping("AnswerA", "AnswerA"), New System.Data.Common.DataColumnMapping("AnswerB", "AnswerB"), New System.Data.Common.DataColumnMapping("AnswerC", "AnswerC"), New System.Data.Common.DataColumnMapping("AnswerD", "AnswerD"), New System.Data.Common.DataColumnMapping("AnswerE", "AnswerE"), New System.Data.Common.DataColumnMapping("OptionNo", "OptionNo"), New System.Data.Common.DataColumnMapping("QuestionType", "QuestionType"), New System.Data.Common.DataColumnMapping("CAnswer", "CAnswer"), New System.Data.Common.DataColumnMapping("WAnswer", "WAnswer"), New System.Data.Common.DataColumnMapping("ExamTime", "ExamTime")})})
        '
        'StartSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 268)
        Me.Controls.Add(Me.Configure3)
        Me.Controls.Add(Me.Startexam3)
        Me.Controls.Add(Me.Loadexam3)
        Me.Controls.Add(Me.Configure2)
        Me.Controls.Add(Me.Startexam2)
        Me.Controls.Add(Me.Loadexam2)
        Me.Controls.Add(Me.Configure1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Startexam1)
        Me.Controls.Add(Me.Loadexam1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(488, 300)
        Me.MinimumSize = New System.Drawing.Size(488, 300)
        Me.Name = "StartSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eXaminer 2007"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxConfigure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStartExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLoadExam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Configure3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Startexam3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loadexam3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Configure2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Startexam2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loadexam2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Configure1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Startexam1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loadexam1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxLoadExam As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxConfigure As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxStartExam As System.Windows.Forms.PictureBox
    Friend WithEvents Configure1 As System.Windows.Forms.PictureBox
    Friend WithEvents Startexam1 As System.Windows.Forms.PictureBox
    Friend WithEvents Loadexam1 As System.Windows.Forms.PictureBox
    Friend WithEvents Configure2 As System.Windows.Forms.PictureBox
    Friend WithEvents Startexam2 As System.Windows.Forms.PictureBox
    Friend WithEvents Loadexam2 As System.Windows.Forms.PictureBox
    Friend WithEvents Configure3 As System.Windows.Forms.PictureBox
    Friend WithEvents Startexam3 As System.Windows.Forms.PictureBox
    Friend WithEvents Loadexam3 As System.Windows.Forms.PictureBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents LoadAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ODbConnection As System.Data.OleDb.OleDbConnection

End Class
