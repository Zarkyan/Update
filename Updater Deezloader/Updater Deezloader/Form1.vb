Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Updater "
        FlatLabel1.Text = "Vérification des mises à jour"
        FlatLabel2.Text = ""
        Timer1.Start()
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
        If System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\bin\Version_Updater.txt") = False Then
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/slooxpjg8oxe63j/Version_Updater.txt?token_hash=AAHJl5BZQL1PUSQ7fhpNKNfm4qR5sSEiKQgwCFEr7oJHKw&dl=1", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\bin\Version_Updater.txt")
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/ju3lvxg7i97ocvs/Azuria.exe?token_hash=AAEeqgl_ti9-P27D0FTScbsFcm_P4XWvfL38WUOn5N2VSg&dl=1", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Azuria.exe")
            Close()
        Else
            'Mise à jour automatique
            My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/slooxpjg8oxe63j/Version_Updater.txt?token_hash=AAHJl5BZQL1PUSQ7fhpNKNfm4qR5sSEiKQgwCFEr7oJHKw&dl=1", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Version_Updater.txt")
            Dim vn As New System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\bin\Version_Updater.txt")
            Dim vni As New System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Version_Updater.txt")
            Dim nk As String
            Dim nki As String
            nk = vn.ReadLine
            nki = vni.ReadLine
            vn.Close()
            vni.Close()
            Kill(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Version_Updater.txt")
            If nk < nki Then
                MsgBox("Mise à jour du launcher..", MsgBoxStyle.Information)
                'Mise à jour
                Kill(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\bin\Version_Updater.txt")
                Kill(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Azuria.exe")
                My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/wthiabqn2kll3zl/Version.txt?token_hash=AAE_x9aN908thAHd5Bh0p0pLen7w8ZnAkDl_LvJZgR15Ww&dl=1", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\bin\Version_Updater.txt")
                My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/s/ju3lvxg7i97ocvs/Azuria.exe?token_hash=AAEeqgl_ti9-P27D0FTScbsFcm_P4XWvfL38WUOn5N2VSg&dl=1", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Azuria.exe")
                Close()
            End If
        End If
        'Lancement de Azuria.exe
        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azuria\Azuria.exe")
        Close()
    End Sub
End Class
