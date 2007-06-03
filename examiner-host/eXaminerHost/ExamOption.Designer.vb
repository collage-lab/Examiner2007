<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamOption))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonBrowse = New System.Windows.Forms.Button
        Me.TextBoxFileOpen = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabelStartingTime = New System.Windows.Forms.Label
        Me.NumericTextBox = New NumericTextBox.NumericTextBox
        Me.RBU = New System.Windows.Forms.RadioButton
        Me.RBLim = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RButtonQst = New System.Windows.Forms.RadioButton
        Me.RButtonMan = New System.Windows.Forms.RadioButton
        Me.RButtonAuto = New System.Windows.Forms.RadioButton
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.ODbConnection = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.LoadAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonOk = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonBrowse)
        Me.GroupBox1.Controls.Add(Me.TextBoxFileOpen)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load Exam File"
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(318, 31)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 1
        Me.ButtonBrowse.Text = "Browse ..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'TextBoxFileOpen
        '
        Me.TextBoxFileOpen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBoxFileOpen.Location = New System.Drawing.Point(16, 33)
        Me.TextBoxFileOpen.Name = "TextBoxFileOpen"
        Me.TextBoxFileOpen.ReadOnly = True
        Me.TextBoxFileOpen.Size = New System.Drawing.Size(296, 20)
        Me.TextBoxFileOpen.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.LabelStartingTime)
        Me.GroupBox2.Controls.Add(Me.NumericTextBox)
        Me.GroupBox2.Controls.Add(Me.RBU)
        Me.GroupBox2.Controls.Add(Me.RBLim)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exam Duration"
        '
        'LabelStartingTime
        '
        Me.LabelStartingTime.AutoSize = True
        Me.LabelStartingTime.Location = New System.Drawing.Point(94, 144)
        Me.LabelStartingTime.Name = "LabelStartingTime"
        Me.LabelStartingTime.Size = New System.Drawing.Size(24, 13)
        Me.LabelStartingTime.TabIndex = 7
        Me.LabelStartingTime.Text = "Min"
        '
        'NumericTextBox
        '
        Me.NumericTextBox.Enabled = False
        Me.NumericTextBox.Location = New System.Drawing.Point(33, 140)
        Me.NumericTextBox.Name = "NumericTextBox"
        Me.NumericTextBox.Size = New System.Drawing.Size(58, 20)
        Me.NumericTextBox.TabIndex = 2
        '
        'RBU
        '
        Me.RBU.AutoSize = True
        Me.RBU.Checked = True
        Me.RBU.Location = New System.Drawing.Point(33, 45)
        Me.RBU.Name = "RBU"
        Me.RBU.Size = New System.Drawing.Size(68, 17)
        Me.RBU.TabIndex = 0
        Me.RBU.TabStop = True
        Me.RBU.Text = "Unlimited"
        Me.RBU.UseVisualStyleBackColor = True
        '
        'RBLim
        '
        Me.RBLim.AutoSize = True
        Me.RBLim.Location = New System.Drawing.Point(33, 93)
        Me.RBLim.Name = "RBLim"
        Me.RBLim.Size = New System.Drawing.Size(58, 17)
        Me.RBLim.TabIndex = 1
        Me.RBLim.Text = "Limited"
        Me.RBLim.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.RButtonQst)
        Me.GroupBox3.Controls.Add(Me.RButtonMan)
        Me.GroupBox3.Controls.Add(Me.RButtonAuto)
        Me.GroupBox3.Location = New System.Drawing.Point(186, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(145, 189)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Time  Limiting"
        '
        'RButtonQst
        '
        Me.RButtonQst.AutoSize = True
        Me.RButtonQst.Location = New System.Drawing.Point(33, 140)
        Me.RButtonQst.Name = "RButtonQst"
        Me.RButtonQst.Size = New System.Drawing.Size(91, 17)
        Me.RButtonQst.TabIndex = 2
        Me.RButtonQst.Text = "Question wise"
        Me.RButtonQst.UseVisualStyleBackColor = True
        '
        'RButtonMan
        '
        Me.RButtonMan.AutoSize = True
        Me.RButtonMan.Checked = True
        Me.RButtonMan.Location = New System.Drawing.Point(33, 43)
        Me.RButtonMan.Name = "RButtonMan"
        Me.RButtonMan.Size = New System.Drawing.Size(66, 17)
        Me.RButtonMan.TabIndex = 0
        Me.RButtonMan.TabStop = True
        Me.RButtonMan.Text = "Manuval"
        Me.RButtonMan.UseVisualStyleBackColor = True
        '
        'RButtonAuto
        '
        Me.RButtonAuto.AutoSize = True
        Me.RButtonAuto.Location = New System.Drawing.Point(33, 93)
        Me.RButtonAuto.Name = "RButtonAuto"
        Me.RButtonAuto.Size = New System.Drawing.Size(72, 17)
        Me.RButtonAuto.TabIndex = 1
        Me.RButtonAuto.Text = "Automatic"
        Me.RButtonAuto.UseVisualStyleBackColor = True
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.eXaminerHost.My.Resources.Resources.PNG_X__208_
        Me.PictureBox1.Location = New System.Drawing.Point(352, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(471, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(362, 271)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 27)
        Me.ButtonOk.TabIndex = 0
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(362, 308)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 27)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ExamOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(469, 357)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(475, 389)
        Me.MinimumSize = New System.Drawing.Size(475, 389)
        Me.Name = "ExamOption"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxFileOpen As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RBLim As System.Windows.Forms.RadioButton
    Friend WithEvents RBU As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericTextBox As NumericTextBox.NumericTextBox
    Friend WithEvents RButtonQst As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonMan As System.Windows.Forms.RadioButton
    Friend WithEvents RButtonAuto As System.Windows.Forms.RadioButton
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents LoadAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ODbConnection As System.Data.OleDb.OleDbConnection
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelStartingTime As System.Windows.Forms.Label
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
