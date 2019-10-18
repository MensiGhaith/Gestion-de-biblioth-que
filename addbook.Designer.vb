<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addbook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addbook))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bookadd = New System.Windows.Forms.Button()
        Me.pub = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.pubdate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.auth = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.Label()
        Me.cin111 = New System.Windows.Forms.Label()
        Me.titre = New System.Windows.Forms.TextBox()
        Me.genre = New System.Windows.Forms.TextBox()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.price)
        Me.GroupBox2.Controls.Add(Me.bookadd)
        Me.GroupBox2.Controls.Add(Me.pub)
        Me.GroupBox2.Controls.Add(Me.author)
        Me.GroupBox2.Controls.Add(Me.pubdate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.auth)
        Me.GroupBox2.Controls.Add(Me.title)
        Me.GroupBox2.Controls.Add(Me.cin111)
        Me.GroupBox2.Controls.Add(Me.titre)
        Me.GroupBox2.Controls.Add(Me.genre)
        Me.GroupBox2.Controls.Add(Me.isbn)
        Me.GroupBox2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(97, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(625, 333)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADD A BOOK"
        '
        'bookadd
        '
        Me.bookadd.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookadd.Location = New System.Drawing.Point(501, 294)
        Me.bookadd.Name = "bookadd"
        Me.bookadd.Size = New System.Drawing.Size(118, 33)
        Me.bookadd.TabIndex = 17
        Me.bookadd.Text = "ADD"
        Me.bookadd.UseVisualStyleBackColor = True
        '
        'pub
        '
        Me.pub.AccessibleName = ""
        Me.pub.AutoSize = True
        Me.pub.BackColor = System.Drawing.Color.Transparent
        Me.pub.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pub.Location = New System.Drawing.Point(1, 274)
        Me.pub.Name = "pub"
        Me.pub.Size = New System.Drawing.Size(145, 18)
        Me.pub.TabIndex = 11
        Me.pub.Text = " Publication's date"
        '
        'author
        '
        Me.author.AccessibleName = ""
        Me.author.AutoSize = True
        Me.author.BackColor = System.Drawing.Color.Transparent
        Me.author.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.Location = New System.Drawing.Point(27, 142)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(94, 29)
        Me.author.TabIndex = 10
        Me.author.Text = "Author"
        '
        'pubdate
        '
        Me.pubdate.CalendarFont = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pubdate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pubdate.Location = New System.Drawing.Point(152, 264)
        Me.pubdate.Name = "pubdate"
        Me.pubdate.Size = New System.Drawing.Size(200, 30)
        Me.pubdate.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AccessibleName = ""
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Genre"
        '
        'auth
        '
        Me.auth.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.auth.Location = New System.Drawing.Point(152, 147)
        Me.auth.Name = "auth"
        Me.auth.Size = New System.Drawing.Size(152, 27)
        Me.auth.TabIndex = 2
        '
        'title
        '
        Me.title.AccessibleName = ""
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(55, 92)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(66, 29)
        Me.title.TabIndex = 7
        Me.title.Text = "Title"
        '
        'cin111
        '
        Me.cin111.AccessibleName = ""
        Me.cin111.AutoSize = True
        Me.cin111.BackColor = System.Drawing.Color.Transparent
        Me.cin111.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin111.Location = New System.Drawing.Point(46, 45)
        Me.cin111.Name = "cin111"
        Me.cin111.Size = New System.Drawing.Size(75, 29)
        Me.cin111.TabIndex = 6
        Me.cin111.Text = "ISBN"
        '
        'titre
        '
        Me.titre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.Location = New System.Drawing.Point(152, 97)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(152, 27)
        Me.titre.TabIndex = 4
        '
        'genre
        '
        Me.genre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genre.Location = New System.Drawing.Point(152, 202)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(152, 27)
        Me.genre.TabIndex = 1
        '
        'isbn
        '
        Me.isbn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn.Location = New System.Drawing.Point(152, 50)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(152, 27)
        Me.isbn.TabIndex = 0
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
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 49)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'price
        '
        Me.price.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(448, 50)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(152, 27)
        Me.price.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AccessibleName = ""
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Price"
        '
        'addbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addbook"
        Me.Text = "addbook"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents bookadd As Button
    Friend WithEvents pub As Label
    Friend WithEvents author As Label
    Friend WithEvents pubdate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents auth As TextBox
    Friend WithEvents title As Label
    Friend WithEvents cin111 As Label
    Friend WithEvents titre As TextBox
    Friend WithEvents genre As TextBox
    Friend WithEvents isbn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents price As TextBox
    Friend WithEvents Label1 As Label
End Class
