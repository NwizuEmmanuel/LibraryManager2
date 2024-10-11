Imports System.Configuration
Imports System.Data.SqlClient

Public Class ViewLibrarian
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub ViewLibrarian_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataToTable()

        LibrarianDataTable.Columns("LibrarianId").ReadOnly = True
        LibrarianDataTable.AllowUserToAddRows = False
        LibrarianDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadDataToTable()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                    "SELECT * FROM [Librarians]",
                    connection
                )
                Try
                    connection.Open()
                    table.Clear()
                    adapter.Fill(table)
                    LibrarianDataTable.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub UpdateDatabase(id As Integer, editedValue As Object, columnName As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                $"UPDATE Librarians SET {columnName}=@editedValue WHERE LibrarianId=@id",
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

    Private Sub LibrarianDataTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles LibrarianDataTable.CellEndEdit
        Dim editedCellValue As Object = LibrarianDataTable.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim primaryKey As Integer = CInt(LibrarianDataTable.Rows(e.RowIndex).Cells("LibrarianId").Value.ToString())
        Dim columnName = LibrarianDataTable.Columns(e.ColumnIndex).Name

        UpdateDatabase(primaryKey, editedValue:=editedCellValue, columnName:=columnName)
    End Sub

    Private Sub LibrarianDataTable_MouseDown(sender As Object, e As MouseEventArgs) Handles LibrarianDataTable.MouseDown
        ' Check if right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ' Get the row index from the mouse position
            Dim hitTestInfo As DataGridView.HitTestInfo = LibrarianDataTable.HitTest(e.X, e.Y)

            ' Ensure the user clicked on a valid row and not the column headers
            If hitTestInfo.Type = DataGridViewHitTestType.Cell Then
                ' Select the row where the right-click happened
                LibrarianDataTable.ClearSelection()
                LibrarianDataTable.Rows(hitTestInfo.RowIndex).Selected = True

                ' Show the context menu at the mouse position
                ContextMenuStrip1.Show(LibrarianDataTable, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub DeleteFromDatabase(id As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(
                    "DELETE FROM [Librarians] WHERE LibrarianId=@id",
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

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If LibrarianDataTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = LibrarianDataTable.SelectedRows(0)
            Dim id = Convert.ToInt32(selectedRow.Cells("LibrarianId").Value)
            LibrarianDataTable.Rows.Remove(selectedRow)
            DeleteFromDatabase(id)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadDataToTable()
    End Sub

    Private Sub SearchAction() Handles SearchLibrarianTextBox.TextChanged
        Dim text = SearchLibrarianTextBox.Text & "%"
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                "SELECT * FROM [Librarians] " &
                "WHERE [FirstName] LIKE @text OR " &
                "[LastName] LIKE @text OR " &
                "[Email] LIKE @text OR " &
                "[PhoneNumber] LIKE @text", conn)
                adapter.SelectCommand.Parameters.AddWithValue("@text", text)
                Try
                    conn.Open()
                    table.Clear()
                    adapter.Fill(table)
                    LibrarianDataTable.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class