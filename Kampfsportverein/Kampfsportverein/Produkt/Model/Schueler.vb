Public Class Schueler
    Private mstrVorname As String
    Private mstrName As String
    Private mstrEMailAdresse As String

    Sub New()
        mstrVorname = String.Empty
        mstrName = String.Empty
        mstrEMailAdresse = String.Empty
    End Sub

    Sub New(pstrVorname As String, pstrName As String, pstrEMailAdresse As String)
        mstrVorname = pstrVorname
        mstrName = pstrName
        mstrEMailAdresse = pstrEMailAdresse
    End Sub

    Public Property EMailAdresse As String
        Get
            Return mstrEMailAdresse
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

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
        End Set
    End Property
End Class
