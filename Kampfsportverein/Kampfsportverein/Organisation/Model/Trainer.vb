Public Class Trainer
    Inherits Benutzer

    Private mName As Integer
    Private mVorname As Integer
    Private mPasswort As Integer
    Private mGeburtsdatum As Integer
    Private mBenutzername As Integer
    Private mBenutzerId As Integer

    Sub New()

        MyBase.New()

    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, pintBenutzerID)

    End Sub

End Class
