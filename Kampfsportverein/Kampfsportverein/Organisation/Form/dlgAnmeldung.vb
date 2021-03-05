Public Class dlgAnmeldung
    Protected mPresenter As AnmeldungPresenter

    Public Property Presenter As AnmeldungPresenter
        Get
            Return Nothing
        End Get
        Set(value As AnmeldungPresenter)
            mPresenter = value
        End Set
    End Property

    Private Sub btnAnmelden_Click(sender As Object, e As EventArgs) Handles btnAnmelden.Click
        Dim strBenutzername As String
        Dim strPasswort As String
        strBenutzername = Trim(Me.txtBenutzername.Text)
        strPasswort = Me.txtPasswort.Text
        mPresenter.verarbeitenAnmelden(strBenutzername, strPasswort)
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeitenAbbrechen()
    End Sub

End Class