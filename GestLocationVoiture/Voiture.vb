Public Class Voiture

    Private Sub Voiture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Bdd_voitureDataSet.marque'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.MarqueTableAdapter.Fill(Me.Bdd_voitureDataSet.marque)
        'TODO: cette ligne de code charge les données dans la table 'Bdd_voitureDataSet.location'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.LocationTableAdapter.Fill(Me.Bdd_voitureDataSet.location)
        'TODO: cette ligne de code charge les données dans la table 'Bdd_voitureDataSet.voiture'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.VoitureTableAdapter.Fill(Me.Bdd_voitureDataSet.voiture)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub
End Class