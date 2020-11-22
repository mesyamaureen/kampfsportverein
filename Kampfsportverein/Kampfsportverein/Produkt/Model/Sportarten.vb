Public Class Sportart
    Private mstrName As String
    Private mstrHerkunftsland As String
    Private mstrZielgruppe As String
    Private mbyteMindestalter As Byte

    Sub New()
        mstrName = String.Empty
        mstrHerkunftsland = String.Empty
        mstrZielgruppe = String.Empty
        mbyteMindestalter = String.Empty
    End Sub

    Sub New(pstrName As String, pstrHerkunftsland As String, pstrZielgruppe As String, pbyteMindestalter As Byte)
        mstrName = pstrName
        mstrHerkunftsland = pstrHerkunftsland
        mstrZielgruppe = pstrZielgruppe
        mbyteMindestalter = pbyteMindestalter
    End Sub

    Public Property Mindestalter As Integer
        Get
            Return mbyteMindestalter
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Herkunftsland As Integer
        Get
            Return mstrHerkunftsland
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Name As Integer
        Get
            Return mstrName
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public Property Zielgruppe As Integer
        Get
            Return mstrZielgruppe
        End Get
        Set(value As Integer)
        End Set
    End Property
End Class
