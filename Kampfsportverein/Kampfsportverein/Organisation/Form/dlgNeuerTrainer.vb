﻿Public Class dlgNeuerTrainer
    Public mPresenter As NeuerTrainerPresenter

    Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Public Property Presenter As NeuerTrainerPresenter
        Get
            Return Nothing
        End Get
        Set(value As NeuerTrainerPresenter)
        End Set
    End Property

    Private Sub btnErstellen_Click(sender As Object, e As EventArgs) Handles btnErstellen.Click
        'mPresenter.verarbeiteErstellen()
    End Sub
End Class