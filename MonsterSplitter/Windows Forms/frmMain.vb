Imports System.IO
Imports System.Security.Principal.WindowsIdentity
Imports System
Imports System.Data.SqlClient
Imports MonsterSplitter.Data.SQLServer

Public Class frmMain
    ''https://www.dotnetheaven.com/article/read-the-data-with-the-datareader-object-in-vb.net
    Dim strHeader As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '' Load the static items
        Text = ProductName
        AppToolStripMenuItem.Text = Text
        AboutAppNameToolStripMenuItem.Text = AboutAppNameToolStripMenuItem.Text.Replace("{AppName}", Text)
        QuitAppNameToolStripMenuItem.Text = QuitAppNameToolStripMenuItem.Text.Replace("{AppName}", Text)


    End Sub

    Private Sub RecommendNewFeaturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecommendNewFeaturesToolStripMenuItem.Click
        Process.Start("https://github.com/Laim/MonsterSplitter/issues/new")
    End Sub

    Private Sub ReportAnIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportAnIssueToolStripMenuItem.Click
        Process.Start("https://github.com/Laim/MonsterSplitter/issues/new")
    End Sub
    Private Sub AboutAppNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAppNameToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        frmPreferences.ShowDialog()
    End Sub

    Sub SplitCSV(ByVal FilePath As String, ByVal LineCount As Integer)

        ' Open the csv file for reading
        Dim Reader As New IO.StreamReader(FilePath)

        ' Create the output directory
        Dim OutputFolder As String = FilePath & "_Pieces"
        If Directory.Exists(FilePath) = False Then
            Directory.CreateDirectory(OutputFolder)
        End If

        If cbCSVHeader.Checked = True Then
            ' Read the csv column's header
            strHeader = Reader.ReadLine
        End If

        ' Start splitting
        Dim FileIndex As Integer

        Do

            ' Update progress
            FileIndex += 1

            ' Check if the number of splitted files doesn't exceed the limit

            ' Create new file to store a piece of the csv file
            Dim PiecePath As String = OutputFolder & "\" & Path.GetFileNameWithoutExtension(FilePath) & "_" & FileIndex & Path.GetExtension(FilePath)
            Dim Writer As New StreamWriter(PiecePath, False)
            Writer.AutoFlush = False
            If cbCSVHeader.Checked = True Then
                Writer.WriteLine(strHeader)
            End If

            ' Read and writes precise number of rows
            For i As Integer = 1 To LineCount

                Dim s As String = Reader.ReadLine()
                If s <> Nothing Then
                    Writer.WriteLine(s)
                Else
                    Writer.Flush()
                    Writer.Close()
                    Exit Do
                End If

            Next

            ' Flush and close the splitted file
            Writer.Flush()
            Writer.Close()

        Loop

        Reader.Close()

    End Sub

    Sub SplitIt()
        Try
            SplitCSV(tbCSVPath.Text, nudLinesPerCSV.Value)
            MsgBox("Completed Successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Unable to split the CSV File. Reason: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            btnSplitCSV.Enabled = True
        End Try
    End Sub


    Private Sub BtnSplitCSV_Click(sender As Object, e As EventArgs) Handles btnSplitCSV.Click
        ''log what's happening
        lbConsole.Items.Add(lineCount(tbCSVPath.Text) + " lines to split")

        Dim th As New Threading.Thread(AddressOf SplitIt)
        th.Start()
    End Sub

    Public Function lineCount(ByVal FPName As String) As String

        Dim sr As New StreamReader(FPName)

        Dim myLineCount As Integer = 0

        While sr.ReadLine <> Nothing

            myLineCount += 1

        End While

        sr.Close()

        sr.Dispose()

        Return myLineCount.ToString

    End Function
End Class
