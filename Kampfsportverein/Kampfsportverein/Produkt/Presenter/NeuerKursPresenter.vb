Public Class NeuerKursPresenter
    Private mView As NeuerKursView
    Private mErgebnis As EPresenterErgebnis
    Private mKurs As Kurs
    Private mmitDAO As MitarbeiterDAO
    Private mtraDAO As TrainerDAO

    Sub New(pKurs As Kurs)
        mKurs = pKurs
        mView = New NeuerKursView(Me)
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

    Public Sub verarbeiteErstellen()

    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
