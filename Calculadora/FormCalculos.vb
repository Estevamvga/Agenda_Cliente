Public Class FormCalculos

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcula.Click
        'MessageBox.Show("Deseja Calcular?", "Soma/Média", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        txt_soma.Text = Val(txt_nota1.Text) + Val(txt_nota2.Text) + Val(txt_nota3.Text) + Val(txt_nota4.Text) + Val(txt_nota5.Text) + Val(txt_nota6.Text)
        txt_media.Text = (Val(txt_nota1.Text) + Val(txt_nota2.Text) + Val(txt_nota3.Text) + Val(txt_nota4.Text) + Val(txt_nota5.Text) + Val(txt_nota6.Text)) / 6
        txt_mult.Text = (((Val(txt_nota1.Text) * Val(txt_nota2.Text) * Val(txt_nota3.Text) * Val(txt_nota4.Text) * Val(txt_nota5.Text) * Val(txt_nota6.Text))))
        txt_nota1.Text = ""
        txt_nota2.Text = ""
        txt_nota3.Text = ""
        txt_nota4.Text = ""
        txt_nota5.Text = ""
        txt_nota6.Text = ""
        txt_nota1.Focus()

    End Sub

    Private Sub Professora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("Deseja carregar esse fomulário?")
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click

        If MsgBox("Tem certeza que deseja voltar?", vbYesNo, "Confirmação") = vbYes Then
            If vbYes Then
                Me.Close()
            End If
            If vbNo Then
            Else
            End If
        End If


    End Sub


End Class