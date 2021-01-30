Public Class SportartenEinzelView
    Inherits dlgSportEinzel
    Protected mPresenter As SportartenPresenter

    Sub New(pPresenter As SportartenPresenter)
        mPresenter = pPresenter
    End Sub

    Protected Property Presenter As SportartenPresenter
        Get
            Return mPresenter
        End Get
        Set(value As SportartenPresenter)
            mPresenter = value
        End Set
    End Property



    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim mbrResult As MsgBoxResult

        mbrResult = MsgBox("Möchten Sie wirklich abbrechen?", MsgBoxStyle.Question + vbYesNo, "Abbrechen")
        If mbrResult = vbNo Then
            DialogResult = Nothing
        Else
            mPresenter.verarbeiteAbbrechen()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim mSpor As Sportart = New Sportart
        mSpor.Name = Me.txtName.Text
        mSpor.Herkunftsland = Me.txtHerkunftsland.Text
        mSpor.Mindestalter = Me.txtMindestalter.Text
        mSpor.Zielgruppe = Me.rtxtZielgruppe.Text

        mPresenter.verarbeiteClose(mSpor)
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Dim mSpor As Sportart = New Sportart
        mSpor.Name = Me.txtName.Text
        mSpor.Herkunftsland = Me.txtHerkunftsland.Text
        mSpor.Mindestalter = Me.txtMindestalter.Text
        mSpor.Zielgruppe = Me.rtxtZielgruppe.Text

        mPresenter.verarbeiteSpeichern(mSpor)
    End Sub

    Public Sub anzeigenSportart(pSpor As Sportart)

        Me.txtName.Text = pSpor.Name
        Me.txtHerkunftsland.Text = pSpor.Herkunftsland
        Me.txtMindestalter.Text = pSpor.Mindestalter
        Me.rtxtZielgruppe.Text = pSpor.Zielgruppe

    End Sub


End Class