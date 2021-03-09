Public Class dlgKursEinzeln
    Public mPresenter As KursPresenter

    Public Property Presenter As KursPresenter
        Get
            Return mPresenter
        End Get
        Set(value As KursPresenter)
        End Set
    End Property
    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        mPresenter.verarbeiteSpeichern(mPresenter.EinzelKurs)
    End Sub

End Class