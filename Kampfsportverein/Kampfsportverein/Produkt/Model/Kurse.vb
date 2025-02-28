﻿Public Class Kurs
    Private mlngIdPk As Long
    Private mdatZeitpunkt As Date
    Private mstrOrt As String
    Private mlngTeilnehmerzahl As Long
    Private mstrSchwierigkeitsgrad As String
    Private mlngSaIdFk As Long
    Private mlngBenIdFk As Long
    Private mlngVersion As Long
    Private mBenutzer As Benutzer
    Private mSportart As Sportart

    Sub New() 'parameterloser Konstruktor
        mlngIdPk -= 1
        mdatZeitpunkt = Date.MinValue
        mstrOrt = String.Empty
        mlngTeilnehmerzahl = Nothing
        mstrSchwierigkeitsgrad = String.Empty
        mlngSaIdFk = Nothing
        mlngBenIdFk = Nothing
        mlngVersion = 0
    End Sub

    Sub New(pdatZeitpunkt As Date, pstrOrt As String, plngTeilnehmerzahl As Long, pstrSchwierigkeitsgrad As String,
            plngSaIdFk As Long, plngBenIdFk As Long) 'Konstruktor mit Parameter
        mlngIdPk -= 1
        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mlngTeilnehmerzahl = plngTeilnehmerzahl
        mstrSchwierigkeitsgrad = pstrSchwierigkeitsgrad
        mlngSaIdFk = plngSaIdFk
        mlngBenIdFk = plngBenIdFk
        mlngVersion = 0
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

    Public Property Sportart As Sportart
        Get
            Return mSportart
        End Get
        Set(value As Sportart)
            mSportart = value
            mSportart.hinzufuegenKurs(Me)
        End Set
    End Property

    Public Property IdPk As Long
        Get
            Return mlngIdPk
        End Get
        Set(ByVal value As Long)
        End Set
    End Property

    Public Property Teilnehmerzahl As Long
        Get
            Return mlngTeilnehmerzahl
        End Get
        Set(ByVal value As Long)
            mlngTeilnehmerzahl = value
        End Set
    End Property

    Public Property Zeitpunkt As Date
        Get
            Return mdatZeitpunkt
        End Get
        Set(ByVal value As Date)
            mdatZeitpunkt = value
        End Set
    End Property

    Public Property Ort As String
        Get
            Return mstrOrt
        End Get
        Set(ByVal value As String)
            mstrOrt = value
        End Set
    End Property

    Public Property Schwierigkeitsgrad As String
        Get
            Return mstrSchwierigkeitsgrad
        End Get
        Set(ByVal value As String)
            mstrSchwierigkeitsgrad = value

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