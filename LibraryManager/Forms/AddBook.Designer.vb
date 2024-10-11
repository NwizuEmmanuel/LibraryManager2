<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBookDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.AuthorsLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.PublisherLabel = New System.Windows.Forms.Label()
        Me.PublisherDateLabel = New System.Windows.Forms.Label()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AuthorDescriptionLabel = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.PubDateMonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.PublisherComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.NumericUpDown()
        Me.ExistingBookCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(427, 464)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.SlateBlue
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.OK_Button.Location = New System.Drawing.Point(4, 7)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(76, 31)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.SlateBlue
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel_Button.Location = New System.Drawing.Point(89, 7)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(76, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BookTitleTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TitleLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ISBNLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.AuthorsLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CategoryLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PublisherLabel, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.PublisherDateLabel, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ISBNTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CategoryComboBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PubDateMonthCalendar, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.PublisherComboBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Quantity, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.ExistingBookCheckBox, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(14, 14)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(583, 442)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookTitleTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookTitleTextBox.Location = New System.Drawing.Point(162, 61)
        Me.BookTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(417, 25)
        Me.BookTitleTextBox.TabIndex = 8
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(4, 58)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(70, 17)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Book Title*"
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNLabel.Location = New System.Drawing.Point(4, 27)
        Me.ISBNLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(40, 17)
        Me.ISBNLabel.TabIndex = 0
        Me.ISBNLabel.Text = "ISBN*"
        '
        'AuthorsLabel
        '
        Me.AuthorsLabel.AutoSize = True
        Me.AuthorsLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorsLabel.Location = New System.Drawing.Point(4, 89)
        Me.AuthorsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AuthorsLabel.Name = "AuthorsLabel"
        Me.AuthorsLabel.Size = New System.Drawing.Size(58, 17)
        Me.AuthorsLabel.TabIndex = 3
        Me.AuthorsLabel.Text = "Authors*"
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryLabel.Location = New System.Drawing.Point(4, 161)
        Me.CategoryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(61, 17)
        Me.CategoryLabel.TabIndex = 4
        Me.CategoryLabel.Text = "Category"
        '
        'PublisherLabel
        '
        Me.PublisherLabel.AutoSize = True
        Me.PublisherLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherLabel.Location = New System.Drawing.Point(4, 192)
        Me.PublisherLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublisherLabel.Name = "PublisherLabel"
        Me.PublisherLabel.Size = New System.Drawing.Size(61, 17)
        Me.PublisherLabel.TabIndex = 5
        Me.PublisherLabel.Text = "Publisher"
        '
        'PublisherDateLabel
        '
        Me.PublisherDateLabel.AutoSize = True
        Me.PublisherDateLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherDateLabel.Location = New System.Drawing.Point(4, 223)
        Me.PublisherDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublisherDateLabel.Name = "PublisherDateLabel"
        Me.PublisherDateLabel.Size = New System.Drawing.Size(80, 17)
        Me.PublisherDateLabel.TabIndex = 6
        Me.PublisherDateLabel.Text = "Publish Date"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ISBNTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNTextBox.Location = New System.Drawing.Point(162, 30)
        Me.ISBNTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(417, 25)
        Me.ISBNTextBox.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AuthorDescriptionLabel)
        Me.Panel1.Controls.Add(Me.AuthorTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(158, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 72)
        Me.Panel1.TabIndex = 9
        '
        'AuthorDescriptionLabel
        '
        Me.AuthorDescriptionLabel.AutoSize = True
        Me.AuthorDescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorDescriptionLabel.Location = New System.Drawing.Point(4, 30)
        Me.AuthorDescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AuthorDescriptionLabel.Name = "AuthorDescriptionLabel"
        Me.AuthorDescriptionLabel.Size = New System.Drawing.Size(236, 34)
        Me.AuthorDescriptionLabel.TabIndex = 4
        Me.AuthorDescriptionLabel.Text = "Use comma for more than one authors" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex. John Doe,Adam Williams"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(4, 3)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(417, 25)
        Me.AuthorTextBox.TabIndex = 1
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CategoryComboBox.DisplayMember = "Category"
        Me.CategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(162, 164)
        Me.CategoryComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(417, 25)
        Me.CategoryComboBox.TabIndex = 10
        Me.CategoryComboBox.ValueMember = "Category"
        '
        'PubDateMonthCalendar
        '
        Me.PubDateMonthCalendar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PubDateMonthCalendar.Location = New System.Drawing.Point(168, 233)
        Me.PubDateMonthCalendar.Margin = New System.Windows.Forms.Padding(10)
        Me.PubDateMonthCalendar.Name = "PubDateMonthCalendar"
        Me.PubDateMonthCalendar.TabIndex = 12
        '
        'PublisherComboBox
        '
        Me.PublisherComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublisherComboBox.DisplayMember = "Publisher"
        Me.PublisherComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherComboBox.FormattingEnabled = True
        Me.PublisherComboBox.Location = New System.Drawing.Point(162, 195)
        Me.PublisherComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PublisherComboBox.Name = "PublisherComboBox"
        Me.PublisherComboBox.Size = New System.Drawing.Size(417, 25)
        Me.PublisherComboBox.TabIndex = 13
        Me.PublisherComboBox.ValueMember = "Publisher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 405)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Quantity"
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(162, 408)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Quantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(140, 25)
        Me.Quantity.TabIndex = 15
        Me.Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ExistingBookCheckBox
        '
        Me.ExistingBookCheckBox.AutoSize = True
        Me.ExistingBookCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistingBookCheckBox.Location = New System.Drawing.Point(4, 3)
        Me.ExistingBookCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ExistingBookCheckBox.Name = "ExistingBookCheckBox"
        Me.ExistingBookCheckBox.Size = New System.Drawing.Size(150, 21)
        Me.ExistingBookCheckBox.TabIndex = 16
        Me.ExistingBookCheckBox.Text = "Adding Existing Book"
        Me.ExistingBookCheckBox.UseVisualStyleBackColor = True
        '
        'AddBookDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(610, 512)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddBookDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Book"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents AuthorsLabel As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents PublisherLabel As Label
    Friend WithEvents PublisherDateLabel As Label
    Friend WithEvents BookTitleTextBox As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents PubDateMonthCalendar As MonthCalendar
    Friend WithEvents PublisherComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AuthorDescriptionLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Quantity As NumericUpDown
    Friend WithEvents ExistingBookCheckBox As CheckBox
End Class
