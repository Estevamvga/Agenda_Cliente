Public Class VendasPrd

    Dim Codprod(10) As String
    Dim NomeProd(10) As String
    Dim precoProd(10) As Decimal
    Dim labProd(10) As String
    Dim descontoProd(10) As Decimal
    Dim brutototal As Decimal
    Dim brutodesconto As Decimal
    Dim tpreco As Decimal
    Dim tdesc As Decimal

    Private Sub VendasPrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpaLista()
        Carrega_Dados()
        desabilitaCampo()
    End Sub

    Private Sub txtCodProduto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProduto.TextChanged
        Dim vnome As String
        Dim vpreco As Decimal
        Dim vachou As Boolean
        Dim vlabPrd As String
        Dim vdesc As Decimal
        Dim TotalSomatoria As Decimal

        If txtCodProduto.Text.Length = 5 Then
            vachou = False
            For t = 1 To 10
                If txtCodProduto.Text = Codprod(t) Then
                    vnome = NomeProd(t)
                    vpreco = precoProd(t)
                    vlabPrd = labProd(t)
                    vdesc = descontoProd(t)
                    vachou = True
                End If
            Next
            If Not vachou Then
                MessageBox.Show("Produto invalido!", "Atenção")
            Else
                ListBox1.Items.Add(txtCodProduto.Text & " | " & vnome & vbCrLf & " | " & vlabPrd & " | " & Format(vpreco, "c") & " | Descontos " & Format(vdesc, "c"))
                txtCodProduto.Text = ""

                'Somatória valor total dos produtos
                brutototal = brutototal + vpreco
                txtValorTotal.Text = Format(brutototal, "c")

                'somatoria valor total dos descontos
                brutodesconto = brutodesconto + vdesc
                txtValorDesconto.Text = Format(brutodesconto, "c")

                'Aplicando desconto sobre o valor bruto dos produtos
                tpreco = brutototal
                tdesc = brutodesconto
                TotalSomatoria = brutototal - brutodesconto
                txtTotalLiquido.Text = Format(TotalSomatoria, "c")

            End If
        End If
    End Sub

    Private Sub Carrega_Dados()

        'Dados do 1º produto
        Codprod(1) = "10001"
        NomeProd(1) = "ANADOR 500MG GTS 10ML"
        labProd(1) = "SANOFI"
        precoProd(1) = 12.48
        descontoProd(1) = 1.2

        'Dados do 2º produto
        Codprod(2) = "10002"
        NomeProd(2) = "DIPIMED 500MG 10CPR"
        labProd(2) = "MEDQUIMICA"
        precoProd(2) = 268.42
        descontoProd(2) = 1.0

        'Dados do 3º produto
        Codprod(3) = "10003"
        NomeProd(3) = "DORFEBRIL GTS 20ML"
        labProd(3) = "MEDQUIMICA"
        precoProd(3) = 35.99
        descontoProd(3) = 1.5

        'Dados do 4º produto
        Codprod(4) = "10004"
        NomeProd(4) = "AMOXICILINA 125MG"
        labProd(4) = "MEDLEY"
        precoProd(4) = 22.9
        descontoProd(4) = 1.3

        'Dados do 5º produto
        Codprod(5) = "10005"
        NomeProd(5) = "WHEY 100% 900G"
        labProd(5) = "MAX TITANIUM"
        precoProd(5) = 131.13
        descontoProd(5) = 10.0

        'Dados do 6º produto
        Codprod(6) = "10006"
        NomeProd(6) = "BENEGRIP 12CPR"
        labProd(6) = "HYPERA  OTC"
        precoProd(6) = 25.99
        descontoProd(6) = 2.5

        'Dados do 7º produto
        Codprod(7) = "10007"
        NomeProd(7) = "BCAA 120 TABLETES"
        labProd(7) = "MMAX TITANIUM"
        precoProd(7) = 12.3
        descontoProd(7) = 5.5

        'Dados do 8º produto
        Codprod(8) = "10008"
        NomeProd(8) = "DORALFLEX 10CPR"
        labProd(8) = "PHARMASCIENCE LAB LTDA"
        precoProd(8) = 110.28
        descontoProd(8) = 8.9

        'Dados do 9º produto
        Codprod(9) = "10009"
        NomeProd(9) = "ALCOOL 70 LIQUIDO 1L"
        labProd(9) = "PERFUMARIA"
        precoProd(9) = 12.5
        descontoProd(9) = 5.0

        'Dados do 10º produto
        Codprod(10) = "10010"
        NomeProd(10) = "CIMEGRIPE 400MG 10CAPS"
        labProd(10) = "CIMED SIMILAR"
        precoProd(10) = 105.35
        descontoProd(10) = 15.0

    End Sub

    Private Sub LimpaLista()

        'Limpar lista 
        ListBox1.Items.Clear()

    End Sub

    Private Sub DesabilitaCampo()
        txtValorTotal.Enabled = False
        txtValorDesconto.Enabled = False
        txtTotalLiquido.Enabled = False
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click

        If MsgBox("Deseja Excluir todos os produtos?", MsgBoxStyle.YesNo, "Confirmação") = vbYes Then
            If vbYes Then
                ListBox1.Items.Clear()
                txtValorTotal.Text = ""
                txtValorDesconto.Text = ""
                txtTotalLiquido.Text = ""
                txtCodProduto.Focus()
            End If
        End If
    End Sub
End Class