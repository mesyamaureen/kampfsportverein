Public Class MitarbeiterKontoPresenter
    Sub New()

    End Sub

    Public Property View As MitarbeiterKontoView
        Get
            Return Nothing
        End Get
        Set(value As MitarbeiterKontoView)
        End Set
    End Property

    Public Property MitEinzel As Mitarbeiter
        Get
            Return Nothing
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return Nothing
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub anzeigen()

    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()

    End Sub
End Class
