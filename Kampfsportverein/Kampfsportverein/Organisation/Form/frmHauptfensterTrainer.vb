Public Class frmHauptfensterTrainer
    Protected mPresenter As AnmeldungPresenter 'Beziehung mit Presenter

    Public Property Presenter As TrainerAllePresenter
        Get
            Return Nothing
        End Get
        Set(value As TrainerAllePresenter)
        End Set
    End Property
    'Nach d
    Private Sub frmHauptfensterTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMeinKonto_Click(sender As Object, e As EventArgs) Handles btnMeinKonto.Click

    End Sub

    Private Sub btnAlleSchueler_Click(sender As Object, e As EventArgs) Handles btnAlleSchueler.Click

    End Sub

    Private Sub btnNeueSchueler_Click(sender As Object, e As EventArgs) Handles btnNeueSchueler.Click

    End Sub

    Private Sub btnBearbeiten_Click(sender As Object, e As EventArgs) Handles btnBearbeiten.Click

    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click

    End Sub
End Class