Public Class DAOFactory
    'Attribut vom eigenen Typ des Singletons
    Private Shared mInstanz As DAOFactory
    Private mAktuelleFactory As MitarbeiterDAO

    'privater Konstruktor des Singletons
    Private Sub New()
        mAktuelleFactory = Nothing
    End Sub
    'implementierung eines Singletons
    Public Shared ReadOnly Property Instanz As DAOFactory
        Get
            If IsNothing(mInstanz) Then
                mInstanz = New DAOFactory
            End If
            Return mInstanz

        End Get
    End Property

    Public Property TrainerDAO As TrainerDAO
        Get
            Return Nothing
        End Get
        Set(value As TrainerDAO)
        End Set
    End Property

    Public Property MitarbeiterDAO As MitarbeiterDAO
        Get
            Return Nothing
        End Get
        Set(value As MitarbeiterDAO)
        End Set
    End Property
End Class
