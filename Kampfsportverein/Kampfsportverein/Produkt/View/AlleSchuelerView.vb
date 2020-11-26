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
End Class
