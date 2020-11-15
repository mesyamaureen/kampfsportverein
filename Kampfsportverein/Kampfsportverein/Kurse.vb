Public Class Kurse
    Private mdatZeitpunkt As Date
    Private mstrOrt As String
    Private mstrTrainer As String
    Private mbytTeilnehmerzahl As Byte
    Private mstrSchwierigkeitsgrad As String
    Private mstrName As Integer

    Public Property Teilnehmerzahl As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Zeitpunkt As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Ort As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Schwierigkeitsgrad As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Trainer As Integer
        Get
            Return Nothing
        End Get
        Set(value As Integer)
        End Set
    End Property
End Class
