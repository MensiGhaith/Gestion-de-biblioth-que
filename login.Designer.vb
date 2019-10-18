<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.un = New System.Windows.Forms.Label()
        Me.pwd = New System.Windows.Forms.Label()
        Me.usern = New System.Windows.Forms.TextBox()
        Me.psd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'un
        '
        Me.un.AccessibleName = ""
        Me.un.AutoSize = True
        Me.un.BackColor = System.Drawing.Color.Transparent
        Me.un.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.un.Location = New System.Drawing.Point(330, 184)
        Me.un.Name = "un"
        Me.un.Size = New System.Drawing.Size(60, 29)
        Me.un.TabIndex = 0
        Me.un.Text = "CIN"
        '
        'pwd
        '
        Me.pwd.AccessibleName = ""
        Me.pwd.AutoSize = True
        Me.pwd.BackColor = System.Drawing.Color.Transparent
        Me.pwd.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.Location = New System.Drawing.Point(317, 247)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(128, 29)
        Me.pwd.TabIndex = 1
        Me.pwd.Text = "Password"
        '
        'usern
        '
        Me.usern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usern.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usern.Location = New System.Drawing.Point(462, 191)
        Me.usern.Name = "usern"
        Me.usern.Size = New System.Drawing.Size(161, 26)
        Me.usern.TabIndex = 2
        '
        'psd
        '
        Me.psd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.psd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psd.Location = New System.Drawing.Point(462, 254)
        Me.psd.Name = "psd"
        Me.psd.Size = New System.Drawing.Size(161, 26)
        Me.psd.TabIndex = 3
        Me.psd.UseSystemPasswordChar = True
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn1.Location = New System.Drawing.Point(317, 326)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(128, 33)
        Me.btn1.TabIndex = 5
        Me.btn1.Text = "LOGIN"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.psd)
        Me.Controls.Add(Me.usern)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.un)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents un As Label
    Friend WithEvents pwd As Label
    Friend WithEvents usern As TextBox
    Friend WithEvents psd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn1 As Button
End Class
