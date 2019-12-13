Imports System.IO

Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If File.Exists("c:\Users\User\Documents\Visual Studio 2010\Projects\testFile.txt") Then
            MsgBox("File 'testFile' Exist ")
        Else
            File.Create("c:\Users\User\Documents\Visual Studio 2010\Projects\testFile.txt")
            MsgBox("File 'testFile' created ")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim wFile As System.IO.FileStream
        Dim ic(9) As Long
        Dim h As Integer
        Dim bytedata(9) As Byte


        ic(0) = 990101107654
        ic(1) = 990202043254
        ic(2) = 990303089864
        ic(3) = 990404062947
        ic(4) = 990505082923
        ic(5) = 990606081203
        ic(6) = 990707042319
        ic(7) = 990808082130
        ic(8) = 990909082319
        ic(9) = 991010432139


        For h = 0 To 9
            bytedata = System.Text.Encoding.ASCII.GetBytes("The ic num is " & ic(h) & vbNewLine)
            wFile = New FileStream("c:\Users\User\Documents\Visual Studio 2010\Projects\testFile.txt", FileMode.Append)
            wFile.Write(bytedata, 0, bytedata.Length)
            wFile.Close()
            ListBox1.Items.Add(ic(h))

        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()


    End Sub
End Class