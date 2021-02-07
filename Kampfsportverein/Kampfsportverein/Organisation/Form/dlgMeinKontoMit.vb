Public Class dlgMeinKontoMit
    Public mPresenter As MitarbeiterKontoPresenter
    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Property Presenter As MitarbeiterKontoPresenter
        Get
            Return Nothing
        End Get
        Set(value As MitarbeiterKontoPresenter)
        End Set
    End Property

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click

    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click

    End Sub
End Class