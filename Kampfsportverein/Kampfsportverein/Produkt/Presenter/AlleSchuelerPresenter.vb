Public Class SchuelerAllePresenter
    Private mErgebnis As Integer
    Private mView As Integer
    Private mistSchuelerAlle As Integer

    Sub New()

    End Sub

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

    Public Sub verarbeiteOeffnen()

    End Sub

    Public Sub verarbeiteNeu()

    End Sub

    Public Sub verarbeiteLoeschen()

    End Sub
End Class
