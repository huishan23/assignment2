Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim age(3) As Integer
        Dim i As Integer

        age(0) = Val(TextBox1.Text)
        age(1) = Val(TextBox2.Text)
        age(2) = Val(TextBox3.Text)
        age(3) = Val(TextBox4.Text)

        For i = 0 To 3
            ListBox1.Items.Add(age(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ListBox1.Items.Clear()
        TextBox1.Focus()

    End Sub
End Class