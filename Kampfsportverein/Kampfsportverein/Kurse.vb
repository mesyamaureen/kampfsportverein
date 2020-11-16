Public Class Kurse
    Private mdatZeitpunkt As Date
    Private mstrOrt As String
    Private mtraTrainer As Trainer
    Private mbytTeilnehmerzahl As Byte
    Private mstrSchwierigkeitsgrad As String
    Private mstrName As Integer

    Sub New()
        mdatZeitpunkt = Date.MinValue
        mstrOrt = String.Empty
        mtraTrainer = Nothing
        mbytTeilnehmerzahl = Nothing
        mstrSchwierigkeitsgrad = String.Empty
        mstrName = String.Empty
    End Sub

    Sub New(pdatZeitpunkt As Date, pstrOrt As String, ptraTrainer As Trainer, pbytTeilnehmerzahl As Byte, pstrSchwierigkeitsgrad As String, pstrName As Integer)
        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mtraTrainer = ptraTrainer
        mbytTeilnehmerzahl = pbytTeilnehmerzahl
        mstrSchwierigkeitsgrad = pstrSchwierigkeitsgrad
        mstrName = pstrName
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

End Class
