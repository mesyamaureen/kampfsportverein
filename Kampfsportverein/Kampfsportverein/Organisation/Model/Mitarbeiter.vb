Public Class Mitarbeiter
    Inherits Benutzer

    Public Shared Widening Operator CType(v As (String, String, String, String, Integer)) As Mitarbeiter
        Throw New NotImplementedException()
    End Operator
End Class
