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

    Public Property Mitarbeiter As Mitarbeiter
        Get
            Return Nothing
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Private Sub anzeigen()

    End Sub

    Public Sub verarbeiteMitarbeiterEinzeln() 'button Mein Konto

    End Sub
    Public Sub verarbeiteSportartUebersichtAnzeigen() 'button Sportarten

    End Sub

    Public Sub verarbeiteKursuebersichtAnzeigen() 'button Kurse

    End Sub
    Public Sub verarbeiteSchueleruebersichtAnzeigen() 'button Schüler

    End Sub
    Public Sub verarbeiteTrainerUebersichtAnzeigen() 'button Trainer

    End Sub

    Public Sub verarbeiteÖffnen() 'button Öffnen

    End Sub
    Public Sub verarbeiteNeu() 'button Neu

    End Sub
    Public Sub verarbeiteLoeschen() 'button Löschen

    End Sub

    Public Sub verarbeiteBeenden() 'button Beenden

    End Sub

End Class
