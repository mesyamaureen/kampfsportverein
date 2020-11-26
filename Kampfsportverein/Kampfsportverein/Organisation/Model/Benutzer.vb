Public Class Benutzer
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mstrVorname As String
    Private mstrName As String
    Private mlngBenutzerID As Long

    Sub New()

        mstrBenutzername = String.Empty
        mstrPasswort = String.Empty
        mstrVorname = String.Empty
        mstrName = String.Empty
        mlngBenutzerID = Nothing

    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer)
        mstrBenutzername = pstrBenutzername
        mstrPasswort = pstrPasswort
        mstrVorname = pstrVorname
        mstrName = pstrName
        mlngBenutzerID = pintBenutzerID

    End Sub



    Public Property Benutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public Property Passwort As String
        Get
            Return mstrPasswort
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public Property BenutzerID As Long
        Get
            Return mlngBenutzerID
        End Get
        Set(ByVal value As Long)
        End Set
    End Property

End Class
