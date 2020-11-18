Public Class MitarbeiterAllePresenter
    Private mErgebnis As Integer
    Private mView As MitarbeiterAllePresenter

    Private mistMitarbeiterAlle As MitarbeiterAllePresenter

    Sub New()

    End Sub

    Public Property Ergebnis As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
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
            Return Nothing
        End Get
        Set(value As MitarbeiterAlleView)
        End Set
    End Property

    Private Sub anzeigen()

    End Sub

    Public Sub verarbeiteBearbeiten() 'für SportartuebersichtAnzeigen()

    End Sub

    Public Sub verarbeiteBeenden() 'button Beenden

    End Sub

    Public Sub verarbeiteTrainerHinzufuegen() 'button Neuer Trainer

    End Sub

    Public Sub verarbeiteLoeschen() 'kein Button Löschen

    End Sub

    Public Sub verarbeiteSchliessen() 'kein button Schliessen

    End Sub

    Public Sub verarbeiteTrainerUebersichtAnzeigen() 'menü Alle Trainer

    End Sub

    Public Sub verarbeiteSchueleruebersichtAnzeigen() 'menü Alle Schüler

    End Sub

    Public Sub verarbeiteKursuebersichtAnzeigen() 'keine direkte Übersicht von Kursen vll. statt Kursübersicht: Kurs hinzufügen

    End Sub

    Public Sub verarbeiteSportartuebersichtAnzeigen() 'button Bearbeiten

    End Sub

    Public Sub verarbeiteMitarbeiterHinzufuegen() 'kein Neuer Mitarbeiter Button

    End Sub

    Public Sub verarbeiteSchuelerHinzufuegen() 'wieso hier? auf frmHauptfensterMit gibt's keine Neue Schüler Schaltfläche

    End Sub
End Class
