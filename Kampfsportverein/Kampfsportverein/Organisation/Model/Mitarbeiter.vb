Public Class Mitarbeiter
    Inherits Benutzer


    Private mName As String
    Private mBenutzerId As Long
    Private mBenutzername As String
    Private mPasswort As String
    Private mVorname As String




    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, pintBenutzerID As Integer, plngVersion As Long, pcharTyp As Char)

        MyBase.New(pstrBenutzername, pstrPasswort, pstrVorname, pstrName, pintBenutzerID, plngVersion, pcharTyp)

    End Sub

    Sub New()

        MyBase.New()

    End Sub


    'Public Property Vorname As String
    '    Get
    '        Return mVorname
    '    End Get
    '    Set(value As String)
    '        mVorname = value
    '    End Set
    'End Property

    'Public Property Nachname As String
    '    Get
    '        Return mName
    '    End Get
    '    Set(value As String)
    '        mName = value
    '    End Set
    'End Property

    'Public Property Benutzername As String
    '    Get
    '        Return mBenutzername
    '    End Get
    '    Set(value As String)
    '        mBenutzername = value
    '    End Set
    'End Property

    'Public Property Passwort As String
    '    Get
    '        Return mPasswort
    '    End Get
    '    Set(value As String)
    '        mPasswort = value
    '    End Set
    'End Property

    'Public Property ID As Long
    '    Get
    '        Return mBenutzerId
    '    End Get
    '    Set(value As Long)
    '        mBenutzerId = value
    '    End Set
    'End Property


End Class
