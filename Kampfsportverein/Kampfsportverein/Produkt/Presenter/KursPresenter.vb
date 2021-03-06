Public Class KursPresenter
    Private mView As KursView
    Public mErgebnis As EPresenterErgebnis
    Private mlstKurse As List(Of Kurs)
    Private mKurs As Kurs
    Private mmitDAO As MitarbeiterDAO
    Private mtraDAO As TrainerDAO

    Sub New(pKurs As Kurs)
        mKurs = pKurs
        mView = New KursView(Me)
        anzeigenAusgewaehlteKurs()
        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New KursView(Me)
        mKurs = New Kurs
        mView.ShowDialog()
    End Sub

    Public Property View As KursView
        Get
            Return mView
        End Get
        Set(value As KursView)
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property EinzelKurs As Kurs
        Get
            Return mKurs
        End Get
        Set(value As Kurs)
        End Set
    End Property

    Public Property MitDAO As MitarbeiterDAO
        Get
            Return mmitDAO
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property

    Public Property TraDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Property ListeKurse As List(Of Kurs)
        Get
            Return mlstKurse
        End Get
        Set(value As List(Of Kurs))
        End Set
    End Property

    Public Sub anzeigenAusgewaehlteKurs()
        mView.leeren()
        mView.anzeigenKurs()
        mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
        mtraDAO = DAOFactory.Instanz.TrainerDAO
        'Verbindung zwischen zugeordneter Sportart, zugeordnetem Trainer und Kurs
        mKurs.Sportart = mmitDAO.findeSportart(mKurs.SaIdFk)
        mKurs.Benutzer = mtraDAO.findenTrainerId(mKurs.BenIdFk)
        'Kurs Eigenschaften zur View Klasse zugewiesen
        mView.txtSportart.Text = mKurs.Sportart.Name
        mView.txtZeitpunkt.Text = mKurs.Zeitpunkt.ToString
        mView.txtOrt.Text = mKurs.Ort
        mView.txtTeilnZahl.Text = mKurs.Teilnehmerzahl.ToString
        mView.txtSchwierigkeit.Text = mKurs.Schwierigkeitsgrad
        mView.txtTrainer.Text = mKurs.Benutzer.Name
    End Sub
    Public Sub verarbeiteSpeichern()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
