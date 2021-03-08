Public Class TrainerAllePresenter
    Public mErgebnis As EPresenterErgebnis
    Private mlstKursAlle As List(Of Kurs)
    Private mlstSchuelerAlle As List(Of Schueler)
    Private mView As TrainerAlleView
    Private mTrainerAlle As Trainer
    Private mmitDAO As MitarbeiterDAO = New MitarbeiterDAO
    Private mtraDAO As TrainerDAO = New TrainerDAO

    'Parameterloser Konstruktor
    Public Sub New()
        mView = New TrainerAlleView(Me)
        'mlstKursAlle = Kampfsportverein.mlstKurs
        'mlstSchuelerAlle = Kampfsportverein.mlstSchueler SOLLTE BIS HIER GELÖSCHT WERDEN (AM ENDE)
        mTrainerAlle = New Trainer

        'Daten an die Oberfläche übergeben
        verarbeiteKursuebersichtAnzeigen()
        verarbeiteSchueleruebersichtAnzeigen()
        'verarbeiteEigenesProfilAnzeigen()
        'anzeigenKursAlle()
        'anzeigenSchuelerAlle()

        'Anzeige der View als Oberfläche (Formular)
        mView.ShowDialog()
        'Application.Run(mView)
    End Sub

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
            mErgebnis = value
        End Set
    End Property

    Private ReadOnly Property TrainerAlle As Trainer 'brauchen wir hier Property:TrainerAlle oder Liste Kurse?
        Get
            Return mTrainerAlle
        End Get
    End Property

    Public Property View As TrainerAlleView
        Get
            Return mView
        End Get
        Set(value As TrainerAlleView)
            mView = value
        End Set
    End Property

    Public Property Trainer As Trainer
        Get
            Return Nothing
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Private Sub anzeigenKursAlle() 'anzeigen der Liste von Kurs auf dem frmHauptfensterTrainer
        mView.leeren()
        mView.anzeigenKurse()
        'anzeigen Kursliste
        For Each kurs As Kurs In mlstKursAlle
            mView.anzeigenKursUebersicht(kurs.IdPk, kurs.Zeitpunkt, kurs.SaIdFk, kurs.BenIdFk)
        Next
    End Sub

    Private Sub anzeigenSchuelerAlle()
        mView.leeren()
        mView.anzeigenSchueler()
        'anzeigen Schuelerliste
        For Each schueler As Schueler In mlstSchuelerAlle
            mView.anzeigenSchuelerUebersicht(schueler.SchuelerIdPk, schueler.Name, schueler.Vorname)
        Next
    End Sub
    Public Sub verarbeiteKursuebersichtAnzeigen() 'button Kurse
        mErgebnis = EPresenterErgebnis.EIGENEKURSE_ANZEIGEN
        Dim mitDAO As MitarbeiterDAO
        Dim benAngemeldet As Benutzer

        'Initialisierung
        benAngemeldet = BenutzerSitzung.Instanz.AktuellerBenutzer
        mitDAO = DAOFactory.Instanz.MitarbeiterDAO

        'Alle Kurse des Benutzers mit ID laden
        mlstKursAlle = mitDAO.findenBenKurs(benAngemeldet)
        anzeigenKursAlle()
    End Sub
    Public Sub verarbeiteSchueleruebersichtAnzeigen() 'button Schüler
        mErgebnis = EPresenterErgebnis.MITGLIEDER_ANZEIGEN
        mtraDAO = DAOFactory.Instanz.TrainerDAO
        mlstSchuelerAlle = mtraDAO.findeAlleSchueler()
        anzeigenSchuelerAlle()
    End Sub

    Public Sub verarbeiteEigenesProfilAnzeigen() 'button Mein Konto 
        Dim traBen As Benutzer
        Dim traKontoPresenter As KontoTrainerPresenter
        traBen = mtraDAO.findenTrainerId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID)
        traKontoPresenter = New KontoTrainerPresenter(traBen)
        If mErgebnis = EPresenterErgebnis.SPEICHERN Then
            anzeigenKursAlle()
        End If
    End Sub


    Public Sub verarbeiteKursOeffnen(plngKursId As Long) 'buttonÖffnen
        'Deklaration
        Dim kurs As Kurs
        Dim kursPresenter As KursPresenter

        'Ermitteln des Kurs anhand ID
        kurs = mmitDAO.findeKurs(plngKursId)
        'Übergeben der Sportart zur Anzeige im Presenter
        kursPresenter = New KursPresenter(kurs)
        'Liste muss aktualisiert, wenn es Änderungen gibt
        If kursPresenter.mErgebnis = EPresenterErgebnis.EIGENEKURSE_ANZEIGEN Then
            verarbeiteKursuebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteSchuelerOeffnen(plngSchuId As Long) 'button Öffnen
        'Deklaration
        Dim schueler As Schueler
        Dim schuPresenter As SchuelerAllePresenter
        'Ermitteln des Schuelers anhand ID
        schueler = mtraDAO.findenAlleMitSchuelerId(plngSchuId)
        'Übergeben des Schuelers zur Anzeige im Presenter
        schuPresenter = New SchuelerAllePresenter(schueler)
        'Liste muss aktualisiert, wenn es Änderungen gibt
        If schuPresenter.mErgebnis = EPresenterErgebnis.MITGLIEDER_EINZELN Then
            verarbeiteSchueleruebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteNeuSchueler()
        'Dim schueler As Schueler
        Dim schu As Schueler
        Dim neueSchuelerPresenter As NeueSchuelerPresenter
        schu = New Schueler()
        neueSchuelerPresenter = New NeueSchuelerPresenter(schu)
        If neueSchuelerPresenter.mErgebnis = EPresenterErgebnis.MITGLIEDER_ERSTELLEN Then
            verarbeiteSchueleruebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteBeenden()
        mView.Close()
    End Sub

    'LÖSCHEN (Am Ende)
    'Public Sub verarbeiteLoeschen(plngIndex As Long) 'button Löschen
    '    mlstKursAlle.RemoveAt(plngIndex)
    '    mlstSchuelerAlle.RemoveAt(plngIndex)
    '    anzeigenKursAlle()
    'End Sub

    'Public Sub verarbeiteNeu() 'button Neu
    '    Dim kurs As Kurs
    '    Dim kursPresenter As KursPresenter
    '    Dim schueler As Schueler
    '    Dim schuelerPresenter As SchuelerAllePresenter

    '    kurs = New Kurs
    '    kursPresenter = New KursPresenter(kurs)
    '    schueler = New Schueler
    '    schuelerPresenter = New SchuelerAllePresenter(schueler)

    '    If mErgebnis = EPresenterErgebnis.MITGLIEDER_ERSTELLEN Then
    '        mlstKursAlle.Add(kurs)
    '        mlstSchuelerAlle.Add(schueler)
    '    ElseIf mErgebnis = EPresenterErgebnis.ABBRECHEN Then
    '        kurs = Nothing
    '        schueler = Nothing
    '    Else
    '        'tun nichts
    '    End If

    'End Sub


End Class

