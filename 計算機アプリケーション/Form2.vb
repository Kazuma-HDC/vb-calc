Public Class FrmTri
    Dim menseki As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teihen As Single = TextBox1.Text
        Dim takasa As Single = TextBox2.Text
        menseki = teihen * takasa / 2

        Label4.Text = menseki
    End Sub
End Class