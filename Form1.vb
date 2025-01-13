Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[a-zA-Z]+$") And System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, "^[a-zA-Z0-9]+$") Then
            MsgBox("Bienvenue")
            Dim f2 As New Form2
            f2.Show()
        Else
            MsgBox("Erreur")
        End If
    End Sub
End Class
