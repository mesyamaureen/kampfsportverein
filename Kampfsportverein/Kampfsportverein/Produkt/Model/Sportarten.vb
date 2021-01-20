Public Class Sportart
    Private mstrName As String
    Private mstrHerkunftsland As String
    Private mstrZielgruppe As String
    Private mbyteMindestalter As Byte
    Private mlngVersion As Long

    Sub New()
        mstrName = String.Empty
        mstrHerkunftsland = String.Empty
        mstrZielgruppe = String.Empty
        mbyteMindestalter = String.Empty
        mlngVersion = 0
    End Sub

    Sub New(pstrName As String, pstrHerkunftsland As String, pstrZielgruppe As String, pbyteMindestalter As Byte, plngVersion As Long)
        mstrName = pstrName
        mstrHerkunftsland = pstrHerkunftsland
        mstrZielgruppe = pstrZielgruppe
        mbyteMindestalter = pbyteMindestalter
        mlngVersion = plngVersion
    End Sub

    Public Property Mindestalter As Byte
        Get
            Return mbyteMindestalter
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Herkunftsland As String
        Get
            Return mstrHerkunftsland
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

    Public Property Zielgruppe As String
        Get
            Return mstrZielgruppe
        End Get
        Set(value As String)
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
