Public Class dlgKursEinzeln
    Public mPresenter As KursPresenter

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        mPresenter.verarbeiteSpeichern(mPresenter.EinzelKurs)
    End Sub

End Class