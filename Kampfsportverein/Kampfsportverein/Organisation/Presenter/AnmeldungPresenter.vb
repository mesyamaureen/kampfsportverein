Public Class AnmeldungPresenter
    Private mErgebnis As EPresenterErgebnis
    Private mView As AnmeldungView
    Private mAngemeldeterBenutzer As Benutzer

    Public Sub New()
        mView = New AnmeldungView(Me)
        mAngemeldeterBenutzer = Nothing

        Application.Run(mView)
    End Sub

    Public Property View As AnmeldungView
        Get
            Return mView
        End Get
        Set(value As AnmeldungView)
            mView = value
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
            mErgebnis = value
        End Set
    End Property

    Public Property AngemeldeterBenutzer As Benutzer
        Get
            Return mAngemeldeterBenutzer
        End Get
        Set(value As Benutzer)
            mAngemeldeterBenutzer = value
        End Set
    End Property


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

    Private Function anmelden(pstrBenutzername As String, pstrPasswort As String) As Benutzer
        'Deklaration
        Dim ben As Benutzer 'Benutzer
        Dim mitDAO As MitarbeiterDAO 'MitarbeiterDAO
        Dim traDAO As TrainerDAO 'TrainerDAO

        'Initialisieren des BenutzerDAO über die DAOFactory
        mitDAO = DAOFactory.Instanz.MitarbeiterDAO
        traDAO = DAOFactory.Instanz.TrainerDAO

        'Nutzen des DAOs, um den angemeldeten Benutzer zu finden anhand 
        'Benutzername und Passwort 'If ben=mitarbeiter then ben = mitDAO.findenMitBenutzernamePasswort(..)
        ben = mitDAO.findenMitBenutzernamePasswort(pstrBenutzername, pstrPasswort) 'Formulierung einer Verzweigung, 
        'falls sinnlos dann neues Diagramm

        'Rückgabe des angemeldeten Benutzers
        Return ben
    End Function

End Class
