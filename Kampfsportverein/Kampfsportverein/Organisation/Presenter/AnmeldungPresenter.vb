Public Class AnmeldungPresenter
    Private mErgebnis As EPresenterErgebnis
    Private mView As AnmeldungView
    Private mAngemeldeterBenutzer As Benutzer

    Public Sub New()
        mView = New AnmeldungView()
        'anzeigen()
        Application.Run(mView)
    End Sub

    Public Property View As AnmeldungView
        Get
            Return Nothing
        End Get
        Set(value As AnmeldungView)
            mView = value
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return Nothing
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property AngemeldeterBenutzer As Benutzer
        Get
            Return Nothing
        End Get
        Set(value As Benutzer)
        End Set
    End Property
End Class
