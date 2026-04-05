Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 4
            For j As Integer = 1 To i - 1
                TextBox1.Text = TextBox1.Text & ("0")
            Next
            For k As Integer = 1 To 1
                TextBox1.Text = TextBox1.Text & ("1")
            Next
            For l As Integer = 1 To 4 - i
                TextBox1.Text = TextBox1.Text & ("0")
            Next
            TextBox1.Text &= vbCrLf
        Next
    End Sub
End Class
