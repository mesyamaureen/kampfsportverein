Public Class NeuerMitarbeiterPresenter

    Private mNeuerMitarbeiter As Mitarbeiter
    Public mErgebnis As EPresenterErgebnis
    Private mView As NeuerMitarbeiterView
    Private mmitDAO As MitarbeiterDAO

    Sub New(pMitarbeiter As Mitarbeiter)
        mNeuerMitarbeiter = Nothing
        mView = New NeuerMitarbeiterView(Me)
        anzeigenNeuerMitarbeiter()
        mView.ShowDialog()
    End Sub

    Public Property View As NeuerMitarbeiterView
        Get
            Return mView
        End Get
        Set(value As NeuerMitarbeiterView)
        End Set
    End Property

    Public Property Mitarbeiter As Mitarbeiter
        Get
            Return mNeuerMitarbeiter
        End Get
        Set(value As Mitarbeiter)
        End Set
    End Property

    Public Property MitarbeiterDAO As MitarbeiterDAO
        Get
            Return mmitDAO
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub anzeigenNeuerMitarbeiter()
        mView.leeren()
        mView.anzeigen()
        mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
    End Sub

    Public Sub verarbeiteErstellen()
        Dim strVorname As String
        Dim strName As String
        Dim strBenutzername As String
        Dim strPasswort As String

        If String.IsNullOrEmpty(mView.txtVorname.Text) Or String.IsNullOrEmpty(mView.txtName.Text) Or String.IsNullOrEmpty(mView.txtBenutzername.Text) Or String.IsNullOrEmpty(mView.txtPasswort.Text) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            strVorname = mView.txtVorname.Text
            strName = mView.txtName.Text
            strBenutzername = mView.txtBenutzername.Text
            strPasswort = mView.txtPasswort.Text

            If mNeuerMitarbeiter Is Nothing Then
                mNeuerMitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strVorname, strName, 0, 0, "M")
            Else
                mNeuerMitarbeiter.BenutzerID = 0
                mNeuerMitarbeiter.Benutzername = strBenutzername
                mNeuerMitarbeiter.Passwort = strPasswort
                mNeuerMitarbeiter.Vorname = strVorname
                mNeuerMitarbeiter.Name = strName
                mNeuerMitarbeiter.Typ = "M"
            End If
            MitarbeiterDAO.hinzufuegenMitarbeiter(mNeuerMitarbeiter)
            mErgebnis = EPresenterErgebnis.MITARBEITER_ERSTELLEN
            MsgBox("Ein neuer Mitarbeiter wird mit diesen Login-Daten erstellt. BENUTZERNAME: " & strBenutzername & " PASSWORT: " & strPasswort & " .", vbOKOnly)
            mView.Close()
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
