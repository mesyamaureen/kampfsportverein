Public Class Trainer
    Inherits Benutzer




    Public Shared Widening Operator CType(v As (String, String, String, String, Integer)) As Trainer
        Throw New NotImplementedException()
    End Operator

    Public Property Schueler As Schueler
        Get
            Return Nothing
        End Get
        Set(value As Schueler)
        End Set
    End Property

    Public Property Kurse As Kurse
        Get
            Return Nothing
        End Get
        Set(value As Kurse)
        End Set
    End Property

End Class
