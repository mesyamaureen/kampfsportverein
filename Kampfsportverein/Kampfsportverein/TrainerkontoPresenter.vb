Public Class TrainerkontoPresenter
    Sub New()

    End Sub

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return Nothing
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Property TrainerEinzel As Trainer
        Get
            Return Nothing
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Public Property View As TrainerkontoView
        Get
            Return Nothing
        End Get
        Set(value As TrainerkontoView)
        End Set
    End Property
End Class
