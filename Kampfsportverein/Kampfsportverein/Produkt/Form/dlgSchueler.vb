Public Class dlgSchueler

    Public mPresenter As SchuelerAllePresenter

    Public Property Presenter As SchuelerAllePresenter
        Get
            Return mPresenter
        End Get
        Set(value As SchuelerAllePresenter)
        End Set
    End Property

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        mPresenter.verarbeiteSpeichern(mPresenter.EinzelSchueler)
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub
End Class