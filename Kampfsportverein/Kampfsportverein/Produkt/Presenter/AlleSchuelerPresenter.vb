Public Class SchuelerAllePresenter
    Public mErgebnis As EPresenterErgebnis
    Private mView As AlleSchuelerView
    Public mistSchuelerAlle As List(Of Schueler)

    Sub New(schueler As Schueler)
        mView = New AlleSchuelerView(Me)
        mView.ShowDialog()
    End Sub

    Public Property View As AlleSchuelerView
        Get
            Return mView
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

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub verarbeiteOeffnen()

    End Sub

    Public Sub verarbeiteNeu()

    End Sub

    Public Sub verarbeiteLoeschen()

    End Sub
End Class
