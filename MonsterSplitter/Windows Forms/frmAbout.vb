Imports MonsterSplitter.My

Public Class frmAbout
    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Load the static items
        Text = ProductName
        lblAppName.Text = Text
        lblAppVersion.Text = lblAppVersion.Text.Replace("{Ver}", ProductVersion)

        ''rtbAboutInfo.LoadFile("C:\Users\Laim.McKenzie\Downloads\Document.rtf")
        rtbAboutInfo.Rtf = Resources.AboutDoc
        lblCopyright.Text = lblCopyright.Text.Replace("{Copyright}", Application.Info.Copyright)
    End Sub
End Class

