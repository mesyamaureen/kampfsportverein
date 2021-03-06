Public Class NeuerTrainerPresenter
    Private mNeuerTrainer As Trainer
    Public mErgebnis As EPresenterErgebnis
    Private mSitzung As BenutzerSitzung
    Private mView As NeuerTrainerView

    Sub New()
        MyBase.New
        mView = New NeuerTrainerView(Me)
        mNeuerTrainer = New Trainer
        anzeigen()
        mView.ShowDialog()
    End Sub

    Public Property View As NeuerTrainerView
        Get
            Return mView
        End Get
        Set(value As NeuerTrainerView)
        End Set
    End Property

    Public Property NeuerTrainer As Trainer
        Get
            Return mNeuerTrainer
        End Get
        Set(value As Trainer)
        End Set
    End Property

    Public Property Ergebnis As EPresenterErgebnis
        Get
            Return mErgebnis
        End Get
        Set(value As EPresenterErgebnis)
        End Set
    End Property

    Public Sub anzeigen()
        mView.leeren()
        mView.anzeigen()
    End Sub

    Public Sub verarbeiteErstellen(pTrainer As Trainer)
        If String.IsNullOrEmpty(pTrainer.Vorname) Or String.IsNullOrEmpty(pTrainer.Name) Or
String.IsNullOrEmpty(pTrainer.Benutzername) Or String.IsNullOrEmpty(pTrainer.Passwort) Then
            MsgBox("Alle Felder müssen befüllt sein!", vbOKOnly)
        Else
            mNeuerTrainer.Vorname = pTrainer.Vorname
            mNeuerTrainer.Name = pTrainer.Name
            mNeuerTrainer.Benutzername = pTrainer.Benutzername
            mNeuerTrainer.Passwort = pTrainer.Passwort

            mNeuerTrainer.Version = pTrainer.Version + 1

            Dim Ergebnis As Long
            Ergebnis = TrainerDAO.hinzufuegenTrainer(pTrainer)
            If Ergebnis = mNeuerTrainer.BenutzerID Then
                mErgebnis = EPresenterErgebnis.SPORTART_EINZELN
                mView.Close()
            Else
                MsgBox("Es ist ein Fehler beim Speichern aufgetreten", vbOKOnly)
            End If
        End If
    End Sub

    Public Sub verarbeiteAbbrechen()
        mView.Close()
    End Sub
End Class
