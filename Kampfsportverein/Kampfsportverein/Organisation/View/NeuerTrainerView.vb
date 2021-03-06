Public Class NeuerTrainerView
    Inherits dlgNeuerTrainer

    Sub New(pPresenter As NeuerTrainerPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigen() 'pstrVorname As String, pstrName As String, pstrBenutzername As String, pstrPasswort As String)
        Me.txtVorname.Text = Enabled
        Me.txtName.Text = Enabled
        Me.txtBenutzername.Text = Enabled
        Me.txtPass.Text = Enabled

        'Me.txtVorname.Text = pstrVorname
        'Me.txtName.Text = pstrName
        'Me.txtBenutzername.Text = pstrBenutzername
        'Me.txtPass.Text = pstrPasswort
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtPass.Text = String.Empty
    End Sub

End Class
