Public Class frmHauptfensterMit

    Public mPresenter As MitarbeiterAllePresenter

    Public Property Presenter As MitarbeiterAllePresenter
        Get
            Return Nothing
        End Get
        Set(value As MitarbeiterAllePresenter)
        End Set
    End Property

    Private Sub btnMeinKonto_Click(sender As Object, e As EventArgs) Handles btnMeinKonto.Click
        mPresenter.verarbeiteMitarbeiterEinzeln() 'angemeldeter Benutzer
    End Sub

    Private Sub btnSportarten_Click(sender As Object, e As EventArgs) Handles btnSportarten.Click
        mPresenter.verarbeiteSportartUebersichtAnzeigen()
    End Sub

    Private Sub btnKurs_Click(sender As Object, e As EventArgs) Handles btnKurs.Click
        mPresenter.verarbeiteKursuebersichtAnzeigen()
    End Sub

    Private Sub btnSchueler_Click(sender As Object, e As EventArgs) Handles btnSchueler.Click
        mPresenter.verarbeiteSchueleruebersichtAnzeigen()
    End Sub

    Private Sub btnTrainer_Click(sender As Object, e As EventArgs) Handles btnTrainer.Click
        mPresenter.verarbeiteTrainerUebersichtAnzeigen()
    End Sub

    Private Sub btnNeu_Click(sender As Object, e As EventArgs) Handles btnNeu.Click
        If Me.lstSportart.Visible = True Then
            mPresenter.verarbeiteNeu()
        ElseIf Me.lstKurseAlle.Visible = True Then
            mPresenter.verarbeiteNeuerKurs()
        ElseIf Me.lstTrainer.Visible = True Then
            mPresenter.verarbeiteNeuTrainer()
        End If
    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        Dim lngSportartId As Long
        Dim lngKursId As Long
        Dim lngSchuelerId As Long
        Dim lngTrainerId As Long

        If Me.lstSportart.SelectedItems.Count > 0 Then
            lngSportartId = Me.lstSportart.SelectedItems(0).Text
            mPresenter.verarbeiteLoeschen(lngSportartId)
        ElseIf Me.lstKurseAlle.SelectedItems.Count > 0 Then
            lngKursId = Me.lstKurseAlle.SelectedItems(0).Text
            mPresenter.verarbeiteLoeschenKurs(lngKursId)
        ElseIf Me.lstSchuelerAlle.SelectedItems.Count > 0 Then
            lngSchuelerId = Me.lstSchuelerAlle.SelectedItems(0).Text
            mPresenter.verarbeiteLoeschenSchueler(lngSchuelerId)
        ElseIf Me.lstTrainer.SelectedItems.Count > 0 Then
            lngTrainerId = Me.lstTrainer.SelectedItems(0).Text
            mPresenter.verarbeiteLoeschenTrainer(lngTrainerId)
        End If
    End Sub

    Private Sub btnOeffnen_Click(sender As Object, e As EventArgs) Handles btnOeffnen.Click
        Dim lngSportartId As Long
        Dim lngKursId As Long
        Dim lngSchuelerId As Long
        Dim lngTrainer As Long

        If Me.lstSportart.SelectedItems.Count > 0 Then
            lngSportartId = Me.lstSportart.SelectedItems(0).Text
            mPresenter.verarbeiteSportartOeffnen(lngSportartId)
        ElseIf Me.lstKurseAlle.SelectedItems.Count > 0 Then
            lngKursId = Me.lstKurseAlle.SelectedItems(0).Text
            mPresenter.verarbeiteKursOeffnen(lngKursId)
        ElseIf Me.lstSchuelerAlle.SelectedItems.Count > 0 Then
            lngSchuelerId = Me.lstSchuelerAlle.SelectedItems(0).Text
            mPresenter.verarbeiteSchuelerOeffnen(lngSchuelerId)
        ElseIf Me.lstTrainer.SelectedItems.Count > 0 Then
            lngTrainer = Me.lstTrainer.SelectedItems(0).Text
            mPresenter.verarbeiteTrainerOeffnen(lngTrainer)
        End If

    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        mPresenter.verarbeiteBeenden()
    End Sub

    Private Sub lstSportart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSportart.SelectedIndexChanged
        geaenderteAuswahl()
    End Sub

    Private Sub lstTrainer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTrainer.SelectedIndexChanged
        If Me.lstTrainer.SelectedItems.Count = 0 Then
            Me.btnNeu.Enabled = True
            Me.btnLoeschen.Enabled = False
            Me.btnOeffnen.Enabled = False
        ElseIf Me.lstTrainer.SelectedItems.Count = 1 Then
            Me.btnNeu.Enabled = False
            Me.btnLoeschen.Enabled = True
            Me.btnOeffnen.Enabled = True
        End If
    End Sub

    Private Sub lstSchuelerAlle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSchuelerAlle.SelectedIndexChanged
        If Me.lstSchuelerAlle.SelectedItems.Count = 0 Then
            Me.btnLoeschen.Enabled = False
            Me.btnOeffnen.Enabled = False
        ElseIf Me.lstSchuelerAlle.SelectedItems.Count = 1 Then
            Me.btnLoeschen.Enabled = True
            Me.btnOeffnen.Enabled = True
        End If
    End Sub

    Private Sub lstKurseAlle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKurseAlle.SelectedIndexChanged
        If Me.lstKurseAlle.SelectedItems.Count = 0 Then
            Me.btnNeu.Enabled = True
            Me.btnLoeschen.Enabled = False
            Me.btnOeffnen.Enabled = False
        ElseIf Me.lstKurseAlle.SelectedItems.Count = 1 Then
            Me.btnNeu.Enabled = False
            Me.btnLoeschen.Enabled = True
            Me.btnOeffnen.Enabled = True
        End If
    End Sub

    Private Sub geaenderteAuswahl()
        ' Registerkarte Offene Aufgaben
        If Me.lstSportart.SelectedItems.Count > 0 Then
            Me.btnBeenden.Enabled = True
            Me.btnNeu.Enabled = False
            Me.btnOeffnen.Enabled = True
            Me.btnLoeschen.Enabled = True
        Else
            Me.btnBeenden.Enabled = True
            Me.btnNeu.Enabled = True
            Me.btnOeffnen.Enabled = False
            Me.btnLoeschen.Enabled = False
        End If

    End Sub

    Private Sub btnNeuerMitarbeiter_Click(sender As Object, e As EventArgs) Handles btnNeuerMitarbeiter.Click
        mPresenter.verarbeiteNeuerMitarbeiter()
    End Sub

    Private Sub frmHauptfensterMit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim mbrResult As MsgBoxResult
        mbrResult = MsgBox("Wirklich Beenden?", MsgBoxStyle.Question + vbYesNo, "Beenden")
        If mbrResult = vbNo Then
            Me.DialogResult = DialogResult.None
            e.Cancel = True
        End If
    End Sub


End Class