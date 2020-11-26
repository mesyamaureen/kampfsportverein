Public Class TrainerAllePresenter
    Private mErgebnis As EPresenterErgebnis
    Private mlstKursAlle As List(Of Kurs)
    Private mlstSchuelerAlle As List(Of Schueler)
    Private mView As TrainerAlleView
    Private mTrainerAlle As Trainer

    'Parameterloser Konstruktor
    Public Sub New()
        mView = New TrainerAlleView(Me)
        mlstKursAlle = Kampfsportverein.mlstKurs
        mlstSchuelerAlle = Kampfsportverein.mlstSchueler
        mTrainerAlle = New Trainer

        'Daten an die Oberfläche übergeben
        anzeigenTrainerAlle()
        'Anzeige der View als Oberfläche (Formular)
        Application.Run(mView)
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

    Private Sub anzeigenTrainerAlle() 'anzeigen der Liste von Kurs auf dem frmHauptfensterTrainer
        mView.leeren()
        mView.anzeigen()
        'anzeigen lstKurse
        For Each kurs As Kurs In mlstKursAlle
            mView.hinzufuegenZeileKurs(mlstKursAlle.IndexOf(kurs), kurs.Zeitpunkt,
                                       kurs.Sportarten, kurs.Verfuegbarkeit)
        Next
    End Sub

    Public Sub verarbeiteEigenesProfilAnzeigen() 'button Mein Konto
        Dim presenter As TrainerkontoPresenter = New TrainerkontoPresenter()
        If mErgebnis = EPresenterErgebnis.EIGENESPROFIL_ANZEIGEN Then
            presenter.anzeigen()
        Else 'nichts tun
        End If
    End Sub

    Public Sub verarbeiteKursuebersichtAnzeigen(lngIndex As Long) 'button Kurse
        'Dim kurs As Kurs
        'Dim kursPresenter As KursPresenter
        'kurs = mlstKursAlle.Item(lngIndex)
        'kursPresenter = New KursPresenter '(kurs)

        'Select Case kursPresenter.Ergebnis
        '    Case EPresenterErgebnis.EIGENEKURSE_ANZEIGEN
        '        anzeigen()
        '    Case EPresenterErgebnis.ABSAGEN
        '        anzeigen()
        '    Case EPresenterErgebnis.ABBRECHEN
        '        'Nichts zu tun, denn Inhalte der Felder in der View wurde verworfen
        '    Case Else
        'End Select
    End Sub

    Public Sub verarbeiteSchueleruebersichtAnzeigen() 'button Schüler
        mErgebnis = EPresenterErgebnis.MITGLIEDER_ANZEIGEN
        mView.Close()
    End Sub

    Public Sub verarbeiteOeffnen() 'button Öffnen

    End Sub

    Public Sub verarbeiteLoeschen() 'button Löschen

    End Sub

    Public Sub verarbeiteNeu() 'button Neu
        mErgebnis = EPresenterErgebnis.MITGLIEDER_ERSTELLEN
        mView.Close()
    End Sub

    Public Sub verarbeiteBeenden()
        mView.Close()
    End Sub
End Class
