Public Class KursePresenter
    Private mView As Kurs
    Private mErgebnis As Kurs
    Private mistKurseAlle As Kurs

    Sub New()

    End Sub

    Public Property View As KurseView
        Get
            Return Nothing
        End Get
        Set(value As KurseView)
        End Set
    End Property

    Public Property Ergebnis As Kurs
        Get
            Return Nothing
        End Get
        Set(value As Kurs)
        End Set
    End Property

    Public Property KurseAlle As Kurs
        Get
            Return Nothing
        End Get
        Set(value As Kurs)
        End Set
    End Property

    Public Sub verarbeiteOeffnen()

    End Sub

    Public Sub verarbeiteNeu()

    End Sub

    Public Sub verarbeiteLoeschen()

    End Sub
End Class
