Public Class frmPreferences
    Private Sub FrmPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSplitPath.Text = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\" + Application.ProductName + "\"
    End Sub
End Class