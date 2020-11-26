Public Class Mitarbeiter
    Inherits Benutzer

    Private mKurse As Integer
    Private mName As Integer
    Private mGeburtsdatum As Integer
    Private mBenutzerId As Integer
    Private mBenutzername As Integer
    Private mPasswort As Integer
    Private mVorname As Integer


    ' Public Shared Widening Operator CType(v As (String, String, String, String, Integer)) As Mitarbeiter
    'Throw New NotImplementedException()
    'End Operator

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, pintBenutzerID)

    End Sub

    Sub New()

        MyBase.New()

    End Sub
End Class
