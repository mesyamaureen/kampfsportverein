Public Class dlgSportEinzel
    Public mPresenter As SportartenPresenter
    Public Property Presenter As SportartenPresenter
        Get
            Return mPresenter
        End Get
        Set(value As SportartenPresenter)
        End Set
    End Property
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblVersion.Click

    End Sub

    'Private Sub tabSportart_Click(sender As Object, e As EventArgs) Handles tabSportart.Click
    '    mPresenter.verarbeiteKursUebersichtAnzeigen()
    'End Sub
End Class