Public Class Dialog
    Private Sub btn_cor_Click(sender As Object, e As EventArgs) Handles btn_cor_Form.Click

        ColorDialog1.ShowDialog()
        txtEmpresaC.ForeColor = ColorDialog1.Color


    End Sub

    Private Sub btn_CorLabel_Click(sender As Object, e As EventArgs) Handles btn_CorLabel.Click

        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color

    End Sub
End Class