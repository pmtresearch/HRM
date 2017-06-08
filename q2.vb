Public Class q2
    Public e1 = q1.e1, i1 = q1.i1, s1 = q1.s1, n1 = q1.n1, t1 = q1.t1, f1 = q1.f1, j1 = q1.j1, p1 = q1.p1
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = False And RadioButton2.Checked = False Or RadioButton3.Checked = False And RadioButton4.Checked = False Or RadioButton5.Checked = False And RadioButton6.Checked = False Or RadioButton7.Checked = False And RadioButton8.Checked = False Or RadioButton9.Checked = False And RadioButton10.Checked = False Then
            MsgBox("Please answer all the question")
        Else
            If RadioButton1.Checked = True Then
                s1 = s1 + 1
            Else
                n1 = n1 + 1
            End If
            If RadioButton3.Checked = True Then
                t1 = t1 + 1
            Else
                f1 = f1 + 1
            End If
            If RadioButton5.Checked = True Then
                j1 = j1 + 1
            Else
                p1 = p1 + 1
            End If
            If RadioButton7.Checked = True Then
                e1 = e1 + 1
            Else
                i1 = i1 + 1
            End If
            If RadioButton9.Checked = True Then
                s1 = s1 + 1
            Else
                n1 = n1 + 1
            End If
            Me.Hide()
            q3.Show()
        End If
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
    End Sub
End Class