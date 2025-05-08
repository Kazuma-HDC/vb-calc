Public Class Form1
    Dim a As New FrmTri
    Dim b As New FrmTra
    Dim c As New FrmBMI
    Private Sub FormMain_Click(sender As Object, e As EventArgs) Handles FormMain.Click
        a.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c.Show()
    End Sub
End Class
