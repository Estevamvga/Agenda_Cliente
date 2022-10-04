Public Class Login

    Public A As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100
        ProgressBar2.Visible = False
        txtContador.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Value = ProgressBar2.Value + 20
        txtContador.Text = ProgressBar2.Value & "%"
        If ProgressBar2.Value >= 100 Then
            Timer1.Enabled = False
            If txt_login.Text = "1" And txt_password.Text = "1" Then
                ProgressBar2.Value = 0
                MenuPrincipal.Show()
                Me.Close()
            Else
                MessageBox.Show("Usuário e senha inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProgressBar2.Value = 0
                ProgressBar2.Visible = False
                txtContador.Text = ""
                txt_login.Text = ""
                txt_password.Text = ""
                txt_login.Focus()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btn_acessar.Click
        Timer1.Enabled = True
        ProgressBar2.Visible = True
        txtContador.Visible = True
    End Sub

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ImageCheckBox1.CheckedChanged
        If Guna2ImageCheckBox1.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

End Class
