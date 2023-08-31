<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_connect = New System.Windows.Forms.Button()
        Me.title_id_label = New System.Windows.Forms.Label()
        Me.short_title_label = New System.Windows.Forms.Label()
        Me.author_label = New System.Windows.Forms.Label()
        Me.media_type_label = New System.Windows.Forms.Label()
        Me.isbn_label = New System.Windows.Forms.Label()
        Me.department_label = New System.Windows.Forms.Label()
        Me.genre_label = New System.Windows.Forms.Label()
        Me.number_in_stock_label = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthorID = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_connect
        '
        Me.Btn_connect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_connect.Location = New System.Drawing.Point(174, 45)
        Me.Btn_connect.Name = "Btn_connect"
        Me.Btn_connect.Size = New System.Drawing.Size(88, 28)
        Me.Btn_connect.TabIndex = 0
        Me.Btn_connect.Text = "Connect"
        Me.Btn_connect.UseVisualStyleBackColor = False
        '
        'title_id_label
        '
        Me.title_id_label.AutoSize = True
        Me.title_id_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_id_label.Location = New System.Drawing.Point(442, 100)
        Me.title_id_label.Name = "title_id_label"
        Me.title_id_label.Size = New System.Drawing.Size(56, 20)
        Me.title_id_label.TabIndex = 1
        Me.title_id_label.Text = "Title Id"
        '
        'short_title_label
        '
        Me.short_title_label.AutoSize = True
        Me.short_title_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.short_title_label.Location = New System.Drawing.Point(439, 135)
        Me.short_title_label.Name = "short_title_label"
        Me.short_title_label.Size = New System.Drawing.Size(81, 20)
        Me.short_title_label.TabIndex = 2
        Me.short_title_label.Text = "Short Title"
        '
        'author_label
        '
        Me.author_label.AutoSize = True
        Me.author_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author_label.Location = New System.Drawing.Point(439, 161)
        Me.author_label.Name = "author_label"
        Me.author_label.Size = New System.Drawing.Size(57, 20)
        Me.author_label.TabIndex = 3
        Me.author_label.Text = "Author"
        '
        'media_type_label
        '
        Me.media_type_label.AutoSize = True
        Me.media_type_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.media_type_label.Location = New System.Drawing.Point(439, 188)
        Me.media_type_label.Name = "media_type_label"
        Me.media_type_label.Size = New System.Drawing.Size(90, 20)
        Me.media_type_label.TabIndex = 4
        Me.media_type_label.Text = "Media Type"
        '
        'isbn_label
        '
        Me.isbn_label.AutoSize = True
        Me.isbn_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn_label.Location = New System.Drawing.Point(439, 214)
        Me.isbn_label.Name = "isbn_label"
        Me.isbn_label.Size = New System.Drawing.Size(47, 20)
        Me.isbn_label.TabIndex = 5
        Me.isbn_label.Text = "ISBN"
        '
        'department_label
        '
        Me.department_label.AutoSize = True
        Me.department_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department_label.Location = New System.Drawing.Point(439, 263)
        Me.department_label.Name = "department_label"
        Me.department_label.Size = New System.Drawing.Size(94, 20)
        Me.department_label.TabIndex = 6
        Me.department_label.Text = "Department"
        '
        'genre_label
        '
        Me.genre_label.AutoSize = True
        Me.genre_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genre_label.Location = New System.Drawing.Point(439, 293)
        Me.genre_label.Name = "genre_label"
        Me.genre_label.Size = New System.Drawing.Size(54, 20)
        Me.genre_label.TabIndex = 7
        Me.genre_label.Text = "Genre"
        '
        'number_in_stock_label
        '
        Me.number_in_stock_label.AutoSize = True
        Me.number_in_stock_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number_in_stock_label.Location = New System.Drawing.Point(440, 325)
        Me.number_in_stock_label.Name = "number_in_stock_label"
        Me.number_in_stock_label.Size = New System.Drawing.Size(126, 20)
        Me.number_in_stock_label.TabIndex = 8
        Me.number_in_stock_label.Text = "Number in Stock"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(442, 356)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(44, 20)
        Me.Price.TabIndex = 9
        Me.Price.Text = "Price"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(571, 100)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(161, 20)
        Me.txtID.TabIndex = 10
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(571, 135)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(230, 20)
        Me.txtTitle.TabIndex = 11
        '
        'txtAuthorID
        '
        Me.txtAuthorID.Location = New System.Drawing.Point(571, 161)
        Me.txtAuthorID.Name = "txtAuthorID"
        Me.txtAuthorID.Size = New System.Drawing.Size(230, 20)
        Me.txtAuthorID.TabIndex = 12
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(571, 214)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(230, 20)
        Me.txtISBN.TabIndex = 13
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(571, 327)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(130, 20)
        Me.txtStock.TabIndex = 14
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(571, 358)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(130, 20)
        Me.txtPrice.TabIndex = 15
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(571, 187)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(230, 21)
        Me.cboType.TabIndex = 16
        '
        'cboDept
        '
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(571, 262)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(121, 21)
        Me.cboDept.TabIndex = 17
        '
        'cboGenre
        '
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(571, 292)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(121, 21)
        Me.cboGenre.TabIndex = 18
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_update.Location = New System.Drawing.Point(553, 411)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(192, 28)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(395, 407)
        Me.DataGridView1.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 515)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.cboDept)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtAuthorID)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.number_in_stock_label)
        Me.Controls.Add(Me.genre_label)
        Me.Controls.Add(Me.department_label)
        Me.Controls.Add(Me.isbn_label)
        Me.Controls.Add(Me.media_type_label)
        Me.Controls.Add(Me.author_label)
        Me.Controls.Add(Me.short_title_label)
        Me.Controls.Add(Me.title_id_label)
        Me.Controls.Add(Me.Btn_connect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_connect As Button
    Friend WithEvents title_id_label As Label
    Friend WithEvents short_title_label As Label
    Friend WithEvents author_label As Label
    Friend WithEvents media_type_label As Label
    Friend WithEvents isbn_label As Label
    Friend WithEvents department_label As Label
    Friend WithEvents genre_label As Label
    Friend WithEvents number_in_stock_label As Label
    Friend WithEvents Price As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthorID As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboDept As ComboBox
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents btn_update As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
