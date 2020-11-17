Public Class Benutzer
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mstrVorname As String
    Private mstrName As String
    Private mintBenutzerID As Integer

    Sub New()

        mstrBenutzername = String.Empty
        mstrPasswort = String.Empty
        mstrVorname = String.Empty
        mstrName = String.Empty
        mintBenutzerID = Nothing
    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer)
        mstrBenutzername = pstrBenutzername
        mstrPasswort = pstrPasswort
        mstrVorname = pstrVorname
        mstrName = pstrName
        mintBenutzerID = pintBenutzerID

    End Sub

    Public Property BenutzerID As Integer
        Get
            Return mintBenutzerID
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Benutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Passwort As String
        Get
            Return mstrPasswort
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
        End Set
    End Property
End Class
