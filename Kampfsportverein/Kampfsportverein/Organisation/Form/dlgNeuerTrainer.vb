Public Class dlgNeuerTrainer
    Public mPresenter As NeuerTrainerPresenter

    Public Property Presenter As NeuerTrainerPresenter
        Get
            Return mPresenter
        End Get
        Set(value As NeuerTrainerPresenter)
        End Set
    End Property

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        mPresenter.verarbeiteErstellen()
    End Sub

End Class