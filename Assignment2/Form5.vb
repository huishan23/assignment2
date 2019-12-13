Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim parentphone(4) As Integer


        parentphone(0) = Val(InputBox("Please enter the first parent's phone number"))
        parentphone(1) = Val(InputBox("Please enter the second parent's phone number"))
        parentphone(2) = Val(InputBox("Please enter the third parent's phone number"))
        parentphone(3) = Val(InputBox("Please enter the fourth parent's phone number"))
        parentphone(4) = Val(InputBox("Please enter the fifth parent's phone number"))
        Dim q As Integer


        For q = 0 To 4
            ListBox1.Items.Add(parentphone(q))
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()

    End Sub
End Class