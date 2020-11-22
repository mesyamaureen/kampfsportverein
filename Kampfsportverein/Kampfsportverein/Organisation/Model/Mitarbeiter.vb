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

    Public Property Name As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Geburtsdatum As Date
        Get
            Return Nothing
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Property BenutzerId As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Benutzername As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Passwort As String
        Get
            Return Nothing
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property TrainerAllePresenter As TrainerAllePresenter
        Get
            Return Nothing
        End Get
        Set(value As TrainerAllePresenter)
        End Set
    End Property

    Public Property Trainer As Trainer
        Get
            Return Nothing
        End Get
        Set(value As Trainer)
        End Set
    End Property
End Class
