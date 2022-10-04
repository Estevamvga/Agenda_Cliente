Public Class Editor
    Private Sub btn_fonte_Click(sender As Object, e As EventArgs) Handles btn_fonte.Click

        MessageBox.Show("Deseja alterar os paramentros da fonte?", "ATENÇÃO!!!")
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font

    End Sub

    Private Sub btn_Cor_Click(sender As Object, e As EventArgs) Handles btn_Cor.Click
        MessageBox.Show("Deseja trocar a cor da fonte?", "ATENÇÃO!!!")
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        SaveFileDialog1.ShowDialog()
        TextBox1.Text = SaveFileDialog1.FileName

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class