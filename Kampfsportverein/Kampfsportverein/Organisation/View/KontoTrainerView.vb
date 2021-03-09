Public Class KontoTrainerView
    Inherits dlgKontoTrainer

    Sub New(pPresenter As KontoTrainerPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigenTrainer() 'plngBenutzerID As Long, pstrVorname As String, pstrName As String, pstrBenutzername As String, pstrPasswort As String)
        Me.txtTrainerID.Enabled = False
        Me.txtVorname.Enabled = True
        Me.txtName.Enabled = True
        Me.txtBenutzername.Enabled = True
        Me.txtNeuesPasswort.Enabled = True

        'Me.txtTrainerID.Text = plngBenutzerID
        'Me.txtVorname.Text = pstrVorname
        'Me.txtName.Text = pstrName
        'Me.txtBenutzername.Text = pstrBenutzername
        'Me.txtPasswort.Text = pstrPasswort
    End Sub

    Public Sub leeren()
        Me.txtVorname.Text = String.Empty
        Me.txtName.Text = String.Empty
        Me.txtBenutzername.Text = String.Empty
        Me.txtNeuesPasswort.Text = String.Empty
    End Sub

End Class
