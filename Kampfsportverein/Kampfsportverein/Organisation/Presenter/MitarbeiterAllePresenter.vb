﻿Public Class MitarbeiterAllePresenter
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
        'SOLLTE BIS ZEILE 18 GELÖSCHT WERDEN (AM ENDE) -04.03.2021
        'mlstSportartAlle = Kampfsportverein.mlstSportart
        'mlstKurseAlle = Kampfsportverein.mlstKurs
        'mlstSchuelerAlle = Kampfsportverein.mlstSchueler
        'mlstTrainerAlle = Kampfsportverein.mlstTrainer
        'verarbeiteMitarbeiterEinzeln()
        verarbeiteSportartUebersichtAnzeigen()
        verarbeiteKursuebersichtAnzeigen()
        verarbeiteSchueleruebersichtAnzeigen()
        verarbeiteTrainerUebersichtAnzeigen()
        'anzeigenMitarbeiterAlle()
        'anzeigenKursAlle()
        'anzeigenSchueleruebersichtAnzeigen()
        'anzeigenTrainerAlle()

        'Daten an die Oberfläche übergeben
        'anzeigenKursAlle()
        'anzeigenMitarbeiterAlle()
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
        For Each kurs As Kurs In mlstKurseAlle
            mView.hinzufuegenZeileKurse(kurs.IdPk, kurs.Zeitpunkt, kurs.SaIdFk, kurs.BenIdFk)
        Next
    End Sub

    Private Sub anzeigenSchueleruebersichtAnzeigen()
        mView.leeren()
        mView.anzeigenSchueleruebersicht()
        For Each schueler As Schueler In mlstSchuelerAlle
            mView.hinzufuegenZeileSchueler(schueler.SchuelerIdPk, schueler.Name, schueler.Vorname)
        Next
    End Sub

    Private Sub anzeigenTrainerAlle()
        mView.leeren()
        mView.anzeigenTraineruebersicht()
        For Each trainer As Trainer In mlstTrainerAlle
            mView.hinzufuegenZeileTrainer(trainer.BenutzerID, trainer.Name, trainer.Vorname)
        Next
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
        schueler = mTrainerDAO.findenAlleMitSchuelerId(plngSchuelerId) ' Übergeben der Sportart zur Anzeige im Presenter
        schuPresenter = New SchuelerAllePresenter(schueler)

        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If schuPresenter.mErgebnis = EPresenterErgebnis.MITGLIEDER_EINZELN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteSchueleruebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteTrainerOeffnen(plngTrainerId As Long) 'button Öffnen für Trainer
        Dim tra As Trainer ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim traPresenter As KontoTrainerPresenter ' Presenter zum anzeigen der Sportart

        ' Ermitteln der Sportart anhand der ID aus der DB
        tra = mTrainerDAO.findenTrainerId(plngTrainerId)
        ' Übergeben der Sportart zur Anzeige im Presenter
        traPresenter = New KontoTrainerPresenter(tra)

        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If traPresenter.mErgebnis = EPresenterErgebnis.TRAINER_EINZELN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
            verarbeiteTrainerUebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteMitarbeiterEinzeln() 'button Mein Konto
        Dim mitBen As Benutzer
        Dim mitKontoPresenter As MitarbeiterKontoPresenter
        mitBen = mMitarbeiterDAO.findenMitarbeiterId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID)
        ' Übergeben der Sportart zur Anzeige im Presenter
        mitKontoPresenter = New MitarbeiterKontoPresenter(mitBen)
        'If MitarbeiterKontoPresenter.mErgebnis = EPresenterErgebnis.EIGENESPROFIL_ANZEIGEN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27 -> Erledigt -2021-01-31
        '    verarbeiteKursuebersichtAnzeigen()
        'End If
    End Sub

    Public Sub verarbeiteNeu() 'button Neu

        Dim sporPresenter As SportartenPresenter ' Presenter zum anzeigen der Sportart
        sporPresenter = New SportartenPresenter()
        ' Liste muss nur aktualisiert werden, wenn Änderungen im SportartPresenter gespeichert wurden 
        If sporPresenter.mErgebnis = EPresenterErgebnis.SPORTART_EINZELN Then
            verarbeiteSportartUebersichtAnzeigen()
        End If
    End Sub

    Public Sub verarbeiteNeuerKurs()
        Dim kurs As Kurs
        Dim neuerKursPresenter As NeuerKursPresenter
        Dim lngKursIdPk As Long

        kurs = New Kurs()
        neuerKursPresenter = New NeuerKursPresenter() 'kurs)
        lngKursIdPk = MitarbeiterDAO.hinzufuegenKurs(kurs)
        anzeigenKursAlle()
    End Sub

    Public Sub verarbeiteNeuSchueler()
        Dim schu As Schueler
        Dim neueSchuPresenter As NeueSchuelerPresenter()
        Dim lngSchuIdPk As Long

        schu = New Schueler()
        'neueSchuPresenter = New NeueSchuelerPresenter()
        lngSchuIdPk = mTrainerDAO.hinzufuegen(schu)
        anzeigenSchueleruebersichtAnzeigen()
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
        If plngKursId > 0 Then
            plngKursId -= 1
        End If
        kurs = mlstKurseAlle.Item(plngKursId)
        bolKursErgebnis = MitarbeiterDAO.loeschenKursTraId(kurs.IdPk, kurs.Version)
        If bolKursErgebnis = True Then
            verarbeiteKursuebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If
    End Sub

    Public Sub verarbeiteLoeschenSchueler(plngSchuId As Long)
        Dim schu As Schueler
        Dim bolSchuErgebnis As Boolean
        plngSchuId -= 1
        schu = mlstSchuelerAlle.Item(plngSchuId)
        bolSchuErgebnis = TrainerDAO.loeschenMitSchuelerId(schu.SchuelerIdPk, schu.Version)
        If bolSchuErgebnis = True Then
            verarbeiteSchueleruebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If
    End Sub

    Public Sub verarbeiteLoeschenTrainer(plngTraId As Long)
        Dim tra As Trainer
        Dim bolTraErgebnis As Boolean
        'plngTraId -= 1
        tra = mTrainerDAO.findenTrainerId(plngTraId)
        bolTraErgebnis = TrainerDAO.loeschenTrainer(tra.BenutzerID, tra.Version)
        If bolTraErgebnis = True Then
            verarbeiteTrainerUebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If
    End Sub

    Public Sub verarbeiteBeenden() 'button Beenden
        mView.Close()
    End Sub

End Class
