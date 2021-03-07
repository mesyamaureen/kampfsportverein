Public Class MitarbeiterKontoView
    Inherits dlgMeinKontoMit

    Private mView As MitarbeiterKontoView

    Sub New(pPresenter As MitarbeiterKontoPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Property IstMitarbeiter As MitarbeiterKontoView
        Get
            Return mView
        End Get
        Set(value As MitarbeiterKontoView)
        End Set
    End Property

    Public Sub anzeigenKonto() 'plngBenutzerId As Long, pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String)
        Me.txtMitarbeiterID.Enabled = False
        Me.txtVorname.Enabled = False
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = True
        Me.txtAltPass.Enabled = True
        Me.txtNeuesPasswort.Enabled = True


        'Me.txtMitarbeiterID.Text = plngBenutzerId
        'Me.txtVorname.Text = pstrVorname
        'Me.txtName.Text = pstrName
        'Me.txtBenutzername.Text = pstrBenutzername
        'Me.txtPassWiederh.Text = pstrPasswort
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtAltPass.Text = String.Empty
        Me.txtNeuesPasswort.Text = String.Empty
    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click

        Dim mMit As Mitarbeiter = New Mitarbeiter
        Dim mNeuesPw As String = Me.txtNeuesPasswort.Text
        Try
            mMit.Nachname = Me.txtName.Text
            mMit.Passwort = Me.txtAltPass.Text

            Exit Try
        Catch
            MsgBox("Bitte Überprüfen Sie die Eingaben")
            Exit Sub
            Exit Try
        End Try
        mPresenter.verarbeiteSpeichern(mMit, mNeuesPw)


    End Sub

End Class
