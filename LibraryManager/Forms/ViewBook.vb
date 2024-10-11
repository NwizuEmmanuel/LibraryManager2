Imports System.Configuration
Imports System.Data.SqlClient

Public Class ViewBook
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub ViewBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBookData()
        BookTableView.AllowUserToAddRows = False
        BookTableView.Columns("BookId").ReadOnly = True
        BookTableView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadBookData()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using adapter As New SqlDataAdapter("SELECT * FROM [Books]", connection)
                table.Clear()
                adapter.Fill(table)
                BookTableView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadBookData()
    End Sub

    Private Sub BookTableView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles BookTableView.CellEndEdit
        Dim editedCellValue As Object = BookTableView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim primaryKey As Integer = CInt(BookTableView.Rows(e.RowIndex).Cells("BookId").Value.ToString())
        Dim columnName = BookTableView.Columns(e.ColumnIndex).Name

        UpdateDatabase(primaryKey, editedValue:=editedCellValue, columnName:=columnName)
    End Sub

    Private Sub UpdateDatabase(id As Integer, editedValue As Object, columnName As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                $"UPDATE Books SET {columnName}=@editedValue WHERE BookId=@id",
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

    Private Sub BookTableView_MouseDown(sender As Object, e As MouseEventArgs) Handles BookTableView.MouseDown
        ' Check if right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ' Get the row index from the mouse position
            Dim hitTestInfo As DataGridView.HitTestInfo = BookTableView.HitTest(e.X, e.Y)

            ' Ensure the user clicked on a valid row and not the column headers
            If hitTestInfo.Type = DataGridViewHitTestType.Cell Then
                ' Select the row where the right-click happened
                BookTableView.ClearSelection()
                BookTableView.Rows(hitTestInfo.RowIndex).Selected = True

                ' Show the context menu at the mouse position
                ContextMenuStrip1.Show(BookTableView, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If BookTableView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = BookTableView.SelectedRows(0)
            Dim id = Convert.ToInt32(selectedRow.Cells("BookId").Value)
            BookTableView.Rows.Remove(selectedRow)
            DeleteFromDatabase(id)
        End If
    End Sub

    Private Sub DeleteFromDatabase(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                    "DELETE FROM [Books] WHERE BookId=@id",
                    connection
                )
                Try
                    connection.Open()
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Book Deleted.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub SearchAction() Handles SearchTextBox.TextChanged
        Dim text = SearchTextBox.Text & "%"
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                "SELECT * FROM [Books] " &
                "WHERE [Title] LIKE @text OR " &
                "[ISBN] LIKE @text OR " &
                "[Authors] LIKE @text OR " &
                "[Publisher] LIKE @text OR " &
                "[Category] LIKE @text", conn)
                adapter.SelectCommand.Parameters.AddWithValue("@text", text)
                Try
                    conn.Open()
                    table.Clear()
                    adapter.Fill(table)
                    BookTableView.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class