Public Class NeuerKursPresenter
    Private mView As NeuerKursView
    Private mErgebnis As EPresenterErgebnis
    Private mKurs As Kurs
    Private mmitDAO As MitarbeiterDAO
    Private mtraDAO As TrainerDAO

    Sub New() 'pKurs As Kurs)
        'mKurs = pKurs
        mKurs = Nothing
        mView = New NeuerKursView(Me)
        anzeigenNeuerKurs()
        mView.ShowDialog()
    End Sub

    Public Property View As NeuerKursView
        Get
            Return mView
        End Get
        Set(value As NeuerKursView)
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property Kurs As Kurs
        Get
            Return mKurs
        End Get
        Set(value As Kurs)
        End Set
    End Property

    Public Property mitDAO As MitarbeiterDAO
        Get
            Return mmitDAO
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property

    Public Property traDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Sub anzeigenNeuerKurs()
        mView.leeren()
        mView.anzeigenKurs()
        mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
        mtraDAO = DAOFactory.Instanz.TrainerDAO
    End Sub

    Public Sub ladenSaName()
        Dim i As Integer
        Dim strSaName As String
        'mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
        Dim lstSportart As List(Of Sportart) = mmitDAO.findenAlleSportarten
        For i = 0 To lstSportart.Count - 1
            strSaName = lstSportart.Item(i).Name
            mView.befuellenSaName(strSaName)
        Next
    End Sub

    Public Sub ladenTrainer()
        Dim i As Integer
        Dim strTrainer As String
        'mtraDAO = DAOFactory.Instanz.TrainerDAO
        Dim lstTrainer As List(Of Trainer) = mtraDAO.findeAlleTrainer
        For i = 0 To lstTrainer.Count - 1
            strTrainer = lstTrainer.Item(i).Name
            mView.befuellenTrainer(strTrainer)
        Next
    End Sub

    Public Sub verarbeiteErstellen()
        Dim strOrt As String
        Dim strSchwierigkeit As String
        Dim bytTeilnehmeranzahl As Byte
        Dim datKurs As Date
        Dim lngSaId As Long
        Dim lngTraId As Long
        Dim lstAlleSa As List(Of Sportart) = mmitDAO.findenAlleSportarten
        Dim lstAlleTrainer As List(Of Trainer) = mtraDAO.findeAlleTrainer
        Dim lngKursId As Long

        strOrt = mView.txtOrt.Text
        strSchwierigkeit = mView.txtSchwierigkeit.Text
        bytTeilnehmeranzahl = mView.txtTeilnZahl.Text
        datKurs = mView.datKurs.Value
        lngSaId = mmitDAO.findeSportart(lstAlleSa.Item(mView.cmbSportart.SelectedIndex).ID).ID
        lngTraId = mtraDAO.findenTrainerId(lstAlleTrainer.Item(mView.cmbTrainer.SelectedIndex).BenutzerID).BenutzerID

        If mKurs Is Nothing Then
            mKurs = New Kurs(datKurs, strOrt, bytTeilnehmeranzahl, strSchwierigkeit, lngSaId, lngTraId)
        Else
            'mKurs.BenIdFk = 0  ' Ändere!

            mKurs.Zeitpunkt = datKurs
            mKurs.Ort = strOrt
            mKurs.Teilnehmerzahl = bytTeilnehmeranzahl
            mKurs.Schwierigkeitsgrad = strSchwierigkeit
            mKurs.SaIdFk = lngSaId
            mKurs.BenIdFk = lngTraId
        End If
        lngKursId = MitarbeiterDAO.hinzufuegenKurs(mKurs)

        If lngKursId = -1 Then
            MsgBox("Der Kurs konnte nicht gespeichert werden, weil zwischenzeitlich eine Änderung an dem Kurs vorgenommen wurde. Prüfen Sie, ob Sie die geänderten Kurs noch immer erledigen möchten.", vbOKOnly + vbExclamation)
            mmitDAO.findeKurs(lngKursId)
            anzeigenNeuerKurs()
            mView.DialogResult = Nothing
        Else
            mErgebnis = EPresenterErgebnis.KURS_ERSTELLEN
            mView.Close()
        End If

        MitarbeiterDAO.hinzufuegenKurs(mKurs)
        mView.Close()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
