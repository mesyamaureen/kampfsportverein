Public Class TrainerkontoView
    Inherits dlgMeinKontoTrainer

    Sub New(pPresenter As TrainerkontoPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtPasswort.Text = String.Empty
    End Sub

    Public Sub anzeigen(pintBenutzerID As Integer, pstrVorname As String, pstrName As String, pstrBenutzername As String, pstrPasswort As String)
        Me.txtTrainerID.Enabled = False
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = False
        Me.txtPasswort.Enabled = True

        Me.txtTrainerID.Text = pintBenutzerID
        Me.txtVorname.Text = pstrVorname
        Me.txtName.Text = pstrName
        Me.txtBenutzername.Text = pstrBenutzername
        Me.txtPasswort.Text = pstrPasswort
    End Sub

End Class
