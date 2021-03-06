Imports Kampfsportvereinverwaltung
Public Class SportartenPresenter
    Inherits frmHauptfensterMit

    Public mErgebnis As EPresenterErgebnis
    Public Shared mSpor As Sportart
    Private mView As SportartenEinzelView
    Private mlstKurse As List(Of Kurs)
    Private mmitDAO As MitarbeiterDAO
    Private mtraDAO As TrainerDAO

    Sub New(pSpor As Sportart)
        mSpor = pSpor
        mView = New SportartenEinzelView(Me)
        mView.anzeigenSportart(mSpor)
        verarbeiteKursUebersichtAnzeigen()
        anzeigeKursAlle()
        mView.ShowDialog()
    End Sub

    Sub New()
        mView = New SportartenEinzelView(Me)
        mSpor = New Sportart
        mView.ShowDialog()
    End Sub

    Public Property View As SportartenEinzelView
        Get
            Return Nothing
        End Get
        Set(value As SportartenEinzelView)
        End Set
    End Property

    Public Property Ergebnis As SportartenPresenter
        Get
            Return Nothing
        End Get
        Set(value As SportartenPresenter)
        End Set
    End Property

    Public Property SportartenAlle As Sportart
        Get
            Return Nothing
        End Get
        Set(value As Sportart)
        End Set
    End Property

    Public Property ListeKurs As List(Of Kurs)
        Get
            Return mlstKurse
        End Get
        Set(value As List(Of Kurs))
        End Set
    End Property

    Public Property MitarbeiterDAO As MitarbeiterDAO
        Get
            Return mmitDAO
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property

    Public Property TrainerDAO As TrainerDAO
        Get
            Return mtraDAO
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property


    Public Sub verarbeiteClose(pSpor As Sportart)
        'Prüfschleife ob Dinge gespeichert werden sollen

        If mSpor.Name = pSpor.Name And mSpor.Herkunftsland = pSpor.Herkunftsland And
            mSpor.Mindestalter = pSpor.Mindestalter And mSpor.Zielgruppe = pSpor.Zielgruppe Then

            mView.Close()
        Else
            If MessageBox.Show("Wollen Sie die eingegebenen Änderungen abspeichern?", "Speichern", MessageBoxButtons.YesNo) _
            = Windows.Forms.DialogResult.Yes Then
                verarbeiteSpeichern(pSpor)
            Else
                mView.Close()
            End If
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        'Prüfschleife ob abgebrochen werde soll - Yes No

        If MessageBox.Show("Wollen Sie wirklich abbrechen?", "Abbrechen", MessageBoxButtons.OKCancel) _
        = Windows.Forms.DialogResult.OK Then
            mView.Close()
        End If

    End Sub

    Public Sub verarbeiteSpeichern(pSpor As Sportart)

        If String.IsNullOrEmpty(pSpor.Name) Or String.IsNullOrEmpty(pSpor.Herkunftsland) Or
        String.IsNullOrEmpty(pSpor.Mindestalter) Or String.IsNullOrEmpty(pSpor.Zielgruppe) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            mSpor.Name = pSpor.Name
            mSpor.Herkunftsland = pSpor.Herkunftsland
            mSpor.Zielgruppe = pSpor.Zielgruppe
            mSpor.Mindestalter = pSpor.Mindestalter

            mSpor.Version = pSpor.Version + 1

            Dim Ergebnis As Long
            Ergebnis = MitarbeiterDAO.speichern(mSpor)
            If Ergebnis = mSpor.ID Then
                mErgebnis = EPresenterErgebnis.SPORTART_EINZELN
                mView.Close()
            Else
                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
            End If
        End If

    End Sub

    Public Sub anzeigeKursAlle()
        mView.leeren()
        mView.anzeigenKursuebersicht()
        mtraDAO = DAOFactory.Instanz.TrainerDAO
        Dim ausgewaehlteTra As Trainer
        For Each kurs As Kurs In mlstKurse
            ausgewaehlteTra = mtraDAO.findenTrainerId(kurs.BenIdFk)
            mView.hinzufuegenZeileKurs(kurs.IdPk, kurs.Zeitpunkt, kurs.Ort, ausgewaehlteTra.Name, kurs.Schwierigkeitsgrad)
        Next
    End Sub


    Public Sub verarbeiteKursUebersichtAnzeigen() 'plngSportartIdPk As Long)
        mErgebnis = EPresenterErgebnis.KURS_ANZEIGEN
        mmitDAO = DAOFactory.Instanz.MitarbeiterDAO
        'Dim ausgewaehlteSA As Sportart
        'ausgewaehlteSA = mmitDAO.findeSportart(plngSportartIdPk)
        mlstKurse = mmitDAO.findenAlleSaKurse(mSpor)
        anzeigeKursAlle()
    End Sub
End Class
