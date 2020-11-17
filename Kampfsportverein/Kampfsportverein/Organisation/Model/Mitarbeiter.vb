Public Class Mitarbeiter
    Inherits Benutzer


    Public Shared Widening Operator CType(v As (String, String, String, String, Integer)) As Mitarbeiter
        Throw New NotImplementedException()
    End Operator

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
