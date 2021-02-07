Public Class MitarbeiterKontoPresenter
    Private mMitEinzel As Mitarbeiter
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As MitarbeiterKontoView
    Sub New()
        MyBase.New
        mView = New MitarbeiterKontoView(Me)
        mMitEinzel = New Mitarbeiter

        anzeigen()
        mView.ShowDialog()
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

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return Nothing
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigen(mlstMitarbeiter(1).BenutzerID, mlstMitarbeiter(1).Benutzername, mlstMitarbeiter(1).Passwort,
                       mlstMitarbeiter(1).Vorname, mlstMitarbeiter(1).Name)
    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
