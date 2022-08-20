Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = Fact1(TextBox1.Text)
    End Sub
    Function Fact1(n As Integer)
        If (n >= 0) And (n <= 20) Then
            If n = 0 Then Return 1
            If n = 1 Then Return 1
            Return n * Fact1(n - 1)
        End If
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
