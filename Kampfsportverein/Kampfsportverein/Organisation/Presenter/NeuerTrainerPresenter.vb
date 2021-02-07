Public Class NeuerTrainerPresenter
    Private mNeuerTrainer As Trainer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As NeuerTrainerView
    Sub New()
        MyBase.New
        mView = New NeuerTrainerView(Me)
        mNeuerTrainer = New Trainer
        anzeigen()
        mView.ShowDialog()
    End Sub

    Public Property View As NeuerTrainerView
        Get
            Return mView
        End Get
        Set(value As NeuerTrainerView)
        End Set
    End Property

    Public Property NeuerTrainer As Trainer
        Get
            Return mNeuerTrainer
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigen(mlstMitarbeiter(1).Vorname, mlstMitarbeiter(1).Name, mlstMitarbeiter(1).Benutzername,
                       mlstMitarbeiter(1).Passwort)
    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

    Public Sub verarbeiteErstellen()

    End Sub
End Class
