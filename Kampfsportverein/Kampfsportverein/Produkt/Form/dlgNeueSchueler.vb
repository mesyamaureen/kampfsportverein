Public Class dlgNeueSchueler
    Public mPresenter As NeueSchuelerPresenter

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Property Presenter As NeueSchuelerPresenter
        Get
            Return Nothing
        End Get
        Set(value As NeueSchuelerPresenter)
        End Set
    End Property
End Class