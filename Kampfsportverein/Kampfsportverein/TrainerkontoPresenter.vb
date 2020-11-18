Public Class TrainerkontoPresenter
    Private mBenutzer As Integer
    Private mErgebnis As Integer
    Private mSitzung As Integer
    Private mView As Integer

    Sub New(pPresenter As TrainerkontoPresenter)

        MyBase.New


    End Sub

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return Nothing
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property TrainerEinzel As Trainer
        Get
            Return TrainerEinzel
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Public Property View As TrainerkontoView
        Get
            Return TrainerkontoView
        End Get
        Set(value As TrainerkontoView)
        End Set
    End Property

    Public Sub anzeigen()

    End Sub

    Public Sub verarbeiteSchliessen()

    End Sub
End Class