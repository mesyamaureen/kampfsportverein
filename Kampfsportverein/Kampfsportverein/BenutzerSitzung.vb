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

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return Nothing
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub start()
        anzeigenAnmeldung()
    End Sub

    Public Sub beenden()
        Application.Exit()
    End Sub

    Public Sub anzeigenAnmeldung()
        Dim presenter As AnmeldungPresenter = New AnmeldungPresenter()

        If presenter.Ergebnis = EPresenterErgebnis.ABBRECHEN Then
            beenden()
        ElseIf presenter.Ergebnis = EPresenterErgebnis.ANMELDEN Then
            mAktuellerBenutzer = presenter.AngemeldeterBenutzer

            If Not (istAnmeldungErfolgreich()) Then
                beenden()
            End If

            If istBenutzerMitarbeiter() Then
                anzeigenSportarten()
            ElseIf istBenutzerTrainer() Then
                anzeigenKursuebersicht()
            Else
                MsgBox("Fehlerhafter Sitzungszustand. Die Anwendung muss beendet werden.",
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Fehler in der Sitzung")
            End If
        End If
    End Sub

    Public Sub anzeigenKursuebersicht()
        Dim presenter As TrainerAllePresenter
        presenter = New TrainerAllePresenter()

        Select Case presenter.Ergebnis
            Case EPresenterErgebnis.BEENDEN
                beenden()
                'Case EPresenterErgebnis.EIGENEKURSE_ANZEIGEN
                'presenter.verarbeiteKursuebersichtAnzeigen(i)
            Case EPresenterErgebnis.EIGENESPROFIL_ANZEIGEN
                presenter.verarbeiteEigenesProfilAnzeigen()
            Case EPresenterErgebnis.MITGLIEDER_ANZEIGEN
                presenter.verarbeiteSchueleruebersichtAnzeigen()
            Case Else
                MsgBox("Fehlerhafter Sitzungszustand. Die Anwendung muss beendet werden.",
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Fehler in der Sitzung")
        End Select
    End Sub

    Public Sub anzeigenSportarten()
        Dim presenter As MitarbeiterAllePresenter
        presenter = New MitarbeiterAllePresenter()

        Select Case presenter.Ergebnis
            Case EPresenterErgebnis.BEENDEN
                beenden()
            Case EPresenterErgebnis.SPORTART_ANZEIGEN
                presenter.verarbeiteSportartuebersichtAnzeigen()
            Case EPresenterErgebnis.MITGLIEDER_ANZEIGEN
                presenter.verarbeiteSchueleruebersichtAnzeigen()
            Case EPresenterErgebnis.TRAINER_ANZEIGEN
                presenter.verarbeiteTrainerUebersichtAnzeigen()
            Case EPresenterErgebnis.TRAINER_ERSTELLEN
                presenter.verarbeiteTrainerHinzufuegen()
            Case Else
                MsgBox("Fehlerhafter Sitzungszustand. Die Anwendung muss beendet werden.",
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Fehler in der Sitzung")
        End Select
    End Sub

    Public Function istAnmeldungErfolgreich() As Boolean
        Dim bolErfolgreich As Boolean

        bolErfolgreich = Not (IsNothing(mAktuellerBenutzer))
        Return bolErfolgreich
    End Function

    Public Function istBenutzerMitarbeiter() As Boolean
        Dim t As Type
        If mAktuellerBenutzer Is Nothing Then
            Return False
        End If
        t = mAktuellerBenutzer.GetType()
        Return (t.Equals(GetType(Mitarbeiter)))
    End Function

    Public Function istBenutzerTrainer() As Boolean
        Dim t As Type
        If mAktuellerBenutzer Is Nothing Then
            Return False
        End If
        t = mAktuellerBenutzer.GetType()
        Return (t.Equals(GetType(Trainer)))
    End Function
End Class
