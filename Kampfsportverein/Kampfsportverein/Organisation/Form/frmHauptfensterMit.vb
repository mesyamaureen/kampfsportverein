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
        mPresenter.verarbeiteMitarbeiterEinzeln()
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
        mPresenter.verarbeiteNeu()
    End Sub

    Private Sub btnLoeschen_Click(sender As Object, e As EventArgs) Handles btnLoeschen.Click
        Dim lngSportartId As Long
        lngSportartId = Me.lstSportart.SelectedItems(0).Text
        mPresenter.verarbeiteLoeschen(lngSportartId)
    End Sub

    Private Sub btnOeffnen_Click(sender As Object, e As EventArgs) Handles btnOeffnen.Click

        Dim lngSportartId As Long
        lngSportartId = Me.lstSportart.SelectedItems(0).Text
        mPresenter.verarbeiteSportartÖffnen(lngSportartId)
    End Sub

    Private Sub btnBeenden_Click(sender As Object, e As EventArgs) Handles btnBeenden.Click
        mPresenter.verarbeiteBeenden()
    End Sub

    Private Sub lstSportart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSportart.SelectedIndexChanged
        geaenderteAuswahl()
    End Sub

    Private Sub geaenderteAuswahl()
        ' Registerkarte Offene Aufgaben
        If Me.lstSportart.SelectedItems.Count > 0 Then
            Me.btnBeenden.Enabled = True
            Me.btnNeu.Enabled = True
            Me.btnOeffnen.Enabled = True
            Me.btnLoeschen.Enabled = True
        Else
            Me.btnBeenden.Enabled = True
            Me.btnNeu.Enabled = True
            Me.btnOeffnen.Enabled = False
            Me.btnLoeschen.Enabled = False
        End If

    End Sub


End Class