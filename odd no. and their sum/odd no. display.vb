Public Class frmOdd
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim a As Integer

        For a = 0 To 20
            If a Mod 2 <> 0 Then
                ListBox1.Items.Add(a)

            End If
        Next a
    End Sub
End Class
