Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Updater "
        FlatLabel1.Text = "Vérification des mises à jour"
        FlatLabel2.Text = ""
        Timer1.Start()
        Me.Show()
        VerifMaJ()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If FlatLabel1.Text = "Vérification des mises à jour" Then
            FlatLabel1.Text = "Vérification des mises à jour."
        ElseIf FlatLabel1.Text = "Vérification des mises à jour." Then
            FlatLabel1.Text = "Vérification des mises à jour.."
        ElseIf FlatLabel1.Text = "Vérification des mises à jour.." Then
            FlatLabel1.Text = "Vérification des mises à jour..."
        ElseIf FlatLabel1.Text = "Vérification des mises à jour..." Then
            FlatLabel1.Text = "Vérification des mises à jour"

        End If
    End Sub
    Private Sub ProgressBarTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarTimer.Tick
        If FlatProgressBar1.Value = FlatProgressBar1.Maximum Then
            ProgressBarTimer.Enabled = False
        Else
            FlatProgressBar1.Value = FlatProgressBar1.Value + 1
        End If
    End Sub

    Sub VerifMaJ()
        'Premier lancement
        'If System.IO.File.Exists(Environment.GetFolderPath("bin\Version_Updater.txt")) = False Then
        If My.Computer.FileSystem.FileExists("Verif_Version.txt") = False Then
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/content_link/pzGaIP0onzEWvNPko6CKEsjNceo0pBAzKsgKpHdSlIiaC9wmjLGsUr2PY2cfQMf5/file?dl=1", "Verif_Version.txt")
            Close()
        Else
            'Mise à jour automatique
            My.Computer.Network.DownloadFile("http://raw.githubusercontent.com/Zarkyan/Update/master/Version_Updater.txt", "\Version_Updater.txt")
            Dim vn As New System.IO.StreamReader("\Verif_Version.txt")
            Dim vni As New System.IO.StreamReader("\Version_Updater.txt")
            Dim nk As String
            Dim nki As String
            nk = vn.ReadLine
            nki = vni.ReadLine
            vn.Close()
            vni.Close()
            Kill(Environment.GetFolderPath("\Version_Updater.txt"))
            If nk < nki Then
                'Mise à jour
                Kill(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Verif_Version.txt")
                My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/Zarkyan/Update/master/Version_Updater.txt", "\Verif_Version.txt")
                Close()
            End If
        End If
        'Lancement de DeezLoader
        MsgBox("Yeah")
        Process.Start("start.bat")
        'Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\DeezLoader\start.bat")
        Close()
    End Sub
End Class
