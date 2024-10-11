Imports System.Configuration
Imports System.Data.SqlClient

Public Class ViewStudent
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub ViewStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataToTable()
        StudentDataGridView.Columns("StudentId").ReadOnly = True
        StudentDataGridView.AllowUserToAddRows = False
        StudentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Assign event handler for DataGridView MouseDown event
        AddHandler StudentDataGridView.MouseDown, AddressOf StudentDataGridView_MouseDown
    End Sub

    ' Handle MouseDown event to detect right-click and show the context menu
    Private Sub StudentDataGridView_MouseDown(sender As Object, e As MouseEventArgs)
        ' Check if right mouse button was clicked
        If e.Button = MouseButtons.Right Then
            ' Get the row index from the mouse position
            Dim hitTestInfo As DataGridView.HitTestInfo = StudentDataGridView.HitTest(e.X, e.Y)

            ' Ensure the user clicked on a valid row and not the column headers
            If hitTestInfo.Type = DataGridViewHitTestType.Cell Then
                ' Select the row where the right-click happened
                StudentDataGridView.ClearSelection()
                StudentDataGridView.Rows(hitTestInfo.RowIndex).Selected = True

                ' Show the context menu at the mouse position
                ContextMenuStrip1.Show(StudentDataGridView, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub StudentDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellEndEdit
        ' Get the edited value
        Dim editedCellValue As String = StudentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

        ' Get the primary key value (e.g., ID)
        Dim primaryKeyValue As Integer = Convert.ToInt32(StudentDataGridView.Rows(e.RowIndex).Cells("StudentId").Value)


        ' Get the column name
        Dim columnName As String = StudentDataGridView.Columns(e.ColumnIndex).Name

        ' Update the database with the edited value
        UpdateDatabase(primaryKeyValue, columnName, editedCellValue)
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadDataToTable()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ' Get the selected row (assumes only one row is selected at a time)
        If StudentDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = StudentDataGridView.SelectedRows(0)

            ' Get the primary key (assuming the column is "ID")
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("StudentId").Value)

            ' Remove the row from the DataGridView
            StudentDataGridView.Rows.Remove(selectedRow)

            ' Call the method to delete from the database
            DeleteFromDatabase(id)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub LoadDataToTable()
        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter("select * from [Students]", connection)
                table.Clear()
                adapter.Fill(table)
                StudentDataGridView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub UpdateDatabase(id As Integer, columnName As String, editedValue As String)
        ' SQL update query
        Dim query As String = $"UPDATE Students SET {columnName} = @EditedValue WHERE StudentId = @ID"

        ' Create a SqlConnection
        Using connection As New SqlConnection(connectionString)
            ' Create a SqlCommand
            Using command As New SqlCommand(query, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@EditedValue", editedValue)
                command.Parameters.AddWithValue("@ID", id)
                Try
                    ' Open the connection
                    connection.Open()

                    ' Execute the query
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteFromDatabase(id As Integer)
        ' Your database deletion logic here
        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("DELETE FROM [Students] WHERE [StudentId]=@id", conn)
                Try
                    conn.Open()
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                    MessageBox.Show($"Deleted row with ID: {id}")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
        LoadDataToTable()
    End Sub

    Private Sub SearchStudentTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchStudentTextBox.TextChanged
        Dim text = SearchStudentTextBox.Text & "%"
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(
                "SELECT * FROM [Students] " &
                "WHERE [FirstName] LIKE @text OR " &
                "[LastName] LIKE @text OR " &
                "[Address] LIKE @text OR " &
                "[Department] LIKE @text OR " &
                "[PhoneNumber] LIKE @text OR " &
                "[Email] LIKE @text", conn)
                adapter.SelectCommand.Parameters.AddWithValue("@text", text)
                Try
                    conn.Open()
                    table.Clear()
                    adapter.Fill(table)
                    StudentDataGridView.DataSource = table
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class