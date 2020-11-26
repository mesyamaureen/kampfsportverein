Public Class MitarbeiterAlleView
    Inherits frmHauptfensterMit

    Private mbolMitarbeiter As Boolean

    Sub New(pPresenter As MitarbeiterAllePresenter)

        MyBase.New
        mPresenter = pPresenter

    End Sub

    Public Property IstMitarbeiter As MitarbeiterAlleView
        Get
            Return Nothing
        End Get
        Set(value As MitarbeiterAlleView)
        End Set
    End Property

    Public Sub anzeigenSportartenuebersicht()
        Me.lstSportart.Visible = True
        Me.lstKurseAlle.Visible = False
        Me.lstSchuelerAlle.Visible = False
        Me.lstTrainer.Visible = False
    End Sub

    Public Sub anzeigenKursuebersicht()
        Me.lstSportart.Visible = False
        Me.lstKurseAlle.Visible = True
        Me.lstSchuelerAlle.Visible = False
        Me.lstTrainer.Visible = False
    End Sub

    Public Sub anzeigenSchueleruebersicht()
        Me.lstSportart.Visible = False
        Me.lstKurseAlle.Visible = False
        Me.lstSchuelerAlle.Visible = True
        Me.lstTrainer.Visible = False
    End Sub

    Public Sub anzeigenTraineruebersicht()
        Me.lstSportart.Visible = False
        Me.lstKurseAlle.Visible = False
        Me.lstSchuelerAlle.Visible = False
        Me.lstTrainer.Visible = True
    End Sub

    'Public Sub anzeigenMitarbeiteruebersicht()

    'End Sub

    Public Sub anzeigenMeinKonto()
        Me.Close()
    End Sub

    Public Sub hinzufuegenZeileSportart(plngSportartID As Long, pSportart As String)
        Dim sportZeile As ListViewItem
        sportZeile = Me.lstSportart.Items.Add(plngSportartID)
        With sportZeile.SubItems
            .Add(pSportart)
        End With
    End Sub

    Public Sub hinzufuegenZeileKurse(plngKursID As Long, pdatKurs As Date,
                                     pSportartKurs As Sportart, pbolVerfuegbarkeit As Boolean)
        Dim kursZeile As ListViewItem
        kursZeile = Me.lstKurseAlle.Items.Add(plngKursID)
        With kursZeile.SubItems
            .Add(pdatKurs)
            .Add(pSportartKurs.Name)
            .Add(pbolVerfuegbarkeit)
        End With
    End Sub
    Public Sub hinzufuegenZeileSchueler(plngSchuelerID As Long,
                                        pstrNameSchueler As String,
                                        pstrVornameSchueler As String)
        Dim schuelerZeile As ListViewItem
        schuelerZeile = Me.lstSchuelerAlle.Items.Add(plngSchuelerID)
        With schuelerZeile.SubItems
            .Add(pstrNameSchueler)
            .Add(pstrVornameSchueler)
        End With
    End Sub
    Public Sub hinzufuegenZeileTrainer(plngTrainerID As Long,
                                       pstrNameTrainer As String, pstrVornameTrainer As String)
        Dim trainerZeile As ListViewItem
        trainerZeile = Me.lstTrainer.Items.Add(plngTrainerID)
        With trainerZeile.SubItems
            .Add(pstrNameTrainer)
            .Add(pstrVornameTrainer)
        End With
    End Sub
    Public Sub leeren()
        Me.lstSportart.Items.Clear()
        Me.lstKurseAlle.Items.Clear()
        Me.lstSchuelerAlle.Items.Clear()
        Me.lstTrainer.Items.Clear()
    End Sub

    Public Sub anzeigenNeueAnmeldung()

    End Sub

    Public Sub anzeigenNeuerKurs()

    End Sub

    Public Sub anzeigenBearbeiten()

    End Sub

    Public Sub anzeigenBeenden()

    End Sub

    Public Sub anzeigenSchaltflächen()

    End Sub

End Class
