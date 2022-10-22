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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.dealerHomer
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(398, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Deal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(285, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 55)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stay"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(638, 438)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 55)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Split"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 275)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Betting"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Double ($):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Insur ($):"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(92, 234)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Double ($):"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(92, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(89, 164)
        Me.Label10.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Label10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Split ($):"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(92, 201)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 9
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(32, 130)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 21)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Insurance"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(32, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(113, 21)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No Insurance"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(92, 18)
        Me.Label7.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Label7"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(90, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Stack ($):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Bet ($):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(230, 33)
        Me.Label1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "22"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(229, 441)
        Me.Label2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 50)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "22"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1053, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 55)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Help"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(997, 441)
        Me.Label9.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 50)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "22"
        Me.Label9.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cardBack.JPG")
        Me.ImageList1.Images.SetKeyName(1, "a_S.JPG")
        Me.ImageList1.Images.SetKeyName(2, "two_S.JPG")
        Me.ImageList1.Images.SetKeyName(3, "three_S.JPG")
        Me.ImageList1.Images.SetKeyName(4, "four_S.JPG")
        Me.ImageList1.Images.SetKeyName(5, "five_S.JPG")
        Me.ImageList1.Images.SetKeyName(6, "six_S.JPG")
        Me.ImageList1.Images.SetKeyName(7, "seven_S.JPG")
        Me.ImageList1.Images.SetKeyName(8, "eight_S.JPG")
        Me.ImageList1.Images.SetKeyName(9, "nine_S.JPG")
        Me.ImageList1.Images.SetKeyName(10, "ten_S.JPG")
        Me.ImageList1.Images.SetKeyName(11, "j_S.JPG")
        Me.ImageList1.Images.SetKeyName(12, "q_S.JPG")
        Me.ImageList1.Images.SetKeyName(13, "k_S.JPG")
        Me.ImageList1.Images.SetKeyName(14, "a_H.JPG")
        Me.ImageList1.Images.SetKeyName(15, "two_H.JPG")
        Me.ImageList1.Images.SetKeyName(16, "three_H.JPG")
        Me.ImageList1.Images.SetKeyName(17, "four_H.JPG")
        Me.ImageList1.Images.SetKeyName(18, "five_H.JPG")
        Me.ImageList1.Images.SetKeyName(19, "six_H.JPG")
        Me.ImageList1.Images.SetKeyName(20, "seven_H.JPG")
        Me.ImageList1.Images.SetKeyName(21, "eight_H.JPG")
        Me.ImageList1.Images.SetKeyName(22, "nine_H.JPG")
        Me.ImageList1.Images.SetKeyName(23, "ten_H.JPG")
        Me.ImageList1.Images.SetKeyName(24, "j_H.JPG")
        Me.ImageList1.Images.SetKeyName(25, "q_H.JPG")
        Me.ImageList1.Images.SetKeyName(26, "k_H.JPG")
        Me.ImageList1.Images.SetKeyName(27, "a_D.JPG")
        Me.ImageList1.Images.SetKeyName(28, "two_D.JPG")
        Me.ImageList1.Images.SetKeyName(29, "three_D.JPG")
        Me.ImageList1.Images.SetKeyName(30, "four_D.JPG")
        Me.ImageList1.Images.SetKeyName(31, "five_D.JPG")
        Me.ImageList1.Images.SetKeyName(32, "six_D.JPG")
        Me.ImageList1.Images.SetKeyName(33, "seven_D.JPG")
        Me.ImageList1.Images.SetKeyName(34, "eight_D.JPG")
        Me.ImageList1.Images.SetKeyName(35, "nine_D.JPG")
        Me.ImageList1.Images.SetKeyName(36, "ten_D.JPG")
        Me.ImageList1.Images.SetKeyName(37, "j_D.JPG")
        Me.ImageList1.Images.SetKeyName(38, "q_D.JPG")
        Me.ImageList1.Images.SetKeyName(39, "k_D.JPG")
        Me.ImageList1.Images.SetKeyName(40, "a_C.JPG")
        Me.ImageList1.Images.SetKeyName(41, "two_C.JPG")
        Me.ImageList1.Images.SetKeyName(42, "three_C.JPG")
        Me.ImageList1.Images.SetKeyName(43, "four_C.JPG")
        Me.ImageList1.Images.SetKeyName(44, "five_C.JPG")
        Me.ImageList1.Images.SetKeyName(45, "six_C.JPG")
        Me.ImageList1.Images.SetKeyName(46, "seven_C.JPG")
        Me.ImageList1.Images.SetKeyName(47, "eight_C.JPG")
        Me.ImageList1.Images.SetKeyName(48, "nine_C.JPG")
        Me.ImageList1.Images.SetKeyName(49, "ten_C.JPG")
        Me.ImageList1.Images.SetKeyName(50, "j_C.JPG")
        Me.ImageList1.Images.SetKeyName(51, "q_C.JPG")
        Me.ImageList1.Images.SetKeyName(52, "k_C.JPG")
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1053, 12)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(241, 219)
        Me.TextBox4.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(516, 438)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 55)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Double"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(767, 438)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 55)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Stay"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(874, 438)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(113, 55)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Double"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(1178, 438)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 55)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "Exit"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.tableTop
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1306, 524)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
