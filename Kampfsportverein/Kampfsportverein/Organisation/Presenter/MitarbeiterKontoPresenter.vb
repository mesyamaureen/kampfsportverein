Public Class MitarbeiterKontoPresenter
    Private mMitEinzel As Mitarbeiter
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As MitarbeiterKontoView
    Sub New(pMitarbeiter As Mitarbeiter)
        mMitEinzel = pMitarbeiter
        mView = New MitarbeiterKontoView(Me)
        mMitEinzel = New Mitarbeiter

        anzeigen()
        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New MitarbeiterKontoView(Me)
        mMitEinzel = New Mitarbeiter
        mView.ShowDialog(Me)
    End Sub
    Public Property View As MitarbeiterKontoView
        Get
            Return mView
        End Get
        Set(value As MitarbeiterKontoView)
        End Set
    End Property

    Public Property MitEinzel As Mitarbeiter
        Get
            Return mMitEinzel
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigenKonto()
    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
