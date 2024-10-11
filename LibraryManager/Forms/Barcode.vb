Imports System.Configuration
Imports System.Data.SqlClient

Public Class Barcode
    Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Dim table As New DataTable()

    Private Sub Barcode_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        ' Specify the text to encode in the barcode
        Dim selectedRow = BookTableView.SelectedRows(0)
        Dim isbn = selectedRow.Cells("ISBN").Value
        Dim bookTitle = selectedRow.Cells("Title").Value

        Dim barcode As New BarcodeGenerator()
        ' Generate the barcode
        Dim barcodeBitmap As Bitmap = barcode.GenerateBarcode(isbn)

        ' Save file dialog
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
            saveFileDialog.Title = "Save Barcode Image"
            saveFileDialog.FileName = bookTitle & "barcode.png"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                barcodeBitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Barcode saved as: " & saveFileDialog.FileName)
            End If
        End Using

    End Sub


End Class