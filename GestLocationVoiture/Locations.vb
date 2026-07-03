Public Class Locations

    Private Sub Location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Bdd_voitureDataSet.location'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.LocationTableAdapter.Fill(Me.Bdd_voitureDataSet.location)

    End Sub

    Private Sub Date_finDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_finDateTimePicker.ValueChanged

    End Sub

    Private Sub Date_finLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Id_voitureTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class