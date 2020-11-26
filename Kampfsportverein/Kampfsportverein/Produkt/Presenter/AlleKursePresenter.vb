Public Class KursPresenter
    Private mView As KursView
    Private mErgebnis As Kurs
    Private mistKurseAlle As Kurs

    Sub New(kurs As Kurs)
        mView = New KursView(Me)
        mView.ShowDialog()
    End Sub

    Public Property View As KursView
        Get
            Return mView
        End Get
        Set(value As KursView)
        End Set
    End Property

    Public Property Ergebnis As Kurs
        Get
            Return Nothing
        End Get
        Set(value As Kurs)
        End Set
    End Property

    Public Property KurseAlle As Kurs
        Get
            Return Nothing
        End Get
        Set(value As Kurs)
        End Set
    End Property

    Public Sub anzeigenKurs()

    End Sub
    Public Sub verarbeiteOeffnen()

    End Sub

    Public Sub verarbeiteNeu()

    End Sub

    Public Sub verarbeiteLoeschen()

    End Sub

    Public Sub verarbeiteKursAbsagen()

    End Sub
    Public Sub beenden()
        mView.Close()
    End Sub
End Class
