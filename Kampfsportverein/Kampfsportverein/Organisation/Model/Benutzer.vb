Public Class Benutzer
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mstrVorname As String
    Private mstrName As String
    Private mlngBenutzerID As Long
    Private mlngVersion As Long
    Private mcharTyp As Char

    Sub New()

        mstrBenutzername = String.Empty
        mstrPasswort = String.Empty
        mstrVorname = String.Empty
        mstrName = String.Empty
        mlngBenutzerID = Nothing
        mlngVersion = Nothing
        mcharTyp = Nothing
    End Sub

    Sub New(pstrBenutzername As String, pstrPasswort As String, pstrVorname As String, pstrName As String, plngBenutzerID As Long, plngVersion As Long, pcharTyp As Char)
        mstrBenutzername = pstrBenutzername
        mstrPasswort = pstrPasswort
        mstrVorname = pstrVorname
        mstrName = pstrName
        mlngBenutzerID = plngBenutzerID
        mlngVersion = plngVersion
        mcharTyp = pcharTyp
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

    Public Property Version As Long
        Get
            Return mlngVersion
        End Get
        Set(ByVal value As Long)
        End Set
    End Property

    Public Property Typ As Char
        Get
            Return mcharTyp
        End Get
        Set(ByVal value As Char)
        End Set
    End Property

    Public Sub hinzufuegenKurs(pKurs As Kurs)
        If Not mlstKurs.Contains(pKurs) Then
            mlstKurs.Add(pKurs)
            If IsNothing(pKurs.Benutzer) Then
                pKurs.Benutzer = Me
            End If
        End If
    End Sub

    Public Sub loeschenKurs(pKurs As Kurs)
        If Not mlstKurs.Contains(pKurs) Then
            pKurs.Benutzer = Nothing
            mlstKurs.Remove(pKurs)
        End If
    End Sub
End Class
