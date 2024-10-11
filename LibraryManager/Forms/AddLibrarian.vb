Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AddLibrarian
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

    Private Function AddLibrarian() As Boolean
        Dim noError = True
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                "insert into [Librarians] (Firstname,Lastname,Email,PhoneNumber,Password,Role) values (@fname,@lname,@email,@phone,@pass,@role)",
                connection)
                connection.Open()
                command.Parameters.AddWithValue("@fname", FirstnameTextBox.Text)
                command.Parameters.AddWithValue("lname", LastnameTextBox.Text)
                command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                command.Parameters.AddWithValue("@phone", PhonenumberMaskedTextBox.Text)
                command.Parameters.AddWithValue("@pass", PasswordTextBox.Text)
                command.Parameters.AddWithValue("role", RoleComboBox.Text)
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    noError = False
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        Return noError
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If AddLibrarian() <> False Then
            MessageBox.Show("Success.")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
