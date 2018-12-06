<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(280, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 32)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Текущий средний балл:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button1.Location = New System.Drawing.Point(12, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "+1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button2.Location = New System.Drawing.Point(128, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "+0.1"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button3.Location = New System.Drawing.Point(244, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 35)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "+0.01"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCoral
        Me.Button4.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button4.Location = New System.Drawing.Point(12, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "-1"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCoral
        Me.Button5.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button5.Location = New System.Drawing.Point(128, 86)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "-0.1"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightCoral
        Me.Button6.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button6.Location = New System.Drawing.Point(244, 86)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(110, 35)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "-0.01"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightCoral
        Me.Button7.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button7.Location = New System.Drawing.Point(222, 245)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(132, 35)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "-1"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightCoral
        Me.Button9.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button9.Location = New System.Drawing.Point(12, 245)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(204, 35)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "-10"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button10.Location = New System.Drawing.Point(222, 204)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(132, 35)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "+1"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button12.Location = New System.Drawing.Point(12, 204)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(204, 35)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "+10"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Количество оценок:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(280, 165)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 32)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = "1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button19)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button18)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(384, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 272)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Оценок для исправления"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(178, 232)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(74, 32)
        Me.TextBox4.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Необходимо Х:"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button19.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button19.Location = New System.Drawing.Point(7, 169)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(341, 55)
        Me.Button19.TabIndex = 18
        Me.Button19.Text = "Рассчитать"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(133, 140)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(117, 23)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Получаем 4"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(10, 140)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(117, 23)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Получаем 5"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.LightCoral
        Me.Button13.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button13.Location = New System.Drawing.Point(238, 99)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(110, 35)
        Me.Button13.TabIndex = 15
        Me.Button13.Text = "-0.01"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.LightCoral
        Me.Button14.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button14.Location = New System.Drawing.Point(122, 99)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(110, 35)
        Me.Button14.TabIndex = 14
        Me.Button14.Text = "-0.1"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.LightCoral
        Me.Button15.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button15.Location = New System.Drawing.Point(6, 99)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(110, 35)
        Me.Button15.TabIndex = 13
        Me.Button15.Text = "-1"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button16.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button16.Location = New System.Drawing.Point(238, 58)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(110, 35)
        Me.Button16.TabIndex = 12
        Me.Button16.Text = "+0.01"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button17.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button17.Location = New System.Drawing.Point(122, 58)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(110, 35)
        Me.Button17.TabIndex = 11
        Me.Button17.Text = "+0.1"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button18.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.Button18.Location = New System.Drawing.Point(6, 58)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(110, 35)
        Me.Button18.TabIndex = 10
        Me.Button18.Text = "+1"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Необходимый средний балл:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(272, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(76, 30)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "3.5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(257, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "ver. 1.0-r1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(257, 149)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 14)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "vk.com/65zio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button19 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class