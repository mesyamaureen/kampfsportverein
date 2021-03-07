Imports Kampfsportvereinverwaltung
Public Class MitarbeiterKontoPresenter
    Private mMitBenutzer As Benutzer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As MitarbeiterKontoView
    Private mMitarbeiter As Mitarbeiter
    Sub New(pBenutzer As Benutzer)
        mMitBenutzer = pBenutzer

        mView = New MitarbeiterKontoView(Me)
        mMitarbeiter = New Mitarbeiter
        mMitarbeiter.ID = pBenutzer.BenutzerID
        mMitarbeiter.Nachname = pBenutzer.Name
        mMitarbeiter.Vorname = pBenutzer.Vorname
        mMitarbeiter.Benutzername = pBenutzer.Benutzername
        mMitarbeiter.Passwort = pBenutzer.Passwort
        mMitarbeiter.Typ = "M"
        mMitarbeiter.Version = 0

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

    Public Sub verarbeiteSpeichern(pMit As Mitarbeiter, pNeuesPw As String)



        If pNeuesPw IsNot String.Empty Then
            If Not pMit.Passwort = mMitarbeiter.Passwort Then
                MsgBox("Altes Passwort ist Falsch")
                Exit Sub
            Else
                mMitarbeiter.Passwort = pNeuesPw
                mMitarbeiter.Nachname = pMit.Nachname

                MitarbeiterDAO.speichernMitarbeiter(mMitarbeiter)
            End If
        Else
            mMitarbeiter.Nachname = pMit.Nachname
            'MsgBox(mMitarbeiter.ID & "     " & mMitarbeiter.Nachname)
            MitarbeiterDAO.speichernMitarbeiter(mMitarbeiter)
        End If




    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
