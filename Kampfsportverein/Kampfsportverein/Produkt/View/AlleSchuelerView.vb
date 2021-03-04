Public Class AlleSchuelerView
    Inherits dlgSchueler

    Protected Shared mPresenter As SchuelerAllePresenter
    Sub New(pPresenter As SchuelerAllePresenter)
        MyBase.New
        mPresenter = pPresenter
    End Sub

    Public Property IstSchueler As AlleSchuelerView
        Get
            Return Nothing
        End Get
        Set(value As AlleSchuelerView)
        End Set
    End Property

    Public Sub anzeigenEmailadresse()

    End Sub

    Public Sub anzeigenVorname()

    End Sub

    Public Sub anzeigenName()

    End Sub

    Public Sub anzeigenBelegteKurse()

    End Sub

    Public Sub anzeigenGeburtsdatum()

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'AlleSchuelerView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(580, 423)
        Me.Name = "AlleSchuelerView"
        Me.Text = "gibt dem benutzer ei"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
