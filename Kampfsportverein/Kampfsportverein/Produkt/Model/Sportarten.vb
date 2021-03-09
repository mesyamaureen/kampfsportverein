Public Class Sportart
    Private mlngIdPk As Long
    Private mstrName As String
    Private mstrHerkunftsland As String
    Private mstrZielgruppe As String
    Private mbyteMindestalter As Byte
    Private mlngVersion As Long
    Private mKurs As Kurs

    Sub New() 'Parameterloser Konstruktor
        mlngIdPk = -1
        mstrName = String.Empty
        mstrHerkunftsland = String.Empty
        mstrZielgruppe = String.Empty
        mbyteMindestalter = 0
        mlngVersion = 0
    End Sub

    Sub New(plngIdPk As Long, pstrName As String, pstrHerkunftsland As String,
            pstrZielgruppe As String, pbyteMindestalter As Byte,
            plngVersion As Long) 'Konstruktor mit Parameter
        mlngIdPk = plngIdPk
        mstrName = pstrName
        mstrHerkunftsland = pstrHerkunftsland
        mstrZielgruppe = pstrZielgruppe
        mbyteMindestalter = pbyteMindestalter
        mlngVersion = plngVersion
    End Sub

    Public Property ID As Long
        Get
            Return mlngIdPk
        End Get
        Set(value As Long)
        End Set
    End Property
    Public Property Mindestalter As Byte
        Get
            Return mbyteMindestalter
        End Get
        Set(value As Byte)
            mbyteMindestalter = value
        End Set
    End Property

    Public Property Herkunftsland As String
        Get
            Return mstrHerkunftsland
        End Get
        Set(value As String)
            mstrHerkunftsland = value
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

    Public Property Zielgruppe As String
        Get
            Return mstrZielgruppe
        End Get
        Set(value As String)
            mstrZielgruppe = value
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

    Public Sub hinzufuegenKurs(pKurs As Kurs)
        If Not mlstKurs.Contains(pKurs) Then
            mlstKurs.Add(pKurs)
            If IsNothing(pKurs.Sportart) Then
                pKurs.Sportart = Me
            End If
        End If
    End Sub

End Class
