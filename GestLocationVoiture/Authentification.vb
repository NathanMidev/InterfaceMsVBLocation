Public Class Authentification

    Private Sub Authentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomUtilisateur As String = TextBox1.Text
        Dim motDePasse As String = TextBox2.Text

        If nomUtilisateur = "admin" And motDePasse = "2024" Then
            MessageBox.Show("Authentification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MenuPrincipal.VOITUREToolStripMenuItem.Enabled = True
            MenuPrincipal.SEDECONNECTERToolStripMenuItem.Enabled = True
            MenuPrincipal.GestionToolStripMenuItem.Enabled = True
            Me.Hide()
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class