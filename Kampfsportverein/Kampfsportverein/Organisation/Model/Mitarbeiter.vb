Public Class Mitarbeiter
    Inherits Benutzer

    Public Property Kurse As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Kurse)
        End Set
    End Property

    Public Property Sportarten As Sportarten
        Get
            Return Nothing
        End Get
        Set(value As Sportarten)
        End Set
    End Property

    Public Property Schueler As Schueler
        Get
            Return Nothing
        End Get
        Set(value As Schueler)
        End Set
    End Property
End Class
