Public Class KursView
    Inherits dlgKursEinzeln

    Private mbolAktiv As Boolean
    Protected Shared mPresenter As KursPresenter
    'Konstruktor
    Sub New(pPresenter As KursPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub
    'Eigenschaften
    Public Property IstKurs As KursView
        Get
            Return Nothing
        End Get
        Set(value As KursView)
        End Set
    End Property
    'Methoden
    Public Sub anzeigenOrt()

    End Sub

    Public Sub anzeigenSchwierigkeitsgrad()

    End Sub

    Public Sub anzeigenName()

    End Sub

    Public Sub anzeigenTeilnehmerzahl()

    End Sub

    Public Sub anzeigenTrainer()

    End Sub

    Public Sub anzeigenZeitpunkt()

    End Sub

    Public Sub anzeigenAktivInaktiv()

    End Sub
End Class
