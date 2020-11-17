Public Class AlleSchuelerPresenter
    Private mErgebnis As Integer
    Private mView As Integer
    Private mistSchueler As Integer

    Public Property View As AlleSchuelerView
        Get
            Return Nothing
        End Get
        Set(value As AlleSchuelerView)
        End Set
    End Property

    Public Property SchuelerAlle As Schueler
        Get
            Return Nothing
        End Get
        Set(value As Schueler)
        End Set
    End Property

    Public Property Ergebnis As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Sub verabeiteLoeschen()

    End Sub

    Public Sub verarbeiteRegistrieren()

    End Sub

    Public Sub verarbeiteBearbeiten()

    End Sub

    Public Sub verarbeiteErstellen()

    End Sub

    Public Sub verarbeitenEntfernen()

    End Sub
End Class
