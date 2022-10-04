Public Class Folder
    Private Sub btn_Folder_Click(sender As Object, e As EventArgs) Handles btn_Folder.Click

        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath

    End Sub
End Class