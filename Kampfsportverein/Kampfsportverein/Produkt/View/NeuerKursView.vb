Public Class NeuerKursView
    Inherits dlgNeuerKurs

    Sub New(pPresenter As NeuerKursPresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Sub anzeigenKurs()
        Me.txtOrt.Enabled = True
        Me.txtTeilnZahl.Enabled = True
        Me.cmbSportart.Enabled = True
        Me.cmbSchwierigkeit.Enabled = True
        Me.cmbTrainer.Enabled = True
        Me.datKurs.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtOrt.Clear()
        Me.txtTeilnZahl.Clear()
        Me.cmbSportart.Items.Clear()
        Me.cmbSchwierigkeit.Items.Clear()
        Me.cmbTrainer.Items.Clear()
    End Sub
End Class
