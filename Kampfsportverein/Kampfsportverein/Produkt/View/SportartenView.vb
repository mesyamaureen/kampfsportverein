Public Class SportartenView
    Inherits dlgSportEinzel
    Protected mPresenter As SportartenPresenter

    Sub New(pPresenter As SportartenPresenter)
        mPresenter = pPresenter
    End Sub

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




    Public Property IstSportart As SportartenView
        Get
            Return Nothing
        End Get
        Set(value As SportartenView)
        End Set
    End Property

    Public Sub anzeigenName()

    End Sub

    Public Sub anzeigenHerkunftsland()

    End Sub

    Public Sub anzeigenZielgruppe()

    End Sub

    Public Sub anzeigenMindestalter()

    End Sub
End Class
