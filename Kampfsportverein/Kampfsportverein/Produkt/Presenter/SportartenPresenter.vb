Public Class SportartenPresenter
    Inherits frmHauptfensterMit
    Private mErgebnis As EPresenterErgebnis
    Private mSpor As Sportart
    Private mView As SportartenView

    Sub New(pSpor As Sportart)

        mSpor = pSpor
        mView = New SportartenView(Me)
        mView.ShowDialog()



    End Sub

    Sub New()


        mView = New SportartenView(Me)
        mView.ShowDialog()



    End Sub

    Public Property View As SportartenView
        Get
            Return Nothing
        End Get
        Set(value As SportartenView)
        End Set
    End Property

    Public Property Ergebnis As SportartenPresenter
        Get
            Return Nothing
        End Get
        Set(value As SportartenPresenter)
        End Set
    End Property

    Public Property SportartenAlle As Sportart
        Get
            Return Nothing
        End Get
        Set(value As Sportart)
        End Set
    End Property

    Public Sub verarbeiteLoeschen()

    End Sub

    Public Sub verarbeiteBearbeiten()

    End Sub

    Public Sub verarbeiteNeueSportart()

    End Sub

    Public Sub verarbeiteNeu()
        ' Deklaration und Initialisierung des Aufgabenpresenters
        Dim sporPreseter As SportartenPresenter
        sporPreseter = New SportartenPresenter()

        ' Liste muss nur aktualisiert werden, wenn Änderungen im
        ' AufgabePresenter gespeichert wurden 
        If sporPreseter.Ergebnis = EPresenterErgebnis.SPEICHERN Then
            ermittelnAufgaben() ' Liste der Aufgaben aus Datenbank laden
            verarbeiteOeffnen() ' Anzeigen der neu geladenen Liste von Aufgaben
        End If
    End Sub


    Public Sub verarbeiteOeffnen()



        'frmHauptfensterMit.leeren() ' Leeren der Liste mit den Aufgaben in der View

        ermittelnAufgaben() ' Veränderungen an den Aufgaben aus der Datenbank laden

        ' Schleife über alle Aufgaben in der Liste
        For Each spor As Sportart In mlstSportart
            ' Die Eigenschaften jeder Aufgabe einzeln an die View übergeben, damit sie dort hinzugefügt werden
            mView.anzeigenSportart(mlstSportart.IndexOf(spor), spor.Name, spor.Herkunftsland, spor.Zielgruppe, spor.Mindestalter)
        Next

        ' Wegen der Änderung in der dargestellten Liste, müssen jetzt die Schaltflächen 
        ' entsprechend aktiviert bzw. deaktiviert werden
        ' frmHauptfensterMit.

    End Sub


    Public Sub verarbeiteOk()

    End Sub

    Public Sub verarbeiteAbbrechen()

    End Sub

    Private Sub ermittelnAufgaben()
        ' TODO: Vorübergehend Arbeit mit Beispieldaten
        'mlstAufgaben = Benutzersitzung.Instanz.AktuellerBenutzer.Aufgaben


        ' Deklaration
        Dim mMitarbeiterDAO As MitarbeiterDAO ' DAO für den Zugriff auf die Aufgaben in der Datenbank
        Dim aktuellerBenutzer As Benutzer ' Benutzer, dessen Aufgaben angezeigt werden sollen

        ' Initialisierung
        aktuellerBenutzer = BenutzerSitzung.Instanz.AktuellerBenutzer ' angemeldeten Benutzer ermitteln
        mMitarbeiterDAO = DAOFactory.Instanz.MitarbeiterDAO ' Initialisierung des DAO über die Factory

        ' Alle Aufgaben des Benutzers mit Hilfe des DAOs laden
        mlstSportart = mMitarbeiterDAO.findenAlleSportarten
    End Sub

End Class
