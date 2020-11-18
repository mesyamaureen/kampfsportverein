Public Class TrainerkontoPresenter
    Private mTrainerEinzel As Trainer
    Private mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As TrainerkontoView

    Sub New()
        'MyBase.New
        mView = New TrainerkontoView(Me)
        mTrainerEinzel = New Trainer

        anzeigen()
        mView.ShowDialog()
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
            Return mView
        End Get
        Set(value As TrainerkontoView)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigen(mlstTrainer(1).BenutzerID, mlstTrainer(1).Vorname, mlstTrainer(1).Name,
                       mlstTrainer(1).Benutzername, mlstTrainer(1).Passwort)
    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub
End Class