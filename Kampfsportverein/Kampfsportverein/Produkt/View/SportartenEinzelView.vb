Public Class SportartenEinzelView
    Inherits dlgSportEinzel

    Sub New(pPresenter As SportartenPresenter)
        mPresenter = pPresenter
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim mSpor As Sportart = New Sportart
        mSpor.Name = Me.txtName.Text
        mSpor.Herkunftsland = Me.txtHerkunftsland.Text
        mSpor.Mindestalter = Me.txtMindestalter.Text
        mSpor.Zielgruppe = Me.rtxtZielgruppe.Text
        mSpor.Version = Me.txtVersion.Text

        mPresenter.verarbeiteAbbrechen(mSpor)
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim mSpor As Sportart = New Sportart
        Try
            mSpor.Name = Me.txtName.Text
            mSpor.Herkunftsland = Me.txtHerkunftsland.Text
            mSpor.Mindestalter = Me.txtMindestalter.Text
            mSpor.Zielgruppe = Me.rtxtZielgruppe.Text
            mSpor.Version = Me.txtVersion.Text
            Exit Try
        Catch
            MsgBox("Bitte Überprüfen Sie die Eingaben")
            Exit Sub
            Exit Try
        End Try
        mPresenter.verarbeiteSpeichern(mSpor)
    End Sub

    Public Sub anzeigenSportart(pSpor As Sportart)

        Me.txtName.Text = pSpor.Name
        Me.txtHerkunftsland.Text = pSpor.Herkunftsland
        Me.txtMindestalter.Text = pSpor.Mindestalter
        Me.rtxtZielgruppe.Text = pSpor.Zielgruppe
        Me.txtVersion.Text = pSpor.Version
    End Sub

    Public Sub anzeigenKursuebersicht()
        Me.lstKurse.Visible = True
    End Sub

    Public Sub hinzufuegenZeileKurs(plngKursID As Long, pdatZeitpunkt As Date, pstrOrt As String, pTrainer As String, pstrSchwierigkeitsgrad As String)
        Dim kursZeile As ListViewItem
        kursZeile = Me.lstKurse.Items.Add(plngKursID)
        With kursZeile.SubItems
            .Add(pdatZeitpunkt)
            .Add(pstrOrt)
            .Add(pTrainer)
            .Add(pstrSchwierigkeitsgrad)
        End With
    End Sub

    Public Sub leeren()
        Me.lstKurse.Items.Clear()
    End Sub

End Class