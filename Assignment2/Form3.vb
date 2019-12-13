Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)


        If RadioButton1.Checked = True Then
            Do While (a <= b)
                ListBox1.Items.Add(a)
                a = a + 1
            Loop
        End If

        If RadioButton2.Checked = True Then
            Do While (a <= c)
                ListBox1.Items.Add(a)
                a = a + 1
            Loop

        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ListBox1.Items.Clear()
        TextBox1.Focus()

    End Sub
End Class