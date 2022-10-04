Public Class formResult

    Dim NomeMaiorSoma As String
    Dim ValorMaiorSoma As Decimal
    Dim NomeMaiorMedia As String
    Dim ValorMaiorMedia As Decimal
    Dim ValorDaSomaGeral As Decimal
    Dim ValorDaMediaGeral As Decimal
    Dim Contador As Integer = 0


    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click

        Dim ValorSomaAtual As Decimal
        Dim ValorMediaAtual As Decimal
        'TRATANDO ERRO AO GRAVAR SEM DADOS

        Try
            ValorSomaAtual = CDec(txt_nota1.Text) + CDec(txt_nota2.Text) + CDec(txt_nota3.Text)
            ValorMediaAtual = ValorSomaAtual / 3
            ValorDaSomaGeral = ValorDaSomaGeral + ValorSomaAtual
        Catch
            txt_nome = txt_nome
            MessageBox.Show("Não existe valores para GRAVAR!!!", "ATENÇÃO!!!")
        End Try

        If ValorSomaAtual > ValorMaiorSoma Then
            NomeMaiorSoma = txt_nome.Text
            ValorMaiorSoma = ValorSomaAtual

        End If

        If ValorMediaAtual > ValorMaiorMedia Then
            NomeMaiorMedia = txt_nome.Text
            ValorMaiorMedia = ValorMediaAtual
        End If

        Contador = Contador + 1
        txt_nome.Text = ""
        txt_nota1.Text = ""
        txt_nota2.Text = ""
        txt_nota3.Text = ""
        txt_nome.Focus()

    End Sub


    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click

        If MsgBox("Tem certeza que deseja voltar?", vbYesNo, "Confirmação") = vbYes Then
            If vbYes Then
                Me.Close()
            End If
            If vbNo Then
            Else
            End If

        End If


    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click

        If ValorDaMediaGeral >= ValorDaSomaGeral Then
            MessageBox.Show("Sem dados para imprimir", "ATENÇÃO!!!")
            Exit Sub
        End If

        ValorDaMediaGeral = ValorDaSomaGeral / (Contador * 3)

        MessageBox.Show("Maior nota: " & NomeMaiorSoma & vbCrLf & "Valor do maior nota: " & ValorMaiorSoma.ToString _
            & vbCrLf & "Nome Média: " & NomeMaiorMedia & vbCrLf & "Valor da maior média: " & ValorMaiorMedia.ToString _
            & vbCrLf & "--------------------------" & vbCrLf _
            & "Quantidade de alunos: " & Contador & vbCrLf _
            & "Valor da nota media geral: " & ValorDaMediaGeral, "Resultado:")


    End Sub


End Class