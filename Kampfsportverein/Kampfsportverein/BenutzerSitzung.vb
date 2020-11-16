Public Class BenutzerSitzung
    'Attribut vom eigenen Typ des Singletons
    Private Shared mInstanz As BenutzerSitzung
    Private mAktuellerBenutzer As Benutzer

    'Privater Konstruktor des Singletons
    Private Sub New()
        mAktuellerBenutzer = Nothing
    End Sub

    'Implementierung eines Singletons
    Public Shared ReadOnly Property Instanz As BenutzerSitzung
        Get
            If IsNothing(mInstanz) Then
                mInstanz = New BenutzerSitzung
            End If
            Return mInstanz
        End Get
    End Property

    Public ReadOnly Property AktuellerBenutzer As Benutzer
        Get
            Return mAktuellerBenutzer
        End Get
    End Property

    Public Sub anzeigenAnmeldung()
        Dim presenter As AnmeldungPresenter = New AnmeldungPresenter()

        If presenter.Ergebnis = EPresenterErgebnis.ABBRECHEN Then
            beenden()
        ElseIf presenter.Ergebnis = EPresenterErgebnis.ANMELDEN Then
            mAktuellerBenutzer = presenter.AngemeldeterBenutzer
        End If
    End Sub

    Public Sub anzeigenKursUebersicht()

    End Sub

    Public Sub anzeigenUebersichtSportart()

    End Sub

    Public Sub start()
        anzeigenAnmeldung()
    End Sub

    Public Sub beenden()
        Application.Exit()
    End Sub

    Public Function istAnmeldungErfolgreich() As Boolean
        Dim bolErfolgreich As Boolean

        bolErfolgreich = Not (IsNothing(mAktuellerBenutzer))
        Return bolErfolgreich
    End Function

    Public Function istBenutzerMitarbeiter() As Boolean
    End Function
End Class
