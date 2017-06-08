Public Class index

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enterthe name")
        Else
            Me.Hide()
            q1.Show()
        End If
        TextBox1.Clear()
    End Sub
End Class