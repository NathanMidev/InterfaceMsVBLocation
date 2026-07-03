Public Class Client

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bdd_voitureDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Bdd_voitureDataSet.client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ClientTableAdapter.Fill(Me.Bdd_voitureDataSet.client)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub NomLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
