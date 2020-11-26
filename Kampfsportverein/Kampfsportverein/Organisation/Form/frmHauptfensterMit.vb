Public Class frmHauptfensterMit

    Public mPresenter As MitarbeiterAllePresenter

    Public Property Presenter As MitarbeiterAllePresenter
        Get
            Return Nothing
        End Get
        Set(value As MitarbeiterAllePresenter)
        End Set
    End Property

    Private Sub btnMeinKonto_Click(sender As Object, e As EventArgs) Handles btnMeinKonto.Click
        mPresenter.verarbeiteMitarbeiterEinzeln()
    End Sub

    Private Sub btnSportarten_Click(sender As Object, e As EventArgs) Handles btnSportarten.Click
        mPresenter.verarbeiteSportartUebersichtAnzeigen()
    End Sub

    Private Sub btnKurs_Click(sender As Object, e As EventArgs) Handles btnKurs.Click
        mPresenter.verarbeiteKursuebersichtAnzeigen()
    End Sub

    Private Sub btnSchueler_Click(sender As Object, e As EventArgs) Handles btnSchueler.Click
        mPresenter.verarbeiteSchueleruebersichtAnzeigen()
    End Sub

    Private Sub btnTrainer_Click(sender As Object, e As EventArgs) Handles btnTrainer.Click
        mPresenter.verarbeiteTrainerUebersichtAnzeigen()
    End Sub

    Private Sub btnNeu_Click(sender As Object, e As EventArgs) Handles btnNeu.Click

    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click

    End Sub

    Private Sub btnOeffnen_Click(sender As Object, e As EventArgs) Handles btnOeffnen.Click

    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        mPresenter.verarbeiteBeenden()
    End Sub
End Class