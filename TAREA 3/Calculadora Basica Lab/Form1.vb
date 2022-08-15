Public Class Form1
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 + num2
        Label1.Text = res
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 - num2
        Label1.Text = res
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 * num2
        Label1.Text = res
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Dim num1, num2, res As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 / num2
        Label1.Text = res
    End Sub
End Class
