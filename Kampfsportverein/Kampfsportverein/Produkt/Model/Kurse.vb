Public Class Kurs
    Private mlngIdPk As Long
    Private mdatZeitpunkt As Date
    Private mstrOrt As String
    Private mbytTeilnehmerzahl As Byte
    Private mstrSchwierigkeitsgrad As String
    Private mlngSaIdFk As Long
    Private mlngBenIdFk As Long
    Private mlngVersion As Long
    Private mBenutzer As Benutzer

    Sub New() 'parameterloser Konstruktor
        mlngIdPk = Nothing
        mdatZeitpunkt = Date.MinValue
        mstrOrt = String.Empty
        mbytTeilnehmerzahl = Nothing
        mstrSchwierigkeitsgrad = String.Empty
        mlngSaIdFk = Nothing
        mlngBenIdFk = Nothing
        mlngVersion = Nothing
    End Sub

    Sub New(plngIdPk As Long, pdatZeitpunkt As Date, pstrOrt As String, pbytTeilnehmerzahl As Byte, pstrSchwierigkeitsgrad As String,
            plngSaIdFk As Long, plngBenIdFk As Long, plngVersion As Long) 'Konstruktor mit Parameter
        mlngIdPk = plngIdPk
        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mbytTeilnehmerzahl = pbytTeilnehmerzahl
        mstrSchwierigkeitsgrad = pstrSchwierigkeitsgrad
        mlngSaIdFk = plngSaIdFk
        mlngBenIdFk = plngBenIdFk
        mlngVersion = plngVersion
    End Sub

    Public Property Benutzer As Benutzer
        Get
            Return mBenutzer
        End Get
        Set(value As Benutzer)
            mBenutzer = value
            mBenutzer.hinzufuegenKurs(Me)
        End Set
    End Property

    Public Property IdPk As Long
        Get
            Return mlngIdPk
        End Get
        Set(ByVal value As Long)
        End Set
    End Property

    Public Property Teilnehmerzahl As Byte
        Get
            Return mbytTeilnehmerzahl
        End Get
        Set(ByVal value As Byte)
        End Set
    End Property

    Public Property Zeitpunkt As Date
        Get
            Return mdatZeitpunkt
        End Get
        Set(ByVal value As Date)
        End Set
    End Property

    Public Property Ort As String
        Get
            Return mstrOrt
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public Property Schwierigkeitsgrad As String
        Get
            Return mstrSchwierigkeitsgrad
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Public Property SaIdFk As Long
        Get
            Return mlngSaIdFk
        End Get
        Set(ByVal value As Long)
        End Set
    End Property

    Public Property BenIdFk As Long
        Get
            Return mlngBenIdFk
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


End Class