Public Class dlgMeinKontoMit
    Public mPresenter As MitarbeiterKontoPresenter
    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        mPresenter.verarbeiteSpeichern(mPresenter.EinzelMitarbeiter)
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub
End Class