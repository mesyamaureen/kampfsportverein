Public Class KontoTrainerPresenter
    Private mTrainer As Trainer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung  'benötigt? - 06.03.2021
    Private mView As KontoTrainerView
    Private mtraDAO As TrainerDAO

    Sub New(pTrainer As Trainer)
        mTrainer = pTrainer
        mView = New KontoTrainerView(Me)
        If BenutzerSitzung.Instanz.AktuellerBenutzer.GetType.Equals(GetType(Mitarbeiter)) Then
            anzeigenAusgewaehlterTrainer()
        Else anzeigenTrainerKonto()
        End If

        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New KontoTrainerView(Me)
        mTrainer = New Trainer
        mView.ShowDialog()
    End Sub

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property EinzelTrainer As Trainer
        Get
            Return mTrainer
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Public Property View As KontoTrainerView
        Get
            Return mView
        End Get
        Set(value As KontoTrainerView)
        End Set
    End Property

    Public Property TrainerDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Sub anzeigenAusgewaehlterTrainer()
        mView.leeren()
        mView.anzeigenTrainer()
        mtraDAO = DAOFactory.Instanz.TrainerDAO
        mView.txtTrainerID.Text = mTrainer.BenutzerID
        mView.txtVorname.Text = mTrainer.Vorname
        mView.txtName.Text = mTrainer.Name
        mView.txtBenutzername.Text = mTrainer.Benutzername
        mView.txtPasswort.Text = mTrainer.Passwort
    End Sub

    Public Sub anzeigenTrainerKonto()
        mView.leeren()
        mView.anzeigenTrainer()
        mView.txtTrainerID.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID
        mView.txtVorname.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Vorname
        mView.txtName.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Name
        mView.txtBenutzername.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.Benutzername
    End Sub

    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

End Class