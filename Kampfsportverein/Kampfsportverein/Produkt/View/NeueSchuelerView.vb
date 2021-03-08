Public Class NeueSchuelerView
    Inherits dlgNeueSchueler

    Sub New(pPresenter As NeueSchuelerPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigenSchueler()
        Me.txtName.Enabled = True
        Me.txtVorname.Enabled = True
        Me.txtEmail.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtName.Clear()
        Me.txtVorname.Clear()
        Me.txtEmail.Clear()
    End Sub

End Class
