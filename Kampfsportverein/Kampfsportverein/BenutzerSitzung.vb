Public Class BenutzerSitzung
    Private mInstanz As BenutzerSitzung
    Private mAktuellerBenutzer As Integer

    Private Sub New()

    End Sub

    Public Shared Property Instanz As BenutzerSitzung
        Get
            Return Nothing
        End Get
        Set(value As BenutzerSitzung)
        End Set
    End Property

    Public Property AktuellerBenutzer As Benutzer
        Get
            Return Nothing
        End Get
        Set(value As Benutzer)
        End Set
    End Property

    Public Sub anzeigenAnmeldung()

    End Sub

    Public Sub anzeigenKursUebersicht()

    End Sub

    Public Sub anzeigenUebersichtSportart()

    End Sub

    Public Sub start()

    End Sub

    Public Sub beenden()

    End Sub

    Public Function istAnmeldungErfolgreich() As Boolean
    End Function

    Public Function istBenutzerMitarbeiter() As Boolean
    End Function
End Class
