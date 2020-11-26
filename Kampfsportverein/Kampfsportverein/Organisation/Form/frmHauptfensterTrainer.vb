Public Class frmHauptfensterTrainer
    Protected mPresenter As TrainerAllePresenter 'Beziehung mit Presenter

    Public Property Presenter As TrainerAllePresenter
        Get
            Return mPresenter
        End Get
        Set(value As TrainerAllePresenter)
            mPresenter = value
        End Set
    End Property

    Private Sub btnMeinKonto_Click(sender As Object, e As EventArgs) Handles btnMeinKonto.Click
        mPresenter.verarbeiteEigenesProfilAnzeigen()
    End Sub

    'Private Sub btnBearbeiten_Click(sender As Object, e As EventArgs) Handles btnOeffnen.Click
    '    Dim lngAktuelleID As Long
    '    lngAktuelleID = Me.lstKurse.SelectedItems(0).Text
    '    mPresenter.verarbeiteKursuebersichtAnzeigen(lngAktuelleID)
    'End Sub

    Private Sub btnKurse_Click(sender As Object, e As EventArgs) Handles btnKurse.Click
        mPresenter.verarbeiteKursuebersichtAnzeigen()
    End Sub

    Private Sub btnSchueler_Click(sender As Object, e As EventArgs) Handles btnSchueler.Click
        mPresenter.verarbeiteSchueleruebersichtAnzeigen()
    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        mPresenter.verarbeiteBeenden()
    End Sub
End Class