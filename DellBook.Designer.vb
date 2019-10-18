<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DellBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DellBook))
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.isbn8 = New System.Windows.Forms.Label()
        Me.DEL = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo
        '
        Me.combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(488, 118)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(181, 28)
        Me.combo.TabIndex = 0
        '
        'isbn8
        '
        Me.isbn8.AccessibleName = ""
        Me.isbn8.AutoSize = True
        Me.isbn8.BackColor = System.Drawing.Color.Transparent
        Me.isbn8.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn8.Location = New System.Drawing.Point(415, 118)
        Me.isbn8.Name = "isbn8"
        Me.isbn8.Size = New System.Drawing.Size(75, 29)
        Me.isbn8.TabIndex = 7
        Me.isbn8.Text = "ISBN"
        '
        'DEL
        '
        Me.DEL.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEL.Location = New System.Drawing.Point(509, 170)
        Me.DEL.Name = "DEL"
        Me.DEL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DEL.Size = New System.Drawing.Size(132, 37)
        Me.DEL.TabIndex = 8
        Me.DEL.Text = "DELETE"
        Me.DEL.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 49)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(757, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 33)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "X"
        '
        'DellBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DEL)
        Me.Controls.Add(Me.isbn8)
        Me.Controls.Add(Me.combo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DellBook"
        Me.Text = "DellBook"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo As ComboBox
    Friend WithEvents isbn8 As Label
    Friend WithEvents DEL As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
