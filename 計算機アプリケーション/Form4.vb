Public Class FrmBMI
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim shincyo, taijyu, BMI As Single
        shincyo = TextBox1.Text / 100
        taijyu = TextBox2.Text
        BMI = taijyu / shincyo / shincyo
        BMI = Math.Round(taijyu / shincyo / shincyo, 1)
        Label4.Text = BMI
    End Sub
End Class