Public Class MenuPrincipal

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VOITUREToolStripMenuItem.Enabled = False
        SEDECONNECTERToolStripMenuItem.Enabled = False
        SECONNECTERToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LouerUneVoitureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LouerUneVoitureToolStripMenuItem.Click
        LouerVoiture.Show()
    End Sub

    Private Sub CLIENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CLIENTToolStripMenuItem1.Click
        Client.Show()
    End Sub

    Private Sub LOCATIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOCATIONToolStripMenuItem1.Click
        Locations.Show()
    End Sub

    Private Sub VOITUREToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VOITUREToolStripMenuItem1.Click
        Voiture.Show()
    End Sub

    Private Sub MARQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MARQUEToolStripMenuItem.Click
        Marque.Show()
    End Sub

    Private Sub SECONNECTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECONNECTERToolStripMenuItem.Click
        Authentification.Show()
    End Sub

    Private Sub QUITTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUITTERToolStripMenuItem.Click
        Dim reponse As DialogResult = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reponse = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click

    End Sub

    Private Sub CLIENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTToolStripMenuItem.Click

    End Sub

    Private Sub SEDECONNECTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEDECONNECTERToolStripMenuItem.Click
        VOITUREToolStripMenuItem.Enabled = False
        SEDECONNECTERToolStripMenuItem.Enabled = False
        SECONNECTERToolStripMenuItem.Enabled = True
        MessageBox.Show("Vous avez été déconnecté.", "Déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class