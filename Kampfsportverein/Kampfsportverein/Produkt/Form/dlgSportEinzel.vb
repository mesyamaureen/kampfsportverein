Public Class dlgSportEinzel
    Inherits SportartenPresenter
    Protected mPresenter As SportartenPresenter
    Protected Property Presenter As SportartenPresenter
        Get
            Return mPresenter
        End Get
        Set(value As SportartenPresenter)
            mPresenter = value
        End Set
    End Property


    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Dim mbrResult As MsgBoxResult

        mbrResult = MsgBox("Möchten Sie wirklich abbrechen?", MsgBoxStyle.Question + vbYesNo, "Abbrechen")
        If mbrResult = vbNo Then
            DialogResult = Nothing
        Else
            mPresenter.verarbeiteAbbrechen()
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        mPresenter.verarbeiteOk()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

End Class