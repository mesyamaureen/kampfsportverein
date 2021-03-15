Public Class NeueSchuelerPresenter
    Private mView As NeueSchuelerView
    Public mErgebnis As EPresenterErgebnis
    Private mSchueler As Schueler
    Private mtraDAO As TrainerDAO

    Sub New(pSchueler As Schueler)
        mSchueler = Nothing
        mView = New NeueSchuelerView(Me)
        anzeigenNeueSchueler()
        mView.ShowDialog()
    End Sub

    Public Property View As NeueSchuelerView
        Get
            Return mView
        End Get
        Set(value As NeueSchuelerView)
        End Set
    End Property

    Public Property Schueler As Schueler
        Get
            Return mSchueler
        End Get
        Set(value As Schueler)
        End Set
    End Property

    Public Property TrainerDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Sub anzeigenNeueSchueler()
        mView.leeren()
        mView.anzeigenSchueler()
        mtraDAO = DAOFactory.Instanz.TrainerDAO
    End Sub

    Public Sub verarbeiteErstellen()
        Dim strName As String
        Dim strVorname As String
        Dim strEmail As String

        If String.IsNullOrEmpty(mView.txtName.Text) Or String.IsNullOrEmpty(mView.txtVorname.Text) Or String.IsNullOrEmpty(mView.txtEmail.Text) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            strName = mView.txtName.Text
            strVorname = mView.txtVorname.Text
            strEmail = mView.txtEmail.Text

            If mSchueler Is Nothing Then
                mSchueler = New Schueler(0, strVorname, strName, strEmail, 0)
            Else
                mSchueler.SchuelerIdPk = 0
                mSchueler.Vorname = strVorname
                mSchueler.Name = strName
                mSchueler.EMailAdresse = strEmail
            End If
            mtraDAO.hinzufuegen(mSchueler)
            mErgebnis = EPresenterErgebnis.MITGLIEDER_ERSTELLEN
            mView.Close()
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        mErgebnis = EPresenterErgebnis.ABBRECHEN
        mView.Close()
    End Sub
End Class
