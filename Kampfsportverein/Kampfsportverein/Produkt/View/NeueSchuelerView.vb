Public Class NeueSchuelerView
    Inherits dlgNeueSchueler

    Sub New(pPresenter As NeueSchuelerPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigenNeueSchueler()
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtEmail.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtVorname.Clear()
        Me.txtName.Clear()
        Me.txtEmail.Clear()
    End Sub
End Class
