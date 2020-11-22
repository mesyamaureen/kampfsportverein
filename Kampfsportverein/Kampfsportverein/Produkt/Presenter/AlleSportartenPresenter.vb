Public Class SportartenPresenter
    Private mErgebnis As SportartenPresenter
    Private mistSportart As Integer
    Private mView As Integer

    Sub New()

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

    End Sub

    Public Sub verarbeiteOeffnen()

    End Sub
End Class
