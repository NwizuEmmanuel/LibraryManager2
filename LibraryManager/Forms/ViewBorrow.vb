Imports System.Configuration
Imports System.Data.SqlClient

Public Class ViewBorrow
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub ViewBorrow_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataTable()
        'BorrowDataTable.Columns("BorrowId").ReadOnly = True
        BorrowDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        BorrowDataTable.AllowUserToAddRows = False
        For index As Integer = 0 To 3
            BorrowDataTable.Columns(index).ReadOnly = True
        Next
        BorrowDataTable.Columns(4).ReadOnly = False
        BorrowDataTable.Columns(5).ReadOnly = False
        BorrowDataTable.Columns(6).ReadOnly = False
        For index As Integer = 7 To BorrowDataTable.Columns.Count - 1
            BorrowDataTable.Columns(index).ReadOnly = True
        Next
    End Sub
    Private Sub LoadDataTable()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                    "SELECT Borrows.BorrowId,Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
                    "Borrows.ReturnDate,Librarians.FirstName as LibrarianFirstname,Librarians.LastName as LibrarianLastname " &
                    ",Students.FirstName as StudentFirstame,Students.LastName as StudentLastName " &
                    "FROM Borrows " &
                    "INNER JOIN Books ON Borrows.BookId=Books.BookId " &
                    "INNER JOIN Librarians ON Borrows.LibrarianId=Librarians.LibrarianId " &
                    "INNER JOIN Students ON Borrows.StudentId=Students.StudentId " &
                    "ORDER BY Books.Title",
                    connection
                )
                table.Clear()
                adapter.Fill(table)
                BorrowDataTable.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub SearchAction()
        Dim text = SearchTextBox.Text & "%"
        Dim query = "SELECT Borrows.BorrowId,Books.ISBN,[Books].[Title],Books.Authors,Borrows.BorrowDate,Borrows.DueDate," &
                    "Borrows.ReturnDate,Librarians.FirstName as LibrarianFirstname,Librarians.LastName as LibrarianLastname " &
                    ",Students.FirstName as StudentFirstame,Students.LastName as StudentLastName " &
                    "FROM Borrows " &
                    "INNER JOIN Books ON Borrows.BookId=Books.BookId " &
                    "INNER JOIN Librarians ON Borrows.LibrarianId=Librarians.LibrarianId " &
                    "INNER JOIN Students ON Borrows.StudentId=Students.StudentId " &
                    "WHERE ISBN LIKE @text OR Title LIKE @text"
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@text", text)
                Try
                    conn.Open()
                    table.Clear()
                    adapter.Fill(table)
                    BorrowDataTable.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub RefreshLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        LoadDataTable()
    End Sub



    Private Sub BorrowDataTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowDataTable.CellEndEdit
        Dim editedCellValue As Object = BorrowDataTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim primaryKey As Integer = CInt(BorrowDataTable.Rows(e.RowIndex).Cells("BorrowId").Value.ToString())
        Dim columnName = BorrowDataTable.Columns(e.ColumnIndex).Name

        UpdateDatabase(id:=primaryKey, editedValue:=editedCellValue, columnName:=columnName)
    End Sub

    Private Sub UpdateDatabase(id As Integer, editedValue As Object, columnName As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                $"UPDATE Borrows SET {columnName}=@editedValue WHERE BorrowId=@id",
                connection)
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@editedValue", editedValue)
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If BorrowDataTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = BorrowDataTable.SelectedRows(0)
            Dim id = Convert.ToInt32(selectedRow.Cells("BorrowId").Value)
            BorrowDataTable.Rows.Remove(selectedRow)
            DeleteFromDatabase(id)
        End If
    End Sub

    Private Sub DeleteFromDatabase(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                    "DELETE FROM [Borrows] WHERE BorrowId=@id",
                    connection
                )
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Borrow transaction Deleted.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub BorrowDataTable_MouseDown(sender As Object, e As MouseEventArgs) Handles BorrowDataTable.MouseDown
        ' Check if right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ' Get the row index from the mouse position
            Dim hitTestInfo As DataGridView.HitTestInfo = BorrowDataTable.HitTest(e.X, e.Y)

            ' Ensure the user clicked on a valid row and not the column headers
            If hitTestInfo.Type = DataGridViewHitTestType.Cell Then
                ' Select the row where the right-click happened
                BorrowDataTable.ClearSelection()
                BorrowDataTable.Rows(hitTestInfo.RowIndex).Selected = True

                ' Show the context menu at the mouse position
                ContextMenuStrip1.Show(BorrowDataTable, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        SearchAction()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDataTable()
    End Sub
End Class
