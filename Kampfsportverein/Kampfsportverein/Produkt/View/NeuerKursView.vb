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
        Me.txtSchwierigkeit.Enabled = True
        Me.cmbTrainer.Enabled = True
        Me.datKurs.Enabled = True
    End Sub

    Public Sub leeren()
        Me.txtOrt.Clear()
        Me.txtTeilnZahl.Clear()
        Me.cmbSportart.Items.Clear()
        Me.txtSchwierigkeit.Clear()
        Me.cmbTrainer.Items.Clear()
    End Sub

    Public Sub befuellenSaName(strSaName As String)
        Dim i As Integer = Me.cmbSportart.Items.Count
        Me.cmbSportart.Items.Insert(i, strSaName)
    End Sub

    Public Sub befuellenTrainer(strTrainerName As String)
        Dim i As Integer = Me.cmbTrainer.Items.Count
        Me.cmbTrainer.Items.Insert(i, strTrainerName)
    End Sub
End Class
