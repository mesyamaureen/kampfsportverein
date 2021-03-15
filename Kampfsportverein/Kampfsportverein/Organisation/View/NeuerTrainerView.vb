Public Class NeuerTrainerView
    Inherits dlgNeuerTrainer

    Sub New(pPresenter As NeuerTrainerPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigen()
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = True
        Me.txtPass.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtPass.Text = String.Empty
    End Sub

End Class
