Public Class Schueler
    Private mstrVorname As String
    Private mstrName As String
    Private mstrEMailAdresse As String
    Private mlngSchuelerIdPk As Long
    Private mlngVersion As Long

    Sub New() 'parameterloser Konstruktor
        mstrVorname = String.Empty
        mstrName = String.Empty
        mstrEMailAdresse = String.Empty
        mlngSchuelerIdPk = 0
        mlngVersion = 0
    End Sub

    Sub New(pstrVorname As String, pstrName As String, pstrEMailAdresse As String, plngSchuelerId As Long, plngVersion As Long) 'Konstruktor mit Parameter
        mstrVorname = pstrVorname
        mstrName = pstrName
        mstrEMailAdresse = pstrEMailAdresse
        mlngSchuelerIdPk = plngSchuelerId
        mlngVersion = plngVersion
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

    Public Property SchuelerIdPk As Long
        Get
            Return mlngSchuelerIdPk
        End Get
        Set(value As Long)
        End Set
    End Property

    Public Property Version As Long
        Get
            Return mlngVersion
        End Get
        Set(value As Long)
        End Set
    End Property

End Class
