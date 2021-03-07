Public Class NeueSchuelerPresenter
    Private mNeueSchueler As Schueler
    Public mErgebnis As EPresenterErgebnis
    Private mView As NeueSchuelerView

    Sub New()
        mView = New NeueSchuelerView(Me)
        mNeueSchueler = New Schueler
        anzeigen()
        mView.ShowDialog()
    End Sub

    Public Property Schueler As Schueler
        Get
            Return mNeueSchueler
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

    Public Property View As NeueSchuelerView
        Get
            Return mView
        End Get
        Set(value As NeueSchuelerView)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigenNeueSchueler()
    End Sub

    Public Sub verarbeiteErstellen()

    End Sub
End Class
