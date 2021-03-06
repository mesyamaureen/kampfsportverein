Public Class SchuelerAllePresenter
    Public mErgebnis As EPresenterErgebnis
    Private mView As AlleSchuelerView
    Private mSchueler As Schueler
    Private mtraDAO As TrainerDAO

    Sub New(pSchueler As Schueler)
        mSchueler = pSchueler
        mView = New AlleSchuelerView(Me)
        anzeigenAusgewaehlteSchueler()
        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New AlleSchuelerView(Me)
        mSchueler = New Schueler
        mView.ShowDialog()
    End Sub

    Public Property View As AlleSchuelerView
        Get
            Return mView
        End Get
        Set(value As AlleSchuelerView)
        End Set
    End Property

    Public Property EinzelSchueler As Schueler
        Get
            Return mSchueler
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

    Public Property TraDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Sub anzeigenAusgewaehlteSchueler()
        mView.leeren()
        mView.anzeigenSchueler()
        mtraDAO = DAOFactory.Instanz.TrainerDAO
        mView.txtSchuelerID.Text = mSchueler.SchuelerIdPk
        mView.txtVorname.Text = mSchueler.Vorname
        mView.txtName.Text = mSchueler.Name
        mView.txtEmail.Text = mSchueler.EMailAdresse
    End Sub
    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub

End Class
