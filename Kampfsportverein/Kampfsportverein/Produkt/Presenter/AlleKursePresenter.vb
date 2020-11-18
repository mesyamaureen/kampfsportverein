Public Class AlleKursePresenter
    Private mView As Kurse
    Private mErgebnis As Kurse
    Private mistKurs As Kurse

    Sub New()

    End Sub

    Public Property View As AlleKurseView
        Get
            Return Nothing
        End Get
        Set(value As AlleKurseView)
        End Set
    End Property

    Public Property Ergebnis As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Kurse)
        End Set
    End Property

    Public Property KurseAlle As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Kurse)
        End Set
    End Property

    Public Sub verabeiteBearbeiten()

    End Sub

    Public Sub verabeiteLoeschen()

    End Sub

    Public Sub verarbeiteNeuerKurs()

    End Sub

    Public Sub verarbeiteTrainerzuordnung()

    End Sub
End Class
