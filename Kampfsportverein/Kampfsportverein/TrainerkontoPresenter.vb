Public Class TrainerkontoPresenter
    Private mTrainerEinzel As Trainer
    Private mErgebnis As EPresenterErgebnis
    Private mSitzung As Integer
    Private mView As TrainerkontoView

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
            Return mTrainerEinzel
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

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub
End Class