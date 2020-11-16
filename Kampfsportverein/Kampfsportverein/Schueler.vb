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
        mstrVorname = pstrEMailAdresse
        mstrName = pstrEMailAdresse
        mstrEMailAdresse = pstrEMailAdresse
    End Sub

    Public Property EMailAdresse As String
        Get
            Return mstrEMailAdresse
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Name As Integer
        Get
            Return mstrName
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Vorname As Integer
        Get
            Return mstrVorname
        End Get
        Set(value As Integer)
        End Set
    End Property
End Class
