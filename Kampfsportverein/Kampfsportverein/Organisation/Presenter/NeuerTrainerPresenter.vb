Public Class NeuerTrainerPresenter
    Private mNeuerTrainer As Trainer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As NeuerTrainerView
    Private mtraDAO As TrainerDAO

    Sub New(pTrainer As Trainer)
        mNeuerTrainer = Nothing
        mView = New NeuerTrainerView(Me)
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

    Public Property TrainerDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigen()
        mtraDAO = DAOFactory.Instanz.TrainerDAO
    End Sub

    Public Sub verarbeiteErstellen()
        Dim strVorname As String
        Dim strName As String
        Dim strBenutzername As String
        Dim strPass As String

        If String.IsNullOrEmpty(mView.txtVorname.Text) Or String.IsNullOrEmpty(mView.txtName.Text) Or
            String.IsNullOrEmpty(mView.txtBenutzername.Text) Or String.IsNullOrEmpty(mView.txtPass.Text) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            strVorname = mView.txtVorname.Text
            strName = mView.txtName.Text
            strBenutzername = mView.txtBenutzername.Text
            strPass = mView.txtPass.Text

            If mNeuerTrainer Is Nothing Then
                mNeuerTrainer = New Trainer(strBenutzername, strPass, strVorname, strName, 0, 0, "T")
            Else
                mNeuerTrainer.BenutzerID = 0
                mNeuerTrainer.Benutzername = strBenutzername
                mNeuerTrainer.Passwort = strPass
                mNeuerTrainer.Vorname = strVorname
                mNeuerTrainer.Name = strName
                mNeuerTrainer.Typ = "T"
            End If
            TrainerDAO.hinzufuegenTrainer(mNeuerTrainer)
            mErgebnis = EPresenterErgebnis.TRAINER_ERSTELLEN
            mView.Close()
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
