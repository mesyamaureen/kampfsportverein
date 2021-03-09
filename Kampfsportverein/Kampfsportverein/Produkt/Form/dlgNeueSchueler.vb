Public Class dlgNeueSchueler
    Public mPresenter As NeueSchuelerPresenter

    Public Property Presenter As NeueSchuelerPresenter
        Get
            Return mPresenter
        End Get
        Set(value As NeueSchuelerPresenter)
        End Set
    End Property

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        mPresenter.verarbeiteErstellen()
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub

End Class