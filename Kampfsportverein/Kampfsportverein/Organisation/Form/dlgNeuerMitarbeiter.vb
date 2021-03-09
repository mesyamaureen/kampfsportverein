Public Class dlgNeuerMitarbeiter
    Public mPresenter As NeuerMitarbeiterPresenter

    Public Property Presenter As NeuerMitarbeiterPresenter
        Get
            Return mPresenter
        End Get
        Set(value As NeuerMitarbeiterPresenter)
        End Set
    End Property

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        mPresenter.verarbeiteErstellen()
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub

End Class