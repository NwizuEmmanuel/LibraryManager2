Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AddBookDialog
    Dim connString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

    Private Function AuthorDataCleaner(data As String)
        Dim result As String = Nothing

        Dim strings As String() = data.Trim.Split(",")
        Dim index = 0
        For Each item In strings
            index += 1
            If index = strings.Count - 1 Then
                result += item
            Else
                result += item.Trim & ","
            End If
        Next

        Return result
    End Function

    Private Function AddNewBook()
        Dim noError = True
        Try
            Using connection As New SqlConnection(connString)
                Using command As New SqlCommand(
                    "insert into Books (ISBN,Title,Category,Publisher,PublishedDate,Authors,Quantity) values (@isbn,@title,@category,@publisher,@publishedDate,@authors,@quantity)",
                    connection
                    )
                    connection.Open()
                    command.Parameters.AddWithValue("@isbn", ISBNTextBox.Text)
                    command.Parameters.AddWithValue("@title", BookTitleTextBox.Text)
                    command.Parameters.AddWithValue("@category", CategoryComboBox.Text)
                    command.Parameters.AddWithValue("@publisher", PublisherComboBox.Text)
                    Dim pubDate As DateTime = DateTime.Parse(PubDateMonthCalendar.SelectionStart.ToLongDateString)
                    command.Parameters.AddWithValue("@publishedDate", pubDate)
                    command.Parameters.AddWithValue("@authors", AuthorDataCleaner(AuthorTextBox.Text))
                    command.Parameters.AddWithValue("@quantity", Quantity.Value)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            noError = False
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return noError
    End Function

    Private Sub LoadCategory()
        Using conn As New SqlConnection(connString)
            Using command As New SqlCommand("select distinct [Category] from [dbo].[Books]", conn)
                conn.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                CategoryComboBox.Items.Clear()
                While reader.Read()
                    CategoryComboBox.Items.Add(reader("Category").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub LoadPublisher()
        Using conn As New SqlConnection(connString)
            Using command As New SqlCommand("select distinct [Publisher] from [dbo].[Books]", conn)
                conn.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                PublisherComboBox.Items.Clear()
                While reader.Read()
                    PublisherComboBox.Items.Add(reader("Publisher").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub UpdateBookQuantity()
        Dim isbn = ISBNTextBox.Text
        Dim query = "update Books set Quantity=Quantity + @quantity where ISBN=@isbn"
        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@quantity", Quantity.Text)
                    command.Parameters.AddWithValue("@isbn", isbn)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Quantity updated.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ExistingBookCheckBox.Checked Then
            UpdateBookQuantity()
        Else
            If AddNewBook() <> False Then
                MessageBox.Show("Book Added")
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCategory()
        LoadPublisher()
    End Sub

    Private Sub ExistingBookCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExistingBookCheckBox.CheckedChanged
        If ExistingBookCheckBox.Checked Then
            BookTitleTextBox.Enabled = False
            AuthorTextBox.Enabled = False
            CategoryComboBox.Enabled = False
            PublisherComboBox.Enabled = False
            PubDateMonthCalendar.Enabled = False
            PubDateMonthCalendar.Visible = False
            PublisherDateLabel.Visible = False
        Else
            BookTitleTextBox.Enabled = True
            AuthorTextBox.Enabled = True
            CategoryComboBox.Enabled = True
            PublisherComboBox.Enabled = True
            PubDateMonthCalendar.Enabled = True
            PubDateMonthCalendar.Visible = True
            PublisherDateLabel.Visible = True
        End If
    End Sub
End Class
