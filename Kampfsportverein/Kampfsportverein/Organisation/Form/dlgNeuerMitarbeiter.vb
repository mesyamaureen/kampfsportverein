Public Class dlgNeuerMitarbeiter
    Public mPresenter As NeuerMitarbeiterPresenter

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        mPresenter.verarbeiteErstellen()
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub
End Class