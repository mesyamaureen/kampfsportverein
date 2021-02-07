Public Class MitarbeiterKontoView
    Inherits dlgMeinKontoMit

    Sub New(pPresenter As MitarbeiterKontoPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtNeuesPass.Text = String.Empty
        Me.txtPassWiederh.Text = String.Empty
    End Sub

    Public Sub anzeigen(plngBenutzerId As Long, pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String)
        Me.txtMitarbeiterID.Enabled = False
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = True
        Me.txtNeuesPass.Enabled = True
        Me.txtPassWiederh.Enabled = True

        Me.txtMitarbeiterID.Text = plngBenutzerId
        Me.txtVorname.Text = pstrVorname
        Me.txtName.Text = pstrName
        Me.txtBenutzername.Text = pstrBenutzername
        Me.txtPassWiederh.Text = pstrPasswort
    End Sub

End Class
