Public Class Form3
    Private Reservations As New List(Of String())
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter a name.")
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter a first name.")
            Return
        End If
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please enter a phone number.")
            Return
        End If
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a destination.")
            Return
        End If
        If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please select a date.")
            Return
        End If
        Dim reservation As String() = {
            TextBox1.Text,
            TextBox2.Text,
            TextBox3.Text,
            ComboBox1.SelectedItem.ToString(),
            ComboBox2.SelectedItem.ToString()
        }
        Reservations.Add(reservation)
        DataGridView1.Rows.Add(reservation)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        MessageBox.Show("Reservation added successfully!")
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"Paris", "New York", "Tokyo", "London"})
        ComboBox2.Items.AddRange(New String() {"2025-01-10", "2025-01-15", "2025-02-01", "2025-03-05"})
        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "Name"
        DataGridView1.Columns(1).Name = "First Name"
        DataGridView1.Columns(2).Name = "Phone"
        DataGridView1.Columns(3).Name = "Destination"
        DataGridView1.Columns(4).Name = "Date"
    End Sub
End Class
