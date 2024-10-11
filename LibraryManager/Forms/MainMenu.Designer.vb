<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ScannerDataTable = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ManualModeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteBookButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ReturnStudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ReturnBookButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BorrowBookButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentIDTextbox = New System.Windows.Forms.TextBox()
        Me.DueDateComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewLibrarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowedBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarcodeGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScannerDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ScannerDataTable, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(776, 610)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.WelcomeLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 92)
        Me.Panel1.TabIndex = 0
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoEllipsis = True
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeLabel.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WelcomeLabel.Location = New System.Drawing.Point(98, 3)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(226, 36)
        Me.WelcomeLabel.TabIndex = 1
        Me.WelcomeLabel.Text = "Welcome Onyeka!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManager.My.Resources.Resources._2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ScannerDataTable
        '
        Me.ScannerDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ScannerDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ScannerDataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ScannerDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ScannerDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ScannerDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScannerDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScannerDataTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.ScannerDataTable.Location = New System.Drawing.Point(3, 149)
        Me.ScannerDataTable.Name = "ScannerDataTable"
        Me.ScannerDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ScannerDataTable.Size = New System.Drawing.Size(770, 216)
        Me.ScannerDataTable.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.ManualModeCheckBox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BarcodeTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 42)
        Me.Panel2.TabIndex = 2
        '
        'ManualModeCheckBox
        '
        Me.ManualModeCheckBox.AutoSize = True
        Me.ManualModeCheckBox.BackColor = System.Drawing.Color.LightSlateGray
        Me.ManualModeCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ManualModeCheckBox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualModeCheckBox.ForeColor = System.Drawing.Color.Black
        Me.ManualModeCheckBox.Location = New System.Drawing.Point(440, 10)
        Me.ManualModeCheckBox.Name = "ManualModeCheckBox"
        Me.ManualModeCheckBox.Size = New System.Drawing.Size(109, 22)
        Me.ManualModeCheckBox.TabIndex = 2
        Me.ManualModeCheckBox.Text = "Manual Mode"
        Me.ManualModeCheckBox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3)
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Barcode Here"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(143, 10)
        Me.BarcodeTextBox.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(291, 25)
        Me.BarcodeTextBox.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 371)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(770, 237)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.ClearButton)
        Me.GroupBox3.Controls.Add(Me.DeleteBookButton)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(381, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 87)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delete Section"
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.Black
        Me.ClearButton.Location = New System.Drawing.Point(92, 45)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(76, 31)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'DeleteBookButton
        '
        Me.DeleteBookButton.BackColor = System.Drawing.Color.LightSlateGray
        Me.DeleteBookButton.FlatAppearance.BorderSize = 0
        Me.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBookButton.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBookButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteBookButton.Location = New System.Drawing.Point(6, 45)
        Me.DeleteBookButton.Name = "DeleteBookButton"
        Me.DeleteBookButton.Size = New System.Drawing.Size(76, 31)
        Me.DeleteBookButton.TabIndex = 7
        Me.DeleteBookButton.Text = "Delete"
        Me.DeleteBookButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "The selected books in the table will be deleted"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ReturnStudentIdTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ReturnBookButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(381, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 137)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return Section"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Student ID"
        '
        'ReturnStudentIdTextBox
        '
        Me.ReturnStudentIdTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnStudentIdTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ReturnStudentIdTextBox.Location = New System.Drawing.Point(9, 64)
        Me.ReturnStudentIdTextBox.Name = "ReturnStudentIdTextBox"
        Me.ReturnStudentIdTextBox.Size = New System.Drawing.Size(167, 25)
        Me.ReturnStudentIdTextBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "The books in the table will returned"
        '
        'ReturnBookButton
        '
        Me.ReturnBookButton.BackColor = System.Drawing.Color.LightSlateGray
        Me.ReturnBookButton.FlatAppearance.BorderSize = 0
        Me.ReturnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBookButton.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBookButton.ForeColor = System.Drawing.Color.Black
        Me.ReturnBookButton.Location = New System.Drawing.Point(9, 100)
        Me.ReturnBookButton.Name = "ReturnBookButton"
        Me.ReturnBookButton.Size = New System.Drawing.Size(115, 31)
        Me.ReturnBookButton.TabIndex = 4
        Me.ReturnBookButton.Text = "Return book(s)"
        Me.ReturnBookButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BorrowBookButton)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.StudentIDTextbox)
        Me.GroupBox1.Controls.Add(Me.DueDateComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 225)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrow Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "The books in the table will be Borrowed"
        '
        'BorrowBookButton
        '
        Me.BorrowBookButton.BackColor = System.Drawing.Color.LightSlateGray
        Me.BorrowBookButton.FlatAppearance.BorderSize = 0
        Me.BorrowBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BorrowBookButton.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowBookButton.ForeColor = System.Drawing.Color.Black
        Me.BorrowBookButton.Location = New System.Drawing.Point(9, 106)
        Me.BorrowBookButton.Name = "BorrowBookButton"
        Me.BorrowBookButton.Size = New System.Drawing.Size(119, 31)
        Me.BorrowBookButton.TabIndex = 7
        Me.BorrowBookButton.Text = "Borrow Book(s)"
        Me.BorrowBookButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BorrowBookButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(6, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(182, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Due Date"
        '
        'StudentIDTextbox
        '
        Me.StudentIDTextbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDTextbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.StudentIDTextbox.Location = New System.Drawing.Point(9, 64)
        Me.StudentIDTextbox.Name = "StudentIDTextbox"
        Me.StudentIDTextbox.Size = New System.Drawing.Size(167, 25)
        Me.StudentIDTextbox.TabIndex = 0
        '
        'DueDateComboBox
        '
        Me.DueDateComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDateComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DueDateComboBox.FormattingEnabled = True
        Me.DueDateComboBox.Items.AddRange(New Object() {"5", "10", "15", "21"})
        Me.DueDateComboBox.Location = New System.Drawing.Point(180, 64)
        Me.DueDateComboBox.Name = "DueDateComboBox"
        Me.DueDateComboBox.Size = New System.Drawing.Size(167, 25)
        Me.DueDateComboBox.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Enabled = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.BorrowsToolStripMenuItem, Me.BarcodeGeneratorToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(776, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBookToolStripMenuItem, Me.NewStudentToolStripMenuItem, Me.NewLibrarianToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewBookToolStripMenuItem
        '
        Me.NewBookToolStripMenuItem.Name = "NewBookToolStripMenuItem"
        Me.NewBookToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewBookToolStripMenuItem.Text = "New Book"
        '
        'NewStudentToolStripMenuItem
        '
        Me.NewStudentToolStripMenuItem.Name = "NewStudentToolStripMenuItem"
        Me.NewStudentToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewStudentToolStripMenuItem.Text = "New Student"
        '
        'NewLibrarianToolStripMenuItem
        '
        Me.NewLibrarianToolStripMenuItem.Name = "NewLibrarianToolStripMenuItem"
        Me.NewLibrarianToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewLibrarianToolStripMenuItem.Text = "New Librarian"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateStudentToolStripMenuItem, Me.BookToolStripMenuItem, Me.LibrarianToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UpdateStudentToolStripMenuItem
        '
        Me.UpdateStudentToolStripMenuItem.Name = "UpdateStudentToolStripMenuItem"
        Me.UpdateStudentToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.UpdateStudentToolStripMenuItem.Text = "Student"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'LibrarianToolStripMenuItem
        '
        Me.LibrarianToolStripMenuItem.Name = "LibrarianToolStripMenuItem"
        Me.LibrarianToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LibrarianToolStripMenuItem.Text = "Librarian"
        '
        'BorrowsToolStripMenuItem
        '
        Me.BorrowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowedBookToolStripMenuItem})
        Me.BorrowsToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BorrowsToolStripMenuItem.Name = "BorrowsToolStripMenuItem"
        Me.BorrowsToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.BorrowsToolStripMenuItem.Text = "Borrows"
        '
        'BorrowedBookToolStripMenuItem
        '
        Me.BorrowedBookToolStripMenuItem.Name = "BorrowedBookToolStripMenuItem"
        Me.BorrowedBookToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BorrowedBookToolStripMenuItem.Text = "Borrowed Book"
        '
        'BarcodeGeneratorToolStripMenuItem
        '
        Me.BarcodeGeneratorToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeGeneratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BarcodeGeneratorToolStripMenuItem.Name = "BarcodeGeneratorToolStripMenuItem"
        Me.BarcodeGeneratorToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.BarcodeGeneratorToolStripMenuItem.Text = "Barcode Generator"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(776, 636)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScannerDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewLibrarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents ScannerDataTable As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents BorrowedBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualModeCheckBox As CheckBox
    Friend WithEvents ReturnBookButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DueDateComboBox As ComboBox
    Friend WithEvents StudentIDTextbox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BorrowBookButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DeleteBookButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ReturnStudentIdTextBox As TextBox
    Friend WithEvents BarcodeGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
