Public Class dlgMeinKontoTrainer
<<<<<<< HEAD

    Public mPresenter As TrainerkontoPresenter


=======

    Private mPresenter As TrainerkontoPresenter
>>>>>>> f03a5a805aab03b5a3e5436b79576b9b82a10023
    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Property Presenter As TrainerkontoPresenter
        Get
            Return Nothing
        End Get
        Set(value As TrainerkontoPresenter)
        End Set
    End Property

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        mPresenter.verarbeiteSpeichern()
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        mPresenter.verarbeiteAbbrechen()
    End Sub

    Private Sub txtTrainerID_TextChanged(sender As Object, e As EventArgs) Handles txtTrainerID.TextChanged

    End Sub

    Private Sub txtVorname_TextChanged(sender As Object, e As EventArgs) Handles txtVorname.TextChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtBenutzername_TextChanged(sender As Object, e As EventArgs) Handles txtBenutzername.TextChanged

    End Sub

    Private Sub txtPasswort_TextChanged(sender As Object, e As EventArgs) Handles txtPasswort.TextChanged

    End Sub
End Class