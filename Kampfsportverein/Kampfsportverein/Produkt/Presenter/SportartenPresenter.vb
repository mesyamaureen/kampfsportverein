Public Class SportartenPresenter
    Private mErgebnis As EPresenterErgebnis
    Private mSpor As Sportart
    Private mView As SportartenView

    Sub New(pSpor As Sportart)

        mSpor = pSpor
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

    End Sub

    Public Sub verarbeiteOeffnen()

    End Sub

    Public Sub verarbeiteOk()

    End Sub

    Public Sub verarbeiteAbbrechen()

    End Sub

End Class
