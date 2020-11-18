Public Class dlgMeinKontoTrainer
    Public mPresenter As TrainerkontoPresenter

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
End Class