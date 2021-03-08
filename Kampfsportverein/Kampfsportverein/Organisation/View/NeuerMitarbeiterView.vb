Public Class NeuerMitarbeiterView
    Inherits dlgNeuerMitarbeiter

    Sub New(pPresenter As NeuerMitarbeiterPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigen()
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = True
        Me.txtPasswort.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtVorname.Clear()
        Me.txtName.Clear()
        Me.txtBenutzername.Clear()
        Me.txtPasswort.Clear()
    End Sub
End Class
