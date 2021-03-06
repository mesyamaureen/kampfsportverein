Public Class KursView
    Inherits dlgKursEinzeln

    Private mbolAktiv As Boolean
    Protected Shared mPresenter As KursPresenter
    'Konstruktor
    Sub New(pPresenter As KursPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub
    'Eigenschaften
    Public Property IstKurs As KursView
        Get
            Return Nothing
        End Get
        Set(value As KursView)
        End Set
    End Property
    'Methoden
    'Initialisierungen 

    Public Sub anzeigenKurs()
        Me.txtSportart.Enabled = False
        Me.txtOrt.Enabled = True
        Me.txtSchwierigkeit.Enabled = True
        Me.txtTeilnZahl.Enabled = True
        Me.txtTrainer.Enabled = False
        Me.txtZeitpunkt.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtSportart.Clear()
        Me.txtZeitpunkt.Clear()
        Me.txtOrt.Clear()
        Me.txtTeilnZahl.Clear()
        Me.txtSchwierigkeit.Clear()
        Me.txtTrainer.Clear()
    End Sub
End Class
