Public Class Trainer
    Inherits Benutzer


    Sub New()

        MyBase.New()

    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, pintBenutzerID)

    End Sub

    '  Public Shared Widening Operator CType(v As (String, String, String, String, Integer)) As Trainer
    ' Throw New NotImplementedException()
    ' End Operator

    Public Property Schueler As Schueler
        Get
            Return Nothing
        End Get
        Set(value As Schueler)
        End Set
    End Property

    Public Property Kurse As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Kurse)
        End Set
    End Property
End Class
