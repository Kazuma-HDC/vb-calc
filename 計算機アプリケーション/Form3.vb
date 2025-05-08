Public Class FrmTra
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jyotei As Single
        Dim katei As Single
        Dim takasa As Single
        Dim menseki As Single
        jyotei = TextBox1.Text
        katei = TextBox2.Text
        takasa = TextBox3.Text
        menseki = (jyotei + katei) * takasa / 2
        Label5.Text = menseki
    End Sub
End Class