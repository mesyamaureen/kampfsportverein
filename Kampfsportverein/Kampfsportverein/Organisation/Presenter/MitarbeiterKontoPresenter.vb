Public Class MitarbeiterKontoPresenter
    Private mMitBenutzer As Benutzer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As MitarbeiterKontoView
    Sub New(pBenutzer As Benutzer)
        mMitBenutzer = pBenutzer
        mView = New MitarbeiterKontoView(Me)

        anzeigen()
        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New MitarbeiterKontoView(Me)
        mMitBenutzer = New Benutzer
        mView.ShowDialog(Me)
    End Sub
    Public Property View As MitarbeiterKontoView
        Get
            Return mView
        End Get
        Set(value As MitarbeiterKontoView)
        End Set
    End Property

    Public Property MitBenutzer As Benutzer
        Get
            Return mMitBenutzer
        End Get
        Set(value As Benutzer)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigenKonto()
        mView.txtMitarbeiterID.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID
        mView.txtVorname.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Vorname
        mView.txtName.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Name
        mView.txtBenutzername.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Benutzername

    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
