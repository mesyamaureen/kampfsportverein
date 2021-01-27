Public Class Kurs
    Private mdatZeitpunkt As Date
    Private mstrOrt As String
    Private mtraTrainer As Trainer
    Private mbytTeilnehmerzahl As Byte
    Private mstrSchwierigkeitsgrad As String
    Private mstrName As String
    Private mbolVerfuegbarkeit As Boolean
    Private mSportart As Sportart

    Sub New() 'parameterloser Konstruktor
        mdatZeitpunkt = Date.MinValue
        mstrOrt = String.Empty
        mtraTrainer = Nothing
        mbytTeilnehmerzahl = Nothing
        mstrSchwierigkeitsgrad = String.Empty
        mstrName = String.Empty
        mbolVerfuegbarkeit = Boolean.TrueString
        mSportart = Nothing
    End Sub

    Sub New(pdatZeitpunkt As Date, pstrOrt As String, ptraTrainer As Trainer,
            pbytTeilnehmerzahl As Byte, pstrSchwierigkeitsgrad As String,
            pstrName As String, pbolVerfuegbarkeit As Boolean, pSportart As Sportart) 'Konstruktor mit Parameter
        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mtraTrainer = ptraTrainer
        mbytTeilnehmerzahl = pbytTeilnehmerzahl
        mstrSchwierigkeitsgrad = pstrSchwierigkeitsgrad
        mstrName = pstrName
        mbolVerfuegbarkeit = pbolVerfuegbarkeit
        mSportart = pSportart
    End Sub

    Public Property Teilnehmerzahl As Byte
        Get
            Return mbytTeilnehmerzahl
        End Get
        Set(value As Byte)
        End Set
    End Property

    Public Property Zeitpunkt As Date
        Get
            Return mdatZeitpunkt
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Property Ort As String
        Get
            Return mstrOrt
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Schwierigkeitsgrad As String
        Get
            Return mstrSchwierigkeitsgrad
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Trainer As Trainer
        Get
            Return mtraTrainer
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Sportarten As Sportart
        Get
            Return mSportart
        End Get
        Set(value As Sportart)
        End Set
    End Property

    Public Property Verfuegbarkeit As Boolean
        Get
            Return mbolVerfuegbarkeit
        End Get
        Set(value As Boolean)
        End Set
    End Property
End Class