Public Class TrainerAlleView
    Inherits frmHauptfensterTrainer

    Private mbolTrainer As Boolean



    Public Property IstTrainer As TrainerAlleView
        Get
            Return Nothing
        End Get
        Set(value As TrainerAlleView)
        End Set
    End Property

    Public Sub anzeigenMeinKonto()

    End Sub

    Public Sub anzeigenKursuebersicht()

    End Sub

    Public Sub anzeigenSchueleruebersicht()

    End Sub

    Public Sub anzeigenNeueAnmeldung()

    End Sub

    Public Sub anzeigenBearbeiten()

    End Sub

    Public Sub anzeigenBeenden()

    End Sub

    Public Sub anzeigen(plngIndex As Long, pintBenutzerID As Integer, pstrVorname As String, pstrName As String, pstrBenutzername As String, pstrPasswort As String)

        Dim zeile As ListViewItem

    End Sub

End Class
