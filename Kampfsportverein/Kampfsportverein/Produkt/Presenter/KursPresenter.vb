Public Class KursPresenter
    Private mView As KursView
    Public mErgebnis As EPresenterErgebnis
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
    Public Sub verarbeiteSpeichern(pKurs As Kurs)
        If String.IsNullOrEmpty(mView.txtZeitpunkt.Text) Or String.IsNullOrEmpty(mView.txtOrt.Text) Or String.IsNullOrEmpty(mView.txtTeilnZahl.Text) Or String.IsNullOrEmpty(mView.txtSchwierigkeit.Text) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            mKurs.Zeitpunkt = mView.txtZeitpunkt.Text
            mKurs.Ort = mView.txtOrt.Text
            mKurs.Teilnehmerzahl = mView.txtTeilnZahl.Text
            mKurs.Schwierigkeitsgrad = mView.txtSchwierigkeit.Text
            mKurs.Version = pKurs.Version + 1

            Dim lngErgebnis As Long
            lngErgebnis = MitarbeiterDAO.speichernKurs(mKurs)
            If lngErgebnis = mKurs.IdPk Then
                mErgebnis = EPresenterErgebnis.SPEICHERN
                MsgBox("Ihre Änderungen werden erfolgreich gespeichert", vbOKOnly)
                mView.Close()
            Else
                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
            End If
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        mErgebnis = EPresenterErgebnis.ABBRECHEN
        mView.Close()
    End Sub
End Class
