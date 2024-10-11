Imports System.Configuration
Imports System.Data.SqlClient

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Dim connString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username = EmailTextBox.Text
        Dim password = PasswordTextBox.Text

        If UserCheckBox.Checked Then
            Using connection As New SqlConnection(connString)
                Dim query = "
                SELECT [LibrarianId],[FirstName],[LastName],[PhoneNumber],[Role] FROM [Librarians] WHERE [Email]=@email AND
                [Password]=@pass and Role='user'
"
                Using command As New SqlCommand(query, connection)
                    Try
                        connection.Open()

                        command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                        command.Parameters.AddWithValue("@pass", PasswordTextBox.Text)

                        Dim userCount As Integer = CInt(command.ExecuteScalar())
                        Dim reader = command.ExecuteReader()
                        If userCount > 0 Then
                            ' Go to next form
                            While reader.Read()
                                Whoami.Firstname = reader("FirstName")
                                Whoami.Lastname = reader("LastName")
                                Whoami.PhoneNumber = reader("PhoneNumber")
                                Whoami.ID = reader("LibrarianId")
                                Whoami.Role = reader("Role")
                            End While
                            Me.Hide()
                            MainMenu.Show()
                        Else
                            MessageBox.Show("User does not exists.")
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        Else
            Using connection As New SqlConnection(connString)
                Dim query = "
                SELECT [LibrarianId],[FirstName],[LastName],[PhoneNumber],[Role] FROM [Librarians] WHERE [Email]=@email AND
                [Password]=@pass and Role='admin'
"
                Using command As New SqlCommand(query, connection)
                    Try
                        connection.Open()

                        command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                        command.Parameters.AddWithValue("@pass", PasswordTextBox.Text)

                        Dim userCount As Integer = CInt(command.ExecuteScalar())
                        Dim reader = command.ExecuteReader()
                        If userCount > 0 Then
                            ' Go to next form
                            While reader.Read()
                                Whoami.Firstname = reader("FirstName")
                                Whoami.Lastname = reader("LastName")
                                Whoami.PhoneNumber = reader("PhoneNumber")
                                Whoami.ID = reader("LibrarianId")
                                Whoami.Role = reader("Role")
                            End While
                            Me.Hide()
                            MainMenu.Show()
                        Else
                            MessageBox.Show("Admin does not exists. ")
                        End If

                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
