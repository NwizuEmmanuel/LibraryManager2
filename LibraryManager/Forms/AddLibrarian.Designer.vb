<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddLibrarian
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
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.LastnameLabel = New System.Windows.Forms.Label()
        Me.PhonenumberLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PhonenumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoleComboBox = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(266, 232)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 43)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.LightSlateGray
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.Black
        Me.OK_Button.Location = New System.Drawing.Point(4, 6)
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
        Me.Cancel_Button.BackColor = System.Drawing.Color.LightSlateGray
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.Black
        Me.Cancel_Button.Location = New System.Drawing.Point(89, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(76, 31)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.EmailTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PhonenumberLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.EmailLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PasswordLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PasswordTextBox, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.PhonenumberMaskedTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.RoleComboBox, 1, 5)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(14, 14)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(421, 191)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(111, 96)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(308, 25)
        Me.EmailTextBox.TabIndex = 8
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Location = New System.Drawing.Point(111, 34)
        Me.LastnameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(308, 25)
        Me.LastnameTextBox.TabIndex = 6
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Location = New System.Drawing.Point(4, 0)
        Me.FirstnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(75, 18)
        Me.FirstnameLabel.TabIndex = 0
        Me.FirstnameLabel.Text = "First Name"
        '
        'LastnameLabel
        '
        Me.LastnameLabel.AutoSize = True
        Me.LastnameLabel.Location = New System.Drawing.Point(4, 31)
        Me.LastnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastnameLabel.Name = "LastnameLabel"
        Me.LastnameLabel.Size = New System.Drawing.Size(73, 18)
        Me.LastnameLabel.TabIndex = 1
        Me.LastnameLabel.Text = "Last Name"
        '
        'PhonenumberLabel
        '
        Me.PhonenumberLabel.AutoSize = True
        Me.PhonenumberLabel.Location = New System.Drawing.Point(4, 62)
        Me.PhonenumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhonenumberLabel.Name = "PhonenumberLabel"
        Me.PhonenumberLabel.Size = New System.Drawing.Size(99, 18)
        Me.PhonenumberLabel.TabIndex = 2
        Me.PhonenumberLabel.Text = "Phone Number"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(4, 93)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(42, 18)
        Me.EmailLabel.TabIndex = 3
        Me.EmailLabel.Text = "Email"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(4, 124)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(68, 18)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(111, 3)
        Me.FirstnameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(308, 25)
        Me.FirstnameTextBox.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(111, 127)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(308, 25)
        Me.PasswordTextBox.TabIndex = 7
        '
        'PhonenumberMaskedTextBox
        '
        Me.PhonenumberMaskedTextBox.Location = New System.Drawing.Point(111, 65)
        Me.PhonenumberMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PhonenumberMaskedTextBox.Name = "PhonenumberMaskedTextBox"
        Me.PhonenumberMaskedTextBox.Size = New System.Drawing.Size(308, 25)
        Me.PhonenumberMaskedTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Role"
        '
        'RoleComboBox
        '
        Me.RoleComboBox.FormattingEnabled = True
        Me.RoleComboBox.Items.AddRange(New Object() {"admin", "user"})
        Me.RoleComboBox.Location = New System.Drawing.Point(110, 158)
        Me.RoleComboBox.Name = "RoleComboBox"
        Me.RoleComboBox.Size = New System.Drawing.Size(265, 26)
        Me.RoleComboBox.TabIndex = 11
        '
        'AddLibrarian
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.LibraryManager.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(451, 279)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddLibrarian"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Librarian"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LastnameTextBox As TextBox
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents LastnameLabel As Label
    Friend WithEvents PhonenumberLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents PhonenumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoleComboBox As ComboBox
End Class
