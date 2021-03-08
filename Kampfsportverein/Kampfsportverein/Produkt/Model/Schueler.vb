Public Class Schueler
    Private mstrVorname As String
    Private mstrName As String
    Private mstrEMailAdresse As String
    Private mlngSchuelerIdPk As Long
    Private mlngVersion As Long

    Sub New() 'parameterloser Konstruktor
        mlngSchuelerIdPk = Nothing
        mstrName = String.Empty
        mstrEMailAdresse = String.Empty
        mlngVersion = Nothing
    End Sub

    Sub New(plngSchuelerId As Long, pstrVorname As String, pstrName As String, pstrEMailAdresse As String, plngVersion As Long) 'Konstruktor mit Parameter
        mlngSchuelerIdPk = plngSchuelerId
        mstrVorname = pstrVorname
        mstrName = pstrName
        mstrEMailAdresse = pstrEMailAdresse
        mlngVersion = plngVersion
    End Sub

    Public Property EMailAdresse As String
        Get
            Return mstrEMailAdresse
        End Get
        Set(value As String)
            mstrEMailAdresse = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
            mstrVorname = value
        End Set
    End Property

    Public Property SchuelerIdPk As Long
        Get
            Return mlngSchuelerIdPk
        End Get
        Set(value As Long)
            mlngSchuelerIdPk = value
        End Set
    End Property

    Public Property Version As Long
        Get
            Return mlngVersion
        End Get
        Set(value As Long)
            mlngVersion = value
        End Set
    End Property

End Class
