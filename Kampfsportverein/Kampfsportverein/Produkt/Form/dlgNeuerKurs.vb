Public Class dlgNeuerKurs
    Public mPresenter As NeuerKursPresenter

    Private Sub dlgNeuerKurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mPresenter.ladenSaName()
        mPresenter.ladenTrainer()
    End Sub

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        mPresenter.verarbeiteErstellen()
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub
End Class