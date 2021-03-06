Public Class dlgKursEinzeln
    Protected mPresenter As KursPresenter

    Public Property Presenter As KursPresenter
        Get
            Return mPresenter
        End Get
        Set(value As KursPresenter)
            mPresenter = value
        End Set
    End Property

End Class