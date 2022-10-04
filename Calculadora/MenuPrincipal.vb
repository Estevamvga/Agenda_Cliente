Public Class MenuPrincipal
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DialogToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dialog.Show()
    End Sub

    Private Sub EditorToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        Editor.Show()
    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Folder.Show()
    End Sub

    Private Sub CalculaResultadToolStripMenuItem_Click(sender As Object, e As EventArgs) 

        formResult.Show()

    End Sub

    Private Sub CalculaMédiaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        FormCalculos.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) 
        CadastroCli.Show()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click

        ' Deixar vendasprd como uma janela filha da principal

        VendasPrd.Show()

    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Help.Show()
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        AgendaCli.Show()
    End Sub
End Class