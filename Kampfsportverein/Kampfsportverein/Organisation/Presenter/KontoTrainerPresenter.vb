Public Class KontoTrainerPresenter
    Private mTrainer As Trainer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
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
    End Sub

    Public Sub anzeigenTrainerKonto()
        mView.leeren()
        mView.anzeigenTrainer()
        mtraDAO = DAOFactory.Instanz.TrainerDAO
        mView.txtTrainerID.Text = BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID
        mView.txtVorname.Text = mtraDAO.findenTrainerId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Vorname
        mView.txtName.Text = mtraDAO.findenTrainerId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Name
        mView.txtBenutzername.Text = mtraDAO.findenTrainerId(BenutzerSitzung.Instanz.AktuellerBenutzer.BenutzerID).Benutzername
    End Sub

    Public Sub verarbeiteSpeichern(pTrainer As Trainer)
        If String.IsNullOrEmpty(mView.txtVorname.Text) Or String.IsNullOrEmpty(mView.txtName.Text) Or String.IsNullOrEmpty(mView.txtBenutzername.Text) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            mTrainer.Vorname = mView.txtVorname.Text
            mTrainer.Name = mView.txtName.Text
            mTrainer.Benutzername = mView.txtBenutzername.Text
            If mView.txtNeuesPasswort.Text IsNot "" Then
                mTrainer.Passwort = mView.txtNeuesPasswort.Text
                Exit Sub
            End If
            mTrainer.Version = pTrainer.Version + 1

            Dim lngErgebnis As Long
            lngErgebnis = TrainerDAO.speichernTrainer(mTrainer)
            If lngErgebnis = mTrainer.BenutzerID Then
                mErgebnis = EPresenterErgebnis.SPEICHERN
                MsgBox("Ihre Änderungen werden erfolgreich gespeichert", vbOKOnly)
                mView.Close()
            Else
                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
            End If
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

End Class