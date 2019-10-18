<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class upStudent
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(upStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_up1 = New System.Windows.Forms.Button()
        Me.ComboBox88 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox44 = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.CheckBox33 = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.uuutitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(757, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 49)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btn_up1
        '
        Me.btn_up1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_up1.Location = New System.Drawing.Point(300, 374)
        Me.btn_up1.Name = "btn_up1"
        Me.btn_up1.Size = New System.Drawing.Size(113, 31)
        Me.btn_up1.TabIndex = 44
        Me.btn_up1.Text = "UPDATE"
        Me.btn_up1.UseVisualStyleBackColor = True
        '
        'ComboBox88
        '
        Me.ComboBox88.FormattingEnabled = True
        Me.ComboBox88.Location = New System.Drawing.Point(300, 55)
        Me.ComboBox88.Name = "ComboBox88"
        Me.ComboBox88.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox88.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AccessibleName = ""
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(190, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(401, 31)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Which column you have to update?"
        '
        'CheckBox44
        '
        Me.CheckBox44.AutoSize = True
        Me.CheckBox44.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox44.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox44.Location = New System.Drawing.Point(196, 289)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(161, 33)
        Me.CheckBox44.TabIndex = 41
        Me.CheckBox44.Text = "Password?"
        Me.CheckBox44.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AccessibleName = ""
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(391, 290)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(128, 29)
        Me.Label44.TabIndex = 40
        Me.Label44.Text = "Password"
        Me.Label44.Visible = False
        '
        'TextBox33
        '
        Me.TextBox33.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox33.Location = New System.Drawing.Point(525, 295)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(152, 27)
        Me.TextBox33.TabIndex = 39
        Me.TextBox33.Visible = False
        '
        'CheckBox33
        '
        Me.CheckBox33.AutoSize = True
        Me.CheckBox33.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox33.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox33.Location = New System.Drawing.Point(196, 239)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(166, 33)
        Me.CheckBox33.TabIndex = 38
        Me.CheckBox33.Text = "Username?"
        Me.CheckBox33.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AccessibleName = ""
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(386, 240)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(133, 29)
        Me.Label33.TabIndex = 37
        Me.Label33.Text = "Username"
        Me.Label33.Visible = False
        '
        'TextBox22
        '
        Me.TextBox22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(525, 245)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(152, 27)
        Me.TextBox22.TabIndex = 36
        Me.TextBox22.Visible = False
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox22.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox22.Location = New System.Drawing.Point(196, 191)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(155, 33)
        Me.CheckBox22.TabIndex = 35
        Me.CheckBox22.Text = "Fullname?"
        Me.CheckBox22.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AccessibleName = ""
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(397, 192)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(122, 29)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Fullname"
        Me.Label22.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(525, 196)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(152, 27)
        Me.TextBox11.TabIndex = 33
        Me.TextBox11.Visible = False
        '
        'uuutitle
        '
        Me.uuutitle.AccessibleName = ""
        Me.uuutitle.AutoSize = True
        Me.uuutitle.BackColor = System.Drawing.Color.Transparent
        Me.uuutitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uuutitle.Location = New System.Drawing.Point(221, 45)
        Me.uuutitle.Name = "uuutitle"
        Me.uuutitle.Size = New System.Drawing.Size(51, 29)
        Me.uuutitle.TabIndex = 32
        Me.uuutitle.Text = "Cin"
        '
        'upStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_up1)
        Me.Controls.Add(Me.ComboBox88)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox44)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.TextBox33)
        Me.Controls.Add(Me.CheckBox33)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.CheckBox22)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.uuutitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "upStudent"
        Me.Text = "upStudent"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_up1 As Button
    Friend WithEvents ComboBox88 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox44 As CheckBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents CheckBox33 As CheckBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents uuutitle As Label
End Class
