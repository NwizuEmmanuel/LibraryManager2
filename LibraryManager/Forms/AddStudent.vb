Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AddStudent
    Private Function AddNewStudent()
        Dim hasNoError = True
        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                "insert into [Students] (StudentId,Firstname,Lastname,Sex,Department,Email,PhoneNumber,Address) values 
                (@studentid,@fname,@lname,@sex,@department,@email,@phonenumber,@address)",
                connection
                )
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@fname", FirstnameTextBox.Text)
                    command.Parameters.AddWithValue("@lname", LastnameTextBox.Text)
                    Dim studentSex = Nothing
                    If MaleRadioButton.Checked Then
                        studentSex = "male"
                    ElseIf FemaleRadioButton.Checked Then
                        studentSex = "female"
                    ElseIf OthersRadioButton.Checked Then
                        studentSex = "others"
                    End If
                    command.Parameters.AddWithValue("@sex", studentSex)
                    command.Parameters.AddWithValue("@department", DepartmentTextBox.Text)
                    command.Parameters.AddWithValue("@email", EmailTextBox.Text)
                    command.Parameters.AddWithValue("@phonenumber", PhoneNumberTextBox.Text)
                    command.Parameters.AddWithValue("@address", AddressTextBox.Text)
                    command.Parameters.AddWithValue("@studentid", StudentIDTextBox.Text)

                    command.ExecuteNonQuery()
                Catch ex As Exception
                    hasNoError = False
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
        Return hasNoError
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If AddNewStudent() <> False Then
            MessageBox.Show("New Student added.")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
