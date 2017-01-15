Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Updater "
        FlatLabel1.Text = "Vérification des mises à jour"
        FlatLabel2.Text = ""
        Timer1.Start()
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
End Class
