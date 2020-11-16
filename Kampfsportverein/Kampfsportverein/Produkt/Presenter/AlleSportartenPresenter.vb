Public Class AlleSportartenPresenter
    Private mErgebnis As Integer
    Private mistSportart As Integer
    Private mView As Integer

    Public Property View As AlleSportartenView
        Get
            Return Nothing
        End Get
        Set(value As AlleSportartenView)
        End Set
    End Property

    Public Property Ergebnis As Kampfsportverein.AlleSportartenPresenter
        Get
            Return Nothing
        End Get
        Set(value As Kampfsportverein.AlleSportartenPresenter)
        End Set
    End Property

    Public Property SportartenAlle As Sportarten
        Get
            Return Nothing
        End Get
        Set(value As Sportarten)
        End Set
    End Property

    Public Sub verarbeiteLoeschen()

    End Sub

    Public Sub verarbeiteBearbeiten()

    End Sub

    Public Sub verarbeiteNeueSportart()

    End Sub
End Class
