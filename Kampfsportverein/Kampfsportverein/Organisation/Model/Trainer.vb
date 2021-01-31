Public Class Trainer
    Inherits Benutzer

    Private mName As String
    Private mVorname As String
    Private mPasswort As String
    Private mGeburtsdatum As Date
    Private mBenutzername As String
    Private mBenutzerId As Long

    Sub New()

        MyBase.New()

    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer, plngVersion As Long) ', pcharTyp As Char)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, pintBenutzerID, plngVersion) ', pcharTyp)

    End Sub

End Class
