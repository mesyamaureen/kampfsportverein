Public Class MitarbeiterAllePresenter
    Private mErgebnis As EPresenterErgebnis
    Private mView As MitarbeiterAlleView
    Private mlstSportartAlle As List(Of Sportart)
    Private mlstKurseAlle As List(Of Kurs)
    Private mlstSchuelerAlle As List(Of Schueler)
    Private mlstTrainerAlle As List(Of Trainer)
    Private mMitarbeiterDAO As MitarbeiterDAO = New MitarbeiterDAO
    Private mTrainerDAO As TrainerDAO = New TrainerDAO
    Private mistMitarbeiterAlle As MitarbeiterAllePresenter

    Public Sub New()
        mView = New MitarbeiterAlleView(Me) 'Neue View erzeugen
        'SOLLTE BIS ZEILE 18 GELÖSCHT WERDEN (AM ENDE)
        'mlstSportartAlle = Kampfsportverein.mlstSportart
        'mlstKurseAlle = Kampfsportverein.mlstKurs
        'mlstSchuelerAlle = Kampfsportverein.mlstSchueler
        'mlstTrainerAlle = Kampfsportverein.mlstTrainer
        'verarbeiteMitarbeiterEinzeln()
        verarbeiteSportartUebersichtAnzeigen()
        verarbeiteKursuebersichtAnzeigen()
        verarbeiteSchueleruebersichtAnzeigen()
        verarbeiteTrainerUebersichtAnzeigen()
        anzeigenMitarbeiterAlle()
        anzeigenKursAlle()
        anzeigenSchueleruebersichtAnzeigen()
        anzeigenTrainerAlle()

        'Daten an die Oberfläche übergeben
        anzeigenKursAlle()
        anzeigenMitarbeiterAlle()
        'Anzeige der View als Oberfläche
        Application.Run(mView)

    End Sub

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property MitarbeiterAlle As Mitarbeiter
        Get
            Return Nothing
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Public Property View As MitarbeiterAlleView
        Get
            Return mView
        End Get
        Set(value As MitarbeiterAlleView)
        End Set
    End Property

    Public Property Mitarbeiter As Mitarbeiter
        Get
            Return Nothing
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Private Sub anzeigenMitarbeiterAlle()
        mView.leeren()
        mView.anzeigenSportartenuebersicht()
        'anzeigen lstSportart
        For Each sport As Sportart In mlstSportartAlle
            mView.hinzufuegenZeileSportart(sport.ID, sport.Name)
        Next
    End Sub

    Private Sub anzeigenKursAlle()
        mView.leeren()
        mView.anzeigenKursuebersicht()
        'anzeigen lstKurs
        For Each kurs As Kurs In mlstKurseAlle
            mView.hinzufuegenZeileKurse(mlstKurseAlle.IndexOf(kurs), kurs.Zeitpunkt, kurs.SaIdFk, kurs.BenIdFk)
        Next
    End Sub

    Private Sub anzeigenSchueleruebersichtAnzeigen()
        mView.leeren()
        mView.anzeigenSchueleruebersicht()
        'anzeigen lstKurs
        For Each schueler As Schueler In mlstSchuelerAlle
            mView.hinzufuegenZeileSchueler(mlstSchuelerAlle.IndexOf(schueler), schueler.Name, schueler.Vorname)
        Next
    End Sub

    Private Sub anzeigenTrainerAlle()
        mView.leeren()
        mView.anzeigenTraineruebersicht()
        For Each trainer As Trainer In mlstTrainerAlle
            mView.hinzufuegenZeileTrainer(mlstTrainerAlle.IndexOf(trainer), trainer.Name, trainer.Vorname)
        Next
    End Sub

    Public Sub verarbeiteMitarbeiterEinzeln(plngBenIdPk As Long) 'button Mein Konto
        'mView.anzeigenMeinKonto()
        'Dim mit As Mitarbeiter
        'Dim mitKontoPresenter As MitarbeiterKontoPresenter
        'mit = mMitarbeiterDAO.findenMitarbeiterId(plngBenIdPk)
        ' Übergeben der Sportart zur Anzeige im Presenter
        'mitKontoPresenter = New MitarbeiterKontoPresenter(mit)
        'If MitarbeiterKontoPresenter.mErgebnis = EPresenterErgebnis.EIGENEKURSE_ANZEIGEN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
        'verarbeiteKursuebersichtAnzeigen()
        'End If
    End Sub

    Public Sub verarbeiteSportartUebersichtAnzeigen() 'button Sportarten
        mErgebnis = EPresenterErgebnis.SPORTART_ANZEIGEN
        mMitarbeiterDAO = DAOFactory.Instanz.MitarbeiterDAO
        mlstSportartAlle = mMitarbeiterDAO.findenAlleSportarten()
        anzeigenMitarbeiterAlle()
    End Sub

    Public Sub verarbeiteKursuebersichtAnzeigen() 'button Kurse
        mErgebnis = EPresenterErgebnis.KURS_ANZEIGEN
        mMitarbeiterDAO = DAOFactory.Instanz.MitarbeiterDAO
        mlstKurseAlle = mMitarbeiterDAO.findeAlleKurse()
        anzeigenKursAlle()
    End Sub

    Public Sub verarbeiteSchueleruebersichtAnzeigen() 'button Schüler
        mErgebnis = EPresenterErgebnis.MITGLIEDER_ANZEIGEN
        mTrainerDAO = DAOFactory.Instanz.TrainerDAO
        mlstSchuelerAlle = mTrainerDAO.findeAlleSchueler()
        anzeigenSchueleruebersichtAnzeigen()
    End Sub

    Public Sub verarbeiteTrainerUebersichtAnzeigen() 'button Trainer
        mErgebnis = EPresenterErgebnis.TRAINER_EINZELN
        mTrainerDAO = DAOFactory.Instanz.TrainerDAO
        mlstTrainerAlle = mTrainerDAO.findeAlleTrainer()
        anzeigenTrainerAlle()
    End Sub

    Public Sub verarbeiteSportartOeffnen(plngSportartId As Long) 'button Öffnen
        ' Deklaration
        Dim spor As Sportart ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim sporPresenter As SportartenPresenter ' Presenter zum anzeigen der Sportart

        ' Ermitteln der Sportart anhand der ID aus der DB
        spor = mMitarbeiterDAO.findeSportart(plngSportartId)
        ' Übergeben der Sportart zur Anzeige im Presenter
        sporPresenter = New SportartenPresenter(spor)

        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If sporPresenter.mErgebnis = EPresenterErgebnis.SPORTART_EINZELN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteSportartUebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteKursOeffnen(plngKursId As Long) 'button Öffnen für Kurs
        Dim ausgewaehlterKurs As Kurs ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim kursPresenter As KursPresenter ' Presenter zum anzeigen der Sportart

        ' Ermitteln der Sportart anhand der ID aus der DB
        plngKursId += 1  'weil Index auf Datenbank von 1 anfängt
        ausgewaehlterKurs = mMitarbeiterDAO.findeKurs(plngKursId)
        ' Übergeben der Sportart zur Anzeige im Presenter
        kursPresenter = New KursPresenter(ausgewaehlterKurs)

        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If kursPresenter.mErgebnis = EPresenterErgebnis.EIGENEKURSE_ANZEIGEN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteKursuebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteSchuelerOeffnen(plngSchuelerId As Long) 'button Öffnen für Schueler
        Dim schueler As Schueler ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim schuPresenter As SchuelerAllePresenter ' Presenter zum anzeigen der Sportart

        ' Ermitteln der Sportart anhand der ID aus der DB
        plngSchuelerId += 1
        schueler = mTrainerDAO.findenAlleMitSchuelerId(plngSchuelerId) ' Übergeben der Sportart zur Anzeige im Presenter
        schuPresenter = New SchuelerAllePresenter(schueler)

        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If schuPresenter.mErgebnis = EPresenterErgebnis.MITGLIEDER_EINZELN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteSchueleruebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteTrainerOeffnen(plngTrainerId As Long) 'button Öffnen für Trainer
        Dim tra As Trainer ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim traPresenter As TrainerkontoPresenter ' Presenter zum anzeigen der Sportart

        ' Ermitteln der Sportart anhand der ID aus der DB
        plngTrainerId += 1
        tra = mTrainerDAO.findenTrainerId(plngTrainerId)
        ' Übergeben der Sportart zur Anzeige im Presenter
        traPresenter = New TrainerkontoPresenter()

        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If traPresenter.mErgebnis = EPresenterErgebnis.TRAINER_EINZELN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteTrainerUebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteNeu() 'button Neu

        Dim sporPresenter As SportartenPresenter ' Presenter zum anzeigen der Sportart
        sporPresenter = New SportartenPresenter()
        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If sporPresenter.mErgebnis = EPresenterErgebnis.SPORTART_EINZELN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteSportartUebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteNeuKurs()
        'Neu MVP für Hinzufügen-Seite
    End Sub

    Public Sub verarbeiteNeuSchueler()
        'Neu MVP für Hinzufügen-Seite
    End Sub

    Public Sub verarbeiteNeuTrainer()
        Dim neuerTrainerPresenter As NeuerTrainerPresenter
        neuerTrainerPresenter = New NeuerTrainerPresenter()
        If neuerTrainerPresenter.mErgebnis = EPresenterErgebnis.TRAINER_ERSTELLEN Then
            'mView. -- Wieeeee??
        End If
    End Sub

    Public Sub verarbeiteLoeschen(plngSportartId As Long) 'button Löschen

        ' Deklaration
        Dim spor As Sportart ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim bolErgebnis As Boolean
        spor = mMitarbeiterDAO.findeSportart(plngSportartId) ' Ermitteln der Sportart anhand der ID aus der DB
        bolErgebnis = MitarbeiterDAO.loeschenMitSportartId(plngSportartId, spor.Version)
        If bolErgebnis Then
            verarbeiteSportartUebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If

    End Sub

    Public Sub verarbeiteLoeschenKurs(plngKursId As Long)
        Dim kurs As Kurs
        Dim bolKursErgebnis As Boolean
        kurs = mMitarbeiterDAO.findeKurs(plngKursId)
        bolKursErgebnis = MitarbeiterDAO.loeschenKursTraId(plngKursId, kurs.Version)
        If bolKursErgebnis Then
            verarbeiteKursuebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If
    End Sub

    Public Sub verarbeiteLoeschenSchueler(plngSchuId As Long)
        Dim schu As Schueler
        Dim bolSchuErgebnis As Boolean
        schu = mTrainerDAO.findenAlleMitSchuelerId(plngSchuId)
        bolSchuErgebnis = TrainerDAO.loeschenMitSchuelerId(plngSchuId, schu.Version)
        If bolSchuErgebnis Then
            verarbeiteSchueleruebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If
    End Sub

    Public Sub verarbeiteLoeschenTrainer(plngTraId As Long)
        Dim tra As Trainer
        Dim bolTraErgebnis As Boolean
        tra = mTrainerDAO.findenTrainerId(plngTraId)
        'need to create a loeschenTrainerId Function in TrainerDAO!
    End Sub

    Public Sub verarbeiteBeenden() 'button Beenden
        mView.Close()
    End Sub

End Class
