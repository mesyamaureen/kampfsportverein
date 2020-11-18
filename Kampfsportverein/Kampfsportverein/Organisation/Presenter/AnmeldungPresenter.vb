Public Class AnmeldungPresenter
    Private mErgebnis As EPresenterErgebnis
    Private mView As AnmeldungView
    Private mAngemeldeterBenutzer As Benutzer

    Public Sub New()
        mView = New AnmeldungView(Me)
        'mErgebnis = EPresenterErgebnis.OHNE
        mAngemeldeterBenutzer = Nothing

        Application.Run(mView)
    End Sub

    Private ReadOnly Property View As AnmeldungView
        Get
            Return mView
        End Get
    End Property

    Public ReadOnly Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
    End Property

    Public ReadOnly Property AngemeldeterBenutzer As Benutzer
        Get
            Return mAngemeldeterBenutzer
        End Get
    End Property

    Private Function anmelden(pstrBenutzername As String, pstrPasswort As String) As Benutzer
        Return Kampfsportverein.mlstTrainer.Item(1)
    End Function

    Public Sub verarbeitenAbbrechen()
        mErgebnis = EPresenterErgebnis.ABBRECHEN
        mView.Close()
    End Sub

    Public Sub verarbeitenAnmelden(pstrBenutzername As String, pstrPasswort As String)
        mAngemeldeterBenutzer = anmelden(pstrBenutzername, pstrPasswort)
        If mAngemeldeterBenutzer Is Nothing Then
            mView.anzeigenAnmeldeFehler()
            mView.leeren()
        Else
            mErgebnis = EPresenterErgebnis.ANMELDEN
            mView.Close()
        End If
    End Sub
End Class
