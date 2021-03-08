Public Class dlgNeuerTrainer
    Public mPresenter As NeuerTrainerPresenter

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        mPresenter.verarbeiteErstellen()
    End Sub

End Class