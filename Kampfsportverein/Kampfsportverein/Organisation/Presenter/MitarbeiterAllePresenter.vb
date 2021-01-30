Public Class MitarbeiterAllePresenter
    Private mErgebnis As EPresenterErgebnis
    Private mView As MitarbeiterAlleView
    Private mlstSportartAlle As List(Of Sportart)
    Private mlstKurseAlle As List(Of Kurs)
    Private mlstSchuelerAlle As List(Of Schueler)
    Private mlstTrainerAlle As List(Of Trainer)
    Private mMitarbeiterDAO As MitarbeiterDAO = New MitarbeiterDAO
    Private mistMitarbeiterAlle As MitarbeiterAllePresenter

    Sub New()
        mView = New MitarbeiterAlleView(Me)
        mlstSportartAlle = Kampfsportverein.mlstSportart
        mlstKurseAlle = Kampfsportverein.mlstKurs
        mlstSchuelerAlle = Kampfsportverein.mlstSchueler
        mlstTrainerAlle = Kampfsportverein.mlstTrainer
        'Daten an die Oberfläche übergeben
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
            mView.hinzufuegenZeileSportart(mlstSportartAlle.IndexOf(sport), sport.Name)
        Next
    End Sub

    Public Sub verarbeiteMitarbeiterEinzeln() 'button Mein Konto

    End Sub
    Public Sub verarbeiteSportartUebersichtAnzeigen() 'button Sportarten
        mErgebnis = EPresenterErgebnis.SPORTART_ANZEIGEN
        mlstSportartAlle = mMitarbeiterDAO.findenAlleSportarten()
        anzeigenMitarbeiterAlle()
    End Sub

    Public Sub verarbeiteKursuebersichtAnzeigen() 'button Kurse
        mErgebnis = EPresenterErgebnis.KURS_ANZEIGEN
        mView.leeren()
        mView.anzeigenKursuebersicht()
        For Each kurs As Kurs In mlstKurseAlle
            mView.hinzufuegenZeileKurse(mlstKurseAlle.IndexOf(kurs), kurs.Zeitpunkt,
                                        kurs.Sportarten, kurs.Verfuegbarkeit)
        Next
    End Sub
    Public Sub verarbeiteSchueleruebersichtAnzeigen() 'button Schüler
        mErgebnis = EPresenterErgebnis.MITGLIEDER_ANZEIGEN
        mView.leeren()
        mView.anzeigenSchueleruebersicht()
        For Each schueler As Schueler In mlstSchuelerAlle
            mView.hinzufuegenZeileSchueler(mlstSchuelerAlle.IndexOf(schueler),
                                           schueler.Name, schueler.Vorname)
        Next
    End Sub
    Public Sub verarbeiteTrainerUebersichtAnzeigen() 'button Trainer
        mErgebnis = EPresenterErgebnis.TRAINER_ANZEIGEN
        mView.leeren()
        mView.anzeigenTraineruebersicht()
        For Each trainer As Trainer In mlstTrainerAlle
            mView.hinzufuegenZeileTrainer(mlstTrainerAlle.IndexOf(trainer),
                                          trainer.Name, trainer.Vorname)
        Next
    End Sub

    Public Sub verarbeiteSportartÖffnen(plngSportartId As Long) 'button Öffnen
        ' Deklaration
        Dim spor As Sportart ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim sporPresenter As SportartenPresenter ' Presenter zum anzeigen der Sportart

        ' Ermitteln der Sportart anhand der ID aus der DB
        spor = mMitarbeiterDAO.findeSportart(plngSportartId)
        ' Übergeben der Sportart zur Anzeige im Presenter
        sporPresenter = New SportartenPresenter(spor)

        ' Liste muss nur aktualisiert werden, wenn Änderungen im
        ' SportartPresenter gespeichert wurden 
        If sporPresenter.mErgebnis = EPresenterErgebnis.SPEICHERN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27
            verarbeiteSportartUebersichtAnzeigen()
        End If
    End Sub
    Public Sub verarbeiteNeu() 'button Neu

        Dim sporPresenter As SportartenPresenter ' Presenter zum anzeigen der Sportart
        sporPresenter = New SportartenPresenter()
        If sporPresenter.mErgebnis = EPresenterErgebnis.SPEICHERN Then 'Presenterergebnis noch nicht voirhanden -2021-01-27
            verarbeiteSportartUebersichtAnzeigen()
        End If
    End Sub
    Public Sub verarbeiteLoeschen(plngSportartId As Long) 'button Löschen

        ' Deklaration
        Dim spor As Sportart ' Sportart, deren Details in einem neuen Fenster geöffnet werden sollen
        Dim bolErgebnis As Boolean

        ' Ermitteln der Sportart anhand der ID aus der DB
        spor = mMitarbeiterDAO.findeSportart(plngSportartId)

        bolErgebnis = MitarbeiterDAO.loeschenMitSportartId(plngSportartId, spor.Version)
        If bolErgebnis Then
            verarbeiteSportartUebersichtAnzeigen()
        Else
            MsgBox("Es ist ein Fehler beim Löschen aufgetreten", vbOKOnly)
        End If

    End Sub

    Public Sub verarbeiteBeenden() 'button Beenden
        mView.Close()
    End Sub

End Class
