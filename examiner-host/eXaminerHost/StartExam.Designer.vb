<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartExam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartExam))
        Me.RadioButtonSnow = New System.Windows.Forms.RadioButton
        Me.RadioButtonShedule = New System.Windows.Forms.RadioButton
        Me.LabelStartingTime = New System.Windows.Forms.Label
        Me.PanelDisplay = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxSmin = New NumericTextBox.TimeTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxSHr = New NumericTextBox.TimeTextBox
        Me.Label = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TimerStop = New System.Windows.Forms.Timer(Me.components)
        Me.Timerstart = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ButtonRest = New System.Windows.Forms.Button
        Me.ButtonOk = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.PanelDisplay.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButtonSnow
        '
        Me.RadioButtonSnow.AutoSize = True
        Me.RadioButtonSnow.Checked = True
        Me.RadioButtonSnow.Location = New System.Drawing.Point(129, 26)
        Me.RadioButtonSnow.Name = "RadioButtonSnow"
        Me.RadioButtonSnow.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonSnow.TabIndex = 4
        Me.RadioButtonSnow.TabStop = True
        Me.RadioButtonSnow.Text = "StartNow"
        Me.RadioButtonSnow.UseVisualStyleBackColor = True
        '
        'RadioButtonShedule
        '
        Me.RadioButtonShedule.AutoSize = True
        Me.RadioButtonShedule.Location = New System.Drawing.Point(232, 26)
        Me.RadioButtonShedule.Name = "RadioButtonShedule"
        Me.RadioButtonShedule.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonShedule.TabIndex = 5
        Me.RadioButtonShedule.Text = "Shedule"
        Me.RadioButtonShedule.UseVisualStyleBackColor = True
        '
        'LabelStartingTime
        '
        Me.LabelStartingTime.AutoSize = True
        Me.LabelStartingTime.Location = New System.Drawing.Point(39, 78)
        Me.LabelStartingTime.Name = "LabelStartingTime"
        Me.LabelStartingTime.Size = New System.Drawing.Size(66, 13)
        Me.LabelStartingTime.TabIndex = 6
        Me.LabelStartingTime.Text = "StartingTime"
        '
        'PanelDisplay
        '
        Me.PanelDisplay.BackColor = System.Drawing.Color.Transparent
        Me.PanelDisplay.Controls.Add(Me.Label3)
        Me.PanelDisplay.Controls.Add(Me.TextBoxSmin)
        Me.PanelDisplay.Controls.Add(Me.Label2)
        Me.PanelDisplay.Controls.Add(Me.TextBoxSHr)
        Me.PanelDisplay.Controls.Add(Me.LabelStartingTime)
        Me.PanelDisplay.Controls.Add(Me.RadioButtonShedule)
        Me.PanelDisplay.Controls.Add(Me.RadioButtonSnow)
        Me.PanelDisplay.Location = New System.Drawing.Point(12, 53)
        Me.PanelDisplay.Name = "PanelDisplay"
        Me.PanelDisplay.Size = New System.Drawing.Size(328, 131)
        Me.PanelDisplay.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Min"
        '
        'TextBoxSmin
        '
        Me.TextBoxSmin.Location = New System.Drawing.Point(212, 74)
        Me.TextBoxSmin.Name = "TextBoxSmin"
        Me.TextBoxSmin.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxSmin.TabIndex = 10
        Me.TextBoxSmin.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hr"
        '
        'TextBoxSHr
        '
        Me.TextBoxSHr.Location = New System.Drawing.Point(129, 74)
        Me.TextBoxSHr.Name = "TextBoxSHr"
        Me.TextBoxSHr.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxSHr.TabIndex = 7
        Me.TextBoxSHr.Text = "0"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(104, 140)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(132, 13)
        Me.Label.TabIndex = 9
        Me.Label.Text = "Exam Sheduled at  12 : 00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Press Cancel to Abourt"
        '
        'TimerStop
        '
        Me.TimerStop.Interval = 60000
        '
        'Timerstart
        '
        Me.Timerstart.Interval = 3000
        '
        'TimerCurrentTime
        '
        Me.TimerCurrentTime.Interval = 3000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.eXaminerHost.My.Resources.Resources.anim_wait
        Me.PictureBox1.Location = New System.Drawing.Point(136, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(356, 50)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'ButtonRest
        '
        Me.ButtonRest.Location = New System.Drawing.Point(33, 190)
        Me.ButtonRest.Name = "ButtonRest"
        Me.ButtonRest.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRest.TabIndex = 13
        Me.ButtonRest.Text = "Reset"
        Me.ButtonRest.UseVisualStyleBackColor = True
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(132, 190)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 14
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(235, 190)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 12
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'StartExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 224)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.ButtonRest)
        Me.Controls.Add(Me.PanelDisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StartExam"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Host 2007"
        Me.PanelDisplay.ResumeLayout(False)
        Me.PanelDisplay.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButtonSnow As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonShedule As System.Windows.Forms.RadioButton
    Friend WithEvents LabelStartingTime As System.Windows.Forms.Label
    Friend WithEvents PanelDisplay As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimerStop As System.Windows.Forms.Timer
    Friend WithEvents Timerstart As System.Windows.Forms.Timer
    Friend WithEvents TimerCurrentTime As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSmin As NumericTextBox.TimeTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSHr As NumericTextBox.TimeTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonRest As System.Windows.Forms.Button
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
