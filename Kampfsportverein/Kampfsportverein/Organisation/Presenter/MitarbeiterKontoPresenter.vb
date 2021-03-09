Imports Kampfsportvereinverwaltung
Public Class MitarbeiterKontoPresenter
    Private Shared mMitarbeiter As Mitarbeiter
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As MitarbeiterKontoView
    Private mmitDAO As MitarbeiterDAO

    Sub New(pMitarbeiter As Mitarbeiter)
        mMitarbeiter = pMitarbeiter
        mView = New MitarbeiterKontoView(Me)
        If BenutzerSitzung.Instanz.AktuellerBenutzer.GetType.Equals(GetType(Mitarbeiter)) Then
            anzeigenMitarbeiterKonto()
        End If
        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New MitarbeiterKontoView(Me)
        mMitarbeiter = New Mitarbeiter
        mView.ShowDialog()
    End Sub
    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property EinzelMitarbeiter As Mitarbeiter
        Get
            Return mMitarbeiter
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Public Property View As MitarbeiterKontoView
        Get
            Return mView
        End Get
        Set(value As MitarbeiterKontoView)
        End Set
    End Property

    Public Property MitarbeiterDAO As MitarbeiterDAO
        Get
            Return mmitDAO
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property

    Public Sub anzeigenMitarbeiterKonto()
        mView.leeren()
        mView.anzeigenKonto()
        mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
        mView.txtMitarbeiterID.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID
        mView.txtVorname.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Vorname
        mView.txtName.Text = mmitDAO.findenMitarbeiterId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Name
        mView.txtBenutzername.Text = mmitDAO.findenMitarbeiterId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Benutzername
    End Sub

    Public Sub verarbeiteSpeichern(pMitarbeiter As Mitarbeiter)
        If String.IsNullOrEmpty(mView.txtName.Text) Or String.IsNullOrEmpty(mView.txtBenutzername.Text) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            mMitarbeiter.Vorname = mView.txtVorname.Text
            mMitarbeiter.Name = mView.txtName.Text
            mMitarbeiter.Benutzername = mView.txtBenutzername.Text
            mMitarbeiter.Passwort = mView.txtNeuesPass.Text
            mMitarbeiter.Version = pMitarbeiter.Version + 1

            Dim lngErgebnis As Long
            lngErgebnis = MitarbeiterDAO.speichernMitarbeiter(mMitarbeiter)
            If lngErgebnis = mMitarbeiter.BenutzerID Then
                mErgebnis = EPresenterErgebnis.SPEICHERN
                MsgBox("Ihre Änderungen werden erfolgreich gespeichert", vbOKOnly)
                mView.Close()
            Else
                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
            End If
        End If
    End Sub
    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

    '    Sub New(pMitarbeiter As Mitarbeiter)
    '        mMitBenutzer = pMitarbeiter

    '        mView = New MitarbeiterKontoView(Me)
    '        mMitarbeiter = New Mitarbeiter
    '        mMitarbeiter.ID = pMitarbeiter.BenutzerID
    '        mMitarbeiter.Nachname = pMitarbeiter.Name
    '        mMitarbeiter.Vorname = pMitarbeiter.Vorname
    '        mMitarbeiter.Benutzername = pMitarbeiter.Benutzername
    '        mMitarbeiter.Passwort = pMitarbeiter.Passwort
    '        'mMitarbeiter.Typ = "M"
    '        mMitarbeiter.Version = 0

    '        anzeigen()
    '        mView.ShowDialog()
    '    End Sub

    '    Sub New()
    '        mView = New MitarbeiterKontoView(Me)
    '        mMitBenutzer = New Benutzer
    '        mView.ShowDialog(Me)
    '    End Sub
    '    Public Property View As MitarbeiterKontoView
    '        Get
    '            Return mView
    '        End Get
    '        Set(value As MitarbeiterKontoView)
    '        End Set
    '    End Property

    '    Public Property Mitarbeiter As Mitarbeiter
    '        Get
    '            Return mMitarbeiter
    '        End Get
    '        Set(value As Mitarbeiter)
    '        End Set
    '    End Property

    '    Public Property MitDAO As MitarbeiterDAO
    '        Get
    '            Return mmitDAO
    '        End Get
    '        Set(value As MitarbeiterDAO)
    '        End Set
    '    End Property


    '    Public Sub anzeigen()
    '        mView.leeren()
    '        mView.anzeigenKonto()
    '        mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
    '        mView.txtMitarbeiterID.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID
    '        mView.txtVorname.Text = mmitDAO.findenMitarbeiterId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Vorname
    '        mView.txtName.Text = mmitDAO.findenMitarbeiterId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Name
    '        mView.txtBenutzername.Text = mmitDAO.findenMitarbeiterId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Benutzername

    '    End Sub

    '    Public Sub verarbeiteSpeichern(pMit As Mitarbeiter, pNeuesPw As String)



    '        If pNeuesPw IsNot String.Empty Then
    '            If Not pMit.Passwort = mMitarbeiter.Passwort Then
    '                MsgBox("Altes Passwort ist Falsch")
    '                Exit Sub
    '            Else
    '                mMitarbeiter.Passwort = pNeuesPw
    '                mMitarbeiter.Nachname = pMit.Nachname

    '                Dim lngErgebnis As Long
    '                MitarbeiterDAO.speichernMitarbeiter(mMitarbeiter)
    '                If lngErgebnis = mMitarbeiter.BenutzerID Then
    '                    mErgebnis = EPresenterErgebnis.SPEICHERN
    '                    MsgBox("Ihre Änderungen werden erfolgreich gespeichert", vbOKOnly)
    '                    mView.Close()
    '                Else
    '                    MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
    '                End If
    '            End If
    '                Else
    '            mMitarbeiter.Nachname = pMit.Nachname
    '            'MsgBox(mMitarbeiter.ID & "     " & mMitarbeiter.Nachname)
    '            Dim lngErgebnis As Long
    '            MitarbeiterDAO.speichernMitarbeiter(mMitarbeiter)
    '            If lngErgebnis = mMitarbeiter.BenutzerID Then
    '                mErgebnis = EPresenterErgebnis.SPEICHERN
    '                MsgBox("Ihre Änderungen werden erfolgreich gespeichert", vbOKOnly)
    '                mView.Close()
    '            Else
    '                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
    '            End If
    '        End If
    '    End Sub

    '    Public Sub verarbeiteAbbrechen()
    '        mView.Close()
    '    End Sub
End Class
