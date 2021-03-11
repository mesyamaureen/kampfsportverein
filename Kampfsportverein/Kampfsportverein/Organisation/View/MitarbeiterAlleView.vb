Public Class MitarbeiterAlleView
    Inherits frmHauptfensterMit

    Private mbolMitarbeiter As Boolean

    Sub New(pPresenter As MitarbeiterAllePresenter)

        MyBase.New
        mPresenter = pPresenter

    End Sub

    Public Sub anzeigenSportartenuebersicht()
        Me.lstSportart.Visible = True
        Me.lstKurseAlle.Visible = False
        Me.lstSchuelerAlle.Visible = False
        Me.lstTrainer.Visible = False
        Me.btnNeu.Enabled = True
        Me.btnLoeschen.Enabled = False
        Me.btnOeffnen.Enabled = False
        Me.btnBeenden.Enabled = True
    End Sub

    Public Sub anzeigenKursuebersicht()
        Me.lstSportart.Visible = False
        Me.lstKurseAlle.Visible = True
        Me.lstSchuelerAlle.Visible = False
        Me.lstTrainer.Visible = False
        Me.btnNeu.Enabled = True
        Me.btnLoeschen.Enabled = False
        Me.btnOeffnen.Enabled = False
        Me.btnBeenden.Enabled = True
    End Sub

    Public Sub anzeigenSchueleruebersicht()
        Me.lstSportart.Visible = False
        Me.lstKurseAlle.Visible = False
        Me.lstSchuelerAlle.Visible = True
        Me.lstTrainer.Visible = False
        Me.btnNeu.Enabled = False
        Me.btnLoeschen.Enabled = False
        Me.btnOeffnen.Enabled = False
        Me.btnBeenden.Enabled = True
    End Sub

    Public Sub anzeigenTraineruebersicht()
        Me.lstSportart.Visible = False
        Me.lstKurseAlle.Visible = False
        Me.lstSchuelerAlle.Visible = False
        Me.lstTrainer.Visible = True
        Me.btnNeu.Enabled = True
        Me.btnLoeschen.Enabled = False
        Me.btnOeffnen.Enabled = False
        Me.btnBeenden.Enabled = True
    End Sub

    Public Sub hinzufuegenZeileSportart(plngSportartID As Long,
                                        pSportart As String)
        Dim sportZeile As ListViewItem
        sportZeile = Me.lstSportart.Items.Add(plngSportartID)
        With sportZeile.SubItems
            .Add(pSportart)
        End With
    End Sub

    Public Sub hinzufuegenZeileKurse(plngKursIdPk As Long, pdatKursZeitpunkt As Date,
                                     plngSaIdFk As Long, plngBenIdFk As Long)
        Dim kursZeile As ListViewItem
        kursZeile = Me.lstKurseAlle.Items.Add(plngKursIdPk)
        With kursZeile.SubItems
            .Add(pdatKursZeitpunkt)
            .Add(plngSaIdFk)
            .Add(plngBenIdFk)
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
                                       pstrNameTrainer As String,
                                       pstrVornameTrainer As String)
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
End Class
