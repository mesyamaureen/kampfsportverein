Public Class MitarbeiterAllePresenter
    Private mErgebnis As Kampfsportverein.MitarbeiterAllePresenter
    Private mView As Kampfsportverein.MitarbeiterAllePresenter

    Private mistMitarbeiterAlle As Kampfsportverein.MitarbeiterAllePresenter

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

    Public Sub verarbeiteBearbeiten()

    End Sub

    Public Sub verarbeiteBeenden()

    End Sub

    Public Sub verarbeiteTrainerHinzufuegen()

    End Sub

    Public Sub verarbeiteLoeschen()

    End Sub

    Public Sub verarbeiteSchliessen()

    End Sub

    Public Sub verarbeiteTrainerUebersichtAnzeigen()

    End Sub

    Public Sub verarbeiteSchueleruebersichtAnzeigen()

    End Sub

    Public Sub verarbeiteKursuebersichtAnzeigen()

    End Sub

    Public Sub verarbeiteSportartuebersichtAnzeigen()

    End Sub

    Public Sub verarbeiteMitarbeiterHinzufuegen()

    End Sub

    Public Sub verarbeiteSchuelerHinzufuegen()

    End Sub
End Class
