Imports Kampfsportvereinverwaltung
Public Class SportartenPresenter
    Inherits frmHauptfensterMit

    Public mErgebnis As EPresenterErgebnis
    Public Shared mSpor As Sportart
    Private mView As SportartenEinzelView

    Sub New(pSpor As Sportart)

        mSpor = pSpor
        mView = New SportartenEinzelView(Me)
        mView.anzeigenSportart(mSpor)
        mView.ShowDialog()

    End Sub

    Sub New()

        mView = New SportartenEinzelView(Me)
        mView.ShowDialog()
        mSpor = New Sportart

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


    Public Sub verarbeiteClose(pSpor As Sportart)
        'Prüfschleife ob Dinge gespeichert werden sollen

        If mSpor.Name = pSpor.Name And mSpor.Herkunftsland = pSpor.Herkunftsland And
            mSpor.Mindestalter = pSpor.Mindestalter And mSpor.Zielgruppe = pSpor.Zielgruppe Then

            Me.Close()
        Else
            If MessageBox.Show("Wollen Sie die eingegebenen Änderungen abspeichern?", "Speichern", MessageBoxButtons.YesNo) _
            = Windows.Forms.DialogResult.Yes Then
                verarbeiteSpeichern(pSpor)
            Else
                Me.Close()
            End If
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        'Prüfschleife ob abgebrochen werde soll - Yes No

        If MessageBox.Show("Wollen Sie wirklich abbrechen?", "Abbrechen", MessageBoxButtons.YesNo) _
        = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Public Sub verarbeiteSpeichern(pSpor As Sportart)
        If String.IsNullOrEmpty(pSpor.Name) Or String.IsNullOrEmpty(pSpor.Herkunftsland) Or
        String.IsNullOrEmpty(pSpor.Mindestalter) Or String.IsNullOrEmpty(pSpor.Zielgruppe) Then 'Kontrolle ob Byte NullOrEmpty Kann Fehlerquelle Sein
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
                mErgebnis = EPresenterErgebnis.SPEICHERN
                Me.Close()
            Else
                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
            End If
        End If

    End Sub

End Class
