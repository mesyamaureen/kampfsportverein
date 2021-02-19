Public Class Mitarbeiter
    Inherits Benutzer

    Private mKurse As String
    Private mName As String
    Private mBenutzerId As Long
    Private mBenutzername As String
    Private mPasswort As String
    Private mVorname As String




    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer, plngVersion As Long) ', pcharTyp As Char)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, pintBenutzerID, plngVersion) ', pcharTyp)

    End Sub

    Sub New()

        MyBase.New()

    End Sub
End Class
