Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Net

Public Class MainMenu
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim currentDataTable As DataTable

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        WelcomeLabel.Text = $"Welcome, {Whoami.Firstname} {Whoami.Lastname}"
        BarcodeTextBox.Focus()
        ScannerDataTable.ReadOnly = True
        ScannerDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        If Whoami.Role = "admin" Then
            MenuStrip1.Enabled = True
        ElseIf Whoami.Role = "user" Then
            MenuStrip1.Enabled = False
        End If
    End Sub

    Private Sub MainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLibrarianToolStripMenuItem.Click
        AddLibrarian.ShowDialog()
    End Sub

    Private Sub NewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBookToolStripMenuItem.Click
        AddBookDialog.ShowDialog()
    End Sub

    Private Sub NewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewStudentToolStripMenuItem.Click
        AddStudent.ShowDialog()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        ViewStudent.ShowDialog()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        ViewBook.ShowDialog()
    End Sub

    Private Sub LibrarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrarianToolStripMenuItem.Click
        ViewLibrarian.ShowDialog()
    End Sub

    Private Function IsDuplicateInGridView(ByVal columnName As String, ByVal valueToCheck As String) As Boolean
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In ScannerDataTable.Rows
            ' Skip the new row if it's a new row being added (to avoid errors)
            If Not row.IsNewRow Then
                ' Check if the value in the specified column matches the value to check
                If row.Cells(columnName).Value IsNot Nothing AndAlso row.Cells(columnName).Value.ToString() = valueToCheck Then
                    Return True ' Duplicate found
                End If
            End If
        Next
        Return False ' No duplicate found
    End Function


    Private Sub AddBook()
        Dim bookisbnCode As String = BarcodeTextBox.Text

        ' Check if the ISBN already exists in the DataGridView
        If IsDuplicateInGridView("ISBN", bookisbnCode) Then
            MessageBox.Show("This book with ISBN already exists in the list.")
            Exit Sub ' Stop further execution
        End If

        Dim newTable As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                "SELECT Title,ISBN,Authors,Category FROM Books WHERE ISBN=@isbnValue",
                connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@isbnValue", bookisbnCode)
                    Dim adapter As New SqlDataAdapter(command)

                    adapter.Fill(newTable)

                    currentDataTable = TryCast(ScannerDataTable.DataSource, DataTable)

                    If currentDataTable Is Nothing Then
                        ScannerDataTable.DataSource = newTable
                    Else
                        For Each row As DataRow In newTable.Rows
                            currentDataTable.ImportRow(row)
                        Next
                    End If

                Catch ex As Exception
                    MessageBox.Show("Book not found. " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BorrowedBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowedBookToolStripMenuItem.Click
        ViewBorrow.ShowDialog()
    End Sub

    Private Sub BarcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles BarcodeTextBox.TextChanged
        If Not ManualModeCheckBox.Checked Then
            AddBook()
        End If
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter And ManualModeCheckBox.Checked Then
            AddBook()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        DeleteSelectedRow()
    End Sub

    Private Sub DeleteSelectedRow()
        ' Check if any row is selected
        If ScannerDataTable.SelectedRows.Count > 0 Then
            ' Get the selected row's index
            Dim rowIndex As Integer = ScannerDataTable.SelectedRows(0).Index

            ' Get the current DataTable bound to the DataGridView
            Dim currentTable As DataTable = TryCast(ScannerDataTable.DataSource, DataTable)

            If currentTable IsNot Nothing AndAlso rowIndex >= 0 Then
                ' Get the ISBN or another unique key value for the selected row
                Dim isbnCode As String = ScannerDataTable.Rows(rowIndex).Cells("ISBN").Value.ToString()

                ' Remove the row from the DataTable
                currentTable.Rows(rowIndex).Delete()

                ' Update the DataGridView
                ScannerDataTable.DataSource = currentTable
                ScannerDataTable.Refresh()
            Else
                MessageBox.Show("No valid row selected.")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Function BorrowBook(isbnValue As String, studentId As Integer, borrowDate As Date, dueDate As Date, librarianId As Integer) As Boolean
        Dim hasNoError = True
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
            "INSERT INTO Borrows (BookId, StudentId, BorrowDate, DueDate, LibrarianId) " &
            "VALUES ((SELECT BookId FROM Books WHERE ISBN=@isbn AND Quantity > 0), @StudentId, @BorrowDate, @DueDate, @LibrarianId);", connection)

                ' Set parameters
                command.Parameters.AddWithValue("@isbn", isbnValue)
                command.Parameters.AddWithValue("@StudentId", studentId)
                command.Parameters.AddWithValue("@BorrowDate", borrowDate)
                command.Parameters.AddWithValue("@DueDate", dueDate)
                command.Parameters.AddWithValue("@LibrarianId", librarianId)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    hasNoError = False
                    MessageBox.Show("Error while borrowing the book: " & ex.Message)
                End Try
            End Using
            Using command As New SqlCommand("UPDATE Books SET Quantity=Quantity - 1 WHERE ISBN=@isbn", connection)
                Try
                    command.Parameters.AddWithValue("@isbn", isbnValue)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    hasNoError = False
                    MessageBox.Show("Error update book quatity: " & ex.Message)
                End Try
            End Using
        End Using
        Return hasNoError
    End Function

    Private Function ReturnBook(isbnValue As String, studentId As Integer, returnDate As Date) As Boolean
        Dim hasNoError = True
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
            "UPDATE Borrows SET ReturnDate = @ReturnDate " &
            "WHERE BookId = (SELECT BookId FROM Books WHERE ISBN=@isbn) AND StudentId = @StudentId AND ReturnDate IS NULL;", connection)

                ' Set parameters
                command.Parameters.AddWithValue("@ReturnDate", returnDate)
                command.Parameters.AddWithValue("@isbn", isbnValue)
                command.Parameters.AddWithValue("@StudentId", studentId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        MessageBox.Show("No active borrow record found for this book and student.")
                        hasNoError = False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error while returning the book: " & ex.Message)
                    hasNoError = False
                End Try
            End Using
            Using command As New SqlCommand("UPDATE Books SET Quantity=Quantity + 1 WHERE ISBN=@isbn", connection)
                Try
                    command.Parameters.AddWithValue("@isbn", isbnValue)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    hasNoError = False
                    MessageBox.Show("Error while borrowing the book: " & ex.Message)
                End Try
            End Using
        End Using
        Return hasNoError
    End Function

    Private Function CanBorrowBook(studentId As Integer, isbnValue As String) As Boolean
        Dim canBorrow As Boolean = True

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
            "SELECT COUNT(*) FROM Borrows WHERE BookId =(select BookId from Books where ISBN=@isbn) AND StudentId = @StudentId AND ReturnDate IS NULL", connection)

                ' Add parameters
                command.Parameters.AddWithValue("@isbn", isbnValue)
                command.Parameters.AddWithValue("@StudentId", studentId)

                Try
                    connection.Open()
                    Dim borrowCount As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If borrowCount > 0 Then
                        ' Student has already borrowed this book and not returned it
                        canBorrow = False
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error checking borrow status: " & ex.Message)
                End Try
            End Using
        End Using

        Return canBorrow
    End Function


    Private Sub BorrowBookButton_Click(sender As Object, e As EventArgs) Handles BorrowBookButton.Click
        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In ScannerDataTable.Rows
            ' Skip the new row if it's a new row being added
            If Not row.IsNewRow Then
                ' Access the value in the specified column
                Dim isbnValue As String = row.Cells("ISBN").Value.ToString()

                Dim bookISBN = isbnValue
                Dim studentId As Integer = Integer.Parse(StudentIDTextbox.Text)
                Dim borrowDate As Date = DateTime.Now
                Dim dueDate As Date = borrowDate.AddDays(DueDateComboBox.Text)
                Dim librarianId As Integer = Integer.Parse(Whoami.ID)
                If CanBorrowBook(studentId, bookISBN) Then
                    ' Proceed to borrow the book
                    ' (Insert borrow record in the Borrows table)
                    If BorrowBook(bookISBN, studentId, borrowDate, dueDate, librarianId) Then
                        MessageBox.Show("Book(s) borrowed successfully.")
                    End If
                Else
                    MessageBox.Show("The student has already borrowed this book and has not returned it.")
                End If
            End If
        Next

    End Sub

    Private Sub ReturnBookButton_Click(sender As Object, e As EventArgs) Handles ReturnBookButton.Click
        For Each row As DataGridViewRow In ScannerDataTable.Rows
            ' Skip the new row if it's a new row being added
            If Not row.IsNewRow Then
                Dim isbnValue As String = row.Cells("ISBN").Value.ToString()
                ' Assume values are obtained from form fields or user inputs
                Dim studentId As Integer = Integer.Parse(ReturnStudentIdTextBox.Text)
                Dim returnDate As Date = DateTime.Now

                If ReturnBook(isbnValue, studentId, returnDate) Then
                    MessageBox.Show("Book(s) returned successfully.")
                End If
            End If
        Next
    End Sub

    Private Sub DeleteBookButton_Click(sender As Object, e As EventArgs) Handles DeleteBookButton.Click
        DeleteSelectedRow()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If currentDataTable IsNot Nothing Then
            currentDataTable.Clear()
            ScannerDataTable.DataSource = currentDataTable
        End If
    End Sub

    Private Sub BarcodeGeneratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarcodeGeneratorToolStripMenuItem.Click
        Barcode.ShowDialog()
    End Sub
End Class