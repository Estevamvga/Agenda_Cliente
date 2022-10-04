Imports System.IO

Public Class AgendaCli
    Dim anome(0) As String
    Dim aTelRes(0) As String
    Dim aTelCel(0) As String
    Dim aDataNas(0) As String
    Dim aDataCad(0) As String
    Dim aReferencias(0) As String
    Dim aSexo(0) As String
    Dim aEmail(0) As String
    Dim vmodo As String = "X"

    Private Sub AgendaCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.FileExists("c:\temp\contatos.txt") Then
            MessageBox.Show("Arquivo Vazio!", "Arquivo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ReDim anome(0)
        Else
            le_arquivo()
            ordenacao()
        End If
    End Sub

    Private Sub le_arquivo()
        Dim Leitor As StreamReader
        Leitor = My.Computer.FileSystem.OpenTextFileReader("c:\Temp\Contatos.txt")
        Dim cont As Integer = 0
        While Not Leitor.EndOfStream ' LOOP
            Dim vstrlinha As String = Leitor.ReadLine()
            Dim vnome As String = vstrlinha.Substring(0, 30)
            Dim vTelRes As String = vstrlinha.Substring(30, 12)
            Dim vTelCel As String = vstrlinha.Substring(42, 12)
            Dim vDataNas As String = vstrlinha.Substring(54, 10)
            Dim vDataCad As String = vstrlinha.Substring(64, 10)
            Dim vReferencias As String = vstrlinha.Substring(74, 10)
            Dim vSexo As String = vstrlinha.Substring(84, 1)
            Dim vEmail As String = vstrlinha.Substring(85, 3)
            '------------------------Carregar Vetores---------------------------------
            cont = cont + 1
            'ReDim repetidamente para alterar o número de elementos e dimensões em uma matriz.
            ReDim Preserve anome(cont)
            ReDim Preserve aTelRes(cont)
            ReDim Preserve aTelCel(cont)
            ReDim Preserve aDataNas(cont)
            ReDim Preserve aDataCad(cont)
            ReDim Preserve aReferencias(cont)
            ReDim Preserve aSexo(cont)
            ReDim Preserve aEmail(cont)
            'ARRAY para acumular os valores guardados  no GRID
            anome(cont) = vnome
            aTelRes(cont) = vTelRes
            aTelCel(cont) = vTelCel
            aDataNas(cont) = vDataNas
            aDataCad(cont) = vDataCad
            aReferencias(cont) = vReferencias
            aSexo(cont) = vSexo
            aEmail(cont) = vEmail
            '------------------------Carregar DATAGRIDVIEW---------------------------------
            dvg_GridViewContatos.Rows.Add(vnome, vSexo, vReferencias, vTelRes)
        End While
    End Sub

    'Criticando campo por erro de digitação ou caracteres inválidos

    Private Function criticampos()
        ' Usa-se Return para retornar alguma coisa OBS** Criar uma sub como Function
        ' Return sendo FALSE && TRUE é uma Function
        If cmb_Sexo.Text <> "M" And cmb_Sexo.Text <> "F" Then
            MessageBox.Show("Campo Sexo inválido", "Descrição inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmb_Sexo.Focus()
            Return False
        End If
        If Not (txt_Email.Text.Contains("@") And txt_Email.Text.Contains(".")) Then
            MessageBox.Show("Campo E-mail inválido", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Email.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub carregaGrid()
        dvg_GridViewContatos.Rows.Clear() 'LimpaGrid
        For t = 1 To anome.Length - 1
            If anome(t).ToUpper.Contains(txtConsulta.Text.ToUpper) Then 'ConsultarDadosGrid
                dvg_GridViewContatos.Rows.Add(anome(t), aSexo(t), aReferencias(t), aTelRes(t))
            End If
        Next
        lbl_QtdRegistros.Text = "Quantidade de registros: " & anome.Length - 1
    End Sub

    ' Variavel VMODO Vai registrar a opeção, incluir, excluir e cancelar. 
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Dim retorno_critica As Boolean = criticampos()
        If retorno_critica Then
            If vmodo = "A" Then 'Confirmar 
                Dim ind As Integer = dvg_GridViewContatos.CurrentRow.Index + 1
                anome(ind) = txt_NomeC.Text
                aTelRes(ind) = txt_TelResidencial.Text
                aTelCel(ind) = txt_TelCelular.Text
                aDataNas(ind) = dtp_Nascimento.Text
                aDataCad(ind) = dtp_Cadastro.Text
                aReferencias(ind) = cmb_Referencias.Text
                aSexo(ind) = cmb_Sexo.Text
                aEmail(ind) = txt_Email.Text

                'Atualizando a posição Ind no Grid
                dvg_GridViewContatos.Item(0, ind - 1).Value = txt_NomeC.Text
                dvg_GridViewContatos.Item(1, ind - 1).Value = cmb_Sexo.Text
                dvg_GridViewContatos.Item(2, ind - 1).Value = txt_TelResidencial.Text
                dvg_GridViewContatos.Item(3, ind - 1).Value = txt_TelResidencial.Text
                ordenacao()
            End If

            If vmodo = "I" Then 'Inclusão
                Dim ind As Integer = anome.Length
                'ReDim repetidamente para alterar o número de elementos e dimensões em uma matriz.
                ReDim Preserve anome(ind)
                ReDim Preserve aTelRes(ind)
                ReDim Preserve aTelCel(ind)
                ReDim Preserve aDataNas(ind)
                ReDim Preserve aDataCad(ind)
                ReDim Preserve aReferencias(ind)
                ReDim Preserve aSexo(ind)
                ReDim Preserve aEmail(ind)

                'ARRAY para acumular os valores guardados  no GRID
                'Aumentar o tamanho do VETOR
                anome(ind) = txt_NomeC.Text
                aTelRes(ind) = txt_TelResidencial.Text
                aTelCel(ind) = txt_TelCelular.Text
                aDataNas(ind) = dtp_Nascimento.Text
                aDataCad(ind) = dtp_Cadastro.Text
                aReferencias(ind) = cmb_Referencias.Text
                aSexo(ind) = cmb_Sexo.Text
                aEmail(ind) = txt_Email.Text

                'dvg_GridViewContatos.Rows.Add(txt_NomeC.Text, cmb_Sexo.Text, cmb_Referencias.Text, txt_TelResidencial.Text)
                'carregaGrid()
                ordenacao()
            End If
            If vmodo = "E" Then  'Exclusão
                Dim ind As Integer = dvg_GridViewContatos.CurrentRow.Index + 1
                For t = 1 To anome.Length - 1
                    If t > 1 Then
                        anome(t - 1) = anome(t)
                        aTelRes(t - 1) = aTelRes(t)
                        aTelCel(t - 1) = aTelCel(t)
                        aDataNas(t - 1) = aDataNas(t)
                        aDataCad(t - 1) = aDataCad(t)
                        aReferencias(t - 1) = aReferencias(t)
                        aSexo(t - 1) = aSexo(t)
                        aEmail(t - 1) = aEmail(t)
                    End If
                Next
                'ind = anome.Length - 2
                Dim ind2 As Integer = anome.Length - 2
                ReDim Preserve anome(ind2)
                ReDim Preserve aTelRes(ind2)
                ReDim Preserve aTelCel(ind2)
                ReDim Preserve aDataNas(ind2)
                ReDim Preserve aDataCad(ind2)
                ReDim Preserve aReferencias(ind2)
                ReDim Preserve aSexo(ind2)
                ReDim Preserve aEmail(ind2)
                carregaGrid()
            End If
        End If
        vmodo = "X"
        DesabilitaCampo()
        gravaarquivo()
    End Sub

    Private Sub btn_alterar_Click(sender As Object, e As EventArgs) Handles btn_alterar.Click
        vmodo = "A"
        habilitaCampos()
    End Sub

    Private Sub habilitaCampos()
        txt_NomeC.Enabled = True
        txt_TelResidencial.Enabled = True
        txt_TelCelular.Enabled = True
        dtp_Nascimento.Enabled = True
        dtp_Cadastro.Enabled = True
        cmb_Referencias.Enabled = True
        cmb_Sexo.Enabled = True
        txt_Email.Enabled = True

        '---- Habilita campo Buttom
        btn_incluir.Enabled = False
        btn_alterar.Enabled = False
        btn_delete.Enabled = False
        btn_salvar.Enabled = True
        btn_cancel.Enabled = True
    End Sub

    Private Sub DesabilitaCampo()
        txt_NomeC.Enabled = False
        txt_TelResidencial.Enabled = False
        txt_TelCelular.Enabled = False
        dtp_Nascimento.Enabled = False
        dtp_Cadastro.Enabled = False
        cmb_Referencias.Enabled = False
        cmb_Sexo.Enabled = False
        txt_Email.Enabled = False

        '---- Desabilitar campo Buttom
        btn_incluir.Enabled = True
        btn_alterar.Enabled = True
        btn_delete.Enabled = True
        btn_salvar.Enabled = False
        btn_cancel.Enabled = False

    End Sub

    'Selecionar linha do GRID // CarregaCampos <<<< Carregar 
    Private Sub dvg_GridViewContatos_SelectionChanged(sender As Object, e As EventArgs) Handles dvg_GridViewContatos.SelectionChanged
        carregaCampos()
        DesabilitaCampo()
    End Sub
    Private Sub carregaCampos()
        Dim ind As Integer = dvg_GridViewContatos.CurrentRow.Index
        txt_NomeC.Text = anome(ind + 1).Trim
        txt_TelResidencial.Text = aTelRes(ind + 1)
        txt_TelCelular.Text = aTelCel(ind + 1)
        dtp_Nascimento.Text = aDataNas(ind + 1)
        dtp_Cadastro.Text = aDataCad(ind + 1)
        cmb_Referencias.Text = aReferencias(ind + 1)
        cmb_Sexo.Text = aSexo(ind + 1)
        txt_Email.Text = aEmail(ind + 1).Trim
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        DesabilitaCampo()
        carregaCampos()
    End Sub

    Private Sub btn_incluir_Click(sender As Object, e As EventArgs) Handles btn_incluir.Click

        vmodo = "I"
        habilitaCampos()
        txt_NomeC.Text = ""
        txt_TelResidencial.Text = ""
        txt_TelCelular.Text = ""
        dtp_Nascimento.Value = Now
        dtp_Cadastro.Value = Now
        cmb_Referencias.Text = ""
        cmb_Sexo.Text = ""
        txt_Email.Text = ""

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        vmodo = "E"
        MessageBox.Show("Para excluir clique em Confirmar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        habilitaCampos()
    End Sub

    Private Sub ordenacao()
        Dim vMudou As Boolean
        Dim vnome As String
        Dim vTelRes As String
        Dim vTelCel As String
        Dim vDataNas As String
        Dim vDataCad As String
        Dim vReferencias As String
        Dim vSexo As String
        Dim vEmail As String

        vMudou = True
        While vMudou
            vMudou = False
            For t = 1 To anome.Length - 2
                If anome(t + 1) < anome(t) Then
                    vnome = anome(t)
                    anome(t) = anome(t + 1)
                    anome(t + 1) = vnome

                    vTelRes = aTelRes(t)
                    aTelRes(t) = aTelRes(t + 1)
                    aTelRes(t + 1) = vTelRes

                    vTelCel = aTelCel(t)
                    aTelCel(t) = aTelCel(t + 1)
                    aTelCel(t + 1) = vTelCel

                    vDataNas = aDataNas(t)
                    aDataNas(t) = aDataNas(t + 1)
                    aDataNas(t + 1) = vDataNas

                    vDataCad = aDataCad(t)
                    aDataCad(t) = aDataCad(t + 1)
                    aDataCad(t + 1) = vDataCad

                    vReferencias = aReferencias(t)
                    aReferencias(t) = aReferencias(t + 1)
                    aReferencias(t + 1) = vReferencias

                    vSexo = aSexo(t)
                    aSexo(t) = aSexo(t + 1)
                    aSexo(t + 1) = vSexo

                    vEmail = aEmail(t)
                    aEmail(t) = aEmail(t + 1)
                    aEmail(t + 1) = vEmail
                    vMudou = True
                End If
            Next
        End While
        carregaGrid()
    End Sub

    Private Sub gravaarquivo()
        If My.Computer.FileSystem.FileExists("c:\temp\contatos.txt") Then
            My.Computer.FileSystem.DeleteFile("c:\temp\contatos.txt")
        End If
        Dim gravador As StreamWriter
        gravador = My.Computer.FileSystem.OpenTextFileWriter("c:\temp\contatos.txt", True)
        Dim vstrlinha As String = ""
        For t = 1 To anome.Length - 1
            vstrlinha = (anome(t).ToUpper & Space(30)).Substring(0, 30)
            vstrlinha = vstrlinha & (aTelRes(t) & Space(12)).Substring(0, 12)
            vstrlinha = vstrlinha & (aTelCel(t) & Space(12)).Substring(0, 12)
            vstrlinha = vstrlinha & (aDataNas(t) & Space(10)).Substring(0, 10)
            vstrlinha = vstrlinha & (aDataCad(t) & Space(10)).Substring(0, 10)
            vstrlinha = vstrlinha & (aReferencias(t) & Space(10)).Substring(0, 10)
            vstrlinha = vstrlinha & (aSexo(t) & Space(1)).Substring(0, 1)
            vstrlinha = vstrlinha & (aEmail(t).ToLower & Space(40)).Substring(0, 40)
            gravador.WriteLine(vstrlinha)
        Next
        gravador.Close()
    End Sub


    Private Sub txtConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtConsulta.TextChanged
        carregaGrid() 'CarregaGrid Ao consultar Dados
    End Sub
End Class