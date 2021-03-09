Public Class MitarbeiterKontoView
    Inherits dlgMeinKontoMit

    Sub New(pPresenter As MitarbeiterKontoPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigenKonto()
        Me.txtMitarbeiterID.Enabled = False
        Me.txtVorname.Enabled = False
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = True
        Me.txtNeuesPass.Enabled = True
        Me.btnSpeichern.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtNeuesPass.Text = String.Empty
    End Sub

End Class
