<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelFrames = New System.Windows.Forms.Label()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMask3 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMask2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMask1 = New System.Windows.Forms.RadioButton()
        Me.ButtonToGif = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownStep = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonRightLeft = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLeftRight = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDownUp = New System.Windows.Forms.RadioButton()
        Me.RadioButtonUpDown = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNone = New System.Windows.Forms.RadioButton()
        Me.ButtonOpenGif = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelRegion = New System.Windows.Forms.Label()
        Me.ButtonResetRegion = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonListAdd = New System.Windows.Forms.Button()
        Me.ButtonListDel = New System.Windows.Forms.Button()
        Me.ButtonListUp = New System.Windows.Forms.Button()
        Me.ButtonListDown = New System.Windows.Forms.Button()
        Me.ButtonListShow = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonToGifAll = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabelPath = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelCords = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckBoxInvert = New System.Windows.Forms.CheckBox()
        Me.ReverseListBox1 = New mask_img_generator.ReverseListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDownStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(839, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Тест"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelFrames
        '
        Me.LabelFrames.AutoSize = True
        Me.LabelFrames.Location = New System.Drawing.Point(839, 257)
        Me.LabelFrames.Name = "LabelFrames"
        Me.LabelFrames.Size = New System.Drawing.Size(36, 13)
        Me.LabelFrames.TabIndex = 2
        Me.LabelFrames.Text = "Frame"
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(8, 19)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(68, 23)
        Me.ButtonOpen.TabIndex = 12
        Me.ButtonOpen.Text = "Открыть"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(839, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 250)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'ButtonReload
        '
        Me.ButtonReload.Location = New System.Drawing.Point(889, 273)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Size = New System.Drawing.Size(50, 23)
        Me.ButtonReload.TabIndex = 22
        Me.ButtonReload.Text = "Сброс"
        Me.ButtonReload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonMask3)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMask2)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMask1)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 92)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Тип"
        '
        'RadioButtonMask3
        '
        Me.RadioButtonMask3.AutoSize = True
        Me.RadioButtonMask3.Location = New System.Drawing.Point(6, 65)
        Me.RadioButtonMask3.Name = "RadioButtonMask3"
        Me.RadioButtonMask3.Size = New System.Drawing.Size(107, 17)
        Me.RadioButtonMask3.TabIndex = 3
        Me.RadioButtonMask3.Text = "Своя раскладка"
        Me.RadioButtonMask3.UseVisualStyleBackColor = True
        '
        'RadioButtonMask2
        '
        Me.RadioButtonMask2.AutoSize = True
        Me.RadioButtonMask2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonMask2.Name = "RadioButtonMask2"
        Me.RadioButtonMask2.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonMask2.TabIndex = 1
        Me.RadioButtonMask2.Text = "Раскладка 2"
        Me.RadioButtonMask2.UseVisualStyleBackColor = True
        '
        'RadioButtonMask1
        '
        Me.RadioButtonMask1.AutoSize = True
        Me.RadioButtonMask1.Checked = True
        Me.RadioButtonMask1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonMask1.Name = "RadioButtonMask1"
        Me.RadioButtonMask1.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonMask1.TabIndex = 0
        Me.RadioButtonMask1.TabStop = True
        Me.RadioButtonMask1.Text = "Раскладка 1"
        Me.RadioButtonMask1.UseVisualStyleBackColor = True
        '
        'ButtonToGif
        '
        Me.ButtonToGif.Location = New System.Drawing.Point(8, 225)
        Me.ButtonToGif.Name = "ButtonToGif"
        Me.ButtonToGif.Size = New System.Drawing.Size(68, 23)
        Me.ButtonToGif.TabIndex = 24
        Me.ButtonToGif.Text = "to GIF"
        Me.ButtonToGif.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDownStep)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RadioButtonRightLeft)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLeftRight)
        Me.GroupBox2.Controls.Add(Me.RadioButtonDownUp)
        Me.GroupBox2.Controls.Add(Me.RadioButtonUpDown)
        Me.GroupBox2.Controls.Add(Me.RadioButtonNone)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 160)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Эффект прокрутки"
        '
        'NumericUpDownStep
        '
        Me.NumericUpDownStep.Location = New System.Drawing.Point(60, 134)
        Me.NumericUpDownStep.Name = "NumericUpDownStep"
        Me.NumericUpDownStep.Size = New System.Drawing.Size(55, 20)
        Me.NumericUpDownStep.TabIndex = 32
        Me.NumericUpDownStep.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Шаг"
        '
        'RadioButtonRightLeft
        '
        Me.RadioButtonRightLeft.AutoSize = True
        Me.RadioButtonRightLeft.Location = New System.Drawing.Point(16, 111)
        Me.RadioButtonRightLeft.Name = "RadioButtonRightLeft"
        Me.RadioButtonRightLeft.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonRightLeft.TabIndex = 4
        Me.RadioButtonRightLeft.Text = "RightLeft"
        Me.RadioButtonRightLeft.UseVisualStyleBackColor = True
        '
        'RadioButtonLeftRight
        '
        Me.RadioButtonLeftRight.AutoSize = True
        Me.RadioButtonLeftRight.Location = New System.Drawing.Point(16, 88)
        Me.RadioButtonLeftRight.Name = "RadioButtonLeftRight"
        Me.RadioButtonLeftRight.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonLeftRight.TabIndex = 3
        Me.RadioButtonLeftRight.Text = "LeftRight"
        Me.RadioButtonLeftRight.UseVisualStyleBackColor = True
        '
        'RadioButtonDownUp
        '
        Me.RadioButtonDownUp.AutoSize = True
        Me.RadioButtonDownUp.Location = New System.Drawing.Point(16, 42)
        Me.RadioButtonDownUp.Name = "RadioButtonDownUp"
        Me.RadioButtonDownUp.Size = New System.Drawing.Size(85, 17)
        Me.RadioButtonDownUp.TabIndex = 2
        Me.RadioButtonDownUp.Text = "СнизуВверх"
        Me.RadioButtonDownUp.UseVisualStyleBackColor = True
        '
        'RadioButtonUpDown
        '
        Me.RadioButtonUpDown.AutoSize = True
        Me.RadioButtonUpDown.Location = New System.Drawing.Point(16, 65)
        Me.RadioButtonUpDown.Name = "RadioButtonUpDown"
        Me.RadioButtonUpDown.Size = New System.Drawing.Size(85, 17)
        Me.RadioButtonUpDown.TabIndex = 1
        Me.RadioButtonUpDown.Text = "СверхуВниз"
        Me.RadioButtonUpDown.UseVisualStyleBackColor = True
        '
        'RadioButtonNone
        '
        Me.RadioButtonNone.AutoSize = True
        Me.RadioButtonNone.Checked = True
        Me.RadioButtonNone.Location = New System.Drawing.Point(16, 19)
        Me.RadioButtonNone.Name = "RadioButtonNone"
        Me.RadioButtonNone.Size = New System.Drawing.Size(42, 17)
        Me.RadioButtonNone.TabIndex = 0
        Me.RadioButtonNone.TabStop = True
        Me.RadioButtonNone.Text = "нет"
        Me.RadioButtonNone.UseVisualStyleBackColor = True
        '
        'ButtonOpenGif
        '
        Me.ButtonOpenGif.Location = New System.Drawing.Point(82, 225)
        Me.ButtonOpenGif.Name = "ButtonOpenGif"
        Me.ButtonOpenGif.Size = New System.Drawing.Size(68, 23)
        Me.ButtonOpenGif.TabIndex = 32
        Me.ButtonOpenGif.Text = "OpenGif"
        Me.ButtonOpenGif.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(569, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 250)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'LabelRegion
        '
        Me.LabelRegion.AutoSize = True
        Me.LabelRegion.Location = New System.Drawing.Point(575, 257)
        Me.LabelRegion.Name = "LabelRegion"
        Me.LabelRegion.Size = New System.Drawing.Size(40, 13)
        Me.LabelRegion.TabIndex = 35
        Me.LabelRegion.Text = "0,0,0,0"
        '
        'ButtonResetRegion
        '
        Me.ButtonResetRegion.Location = New System.Drawing.Point(569, 273)
        Me.ButtonResetRegion.Name = "ButtonResetRegion"
        Me.ButtonResetRegion.Size = New System.Drawing.Size(100, 23)
        Me.ButtonResetRegion.TabIndex = 36
        Me.ButtonResetRegion.Text = "Сбросить выбор"
        Me.ButtonResetRegion.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 173)
        Me.ListBox1.TabIndex = 4
        '
        'ButtonListAdd
        '
        Me.ButtonListAdd.Location = New System.Drawing.Point(6, 206)
        Me.ButtonListAdd.Name = "ButtonListAdd"
        Me.ButtonListAdd.Size = New System.Drawing.Size(83, 23)
        Me.ButtonListAdd.TabIndex = 37
        Me.ButtonListAdd.Text = "Добавить"
        Me.ButtonListAdd.UseVisualStyleBackColor = True
        '
        'ButtonListDel
        '
        Me.ButtonListDel.Location = New System.Drawing.Point(6, 235)
        Me.ButtonListDel.Name = "ButtonListDel"
        Me.ButtonListDel.Size = New System.Drawing.Size(83, 23)
        Me.ButtonListDel.TabIndex = 38
        Me.ButtonListDel.Text = "Удалить"
        Me.ButtonListDel.UseVisualStyleBackColor = True
        '
        'ButtonListUp
        '
        Me.ButtonListUp.Location = New System.Drawing.Point(132, 19)
        Me.ButtonListUp.Name = "ButtonListUp"
        Me.ButtonListUp.Size = New System.Drawing.Size(23, 23)
        Me.ButtonListUp.TabIndex = 39
        Me.ButtonListUp.Text = "↑"
        Me.ButtonListUp.UseVisualStyleBackColor = True
        '
        'ButtonListDown
        '
        Me.ButtonListDown.Location = New System.Drawing.Point(132, 48)
        Me.ButtonListDown.Name = "ButtonListDown"
        Me.ButtonListDown.Size = New System.Drawing.Size(23, 23)
        Me.ButtonListDown.TabIndex = 40
        Me.ButtonListDown.Text = "↓"
        Me.ButtonListDown.UseVisualStyleBackColor = True
        '
        'ButtonListShow
        '
        Me.ButtonListShow.Location = New System.Drawing.Point(6, 263)
        Me.ButtonListShow.Name = "ButtonListShow"
        Me.ButtonListShow.Size = New System.Drawing.Size(83, 23)
        Me.ButtonListShow.TabIndex = 41
        Me.ButtonListShow.Text = "Показать"
        Me.ButtonListShow.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Controls.Add(Me.ButtonListShow)
        Me.GroupBox3.Controls.Add(Me.ButtonListDown)
        Me.GroupBox3.Controls.Add(Me.ButtonListAdd)
        Me.GroupBox3.Controls.Add(Me.ButtonListUp)
        Me.GroupBox3.Controls.Add(Me.ButtonListDel)
        Me.GroupBox3.Location = New System.Drawing.Point(675, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 292)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Регионы"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonToGifAll)
        Me.GroupBox4.Controls.Add(Me.ReverseListBox1)
        Me.GroupBox4.Controls.Add(Me.ButtonToGif)
        Me.GroupBox4.Controls.Add(Me.ButtonOpenGif)
        Me.GroupBox4.Controls.Add(Me.ButtonOpen)
        Me.GroupBox4.Location = New System.Drawing.Point(268, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 284)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Файлы"
        '
        'ButtonToGifAll
        '
        Me.ButtonToGifAll.Location = New System.Drawing.Point(8, 255)
        Me.ButtonToGifAll.Name = "ButtonToGifAll"
        Me.ButtonToGifAll.Size = New System.Drawing.Size(68, 23)
        Me.ButtonToGifAll.TabIndex = 46
        Me.ButtonToGifAll.Text = "to Gif ALL"
        Me.ButtonToGifAll.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabelPath, Me.StatusLabelCords})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 307)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(952, 22)
        Me.StatusStrip1.TabIndex = 44
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabelPath
        '
        Me.StatusLabelPath.Name = "StatusLabelPath"
        Me.StatusLabelPath.Size = New System.Drawing.Size(100, 17)
        Me.StatusLabelPath.Text = "Откройте файлы"
        '
        'StatusLabelCords
        '
        Me.StatusLabelCords.Name = "StatusLabelCords"
        Me.StatusLabelCords.Size = New System.Drawing.Size(837, 17)
        Me.StatusLabelCords.Spring = True
        Me.StatusLabelCords.Text = "x y"
        Me.StatusLabelCords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxInvert
        '
        Me.CheckBoxInvert.AutoSize = True
        Me.CheckBoxInvert.Location = New System.Drawing.Point(432, 279)
        Me.CheckBoxInvert.Name = "CheckBoxInvert"
        Me.CheckBoxInvert.Size = New System.Drawing.Size(82, 17)
        Me.CheckBoxInvert.TabIndex = 45
        Me.CheckBoxInvert.Text = "InvertColors"
        Me.CheckBoxInvert.UseVisualStyleBackColor = True
        '
        'ReverseListBox1
        '
        Me.ReverseListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ReverseListBox1.FormattingEnabled = True
        Me.ReverseListBox1.Location = New System.Drawing.Point(8, 48)
        Me.ReverseListBox1.Name = "ReverseListBox1"
        Me.ReverseListBox1.Size = New System.Drawing.Size(142, 173)
        Me.ReverseListBox1.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 329)
        Me.Controls.Add(Me.CheckBoxInvert)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonResetRegion)
        Me.Controls.Add(Me.LabelRegion)
        Me.Controls.Add(Me.ButtonReload)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelFrames)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RamLedPoi Image Generator v0.01"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDownStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelFrames As System.Windows.Forms.Label
    Friend WithEvents ButtonOpen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonReload As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonMask3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMask2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMask1 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonToGif As System.Windows.Forms.Button
    Friend WithEvents ReverseListBox1 As mask_img_generator.ReverseListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonRightLeft As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLeftRight As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDownUp As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUpDown As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNone As System.Windows.Forms.RadioButton
    Friend WithEvents NumericUpDownStep As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonOpenGif As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelRegion As System.Windows.Forms.Label
    Friend WithEvents ButtonResetRegion As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ButtonListAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonListDel As System.Windows.Forms.Button
    Friend WithEvents ButtonListUp As System.Windows.Forms.Button
    Friend WithEvents ButtonListDown As System.Windows.Forms.Button
    Friend WithEvents ButtonListShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabelPath As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLabelCords As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckBoxInvert As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonToGifAll As System.Windows.Forms.Button

End Class
