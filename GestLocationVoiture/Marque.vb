Public Class Marque

    Private Sub Marque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Bdd_voitureDataSet.marque'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.MarqueTableAdapter.Fill(Me.Bdd_voitureDataSet.marque)

    End Sub

    Private Sub Nom_marqueTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nom_marqueTextBox.TextChanged

    End Sub

    Private Sub Nom_marqueLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class