Public Class TrainerAlleView
    Inherits frmHauptfensterTrainer

    Private mbolTrainer As Boolean
    Sub New(pPresenter As TrainerAllePresenter)

        MyBase.New
        mPresenter = pPresenter

    End Sub

    Public Property lstTrainer As TrainerAlleView
        Get
            Return Nothing
        End Get
        Set(value As TrainerAlleView)
        End Set
    End Property

    Public Sub anzeigenKurse()
        Me.lstSchueler.Visible = False
        Me.lstKurse.Visible = True
        Me.btnNeueSchueler.Enabled = False
    End Sub

    Public Sub anzeigenSchueler()
        Me.lstKurse.Visible = False
        Me.lstSchueler.Visible = True
        Me.btnNeueSchueler.Enabled = True
    End Sub

    Public Sub anzeigenKursUebersicht(plngKursID As Long, pdatKurs As Date, plngSaIdFk As Long,
                                plngBenIdFk As Long)
        Dim kurszeile As ListViewItem
        kurszeile = Me.lstKurse.Items.Add(plngKursID)
        With kurszeile.SubItems
            .Add(pdatKurs)
            .Add(plngSaIdFk)
            .Add(plngBenIdFk)
        End With
    End Sub

    Public Sub anzeigenSchuelerUebersicht(plngSchuelerID As Long, pstrName As String,
                                        pstrVorname As String)
        Dim schuelerzeile As ListViewItem
        schuelerzeile = Me.lstSchueler.Items.Add(plngSchuelerID)
        With schuelerzeile.SubItems
            .Add(pstrName)
            .Add(pstrVorname)
        End With
    End Sub

    Public Sub leeren()
        'Kurse leeren
        Me.lstKurse.Items.Clear()
        'Schüler leeren
        Me.lstSchueler.Items.Clear()
    End Sub

    Public Sub anzeigenNeueAnmeldung()

    End Sub

    Public Sub anzeigenBearbeiten()

    End Sub

    Public Sub anzeigenBeenden()

    End Sub


End Class
